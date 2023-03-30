# -*- coding: utf-8 -*-

from asyncio.windows_events import NULL
import cv2
import os
import openai
import sys
import time
import face_recognition
import mediapipe as mp
import numpy as np
from math import acos, degrees
import random

# Codificar los rostros extraidos
imageFacesPath = "images/faces"

facesEncodings = []
facesNames = []
faceClassif = []
video = False
salir = False
cap = NULL

def dir_defecto(directorio):
    try:
        os.chdir(directorio)
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))
    print(":RET:dir_defecto")
    sys.stdout.flush()

def iniciar_video(num_camara, mostrar_video):
    global cap
    try:
        #mostrar_video = cv2.CAP_DSHOW
        cap = cv2.VideoCapture(num_camara, mostrar_video)
        video = True
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))
    print(":RET:iniciar_video")
    sys.stdout.flush()

def parar_video():
    global cap
    cap.release()
    cv2.destroyAllWindows()
    print(":RET:parar_video")

#------------------------------------------------------------------------------------------------------------
def recuperar_rostro(fimg):
    # Detector facial
    faceClassif = cv2.CascadeClassifier("haarcascades/haarcascade_frontalface_default.xml")

    count = 0
    image = cv2.imread("images/input_images/" + fimg)
    faces = faceClassif.detectMultiScale(image, 1.1, 5)
    for (x, y, w, h) in faces:
        #cv2.rectangle(image, (x, y), (x + w, y + h), (0, 255, 0), 2)
        face = image[y:y + h, x:x + w]
        face = cv2.resize(face, (150, 150))
        cv2.imwrite("images/input_images/faces/" + fimg, face)
        count += 1
    print(":RET:recuperar_rostro")
    sys.stdout.flush()

#------------------------------------------------------------------------------------------------------------
def cargar_rostros():
    try:
        global facesEncodings
        global facesNames
        global faceClassif
        for file_name in os.listdir(imageFacesPath):
             image = cv2.imread(imageFacesPath + "/" + file_name)
             image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)

             f_coding = face_recognition.face_encodings(image, known_face_locations=[(0, 150, 150, 0)])[0]
             facesEncodings.append(f_coding)
             facesNames.append(file_name.split(".")[0])
         # Detector facial. Antes hay que llamar a cargar_rostros()
        faceClassif = cv2.CascadeClassifier("haarcascades/haarcascade_frontalface_default.xml")
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))
    print(":RET:cargar_rostros")
    sys.stdout.flush()
#------------------------------------------------------------------------------------------------------------
def reconocer_rostros(fichero_imagen, salida):
    global cap
    global facesEncodings
    global facesNames
    global faceClassif
    deteccion = False
    try:
        #Reconocer rostros
        if fichero_imagen == "":
            ret, frame = cap.read()
            if ret == False:
                print(":LOG:RET:reconocer_rostros.cap.read()")
                sys.stdout.flush()
                return
        else:
            frame = cv2.imread(fichero_imagen)

        while True:
            orig = frame.copy()
            faces = faceClassif.detectMultiScale(frame, 1.1, 5)

            for (x, y, w, h) in faces:
                deteccion = True
                face = orig[y:y + h, x:x + w]
                face = cv2.cvtColor(face, cv2.COLOR_BGR2RGB)
                actual_face_encoding = face_recognition.face_encodings(face, known_face_locations=[(0, w, h, 0)])[0]
                result = face_recognition.compare_faces(facesEncodings, actual_face_encoding)

                if True in result:
                    index = result.index(True)
                    name = facesNames[index]
                    color = (125, 220, 0)
                else:
                    name = "Desconocido"
                    color = (50, 50, 255)
                posicion = (x, y, w, h)
                print(":VAL:"+ name + ":", end="")
                print(posicion)
                sys.stdout.flush()

                cv2.rectangle(frame, (x, y + h), (x + w, y + h + 30), color, -1)
                cv2.rectangle(frame, (x, y), (x + w, y + h), color, 2)
                cv2.putText(frame, name, (x, y + h + 25), 2, 1, (255, 255, 255), 2, cv2.LINE_AA)   
            if deteccion:
                cv2.imwrite(fichero_imagen, frame)
            if salida:
                cv2.imshow("Frame", frame)
            if fichero_imagen != "":
                break
            if salir:
                break
        cv2.destroyAllWindows()
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))

    print(":RET:reconocer_rostros")
    sys.stdout.flush()

