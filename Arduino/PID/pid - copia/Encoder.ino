#include <Encoder.h>

#define MARCAS_REVOLUCION 8

void Encoder::Inicializar()
{
  tiempo_revolucion_anterior = 0;
  tiempo_revolucion = 0;
  tiempo_marca = 0;
  contador_marcas = 0;
}

void Encoder::CalcularRPM()
{
    long tiempo;
    
    if (tiempo_revolucion == 0)
    {
      tiempo_revolucion = micros();
      tiempo_marca = millis();
      contador_marcas = 0;
    }
    else
    {
      tiempo = micros();
      contador_marcas++;
      if (contador_marcas < MARCAS_REVOLUCION)
      {
        if (tiempo_revolucion_anterior == 0) //No hay información actual de rpm
        {
          //Calculamos las revoluciones si no hay información de rpm
          rev_min = ((float)contador_marcas/MARCAS_REVOLUCION)/((float)TiempoTranscurrido(tiempo, tiempo_revolucion)/(float)1000000/60);
        }
        else
        {
          rev_min = ((float)(contador_marcas+MARCAS_REVOLUCION)/MARCAS_REVOLUCION)/((float)TiempoTranscurrido(tiempo, tiempo_revolucion_anterior)/(float)1000000/60);
          //rev_min = ((float)1/MARCAS_REVOLUCION)/((float)TiempoTranscurrido(micros(), tiempo_marca)/(float)1000000/60);
        }
      }
      else //Hemos contabilizado 8 marcas = 1 revolución completa
      {
        rev_min = (float)1/((float)TiempoTranscurrido(tiempo, tiempo_revolucion)/(float)1000000/60);
        tiempo_revolucion_anterior = tiempo_revolucion;
        tiempo_revolucion = tiempo;
        contador_marcas = 0;
      }
      tiempo_marca = tiempo;
    }
}

void Encoder::ComprobarRPM_0()
{}

long Encoder::TiempoTranscurrido(long TiempoActual, long TiempoAnterior)
{
  return TiempoActual-TiempoAnterior;
}

