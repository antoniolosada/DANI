#define SAPPO_H

#define MAX_EMISORES_ULTRASONIDOS   12
#define MAX_BALIZAS					2
#define NUM_BALIZAS_RECUPERAR 2
#define MAX_REINTENTOS_ORIENTACION	3
#define EMISION_CONJUNTA -1
#define TIMEOUT_MEDIDA_US 45
#define MIN_TIMEOUT_MS_US 34
#define MAX_DISTANCIA_US_CM 1400

#define KALMAN1 			1
#define KALMAN2 			2
#define MEDIA				4
#define EMA					8
#define FIR					16
#define MEDIA_EVOLUTIVA		32
#define MEDIA_COMPENSADA	64

#define SALIDA 1
#define SALIDA_COMPLETA 2

#define LOG_MEDIDAS		1
#define LOG_LECTURAS	2

#define OP_INICIAR 1
#define OP_CONSULTAR 2

#define ID_OPERACION_MEDIDA 1
#define ID_ROBOT_RODI 1
struct sPulsos {
  long pulsos;
  long Ultimo_ms;
  long Tiempo;
};
struct sOdometria {
public:
  sPulsos Contador[2];
  long pulsos_totales;
  long Ultimo_ms_total;
  byte ultimo_valor;
  long tiempo_total;
};

struct sBaliza {
  long codigo;
  int id_baliza;
  int id_habitacion;
  int X;
  int Y;
  int Z; // Altura de los sensores desde el suelo
  int grados_cobertura;
  int numero_sensores;
  int direccion;

public:
  void print();
};


struct sMedida {
  byte codigo;
  float tiempo_local;
  float tiempo_vuelo;
  float tiempo_vuelo_ajustado; // Ajustado con el control de altura entre baliza
                               // y movil
  int num_sensor;
};

struct sMedidas {
  byte codigo;
  byte id_baliza;
  List<sMedida> Medida;
  int numero_medidas;
  long MedidasCorrectas;
  int FallosTotales;
  int FallosAcumulados;
  long tiempo_vida;
  long tiempo_ultima_medida;
  long numero_ultima_medida;
public:
  void Inicializar() {
    numero_medidas = 1;
    MedidasCorrectas = 1;
    FallosAcumulados = 0;
    FallosTotales = 0;
  }
};

struct sProcesoMedida {
  byte BalizasSeleccionadas[2];
  byte ErroresBalizasSeleccionadas[2];
  byte num_balizas;
  byte errores_acumulados;
  long numero_total_medidas;

  sProcesoMedida() {
    for (int i = 0; i < 2; i++)
      BalizasSeleccionadas[2] = ErroresBalizasSeleccionadas[2] = 0;
    num_balizas = 0;
    numero_total_medidas = 0;
    errores_acumulados = 0;
  }
};

struct sPaquete {
  byte id_baliza;
  long tiempo;
  byte num_sensor;
  long tiempo_local;
};

struct sPaqueteRF433 {
  byte id_robot;
  byte operacion;
};