#------------------------------------------------------------------------------------------------------------
def reconocer_objetos(fichero_imagen, salida):
    try:
        # ----------- READ DNN MODEL -----------
        # Model architecture
        prototxt = "model/MobileNetSSD_deploy.prototxt.txt"
        # Weights
        model = "model/MobileNetSSD_deploy.caffemodel"
        # Class labels
        classes = {0:"el fondo", 1:"un avion", 2:"una bicicleta",
                  3:"un pajaro", 4:"un barco",
                  5:"una botella", 6:"un autobus",
                  7:"un coche", 8:"un gato",
                  9:"una silla", 10:"una vaca",
                  11:"un comedor", 12:"un perro",
                  13:"un caballo", 14:"una moto",
                  15:"una persona", 16:"una planta",
                  17:"una oveja", 18:"un sofa",
                  19:"un tren", 20:"una television"}

        # Load the model
        net = cv2.dnn.readNetFromCaffe(prototxt, model)

        # ----------- READ THE IMAGE AND PREPROCESSING -----------
        image = cv2.imread(fichero_imagen)
        height, width, _ = image.shape
        image_resized = cv2.resize(image, (300, 300))

        # Create a blob
        blob = cv2.dnn.blobFromImage(image_resized, 0.007843, (300, 300), (127.5, 127.5, 127.5))
        #print("blob.shape:", blob.shape)

        # ----------- DETECTIONS AND PREDICTIONS -----------
        net.setInput(blob)
        detections = net.forward()

        for detection in detections[0][0]:
             if detection[2] > 0.45:
                  label = classes[detection[1]]
                  print(":VAL:", label, end = ":")
                  for d in detection:
                      print(d, end = ",")
                  print("0")
                  box = detection[3:7] * [width, height, width, height]
                  x_start, y_start, x_end, y_end = int(box[0]), int(box[1]), int(box[2]), int(box[3])

                  cv2.rectangle(image, (x_start, y_start), (x_end, y_end), (0, 255, 0), 2)
                  cv2.putText(image, "Conf: {:.2f}".format(detection[2] * 100), (x_start, y_start - 5), 1, 1.2, (255, 0, 0), 2)
                  cv2.putText(image, label, (x_start, y_start - 25), 1, 1.2, (255, 0, 0), 2)
        cv2.imwrite(fichero_imagen, image)
        if salida:
            cv2.imshow("Image", image)
            cv2.waitKey(0)
            cv2.destroyAllWindows()
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))

    print(":RET:reconocer_rostros")
    sys.stdout.flush()

#------------------------------------------------------------------------------------------------------------
def gpt(entrada, modelo, recordar):
    try:
        openai.api_key = os.getenv("OPENAI_API_KEY")
        if recordar:
            f = open("GPT3/entrada.txt", "r")
            conversation = f.read()+"Humano:"+entrada
            f.close()
        else:
            f = open("GPT3/configuracion.txt", "r")
            conversation = f.read()
            f.close()
            conversation=conversation+"Humano:"+entrada


        conversation += "\nIA:"
        response = openai.Completion.create(
            engine = modelo,
            prompt=conversation,
            temperature = 0.9,
            max_tokens = 150,
            top_p = 1,
            frequency_penalty=0,
            presence_penalty=0.6,
            stop=["\n","Humano:","IA:"]
            )
     
        answer = response.choices[0].text.strip()
        if recordar:
            f = open("GPT3/entrada.txt", "a")
            f.write("Humano:" + entrada + "\nIA:" + answer +"\n" ) 
            f.close()
        print(":VAL:"+ answer)
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))
    print(":RET:gpt")
    sys.stdout.flush()
    return

