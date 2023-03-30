
# -*- coding: utf-8 -*-
"""
Created on Fri Jul 29 18:05:41 2022

@author: antonio
openai api completions.create -m davinci:ft-casa-2023-01-14-18-32-51 -p <YOUR_PROMPT>
"""


import os
import openai
import sys
import time

def GTP3():
    try:
        openai.api_key = os.getenv("OPENAI_API_KEY")
        f = open(sys.argv[2], "r")
        conversation = f.read() 
        f.close()

        conversation += "\AI:"
        response = openai.Completion.create(
            engine = sys.argv[1],
            prompt=conversation,
            temperature = 0.9,
            max_tokens = 150,
            top_p = 1,
            frequency_penalty=0,
            presence_penalty=0.6,
            stop=["\n","Humano:","AI:"]
            )
     
        answer = response.choices[0].text.strip()
        print("AI:"+ answer +"\n")
        f = open(sys.argv[3], "w")
        f.write(answer) 
        f.close()
    except Exception as ex:
        print("Ha habido una excepcion", type(ex))
        time.sleep(4)
    return

def chat_GPT_prueba():
    print("Inicio")
    openai.api_key = os.getenv("OPENAI_API_KEY")
    response = openai.ChatCompletion.create(
          model="gpt-3.5-turbo",
          messages=[
                {"role": "system", "content": "Eres un robot de servicio. Te llamas dani, vives en Pontevedra."},
                {"role": "user", "content": "como te llamas?"},
                {"role": "assistant", "content": "Me llamo dani"},
                {"role": "user", "content": "como te llamas?"}
            ]
        )
    print(response['choices'][0]['message']['content'])

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

def chat_GPT(entrada):
    try:
        entrada_dict = {"role":"user","content":entrada}
        fichero = "ChatGPT/mensajes.txt"
        openai.api_key = os.getenv("OPENAI_API_KEY")
        mensajes = leer_dict(fichero)
        mensajes.append(entrada_dict)
        print(mensajes)
        response = openai.ChatCompletion.create(
              model="gpt-3.5-turbo",
              messages=mensajes
            )
        answer = response['choices'][0]['message']['content']
        print(":VAL:"+ answer)
        fmensajes = open(fichero, "a")
        fmensajes.write("role:user,content:"+entrada+"\n")
        fmensajes.write("role:assistant,content:"+answer+"\n")
        fmensajes.close()
    except Exception as ex:
        print(":ERR:chat_GPT: Ha habido una excepcion", ex)
    print(":RET:gpt")
    sys.stdout.flush()
    return

# MAIN ------------------------------
chat_GPT("como te llamas?")



