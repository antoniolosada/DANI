'
'
'
'


Option Strict Off
Option Explicit On
Imports Artinsoft.VB6.Gui
Imports Artinsoft.VB6.Utils
Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO.Ports
Imports System.Threading
Imports System.Speech.Recognition
Imports System.Speech.Recognition.SrgsGrammar
Imports System.Speech.Synthesis
Imports System.Speech
Imports System.Data.OleDb
Imports System.Configuration
Imports System.Diagnostics
Imports AIMLGUI

Imports AForge.Controls
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge
Imports AForge.Imaging
Imports AForge.Imaging.Filters
Imports AForge.Math.Geometry


Imports HaarCascadeClassifer
Imports HaarCascadeClassifer.HaarDetector
Imports WebCam_Capture
Imports _09_HTTPLISTENER_WEBSERVER
Imports System.Xml

Public Class frmControl
    Inherits System.Windows.Forms.Form
    'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
    'Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
    'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
    'Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer


#Region "variables"
    Private Const MOUSEEVENTF_LEFTDOWN As Integer = &H2S
    Private Const MOUSEEVENTF_LEFTUP As Integer = &H4S
    Private Const MOUSEEVENTF_MIDDLEDOWN As Integer = &H20S
    Private Const MOUSEEVENTF_MIDDLEUP As Integer = &H40S
    Private Const MOUSEEVENTF_MOVE As Integer = &H1S
    Private Const MOUSEEVENTF_RIGHTDOWN As Integer = &H8S
    Private Const MOUSEEVENTF_RIGHTUP As Integer = &H10S

    Private Const SERVO_DIR As Integer = -1
    Private Const MAX_LONGITUD_TEXTO_LOG = 12000
#Region "Video"
    Dim FuenteDeVideoD As VideoCaptureDevice = Nothing
    Dim FuenteDeVideoI As VideoCaptureDevice = Nothing
    Dim DispositivosDeVideo As FilterInfoCollection
    Dim VideoResolucion As Integer = 0
    Dim ExistenDispositivos As Boolean = False

    Dim v3D As Vista3D = New Vista3D()

#End Region
    Const ESPERA_COM As Integer = 50
    Const ESPERA_COM_CICLO As Integer = 300

    Const LIMITE_CONTROL As Integer = 10

    Const VALOR_DISTANCIA_CM_MIN As Integer = 4
    Const VALOR_DISTANCIA_CM_MAX As Integer = 100
    Const VALOR_OBJETO_NO_DETECTADO As Integer = -1

    Const VALOR_SERVO_ROT_ALTO As Integer = 175
    Const VALOR_SERVO_ROT_BAJO As Integer = 5
    Const VALOR_SERVO_ROT_MEDIO As Integer = 90
    Const VALOR_SERVO_ROT_MARGEN_MEDIO As Integer = 70

    Const SERVO_POS_MARGEN As Integer = 10
    Const SERVO_POS_INI As Integer = 2

    Dim ESPERA_TRANSICION_SERVO As Integer = 30
    Const INC_DIR As Integer = 5

    'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
    'Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)

    Dim aDist(4) As TextBox

    Shared static_frase As String = ""
    Shared _continue As Boolean
    Shared _serialPort As SerialPort
    Shared tbComShared As TextBox
    Shared sCadShared As String = ""
    Shared sfrmControl As frmControl
    Dim readThread As Thread

    Const MIN_SERVO_POS As Integer = 16
    Const MAX_SERVO_POS As Integer = 25

    Const MAX_SENSORES_DISTANCIA = 4
    Const NUM_SERVOS_ROT = 6
    Const MAX_SENSOR_ARTICULACIONES = 6
    Const NUM_SERVOS_MANOS = 12

    Const FIN_ARRAY As Integer = 99

    Const GRABAR_MODIFICADOS As Integer = 0
    Const GRABAR_ASIGNADOS As Integer = 1
    Const GRABAR_GRABADOS As Integer = 2
    Const GRABAR_TODOS As Integer = 3

    Const ZONA_SUPERIOR As Integer = 1
    Const ZONA_INFERIOR As Integer = 0
    Const TODAS_LAS_ZONAS As Integer = 2

    Const SIN_CAMBIO As Integer = &HC0FFFF
    Const CAMBIO As Integer = &HC0C0FF
    Const ASIGNADO As Integer = &HFFFFC0
    Const SIN_ASIGNAR As Integer = -1


    Const CADERA_SUP_DER As Integer = 0
    Const CADERA_GIRO_DER As Integer = 1
    Const RODILLA_SUP_DER As Integer = 2
    Const RODILLA_INF_DER As Integer = 3
    Const TOBILLO_DER As Integer = 4
    Const PIE_DER As Integer = 5

    Const CADERA_SUP_IZQ As Integer = 6
    Const CADERA_GIRO_IZQ As Integer = 7
    Const RODILLA_SUP_IZQ As Integer = 8
    Const RODILLA_INF_IZQ As Integer = 9
    Const TOBILLO_IZQ As Integer = 10
    Const PIE_IZQ As Integer = 11

    Const CADERA_CENTRAL As Integer = 12

    Const HOMBRO_CUERPO_DER As Integer = 13
    Const HOMBRO_BRAZO_DER As Integer = 14
    Const BICEPS_DER As Integer = 15
    Const ANTEBRAZO_DER As Integer = 16

    Const HOMBRO_CUERPO_IZQ As Integer = 17
    Const HOMBRO_BRAZO_IZQ As Integer = 18
    Const BICEPS_IZQ As Integer = 19
    Const ANTEBRAZO_IZQ As Integer = 20

    Const CABEZA_DER_IZQ As Integer = 21
    Const CABEZA_ADELANTE_ATRAS As Integer = 22

    '--------------------------

    Const EVENT_CHANGE As Integer = 0
    Const EVENT_SCROLL As Integer = 1

    Const PARADO As Integer = 0
    Const ARRANCADO As Integer = 1
    Const PAUSA As Integer = 2
    Const MAX_LEN_COM As Integer = 10000

    Const GRADOS As Integer = 0
    Const MS As Integer = 1

    Const ENVIO_CONTINUO As Integer = 0
    Const ENVIO_SECUENCIA As Integer = 1

    Const MOV_INDEPENDIENTE As Integer = 0
    Const MOV_SOLIDARIO_ESPEJO As Integer = 1
    Const MOV_SOLIDARIO_COMPLEJO As Integer = 2
    Const ESPERA_COM_INSTRUCCIONES As Integer = 100

    Dim giEstado As Integer
    Dim giServo As Integer

    Dim Imagen As Bitmap
    Dim DETECTOR As HaarDetector

    Dim PararComunicaciones As Boolean = False

    Dim MyoArriba As Integer = 0
    Dim MyoAbajo As Integer = 0
    Dim MyoDerecha As Integer = 0
    Dim MyoIzquierda As Integer = 0

    Public aToleranciaServos() As Integer = {10, 10, 10, 10, 10, 10}

    Public voz As New Speech.Synthesis.SpeechSynthesizer
    Private configXml As New XmlDocument
    Private PosicionBrazos(7) As Integer
    Private Arranque As Boolean = True
    Private DatosRecibidosArduino As Boolean = False



    Enum RASPER
        boca = 14
        guinada = 15
        cabeceo = 16

        hombro_cuerpo_derecho = 18
        hombro_brazo_derecho = 19
        biceps_derecho = 20

        mano_derecha_pulgar = 2
        mano_derecha_indice = 3
        mano_derecha_medio = 4
        mano_derecha_anular = 5
        mano_derecha_menique = 6
        mano_derecha_muneca = 7

        hombro_cuerpo_iquierdo = 22
        hombro_brazo_iquierdo = 23
        biceps_izquierdo = 24

        mano_iquierda_pulgar = 8
        mano_iquierda_indice = 9
        mano_iquierda_medio = 10
        mano_iquierda_anular = 11
        mano_iquierda_menique = 12
        mano_iquierda_muneca = 13

        direccion = 26
        avance = 27

    End Enum
    Structure sPosParada
        Dim iNumServo() As Integer
        Dim iPosServo() As Integer
    End Structure

    Const NUM_MAX_POS_PARADAS As Integer = 10
    Dim aPosParada(NUM_MAX_POS_PARADAS) As sPosParada

    Const NUM_MAX_POS_MANOS As Integer = 10
    Dim aPosManos(NUM_MAX_POS_MANOS) As sPosParada