def palm_centroid(coordinates_list):
     coordinates = np.array(coordinates_list)
     centroid = np.mean(coordinates, axis=0)
     centroid = int(centroid[0]), int(centroid[1])
     return centroid

def fingers_up_down(hand_results, thumb_points, palm_points, fingertips_points, finger_base_points, width, height, frame):
     fingers = None
     coordinates_thumb = []
     coordinates_palm = []
     coordinates_ft = []
     coordinates_fb = []
     for hand_landmarks in hand_results.multi_hand_landmarks:
          for index in thumb_points:
               x = int(hand_landmarks.landmark[index].x * width)
               y = int(hand_landmarks.landmark[index].y * height)
               coordinates_thumb.append([x, y])
          
          for index in palm_points:
               x = int(hand_landmarks.landmark[index].x * width)
               y = int(hand_landmarks.landmark[index].y * height)
               coordinates_palm.append([x, y])
          
          for index in fingertips_points:
               x = int(hand_landmarks.landmark[index].x * width)
               y = int(hand_landmarks.landmark[index].y * height)
               coordinates_ft.append([x, y])
          
          for index in finger_base_points:
               x = int(hand_landmarks.landmark[index].x * width)
               y = int(hand_landmarks.landmark[index].y * height)
               coordinates_fb.append([x, y])
          ##########################
          # Pulgar
          p1 = np.array(coordinates_thumb[0])
          p2 = np.array(coordinates_thumb[1])
          p3 = np.array(coordinates_thumb[2])
          l1 = np.linalg.norm(p2 - p3)
          l2 = np.linalg.norm(p1 - p3)
          l3 = np.linalg.norm(p1 - p2)
          # Calcular el ángulo
          to_angle = (l1**2 + l3**2 - l2**2) / (2 * l1 * l3)
          if int(to_angle) == -1:
               angle = 180
          else:
               angle = degrees(acos(to_angle))
          thumb_finger = np.array(False)
          if angle > 150:
               thumb_finger = np.array(True)
          
          ################################
          # Índice, medio, anular y meñique
          nx, ny = palm_centroid(coordinates_palm)
          cv2.circle(frame, (nx, ny), 3, (0, 255, 0), 2)
          coordinates_centroid = np.array([nx, ny])
          coordinates_ft = np.array(coordinates_ft)
          coordinates_fb = np.array(coordinates_fb)
          # Distancias
          d_centrid_ft = np.linalg.norm(coordinates_centroid - coordinates_ft, axis=1)
          d_centrid_fb = np.linalg.norm(coordinates_centroid - coordinates_fb, axis=1)
          dif = d_centrid_ft - d_centrid_fb
          fingers = dif > 0
          fingers = np.append(thumb_finger, fingers)
          mp_drawing.draw_landmarks(
               frame,
               hand_landmarks,
               mp_hands.HAND_CONNECTIONS,
               mp_drawing_styles.get_default_hand_landmarks_style(),
               mp_drawing_styles.get_default_hand_connections_style())

     return fingers

def profundidad(fimgL, fimgR):
    imgL = cv2.imread(fimgL,0)
    imgL = cv2.resize(imgL,(600,600))

    imgR = cv2.imread(fimgR,0)
    imgR = cv2.resize(imgR,(600,600))

    # Setting parameters for StereoSGBM algorithm
    minDisparity = 0
    numDisparities = 64
    blockSize = 8
    disp12MaxDiff = 1
    uniquenessRatio = 10
    speckleWindowSize = 10
    speckleRange = 8

    # Creating an object of StereoSGBM algorithm
    stereo = cv2.StereoSGBM_create(minDisparity = minDisparity,
        numDisparities = numDisparities,
        blockSize = blockSize,
        disp12MaxDiff = disp12MaxDiff,
        uniquenessRatio = uniquenessRatio,
        speckleWindowSize = speckleWindowSize,
        speckleRange = speckleRange
    )

    # Calculating disparith using the StereoSGBM algorithm
    disp = stereo.compute(imgL, imgR).astype(np.float32)

    # Calculating disparith using the StereoSGBM algorithm
    disp = cv2.normalize(disp,0,255,cv2.NORM_MINMAX)
    
    # Displaying the disparity map
    cv2.imwrite("images/frame.jpg",disp)
    
    print(":RET:profundidad")
    sys.stdout.flush()
    return

