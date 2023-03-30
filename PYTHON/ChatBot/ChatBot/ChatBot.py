
# -*- coding: utf-8 -*-
"""
Created on Fri Jul 29 18:05:41 2022

@author: antonio
"""
import os
import openai
import sys
import time

try:
    openai.api_key = os.getenv("OPENAI_API_KEY")
    f = open(sys.argv[2], "r")
    conversation = f.read() 
    f.close()

    conversation += "\nDani:"
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