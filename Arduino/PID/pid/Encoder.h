
class Encoder
{
  long tiempo_revolucion;
  long tiempo_revolucion_anterior;
  long tiempo_marca;
  byte contador_marcas;
  float rev_min;
  long numero_marcas;
  
  public:
  void Inicializar();
  void CalcularRPM();
  void ComprobarRPM_0();
  long TiempoTranscurrido(long TiempoActual, long TiempoAnterior);
};