def leer_jugada(imagen):
    try:
        with mp_hands.Hands(
            model_complexity=1,
            max_num_hands=1,
            min_detection_confidence=0.5,
            min_tracking_confidence=0.5) as hands:

            frame = cv2.imread(imagen)
            frame = cv2.flip(frame, 1)
            height, width, _ = frame.shape
            frame_rgb = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
            results = hands.process(frame_rgb)
            jugada="NO_DETEC"
            if results.multi_hand_landmarks:
                fingers = fingers_up_down(results, thumb_points, palm_points, fingertips_points, finger_base_points, width, height, frame )
                #print(":LOG:fingers:", fingers)
                if not False in (fingers == PIEDRA):
                    jugada = "0"
                elif not False in (fingers == PAPEL):
                    jugada = "1"
                elif not False in (fingers == TIJERAS):
                    jugada = "2"
                else:
                    jugada="NO_DETECTADA"
            cv2.imwrite("images/frame.jpg", frame)
            print(":VAL:"+jugada)
            print(":RET:leer_jugada")
    except Exception as ex:
        print(":ERR: Ha habido una excepcion", type(ex))

    print(":RET:leer_jugada")
    return 

def leer_dict(fichero):
    try:
        mensajes = [] #lista
        with open(fichero) as fmensajes:
            for linea in fmensajes:
                entrada = linea.split(",")
                mensaje = dict()
                for elemento in entrada:
                    clave = elemento.split(":")
                    mensaje[clave[0]] = clave[1]
                mensajes.append(mensaje)
    except Exception as ex:
        print(":ERR:leer_dict: Ha habido una excepcion", ex)
    return mensajes

def chat_GPT(entrada,recordar):
    try:
        entrada_dict = {"role":"user","content":entrada}
        fichero = "ChatGPT/mensajes.txt"
        openai.api_key = os.getenv("OPENAI_API_KEY")
        mensajes = leer_dict(fichero)
        mensajes.append(entrada_dict)
        print(mensajes)
        response = openai.ChatCompletion.create(
                model="gpt-3.5-turbo",
                messages=mensajes)
        answer = response['choices'][0]['message']['content']
        print(":VAL:"+ answer)
        if (recordar):
            fmensajes = open(fichero, "a")
            fmensajes.write("role:user,content:"+entrada+"\n")
            fmensajes.write("role:assistant,content:"+answer+"\n")
            fmensajes.close()
    except Exception as ex:
        print(":ERR:chat_GPT: Ha habido una excepcion", ex)
    print(":RET:gpt")
    sys.stdout.flush()
    return
    
def Hola():
    print(":RET:Hola")

# ------------------------------------------------ MAIN ------------------------------------------------------
mp_drawing = mp.solutions.drawing_utils
mp_drawing_styles = mp.solutions.drawing_styles
mp_hands = mp.solutions.hands
# Pulgar
thumb_points = [1, 2, 4]
# Índice, medio, anular y meñique
palm_points = [0, 1, 2, 5, 9, 13, 17]
fingertips_points = [8, 12, 16, 20]
finger_base_points =[6, 10, 14, 18]
# FINGERS COMBINATIONS
TO_ACTIVATE = np.array([True, False, False, False, False])
# Piedra, papel, tijeras
PIEDRA = np.array([False, False, False, False, False])
PAPEL = np.array([True, True, True, True, True])
TIJERAS = np.array([False, True, True, False, False])

print(":INIT:")
try:
    while True:
        comando = input()   
        if comando != "" :
            #print(":LOG:"+comando)
            sys.stdout.flush()
            exec(comando)
except Exception as ex:
    print(":ERR:INIT: Ha habido una excepcion", type(ex))
    sys.stdout.flush()