#End Region


    Dim Mov As DetectarMovimiento = New DetectarMovimiento()
    Private Structure tOperacion
        Dim Numero As Short
        Dim Dif As Short
    End Structure
    Private Structure tServo
        <Microsoft.VisualBasic.VBFixedArray(10)> _
        Dim aServo() As tOperacion
        Public Shared Function CreateInstance() As tServo
            Dim result As New tServo()
            ReDim result.aServo(10)
            Return result
        End Function
    End Structure
    'Sincronizaciones simples en espejo
    Dim aSinc() As tServo = ArraysHelper.InitializeArray(Of tServo)(21)
    'Sincronizaciones múltiples
    Dim aSincMultiple() As tServo = ArraysHelper.InitializeArray(Of tServo)(21)
    Dim frmServerWEB As ServidorWeb = New ServidorWeb()

    Dim EscalaVRServoCabeceoMin As Integer
    Dim EscalaVRServoCabeceoMax As Integer
    Dim EscalaVRServoGuinadaMin As Integer
    Dim EscalaVRServoGuinadaMax As Integer

    Dim EscalaVRGafasCabeceoMin As Integer
    Dim EscalaVRGafasCabeceoMax As Integer
    Dim EscalaVRGafasGuinadaMin As Integer
    Dim EscalaVRGafasGuinadaMax As Integer

    Dim m_Servo As Integer = MIN_SERVO_POS
    Dim m_Sensor As Integer = 0


    'UPGRADE_NOTE: (2010) barServo.Change was changed from an event to a procedure. More Information: http://www.vbtonet.com/ewis/ewi2010.aspx
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If

                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        ReLoadForm(False)
    End Sub

    'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
    Private Sub Form_Load()

        Dim iEstado As Integer = PARADO

        For i As Integer = 0 To 13
            tbNumServo(i).Text = CStr(i + 2)
            barServo(i).Value = 0
            tbValServo(i).Text = CStr(0)
        Next

        For i As Integer = 0 To 9
            tbNumServoPos(i).Text = CStr(i + 16)
            barServoPos(i).Value = 0
            tbValServoPos(i).Text = CStr(0)
        Next

        'com.CommPort = 1
        cbPuerto.SelectedIndex = 0
        cbModoEnvio.SelectedIndex = 0

        cbUnidad.SelectedIndex = GRADOS

        cbGrabar.SelectedIndex = GRABAR_MODIFICADOS
        cbZonaMov.SelectedIndex = TODAS_LAS_ZONAS

        GenerarSincronizaciones()

        CargarCfgControlServos()

        cbPuerto.Text = RecCfg("COM", "puerto")

        Dim XMLDoc As New Xml.XmlDocument
        XMLDoc.LoadXml(HaarCascadeClassifer.My.Resources.haarcascade_frontalface_alt)
        DETECTOR = New HaarDetector(XMLDoc)

        EscalaVRServoCabeceoMin = RecCfg("escala_vr_servo_cabeceo_min")
        EscalaVRServoCabeceoMax = RecCfg("escala_vr_servo_cabeceo_max")
        EscalaVRServoGuinadaMin = RecCfg("escala_vr_servo_guinada_min")
        EscalaVRServoGuinadaMax = RecCfg("escala_vr_servo_guinada_max")

        EscalaVRGafasCabeceoMin = RecCfg("escala_vr_gafas_cabeceo_min")
        EscalaVRGafasCabeceoMax = RecCfg("escala_vr_gafas_cabeceo_max")
        EscalaVRGafasGuinadaMin = RecCfg("escala_vr_gafas_guinada_min")
        EscalaVRGafasGuinadaMax = RecCfg("escala_vr_gafas_guinada_max")

        MyoArriba = RecCfg("myo_arriba")
        MyoAbajo = RecCfg("myo_abajo")
        MyoDerecha = RecCfg("myo_derecha")
        MyoIzquierda = RecCfg("myo_izquierda")

        Vista3D.FramesSegundo = Convert.ToInt16(RecCfg("frames_segundo_diferido"))
        Vista3D.ImagenX = Convert.ToInt16(RecCfg("recorte_imagen_x"))
        Vista3D.ImagenY = Convert.ToInt16(RecCfg("recorte_imagen_y"))
        Vista3D.ImagenAlto = Convert.ToInt16(RecCfg("recorte_imagen_alto"))
        Vista3D.ImagenAncho = Convert.ToInt16(RecCfg("recorte_imagen_ancho"))

        AddHandler voz.SpeakProgress, AddressOf Me.synth_SpeakProgress
        AddHandler voz.SpeakCompleted, AddressOf Me.synth_SpeakCompleted
        'voz.Speak("El sistema está preparado")

        sfrmControl = Me
    End Sub
    'UPGRADE_WARNING: (2065) HScrollBar event barServo.Change has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2065.aspx
    Private Sub barServo_Change(ByRef Index As Integer, ByVal newScrollValue As Integer)
        Dim iPos As Integer = Conversion.Val(tbValServo(Index).Text)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        If StringsHelper.ToDoubleSafe(tbValServo(Index).Text) <> barServo(Index).Value Then
            tbValServo(Index).BackColor = ColorTranslator.FromOle(CAMBIO)
        End If

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        tbValServo(Index).Text = CStr(barServo(Index).Value)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        EnviarCambio(Index, barServo(Index).Value - iPos, EVENT_CHANGE)
    End Sub

    Private Sub barServo_Enter(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _barServo_9.Enter, _barServo_8.Enter, _barServo_7.Enter, _barServo_6.Enter, _barServo_10.Enter, _barServo_11.Enter, _barServo_5.Enter, _barServo_4.Enter, _barServo_0.Enter, _barServo_1.Enter, _barServo_2.Enter, _barServo_3.Enter
        Dim Index As Integer = Array.IndexOf(barServo, eventSender)
        tbMin(Index).BackColor = Color.Lime
        tbMax(Index).BackColor = Color.Lime

        giServo = Index
    End Sub

    Private Sub barServo_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _barServo_9.Leave, _barServo_8.Leave, _barServo_7.Leave, _barServo_6.Leave, _barServo_10.Leave, _barServo_11.Leave, _barServo_5.Leave, _barServo_4.Leave, _barServo_0.Leave, _barServo_1.Leave, _barServo_2.Leave, _barServo_3.Leave
        Dim Index As Integer = Array.IndexOf(barServo, eventSender)
        tbMin(Index).BackColor = Color.White
        tbMax(Index).BackColor = Color.White

    End Sub

    'UPGRADE_NOTE: (2010) barServo.Scroll was changed from an event to a procedure. More Information: http://www.vbtonet.com/ewis/ewi2010.aspx
    Private Sub barServo_Scroll_Renamed(ByRef Index As Integer, ByVal newScrollValue As Integer)
        Dim iPos As Integer = Conversion.Val(tbValServo(Index).Text)
        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        tbValServo(Index).Text = CStr(barServo(Index).Value)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        EnviarCambio(Index, barServo(Index).Value - iPos, EVENT_SCROLL)
    End Sub


    Private Sub cbUnidad_SelectedIndexChanged(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cbUnidad.SelectedIndexChanged

        If cbUnidad.SelectedIndex = GRADOS Then
            'Establecer límites de cada servo
            EstablecerLimites(GRADOS)

            PosicionInicial(GRADOS)
        Else
            For i As Integer = 0 To 22
                barServo(i).Minimum = 500
                barServo(i).Maximum = (2300 + barServo(i).LargeChange - 1)
            Next
        End If
    End Sub





    Private Sub cmdGenerarArduino_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdGenerarArduino.Click
        frmArduino.DefInstance.ShowDialog()
    End Sub




    Private Sub cmdArranque_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdArranque.Click
        ConectarArduino()
    End Sub

    Private Sub ConectarArduino()
        Try
            tbCom.Text = ""
            If giEstado = PARADO Then
                giEstado = ARRANCADO
                picEstado.BackColor = Color.Lime
                ' Create a new SerialPort object with default settings.
                _serialPort = New SerialPort()

                ' Allow the user to set the appropriate properties.
                _serialPort.PortName = cbPuerto.Text
                _serialPort.BaudRate = 115200
                _serialPort.Parity = Parity.None
                _serialPort.DataBits = 8
                _serialPort.StopBits = StopBits.One
                _serialPort.Handshake = Handshake.None

                ' Set the read/write timeouts
                _serialPort.ReadTimeout = 500
                _serialPort.WriteTimeout = 500

                _serialPort.Open()
                _continue = True


                AddHandler _serialPort.DataReceived, AddressOf Me.DataReceivedHandler

                tmrLeerDatosArduino.Enabled = True


                '//ALG
                'While Not DatosRecibidosArduino
                '    Thread.Sleep(1000)
                'End While
                InicializarValoresArduino()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message.ToString())
        End Try
    End Sub

    Private Sub InicializarValoresArduino()
        'Posición inicial firmware todos los servos
        EnviarCodigo("i", 0)
        'Cambiamos la variable Debug para comprobar reseteos 
        EnviarCadena("I", "R")

        'Si está activa la opción se establece la posición inicial del interface de control
        If (chkEnviarPosIniServosControl.Checked) Then EnviarPosicionParadaServos()
        If (RecCfg("INI_control_pos") = "S") Then
            'Activar control de posición
            EnviarCodigo("o", 1)
            tbControlPosOn.BackColor = Color.Red
        End If
        If (RecCfg("INI_control_limites_parada") = "S") Then
            'Activar control de límites de parada
            EnviarCodigo("L", 1)
            tbControlPosOn.BackColor = Color.Red
        End If
    End Sub
    Private Sub BucleSolicitudDatos(ByRef Servo As Integer, ByRef Sensor As Integer)

        SolicitarTodosLosSensores()
        Application.DoEvents()
        System.Threading.Thread.Sleep(ESPERA_COM)
        If sCadShared <> "" Then
            RecDatos(sCadShared)
            ActualizarDatos(sCadShared)
            sCadShared = ""
        End If

    End Sub
    Sub EnviarPosicionParadaServos()
        For i As Integer = 18 To 24
            'Asignamos valor y valor de parada
            If i <> 21 Then EnviarPosicionServo(i, Val(tbValorParar(i - 16).Text), "r")
        Next
    End Sub

    Sub EnviarPos(Optional ByRef bAvanzar As Boolean = True)
        'EnviarPosicionTotal()
    End Sub




    Private Sub cmdMoverRatón_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdMoverRatón.Click
        Dim sCad, sValor As String
        Dim aCampos(2) As String

        On Error GoTo 0

        'mouse_event MOUSEEVENTF_MOVE, 10, 10, 0, 0
        'mouse_event MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0
        'mouse_event MOUSEEVENTF_LEFTUP, 0, 0, 0, 0

        'If Not com.PortOpen Then

        '    MessageBox.Show("Control")
        '    com.Settings = "56000,n,8,1"
        '    com.CommPort = 15
        '    com.InputLen = 0
        '    com.SThreshold = 1
        '    com.PortOpen = True

        '    Do While True
        '        While (sCad.IndexOf(Constants.vbLf) + 1) = 0
        '            sCad = sCad & com.Input
        '            Application.DoEvents()
        '        End While
        '        RecuperarCampos(",", Strings.Mid(sCad, 10), aCampos)
        '        tbCom.Text = tbCom.Text & "->" & aCampos(0) & "," & aCampos(1) & " --> " & sCad
        '        sCad = ""
        '        tbCom.SelectionStart = Strings.Len(tbCom.Text)
        '        If Strings.Len(tbCom.Text) > 20000 Then Exit Do
        '        Application.DoEvents()
        '    Loop
        'Else
        '    com.PortOpen = False
        'End If

    End Sub








    Sub RecuperarCampos(ByRef sDelimitador As String, ByVal sCad As String, ByRef asCampos() As String)
        Dim sTmp As String = ""

        Dim iAnt As Integer = 0
        Dim iPos As Integer = 0
        Dim i As Integer = (sCad.IndexOf(sDelimitador) + 1)
        While (i > 0)
            asCampos(iPos) = Strings.Mid(sCad, iAnt + 1, i - iAnt - 1).Trim()
            iPos += 1
            iAnt = i
            i = Strings.InStr(iAnt + 1, sCad, sDelimitador)
        End While
        asCampos(iPos) = Strings.Mid(sCad, iAnt + 1)


    End Sub


    'UPGRADE_NOTE: (7001) The following declaration (Combo1_Change) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub Combo1_Change()
    '
    'End Sub

    Private Sub com_OnComm(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        ' Controlar cada evento o error escribiendo
        ' código en cada instrucción Case

        'Dim sCad As String

        'sCad = com.Input

        'If sCad.Length > 0 Then
        '    tbCom.Text = tbCom.Text & sCad
        'End If

        'Select Case com.CommEvent
        '    ' Errores
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.ErrorConstants.comBreak) ' Se ha recibido una interrupción.
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventFrame) ' Error de trama
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventOverrun) ' Datos perdidos.
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventRxOver) ' Desbordamiento del búfer
        '        tbCom.Text = tbCom.Text & "OVERBUFFER"
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventRxParity) ' Error de paridad.
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventTxFull) ' Búfer de transmisión lleno.
        '    Case ReflectionHelper.GetPrimitiveValue(Of MSCommLib.OnCommConstants)(MSCommLib.CommEventConstants.comEventDCB) ' Error inesperado al recuperar DCB.

        '        ' Eventos
        '    Case MSCommLib.OnCommConstants.comEvCD ' Cambio en la línea CD.
        '    Case MSCommLib.OnCommConstants.comEvCTS ' Cambio en la línea CTS.
        '    Case MSCommLib.OnCommConstants.comEvDSR ' Cambio en la línea DSR.
        '    Case MSCommLib.OnCommConstants.comEvRing ' Cambio en el indicador de
        '        ' llamadas.
        '    Case MSCommLib.OnCommConstants.comEvReceive ' Recibido nº SThreshold de
        '        ' caracteres.
        '        'tbCom.Text = tbCom.Text & com.Input

        '    Case MSCommLib.OnCommConstants.comEvSend ' Hay un SThreshold
        '        ' caracteres en el búfer
        '        ' de transmisión.
        '    Case MSCommLib.OnCommConstants.comEvEOF ' Se ha encontrado un carácter
        '        tbCom.Text = tbCom.Text & "EOF"
        '        ' EOF en la entrada.
        'End Select
    End Sub


    Private Sub Parada_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles Parada.Click
        If giEstado = ARRANCADO Then
            'Apagar base, cabeza y cuerpo
            EnviarCodigo("c", 1)
            EnviarCodigo("C", 1)
            EnviarCodigo("b", 1)

            tmrLeerDatosArduino.Enabled = False
            _continue = False
            giEstado = PARADO
            picEstado.BackColor = Color.Red

            'readThread.Join()
            _serialPort.Close()
        End If
    End Sub
    Private Sub Parada_Click1(ByVal eventSender As Object, ByVal eventArgs As EventArgs) ' Handles Parada.Click
        On Error Resume Next

        giEstado = PARADO
        picEstado.BackColor = Color.Red

        'com.PortOpen = False

    End Sub

    Private Sub tbMax_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _tbMax_11.KeyPress, _tbMax_10.KeyPress, _tbMax_9.KeyPress, _tbMax_8.KeyPress, _tbMax_7.KeyPress, _tbMax_6.KeyPress, _tbMax_5.KeyPress, _tbMax_4.KeyPress, _tbMax_3.KeyPress, _tbMax_2.KeyPress, _tbMax_1.KeyPress, _tbMax_0.KeyPress, _tbMax_13.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub tbMax_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _tbMax_11.Leave, _tbMax_10.Leave, _tbMax_9.Leave, _tbMax_8.Leave, _tbMax_7.Leave, _tbMax_6.Leave, _tbMax_5.Leave, _tbMax_4.Leave, _tbMax_3.Leave, _tbMax_2.Leave, _tbMax_1.Leave, _tbMax_0.Leave, _tbMax_13.Leave
        Dim Index As Integer = Array.IndexOf(tbMax, eventSender)
        barServo(Index).Maximum = (Conversion.Val(tbMax(Index).Text) + barServo(Index).LargeChange - 1)
    End Sub

    Private Sub tbMin_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _tbMin_11.KeyPress, _tbMin_10.KeyPress, _tbMin_9.KeyPress, _tbMin_8.KeyPress, _tbMin_7.KeyPress, _tbMin_6.KeyPress, _tbMin_5.KeyPress, _tbMin_4.KeyPress, _tbMin_3.KeyPress, _tbMin_2.KeyPress, _tbMin_1.KeyPress, _tbMin_0.KeyPress, _tbMin_13.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (tbMov_Change) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub tbMov_Change()
    '
    'End Sub

    'UPGRADE_NOTE: (7001) The following declaration (tbMov_KeyPress) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub tbMov_KeyPress(ByRef KeyAscii As Integer)
    'SoloNumero(KeyAscii)
    'End Sub

    Private Sub tbMin_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _tbMin_11.Leave, _tbMin_10.Leave, _tbMin_9.Leave, _tbMin_8.Leave, _tbMin_7.Leave, _tbMin_6.Leave, _tbMin_5.Leave, _tbMin_4.Leave, _tbMin_3.Leave, _tbMin_2.Leave, _tbMin_1.Leave, _tbMin_0.Leave, _tbMin_13.Leave
        Dim Index As Integer = Array.IndexOf(tbMin, eventSender)
        barServo(Index).Minimum = Conversion.Val(tbMin(Index).Text)
    End Sub

    Private Sub tbNombreMov_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs)
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        If KeyAscii = Strings.Asc("."c) Then KeyAscii = 0

        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub tbNumMov_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs)
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (tbPos_KeyPress) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub tbPos_KeyPress(ByRef KeyAscii As Integer)
    'SoloNumero(KeyAscii)
    'End Sub

    Private Sub tbNumMov_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs)
        barServo(ControlArrayHelper.GetControlIndex(Me)).Minimum = Conversion.Val(tbMin(ControlArrayHelper.GetControlIndex(Me)).Text)

    End Sub


    Private Sub tbValServo_KeyPress(ByVal eventSender As Object, ByVal eventArgs As KeyPressEventArgs) Handles _tbValServo_9.KeyPress, _tbValServo_8.KeyPress, _tbValServo_7.KeyPress, _tbValServo_6.KeyPress, _tbValServo_10.KeyPress, _tbValServo_11.KeyPress, _tbValServo_5.KeyPress, _tbValServo_4.KeyPress, _tbValServo_0.KeyPress, _tbValServo_1.KeyPress, _tbValServo_2.KeyPress, _tbValServo_3.KeyPress, _tbValServo_13.KeyPress
        Dim KeyAscii As Integer = Strings.Asc(eventArgs.KeyChar)
        SoloNumero(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
        eventArgs.KeyChar = Convert.ToChar(KeyAscii)
    End Sub

    Private Sub tbValServo_Leave(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _tbValServo_9.Leave, _tbValServo_8.Leave, _tbValServo_7.Leave, _tbValServo_6.Leave, _tbValServo_10.Leave, _tbValServo_11.Leave, _tbValServo_5.Leave, _tbValServo_4.Leave, _tbValServo_0.Leave, _tbValServo_1.Leave, _tbValServo_2.Leave, _tbValServo_3.Leave, _tbValServo_13.Leave
        Dim Index As Integer = Array.IndexOf(tbValServo, eventSender)
        Dim i As Integer
        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        If barServo(Index).Value <> Conversion.Val(tbValServo(i).Text) Then
            barServo(Index).Value = Conversion.Val(tbValServo(i).Text)
            EnviarPosicion(Index)
        End If
    End Sub


    '==========================================================================



    Sub EnviarCambio(ByRef iServo As Integer, ByRef iDif As Integer, ByRef iEvent As Integer)
        Static bEjecutandose As Boolean

        'Movimiento independiente
        'EnviarPosicion(iServo)
        EnviarPosicionServo(Val(tbNumServo(iServo).Text), Val(tbValServo(iServo).Text))

        bEjecutandose = False
    End Sub

    Sub EnviarPosicion(ByRef i As Integer)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If cbUnidad.SelectedIndex = GRADOS Then
                    sCad = ":pg"
                Else
                    sCad = ":pm"
                End If
                'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( i ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
                sCad = sCad & Conversion.Str(i + 2).Trim() & "," & Conversion.Str(barServo(i).Value).Trim() & ";."
                'com.Output = sCad
                EscribirCom("-->" & sCad & Environment.NewLine)
                Application.DoEvents()
            End If
        End If
    End Sub
    Sub EscribirComCRC(ByVal cad As String)
        Dim car As Char
        Dim CRC As Long = 0

        Try
            For i As Integer = 0 To cad.Length - 2
                car = cad.Substring(i, 1)
                CRC += Asc(car)
            Next

            CRC = CRC Mod 100

            _serialPort.WriteLine("@" & CRC & cad)
        Catch ex As Exception
            Console.WriteLine("EscribirComCRC: " + ex.Message)
        End Try
    End Sub
    Sub SolicitarAngulo(ByRef i As Integer)
        If _continue Then EscribirComCRC(":a" & i.ToString.Trim() & ";.")
        'com.Output = ":a" & i.ToString.Trim() & ";."
    End Sub
    Sub SolicitarDistancia(ByRef i As Integer)
        If _continue Then EscribirComCRC(":D" & i.ToString.Trim() & ";.")
        'com.Output = ":a" & i.ToString.Trim() & ";."
    End Sub
    Sub SolicitarTodasLasDistancia()
        If _continue Then EscribirComCRC(":1;.")
        'com.Output = ":a" & i.ToString.Trim() & ";."
    End Sub
    Sub SolicitarTodosLosSensores()
        If _continue Then EscribirComCRC(":U;.")
        'com.Output = ":a" & i.ToString.Trim() & ";."
    End Sub
    Sub SolicitarTodosLosAngulos()
        If _continue Then EscribirComCRC(":2;.")
        'com.Output = ":a" & i.ToString.Trim() & ";."
    End Sub
    Sub SolicitarMarcasVelocidad(ByRef i As Integer)
        If _continue Then EscribirComCRC(":V" & i.ToString.Trim() & ";.")
        'com.Output = ":a" & i.ToString.Trim() & ";."
    End Sub
    Sub EnviarPosicionServo(ByRef i As Integer, ByVal iValor As Integer, Optional Op As String = "")
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If (Op = "") Then
                    If cbUnidad.SelectedIndex = GRADOS Then
                        sCad = ":pg"
                    Else
                        sCad = ":pm"
                    End If
                Else
                    sCad = ":p" + Op
                End If
                sCad = sCad & Conversion.Str(i).Trim() & "," & Conversion.Str(iValor).Trim() & ";."
                If _continue Then EscribirComCRC(sCad)
                Application.DoEvents()
            End If
        End If
    End Sub
    Sub EnviarPosicionParada(ByRef i As Integer, ByVal iValor As Integer, ByVal Op As String)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                sCad = ":R" + Op
                sCad = sCad & Conversion.Str(i).Trim() & "," & Conversion.Str(iValor).Trim() & ";."
                If _continue Then EscribirComCRC(sCad)
                Application.DoEvents()
            End If
        End If
    End Sub
    Sub EnviarVelocidad(ByVal iValor As Integer)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If _continue Then EscribirComCRC(":v" & barServoVel.Value & ";.")
                Application.DoEvents()
            End If
        End If
    End Sub
    Sub EnviarDireccion(ByVal iValor As Integer)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If _continue Then EscribirComCRC(":d" & barServoDir.Value & ";.")
                Application.DoEvents()
            End If
        End If
    End Sub
    Sub EnviarSentidoMarcha(ByVal iValor As Integer)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If _continue Then EscribirComCRC(":f" & iValor & ";.")
                Application.DoEvents()
            End If
        End If
    End Sub
    Sub EnviarCodigo(ByVal sCodigo As String, ByVal iValor As Integer)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If _continue Then EscribirComCRC(":" & sCodigo & iValor & ";.")
                Application.DoEvents()

                If sCodigo = "c" And iValor = 1 Then
                    Application.DoEvents()
                End If
            End If
        End If
    End Sub
    Sub EnviarCadena(ByVal sCodigo As String, ByVal sValor As String)
        Dim sCad As String = ""

        If giEstado = ARRANCADO Then
            If cbModoEnvio.SelectedIndex = ENVIO_CONTINUO Then
                If _continue Then EscribirComCRC(":" & sCodigo & sValor & ";.")
                Application.DoEvents()
            End If
        End If
    End Sub
    'Sub EnviarPosicionTotal()
    '    Dim CONTROL_PC As Integer
    '    Dim sCad As String = ""
    '    If ListBoxHelper.GetSelectedIndex(lstMov) >= 0 Then
    '        If giEstado = ARRANCADO Then
    '            If cbModoEnvio.SelectedIndex = CONTROL_PC Or cbModoEnvio.SelectedIndex = ENVIO_SECUENCIA Then
    '                If cbUnidad.SelectedIndex = GRADOS Then
    '                    sCad = ":mg"
    '                Else
    '                    sCad = ":mm"
    '                End If
    '                sCad = sCad & lstMov.GetListItem(ListBoxHelper.GetSelectedIndex(lstMov)) & "."
    '                'com.Output = sCad
    '                EscribirCom("-->" & sCad & Environment.NewLine)
    '                Application.DoEvents()
    '            End If
    '        End If
    '    End If
    'End Sub
    Sub RecValores(ByRef sCad As String)
        Dim i As Integer, valor As Integer, pos As Integer
        Dim aCad() As String

        'If sCad.Length > 3 Then
        '    If sCad.Substring(0, 3) = "A->" Then
        '        aCad = sCad.Split(",")
        '        i = Val(aCad(0).Substring(3))
        '        valor = Val(aCad(1).Substring(0, aCad(1).Length - 1))
        '        tbValServoPos(i - MIN_SERVO_POS).Text = valor
        '    End If
        'End If
    End Sub


    Sub EscribirCom(ByRef sCad As String)
        If Strings.Len(tbCom.Text) > MAX_LEN_COM Then tbCom.Text = ""
        ActualizarDatos(sCad & vbCrLf)
        If giEstado <> PAUSA Then
            tbCom.SelectionStart = Strings.Len(tbCom.Text)
        End If
    End Sub

    Sub AsignarServo(ByRef iNumServo As Integer, ByRef iValor As Integer, ByRef iModo As Integer)
        barServo(iNumServo - 2).Value = iValor
        tbValServo(iNumServo - 2).Text = iValor
    End Sub


    Sub LimitesServo(ByRef iNumServo As Integer, ByRef iMin As Integer, ByRef iMax As Integer, ByRef iUnidad As Integer)
        If (iNumServo > 14) Then
            barServo(iNumServo - 2).Minimum = iMin
            tbMin(iNumServo - 2).Text = CStr(iMin)
            barServo(iNumServo - 2).Maximum = (iMax + barServo(iNumServo - 2).LargeChange - 1)
            tbMax(iNumServo - 2).Text = CStr(iMax)
        Else
            barServo(iNumServo - 2).Minimum = iMin
            tbMin(iNumServo - 2).Text = CStr(iMin)
            barServo(iNumServo - 2).Maximum = (iMax + barServo(iNumServo - 2).LargeChange - 1)
            tbMax(iNumServo - 2).Text = CStr(iMax)
        End If
    End Sub
    Sub LimitesServoPos(ByRef iNumServo As Integer, ByRef iMin As Integer, ByRef iMax As Integer, ByRef iUnidad As Integer)
        barServoPos(iNumServo - 2 - 14).Minimum = iMin
        tbMinPos(iNumServo - 2 - 14).Text = CStr(iMin)
        barServoPos(iNumServo - 2 - 14).Maximum = (iMax + barServo(iNumServo - 2 - 14).LargeChange - 1)
        tbMaxPos(iNumServo - 2 - 14).Text = CStr(iMax)
    End Sub

    Sub GenerarSincronizaciones()

        'Sincronizaciones simples en espejo

        aSinc(0).aServo(0).Numero = CShort(HOMBRO_CUERPO_DER)
        aSinc(0).aServo(0).Dif = 1
        aSinc(0).aServo(1).Numero = CShort(HOMBRO_CUERPO_IZQ)
        aSinc(0).aServo(1).Dif = -1
        aSinc(0).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(1).aServo(0).Numero = CShort(HOMBRO_BRAZO_DER)
        aSinc(1).aServo(0).Dif = 1
        aSinc(1).aServo(1).Numero = CShort(HOMBRO_BRAZO_IZQ)
        aSinc(1).aServo(1).Dif = -1
        aSinc(1).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(2).aServo(0).Numero = CShort(BICEPS_DER)
        aSinc(2).aServo(0).Dif = 1
        aSinc(2).aServo(1).Numero = CShort(BICEPS_IZQ)
        aSinc(2).aServo(1).Dif = -1
        aSinc(2).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(3).aServo(0).Numero = CShort(ANTEBRAZO_DER)
        aSinc(3).aServo(0).Dif = 1
        aSinc(3).aServo(1).Numero = CShort(ANTEBRAZO_IZQ)
        aSinc(3).aServo(1).Dif = -1
        aSinc(3).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(4).aServo(0).Numero = CShort(CADERA_SUP_DER)
        aSinc(4).aServo(0).Dif = 1
        aSinc(4).aServo(1).Numero = CShort(CADERA_SUP_IZQ)
        aSinc(4).aServo(1).Dif = 1
        aSinc(4).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(5).aServo(0).Numero = CShort(CADERA_GIRO_DER)
        aSinc(5).aServo(0).Dif = 1
        aSinc(5).aServo(1).Numero = CShort(CADERA_GIRO_IZQ)
        aSinc(5).aServo(1).Dif = 1
        aSinc(5).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(6).aServo(0).Numero = CShort(RODILLA_SUP_DER)
        aSinc(6).aServo(0).Dif = 1
        aSinc(6).aServo(1).Numero = CShort(RODILLA_SUP_IZQ)
        aSinc(6).aServo(1).Dif = -1
        aSinc(6).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(7).aServo(0).Numero = CShort(RODILLA_INF_DER)
        aSinc(7).aServo(0).Dif = 1
        aSinc(7).aServo(1).Numero = CShort(RODILLA_INF_IZQ)
        aSinc(7).aServo(1).Dif = -1
        aSinc(7).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(8).aServo(0).Numero = CShort(TOBILLO_DER)
        aSinc(8).aServo(0).Dif = 1
        aSinc(8).aServo(1).Numero = CShort(TOBILLO_IZQ)
        aSinc(8).aServo(1).Dif = -1
        aSinc(8).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(9).aServo(0).Numero = CShort(PIE_DER)
        aSinc(9).aServo(0).Dif = 1
        aSinc(9).aServo(1).Numero = CShort(PIE_IZQ)
        aSinc(9).aServo(1).Dif = 1
        aSinc(9).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(10).aServo(0).Numero = CShort(FIN_ARRAY)

        'Sincronizaciones complejas

    End Sub
    Sub GenerarSincronizacionesComplejas()

        'Sincronizaciones simples en espejo

        aSinc(0).aServo(0).Numero = CShort(HOMBRO_CUERPO_DER)
        aSinc(0).aServo(0).Dif = 1
        aSinc(0).aServo(1).Numero = CShort(HOMBRO_CUERPO_IZQ)
        aSinc(0).aServo(1).Dif = -1
        aSinc(0).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(1).aServo(0).Numero = CShort(HOMBRO_BRAZO_DER)
        aSinc(1).aServo(0).Dif = 1
        aSinc(1).aServo(1).Numero = CShort(HOMBRO_BRAZO_IZQ)
        aSinc(1).aServo(1).Dif = -1
        aSinc(1).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(2).aServo(0).Numero = CShort(BICEPS_DER)
        aSinc(2).aServo(0).Dif = 1
        aSinc(2).aServo(1).Numero = CShort(BICEPS_IZQ)
        aSinc(2).aServo(1).Dif = -1
        aSinc(2).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(3).aServo(0).Numero = CShort(ANTEBRAZO_DER)
        aSinc(3).aServo(0).Dif = 1
        aSinc(3).aServo(1).Numero = CShort(ANTEBRAZO_IZQ)
        aSinc(3).aServo(1).Dif = -1
        aSinc(3).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(4).aServo(0).Numero = CShort(CADERA_GIRO_DER)
        aSinc(4).aServo(0).Dif = 1
        aSinc(4).aServo(1).Numero = CShort(CADERA_GIRO_IZQ)
        aSinc(4).aServo(1).Dif = 1
        aSinc(4).aServo(2).Numero = CShort(FIN_ARRAY)

        aSinc(5).aServo(0).Numero = CShort(CADERA_SUP_DER)
        aSinc(5).aServo(0).Dif = 1
        aSinc(5).aServo(1).Numero = CShort(CADERA_SUP_IZQ)
        aSinc(5).aServo(1).Dif = 1
        aSinc(5).aServo(2).Numero = CShort(PIE_DER)
        aSinc(5).aServo(2).Dif = 1
        aSinc(5).aServo(3).Numero = CShort(PIE_IZQ)
        aSinc(5).aServo(3).Dif = 1
        aSinc(5).aServo(4).Numero = CShort(FIN_ARRAY)

        aSinc(6).aServo(0).Numero = CShort(RODILLA_SUP_DER)
        aSinc(6).aServo(0).Dif = 1
        aSinc(6).aServo(1).Numero = CShort(RODILLA_SUP_IZQ)
        aSinc(6).aServo(1).Dif = -1
        aSinc(6).aServo(2).Numero = CShort(RODILLA_INF_DER)
        aSinc(6).aServo(2).Dif = 1
        aSinc(6).aServo(3).Numero = CShort(RODILLA_INF_IZQ)
        aSinc(6).aServo(3).Dif = -1
        aSinc(6).aServo(4).Numero = CShort(TOBILLO_DER)
        aSinc(6).aServo(4).Dif = 1
        aSinc(6).aServo(5).Numero = CShort(TOBILLO_IZQ)
        aSinc(6).aServo(5).Dif = -1
        aSinc(6).aServo(6).Numero = CShort(FIN_ARRAY)

        aSinc(7).aServo(0).Numero = CShort(FIN_ARRAY)

        'Sincronizaciones complejas

    End Sub

    Sub Inc(ByRef var As Double, Optional ByRef valor As Integer = 1)
        var += valor
    End Sub


    Sub SoloNumero(ByRef iKey As Integer)
        If Strings.Chr(iKey).ToString() < "0" Or Strings.Chr(iKey).ToString() > "9" Then
            iKey = 0
        End If
    End Sub

    'UPGRADE_NOTE: (7001) The following declaration (Text1_Change) seems to be dead code More Information: http://www.vbtonet.com/ewis/ewi7001.aspx
    'Private Sub Text1_Change()
    '
    'End Sub

    Sub ProcesarError()
        If Information.Err().Number > 0 Then
            Interaction.MsgBox(CStr(Information.Err().Number) & " - " & Information.Err().Description, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Function Zona(ByRef iServo As Integer) As Integer
        If iServo >= 12 And iServo <= 22 Then
            Return ZONA_SUPERIOR
        Else
            Return ZONA_INFERIOR
        End If
    End Function
    Private Sub frmControl_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
        MemoryHelper.ReleaseMemory()
    End Sub
    Private Sub barServo_Scroll(ByVal eventSender As Object, ByVal eventArgs As ScrollEventArgs) Handles _barServo_9.Scroll, _barServo_8.Scroll, _barServo_7.Scroll, _barServo_6.Scroll, _barServo_10.Scroll, _barServo_11.Scroll, _barServo_5.Scroll, _barServo_4.Scroll, _barServo_0.Scroll, _barServo_1.Scroll, _barServo_2.Scroll, _barServo_3.Scroll, _barServo_13.Scroll, _barServo_12.Scroll, _barServo_14.Scroll
        Dim Index As Integer = Array.IndexOf(barServo, eventSender)
        Select Case eventArgs.Type
            Case ScrollEventType.ThumbTrack
                barServo_Scroll_Renamed(Index, eventArgs.NewValue)
            Case ScrollEventType.EndScroll
                barServo_Change(Index, eventArgs.NewValue)
        End Select
        System.Threading.Thread.Sleep(50)
        barServo(Index).Refresh()

    End Sub

    Private Sub tbMenos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _tbMenos_9.Click, _tbMenos_8.Click, _tbMenos_7.Click, _tbMenos_6.Click, _tbMenos_5.Click, _tbMenos_4.Click, _tbMenos_3.Click, _tbMenos_2.Click, _tbMenos_1.Click
        Dim Index As Integer = Array.IndexOf(tbMenos, sender)
        EnviarPosicionServo(Val(tbNumServoPos(Index).Text), VALOR_SERVO_ROT_BAJO)
    End Sub


    Private Sub tbParar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _tbParar_9.Click, _tbParar_8.Click, _tbParar_7.Click, _tbParar_6.Click, _tbParar_5.Click, _tbParar_4.Click, _tbParar_3.Click, _tbParar_2.Click, _tbParar_1.Click
        Dim Index As Integer = Array.IndexOf(tbParar, sender)
        'Asignamos valor y grabamos la posición de parada
        EnviarPosicionServo(Val(tbNumServoPos(Index).Text), Val(tbValorParar(Index).Text), "r")
        GrabarPosicion(Val(tbNumServoPos(Index).Text), Val(tbValorParar(Index).Text))
    End Sub

    Private Sub tbMas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _tbMas_9.Click, _tbMas_8.Click, _tbMas_7.Click, _tbMas_6.Click, _tbMas_5.Click, _tbMas_4.Click, _tbMas_3.Click, _tbMas_2.Click, _tbMas_1.Click
        Dim Index As Integer = Array.IndexOf(tbMas, sender)
        EnviarPosicionServo(Val(tbNumServoPos(Index).Text), VALOR_SERVO_ROT_ALTO)
    End Sub

    Private Sub frmControl_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tbComShared = tbCom
        ComprobarCargaBateria()

        If (Arranque) Then
            If (RecCfg("INI", "conectar") = "S") Then ConectarArduino()
            If (RecCfg("INI", "ejecutar_dani") = "S") Then EjecutarDANI()
            Arranque = False
        End If

    End Sub

    '************************************************************************************************************************************************************************
    ' Funciones de control **************************************************************************************************************************************************
    '************************************************************************************************************************************************************************

    Public Sub RecDatos(ByVal sCad As String)
        Dim aCad() As String
        Dim Servo As Integer
        Dim Sensor As Integer
        Dim Valor As Integer
        If sCad.Length > 3 Then
            Select Case sCad.Substring(0, 3)
                Case "1->" ' Distancias de todos los sensores
                    aCad = sCad.Substring(3).Split(",")
                    For i As Integer = 0 To MAX_SENSORES_DISTANCIA - 1
                        Valor = Val(aCad(i))
                        aDist(i).Text = Valor.ToString()
                    Next
                Case "2->" ' Posición de todos los sensores de las articulaciones
                    aCad = sCad.Substring(3).Split(",")
                    Dim i As Integer = 0
                    While i < MAX_SENSOR_ARTICULACIONES + 1
                        If i <> 3 Then
                            Valor = Val(aCad(i))
                            tbValServoPos(i + SERVO_POS_INI).Text = Valor.ToString()
                        End If
                        i += 1
                    End While
                Case "A->"
                    aCad = sCad.Substring(3).Split(",")
                    If aCad.Length >= 2 Then
                        Servo = Val(aCad(0))
                        Valor = Val(aCad(1))
                        If Servo >= MIN_SERVO_POS And Servo <= MAX_SERVO_POS Then
                            tbValServoPos(Servo - MIN_SERVO_POS).Text = Valor
                            'tbCom.Text = tbCom.Text & "Servo: " & Servo & ", valor: " & Valor & vbCrLf
                        End If
                    End If
                Case "D->"
                    aCad = sCad.Substring(3).Split(",")
                    If aCad.Length >= 2 Then
                        Sensor = Val(aCad(0))
                        Valor = Val(aCad(1))
                        aDist(Sensor).Text = Valor.ToString()
                    End If
                Case "V->"
                    Valor = Val(sCad.Substring(3))
                    tbMarcas.Text = Valor
                Case "U->"
                    Dim n As Integer = 0
                    aCad = sCad.Substring(3).Split(",")
                    tbDebug.Text = sCad
                    Try
                        'Sensores de las articulaciones
                        While n < MAX_SENSOR_ARTICULACIONES + 1
                            If n <> 3 Then
                                Valor = Val(aCad(n))
                                tbValServoPos(n + SERVO_POS_INI).Text = Valor.ToString()
                            End If
                            n += 1
                        End While
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                    Try
                        'Sensores de distancia
                        Dim i As Integer
                        For i = 0 To MAX_SENSORES_DISTANCIA - 1
                            Valor = Val(aCad(i + n))
                            aDist(i).Text = Valor.ToString()
                        Next
                        n = n + i
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
                    Try
                        'Contador de marcas
                        Valor = Val(aCad(n))
                        tbMarcas.Text = Valor
                        Inc(n)
                        'Sensor de línea
                        Dim SensorLinea As String
                        SensorLinea = aCad(n)
                        If SensorLinea.Substring(0, 1) = "1" Then
                            cmdSensorLineaL.BackColor = Color.LightSalmon
                        Else
                            cmdSensorLineaL.BackColor = Color.LightGray
                        End If
                        If SensorLinea.Substring(1, 1) = "1" Then
                            cmdSensorLineaC.BackColor = Color.LightSalmon
                        Else
                            cmdSensorLineaC.BackColor = Color.LightGray
                        End If
                        If SensorLinea.Substring(2, 1) = "1" Then
                            cmdSensorLineaR.BackColor = Color.LightSalmon
                        Else
                            cmdSensorLineaR.BackColor = Color.LightGray
                        End If
                        Inc(n)
                        'Motores servos rotacionales. indica si están en marcha
                        For i As Integer = 0 To NUM_SERVOS_ROT
                            If i <> 3 Then
                                Valor = Val(aCad(i + n))
                                If (Math.Abs(Valor - VALOR_SERVO_ROT_MEDIO) > VALOR_SERVO_ROT_MARGEN_MEDIO) Then
                                    tbValServoPos(i + 2).BackColor = Color.LightSalmon
                                Else
                                    tbValServoPos(i + 2).BackColor = Color.LightGray
                                End If
                            Else
                                n = n - 1
                            End If
                        Next
                        Inc(n)
                        n = n + NUM_SERVOS_ROT
                        'Relés de encendido
                        Valor = Val(aCad(n))
                        Dim ReleCuerpo As String = aCad(n).Substring(0, 1)
                        Dim ReleBase As String = aCad(n).Substring(1, 1)
                        Dim ReleCabeza As String = aCad(n).Substring(2, 1)

                        Dim ControlPos As String = aCad(n).Substring(3, 1)
                        Dim ControlLimitesOff As String = aCad(n).Substring(4, 1)
                        Dim ControlLimites As String = aCad(n).Substring(5, 1)

                        'Relés
                        If (ReleCuerpo = "0") Then
                            cmdCuerpo1.BackColor = Color.Salmon
                            cmdCuerpo1.Tag = "ON"
                        Else
                            cmdCuerpo1.BackColor = Color.LightGray
                            cmdCuerpo1.Tag = "OFF"
                        End If
                        If (ReleBase = "0") Then
                            cmdBase1.BackColor = Color.Salmon
                            cmdBase1.Tag = "ON"
                        Else
                            cmdBase1.BackColor = Color.LightGray
                            cmdBase1.Tag = "OFF"
                        End If
                        If (ReleCabeza = "0") Then
                            cmdCabeza1.BackColor = Color.Salmon
                            cmdCabeza1.Tag = "ON"
                        Else
                            cmdCabeza1.BackColor = Color.LightGray
                            cmdCabeza1.Tag = "OFF"
                        End If

                        'Opciones de control
                        If (ControlPos = "1") Then
                            tbControlPosOn.BackColor = Color.Salmon
                            tbControlPosOn.Tag = "ON"
                        Else
                            tbControlPosOn.BackColor = Color.LightGray
                            tbControlPosOn.Tag = "OFF"
                        End If
                        If (ControlLimitesOff = "1") Then
                            cmdControlLimOn.BackColor = Color.Salmon
                            cmdControlLimOn.Tag = "ON"
                        Else
                            cmdControlLimOn.BackColor = Color.LightGray
                            cmdControlLimOn.Tag = "OFF"
                        End If
                        If (ControlLimites = "1") Then
                            cmdControlLimitesOff.BackColor = Color.LightGray
                            cmdControlLimitesOff.Tag = "ON"
                        Else
                            cmdControlLimitesOff.BackColor = Color.Salmon
                            cmdControlLimitesOff.Tag = "OFF"
                        End If
                        'Recuperamos la inforamción de debug
                        Inc(n)
                        tbDebug.Text = aCad(n)
                    Catch ex As Exception
                        Console.WriteLine(ex.Message)
                    End Try
            End Select
        End If
    End Sub

    Sub DataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        'RecDatos() interpreta los datos
        Static i As Integer = 0
        Dim _serialPort As SerialPort = sender
        'Dim indata As String = sp.ReadExisting()

        Try
            If _serialPort.BytesToRead > 0 Then
                DatosRecibidosArduino = True
                Dim message As String = _serialPort.ReadLine
                If message.Length > 0 Then
                    sCadShared = sCadShared & message & vbCrLf
                    message = ""
                    i += 1
                End If
                'Application.DoEvents()
            End If
        Catch ex As Exception
            Console.WriteLine("DataReceivedHandler: " + ex.Message)
        End Try
    End Sub
    Public Shared Sub LeerDatos()
        Static i As Integer = 0
        While _continue
            Try
                If _serialPort.BytesToRead > 0 Then
                    Dim message As String = _serialPort.ReadLine
                    If message.Length > 0 Then
                        sCadShared = sCadShared & message & vbCrLf
                        message = ""
                        i += 1
                    End If
                    Application.DoEvents()
                End If
            Catch generatedExceptionName As System.TimeoutException
            End Try
        End While
    End Sub

    Private Sub tbVelMin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVelMin.TextChanged
        barServoVel.Minimum = Val(tbVelMin.Text)
    End Sub

    Private Sub tbVelMax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVelMax.TextChanged
        barServoVel.Maximum = Val(tbVelMax.Text)
    End Sub

    Private Sub barServoVel_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles barServoVel.Scroll
        EnviarVelocidad(Val(barServoVel.Value))

        tbVelValor.Text = Val(barServoVel.Value)
    End Sub

    Private Sub barServoDir_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles barServoDir.Scroll
        EnviarDireccion(Val(barServoDir.Value))

        tbDirValor.Text = Val(barServoDir.Value)
    End Sub

    Private Sub btAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtras.Click
        EnviarSentidoMarcha(1)
    End Sub

    Private Sub btAdelante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdelante.Click
        EnviarSentidoMarcha(0)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        barServoVel.Value = 0
    End Sub



    Private Sub cmdCuerpo0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCuerpo0.Click
        EnviarCodigo("c", 1)
        cmdCuerpo1.BackColor = Color.LightGray
        cmdCuerpo1.Tag = "OFF"
    End Sub

    Private Sub cmdCuerpo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCuerpo1.Click
        EnviarCodigo("c", 0)
        cmdCuerpo1.BackColor = Color.Red
        cmdCuerpo1.Tag = "ON"
    End Sub

    Private Sub cmdBase1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBase1.Click
        EnviarCodigo("b", 0)
        cmdBase1.BackColor = Color.Red
        cmdBase1.Tag = "ON"
    End Sub

    Private Sub cmdBase0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBase0.Click
        EnviarCodigo("b", 1)
        cmdBase1.BackColor = Color.LightGray
        cmdBase1.Tag = "OFF"
    End Sub

    Private Sub btArrancar_Click(sender As Object, e As EventArgs) Handles btArrancar.Click
        EnviarCodigo("A", barServoVel.Value)
    End Sub

    Private Sub btParar_Click(sender As Object, e As EventArgs) Handles btParar.Click
        EnviarCodigo("P", 0)
    End Sub

#Region "AsignacíonLimites"
    Sub PosicionInicial(ByRef iUnidad As Integer)

        AsignarServo(RASPER.boca, RecCfgPosIni("RASPER.boca"), GRADOS)
        AsignarServo(RASPER.cabeceo, RecCfgPosIni("RASPER.cabeceo"), GRADOS)
        AsignarServo(RASPER.guinada, RecCfgPosIni("RASPER.guinada"), GRADOS)

        AsignarServo(RASPER.mano_derecha_pulgar, RecCfgPosIni("RASPER.mano_derecha_pulgar"), GRADOS)
        AsignarServo(RASPER.mano_derecha_anular, RecCfgPosIni("RASPER.mano_derecha_anular"), GRADOS)
        AsignarServo(RASPER.mano_derecha_indice, RecCfgPosIni("RASPER.mano_derecha_indice"), GRADOS)
        AsignarServo(RASPER.mano_derecha_medio, RecCfgPosIni("RASPER.mano_derecha_medio"), GRADOS)
        AsignarServo(RASPER.mano_derecha_menique, RecCfgPosIni("RASPER.mano_derecha_menique"), GRADOS)
        AsignarServo(RASPER.mano_derecha_muneca, RecCfgPosIni("RASPER.mano_derecha_muneca"), GRADOS)

        AsignarServo(RASPER.mano_iquierda_pulgar, RecCfgPosIni("RASPER.mano_iquierda_pulgar"), GRADOS)
        AsignarServo(RASPER.mano_iquierda_indice, RecCfgPosIni("RASPER.mano_iquierda_indice"), GRADOS)
        AsignarServo(RASPER.mano_iquierda_medio, RecCfgPosIni("RASPER.mano_iquierda_medio"), GRADOS)
        AsignarServo(RASPER.mano_iquierda_anular, RecCfgPosIni("RASPER.mano_iquierda_anular"), GRADOS)
        AsignarServo(RASPER.mano_iquierda_menique, RecCfgPosIni("RASPER.mano_iquierda_menique"), GRADOS)
        AsignarServo(RASPER.mano_iquierda_muneca, RecCfgPosIni("RASPER.mano_iquierda_muneca"), GRADOS)

        barServoDir.Value = RecCfg("valor_ini", "RASPER.giro")
    End Sub
    Sub EstablecerLimites(ByRef iUnidad As Integer)
        Dim i As Integer

        For i = 2 To MIN_SERVO_POS - 1
            LimitesServo(i, 0, 179, GRADOS)
        Next

        For i = MIN_SERVO_POS To 25
            LimitesServoPos(i, 0, 179, GRADOS)
        Next

        LimitesServo(RASPER.boca, RecCfgLimiteMin("RASPER.boca"), RecCfgLimiteMax("RASPER.boca"), GRADOS)
        LimitesServo(RASPER.cabeceo, RecCfgLimiteMin("RASPER.cabeceo"), RecCfgLimiteMax("RASPER.cabeceo"), GRADOS)
        LimitesServo(RASPER.guinada, RecCfgLimiteMin("RASPER.guinada"), RecCfgLimiteMax("RASPER.guinada"), GRADOS)

        LimitesServo(RASPER.mano_derecha_pulgar, RecCfgLimiteMin("RASPER.mano_derecha_pulgar"), RecCfgLimiteMax("RASPER.mano_derecha_pulgar"), GRADOS)
        LimitesServo(RASPER.mano_derecha_indice, RecCfgLimiteMin("RASPER.mano_derecha_indice"), RecCfgLimiteMax("RASPER.mano_derecha_indice"), GRADOS)
        LimitesServo(RASPER.mano_derecha_medio, RecCfgLimiteMin("RASPER.mano_derecha_medio"), RecCfgLimiteMax("RASPER.mano_derecha_medio"), GRADOS)
        LimitesServo(RASPER.mano_derecha_anular, RecCfgLimiteMin("RASPER.mano_derecha_anular"), RecCfgLimiteMax("RASPER.mano_derecha_anular"), GRADOS)
        LimitesServo(RASPER.mano_derecha_menique, RecCfgLimiteMin("RASPER.mano_derecha_menique"), RecCfgLimiteMax("RASPER.mano_derecha_menique"), GRADOS)
        LimitesServo(RASPER.mano_derecha_muneca, RecCfgLimiteMin("RASPER.mano_derecha_muneca"), RecCfgLimiteMax("RASPER.mano_derecha_muneca"), GRADOS)

        LimitesServo(RASPER.mano_iquierda_pulgar, RecCfgLimiteMin("RASPER.mano_iquierda_pulgar"), RecCfgLimiteMax("RASPER.mano_iquierda_pulgar"), GRADOS)
        LimitesServo(RASPER.mano_iquierda_indice, RecCfgLimiteMin("RASPER.mano_iquierda_indice"), RecCfgLimiteMax("RASPER.mano_iquierda_indice"), GRADOS)
        LimitesServo(RASPER.mano_iquierda_medio, RecCfgLimiteMin("RASPER.mano_iquierda_medio"), RecCfgLimiteMax("RASPER.mano_iquierda_medio"), GRADOS)
        LimitesServo(RASPER.mano_iquierda_anular, RecCfgLimiteMin("RASPER.mano_iquierda_anular"), RecCfgLimiteMax("RASPER.mano_iquierda_anular"), GRADOS)
        LimitesServo(RASPER.mano_iquierda_menique, RecCfgLimiteMin("RASPER.mano_iquierda_menique"), RecCfgLimiteMax("RASPER.mano_iquierda_menique"), GRADOS)
        LimitesServo(RASPER.mano_iquierda_muneca, RecCfgLimiteMin("RASPER.mano_iquierda_muneca"), RecCfgLimiteMax("RASPER.mano_iquierda_muneca"), GRADOS)

        LimitesServoPos(RASPER.hombro_cuerpo_derecho, RecCfgLimiteMin("RASPER.hombro_cuerpo_derecho"), RecCfgLimiteMax("RASPER.hombro_cuerpo_derecho"), GRADOS)
        LimitesServoPos(RASPER.hombro_brazo_derecho, RecCfgLimiteMin("RASPER.hombro_brazo_derecho"), RecCfgLimiteMax("RASPER.hombro_brazo_derecho"), GRADOS)
        LimitesServoPos(RASPER.biceps_derecho, RecCfgLimiteMin("RASPER.biceps_derecho"), RecCfgLimiteMax("RASPER.biceps_derecho"), GRADOS)

        LimitesServoPos(RASPER.hombro_cuerpo_iquierdo, RecCfgLimiteMin("RASPER.hombro_cuerpo_iquierdo"), RecCfgLimiteMax("RASPER.hombro_cuerpo_iquierdo"), GRADOS)
        LimitesServoPos(RASPER.hombro_brazo_iquierdo, RecCfgLimiteMin("RASPER.hombro_brazo_iquierdo"), RecCfgLimiteMax("RASPER.hombro_brazo_iquierdo"), GRADOS)
        LimitesServoPos(RASPER.biceps_izquierdo, RecCfgLimiteMin("RASPER.biceps_izquierdo"), RecCfgLimiteMax("RASPER.biceps_izquierdo"), GRADOS)

        'Dirección
        tbServoDirMin.Text = RecCfgLimiteMin("RASPER.giro")
        tbServoDirMax.Text = RecCfgLimiteMax("RASPER.giro")
    End Sub

    Function ColorDireccion(dir As String) As Color
        If dir = "ASCENDENTE" Then
            Return Color.LightGreen
        Else
            Return Color.LightSalmon
        End If
    End Function
    Sub CargarCfgControlServos()
        For i As Integer = 0 To 9
            tbValorParar(i).Text = "85"
        Next


        tbValorParar(RASPER.hombro_cuerpo_derecho - MIN_SERVO_POS).Text = RecCfgParada("RASPER.hombro_cuerpo_derecho") '18
        tbValorParar(RASPER.hombro_brazo_derecho - MIN_SERVO_POS).Text = RecCfgParada("RASPER.hombro_brazo_derecho") '19
        tbValorParar(RASPER.biceps_derecho - MIN_SERVO_POS).Text = RecCfgParada("RASPER.biceps_derecho") '20
        tbValorParar(21 - MIN_SERVO_POS).Text = 85 '21
        tbValorParar(RASPER.hombro_cuerpo_iquierdo - MIN_SERVO_POS).Text = RecCfgParada("RASPER.hombro_cuerpo_iquierdo") '22
        tbValorParar(RASPER.hombro_brazo_iquierdo - MIN_SERVO_POS).Text = RecCfgParada("RASPER.hombro_brazo_iquierdo") '23
        tbValorParar(RASPER.biceps_izquierdo - MIN_SERVO_POS).Text = RecCfgParada("RASPER.biceps_izquierdo") '24

        'Establecer dirección
        tbValorParar(RASPER.hombro_cuerpo_derecho - MIN_SERVO_POS).Tag = RecCfg("dir", "RASPER.hombro_cuerpo_derecho") '18
        tbValorParar(RASPER.hombro_cuerpo_derecho - MIN_SERVO_POS).BackColor = ColorDireccion(RecCfg("dir", "RASPER.hombro_cuerpo_derecho")) '18

        tbValorParar(RASPER.hombro_brazo_derecho - MIN_SERVO_POS).Tag = RecCfg("dir", "RASPER.hombro_brazo_derecho") '19
        tbValorParar(RASPER.hombro_brazo_derecho - MIN_SERVO_POS).BackColor = ColorDireccion(RecCfg("dir", "RASPER.hombro_brazo_derecho")) '19

        tbValorParar(RASPER.biceps_derecho - MIN_SERVO_POS).Tag = RecCfg("dir", "RASPER.biceps_derecho") '20
        tbValorParar(RASPER.biceps_derecho - MIN_SERVO_POS).BackColor = ColorDireccion(RecCfg("dir", "RASPER.biceps_derecho")) '20

        tbValorParar(21 - MIN_SERVO_POS).Text = 85 '21

        tbValorParar(RASPER.hombro_cuerpo_iquierdo - MIN_SERVO_POS).Tag = RecCfg("dir", "RASPER.hombro_cuerpo_iquierdo") '22
        tbValorParar(RASPER.hombro_cuerpo_iquierdo - MIN_SERVO_POS).BackColor = ColorDireccion(RecCfg("dir", "RASPER.hombro_cuerpo_iquierdo")) '22

        tbValorParar(RASPER.hombro_brazo_iquierdo - MIN_SERVO_POS).Tag = RecCfg("dir", "RASPER.hombro_brazo_iquierdo") '23
        tbValorParar(RASPER.hombro_brazo_iquierdo - MIN_SERVO_POS).BackColor = ColorDireccion(RecCfg("dir", "RASPER.hombro_brazo_iquierdo")) '23

        tbValorParar(RASPER.biceps_izquierdo - MIN_SERVO_POS).Tag = RecCfg("dir", "RASPER.biceps_izquierdo") '24
        tbValorParar(RASPER.biceps_izquierdo - MIN_SERVO_POS).BackColor = ColorDireccion(RecCfg("dir", "RASPER.biceps_izquierdo")) '24

        'Tolerancias
        aToleranciaServos(0) = RecCfg("tolerancia", "RASPER.hombro_cuerpo_derecho")
        aToleranciaServos(1) = RecCfg("tolerancia", "RASPER.hombro_brazo_derecho")
        aToleranciaServos(2) = RecCfg("tolerancia", "RASPER.biceps_derecho")

        aToleranciaServos(3) = RecCfg("tolerancia", "RASPER.hombro_cuerpo_iquierdo")
        aToleranciaServos(4) = RecCfg("tolerancia", "RASPER.hombro_brazo_iquierdo")
        aToleranciaServos(5) = RecCfg("tolerancia", "RASPER.biceps_izquierdo")

        'Movimiento lateral de cabeza
        barServo(13).Value = RecCfg("valor_ini", "RASPER.guinada")
        tbValServo(13).Text = RecCfg("valor_ini", "RASPER.guinada")

        'Cargar posiciones de parada servos rotacionales
        Dim iNumPos As Integer = RecCfg("parada", "num_pos")
        Dim sServo As String
        Dim iValor As Integer
        Dim sValor As Integer
        Dim DatosArduino As frmArduino = New frmArduino()

        For i As Integer = 0 To iNumPos - 1
            aPosParada(i).iNumServo = New Integer(NUM_SERVOS_ROT) {}
            aPosParada(i).iPosServo = New Integer(NUM_SERVOS_ROT) {}

            For j As Integer = 0 To NUM_SERVOS_ROT - 1
                sServo = DatosArduino.aNombreServosRot(j)
                sValor = RecCfg("parada" + i.ToString(), "RASPER." + sServo)
                iValor = Integer.Parse(sValor)
                aPosParada(i).iNumServo(j) = DatosArduino.aNumServosRot(j)
                aPosParada(i).iPosServo(j) = iValor
            Next
            cbPosiciones.AddItem("P" + i.ToString())
        Next


        'Cargar posiciones de servos de las manos
        iNumPos = RecCfg("posicion", "num_pos")

        For i As Integer = 0 To iNumPos - 1
            aPosManos(i).iNumServo = New Integer(NUM_SERVOS_MANOS) {}
            aPosManos(i).iPosServo = New Integer(NUM_SERVOS_MANOS) {}

            For j As Integer = 0 To NUM_SERVOS_MANOS - 1
                sServo = DatosArduino.aNombreServos(j)
                sValor = RecCfg("posicion" + i.ToString(), "RASPER." + sServo)
                iValor = Integer.Parse(sValor)
                aPosManos(i).iNumServo(j) = DatosArduino.aNumServos(j)
                aPosManos(i).iPosServo(j) = iValor
            Next
            cbPosiciones.AddItem("M" + i.ToString())
        Next
        DatosArduino.Dispose()

        If RecCfg("INI_enviar_posiciones_parada") = "S" Then
            chkEnviarPosIniServosControl.Checked = True
        End If
    End Sub
#End Region
    Private Sub cmdHablar_Click(sender As Object, e As EventArgs) Handles cmdHablar.Click
        static_frase = tbTexto.Text
        If chkMoverBoca.Checked Then
            tmrLeerDatosArduino.Enabled = False
            tmrMoverBoca.Enabled = True
            voz.SpeakAsync(static_frase)
        Else
            voz.Speak(static_frase)
        End If
        tbTexto.Text = ""
    End Sub

    Private Sub tbTexto_TextChanged(sender As Object, e As EventArgs) Handles tbTexto.TextChanged

    End Sub

    Private Sub tbTexto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTexto.KeyPress
        If e.KeyChar = Chr(13) Then
            voz.Speak(tbTexto.Text)
            tbTexto.Text = ""
        End If
    End Sub

    Private Sub _tbValorParar_2_TextChanged(sender As Object, e As EventArgs) Handles _tbValorParar_2.TextChanged

    End Sub

    Private Sub cmdIniciarD_Click(sender As Object, e As EventArgs) Handles cmdIniciarD.Click
        InicializarVideo(FuenteDeVideoD, dispositivosD, "D")
    End Sub

    Public Function InicializarVideo(ByRef FuenteDeVideo As VideoCaptureDevice, dispositivos As ComboBox, Ojo As String) As Boolean
        If ((dispositivos.SelectedIndex < 0)) Then
            MessageBox.Show("No hay dispositivos de video conectados")
            Return False
        End If
        FuenteDeVideo = New VideoCaptureDevice(DispositivosDeVideo(dispositivos.SelectedIndex).MonikerString)
        'FuenteDeVideo.DisplayPropertyPage((IntPtr) 0);
        'MostrarResoluciones();
        If Ojo = "D" Then
            AddHandler FuenteDeVideo.NewFrame, AddressOf Me.video_NuevoFrameD
        Else
            AddHandler FuenteDeVideo.NewFrame, AddressOf Me.video_NuevoFrameI
        End If
        'FuenteDeVideo.VideoResolution = FuenteDeVideo.VideoCapabilities[2];
        FuenteDeVideo.VideoResolution = FuenteDeVideo.VideoCapabilities(VideoResolucion)
        FuenteDeVideo.Start()
        Return True
    End Function

    Private Sub video_NuevoFrameD(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            Imagen = CType(eventArgs.Frame.Clone, Bitmap)
            picVideoD.Image = Imagen
        Catch e As Exception

        End Try

    End Sub

    Private Sub video_NuevoFrameI(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            Dim Imagen As Bitmap = CType(eventArgs.Frame.Clone, Bitmap)
            picVideoI.Image = Imagen
        Catch e As Exception

        End Try

    End Sub

    Private Sub cmdIniciarI_Click(sender As Object, e As EventArgs) Handles cmdIniciarI.Click
        InicializarVideo(FuenteDeVideoI, dispositivosI, "I")
    End Sub

    Public Sub TerminarFuenteDeVideo(ByRef FuenteDeVideo As VideoCaptureDevice)
        If Not (FuenteDeVideo Is Nothing) Then
            If FuenteDeVideo.IsRunning Then
                FuenteDeVideo.SignalToStop()
                FuenteDeVideo = Nothing
                GC.Collect()
            End If

        End If

    End Sub


    Private Sub cmdFinD_Click(sender As Object, e As EventArgs) Handles cmdFinD.Click
        TerminarFuenteDeVideo(FuenteDeVideoD)
    End Sub

    Private Sub cmdConfigD_Click(sender As Object, e As EventArgs) Handles cmdConfigD.Click
        FuenteDeVideoD.DisplayPropertyPage(0)
    End Sub

    Private Sub cmdResD_Click(sender As Object, e As EventArgs) Handles cmdResD.Click
        MostrarResoluciones(FuenteDeVideoD)
    End Sub

    Private Sub MostrarResoluciones(FuenteDeVideo As VideoCaptureDevice)
        Dim sCad As String = ""
        Dim i As Integer = 0
        Do While (i < FuenteDeVideo.VideoCapabilities.Length)
            sCad = (sCad _
                        + (Convert.ToString(i) + ("-" + FuenteDeVideo.VideoCapabilities(i).FrameSize.ToString)))
            i = (i + 1)
        Loop

        MessageBox.Show(sCad)
    End Sub

    Private Sub cmdFinI_Click(sender As Object, e As EventArgs) Handles cmdFinI.Click
        TerminarFuenteDeVideo(FuenteDeVideoI)
    End Sub

    Private Sub cmdConfigI_Click(sender As Object, e As EventArgs) Handles cmdConfigI.Click
        FuenteDeVideoI.DisplayPropertyPage(0)
    End Sub

    Private Sub cmdResI_Click(sender As Object, e As EventArgs) Handles cmdResI.Click
        MostrarResoluciones(FuenteDeVideoD)
    End Sub

    Public Sub BuscarDispositivos()
        DispositivosDeVideo = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If (DispositivosDeVideo.Count = 0) Then
            ExistenDispositivos = False
        Else
            ExistenDispositivos = True
            CargarDispositivos(dispositivosD)
            CargarDispositivos(dispositivosI)
            cmdIniciarI.Enabled = True
            cmdFinI.Enabled = True
            cmdConfigI.Enabled = True
            cmdResI.Enabled = True

            cmdIniciarD.Enabled = True
            cmdFinD.Enabled = True
            cmdConfigD.Enabled = True
            cmdResD.Enabled = True
        End If

    End Sub

    Public Sub CargarDispositivos(dispositivos As ComboBox)
        Dim i As Integer = 0
        dispositivos.Items.Clear()
        Do While (i < DispositivosDeVideo.Count)
            dispositivos.Items.Add(DispositivosDeVideo(i).Name.ToString)
            i = (i + 1)
        Loop

        dispositivos.Text = dispositivos.Items(0).ToString
    End Sub

    Private Sub frmControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarDispositivos()
        aDist(0) = tbDistT
        aDist(1) = tbDistI
        aDist(2) = tbDistC
        aDist(3) = tbDistD

        frmServerWEB.Show()

        Me.Text += " v" + Application.ProductVersion
    End Sub

    Private Sub picRadar_Click(sender As Object, e As EventArgs) Handles picRadar.Click
        DibujarRadar()
    End Sub
    'En el gráfico hay espacio para 40 arcos
    ' r va de 0 para objetos próximos a 40 para el objeto más alejado que pueda detectar
    Sub PintarOnda(Sensor As String, pen As Pen, r As Integer)
        Dim p As Pen
        Select Case Sensor
            Case "D"
                p = Pens.Yellow
            Case "C"
                p = Pens.Red
            Case "I"
                p = Pens.Cyan
            Case "T"
                p = Pens.Beige
            Case Else
                p = Pens.White
        End Select

        For i As Integer = 50 To (40 - r) + 10 Step -1
            PintarArco(Sensor, p, i)
        Next
    End Sub
    Sub PintarArco(Sensor As String, pen As Pen, r As Integer)
        Dim g As Graphics = picRadar.CreateGraphics
        Dim AnguloIni As Integer
        Dim AngTam As Integer

        Select Case Sensor
            Case "D"
                AnguloIni = 300
                AngTam = 60
            Case "C"
                AnguloIni = 240
                AngTam = 60
            Case "I"
                AnguloIni = 180
                AngTam = 60
            Case "T"
                AnguloIni = 45
                AngTam = 90
        End Select
        g.DrawArc(pen, New Rectangle(0 + r, 0 + r, picRadar.Width - 2 * r, picRadar.Height - 2 * r), AnguloIni, AngTam)

    End Sub
    Private Sub DibujarRadar()
        Dim v As Integer
        Dim Sensor As String = ""
        picRadar.Refresh()
        For i As Integer = 0 To 3
            Dim d As Double
            v = Convert.ToInt16(aDist(i).Text)
            If (v > VALOR_DISTANCIA_CM_MAX) Or (v < VALOR_DISTANCIA_CM_MIN) Then
                d = VALOR_OBJETO_NO_DETECTADO
            Else
                d = 40 / (VALOR_DISTANCIA_CM_MAX - VALOR_DISTANCIA_CM_MIN) * (v - VALOR_DISTANCIA_CM_MIN)
            End If

            Select Case i
                Case 0
                    Sensor = "T"
                Case 1
                    Sensor = "I"
                Case 2
                    Sensor = "C"
                Case 3
                    Sensor = "D"
            End Select

            PintarOnda(Sensor, Pens.Yellow, d)
        Next
    End Sub
    Private Sub tmrBateria_Tick(sender As Object, e As EventArgs) Handles tmrBateria.Tick
        ComprobarCargaBateria()
    End Sub

    Sub ComprobarCargaBateria()

        ComprobarPorcentajeCPU()

        Dim p As System.Windows.Forms.PowerStatus = SystemInformation.PowerStatus
        tbPorcentajeCarga.Text = (p.BatteryLifePercent * 100).ToString()

        Select Case p.BatteryChargeStatus
            Case BatteryChargeStatus.Charging
                picBateriaAlta.Visible = False
                picBateriaBaja.Visible = False
                picBateriaCritica.Visible = False
                picCargando.Visible = True
                tbPorcentajeCarga.Visible = True
            Case BatteryChargeStatus.Critical
                picBateriaAlta.Visible = False
                picBateriaBaja.Visible = False
                picBateriaCritica.Visible = True
                tbPorcentajeCarga.Visible = True
                picCargando.Visible = False
            Case BatteryChargeStatus.High
                picBateriaAlta.Visible = True
                picBateriaBaja.Visible = False
                picBateriaCritica.Visible = False
                tbPorcentajeCarga.Visible = True
                picCargando.Visible = False
            Case BatteryChargeStatus.Low
                picBateriaAlta.Visible = False
                picBateriaBaja.Visible = True
                picBateriaCritica.Visible = False
                tbPorcentajeCarga.Visible = True
                picCargando.Visible = False
            Case BatteryChargeStatus.NoSystemBattery
                picBateriaAlta.Visible = False
                picBateriaBaja.Visible = False
                picBateriaCritica.Visible = False
                picCargando.Visible = False
                tbPorcentajeCarga.Visible = False
                lblPor.Visible = False
        End Select

        Select Case p.PowerLineStatus
            Case PowerLineStatus.Offline
                picAlimentacion.Visible = False
            Case Else
                picAlimentacion.Visible = True
        End Select
    End Sub
    Private Sub ComprobarPorcentajeCPU()
        Static cpuCounter As PerformanceCounter = New PerformanceCounter()
        cpuCounter.CategoryName = "Processor"
        cpuCounter.CounterName = "% Processor Time"
        cpuCounter.InstanceName = "_Total"

        Dim v As Integer = Math.Truncate(cpuCounter.NextValue())
        tbCPU.Text = v.ToString()
        If v <= 30 Then tbCPU.BackColor = Color.LightGreen

        If v > 30 And v < 70 Then tbCPU.BackColor = Color.LightYellow
        If v >= 70 Then tbCPU.BackColor = Color.LightSalmon


    End Sub
    Private Sub tmrDistancia_Tick(sender As Object, e As EventArgs) Handles tmrDistancia.Tick
        DibujarRadar()
    End Sub

#Region "Configuracion"
    Function RecCfg(cad As String) As String
        Return ConfigurationSettings.AppSettings(cad).ToString()
    End Function
    Function RecCfgPosIni(cad As String) As String
        Return ConfigurationSettings.AppSettings("valor_ini_" + cad).ToString()
    End Function

    Function RecCfg(tipo As String, cad As String) As String
        Return ConfigurationSettings.AppSettings(tipo + "_" + cad).ToString()
    End Function
    Function RecCfgParada(cad As String) As String
        Return ConfigurationSettings.AppSettings("parada_" + cad).ToString()
    End Function

    Function RecCfgLimiteMin(cad As String) As String
        Dim v As String = ConfigurationSettings.AppSettings("limites_" + cad).ToString()
        Dim aCad() As String = v.Split(",")

        Return aCad(0)
    End Function
    Function RecCfgLimiteMax(cad As String) As String
        Dim v As String = ConfigurationSettings.AppSettings("limites_" + cad).ToString()
        Dim aCad() As String = v.Split(",")

        Return aCad(1)
    End Function

#End Region


    Private Sub cmdDANI_Click(sender As Object, e As EventArgs) Handles cmdDANI.Click
        EjecutarDANI()
    End Sub
    Sub EjecutarDANI()
        Dim AIML As aimlForm = New aimlForm()

        AIML.InicializarPosControl(Me.Top + Me.Height, Me.Left)
        AIML.dEjecutarComando = AddressOf EjecutarComando
        aimlForm.dEjecutarMyo = AddressOf EjecutarMyo

        AIML.Show()
    End Sub
    Sub EjecutarMyo(Comando As String, roll As Integer, pitch As Integer, yaw As Integer)
        Static MyoPitch As String = ""
        Static MyoYaw As String = ""

        Select Case Comando
            Case "CambioPosicion"
                If (pitch = MyoAbajo And MyoPitch <> "abajo") Then
                    MyoPitch = "abajo"
                    Hablar("Mio abajo")

                    EnviarSentidoMarcha(0)
                    EnviarCodigo("A", barServoVel.Value)
                ElseIf (pitch = MyoArriba And MyoPitch <> "arriba") Then
                    MyoPitch = "arriba"
                    Hablar("Mio arriba")

                    EnviarCodigo("P", 0)
                ElseIf (yaw = MyoDerecha And MyoYaw <> "derecha") Then
                ElseIf (yaw = MyoIzquierda And MyoYaw <> "izquierda") Then
                End If
            Case "Fist"
                Hablar("Mio puño")
                EjecutarComando("activar base", 0)
                CambiarServo(barServoDir, tbDirValor, 0, RecCfg("giro_centro_RASPER"))
            Case "FingersSpread"
                Hablar("Mio mano abierta")
                EjecutarComando("desactivar base", 0)
            Case "DoubleTap"
                Hablar("Mio doble chic")
            Case "WaveIn"
                Hablar("Mio mano dentro")
                MyoYaw = "derecha"
                CambiarServo(barServoDir, tbDirValor, SERVO_DIR, RecCfg("giro_derecha_RASPER"))
            Case "WaveOut"
                Hablar("Mio mano fuera")
                MyoYaw = "izquierda"

                CambiarServo(barServoDir, tbDirValor, SERVO_DIR, RecCfg("giro_izquierda_RASPER"))
        End Select
    End Sub
    Sub Hablar(cad As String)
        Dim voz As System.Speech.Synthesis.SpeechSynthesizer = New System.Speech.Synthesis.SpeechSynthesizer()
        voz.Speak(cad)
        voz.Dispose()
    End Sub
    Sub EjecutarComando(comando As String, presicion As Double)
        Try
            Select Case (comando)
                Case "movimiento adelante"
                    EnviarCodigo("b", 0)
                    EnviarSentidoMarcha(0)
                    EnviarCodigo("A", barServoVel.Value)
                    Exit Select
                Case "movimiento atras"
                    EnviarSentidoMarcha(1)
                    EnviarCodigo("A", barServoVel.Value)
                    Exit Select
                Case "parar base" 'porar motor
                    EnviarCodigo("P", 0)
                    Exit Select
                Case "griro derecha"
                    CambiarServo(barServoDir, tbDirValor, 0, RecCfg("giro_derecha_RASPER"))
                    tbDirValor.Text = Val(barServoDir.Value)
                    Exit Select
                Case "giro izquierda"
                    CambiarServo(barServoDir, tbDirValor, 0, RecCfg("giro_izquierda_RASPER"))
                    tbDirValor.Text = Val(barServoDir.Value)
                    Exit Select
                Case "activar base"
                    EnviarCodigo("b", 0)
                    Exit Select
                Case "desactivar base"
                    EnviarCodigo("b", 1)
                    Exit Select
                Case "activar cabeza"
                    EnviarCodigo("C", 0)
                    Exit Select
                Case "desactivar cabeza"
                    EnviarCodigo("C", 1)
                    Exit Select
                Case "activar cuerpo"
                    EnviarCodigo("c", 0)
                    Exit Select
                Case "desactivar cuerpo"
                    EnviarCodigo("c", 1)
                    Exit Select
                Case "apagar todo"
                    EnviarCodigo("P", 0) 'para motor
                    EnviarCodigo("b", 1) 'desactivar base
                    EnviarCodigo("c", 1) 'desactivar cuerpo
                    Exit Select
                'Case "subir cabeza"
                '    CambiarServo(_barServo_14, RecCfg("cabeza_arriba_RASPER"))
                '    Exit Select
                'Case "bajar cabeza"
                '    CambiarServo(_barServo_14, RecCfg("cabeza_abajo_RASPER"))
                '    Exit Select
                'Case "mirar derecha"
                '    CambiarServo(_barServo_13, RecCfg("cabeza_derecha_RASPER"))
                '    Exit Select
                'Case "mirar izquierda"
                '    CambiarServo(_barServo_13, RecCfg("cabeza_izquierda_RASPER"))
                '    Exit Select
            'Case "activar zona derecha"
            '    picDer.Visible = True
            '    picIzq.Visible = False
            '    Exit Select
            'Case "activar zona izquierda"
            '    picDer.Visible = False
            '    picIzq.Visible = True
            '    Exit Select
                Case "parar movimientos"
                    EnviarPosicionServo(18, Val(tbValorParar(2).Text))
                    EnviarPosicionServo(19, Val(tbValorParar(3).Text))
                    EnviarPosicionServo(20, Val(tbValorParar(4).Text))

                    EnviarPosicionServo(22, Val(tbValorParar(6).Text))
                    EnviarPosicionServo(23, Val(tbValorParar(7).Text))
                    EnviarPosicionServo(24, Val(tbValorParar(8).Text))
                    Exit Select
                Case "subir brazo derecho"
                    EnviarPosicionServo(20, 5)
                Case "subir brazo izquierdo"
                    EnviarPosicionServo(24, 5)
                Case "bajar brazo derecho"
                    EnviarPosicionServo(20, 175)
                Case "bajar brazo izquierdo"
                    EnviarPosicionServo(24, 175)

                Case "adelante brazo derecho"
                    EnviarPosicionServo(19, 5)
                Case "adelante brazo izquierdo"
                    EnviarPosicionServo(23, 175)
                Case "atras brazo derecho"
                    EnviarPosicionServo(19, 175)
                Case "atras brazo izquierdo"
                    EnviarPosicionServo(23, 5)
                Case "tirar pelota"
                    tmrLeerDatosArduino.Enabled = False
                    'adelante brazo
                    EnviarPosicionServo(19, 5)
                    'abajo brazo
                    EnviarPosicionServo(20, 175)
                    'abrir mano
                    CambiarServoConVelocidad(_barServo_0, _tbValServo_0, 2, RecCfg("pulgar_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_1, _tbValServo_1, 3, RecCfg("indice_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_2, _tbValServo_2, 4, RecCfg("medio_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_3, _tbValServo_3, 5, RecCfg("anular_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_4, _tbValServo_4, 6, RecCfg("menique_derecho_abierto"), 4, 15)
                    'girar muñeca
                    CambiarServoConVelocidad(_barServo_5, _tbValServo_5, 7, RecCfg("muneca_derecha_lado"), 4, 25)
                    tmrLeerDatosArduino.Enabled = True
                Case "girar muñeca derecha"
                    CambiarServoConVelocidad(_barServo_5, _tbValServo_5, 7, RecCfg("muneca_derecha_arriba"), 4, 25)
                Case "ladear muñeca derecha"
                    CambiarServoConVelocidad(_barServo_5, _tbValServo_5, 7, RecCfg("muneca_derecha_lado"), 4, 25)
                Case "abrir mano derecha"
                    tmrLeerDatosArduino.Enabled = False
                    CambiarServoConVelocidad(_barServo_0, _tbValServo_0, 2, RecCfg("pulgar_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_1, _tbValServo_1, 3, RecCfg("indice_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_2, _tbValServo_2, 4, RecCfg("medio_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_3, _tbValServo_3, 5, RecCfg("anular_derecho_abierto"), 4, 15)
                    CambiarServoConVelocidad(_barServo_4, _tbValServo_4, 6, RecCfg("menique_derecho_abierto"), 4, 15)
                    tmrLeerDatosArduino.Enabled = True
                Case "cerrar mano derecha"
                    tmrLeerDatosArduino.Enabled = False
                    CambiarServoConVelocidad(_barServo_0, _tbValServo_0, 2, RecCfg("pulgar_derecho_cerrado"), 4, 15)
                    CambiarServoConVelocidad(_barServo_1, _tbValServo_1, 3, RecCfg("indice_derecho_cerrado"), 4, 15)
                    CambiarServoConVelocidad(_barServo_2, _tbValServo_2, 4, RecCfg("medio_derecho_cerrado"), 4, 15)
                    CambiarServoConVelocidad(_barServo_3, _tbValServo_3, 5, RecCfg("anular_derecho_cerrado"), 4, 15)
                    CambiarServoConVelocidad(_barServo_4, _tbValServo_4, 6, RecCfg("menique_derecho_cerrado"), 4, 15)
                    tmrLeerDatosArduino.Enabled = True
                Case "abrir mano izquierda"
                    tmrLeerDatosArduino.Enabled = False
                    CambiarServo(_barServo_0, _tbValServo_0, 2, RecCfg("pulgar_izquierdo_abierto"))
                    CambiarServo(_barServo_1, _tbValServo_1, 3, RecCfg("indice_izquierdo_abierto"))
                    CambiarServo(_barServo_2, _tbValServo_2, 4, RecCfg("medio_izquierdo_abierto"))
                    CambiarServo(_barServo_3, _tbValServo_3, 5, RecCfg("anular_izquierdo_abierto"))
                    CambiarServo(_barServo_4, _tbValServo_4, 6, RecCfg("menique_izquierdo_abierto"))
                    tmrLeerDatosArduino.Enabled = True
                Case "cerrar mano izquerda"
                    tmrLeerDatosArduino.Enabled = False
                    CambiarServo(_barServo_0, _tbValServo_0, 2, RecCfg("pulgar_izquierdo_cerrado"))
                    CambiarServo(_barServo_1, _tbValServo_1, 3, RecCfg("indice_izquierdo_cerrado"))
                    CambiarServo(_barServo_2, _tbValServo_2, 4, RecCfg("medio_izquierdo_cerrado"))
                    CambiarServo(_barServo_3, _tbValServo_3, 5, RecCfg("anular_izquierdo_cerrado"))
                    CambiarServo(_barServo_4, _tbValServo_4, 6, RecCfg("menique_izquierdo_cerrado"))
                    tmrLeerDatosArduino.Enabled = True
                Case "abrir boca"
                    'CambiarServo(_barServo_12, _tbValServo_12, 14, RecCfg("boca_abierta"))
                    EnviarPosicionServo(14, RecCfg("boca_abierta"))
                    Exit Select
                Case "cerrar boca"
                    EnviarPosicionServo(14, RecCfg("boca_cerrada"))
                    Exit Select
                Case "abrir boca1"
                    'CambiarServo(_barServo_12, _tbValServo_12, 14, RecCfg("boca_abierta"))
                    EnviarPosicionServo(14, RecCfg("boca_abierta1"))
                    Exit Select
                Case "cerrar boca1"
                    EnviarPosicionServo(14, RecCfg("boca_cerrada1"))
                    Exit Select
                Case "cabeza cabeceo arriba1"
                    EnviarPosicionServo(16, RecCfg("cabeza_cabeceo_arriba1"))
                    Exit Select
                Case "cabeza cabeceo arriba2"
                    EnviarPosicionServo(16, RecCfg("cabeza_cabeceo_arriba2"))
                    Exit Select
                Case "cabeza cabeceo abajo1"
                    EnviarPosicionServo(16, RecCfg("cabeza_cabeceo_abajo1"))
                    Exit Select
                Case "cabeza cabeceo abajo2"
                    EnviarPosicionServo(16, RecCfg("cabeza_cabeceo_abajo2"))
                    Exit Select
                Case "cabeza guinada izquierda1"
                    EnviarPosicionServo(15, RecCfg("cabeza_guinada_izq1"))
                    Exit Select
                Case "cabeza guinada izquierda2"
                    EnviarPosicionServo(15, RecCfg("cabeza_guinada_izq2"))
                    Exit Select
                Case "cabeza guinada derecha1"
                    EnviarPosicionServo(15, RecCfg("cabeza_guinada_der1"))
                    Exit Select
                Case "cabeza guinada derecha2"
                    EnviarPosicionServo(15, RecCfg("cabeza_guinada_der2"))
                    Exit Select
            End Select
        Catch ex As Exception
            MessageBox.Show("Control.vb - EjecutarComando: " + ex.Message)
        End Try
    End Sub

    Public Sub CambiarServo(s As HScrollBar, tbValor As TextBox, iServo As Integer, fin As String)
        CambiarServoConVelocidad(s, tbValor, iServo, fin, 2, ESPERA_TRANSICION_SERVO * 2)
    End Sub
    Public Sub CambiarServoConVelocidad(s As HScrollBar, tbValor As TextBox, iServo As Integer, fin As String, salto As Integer, espera As Integer)
        Dim dir As Integer
        Dim vini As Integer = Convert.ToInt16(s.Value)
        Dim vfin As Integer = Convert.ToInt16(fin)

        PararComunicaciones = True

        If vini = vfin Then
            Return
        ElseIf vini < vfin Then
            dir = salto
        Else
            dir = -salto
        End If
        Dim i As Integer
        For i = vini To vfin Step dir
            Try
                s.Value = i.ToString()
                tbValor.Text = i.ToString()
                If (iServo = SERVO_DIR) Then
                    EnviarDireccion(i)
                Else
                    EnviarPosicionServo(iServo, i)
                End If
                Application.DoEvents()
                Thread.Sleep(espera)
            Catch ex As Exception
            End Try
        Next
        If i < vfin Then
            Try
                i = vfin
                s.Value = i.ToString()
                tbValor.Text = i.ToString()
                If (iServo = SERVO_DIR) Then
                    EnviarDireccion(i)
                Else
                    EnviarPosicionServo(iServo, i)
                End If
                Application.DoEvents()
                Thread.Sleep(espera)
            Catch ex As Exception
            End Try
        End If

        PararComunicaciones = False
    End Sub

    Public Sub ProcesarTeclado(e As Char)
        Dim c As String = e
        Select Case c
            Case "1" 'Control del brazo
                picBrazo.Visible = True
                picMano.Visible = False
            Case "4" 'Control de la mano
                picBrazo.Visible = False
                picMano.Visible = True
            Case "a" 'hombro der fuera
                If picBrazo.Visible Then
                    EnviarPosicionServo(18, 175)
                Else 'mover muñeca derecha
                    CambiarServo(_barServo_5, _tbValServo_5, 7, (_barServo_5.Value + INC_DIR).ToString())
                End If
            Case "d" 'hombro der dentro
                If picBrazo.Visible Then
                    EnviarPosicionServo(18, 5)
                Else 'mover muñeca derecha
                    CambiarServo(_barServo_5, _tbValServo_5, 7, (_barServo_5.Value - INC_DIR).ToString())
                End If
            Case "c" 'antebrazo der arriba
                EnviarPosicionServo(19, 175)
            Case "e" 'antebrazo der abajo
                EnviarPosicionServo(19, 5)
            Case "x" 'biceps der delante
                EnviarPosicionServo(20, 175)
            Case "w" 'biceps der detras
                EnviarPosicionServo(20, 5)
            Case "s" 'Parar movimientos parte derecha
                EnviarPosicionServo(18, Val(tbValorParar(2).Text))
                EnviarPosicionServo(19, Val(tbValorParar(3).Text))
                EnviarPosicionServo(20, Val(tbValorParar(4).Text))

            Case "l" 'hombro izq fuera
                If picBrazo.Visible Then
                    EnviarPosicionServo(22, 5)
                Else 'mover muñeca izq
                    CambiarServo(_barServo_11, _tbValServo_11, 13, (_barServo_11.Value + INC_DIR).ToString())
                End If
            Case "j" 'hombro izq dentro
                If picBrazo.Visible Then
                    EnviarPosicionServo(22, 175)
                Else 'mover muñeca izq
                    CambiarServo(_barServo_11, _tbValServo_11, 13, (_barServo_11.Value - INC_DIR).ToString())
                End If
            Case "m" 'antebrazo izq arriba
                EnviarPosicionServo(23, 175)
            Case "u" 'antebrazo izq abajo
                EnviarPosicionServo(23, 5)
            Case "." 'biceps izq delante
                If lblMAY.Text = "C" Then
                    EnviarPosicionServo(24, 175)
                Else 'cabeza abajo
                    CambiarServo(_barServo_14, _tbValServo_14, 16, (_barServo_14.Value + INC_DIR).ToString())
                End If
            Case "i" 'biceps izq detras
                EnviarPosicionServo(24, 5)
            Case "k" 'Parar movimientos parte izq
                EnviarPosicionServo(22, Val(tbValorParar(6).Text))
                EnviarPosicionServo(23, Val(tbValorParar(7).Text))
                EnviarPosicionServo(24, Val(tbValorParar(8).Text))
            Case "q" 'encender cuerpo
                EnviarCodigo("c", 0)

            Case "I" 'cabeza arriba
                CambiarServo(_barServo_14, _tbValServo_14, 16, (_barServo_14.Value - INC_DIR).ToString())
                'Case "."
                '    CambiarServo(_barServo_14, (_barServo_14.Value - INC_DIR).ToString())
            Case "J" 'cabeza izq
                CambiarServo(_barServo_13, _tbValServo_13, 15, (_barServo_13.Value - INC_DIR).ToString())
            Case "L" 'cabeza der
                CambiarServo(_barServo_13, _tbValServo_13, 15, (_barServo_13.Value + INC_DIR).ToString())
            Case "K" 'centrar cabeza
                CambiarServo(_barServo_14, _tbValServo_14, 16, RecCfg("cara_vertical_centro").ToString())
                CambiarServo(_barServo_13, _tbValServo_13, 15, RecCfg("cara_horizontal_centro").ToString())
            Case "U" 'hablar
            Case "O" 'parar hablar

            Case "A" 'derecha
                CambiarServo(barServoDir, tbDirValor, 19, (barServoDir.Value + INC_DIR).ToString())
            Case "D" 'izquierda
                CambiarServo(barServoDir, tbDirValor, 19, (barServoDir.Value - INC_DIR).ToString())
            Case "S" 'centrar dirección
                CambiarServo(barServoDir, tbDirValor, 19, RecCfg("direccion_centro").ToString())
            Case "W" 'avanzar
                EnviarSentidoMarcha(0)
            Case "X" 'retroceder
                EnviarSentidoMarcha(1)
            Case "Q" 'encender motor
                EnviarCodigo("A", barServoVel.Value)
            Case "E" 'parar motor
                EnviarCodigo("P", 0)

            Case " " 'apagar todo
                EnviarCodigo("b", 1)
                EnviarCodigo("c", 1)
            Case "B" 'encender base
                EnviarCodigo("b", 0)
            Case "C" 'encender cuerpo
                EnviarCodigo("c", 0)
        End Select
    End Sub
    Private Sub tbControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbControl.KeyPress
        ProcesarTeclado(e.KeyChar)
        e.Handled = True

    End Sub

    Private Sub tbControl_TextChanged(sender As Object, e As EventArgs) Handles tbControl.TextChanged

    End Sub

    Private Sub tbControl_Enter(sender As Object, e As EventArgs) Handles tbControl.Enter
        tbControl.BackColor = Color.Green
    End Sub

    Private Sub tbControl_Leave(sender As Object, e As EventArgs) Handles tbControl.Leave
        tbControl.BackColor = Color.Yellow
    End Sub

    Private Sub tmrDeteccion_Tick(sender As Object, e As EventArgs) Handles tmrDeteccion.Tick
        tmrDeteccion.Enabled = False
        If IsNothing(FuenteDeVideoI) And Not IsNothing(FuenteDeVideoD) Then
            If chkRostro.Checked Then DetectarRostros(picVideoI) ' Detectar y seguir rostro
            If chkMovimiento.Checked Then DetectarMovimiento()
            Application.DoEvents()
        End If
        tmrDeteccion.Enabled = True
    End Sub
    Private Sub DetectarMovimiento()
        Mov.webcam_CapturarMovimiento(picVideoI, Imagen)
    End Sub
    Private Sub DetectarRostros(picVideoD As System.Windows.Forms.PictureBox)
        Static ANTERIORX As Integer = 0
        Static ANTERIORY As Integer = 0

        Static ValorPersistente As String = ""
        Static NumeroPersistencia As Integer = 0

        Dim ENCONTRADO As Boolean = False
        Dim x As Integer = 0
        Dim y As Integer = 0

        If (IsNothing(FuenteDeVideoD)) Then Exit Sub

        Try
            'DETECCION
            Dim BMP As New Bitmap(Imagen)
            Dim TRAZO As New Pen(Brushes.Lime, 8) 'COLOR Y GROSOR
            Dim PARAMETROS As New DetectionParams(Integer.MaxValue, 0, DETECTOR.Size2Scale(100), DETECTOR.Size2Scale(BMP.Height),
                                                          1.05, 0.3, 0.2, TRAZO) 'PARAMETROS PARA WEBCAM. PARA ROSTROS MUY PEQUEÑOS 1er. DETECTOR.Size2Scale(10)
            Dim RESULTADO As DResults = DETECTOR.Detect(BMP, PARAMETROS)
            Dim ar() As Rectangle = RESULTADO.DetectedOLocs
            If ar Is Nothing Then
                ENCONTRADO = False
            ElseIf ar.Length = 0 Then
                ENCONTRADO = False
            Else
                ENCONTRADO = True
                For Each r As Rectangle In ar
                    x = (r.Top + r.Height / 2) - BMP.Height / 2
                    y = (r.Left + r.Width / 2) - BMP.Width / 2

                    'tbMarcas.Text = x & "," & y
                Next
            End If
            picVideoD.Image = BMP 'MUESTRA LA DETECCION

            If Not ENCONTRADO Then
                lblPos1.Text = "N"
                lblPos2.Text = "N"
                lblPixel.Text = ""
                lblPos1.BackColor = Color.Red
                lblPos2.BackColor = Color.Red
            Else
                lblPos1.BackColor = Color.Green
                lblPos2.BackColor = Color.Green
                tbLogInt.Text = Convert.ToInt16(y)
                If chkSeguirCara.Checked Then
                    SeguimientoRostro(y)
                End If
            End If
            If ValorPersistente = lblPos1.Text & lblPos2.Text Then
                If NumeroPersistencia < 1000 Then
                    Inc(NumeroPersistencia)
                End If
                If NumeroPersistencia > 3 Then
                    lblPos1.BackColor = Color.Green
                    lblPos2.BackColor = Color.Green
                End If
            Else
                lblPos1.BackColor = Color.Red
                lblPos2.BackColor = Color.Red
                NumeroPersistencia = 0
                ValorPersistente = lblPos1.Text & lblPos2.Text
            End If
        Catch ex As Exception
            MessageBox.Show("DetectarRostros: " + ex.Message.ToString())
        End Try
    End Sub
    Sub SeguimientoRostro(pos As Integer)
        'Tenemos que mantener la cabeza en el centro de la imagen
        Dim img_min As Integer = RecCfg("escala_seguimiento_rostro_imagen_cabeceo_min")
        Dim img_max As Integer = RecCfg("escala_seguimiento_rostro_imagen_cabeceo_max")
        Dim servo_img_min As Integer = RecCfg("escala_seguimiento_rostro_servo_cabeceo_min")
        Dim servo_img_max As Integer = RecCfg("escala_seguimiento_rostro_servo_cabeceo_max")
        Dim ancho_img As Integer = RecCfg("escala_seguimiento_rostro_ancho_imagen")

        Dim pos_servo As Integer = Convert.ToInt16(_tbValServo_13.Text)
        Dim PASO As Integer = 3

        PASO = Math.Abs(pos) / 2 * (servo_img_max - servo_img_min) / 2 / ancho_img / 2

        If pos < img_min Then
            If pos_servo - PASO > RecCfg("escala_seguimiento_rostro_servo_cabeceo_min") Then
                CambiarServoConVelocidad(_barServo_13, _tbValServo_13, 15, pos_servo - PASO, 4, 60)
                'CambiarServo(_barServo_13, _tbValServo_13, 15, pos_servo - PASO)
            End If
        ElseIf pos > img_max Then
            If pos_servo + PASO < RecCfg("escala_seguimiento_rostro_servo_cabeceo_max") Then
                CambiarServoConVelocidad(_barServo_13, _tbValServo_13, 15, pos_servo + PASO, 4, 60)
                'CambiarServo(_barServo_13, _tbValServo_13, 15, pos_servo + PASO)
            End If
        End If
    End Sub
    Private Sub chkRostro_CheckedChanged(sender As Object, e As EventArgs) Handles chkRostro.CheckedChanged
        If (chkRostro.Checked) Or (chkMovimiento.Checked) Then
            tmrDeteccion.Enabled = True
        Else
            tmrDeteccion.Enabled = False
        End If
    End Sub

    Private Sub tmrControlesGenerales_Tick(sender As Object, e As EventArgs) Handles tmrControlesGenerales.Tick
        If My.Computer.Keyboard.CapsLock Then
            lblMAY.Text = "M"
            lblMAY.BackColor = Color.LightSalmon
        Else
            lblMAY.Text = "C"
            lblMAY.BackColor = Color.LightYellow
        End If

        If frmServerWEB.VRCabeza Then
            tmrLeerDatosArduino.Enabled = False
            tbMarcas.BackColor = Color.Red
            tmrControlesGenerales.Enabled = False
            Dim v As Integer = ConvertirVR2Servo(frmServerWEB.a2, RecCfg("escala_vr_gafas_cabeceo_min"), RecCfg("escala_vr_gafas_cabeceo_max"), RecCfg("escala_vr_servo_cabeceo_min"), RecCfg("escala_vr_servo_cabeceo_max"))
            CambiarServoConVelocidad(_barServo_13, _tbValServo_13, 15, v, 4, 60)
            tbMarcas.Text = v.ToString()
            v = ConvertirVR2Servo(frmServerWEB.a1, RecCfg("escala_vr_gafas_guinada_min"), RecCfg("escala_vr_gafas_guinada_max"), RecCfg("escala_vr_servo_guinada_min"), RecCfg("escala_vr_servo_guinada_max"))
            CambiarServoConVelocidad(_barServo_14, _tbValServo_14, 16, v, 4, 60)
            tmrControlesGenerales.Enabled = True
            tbMarcas.BackColor = Color.White
            tmrLeerDatosArduino.Enabled = True
        End If
    End Sub

    Private Sub chkMovimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkMovimiento.CheckedChanged
        If (chkRostro.Checked) Or (chkMovimiento.Checked) Then
            tmrDeteccion.Enabled = True
        Else
            tmrDeteccion.Enabled = False
        End If
    End Sub

    Private Sub cmdVista3D_Click(sender As Object, e As EventArgs) Handles cmdVista3D.Click

        v3D.fControl = Me
        v3D.Show()

    End Sub

    Private Sub frmControl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'frmServerWEB.CerrarServidor()
    End Sub

    Function ConvertirVR2Servo(v_gafas As Integer, EscalaVRGafasIni As Integer, EscalaVRGafasFin As Integer, EscalaVRServoIni As Integer, EscalaVRServoFin As Integer) As Integer
        ' Calculamos el valor con base 0
        ' Realizamos la conversión de escalas con base 0
        ' Calculamos el valor en la nueva escala con base minServo
        Dim conversion_escala_base_cero As Double
        Dim valor_base As Integer ' Valor con base 0
        Dim valor As Integer

        If EscalaVRGafasFin > EscalaVRGafasIni Then
            If v_gafas > EscalaVRGafasFin Then v_gafas = EscalaVRGafasFin
            If v_gafas < EscalaVRGafasIni Then v_gafas = EscalaVRGafasIni
            valor_base = v_gafas - EscalaVRGafasIni
        Else
            If v_gafas < EscalaVRGafasFin Then v_gafas = EscalaVRGafasFin
            If v_gafas > EscalaVRGafasIni Then v_gafas = EscalaVRGafasIni
            valor_base = EscalaVRGafasIni - v_gafas
        End If

        Dim maxVR As Integer = Math.Max(EscalaVRGafasFin, EscalaVRGafasIni)
        Dim minVR As Integer = Math.Min(EscalaVRGafasFin, EscalaVRGafasIni)
        Dim maxServo As Integer = Math.Max(EscalaVRServoFin, EscalaVRServoIni)
        Dim minServo As Integer = Math.Min(EscalaVRServoFin, EscalaVRServoIni)


        conversion_escala_base_cero = (maxServo - minServo) / (maxVR - minVR) * valor_base

        If EscalaVRServoFin > EscalaVRServoIni Then
            valor = EscalaVRServoIni + conversion_escala_base_cero
        Else
            valor = EscalaVRServoFin - conversion_escala_base_cero
        End If

        Return Integer.Parse(valor)
    End Function

    Private Sub cmdCabeza0_Click(sender As Object, e As EventArgs) Handles cmdCabeza0.Click
        EnviarCodigo("C", 1)
        cmdCabeza1.BackColor = Color.LightGray
        cmdCabeza1.Tag = "OFF"
    End Sub

    Private Sub cmdCabeza1_Click(sender As Object, e As EventArgs) Handles cmdCabeza1.Click
        EnviarCodigo("C", 0)
        cmdCabeza1.BackColor = Color.Red
        cmdCabeza1.Tag = "ON"
    End Sub

    Private Sub tmrMoverBoca_Tick(sender As Object, e As EventArgs) Handles tmrMoverBoca.Tick
        Static Dim contador As Integer = 0
        contador = (contador + 1)
        Dim rnd As Random = New Random
        Dim numero As Integer = (contador Mod 2)
        Dim a As Integer = rnd.Next(10)
        If (numero = 0) Then
            If (a >= 5) Then
                EjecutarComando("cerrar boca", 1)
            Else
                EjecutarComando("cerrar boca1", 1)
            End If

        End If

        If (numero = 1) Then
            If (a >= 5) Then
                EjecutarComando("abrir boca", 1)
            Else
                EjecutarComando("abrir boca1", 1)
            End If

        End If
    End Sub
    Private Shared Sub synth_SpeakProgress(ByVal sender As Object, ByVal e As SpeakProgressEventArgs)
        If (sfrmControl.chkMoverBoca.Checked) Then
            Try
                'Localizamos si segue un signo de puntuaci?n
                Dim i As Integer = (e.CharacterPosition + e.CharacterCount)
                Do While (i < static_frase.Length)
                    Dim car() As Char = static_frase.Substring(i, 1).ToLower().ToCharArray(0, 1)
                    If ((car(0) = Microsoft.VisualBasic.ChrW(46)) _
                    OrElse ((car(0) = Microsoft.VisualBasic.ChrW(44)) _
                    OrElse ((car(0) = Microsoft.VisualBasic.ChrW(59)) _
                    OrElse ((car(0) = Microsoft.VisualBasic.ChrW(63)) _
                    OrElse (car(0) = Microsoft.VisualBasic.ChrW(33)))))) Then
                        'Paramos el movimiento de la boca temporalmente
                        If sfrmControl.chkMoverBoca.Checked Then
                            sfrmControl.EjecutarComando("cerrar boca", 1)
                        End If
                    ElseIf ((car(0) >= Microsoft.VisualBasic.ChrW(97)) _
                    AndAlso (car(0) <= Microsoft.VisualBasic.ChrW(122))) Then
                        'Comienza una nueva palabra
                        Exit Do
                    End If

                    i = (i + 1)
                Loop
            Catch ex As Exception
            End Try

        End If

    End Sub
    Private Shared Sub synth_SpeakCompleted(sender As Object, e As SpeakCompletedEventArgs)
        If (sfrmControl.chkMoverBoca.Checked) Then
            sfrmControl.tmrMoverBoca.Enabled = False
            sfrmControl.EjecutarComando("cerrar boca", 1)
            sfrmControl.tmrLeerDatosArduino.Enabled = True
        End If
    End Sub

#Region "Viejo bucle de control de datos arduino"
    Private Sub cmdArranque_Click2(ByVal eventSender As Object, ByVal eventArgs As EventArgs) 'Handles cmdArranque.Click
        Dim sCad As String = ""

        On Error GoTo error_Renamed

        If giEstado = PARADO Then
            giEstado = ARRANCADO
            picEstado.BackColor = Color.Lime

            'com.Settings = "14400,n,8,1"
            'com.CommPort = Convert.ToInt16(Conversion.Val(Strings.Mid(cbPuerto.Text, 4)))
            'com.InputLen = 0
            'com.SThreshold = 0
            'com.PortOpen = True

            While giEstado <> PARADO
                While giEstado <> PARADO And (sCad.IndexOf(";") + 1) = 0
                    'If Not (com.Input Is Nothing) Then
                    '    sCad = sCad & com.Input
                    'End If
                    Application.DoEvents()
                End While
                EscribirCom(sCad)
                RecValores(sCad)
                sCad = ""
                Application.DoEvents()
            End While

        End If
        Exit Sub
error_Renamed:
        ProcesarError()
    End Sub


    Private Sub ActualizarDatos(d As String)

        If tbCom.Text.Length > MAX_LONGITUD_TEXTO_LOG Then
            tbCom.Text = tbCom.Text.Substring(1, MAX_LONGITUD_TEXTO_LOG / 2)
        End If
        If chkDebug.Checked Then
            If InStr(sCadShared, "DBG") Then
                tbCom.Text = sCadShared & tbCom.Text
            End If
        Else
            tbCom.Text = sCadShared & tbCom.Text
        End If

    End Sub
    Private Sub tmrLeerDatosArduino_Tick(sender As Object, e As EventArgs) Handles tmrLeerDatosArduino.Tick
        tmrLeerDatosArduino.Enabled = False
        Try
            BucleSolicitudDatos(m_Servo, m_Sensor)
            ControlMovimientoBrazos()
        Catch ex As Exception
            Console.WriteLine("tmrLeerDatosArduino_Tick: " + ex.Message)
        End Try
        tmrLeerDatosArduino.Enabled = True
    End Sub

    Private Sub chkRecuperarPosiciones_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecuperarPosiciones.CheckedChanged
        If chkRecuperarPosiciones.Checked Then
            tmrLeerDatosArduino.Enabled = True
        Else
            tmrLeerDatosArduino.Enabled = False
        End If
    End Sub

#End Region

    Private Sub GrabarPosicion(NumServo As Integer, Posicion As Integer)
        Dim ficConfig As String = Application.ExecutablePath & ".config"
        Dim nServo As String = ""

        Select Case NumServo
            Case 18
                nServo = "parada_RASPER.hombro_cuerpo_derecho"
            Case 19
                nServo = "parada_RASPER.hombro_brazo_derecho"
            Case 20
                nServo = "parada_RASPER.biceps_derecho"
            Case 22
                nServo = "parada_RASPER.hombro_cuerpo_iquierdo"
            Case 23
                nServo = "parada_RASPER.hombro_brazo_iquierdo"
            Case 24
                nServo = "parada_RASPER.biceps_izquierdo"
        End Select
        If nServo <> "" Then
            Try

                ' comprobar si existe el fichero de configuración
                If System.IO.File.Exists(ficConfig) = True Then
                    configXml.Load(ficConfig)
                    cfgSetValue("configuration/appSettings", nServo, Posicion)
                    configXml.Save(ficConfig)
                End If
                '
            Catch ex As Exception
                MessageBox.Show("GrabarPosicion: " + ex.Message)
            End Try
        End If
    End Sub

    Private Sub cfgSetValue(ByVal seccion As String,
                            ByVal clave As String,
                            ByVal valor As String)
        '
        Dim n As XmlNode
        n = configXml.SelectSingleNode(seccion & "/add[@key=""" & clave & """]")
        If Not n Is Nothing Then
            n.Attributes("value").InnerText = valor
        End If
    End Sub

    Private Sub _barServoPos_2_Scroll(sender As Object, e As ScrollEventArgs) Handles _barServoPos_8.Scroll, _barServoPos_7.Scroll, _barServoPos_6.Scroll, _barServoPos_4.Scroll, _barServoPos_3.Scroll, _barServoPos_2.Scroll
        Dim Index As Integer = Array.IndexOf(barServoPos, sender)
        Select Case e.Type
            Case ScrollEventType.ThumbTrack
                'barServo_Scroll_Renamed(Index, e.NewValue)
            Case ScrollEventType.EndScroll
                'barServoPos_Change(Index, e.NewValue)
        End Select
        System.Threading.Thread.Sleep(50)
    End Sub

    Private Sub barServoPos_Change(ByRef Index As Integer, ByVal newScrollValue As Integer)
        Dim iPos As Integer = Conversion.Val(tbValServo(Index).Text)

        'UPGRADE_WARNING: (2009) Can't resolve the name of control barServo( Index ). More Information: http://www.vbtonet.com/ewis/ewi2009.aspx
        'tbValorParar(Index).Text = CStr(barServoPos(Index).Value)

    End Sub

    Private Sub ControlMovimientoBrazos()
        If chkControlMovimiento.Checked Then
            Dim Pos As Integer
            Dim Apagar As Boolean = False
            For i As Integer = 0 To 6
                If i <> 3 Then
                    Pos = Val(tbValServoPos(i + SERVO_POS_INI).Text)
                    If PosicionBrazos(i) > Pos + SERVO_POS_MARGEN Then
                        tbValServoPos(i + SERVO_POS_INI).BackColor = Color.LightSalmon
                        Apagar = True
                    ElseIf PosicionBrazos(i) < Pos - SERVO_POS_MARGEN Then
                        tbValServoPos(i + SERVO_POS_INI).BackColor = Color.LightCyan
                        Apagar = True
                    End If
                End If
            Next
            If Apagar Then
                EnviarCodigo("c", 1)
                cmdCuerpo1.BackColor = Color.LightGray
            End If
        End If
    End Sub

    Private Sub chkControlMovimiento_CheckedChanged(sender As Object, e As EventArgs) Handles chkControlMovimiento.CheckedChanged
        For i As Integer = 0 To 6
            If i <> 3 Then
                PosicionBrazos(i) = Val(tbValServoPos(i + SERVO_POS_INI).Text)
                tbValServoPos(i + SERVO_POS_INI).BackColor = Color.Yellow
            End If
        Next
    End Sub

    Private Sub _tbMin_12_TextChanged(sender As Object, e As EventArgs) Handles _tbMin_12.TextChanged

    End Sub

    Private Sub _tbValServoPos_2_TextChanged(sender As Object, e As EventArgs) Handles _tbValServoPos_8.TextChanged, _tbValServoPos_7.TextChanged, _tbValServoPos_6.TextChanged, _tbValServoPos_4.TextChanged, _tbValServoPos_3.TextChanged, _tbValServoPos_2.TextChanged
        Dim Index As Integer = Array.IndexOf(tbValServoPos, sender)

        Try
            Dim valor As Integer = Integer.Parse(tbValServoPos(Index).Text)
            If valor < barServoPos(Index).Minimum Then
                barServoPos(Index).Value = barServoPos(Index).Minimum
            ElseIf valor > barServoPos(Index).Maximum Then
                barServoPos(Index).Value = barServoPos(Index).Maximum
            Else
                barServoPos(Index).Value = tbValServoPos(Index).Text
            End If
        Catch ex As Exception
            Console.WriteLine("Control.vb - _tbValServoPos_2_TextChanged: " + ex.Message)
        End Try

    End Sub

    Private Sub tbControlPosOn_Click(sender As Object, e As EventArgs) Handles tbControlPosOn.Click
        EnviarCodigo("o", 1)
        tbControlPosOn.BackColor = Color.Red
    End Sub

    Private Sub tbControlPosOff_Click(sender As Object, e As EventArgs) Handles tbControlPosOff.Click
        EnviarCodigo("o", 0)
        tbControlPosOn.BackColor = Color.LightGray
    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        tbCom.Text = ""
    End Sub

    Private Sub tbServoPosMas1_MouseDown(sender As Object, e As MouseEventArgs) Handles tbServoPosMen7.MouseDown, tbServoPosMen6.MouseDown, tbServoPosMen5.MouseDown, tbServoPosMen3.MouseDown, tbServoPosMen2.MouseDown, tbServoPosMen1.MouseDown, tbServoPosMas7.MouseDown, tbServoPosMas6.MouseDown, tbServoPosMas5.MouseDown, tbServoPosMas3.MouseDown, tbServoPosMas2.MouseDown, tbServoPosMas1.MouseDown
        Dim Control As String = CType(sender, Button).Name.Substring(0, 13)
        Dim Num As Integer = CType(sender, Button).Name.Substring(13, 1)

        Num = Num + 1
        If (Control = "tbServoPosMas") Then
            tbValorParar(Num).Text = Val(tbValorParar(Num).Text) + 1
        Else
            tbValorParar(Num).Text = Val(tbValorParar(Num).Text) - 1
        End If

    End Sub

    Private Sub tbServoPosMas1_Click(sender As Object, e As EventArgs) Handles tbServoPosMas1.Click

    End Sub

    Private Sub tbServoPosMas6_Click(sender As Object, e As EventArgs) Handles tbServoPosMas7.Click

    End Sub

    Private Sub _tbMenos_0_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdControlLimOff_Click(sender As Object, e As EventArgs) Handles cmdControlLimOff.Click
        EnviarCodigo("L", 0)
        cmdControlLimOn.BackColor = Color.LightGray
    End Sub

    Private Sub cmdControlLimOn_Click(sender As Object, e As EventArgs) Handles cmdControlLimOn.Click
        EnviarCodigo("L", 1)
        cmdControlLimOn.BackColor = Color.LightSalmon
    End Sub

    Private Sub cmdControlLimitesOff_Click(sender As Object, e As EventArgs) Handles cmdControlLimitesOff.Click
        EnviarCodigo("Z", 0)
        cmdControlLimitesOff.BackColor = Color.LightSalmon
    End Sub

    Private Sub cmdControlLimitesOn_Click(sender As Object, e As EventArgs) Handles cmdControlLimitesOn.Click
        EnviarCodigo("Z", 1)
        cmdControlLimitesOff.BackColor = Color.LightGray
    End Sub

    Private Sub cbPosiciones_Click(sender As Object, e As EventArgs) Handles cbPosiciones.Click
        EnviarPosicionParadaServos()

    End Sub

    Private Sub cbPosiciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPosiciones.SelectedIndexChanged

        Select Case cbPosiciones.Text.Substring(0, 1)
            Case "P"
                Dim ipos = cbPosiciones.Text.Substring(1, 1)

                For i As Integer = 0 To NUM_SERVOS_ROT - 1
                    EnviarPosicionParada(aPosParada(ipos).iNumServo(i), aPosParada(ipos).iPosServo(i), "R")
                    Thread.Sleep(ESPERA_COM_INSTRUCCIONES)
                Next
            Case "M"
                Dim ipos = cbPosiciones.Text.Substring(1, 1)

                For i As Integer = 0 To NUM_SERVOS_MANOS - 1
                    EnviarPosicionServo(aPosManos(ipos).iNumServo(i), aPosManos(ipos).iPosServo(i))
                    Thread.Sleep(ESPERA_COM_INSTRUCCIONES)
                    barServo(i).Value = aPosManos(ipos).iPosServo(i)
                    tbValServo(i).Text = aPosManos(ipos).iPosServo(i)
                Next
        End Select

    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        EnviarCodigo("S", 0)
    End Sub

    Private Sub cmdEnviarPosParada_Click(sender As Object, e As EventArgs) Handles cmdEnviarPosParada.Click
        EnviarPosicionParadaServos()
    End Sub
End Class