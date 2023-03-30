
# -*- coding: utf-8 -*-
"""
Created on Thu Jan 19 07:11:05 2023

@author: antonio
"""

import cv2
import os
import face_recognition

# Codificar los rostros extraidos
imageFacesPath = "images/faces"
image_rec = "images/faces2/dx.jpg"

facesEncodings = []
facesNames = []
for file_name in os.listdir(imageFacesPath):
     image = cv2.imread(imageFacesPath + "/" + file_name)
     image = cv2.cvtColor(image, cv2.COLOR_BGR2RGB)

     f_coding = face_recognition.face_encodings(image, known_face_locations=[(0, 150, 150, 0)])[0]
     facesEncodings.append(f_coding)
     facesNames.append(file_name.split(".")[0])

#print(facesEncodings)
#print(facesNames)

# Detector facial
faceClassif = cv2.CascadeClassifier("haarcascades/haarcascade_frontalface_default.xml")

frame = cv2.imread(image_rec)

orig = frame.copy()

print("detectando")
faces = faceClassif.detectMultiScale(frame, 1.1, 5)

for (x, y, w, h) in faces:
    print("detec")
    face = orig[y:y + h, x:x + w]
    face = cv2.cvtColor(face, cv2.COLOR_BGR2RGB)
    actual_face_encoding = face_recognition.face_encodings(face, known_face_locations=[(0, w, h, 0)])[0]
    result = face_recognition.compare_faces(facesEncodings, actual_face_encoding)
    #print(result)
    if True in result:
        index = result.index(True)
        name = facesNames[index]
        color = (125, 220, 0)
    else:
        name = "Desconocido"
        color = (50, 50, 255)

    cv2.rectangle(frame, (x, y + h), (x + w, y + h + 30), color, -1)
    cv2.rectangle(frame, (x, y), (x + w, y + h), color, 2)
    cv2.putText(frame, name, (x, y + h + 25), 2, 1, (255, 255, 255), 2, cv2.LINE_AA)

cv2.imshow("Frame", frame)
cv2.waitKey(0)
cv2.destroyAllWindows()
