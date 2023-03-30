<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControl
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmControl
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmControl
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmControl)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmControl
		Dim theInstance As frmControl = New frmControl()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "cmdMoverRatón", "cmdCargarNombre", "cmdResetCambios", "cmdAllCambios", "cmdInit", "tbNumMov", "tbFinMov", "cmdEnviarMovimiento", "cmdRUN_MOV", "cmdReset", "cmdSTOP", "cmdRUN", "cbTipoMov", "cmdAct", "cmdMax", "cmdMin", "cbUnidad", "tbCom", "com", "picEstado", "Parada", "cmdArranque", "CDOpen", "CDSave", "cmdEnviarPos", "cbModoEnvio", "tbNombreMov", "cmdGenerarArduino", "cbPuerto", "cmdModPos", "tbTiempoMov", "cmdBajar", "cmdSubir", "cmdRec", "cmdGrabar", "cmdCargar", "cmdDelPos", "cmdAddPos", "picRobot", "lstMov", "cbZonaMov", "chkResetModif", "cbGrabar", "_tbMax_12", "_tbMin_12", "_tbNumServo_12", "_barServo_12", "_tbValServo_12", "_tbMax_11", "_tbMax_10", "_tbMax_9", "_tbMax_8", "_tbMax_7", "_tbMax_6", "_tbMin_11", "_tbMin_10", "_tbMin_9", "_tbMin_8", "_tbMin_7", "_tbMin_6", "_tbNumServo_11", "_tbNumServo_10", "_tbNumServo_9", "_tbNumServo_8", "_tbNumServo_7", "_tbNumServo_6", "_tbValServo_9", "_tbValServo_8", "_tbValServo_7", "_tbValServo_6", "_barServo_9", "_barServo_8", "_barServo_7", "_barServo_6", "_tbValServo_10", "_barServo_10", "_tbValServo_11", "_barServo_11", "Label24", "Label23", "Label22", "Label21", "Label16", "Label15", "Frame8", "_tbMax_5", "_tbMax_4", "_tbMax_3", "_tbMax_2", "_tbMax_1", "_tbMax_0", "_tbMin_5", "_tbMin_4", "_tbMin_3", "_tbMin_2", "_tbMin_1", "_tbMin_0", "_tbNumServo_5", "_tbNumServo_4", "_tbNumServo_3", "_tbNumServo_2", "_tbNumServo_1", "_tbNumServo_0", "_barServo_5", "_tbValServo_5", "_barServo_4", "_tbValServo_4", "_barServo_0", "_barServo_1", "_barServo_2", "_barServo_3", "_tbValServo_0", "_tbValServo_1", "_tbValServo_2", "_tbValServo_3", "Label14", "Label13", "Label20", "Label19", "Label18", "Label17", "Frame9", "Label12", "Frame6", "_tbMax_22", "_tbMax_21", "_tbMin_22", "_tbMin_21", "_tbNumServo_22", "_tbNumServo_21", "_tbValServo_22", "_tbValServo_21", "_barServo_22", "_barServo_21", "Label10", "Label9", "Frame5", "_tbMax_20", "_tbMax_19", "_tbMax_18", "_tbMax_17", "_tbMin_20", "_tbMin_19", "_tbMin_18", "_tbMin_17", "_tbNumServo_20", "_tbNumServo_19", "_tbNumServo_18", "_tbNumServo_17", "_barServo_17", "_barServo_18", "_barServo_19", "_barServo_20", "_tbValServo_17", "_tbValServo_18", "_tbValServo_19", "_tbValServo_20", "Label8", "Label7", "Label6", "Label5", "Frame4", "_tbMax_16", "_tbMax_15", "_tbMax_14", "_tbMax_13", "_tbMin_16", "_tbMin_15", "_tbMin_14", "_tbMin_13", "_tbNumServo_16", "_tbNumServo_15", "_tbNumServo_14", "_tbNumServo_13", "_tbValServo_16", "_tbValServo_15", "_tbValServo_14", "_tbValServo_13", "_barServo_16", "_barServo_15", "_barServo_14", "_barServo_13", "Label4", "Label3", "Label2", "Label1", "Frame3", "Frame1", "Label29", "Label28", "Label27", "Label26", "Label25", "Label11", "barServo", "tbMax", "tbMin", "tbNumServo", "tbValServo", "listBoxHelper1", "listBoxComboBoxHelper1"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents cmdMoverRatón As System.Windows.Forms.Button
    Public WithEvents cbUnidad As System.Windows.Forms.ComboBox
	Public WithEvents tbCom As System.Windows.Forms.TextBox
    Public WithEvents picEstado As System.Windows.Forms.PictureBox
	Public WithEvents Parada As System.Windows.Forms.Button
	Public WithEvents cmdArranque As System.Windows.Forms.Button
	Public CDOpen As System.Windows.Forms.OpenFileDialog
	Public CDSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents cbModoEnvio As System.Windows.Forms.ComboBox
    Public WithEvents cmdGenerarArduino As System.Windows.Forms.Button
	Public WithEvents cbPuerto As System.Windows.Forms.ComboBox
    Public WithEvents picRobot As System.Windows.Forms.PictureBox
    Public WithEvents cbZonaMov As System.Windows.Forms.ComboBox
	Public WithEvents chkResetModif As System.Windows.Forms.CheckBox
	Public WithEvents cbGrabar As System.Windows.Forms.ComboBox
    Private WithEvents _tbMax_11 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_10 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_6 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_11 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_10 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_6 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_11 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_10 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_6 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_9 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_8 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_7 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_6 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_9 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_8 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_7 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_6 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_10 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_10 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_11 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_11 As System.Windows.Forms.HScrollBar
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Private WithEvents _tbMax_5 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_4 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_3 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbMax_0 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_5 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_4 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_3 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbMin_0 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_5 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_4 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_3 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbNumServo_0 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_5 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_5 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_4 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_4 As System.Windows.Forms.TextBox
	Private WithEvents _barServo_0 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_1 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_2 As System.Windows.Forms.HScrollBar
	Private WithEvents _barServo_3 As System.Windows.Forms.HScrollBar
	Private WithEvents _tbValServo_0 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_1 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_2 As System.Windows.Forms.TextBox
	Private WithEvents _tbValServo_3 As System.Windows.Forms.TextBox
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Private WithEvents _tbMax_14 As System.Windows.Forms.TextBox
    Private WithEvents _tbMax_13 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServo_14 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServo_13 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServo_14 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServo_13 As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Private WithEvents _tbMaxPos_9 As System.Windows.Forms.TextBox
    Private WithEvents _tbMaxPos_8 As System.Windows.Forms.TextBox
    Private WithEvents _tbMaxPos_7 As System.Windows.Forms.TextBox
    Private WithEvents _tbMaxPos_6 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_9 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_8 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_7 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_6 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_6 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_7 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_8 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_9 As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Private WithEvents _tbMaxPos_5 As System.Windows.Forms.TextBox
    Private WithEvents _tbMaxPos_4 As System.Windows.Forms.TextBox
    Private WithEvents _tbMaxPos_3 As System.Windows.Forms.TextBox
    Private WithEvents _tbMaxPos_2 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_5 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_4 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_3 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_2 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_5 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_4 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_3 As System.Windows.Forms.TextBox
    Private WithEvents _tbValServoPos_2 As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public barServo(13) As System.Windows.Forms.HScrollBar
    Public tbMax(13) As System.Windows.Forms.TextBox
    Public tbMin(13) As System.Windows.Forms.TextBox
    Public tbNumServo(13) As System.Windows.Forms.TextBox
    Public tbValServo(13) As System.Windows.Forms.TextBox

    Public tbMenos(9) As System.Windows.Forms.Button
    Public tbParar(9) As System.Windows.Forms.Button
    Public tbMas(9) As System.Windows.Forms.Button
    Public tbValorParar(9) As System.Windows.Forms.TextBox
    Public tbValorRot(9) As System.Windows.Forms.TextBox
    Public cmdPlay(9) As System.Windows.Forms.Button
    Public tbMinPos(9) As System.Windows.Forms.TextBox
    Public tbMaxPos(9) As System.Windows.Forms.TextBox
    Public tbValServoPos(9) As System.Windows.Forms.TextBox
    Public tbNumServoPos(9) As System.Windows.Forms.TextBox
    Public barServoPos(9) As System.Windows.Forms.HScrollBar

    Private listBoxHelper1 As Artinsoft.VB6.Gui.ListBoxHelper
    Private listBoxComboBoxHelper1 As Artinsoft.VB6.Gui.ListControlHelper
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControl))
        Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me._tbNumServo_11 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_10 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_9 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_8 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_7 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_6 = New System.Windows.Forms.TextBox()
        Me._tbValServo_9 = New System.Windows.Forms.TextBox()
        Me._tbValServo_8 = New System.Windows.Forms.TextBox()
        Me._tbValServo_7 = New System.Windows.Forms.TextBox()
        Me._tbValServo_6 = New System.Windows.Forms.TextBox()
        Me._tbValServo_10 = New System.Windows.Forms.TextBox()
        Me._tbValServo_11 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_5 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_4 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_3 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_2 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_1 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_0 = New System.Windows.Forms.TextBox()
        Me._tbValServo_5 = New System.Windows.Forms.TextBox()
        Me._tbValServo_4 = New System.Windows.Forms.TextBox()
        Me._tbValServo_0 = New System.Windows.Forms.TextBox()
        Me._tbValServo_1 = New System.Windows.Forms.TextBox()
        Me._tbValServo_2 = New System.Windows.Forms.TextBox()
        Me._tbValServo_3 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_14 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_13 = New System.Windows.Forms.TextBox()
        Me._tbValServo_14 = New System.Windows.Forms.TextBox()
        Me._tbValServo_13 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_9 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_8 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_7 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_6 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_6 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_7 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_8 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_9 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_5 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_4 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_3 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_2 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_5 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_4 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_3 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_2 = New System.Windows.Forms.TextBox()
        Me._tbNumServoPos_1 = New System.Windows.Forms.TextBox()
        Me._tbValServoPos_1 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tbVelValor = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.tbDirValor = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me._tbNumServo_12 = New System.Windows.Forms.TextBox()
        Me._tbValServo_12 = New System.Windows.Forms.TextBox()
        Me.cmdHablar = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.tbServoPosMas1 = New System.Windows.Forms.Button()
        Me.tbServoPosMen1 = New System.Windows.Forms.Button()
        Me.tbServoPosMen2 = New System.Windows.Forms.Button()
        Me.tbServoPosMas2 = New System.Windows.Forms.Button()
        Me.tbServoPosMen3 = New System.Windows.Forms.Button()
        Me.tbServoPosMas3 = New System.Windows.Forms.Button()
        Me.tbServoPosMen5 = New System.Windows.Forms.Button()
        Me.tbServoPosMas5 = New System.Windows.Forms.Button()
        Me.tbServoPosMen6 = New System.Windows.Forms.Button()
        Me.tbServoPosMas6 = New System.Windows.Forms.Button()
        Me.tbServoPosMen7 = New System.Windows.Forms.Button()
        Me.tbServoPosMas7 = New System.Windows.Forms.Button()
        Me.picBrazo = New System.Windows.Forms.PictureBox()
        Me.picMano = New System.Windows.Forms.PictureBox()
        Me.cmdControlLimitesOn = New System.Windows.Forms.Button()
        Me.cmdControlLimitesOff = New System.Windows.Forms.Button()
        Me.cmdControlLimOn = New System.Windows.Forms.Button()
        Me.cmdControlLimOff = New System.Windows.Forms.Button()
        Me.tbControlPosOn = New System.Windows.Forms.Button()
        Me.tbControlPosOff = New System.Windows.Forms.Button()
        Me.cmdReset = New System.Windows.Forms.Button()
        Me.cmdEnviarPosParada = New System.Windows.Forms.Button()
        Me.cmdEjecMovTemp = New System.Windows.Forms.Button()
        Me.cmdEjecutarMovRot = New System.Windows.Forms.Button()
        Me.cmdLeerPosServosRot = New System.Windows.Forms.Button()
        Me.cmdPosIni = New System.Windows.Forms.Button()
        Me.cmdSAPPO_1 = New System.Windows.Forms.Button()
        Me.cmdSAPPO_0 = New System.Windows.Forms.Button()
        Me.cmdMoverRatón = New System.Windows.Forms.Button()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.tbCom = New System.Windows.Forms.TextBox()
        Me.CDOpen = New System.Windows.Forms.OpenFileDialog()
        Me.CDSave = New System.Windows.Forms.SaveFileDialog()
        Me.cbModoEnvio = New System.Windows.Forms.ComboBox()
        Me.cmdGenerarArduino = New System.Windows.Forms.Button()
        Me.cbPuerto = New System.Windows.Forms.ComboBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me._tbMax_11 = New System.Windows.Forms.TextBox()
        Me._tbMax_10 = New System.Windows.Forms.TextBox()
        Me._tbMax_9 = New System.Windows.Forms.TextBox()
        Me._tbMax_8 = New System.Windows.Forms.TextBox()
        Me._tbMax_7 = New System.Windows.Forms.TextBox()
        Me._tbMax_6 = New System.Windows.Forms.TextBox()
        Me._tbMin_11 = New System.Windows.Forms.TextBox()
        Me._tbMin_10 = New System.Windows.Forms.TextBox()
        Me._tbMin_9 = New System.Windows.Forms.TextBox()
        Me._tbMin_8 = New System.Windows.Forms.TextBox()
        Me._tbMin_7 = New System.Windows.Forms.TextBox()
        Me._tbMin_6 = New System.Windows.Forms.TextBox()
        Me._barServo_9 = New System.Windows.Forms.HScrollBar()
        Me._barServo_8 = New System.Windows.Forms.HScrollBar()
        Me._barServo_7 = New System.Windows.Forms.HScrollBar()
        Me._barServo_6 = New System.Windows.Forms.HScrollBar()
        Me._barServo_10 = New System.Windows.Forms.HScrollBar()
        Me._barServo_11 = New System.Windows.Forms.HScrollBar()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbZonaMov = New System.Windows.Forms.ComboBox()
        Me.chkResetModif = New System.Windows.Forms.CheckBox()
        Me.cbGrabar = New System.Windows.Forms.ComboBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me._tbMax_5 = New System.Windows.Forms.TextBox()
        Me._tbMax_4 = New System.Windows.Forms.TextBox()
        Me._tbMax_3 = New System.Windows.Forms.TextBox()
        Me._tbMax_2 = New System.Windows.Forms.TextBox()
        Me._tbMax_1 = New System.Windows.Forms.TextBox()
        Me._tbMax_0 = New System.Windows.Forms.TextBox()
        Me._tbMin_5 = New System.Windows.Forms.TextBox()
        Me._tbMin_4 = New System.Windows.Forms.TextBox()
        Me._tbMin_3 = New System.Windows.Forms.TextBox()
        Me._tbMin_2 = New System.Windows.Forms.TextBox()
        Me._tbMin_1 = New System.Windows.Forms.TextBox()
        Me._tbMin_0 = New System.Windows.Forms.TextBox()
        Me._barServo_5 = New System.Windows.Forms.HScrollBar()
        Me._barServo_4 = New System.Windows.Forms.HScrollBar()
        Me._barServo_0 = New System.Windows.Forms.HScrollBar()
        Me._barServo_1 = New System.Windows.Forms.HScrollBar()
        Me._barServo_2 = New System.Windows.Forms.HScrollBar()
        Me._barServo_3 = New System.Windows.Forms.HScrollBar()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmdOff = New System.Windows.Forms.Button()
        Me.KinectAltura = New System.Windows.Forms.HScrollBar()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tbAngSonido = New System.Windows.Forms.TextBox()
        Me.cmdSensorLineaR = New System.Windows.Forms.Button()
        Me.cmdSensorLineaC = New System.Windows.Forms.Button()
        Me.cmdSensorLineaL = New System.Windows.Forms.Button()
        Me.tbLogInt = New System.Windows.Forms.TextBox()
        Me.tbMarcas = New System.Windows.Forms.TextBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.cmdPrueba = New System.Windows.Forms.Button()
        Me.lblMAY = New System.Windows.Forms.Label()
        Me.tbControl = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me._tbMax_14 = New System.Windows.Forms.TextBox()
        Me._tbMax_13 = New System.Windows.Forms.TextBox()
        Me._tbMax_12 = New System.Windows.Forms.TextBox()
        Me._tbMin_12 = New System.Windows.Forms.TextBox()
        Me._barServo_12 = New System.Windows.Forms.HScrollBar()
        Me.Label12 = New System.Windows.Forms.Label()
        Me._tbValorParar_1 = New System.Windows.Forms.TextBox()
        Me._tbParar_1 = New System.Windows.Forms.Button()
        Me._tbMenos_1 = New System.Windows.Forms.Button()
        Me._tbMas_1 = New System.Windows.Forms.Button()
        Me._tbMaxPos_1 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_1 = New System.Windows.Forms.TextBox()
        Me._barServoPos_1 = New System.Windows.Forms.HScrollBar()
        Me.Label30 = New System.Windows.Forms.Label()
        Me._tbMin_14 = New System.Windows.Forms.TextBox()
        Me._barServo_14 = New System.Windows.Forms.HScrollBar()
        Me._tbMin_13 = New System.Windows.Forms.TextBox()
        Me._barServo_13 = New System.Windows.Forms.HScrollBar()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me._cmdPlay_8 = New System.Windows.Forms.Button()
        Me._cmdPlay_7 = New System.Windows.Forms.Button()
        Me._cmdPlay_6 = New System.Windows.Forms.Button()
        Me._tbValorRot_8 = New System.Windows.Forms.TextBox()
        Me._tbValorRot_7 = New System.Windows.Forms.TextBox()
        Me._tbValorRot_6 = New System.Windows.Forms.TextBox()
        Me.cbPosiciones = New System.Windows.Forms.ComboBox()
        Me._tbMaxPos_9 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_8 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_7 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_6 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_9 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_8 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_7 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_6 = New System.Windows.Forms.TextBox()
        Me._tbParar_9 = New System.Windows.Forms.Button()
        Me._tbMenos_9 = New System.Windows.Forms.Button()
        Me._tbMas_9 = New System.Windows.Forms.Button()
        Me._tbParar_8 = New System.Windows.Forms.Button()
        Me._tbMenos_8 = New System.Windows.Forms.Button()
        Me._tbMas_8 = New System.Windows.Forms.Button()
        Me._tbParar_7 = New System.Windows.Forms.Button()
        Me._tbMenos_7 = New System.Windows.Forms.Button()
        Me._tbMas_7 = New System.Windows.Forms.Button()
        Me._tbParar_6 = New System.Windows.Forms.Button()
        Me._tbMenos_6 = New System.Windows.Forms.Button()
        Me._tbMas_6 = New System.Windows.Forms.Button()
        Me._tbMinPos_9 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_8 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_7 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_6 = New System.Windows.Forms.TextBox()
        Me._barServoPos_9 = New System.Windows.Forms.HScrollBar()
        Me._barServoPos_8 = New System.Windows.Forms.HScrollBar()
        Me._barServoPos_7 = New System.Windows.Forms.HScrollBar()
        Me._barServoPos_6 = New System.Windows.Forms.HScrollBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me._cmdPlay_4 = New System.Windows.Forms.Button()
        Me._cmdPlay_3 = New System.Windows.Forms.Button()
        Me._cmdPlay_2 = New System.Windows.Forms.Button()
        Me._tbValorRot_4 = New System.Windows.Forms.TextBox()
        Me._tbValorRot_3 = New System.Windows.Forms.TextBox()
        Me._tbValorRot_2 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_5 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_4 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_3 = New System.Windows.Forms.TextBox()
        Me._tbMaxPos_2 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_5 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_4 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_3 = New System.Windows.Forms.TextBox()
        Me._tbValorParar_2 = New System.Windows.Forms.TextBox()
        Me._tbParar_5 = New System.Windows.Forms.Button()
        Me._tbMenos_5 = New System.Windows.Forms.Button()
        Me._tbMas_5 = New System.Windows.Forms.Button()
        Me._tbParar_4 = New System.Windows.Forms.Button()
        Me._tbMenos_4 = New System.Windows.Forms.Button()
        Me._tbMas_4 = New System.Windows.Forms.Button()
        Me._tbParar_3 = New System.Windows.Forms.Button()
        Me._tbMenos_3 = New System.Windows.Forms.Button()
        Me._tbMas_3 = New System.Windows.Forms.Button()
        Me._tbParar_2 = New System.Windows.Forms.Button()
        Me._tbMenos_2 = New System.Windows.Forms.Button()
        Me._tbMas_2 = New System.Windows.Forms.Button()
        Me._tbMinPos_5 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_4 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_3 = New System.Windows.Forms.TextBox()
        Me._tbMinPos_2 = New System.Windows.Forms.TextBox()
        Me._barServoPos_5 = New System.Windows.Forms.HScrollBar()
        Me._barServoPos_4 = New System.Windows.Forms.HScrollBar()
        Me._barServoPos_3 = New System.Windows.Forms.HScrollBar()
        Me._barServoPos_2 = New System.Windows.Forms.HScrollBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.listBoxHelper1 = New Artinsoft.VB6.Gui.ListBoxHelper(Me.components)
        Me.listBoxComboBoxHelper1 = New Artinsoft.VB6.Gui.ListControlHelper(Me.components)
        Me.dispositivosD = New System.Windows.Forms.ComboBox()
        Me.dispositivosI = New System.Windows.Forms.ComboBox()
        Me.cbRostroPython = New System.Windows.Forms.ComboBox()
        Me.cbKinect = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btParar = New System.Windows.Forms.Button()
        Me.btArrancar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.HScrollBar2 = New System.Windows.Forms.HScrollBar()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbVelMax = New System.Windows.Forms.TextBox()
        Me.tbVelMin = New System.Windows.Forms.TextBox()
        Me.barServoVel = New System.Windows.Forms.HScrollBar()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btAdelante = New System.Windows.Forms.Button()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.tbServoDirMin = New System.Windows.Forms.TextBox()
        Me.barServoDir = New System.Windows.Forms.HScrollBar()
        Me.tbServoDirMax = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me._tbValorParar_0 = New System.Windows.Forms.TextBox()
        Me._tbParar_0 = New System.Windows.Forms.Button()
        Me._tbMas_0 = New System.Windows.Forms.Button()
        Me._tbMenos_0 = New System.Windows.Forms.Button()
        Me.cmdCabeza1 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmdCabeza0 = New System.Windows.Forms.Button()
        Me.cmdCuerpo1 = New System.Windows.Forms.Button()
        Me.cmdBase1 = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cmdCuerpo0 = New System.Windows.Forms.Button()
        Me.cmdBase0 = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tbTexto = New System.Windows.Forms.TextBox()
        Me.Video = New System.Windows.Forms.GroupBox()
        Me.cmdControl = New System.Windows.Forms.Button()
        Me.cmdFd = New System.Windows.Forms.Button()
        Me.cmdFoto = New System.Windows.Forms.Button()
        Me.cmdSimular = New System.Windows.Forms.Button()
        Me.chkDetecRostroPython = New System.Windows.Forms.CheckBox()
        Me.tbDebug = New System.Windows.Forms.TextBox()
        Me.chkSeguirCara = New System.Windows.Forms.CheckBox()
        Me.cmdVista3D = New System.Windows.Forms.Button()
        Me.chkMovimiento = New System.Windows.Forms.CheckBox()
        Me.lblPixel = New System.Windows.Forms.Label()
        Me.lblPos2 = New System.Windows.Forms.Label()
        Me.lblPos1 = New System.Windows.Forms.Label()
        Me.chkRostro = New System.Windows.Forms.CheckBox()
        Me.cmdResI = New System.Windows.Forms.Button()
        Me.cmdConfigI = New System.Windows.Forms.Button()
        Me.cmdFinI = New System.Windows.Forms.Button()
        Me.cmdResD = New System.Windows.Forms.Button()
        Me.cmdConfigD = New System.Windows.Forms.Button()
        Me.cmdFinD = New System.Windows.Forms.Button()
        Me.cmdIniciarI = New System.Windows.Forms.Button()
        Me.cmdIniciarD = New System.Windows.Forms.Button()
        Me.picVideoI = New System.Windows.Forms.PictureBox()
        Me.picVideoD = New System.Windows.Forms.PictureBox()
        Me.Radar = New System.Windows.Forms.GroupBox()
        Me.cmdBarridoLaserVer = New System.Windows.Forms.Button()
        Me.cmdBarridoLaserHor = New System.Windows.Forms.Button()
        Me.tbDistD = New System.Windows.Forms.TextBox()
        Me.tbDistC = New System.Windows.Forms.TextBox()
        Me.tbDistI = New System.Windows.Forms.TextBox()
        Me.tbDistT = New System.Windows.Forms.TextBox()
        Me.picRadar = New System.Windows.Forms.PictureBox()
        Me.tmrBateria = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbPorcentajeCarga = New System.Windows.Forms.TextBox()
        Me.lblPor = New System.Windows.Forms.Label()
        Me.picBateriaCritica = New System.Windows.Forms.PictureBox()
        Me.picBateriaBaja = New System.Windows.Forms.PictureBox()
        Me.picBateriaAlta = New System.Windows.Forms.PictureBox()
        Me.picAlimentacion = New System.Windows.Forms.PictureBox()
        Me.picCargando = New System.Windows.Forms.PictureBox()
        Me.tmrDistancia = New System.Windows.Forms.Timer(Me.components)
        Me.cmdDANI = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbCPU = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tmrDeteccion = New System.Windows.Forms.Timer(Me.components)
        Me.tmrControlesGenerales = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMoverBoca = New System.Windows.Forms.Timer(Me.components)
        Me.chkMoverBoca = New System.Windows.Forms.CheckBox()
        Me.tmrLeerDatosArduino = New System.Windows.Forms.Timer(Me.components)
        Me.chkRecuperarPosiciones = New System.Windows.Forms.CheckBox()
        Me.chkControlMovimiento = New System.Windows.Forms.CheckBox()
        Me.chkEnviarPosIniServosControl = New System.Windows.Forms.CheckBox()
        Me.chkDebug = New System.Windows.Forms.CheckBox()
        Me.picIzq = New System.Windows.Forms.PictureBox()
        Me.picDer = New System.Windows.Forms.PictureBox()
        Me.picEstado = New System.Windows.Forms.PictureBox()
        Me.Parada = New System.Windows.Forms.Button()
        Me.cmdArranque = New System.Windows.Forms.Button()
        Me.picRobot = New System.Windows.Forms.PictureBox()
        Me.tmrDeteccionPython = New System.Windows.Forms.Timer(Me.components)
        Me.picFrame = New System.Windows.Forms.PictureBox()
        Me.picInfo = New System.Windows.Forms.PictureBox()
        CType(Me.picBrazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame6.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame5.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.listBoxComboBoxHelper1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Video.SuspendLayout()
        CType(Me.picVideoI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVideoD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Radar.SuspendLayout()
        CType(Me.picRadar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picBateriaCritica, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBateriaBaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBateriaAlta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAlimentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCargando, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIzq, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRobot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_tbNumServo_11
        '
        Me._tbNumServo_11.AcceptsReturn = True
        Me._tbNumServo_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_11.Enabled = False
        Me._tbNumServo_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_11.Location = New System.Drawing.Point(412, 137)
        Me._tbNumServo_11.MaxLength = 0
        Me._tbNumServo_11.Name = "_tbNumServo_11"
        Me._tbNumServo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_11.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_11.TabIndex = 107
        Me._tbNumServo_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_11, "Servo nº0")
        '
        '_tbNumServo_10
        '
        Me._tbNumServo_10.AcceptsReturn = True
        Me._tbNumServo_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_10.Enabled = False
        Me._tbNumServo_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_10.Location = New System.Drawing.Point(412, 113)
        Me._tbNumServo_10.MaxLength = 0
        Me._tbNumServo_10.Name = "_tbNumServo_10"
        Me._tbNumServo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_10.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_10.TabIndex = 106
        Me._tbNumServo_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_10, "Servo nº0")
        '
        '_tbNumServo_9
        '
        Me._tbNumServo_9.AcceptsReturn = True
        Me._tbNumServo_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_9.Enabled = False
        Me._tbNumServo_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_9.Location = New System.Drawing.Point(412, 89)
        Me._tbNumServo_9.MaxLength = 0
        Me._tbNumServo_9.Name = "_tbNumServo_9"
        Me._tbNumServo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_9.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_9.TabIndex = 105
        Me._tbNumServo_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_9, "Servo nº0")
        '
        '_tbNumServo_8
        '
        Me._tbNumServo_8.AcceptsReturn = True
        Me._tbNumServo_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_8.Enabled = False
        Me._tbNumServo_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_8.Location = New System.Drawing.Point(412, 65)
        Me._tbNumServo_8.MaxLength = 0
        Me._tbNumServo_8.Name = "_tbNumServo_8"
        Me._tbNumServo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_8.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_8.TabIndex = 104
        Me._tbNumServo_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_8, "Servo nº0")
        '
        '_tbNumServo_7
        '
        Me._tbNumServo_7.AcceptsReturn = True
        Me._tbNumServo_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_7.Enabled = False
        Me._tbNumServo_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_7.Location = New System.Drawing.Point(412, 41)
        Me._tbNumServo_7.MaxLength = 0
        Me._tbNumServo_7.Name = "_tbNumServo_7"
        Me._tbNumServo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_7.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_7.TabIndex = 103
        Me._tbNumServo_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_7, "Servo nº0")
        '
        '_tbNumServo_6
        '
        Me._tbNumServo_6.AcceptsReturn = True
        Me._tbNumServo_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_6.Enabled = False
        Me._tbNumServo_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_6.Location = New System.Drawing.Point(412, 17)
        Me._tbNumServo_6.MaxLength = 0
        Me._tbNumServo_6.Name = "_tbNumServo_6"
        Me._tbNumServo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_6.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_6.TabIndex = 102
        Me._tbNumServo_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_6, "Servo nº0")
        '
        '_tbValServo_9
        '
        Me._tbValServo_9.AcceptsReturn = True
        Me._tbValServo_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_9.Location = New System.Drawing.Point(368, 89)
        Me._tbValServo_9.MaxLength = 0
        Me._tbValServo_9.Name = "_tbValServo_9"
        Me._tbValServo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_9.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_9.TabIndex = 66
        Me._tbValServo_9.Text = "2500"
        Me._tbValServo_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_9, "Servo nº9")
        '
        '_tbValServo_8
        '
        Me._tbValServo_8.AcceptsReturn = True
        Me._tbValServo_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_8.Location = New System.Drawing.Point(368, 65)
        Me._tbValServo_8.MaxLength = 0
        Me._tbValServo_8.Name = "_tbValServo_8"
        Me._tbValServo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_8.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_8.TabIndex = 65
        Me._tbValServo_8.Text = "2500"
        Me._tbValServo_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_8, "Servo nº8")
        '
        '_tbValServo_7
        '
        Me._tbValServo_7.AcceptsReturn = True
        Me._tbValServo_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_7.Location = New System.Drawing.Point(368, 41)
        Me._tbValServo_7.MaxLength = 0
        Me._tbValServo_7.Name = "_tbValServo_7"
        Me._tbValServo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_7.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_7.TabIndex = 64
        Me._tbValServo_7.Text = "2500"
        Me._tbValServo_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_7, "Servo nº7")
        '
        '_tbValServo_6
        '
        Me._tbValServo_6.AcceptsReturn = True
        Me._tbValServo_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_6.Location = New System.Drawing.Point(368, 17)
        Me._tbValServo_6.MaxLength = 0
        Me._tbValServo_6.Name = "_tbValServo_6"
        Me._tbValServo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_6.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_6.TabIndex = 63
        Me._tbValServo_6.Text = "2500"
        Me._tbValServo_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_6, "Servo nº6")
        '
        '_tbValServo_10
        '
        Me._tbValServo_10.AcceptsReturn = True
        Me._tbValServo_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_10.Location = New System.Drawing.Point(368, 113)
        Me._tbValServo_10.MaxLength = 0
        Me._tbValServo_10.Name = "_tbValServo_10"
        Me._tbValServo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_10.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_10.TabIndex = 58
        Me._tbValServo_10.Text = "2500"
        Me._tbValServo_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_10, "Servo nº10")
        '
        '_tbValServo_11
        '
        Me._tbValServo_11.AcceptsReturn = True
        Me._tbValServo_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_11.Location = New System.Drawing.Point(368, 137)
        Me._tbValServo_11.MaxLength = 0
        Me._tbValServo_11.Name = "_tbValServo_11"
        Me._tbValServo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_11.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_11.TabIndex = 56
        Me._tbValServo_11.Text = "2500"
        Me._tbValServo_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_11, "Servo nº011")
        '
        '_tbNumServo_5
        '
        Me._tbNumServo_5.AcceptsReturn = True
        Me._tbNumServo_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_5.Enabled = False
        Me._tbNumServo_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_5.Location = New System.Drawing.Point(410, 137)
        Me._tbNumServo_5.MaxLength = 0
        Me._tbNumServo_5.Name = "_tbNumServo_5"
        Me._tbNumServo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_5.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_5.TabIndex = 101
        Me._tbNumServo_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_5, "Servo nº0")
        '
        '_tbNumServo_4
        '
        Me._tbNumServo_4.AcceptsReturn = True
        Me._tbNumServo_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_4.Enabled = False
        Me._tbNumServo_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_4.Location = New System.Drawing.Point(410, 113)
        Me._tbNumServo_4.MaxLength = 0
        Me._tbNumServo_4.Name = "_tbNumServo_4"
        Me._tbNumServo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_4.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_4.TabIndex = 100
        Me._tbNumServo_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_4, "Servo nº0")
        '
        '_tbNumServo_3
        '
        Me._tbNumServo_3.AcceptsReturn = True
        Me._tbNumServo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_3.Enabled = False
        Me._tbNumServo_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_3.Location = New System.Drawing.Point(410, 89)
        Me._tbNumServo_3.MaxLength = 0
        Me._tbNumServo_3.Name = "_tbNumServo_3"
        Me._tbNumServo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_3.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_3.TabIndex = 99
        Me._tbNumServo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_3, "Servo nº0")
        '
        '_tbNumServo_2
        '
        Me._tbNumServo_2.AcceptsReturn = True
        Me._tbNumServo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_2.Enabled = False
        Me._tbNumServo_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_2.Location = New System.Drawing.Point(410, 65)
        Me._tbNumServo_2.MaxLength = 0
        Me._tbNumServo_2.Name = "_tbNumServo_2"
        Me._tbNumServo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_2.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_2.TabIndex = 98
        Me._tbNumServo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_2, "Servo nº0")
        '
        '_tbNumServo_1
        '
        Me._tbNumServo_1.AcceptsReturn = True
        Me._tbNumServo_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_1.Enabled = False
        Me._tbNumServo_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_1.Location = New System.Drawing.Point(410, 41)
        Me._tbNumServo_1.MaxLength = 0
        Me._tbNumServo_1.Name = "_tbNumServo_1"
        Me._tbNumServo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_1.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_1.TabIndex = 97
        Me._tbNumServo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_1, "Servo nº0")
        '
        '_tbNumServo_0
        '
        Me._tbNumServo_0.AcceptsReturn = True
        Me._tbNumServo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_0.Enabled = False
        Me._tbNumServo_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_0.Location = New System.Drawing.Point(410, 17)
        Me._tbNumServo_0.MaxLength = 0
        Me._tbNumServo_0.Name = "_tbNumServo_0"
        Me._tbNumServo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_0.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_0.TabIndex = 96
        Me._tbNumServo_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_0, "Servo nº0")
        '
        '_tbValServo_5
        '
        Me._tbValServo_5.AcceptsReturn = True
        Me._tbValServo_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_5.Location = New System.Drawing.Point(368, 137)
        Me._tbValServo_5.MaxLength = 0
        Me._tbValServo_5.Name = "_tbValServo_5"
        Me._tbValServo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_5.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_5.TabIndex = 51
        Me._tbValServo_5.Text = "2500"
        Me._tbValServo_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_5, "Servo nº5")
        '
        '_tbValServo_4
        '
        Me._tbValServo_4.AcceptsReturn = True
        Me._tbValServo_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_4.Location = New System.Drawing.Point(368, 113)
        Me._tbValServo_4.MaxLength = 0
        Me._tbValServo_4.Name = "_tbValServo_4"
        Me._tbValServo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_4.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_4.TabIndex = 48
        Me._tbValServo_4.Text = "2500"
        Me._tbValServo_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_4, "Servo nº4")
        '
        '_tbValServo_0
        '
        Me._tbValServo_0.AcceptsReturn = True
        Me._tbValServo_0.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_0.Location = New System.Drawing.Point(368, 17)
        Me._tbValServo_0.MaxLength = 0
        Me._tbValServo_0.Name = "_tbValServo_0"
        Me._tbValServo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_0.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_0.TabIndex = 39
        Me._tbValServo_0.Text = "2500"
        Me._tbValServo_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_0, "Servo nº0")
        '
        '_tbValServo_1
        '
        Me._tbValServo_1.AcceptsReturn = True
        Me._tbValServo_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_1.Location = New System.Drawing.Point(368, 41)
        Me._tbValServo_1.MaxLength = 0
        Me._tbValServo_1.Name = "_tbValServo_1"
        Me._tbValServo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_1.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_1.TabIndex = 38
        Me._tbValServo_1.Text = "2500"
        Me._tbValServo_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_1, "Servo nº1")
        '
        '_tbValServo_2
        '
        Me._tbValServo_2.AcceptsReturn = True
        Me._tbValServo_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_2.Location = New System.Drawing.Point(368, 65)
        Me._tbValServo_2.MaxLength = 0
        Me._tbValServo_2.Name = "_tbValServo_2"
        Me._tbValServo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_2.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_2.TabIndex = 37
        Me._tbValServo_2.Text = "2500"
        Me._tbValServo_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_2, "Servo nº2")
        '
        '_tbValServo_3
        '
        Me._tbValServo_3.AcceptsReturn = True
        Me._tbValServo_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_3.Location = New System.Drawing.Point(368, 89)
        Me._tbValServo_3.MaxLength = 0
        Me._tbValServo_3.Name = "_tbValServo_3"
        Me._tbValServo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_3.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_3.TabIndex = 36
        Me._tbValServo_3.Text = "2500"
        Me._tbValServo_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_3, "Servo nº3")
        '
        '_tbNumServo_14
        '
        Me._tbNumServo_14.AcceptsReturn = True
        Me._tbNumServo_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_14.Enabled = False
        Me._tbNumServo_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_14.Location = New System.Drawing.Point(428, 69)
        Me._tbNumServo_14.MaxLength = 0
        Me._tbNumServo_14.Name = "_tbNumServo_14"
        Me._tbNumServo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_14.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_14.TabIndex = 118
        Me._tbNumServo_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_14, "Servo nº0")
        '
        '_tbNumServo_13
        '
        Me._tbNumServo_13.AcceptsReturn = True
        Me._tbNumServo_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_13.Enabled = False
        Me._tbNumServo_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_13.Location = New System.Drawing.Point(428, 45)
        Me._tbNumServo_13.MaxLength = 0
        Me._tbNumServo_13.Name = "_tbNumServo_13"
        Me._tbNumServo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_13.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_13.TabIndex = 117
        Me._tbNumServo_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_13, "Servo nº0")
        '
        '_tbValServo_14
        '
        Me._tbValServo_14.AcceptsReturn = True
        Me._tbValServo_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_14.Location = New System.Drawing.Point(386, 69)
        Me._tbValServo_14.MaxLength = 0
        Me._tbValServo_14.Name = "_tbValServo_14"
        Me._tbValServo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_14.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_14.TabIndex = 31
        Me._tbValServo_14.Text = "2500"
        Me._tbValServo_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_14, "Servo nº22")
        '
        '_tbValServo_13
        '
        Me._tbValServo_13.AcceptsReturn = True
        Me._tbValServo_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_13.Location = New System.Drawing.Point(386, 45)
        Me._tbValServo_13.MaxLength = 0
        Me._tbValServo_13.Name = "_tbValServo_13"
        Me._tbValServo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_13.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_13.TabIndex = 30
        Me._tbValServo_13.Text = "2500"
        Me._tbValServo_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_13, "Servo nº21")
        '
        '_tbNumServoPos_9
        '
        Me._tbNumServoPos_9.AcceptsReturn = True
        Me._tbNumServoPos_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_9.Enabled = False
        Me._tbNumServoPos_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_9.Location = New System.Drawing.Point(534, 111)
        Me._tbNumServoPos_9.MaxLength = 0
        Me._tbNumServoPos_9.Name = "_tbNumServoPos_9"
        Me._tbNumServoPos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_9.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_9.TabIndex = 116
        Me._tbNumServoPos_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_9, "Servo nº0")
        '
        '_tbNumServoPos_8
        '
        Me._tbNumServoPos_8.AcceptsReturn = True
        Me._tbNumServoPos_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_8.Enabled = False
        Me._tbNumServoPos_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_8.Location = New System.Drawing.Point(538, 62)
        Me._tbNumServoPos_8.MaxLength = 0
        Me._tbNumServoPos_8.Name = "_tbNumServoPos_8"
        Me._tbNumServoPos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_8.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_8.TabIndex = 115
        Me._tbNumServoPos_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_8, "Servo nº0")
        '
        '_tbNumServoPos_7
        '
        Me._tbNumServoPos_7.AcceptsReturn = True
        Me._tbNumServoPos_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_7.Enabled = False
        Me._tbNumServoPos_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_7.Location = New System.Drawing.Point(538, 38)
        Me._tbNumServoPos_7.MaxLength = 0
        Me._tbNumServoPos_7.Name = "_tbNumServoPos_7"
        Me._tbNumServoPos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_7.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_7.TabIndex = 114
        Me._tbNumServoPos_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_7, "Servo nº0")
        '
        '_tbNumServoPos_6
        '
        Me._tbNumServoPos_6.AcceptsReturn = True
        Me._tbNumServoPos_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_6.Enabled = False
        Me._tbNumServoPos_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_6.Location = New System.Drawing.Point(538, 14)
        Me._tbNumServoPos_6.MaxLength = 0
        Me._tbNumServoPos_6.Name = "_tbNumServoPos_6"
        Me._tbNumServoPos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_6.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_6.TabIndex = 113
        Me._tbNumServoPos_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_6, "Servo nº0")
        '
        '_tbValServoPos_6
        '
        Me._tbValServoPos_6.AcceptsReturn = True
        Me._tbValServoPos_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_6.Location = New System.Drawing.Point(510, 14)
        Me._tbValServoPos_6.MaxLength = 0
        Me._tbValServoPos_6.Name = "_tbValServoPos_6"
        Me._tbValServoPos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_6.Size = New System.Drawing.Size(29, 24)
        Me._tbValServoPos_6.TabIndex = 18
        Me._tbValServoPos_6.Text = "250"
        Me._tbValServoPos_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_6, "Servo nº17")
        '
        '_tbValServoPos_7
        '
        Me._tbValServoPos_7.AcceptsReturn = True
        Me._tbValServoPos_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_7.Location = New System.Drawing.Point(510, 38)
        Me._tbValServoPos_7.MaxLength = 0
        Me._tbValServoPos_7.Name = "_tbValServoPos_7"
        Me._tbValServoPos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_7.Size = New System.Drawing.Size(29, 24)
        Me._tbValServoPos_7.TabIndex = 17
        Me._tbValServoPos_7.Text = "250"
        Me._tbValServoPos_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_7, "Servo nº18")
        '
        '_tbValServoPos_8
        '
        Me._tbValServoPos_8.AcceptsReturn = True
        Me._tbValServoPos_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_8.Location = New System.Drawing.Point(510, 62)
        Me._tbValServoPos_8.MaxLength = 0
        Me._tbValServoPos_8.Name = "_tbValServoPos_8"
        Me._tbValServoPos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_8.Size = New System.Drawing.Size(29, 24)
        Me._tbValServoPos_8.TabIndex = 16
        Me._tbValServoPos_8.Text = "250"
        Me._tbValServoPos_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_8, "Servo nº19")
        '
        '_tbValServoPos_9
        '
        Me._tbValServoPos_9.AcceptsReturn = True
        Me._tbValServoPos_9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_9.Location = New System.Drawing.Point(492, 111)
        Me._tbValServoPos_9.MaxLength = 0
        Me._tbValServoPos_9.Name = "_tbValServoPos_9"
        Me._tbValServoPos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_9.Size = New System.Drawing.Size(43, 24)
        Me._tbValServoPos_9.TabIndex = 15
        Me._tbValServoPos_9.Text = "2500"
        Me._tbValServoPos_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_9, "Servo nº20")
        '
        '_tbNumServoPos_5
        '
        Me._tbNumServoPos_5.AcceptsReturn = True
        Me._tbNumServoPos_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_5.Enabled = False
        Me._tbNumServoPos_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_5.Location = New System.Drawing.Point(538, 98)
        Me._tbNumServoPos_5.MaxLength = 0
        Me._tbNumServoPos_5.Name = "_tbNumServoPos_5"
        Me._tbNumServoPos_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_5.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_5.TabIndex = 112
        Me._tbNumServoPos_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_5, "Servo nº0")
        '
        '_tbNumServoPos_4
        '
        Me._tbNumServoPos_4.AcceptsReturn = True
        Me._tbNumServoPos_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_4.Enabled = False
        Me._tbNumServoPos_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_4.Location = New System.Drawing.Point(538, 64)
        Me._tbNumServoPos_4.MaxLength = 0
        Me._tbNumServoPos_4.Name = "_tbNumServoPos_4"
        Me._tbNumServoPos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_4.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_4.TabIndex = 111
        Me._tbNumServoPos_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_4, "Servo nº0")
        '
        '_tbNumServoPos_3
        '
        Me._tbNumServoPos_3.AcceptsReturn = True
        Me._tbNumServoPos_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_3.Enabled = False
        Me._tbNumServoPos_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_3.Location = New System.Drawing.Point(538, 40)
        Me._tbNumServoPos_3.MaxLength = 0
        Me._tbNumServoPos_3.Name = "_tbNumServoPos_3"
        Me._tbNumServoPos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_3.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_3.TabIndex = 110
        Me._tbNumServoPos_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_3, "Servo nº0")
        '
        '_tbNumServoPos_2
        '
        Me._tbNumServoPos_2.AcceptsReturn = True
        Me._tbNumServoPos_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_2.Enabled = False
        Me._tbNumServoPos_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_2.Location = New System.Drawing.Point(538, 16)
        Me._tbNumServoPos_2.MaxLength = 0
        Me._tbNumServoPos_2.Name = "_tbNumServoPos_2"
        Me._tbNumServoPos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_2.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_2.TabIndex = 109
        Me._tbNumServoPos_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_2, "Servo nº0")
        '
        '_tbValServoPos_5
        '
        Me._tbValServoPos_5.AcceptsReturn = True
        Me._tbValServoPos_5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_5.Location = New System.Drawing.Point(496, 98)
        Me._tbValServoPos_5.MaxLength = 0
        Me._tbValServoPos_5.Name = "_tbValServoPos_5"
        Me._tbValServoPos_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_5.Size = New System.Drawing.Size(43, 24)
        Me._tbValServoPos_5.TabIndex = 13
        Me._tbValServoPos_5.Text = "2500"
        Me._tbValServoPos_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_5, "Servo nº16")
        '
        '_tbValServoPos_4
        '
        Me._tbValServoPos_4.AcceptsReturn = True
        Me._tbValServoPos_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_4.Location = New System.Drawing.Point(509, 64)
        Me._tbValServoPos_4.MaxLength = 0
        Me._tbValServoPos_4.Name = "_tbValServoPos_4"
        Me._tbValServoPos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_4.Size = New System.Drawing.Size(30, 24)
        Me._tbValServoPos_4.TabIndex = 12
        Me._tbValServoPos_4.Text = "250"
        Me._tbValServoPos_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_4, "Servo nº15")
        '
        '_tbValServoPos_3
        '
        Me._tbValServoPos_3.AcceptsReturn = True
        Me._tbValServoPos_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_3.Location = New System.Drawing.Point(509, 40)
        Me._tbValServoPos_3.MaxLength = 0
        Me._tbValServoPos_3.Name = "_tbValServoPos_3"
        Me._tbValServoPos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_3.Size = New System.Drawing.Size(30, 24)
        Me._tbValServoPos_3.TabIndex = 11
        Me._tbValServoPos_3.Text = "250"
        Me._tbValServoPos_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_3, "Servo nº14")
        '
        '_tbValServoPos_2
        '
        Me._tbValServoPos_2.AcceptsReturn = True
        Me._tbValServoPos_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_2.Location = New System.Drawing.Point(509, 16)
        Me._tbValServoPos_2.MaxLength = 0
        Me._tbValServoPos_2.Name = "_tbValServoPos_2"
        Me._tbValServoPos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_2.Size = New System.Drawing.Size(30, 24)
        Me._tbValServoPos_2.TabIndex = 10
        Me._tbValServoPos_2.Text = "250"
        Me._tbValServoPos_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_2, "Servo nº13")
        '
        '_tbNumServoPos_1
        '
        Me._tbNumServoPos_1.AcceptsReturn = True
        Me._tbNumServoPos_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServoPos_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServoPos_1.Enabled = False
        Me._tbNumServoPos_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServoPos_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServoPos_1.Location = New System.Drawing.Point(534, 98)
        Me._tbNumServoPos_1.MaxLength = 0
        Me._tbNumServoPos_1.Name = "_tbNumServoPos_1"
        Me._tbNumServoPos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServoPos_1.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServoPos_1.TabIndex = 190
        Me._tbNumServoPos_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServoPos_1, "Servo nº0")
        '
        '_tbValServoPos_1
        '
        Me._tbValServoPos_1.AcceptsReturn = True
        Me._tbValServoPos_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServoPos_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServoPos_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServoPos_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServoPos_1.Location = New System.Drawing.Point(492, 98)
        Me._tbValServoPos_1.MaxLength = 0
        Me._tbValServoPos_1.Name = "_tbValServoPos_1"
        Me._tbValServoPos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServoPos_1.Size = New System.Drawing.Size(43, 24)
        Me._tbValServoPos_1.TabIndex = 187
        Me._tbValServoPos_1.Text = "2500"
        Me._tbValServoPos_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServoPos_1, "Servo nº12")
        '
        'TextBox4
        '
        Me.TextBox4.AcceptsReturn = True
        Me.TextBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox4.Location = New System.Drawing.Point(453, 47)
        Me.TextBox4.MaxLength = 0
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox4.Size = New System.Drawing.Size(25, 24)
        Me.TextBox4.TabIndex = 190
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me.TextBox4, "Servo nº0")
        '
        'tbVelValor
        '
        Me.tbVelValor.AcceptsReturn = True
        Me.tbVelValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbVelValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVelValor.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVelValor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbVelValor.Location = New System.Drawing.Point(411, 47)
        Me.tbVelValor.MaxLength = 0
        Me.tbVelValor.Name = "tbVelValor"
        Me.tbVelValor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbVelValor.Size = New System.Drawing.Size(43, 24)
        Me.tbVelValor.TabIndex = 187
        Me.tbVelValor.Text = "2500"
        Me.tbVelValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me.tbVelValor, "Servo nº12")
        '
        'TextBox12
        '
        Me.TextBox12.AcceptsReturn = True
        Me.TextBox12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox12.Enabled = False
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox12.Location = New System.Drawing.Point(453, 20)
        Me.TextBox12.MaxLength = 0
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox12.Size = New System.Drawing.Size(25, 24)
        Me.TextBox12.TabIndex = 117
        Me.TextBox12.Text = "26"
        Me.TextBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me.TextBox12, "Servo nº0")
        '
        'tbDirValor
        '
        Me.tbDirValor.AcceptsReturn = True
        Me.tbDirValor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbDirValor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDirValor.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDirValor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDirValor.Location = New System.Drawing.Point(411, 20)
        Me.tbDirValor.MaxLength = 0
        Me.tbDirValor.Name = "tbDirValor"
        Me.tbDirValor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDirValor.Size = New System.Drawing.Size(43, 24)
        Me.tbDirValor.TabIndex = 30
        Me.tbDirValor.Text = "2500"
        Me.tbDirValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me.tbDirValor, "Servo nº21")
        '
        'TextBox7
        '
        Me.TextBox7.AcceptsReturn = True
        Me.TextBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox7.Location = New System.Drawing.Point(453, 74)
        Me.TextBox7.MaxLength = 0
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox7.Size = New System.Drawing.Size(25, 24)
        Me.TextBox7.TabIndex = 196
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me.TextBox7, "Servo nº0")
        '
        'TextBox9
        '
        Me.TextBox9.AcceptsReturn = True
        Me.TextBox9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TextBox9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox9.Location = New System.Drawing.Point(411, 74)
        Me.TextBox9.MaxLength = 0
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox9.Size = New System.Drawing.Size(43, 24)
        Me.TextBox9.TabIndex = 194
        Me.TextBox9.Text = "2500"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me.TextBox9, "Servo nº011")
        '
        '_tbNumServo_12
        '
        Me._tbNumServo_12.AcceptsReturn = True
        Me._tbNumServo_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbNumServo_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbNumServo_12.Enabled = False
        Me._tbNumServo_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbNumServo_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbNumServo_12.Location = New System.Drawing.Point(428, 20)
        Me._tbNumServo_12.MaxLength = 0
        Me._tbNumServo_12.Name = "_tbNumServo_12"
        Me._tbNumServo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbNumServo_12.Size = New System.Drawing.Size(25, 24)
        Me._tbNumServo_12.TabIndex = 200
        Me._tbNumServo_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbNumServo_12, "Servo nº0")
        '
        '_tbValServo_12
        '
        Me._tbValServo_12.AcceptsReturn = True
        Me._tbValServo_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValServo_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValServo_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValServo_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValServo_12.Location = New System.Drawing.Point(386, 20)
        Me._tbValServo_12.MaxLength = 0
        Me._tbValServo_12.Name = "_tbValServo_12"
        Me._tbValServo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValServo_12.Size = New System.Drawing.Size(43, 24)
        Me._tbValServo_12.TabIndex = 197
        Me._tbValServo_12.Text = "2500"
        Me._tbValServo_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTipMain.SetToolTip(Me._tbValServo_12, "Servo nº12")
        '
        'cmdHablar
        '
        Me.cmdHablar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdHablar.Location = New System.Drawing.Point(429, 708)
        Me.cmdHablar.Name = "cmdHablar"
        Me.cmdHablar.Size = New System.Drawing.Size(66, 23)
        Me.cmdHablar.TabIndex = 195
        Me.cmdHablar.Text = "HABLAR"
        Me.ToolTipMain.SetToolTip(Me.cmdHablar, "HABLAR")
        Me.cmdHablar.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cmdBorrar.Location = New System.Drawing.Point(429, 681)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(66, 27)
        Me.cmdBorrar.TabIndex = 209
        Me.cmdBorrar.Text = "BORRAR"
        Me.ToolTipMain.SetToolTip(Me.cmdBorrar, "HABLAR")
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'tbServoPosMas1
        '
        Me.tbServoPosMas1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMas1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMas1.Location = New System.Drawing.Point(244, 14)
        Me.tbServoPosMas1.Name = "tbServoPosMas1"
        Me.tbServoPosMas1.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMas1.TabIndex = 196
        Me.tbServoPosMas1.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMas1, "HABLAR")
        Me.tbServoPosMas1.UseVisualStyleBackColor = False
        '
        'tbServoPosMen1
        '
        Me.tbServoPosMen1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMen1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMen1.Location = New System.Drawing.Point(244, 27)
        Me.tbServoPosMen1.Name = "tbServoPosMen1"
        Me.tbServoPosMen1.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMen1.TabIndex = 197
        Me.tbServoPosMen1.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMen1, "HABLAR")
        Me.tbServoPosMen1.UseVisualStyleBackColor = False
        '
        'tbServoPosMen2
        '
        Me.tbServoPosMen2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMen2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMen2.Location = New System.Drawing.Point(244, 52)
        Me.tbServoPosMen2.Name = "tbServoPosMen2"
        Me.tbServoPosMen2.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMen2.TabIndex = 199
        Me.tbServoPosMen2.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMen2, "HABLAR")
        Me.tbServoPosMen2.UseVisualStyleBackColor = False
        '
        'tbServoPosMas2
        '
        Me.tbServoPosMas2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMas2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMas2.Location = New System.Drawing.Point(244, 39)
        Me.tbServoPosMas2.Name = "tbServoPosMas2"
        Me.tbServoPosMas2.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMas2.TabIndex = 198
        Me.tbServoPosMas2.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMas2, "HABLAR")
        Me.tbServoPosMas2.UseVisualStyleBackColor = False
        '
        'tbServoPosMen3
        '
        Me.tbServoPosMen3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMen3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMen3.Location = New System.Drawing.Point(244, 77)
        Me.tbServoPosMen3.Name = "tbServoPosMen3"
        Me.tbServoPosMen3.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMen3.TabIndex = 201
        Me.tbServoPosMen3.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMen3, "HABLAR")
        Me.tbServoPosMen3.UseVisualStyleBackColor = False
        '
        'tbServoPosMas3
        '
        Me.tbServoPosMas3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMas3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMas3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMas3.Location = New System.Drawing.Point(244, 64)
        Me.tbServoPosMas3.Name = "tbServoPosMas3"
        Me.tbServoPosMas3.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMas3.TabIndex = 200
        Me.tbServoPosMas3.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMas3, "HABLAR")
        Me.tbServoPosMas3.UseVisualStyleBackColor = False
        '
        'tbServoPosMen5
        '
        Me.tbServoPosMen5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMen5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMen5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMen5.Location = New System.Drawing.Point(244, 23)
        Me.tbServoPosMen5.Name = "tbServoPosMen5"
        Me.tbServoPosMen5.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMen5.TabIndex = 211
        Me.tbServoPosMen5.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMen5, "HABLAR")
        Me.tbServoPosMen5.UseVisualStyleBackColor = False
        '
        'tbServoPosMas5
        '
        Me.tbServoPosMas5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMas5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMas5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMas5.Location = New System.Drawing.Point(244, 10)
        Me.tbServoPosMas5.Name = "tbServoPosMas5"
        Me.tbServoPosMas5.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMas5.TabIndex = 210
        Me.tbServoPosMas5.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMas5, "HABLAR")
        Me.tbServoPosMas5.UseVisualStyleBackColor = False
        '
        'tbServoPosMen6
        '
        Me.tbServoPosMen6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMen6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMen6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMen6.Location = New System.Drawing.Point(244, 51)
        Me.tbServoPosMen6.Name = "tbServoPosMen6"
        Me.tbServoPosMen6.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMen6.TabIndex = 213
        Me.tbServoPosMen6.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMen6, "HABLAR")
        Me.tbServoPosMen6.UseVisualStyleBackColor = False
        '
        'tbServoPosMas6
        '
        Me.tbServoPosMas6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMas6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMas6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMas6.Location = New System.Drawing.Point(244, 38)
        Me.tbServoPosMas6.Name = "tbServoPosMas6"
        Me.tbServoPosMas6.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMas6.TabIndex = 212
        Me.tbServoPosMas6.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMas6, "HABLAR")
        Me.tbServoPosMas6.UseVisualStyleBackColor = False
        '
        'tbServoPosMen7
        '
        Me.tbServoPosMen7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMen7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMen7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMen7.Location = New System.Drawing.Point(244, 76)
        Me.tbServoPosMen7.Name = "tbServoPosMen7"
        Me.tbServoPosMen7.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMen7.TabIndex = 215
        Me.tbServoPosMen7.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMen7, "HABLAR")
        Me.tbServoPosMen7.UseVisualStyleBackColor = False
        '
        'tbServoPosMas7
        '
        Me.tbServoPosMas7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbServoPosMas7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tbServoPosMas7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.tbServoPosMas7.Location = New System.Drawing.Point(244, 63)
        Me.tbServoPosMas7.Name = "tbServoPosMas7"
        Me.tbServoPosMas7.Size = New System.Drawing.Size(11, 13)
        Me.tbServoPosMas7.TabIndex = 214
        Me.tbServoPosMas7.Text = "+"
        Me.ToolTipMain.SetToolTip(Me.tbServoPosMas7, "HABLAR")
        Me.tbServoPosMas7.UseVisualStyleBackColor = False
        '
        'picBrazo
        '
        Me.picBrazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrazo.Image = Global.MiRobot.My.Resources.Resources._on
        Me.picBrazo.Location = New System.Drawing.Point(540, 47)
        Me.picBrazo.Name = "picBrazo"
        Me.picBrazo.Size = New System.Drawing.Size(26, 26)
        Me.picBrazo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrazo.TabIndex = 202
        Me.picBrazo.TabStop = False
        Me.ToolTipMain.SetToolTip(Me.picBrazo, "1")
        '
        'picMano
        '
        Me.picMano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMano.Image = Global.MiRobot.My.Resources.Resources._on
        Me.picMano.Location = New System.Drawing.Point(540, 98)
        Me.picMano.Name = "picMano"
        Me.picMano.Size = New System.Drawing.Size(26, 26)
        Me.picMano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMano.TabIndex = 203
        Me.picMano.TabStop = False
        Me.ToolTipMain.SetToolTip(Me.picMano, "4")
        Me.picMano.Visible = False
        '
        'cmdControlLimitesOn
        '
        Me.cmdControlLimitesOn.Image = CType(resources.GetObject("cmdControlLimitesOn.Image"), System.Drawing.Image)
        Me.cmdControlLimitesOn.Location = New System.Drawing.Point(331, 44)
        Me.cmdControlLimitesOn.Name = "cmdControlLimitesOn"
        Me.cmdControlLimitesOn.Size = New System.Drawing.Size(31, 27)
        Me.cmdControlLimitesOn.TabIndex = 215
        Me.ToolTipMain.SetToolTip(Me.cmdControlLimitesOn, "Control Posición")
        Me.cmdControlLimitesOn.UseVisualStyleBackColor = True
        '
        'cmdControlLimitesOff
        '
        Me.cmdControlLimitesOff.Image = CType(resources.GetObject("cmdControlLimitesOff.Image"), System.Drawing.Image)
        Me.cmdControlLimitesOff.Location = New System.Drawing.Point(302, 44)
        Me.cmdControlLimitesOff.Name = "cmdControlLimitesOff"
        Me.cmdControlLimitesOff.Size = New System.Drawing.Size(31, 27)
        Me.cmdControlLimitesOff.TabIndex = 214
        Me.ToolTipMain.SetToolTip(Me.cmdControlLimitesOff, "Control Posición")
        Me.cmdControlLimitesOff.UseVisualStyleBackColor = True
        '
        'cmdControlLimOn
        '
        Me.cmdControlLimOn.Image = CType(resources.GetObject("cmdControlLimOn.Image"), System.Drawing.Image)
        Me.cmdControlLimOn.Location = New System.Drawing.Point(218, 44)
        Me.cmdControlLimOn.Name = "cmdControlLimOn"
        Me.cmdControlLimOn.Size = New System.Drawing.Size(31, 27)
        Me.cmdControlLimOn.TabIndex = 212
        Me.ToolTipMain.SetToolTip(Me.cmdControlLimOn, "Control Posición")
        Me.cmdControlLimOn.UseVisualStyleBackColor = True
        '
        'cmdControlLimOff
        '
        Me.cmdControlLimOff.Image = CType(resources.GetObject("cmdControlLimOff.Image"), System.Drawing.Image)
        Me.cmdControlLimOff.Location = New System.Drawing.Point(189, 44)
        Me.cmdControlLimOff.Name = "cmdControlLimOff"
        Me.cmdControlLimOff.Size = New System.Drawing.Size(31, 27)
        Me.cmdControlLimOff.TabIndex = 211
        Me.ToolTipMain.SetToolTip(Me.cmdControlLimOff, "Control Posición")
        Me.cmdControlLimOff.UseVisualStyleBackColor = True
        '
        'tbControlPosOn
        '
        Me.tbControlPosOn.Image = CType(resources.GetObject("tbControlPosOn.Image"), System.Drawing.Image)
        Me.tbControlPosOn.Location = New System.Drawing.Point(81, 44)
        Me.tbControlPosOn.Name = "tbControlPosOn"
        Me.tbControlPosOn.Size = New System.Drawing.Size(31, 27)
        Me.tbControlPosOn.TabIndex = 209
        Me.ToolTipMain.SetToolTip(Me.tbControlPosOn, "Control Posición")
        Me.tbControlPosOn.UseVisualStyleBackColor = True
        '
        'tbControlPosOff
        '
        Me.tbControlPosOff.Image = CType(resources.GetObject("tbControlPosOff.Image"), System.Drawing.Image)
        Me.tbControlPosOff.Location = New System.Drawing.Point(52, 44)
        Me.tbControlPosOff.Name = "tbControlPosOff"
        Me.tbControlPosOff.Size = New System.Drawing.Size(31, 27)
        Me.tbControlPosOff.TabIndex = 208
        Me.ToolTipMain.SetToolTip(Me.tbControlPosOff, "Control Posición")
        Me.tbControlPosOff.UseVisualStyleBackColor = True
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.SystemColors.Control
        Me.cmdReset.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReset.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdReset.Image = Global.MiRobot.My.Resources.Resources.parar1
        Me.cmdReset.Location = New System.Drawing.Point(538, 9)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdReset.Size = New System.Drawing.Size(29, 27)
        Me.cmdReset.TabIndex = 198
        Me.cmdReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdReset, "Reset")
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'cmdEnviarPosParada
        '
        Me.cmdEnviarPosParada.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnviarPosParada.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnviarPosParada.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnviarPosParada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnviarPosParada.Image = Global.MiRobot.My.Resources.Resources.parar1
        Me.cmdEnviarPosParada.Location = New System.Drawing.Point(3, 60)
        Me.cmdEnviarPosParada.Name = "cmdEnviarPosParada"
        Me.cmdEnviarPosParada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnviarPosParada.Size = New System.Drawing.Size(23, 27)
        Me.cmdEnviarPosParada.TabIndex = 202
        Me.cmdEnviarPosParada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTipMain.SetToolTip(Me.cmdEnviarPosParada, "Enviar posiciones de parada")
        Me.cmdEnviarPosParada.UseVisualStyleBackColor = False
        '
        'cmdEjecMovTemp
        '
        Me.cmdEjecMovTemp.BackColor = System.Drawing.Color.White
        Me.cmdEjecMovTemp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdEjecMovTemp.Image = Global.MiRobot.My.Resources.Resources.play
        Me.cmdEjecMovTemp.Location = New System.Drawing.Point(577, 6)
        Me.cmdEjecMovTemp.Name = "cmdEjecMovTemp"
        Me.cmdEjecMovTemp.Size = New System.Drawing.Size(42, 35)
        Me.cmdEjecMovTemp.TabIndex = 207
        Me.ToolTipMain.SetToolTip(Me.cmdEjecMovTemp, "Ejecutar Movimiento Temporizado Servos")
        Me.cmdEjecMovTemp.UseVisualStyleBackColor = False
        '
        'cmdEjecutarMovRot
        '
        Me.cmdEjecutarMovRot.Image = Global.MiRobot.My.Resources.Resources.play
        Me.cmdEjecutarMovRot.Location = New System.Drawing.Point(25, 60)
        Me.cmdEjecutarMovRot.Name = "cmdEjecutarMovRot"
        Me.cmdEjecutarMovRot.Size = New System.Drawing.Size(22, 27)
        Me.cmdEjecutarMovRot.TabIndex = 209
        Me.ToolTipMain.SetToolTip(Me.cmdEjecutarMovRot, "Ejecutar movimiento programado Rotacional")
        Me.cmdEjecutarMovRot.UseVisualStyleBackColor = True
        '
        'cmdLeerPosServosRot
        '
        Me.cmdLeerPosServosRot.Image = Global.MiRobot.My.Resources.Resources._on
        Me.cmdLeerPosServosRot.Location = New System.Drawing.Point(44, 60)
        Me.cmdLeerPosServosRot.Name = "cmdLeerPosServosRot"
        Me.cmdLeerPosServosRot.Size = New System.Drawing.Size(25, 27)
        Me.cmdLeerPosServosRot.TabIndex = 210
        Me.ToolTipMain.SetToolTip(Me.cmdLeerPosServosRot, "Leer posición articulaciones")
        Me.cmdLeerPosServosRot.UseVisualStyleBackColor = True
        '
        'cmdPosIni
        '
        Me.cmdPosIni.BackColor = System.Drawing.Color.White
        Me.cmdPosIni.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cmdPosIni.Image = Global.MiRobot.My.Resources.Resources._on
        Me.cmdPosIni.Location = New System.Drawing.Point(625, 6)
        Me.cmdPosIni.Name = "cmdPosIni"
        Me.cmdPosIni.Size = New System.Drawing.Size(42, 35)
        Me.cmdPosIni.TabIndex = 208
        Me.ToolTipMain.SetToolTip(Me.cmdPosIni, "Valores  iniciales")
        Me.cmdPosIni.UseVisualStyleBackColor = False
        '
        'cmdSAPPO_1
        '
        Me.cmdSAPPO_1.Image = CType(resources.GetObject("cmdSAPPO_1.Image"), System.Drawing.Image)
        Me.cmdSAPPO_1.Location = New System.Drawing.Point(452, 44)
        Me.cmdSAPPO_1.Name = "cmdSAPPO_1"
        Me.cmdSAPPO_1.Size = New System.Drawing.Size(31, 27)
        Me.cmdSAPPO_1.TabIndex = 218
        Me.ToolTipMain.SetToolTip(Me.cmdSAPPO_1, "Control Posición")
        Me.cmdSAPPO_1.UseVisualStyleBackColor = True
        '
        'cmdSAPPO_0
        '
        Me.cmdSAPPO_0.Image = CType(resources.GetObject("cmdSAPPO_0.Image"), System.Drawing.Image)
        Me.cmdSAPPO_0.Location = New System.Drawing.Point(423, 44)
        Me.cmdSAPPO_0.Name = "cmdSAPPO_0"
        Me.cmdSAPPO_0.Size = New System.Drawing.Size(31, 27)
        Me.cmdSAPPO_0.TabIndex = 217
        Me.ToolTipMain.SetToolTip(Me.cmdSAPPO_0, "Control Posición")
        Me.cmdSAPPO_0.UseVisualStyleBackColor = True
        '
        'cmdMoverRatón
        '
        Me.cmdMoverRatón.BackColor = System.Drawing.SystemColors.Control
        Me.cmdMoverRatón.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMoverRatón.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdMoverRatón.Location = New System.Drawing.Point(18, 548)
        Me.cmdMoverRatón.Name = "cmdMoverRatón"
        Me.cmdMoverRatón.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMoverRatón.Size = New System.Drawing.Size(119, 33)
        Me.cmdMoverRatón.TabIndex = 190
        Me.cmdMoverRatón.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdMoverRatón.UseVisualStyleBackColor = False
        Me.cmdMoverRatón.Visible = False
        '
        'cbUnidad
        '
        Me.cbUnidad.BackColor = System.Drawing.SystemColors.Window
        Me.cbUnidad.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbUnidad.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnidad.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbUnidad, New Integer() {0, 0})
        Me.cbUnidad.Items.AddRange(New Object() {"Grados", "Microsegundos"})
        Me.cbUnidad.Location = New System.Drawing.Point(572, 452)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbUnidad.Size = New System.Drawing.Size(95, 26)
        Me.cbUnidad.TabIndex = 123
        '
        'tbCom
        '
        Me.tbCom.AcceptsReturn = True
        Me.tbCom.BackColor = System.Drawing.SystemColors.Window
        Me.tbCom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCom.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbCom.Location = New System.Drawing.Point(9, 573)
        Me.tbCom.MaxLength = 0
        Me.tbCom.Multiline = True
        Me.tbCom.Name = "tbCom"
        Me.tbCom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbCom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbCom.Size = New System.Drawing.Size(413, 121)
        Me.tbCom.TabIndex = 122
        '
        'cbModoEnvio
        '
        Me.cbModoEnvio.BackColor = System.Drawing.SystemColors.Window
        Me.cbModoEnvio.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbModoEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModoEnvio.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbModoEnvio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbModoEnvio, New Integer() {0, 0})
        Me.cbModoEnvio.Items.AddRange(New Object() {"Envío Continuo", "Envío Programado"})
        Me.cbModoEnvio.Location = New System.Drawing.Point(561, 424)
        Me.cbModoEnvio.Name = "cbModoEnvio"
        Me.cbModoEnvio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbModoEnvio.Size = New System.Drawing.Size(106, 26)
        Me.cbModoEnvio.TabIndex = 93
        '
        'cmdGenerarArduino
        '
        Me.cmdGenerarArduino.BackColor = System.Drawing.SystemColors.Control
        Me.cmdGenerarArduino.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGenerarArduino.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerarArduino.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGenerarArduino.Location = New System.Drawing.Point(506, 397)
        Me.cmdGenerarArduino.Name = "cmdGenerarArduino"
        Me.cmdGenerarArduino.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGenerarArduino.Size = New System.Drawing.Size(131, 25)
        Me.cmdGenerarArduino.TabIndex = 91
        Me.cmdGenerarArduino.Text = "Cód. Arduino"
        Me.cmdGenerarArduino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdGenerarArduino.UseVisualStyleBackColor = False
        '
        'cbPuerto
        '
        Me.cbPuerto.BackColor = System.Drawing.SystemColors.Window
        Me.cbPuerto.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbPuerto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPuerto.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPuerto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbPuerto, New Integer() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0})
        Me.cbPuerto.Items.AddRange(New Object() {"COM1", "COM2", "COM3", "COM4", "COM5", "COM6", "COM7", "COM8", "COM9", "COM10", "COM11", "COM12", "COM13", "COM14", "COM15", "COM16"})
        Me.cbPuerto.Location = New System.Drawing.Point(506, 368)
        Me.cbPuerto.Name = "cbPuerto"
        Me.cbPuerto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbPuerto.Size = New System.Drawing.Size(97, 27)
        Me.cbPuerto.TabIndex = 90
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.SystemColors.Control
        Me.Frame6.Controls.Add(Me.Frame8)
        Me.Frame6.Controls.Add(Me.cbZonaMov)
        Me.Frame6.Controls.Add(Me.chkResetModif)
        Me.Frame6.Controls.Add(Me.cbGrabar)
        Me.Frame6.Controls.Add(Me.Frame9)
        Me.Frame6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(13, 6)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame6.Size = New System.Drawing.Size(459, 373)
        Me.Frame6.TabIndex = 34
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "Zona Inferior "
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.SystemColors.Control
        Me.Frame8.Controls.Add(Me._tbMax_11)
        Me.Frame8.Controls.Add(Me._tbMax_10)
        Me.Frame8.Controls.Add(Me._tbMax_9)
        Me.Frame8.Controls.Add(Me._tbMax_8)
        Me.Frame8.Controls.Add(Me._tbMax_7)
        Me.Frame8.Controls.Add(Me._tbMax_6)
        Me.Frame8.Controls.Add(Me._tbMin_11)
        Me.Frame8.Controls.Add(Me._tbMin_10)
        Me.Frame8.Controls.Add(Me._tbMin_9)
        Me.Frame8.Controls.Add(Me._tbMin_8)
        Me.Frame8.Controls.Add(Me._tbMin_7)
        Me.Frame8.Controls.Add(Me._tbMin_6)
        Me.Frame8.Controls.Add(Me._tbNumServo_11)
        Me.Frame8.Controls.Add(Me._tbNumServo_10)
        Me.Frame8.Controls.Add(Me._tbNumServo_9)
        Me.Frame8.Controls.Add(Me._tbNumServo_8)
        Me.Frame8.Controls.Add(Me._tbNumServo_7)
        Me.Frame8.Controls.Add(Me._tbNumServo_6)
        Me.Frame8.Controls.Add(Me._tbValServo_9)
        Me.Frame8.Controls.Add(Me._tbValServo_8)
        Me.Frame8.Controls.Add(Me._tbValServo_7)
        Me.Frame8.Controls.Add(Me._tbValServo_6)
        Me.Frame8.Controls.Add(Me._barServo_9)
        Me.Frame8.Controls.Add(Me._barServo_8)
        Me.Frame8.Controls.Add(Me._barServo_7)
        Me.Frame8.Controls.Add(Me._barServo_6)
        Me.Frame8.Controls.Add(Me._tbValServo_10)
        Me.Frame8.Controls.Add(Me._barServo_10)
        Me.Frame8.Controls.Add(Me._tbValServo_11)
        Me.Frame8.Controls.Add(Me._barServo_11)
        Me.Frame8.Controls.Add(Me.Label24)
        Me.Frame8.Controls.Add(Me.Label23)
        Me.Frame8.Controls.Add(Me.Label22)
        Me.Frame8.Controls.Add(Me.Label21)
        Me.Frame8.Controls.Add(Me.Label16)
        Me.Frame8.Controls.Add(Me.Label15)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(10, 198)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame8.Size = New System.Drawing.Size(443, 169)
        Me.Frame8.TabIndex = 54
        Me.Frame8.TabStop = False
        Me.Frame8.Text = "Brazo Izquierdo"
        '
        '_tbMax_11
        '
        Me._tbMax_11.AcceptsReturn = True
        Me._tbMax_11.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_11.Location = New System.Drawing.Point(324, 137)
        Me._tbMax_11.MaxLength = 0
        Me._tbMax_11.Name = "_tbMax_11"
        Me._tbMax_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_11.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_11.TabIndex = 148
        Me._tbMax_11.Text = "0000"
        Me._tbMax_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_10
        '
        Me._tbMax_10.AcceptsReturn = True
        Me._tbMax_10.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_10.Location = New System.Drawing.Point(324, 113)
        Me._tbMax_10.MaxLength = 0
        Me._tbMax_10.Name = "_tbMax_10"
        Me._tbMax_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_10.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_10.TabIndex = 147
        Me._tbMax_10.Text = "0000"
        Me._tbMax_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_9
        '
        Me._tbMax_9.AcceptsReturn = True
        Me._tbMax_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_9.Location = New System.Drawing.Point(324, 89)
        Me._tbMax_9.MaxLength = 0
        Me._tbMax_9.Name = "_tbMax_9"
        Me._tbMax_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_9.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_9.TabIndex = 146
        Me._tbMax_9.Text = "0000"
        Me._tbMax_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_8
        '
        Me._tbMax_8.AcceptsReturn = True
        Me._tbMax_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_8.Location = New System.Drawing.Point(324, 65)
        Me._tbMax_8.MaxLength = 0
        Me._tbMax_8.Name = "_tbMax_8"
        Me._tbMax_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_8.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_8.TabIndex = 145
        Me._tbMax_8.Text = "0000"
        Me._tbMax_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_7
        '
        Me._tbMax_7.AcceptsReturn = True
        Me._tbMax_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_7.Location = New System.Drawing.Point(324, 41)
        Me._tbMax_7.MaxLength = 0
        Me._tbMax_7.Name = "_tbMax_7"
        Me._tbMax_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_7.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_7.TabIndex = 144
        Me._tbMax_7.Text = "0000"
        Me._tbMax_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_6
        '
        Me._tbMax_6.AcceptsReturn = True
        Me._tbMax_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_6.Location = New System.Drawing.Point(324, 17)
        Me._tbMax_6.MaxLength = 0
        Me._tbMax_6.Name = "_tbMax_6"
        Me._tbMax_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_6.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_6.TabIndex = 143
        Me._tbMax_6.Text = "0000"
        Me._tbMax_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_11
        '
        Me._tbMin_11.AcceptsReturn = True
        Me._tbMin_11.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_11.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_11.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_11.Location = New System.Drawing.Point(128, 136)
        Me._tbMin_11.MaxLength = 0
        Me._tbMin_11.Name = "_tbMin_11"
        Me._tbMin_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_11.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_11.TabIndex = 142
        Me._tbMin_11.Text = "0000"
        Me._tbMin_11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_10
        '
        Me._tbMin_10.AcceptsReturn = True
        Me._tbMin_10.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_10.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_10.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_10.Location = New System.Drawing.Point(128, 112)
        Me._tbMin_10.MaxLength = 0
        Me._tbMin_10.Name = "_tbMin_10"
        Me._tbMin_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_10.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_10.TabIndex = 141
        Me._tbMin_10.Text = "0000"
        Me._tbMin_10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_9
        '
        Me._tbMin_9.AcceptsReturn = True
        Me._tbMin_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_9.Location = New System.Drawing.Point(128, 88)
        Me._tbMin_9.MaxLength = 0
        Me._tbMin_9.Name = "_tbMin_9"
        Me._tbMin_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_9.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_9.TabIndex = 140
        Me._tbMin_9.Text = "0000"
        Me._tbMin_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_8
        '
        Me._tbMin_8.AcceptsReturn = True
        Me._tbMin_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_8.Location = New System.Drawing.Point(128, 64)
        Me._tbMin_8.MaxLength = 0
        Me._tbMin_8.Name = "_tbMin_8"
        Me._tbMin_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_8.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_8.TabIndex = 139
        Me._tbMin_8.Text = "0000"
        Me._tbMin_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_7
        '
        Me._tbMin_7.AcceptsReturn = True
        Me._tbMin_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_7.Location = New System.Drawing.Point(128, 40)
        Me._tbMin_7.MaxLength = 0
        Me._tbMin_7.Name = "_tbMin_7"
        Me._tbMin_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_7.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_7.TabIndex = 138
        Me._tbMin_7.Text = "0000"
        Me._tbMin_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_6
        '
        Me._tbMin_6.AcceptsReturn = True
        Me._tbMin_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_6.Location = New System.Drawing.Point(128, 16)
        Me._tbMin_6.MaxLength = 0
        Me._tbMin_6.Name = "_tbMin_6"
        Me._tbMin_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_6.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_6.TabIndex = 137
        Me._tbMin_6.Text = "0000"
        Me._tbMin_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_9
        '
        Me._barServo_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_9.LargeChange = 1
        Me._barServo_9.Location = New System.Drawing.Point(174, 88)
        Me._barServo_9.Maximum = 32767
        Me._barServo_9.Name = "_barServo_9"
        Me._barServo_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_9.Size = New System.Drawing.Size(145, 25)
        Me._barServo_9.TabIndex = 62
        Me._barServo_9.TabStop = True
        '
        '_barServo_8
        '
        Me._barServo_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_8.LargeChange = 1
        Me._barServo_8.Location = New System.Drawing.Point(174, 64)
        Me._barServo_8.Maximum = 32767
        Me._barServo_8.Name = "_barServo_8"
        Me._barServo_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_8.Size = New System.Drawing.Size(145, 25)
        Me._barServo_8.TabIndex = 61
        Me._barServo_8.TabStop = True
        '
        '_barServo_7
        '
        Me._barServo_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_7.LargeChange = 1
        Me._barServo_7.Location = New System.Drawing.Point(174, 40)
        Me._barServo_7.Maximum = 32767
        Me._barServo_7.Name = "_barServo_7"
        Me._barServo_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_7.Size = New System.Drawing.Size(145, 25)
        Me._barServo_7.TabIndex = 60
        Me._barServo_7.TabStop = True
        '
        '_barServo_6
        '
        Me._barServo_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_6.LargeChange = 1
        Me._barServo_6.Location = New System.Drawing.Point(174, 16)
        Me._barServo_6.Maximum = 32767
        Me._barServo_6.Name = "_barServo_6"
        Me._barServo_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_6.Size = New System.Drawing.Size(145, 25)
        Me._barServo_6.TabIndex = 59
        Me._barServo_6.TabStop = True
        '
        '_barServo_10
        '
        Me._barServo_10.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_10.LargeChange = 1
        Me._barServo_10.Location = New System.Drawing.Point(174, 112)
        Me._barServo_10.Maximum = 32767
        Me._barServo_10.Name = "_barServo_10"
        Me._barServo_10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_10.Size = New System.Drawing.Size(145, 25)
        Me._barServo_10.TabIndex = 57
        Me._barServo_10.TabStop = True
        '
        '_barServo_11
        '
        Me._barServo_11.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_11.LargeChange = 1
        Me._barServo_11.Location = New System.Drawing.Point(174, 136)
        Me._barServo_11.Maximum = 32767
        Me._barServo_11.Name = "_barServo_11"
        Me._barServo_11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_11.Size = New System.Drawing.Size(145, 25)
        Me._barServo_11.TabIndex = 55
        Me._barServo_11.TabStop = True
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.SystemColors.Control
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 88)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(113, 25)
        Me.Label24.TabIndex = 72
        Me.Label24.Text = "Anular"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.SystemColors.Control
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 64)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(113, 25)
        Me.Label23.TabIndex = 71
        Me.Label23.Text = "Medio"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(8, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(113, 25)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "Indice"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.Control
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(113, 25)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "Pulgar"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(8, 112)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(113, 25)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "Meñique"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(113, 25)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Giro Muñeca"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbZonaMov
        '
        Me.cbZonaMov.BackColor = System.Drawing.SystemColors.Window
        Me.cbZonaMov.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbZonaMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbZonaMov.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbZonaMov, New Integer() {0, 0})
        Me.cbZonaMov.Items.AddRange(New Object() {"Independiente", "Solidario"})
        Me.cbZonaMov.Location = New System.Drawing.Point(233, 0)
        Me.cbZonaMov.Name = "cbZonaMov"
        Me.cbZonaMov.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbZonaMov.Size = New System.Drawing.Size(117, 26)
        Me.cbZonaMov.TabIndex = 189
        '
        'chkResetModif
        '
        Me.chkResetModif.BackColor = System.Drawing.SystemColors.Control
        Me.chkResetModif.Checked = True
        Me.chkResetModif.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkResetModif.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkResetModif.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResetModif.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkResetModif.Location = New System.Drawing.Point(143, 4)
        Me.chkResetModif.Name = "chkResetModif"
        Me.chkResetModif.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkResetModif.Size = New System.Drawing.Size(109, 19)
        Me.chkResetModif.TabIndex = 188
        Me.chkResetModif.Text = "Reset Modif"
        Me.chkResetModif.UseVisualStyleBackColor = False
        '
        'cbGrabar
        '
        Me.cbGrabar.BackColor = System.Drawing.SystemColors.Window
        Me.cbGrabar.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbGrabar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrabar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbGrabar, New Integer() {0, 0, 0, 0})
        Me.cbGrabar.Items.AddRange(New Object() {"Modificados", "Asignados", "Grabados", "Todos"})
        Me.cbGrabar.Location = New System.Drawing.Point(353, 0)
        Me.cbGrabar.Name = "cbGrabar"
        Me.cbGrabar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbGrabar.Size = New System.Drawing.Size(89, 26)
        Me.cbGrabar.TabIndex = 187
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.SystemColors.Control
        Me.Frame9.Controls.Add(Me._tbMax_5)
        Me.Frame9.Controls.Add(Me._tbMax_4)
        Me.Frame9.Controls.Add(Me._tbMax_3)
        Me.Frame9.Controls.Add(Me._tbMax_2)
        Me.Frame9.Controls.Add(Me._tbMax_1)
        Me.Frame9.Controls.Add(Me._tbMax_0)
        Me.Frame9.Controls.Add(Me._tbMin_5)
        Me.Frame9.Controls.Add(Me._tbMin_4)
        Me.Frame9.Controls.Add(Me._tbMin_3)
        Me.Frame9.Controls.Add(Me._tbMin_2)
        Me.Frame9.Controls.Add(Me._tbMin_1)
        Me.Frame9.Controls.Add(Me._tbMin_0)
        Me.Frame9.Controls.Add(Me._tbNumServo_5)
        Me.Frame9.Controls.Add(Me._tbNumServo_4)
        Me.Frame9.Controls.Add(Me._tbNumServo_3)
        Me.Frame9.Controls.Add(Me._tbNumServo_2)
        Me.Frame9.Controls.Add(Me._tbNumServo_1)
        Me.Frame9.Controls.Add(Me._tbNumServo_0)
        Me.Frame9.Controls.Add(Me._barServo_5)
        Me.Frame9.Controls.Add(Me._tbValServo_5)
        Me.Frame9.Controls.Add(Me._barServo_4)
        Me.Frame9.Controls.Add(Me._tbValServo_4)
        Me.Frame9.Controls.Add(Me._barServo_0)
        Me.Frame9.Controls.Add(Me._barServo_1)
        Me.Frame9.Controls.Add(Me._barServo_2)
        Me.Frame9.Controls.Add(Me._barServo_3)
        Me.Frame9.Controls.Add(Me._tbValServo_0)
        Me.Frame9.Controls.Add(Me._tbValServo_1)
        Me.Frame9.Controls.Add(Me._tbValServo_2)
        Me.Frame9.Controls.Add(Me._tbValServo_3)
        Me.Frame9.Controls.Add(Me.Label14)
        Me.Frame9.Controls.Add(Me.Label13)
        Me.Frame9.Controls.Add(Me.Label20)
        Me.Frame9.Controls.Add(Me.Label19)
        Me.Frame9.Controls.Add(Me.Label18)
        Me.Frame9.Controls.Add(Me.Label17)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(10, 20)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame9.Size = New System.Drawing.Size(443, 172)
        Me.Frame9.TabIndex = 35
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "Brazo Derecho"
        '
        '_tbMax_5
        '
        Me._tbMax_5.AcceptsReturn = True
        Me._tbMax_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_5.Location = New System.Drawing.Point(322, 137)
        Me._tbMax_5.MaxLength = 0
        Me._tbMax_5.Name = "_tbMax_5"
        Me._tbMax_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_5.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_5.TabIndex = 136
        Me._tbMax_5.Text = "0000"
        Me._tbMax_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_4
        '
        Me._tbMax_4.AcceptsReturn = True
        Me._tbMax_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_4.Location = New System.Drawing.Point(322, 113)
        Me._tbMax_4.MaxLength = 0
        Me._tbMax_4.Name = "_tbMax_4"
        Me._tbMax_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_4.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_4.TabIndex = 135
        Me._tbMax_4.Text = "0000"
        Me._tbMax_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_3
        '
        Me._tbMax_3.AcceptsReturn = True
        Me._tbMax_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_3.Location = New System.Drawing.Point(322, 89)
        Me._tbMax_3.MaxLength = 0
        Me._tbMax_3.Name = "_tbMax_3"
        Me._tbMax_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_3.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_3.TabIndex = 134
        Me._tbMax_3.Text = "0000"
        Me._tbMax_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_2
        '
        Me._tbMax_2.AcceptsReturn = True
        Me._tbMax_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_2.Location = New System.Drawing.Point(322, 65)
        Me._tbMax_2.MaxLength = 0
        Me._tbMax_2.Name = "_tbMax_2"
        Me._tbMax_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_2.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_2.TabIndex = 133
        Me._tbMax_2.Text = "0000"
        Me._tbMax_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_1
        '
        Me._tbMax_1.AcceptsReturn = True
        Me._tbMax_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_1.Location = New System.Drawing.Point(322, 41)
        Me._tbMax_1.MaxLength = 0
        Me._tbMax_1.Name = "_tbMax_1"
        Me._tbMax_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_1.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_1.TabIndex = 132
        Me._tbMax_1.Text = "0000"
        Me._tbMax_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_0
        '
        Me._tbMax_0.AcceptsReturn = True
        Me._tbMax_0.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_0.Location = New System.Drawing.Point(322, 17)
        Me._tbMax_0.MaxLength = 0
        Me._tbMax_0.Name = "_tbMax_0"
        Me._tbMax_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_0.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_0.TabIndex = 131
        Me._tbMax_0.Text = "0000"
        Me._tbMax_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_5
        '
        Me._tbMin_5.AcceptsReturn = True
        Me._tbMin_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_5.Location = New System.Drawing.Point(126, 136)
        Me._tbMin_5.MaxLength = 0
        Me._tbMin_5.Name = "_tbMin_5"
        Me._tbMin_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_5.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_5.TabIndex = 130
        Me._tbMin_5.Text = "0000"
        Me._tbMin_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_4
        '
        Me._tbMin_4.AcceptsReturn = True
        Me._tbMin_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_4.Location = New System.Drawing.Point(126, 112)
        Me._tbMin_4.MaxLength = 0
        Me._tbMin_4.Name = "_tbMin_4"
        Me._tbMin_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_4.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_4.TabIndex = 129
        Me._tbMin_4.Text = "0000"
        Me._tbMin_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_3
        '
        Me._tbMin_3.AcceptsReturn = True
        Me._tbMin_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_3.Location = New System.Drawing.Point(126, 88)
        Me._tbMin_3.MaxLength = 0
        Me._tbMin_3.Name = "_tbMin_3"
        Me._tbMin_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_3.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_3.TabIndex = 128
        Me._tbMin_3.Text = "0000"
        Me._tbMin_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_2
        '
        Me._tbMin_2.AcceptsReturn = True
        Me._tbMin_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_2.Location = New System.Drawing.Point(126, 64)
        Me._tbMin_2.MaxLength = 0
        Me._tbMin_2.Name = "_tbMin_2"
        Me._tbMin_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_2.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_2.TabIndex = 127
        Me._tbMin_2.Text = "0000"
        Me._tbMin_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_1
        '
        Me._tbMin_1.AcceptsReturn = True
        Me._tbMin_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_1.Location = New System.Drawing.Point(126, 40)
        Me._tbMin_1.MaxLength = 0
        Me._tbMin_1.Name = "_tbMin_1"
        Me._tbMin_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_1.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_1.TabIndex = 126
        Me._tbMin_1.Text = "0000"
        Me._tbMin_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_0
        '
        Me._tbMin_0.AcceptsReturn = True
        Me._tbMin_0.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_0.Location = New System.Drawing.Point(126, 16)
        Me._tbMin_0.MaxLength = 0
        Me._tbMin_0.Name = "_tbMin_0"
        Me._tbMin_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_0.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_0.TabIndex = 125
        Me._tbMin_0.Text = "0000"
        Me._tbMin_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_5
        '
        Me._barServo_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_5.LargeChange = 1
        Me._barServo_5.Location = New System.Drawing.Point(172, 136)
        Me._barServo_5.Maximum = 32767
        Me._barServo_5.Name = "_barServo_5"
        Me._barServo_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_5.Size = New System.Drawing.Size(147, 25)
        Me._barServo_5.TabIndex = 52
        Me._barServo_5.TabStop = True
        '
        '_barServo_4
        '
        Me._barServo_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_4.LargeChange = 1
        Me._barServo_4.Location = New System.Drawing.Point(172, 112)
        Me._barServo_4.Maximum = 32767
        Me._barServo_4.Name = "_barServo_4"
        Me._barServo_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_4.Size = New System.Drawing.Size(147, 25)
        Me._barServo_4.TabIndex = 49
        Me._barServo_4.TabStop = True
        '
        '_barServo_0
        '
        Me._barServo_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_0.LargeChange = 1
        Me._barServo_0.Location = New System.Drawing.Point(172, 16)
        Me._barServo_0.Maximum = 32767
        Me._barServo_0.Name = "_barServo_0"
        Me._barServo_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_0.Size = New System.Drawing.Size(147, 25)
        Me._barServo_0.TabIndex = 43
        Me._barServo_0.TabStop = True
        '
        '_barServo_1
        '
        Me._barServo_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_1.LargeChange = 1
        Me._barServo_1.Location = New System.Drawing.Point(172, 40)
        Me._barServo_1.Maximum = 32767
        Me._barServo_1.Name = "_barServo_1"
        Me._barServo_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_1.Size = New System.Drawing.Size(147, 25)
        Me._barServo_1.TabIndex = 42
        Me._barServo_1.TabStop = True
        '
        '_barServo_2
        '
        Me._barServo_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_2.LargeChange = 1
        Me._barServo_2.Location = New System.Drawing.Point(172, 64)
        Me._barServo_2.Maximum = 32767
        Me._barServo_2.Name = "_barServo_2"
        Me._barServo_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_2.Size = New System.Drawing.Size(147, 25)
        Me._barServo_2.TabIndex = 41
        Me._barServo_2.TabStop = True
        '
        '_barServo_3
        '
        Me._barServo_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_3.LargeChange = 1
        Me._barServo_3.Location = New System.Drawing.Point(172, 88)
        Me._barServo_3.Maximum = 32767
        Me._barServo_3.Name = "_barServo_3"
        Me._barServo_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_3.Size = New System.Drawing.Size(147, 25)
        Me._barServo_3.TabIndex = 40
        Me._barServo_3.TabStop = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(26, 135)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(101, 25)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Giro Muñeca"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(29, 112)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(92, 25)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Meñique"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(29, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(92, 25)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "Pulgar"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.Control
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(29, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(92, 25)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Indice"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(63, 63)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(57, 25)
        Me.Label18.TabIndex = 45
        Me.Label18.Text = "Medio"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(29, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(92, 25)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Anular"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmdOff)
        Me.Frame1.Controls.Add(Me.KinectAltura)
        Me.Frame1.Controls.Add(Me.Label39)
        Me.Frame1.Controls.Add(Me.PictureBox2)
        Me.Frame1.Controls.Add(Me.tbAngSonido)
        Me.Frame1.Controls.Add(Me.cmdSensorLineaR)
        Me.Frame1.Controls.Add(Me.cmdSensorLineaC)
        Me.Frame1.Controls.Add(Me.cmdSensorLineaL)
        Me.Frame1.Controls.Add(Me.tbLogInt)
        Me.Frame1.Controls.Add(Me.tbMarcas)
        Me.Frame1.Controls.Add(Me.Frame5)
        Me.Frame1.Controls.Add(Me.Frame4)
        Me.Frame1.Controls.Add(Me.Frame3)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(673, 6)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(579, 356)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Zona Superior "
        '
        'cmdOff
        '
        Me.cmdOff.Image = Global.MiRobot.My.Resources.Resources.off
        Me.cmdOff.Location = New System.Drawing.Point(548, 3)
        Me.cmdOff.Name = "cmdOff"
        Me.cmdOff.Size = New System.Drawing.Size(29, 28)
        Me.cmdOff.TabIndex = 213
        Me.cmdOff.UseVisualStyleBackColor = True
        '
        'KinectAltura
        '
        Me.KinectAltura.Cursor = System.Windows.Forms.Cursors.Default
        Me.KinectAltura.LargeChange = 1
        Me.KinectAltura.Location = New System.Drawing.Point(464, 15)
        Me.KinectAltura.Maximum = 20
        Me.KinectAltura.Minimum = -15
        Me.KinectAltura.Name = "KinectAltura"
        Me.KinectAltura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.KinectAltura.Size = New System.Drawing.Size(81, 22)
        Me.KinectAltura.TabIndex = 202
        Me.KinectAltura.TabStop = True
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(474, -3)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 18)
        Me.Label39.TabIndex = 213
        Me.Label39.Text = "Kinect"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.MiRobot.My.Resources.Resources.sonido
        Me.PictureBox2.Location = New System.Drawing.Point(223, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 35)
        Me.PictureBox2.TabIndex = 201
        Me.PictureBox2.TabStop = False
        '
        'tbAngSonido
        '
        Me.tbAngSonido.AcceptsReturn = True
        Me.tbAngSonido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbAngSonido.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbAngSonido.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbAngSonido.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAngSonido.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbAngSonido.Location = New System.Drawing.Point(267, 2)
        Me.tbAngSonido.MaxLength = 0
        Me.tbAngSonido.Name = "tbAngSonido"
        Me.tbAngSonido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbAngSonido.Size = New System.Drawing.Size(64, 35)
        Me.tbAngSonido.TabIndex = 199
        Me.tbAngSonido.Text = "0000"
        Me.tbAngSonido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdSensorLineaR
        '
        Me.cmdSensorLineaR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSensorLineaR.Enabled = False
        Me.cmdSensorLineaR.Location = New System.Drawing.Point(182, 2)
        Me.cmdSensorLineaR.Name = "cmdSensorLineaR"
        Me.cmdSensorLineaR.Size = New System.Drawing.Size(24, 24)
        Me.cmdSensorLineaR.TabIndex = 38
        Me.cmdSensorLineaR.Text = "R"
        Me.cmdSensorLineaR.UseVisualStyleBackColor = False
        '
        'cmdSensorLineaC
        '
        Me.cmdSensorLineaC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSensorLineaC.Enabled = False
        Me.cmdSensorLineaC.Location = New System.Drawing.Point(159, 2)
        Me.cmdSensorLineaC.Name = "cmdSensorLineaC"
        Me.cmdSensorLineaC.Size = New System.Drawing.Size(24, 24)
        Me.cmdSensorLineaC.TabIndex = 38
        Me.cmdSensorLineaC.Text = "C"
        Me.cmdSensorLineaC.UseVisualStyleBackColor = False
        '
        'cmdSensorLineaL
        '
        Me.cmdSensorLineaL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdSensorLineaL.Enabled = False
        Me.cmdSensorLineaL.Location = New System.Drawing.Point(136, 2)
        Me.cmdSensorLineaL.Name = "cmdSensorLineaL"
        Me.cmdSensorLineaL.Size = New System.Drawing.Size(24, 24)
        Me.cmdSensorLineaL.TabIndex = 37
        Me.cmdSensorLineaL.Text = "L"
        Me.cmdSensorLineaL.UseVisualStyleBackColor = False
        '
        'tbLogInt
        '
        Me.tbLogInt.AcceptsReturn = True
        Me.tbLogInt.BackColor = System.Drawing.SystemColors.Window
        Me.tbLogInt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbLogInt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLogInt.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbLogInt.Location = New System.Drawing.Point(329, 2)
        Me.tbLogInt.MaxLength = 0
        Me.tbLogInt.Name = "tbLogInt"
        Me.tbLogInt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbLogInt.Size = New System.Drawing.Size(64, 35)
        Me.tbLogInt.TabIndex = 197
        Me.tbLogInt.Text = "0000"
        Me.tbLogInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbMarcas
        '
        Me.tbMarcas.AcceptsReturn = True
        Me.tbMarcas.BackColor = System.Drawing.SystemColors.Window
        Me.tbMarcas.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbMarcas.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMarcas.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbMarcas.Location = New System.Drawing.Point(393, 2)
        Me.tbMarcas.MaxLength = 0
        Me.tbMarcas.Name = "tbMarcas"
        Me.tbMarcas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbMarcas.Size = New System.Drawing.Size(68, 35)
        Me.tbMarcas.TabIndex = 196
        Me.tbMarcas.Text = "0000"
        Me.tbMarcas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.SystemColors.Control
        Me.Frame5.Controls.Add(Me.cmdPrueba)
        Me.Frame5.Controls.Add(Me.lblMAY)
        Me.Frame5.Controls.Add(Me.tbControl)
        Me.Frame5.Controls.Add(Me.cmdReset)
        Me.Frame5.Controls.Add(Me.Label11)
        Me.Frame5.Controls.Add(Me._tbMax_14)
        Me.Frame5.Controls.Add(Me._tbMax_13)
        Me.Frame5.Controls.Add(Me._tbMax_12)
        Me.Frame5.Controls.Add(Me._tbMin_12)
        Me.Frame5.Controls.Add(Me._tbNumServo_12)
        Me.Frame5.Controls.Add(Me._barServo_12)
        Me.Frame5.Controls.Add(Me._tbValServo_12)
        Me.Frame5.Controls.Add(Me.Label12)
        Me.Frame5.Controls.Add(Me._tbValorParar_1)
        Me.Frame5.Controls.Add(Me._tbParar_1)
        Me.Frame5.Controls.Add(Me._tbMenos_1)
        Me.Frame5.Controls.Add(Me._tbMas_1)
        Me.Frame5.Controls.Add(Me._tbMaxPos_1)
        Me.Frame5.Controls.Add(Me._tbMinPos_1)
        Me.Frame5.Controls.Add(Me._tbNumServoPos_1)
        Me.Frame5.Controls.Add(Me._barServoPos_1)
        Me.Frame5.Controls.Add(Me._tbValServoPos_1)
        Me.Frame5.Controls.Add(Me.Label30)
        Me.Frame5.Controls.Add(Me._tbMin_14)
        Me.Frame5.Controls.Add(Me._barServo_14)
        Me.Frame5.Controls.Add(Me._tbMin_13)
        Me.Frame5.Controls.Add(Me._barServo_13)
        Me.Frame5.Controls.Add(Me._tbNumServo_14)
        Me.Frame5.Controls.Add(Me._tbNumServo_13)
        Me.Frame5.Controls.Add(Me._tbValServo_14)
        Me.Frame5.Controls.Add(Me._tbValServo_13)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(10, 23)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame5.Size = New System.Drawing.Size(565, 127)
        Me.Frame5.TabIndex = 27
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "Cabeza "
        '
        'cmdPrueba
        '
        Me.cmdPrueba.Location = New System.Drawing.Point(515, 14)
        Me.cmdPrueba.Name = "cmdPrueba"
        Me.cmdPrueba.Size = New System.Drawing.Size(20, 26)
        Me.cmdPrueba.TabIndex = 207
        Me.cmdPrueba.Text = "P"
        Me.cmdPrueba.UseVisualStyleBackColor = True
        '
        'lblMAY
        '
        Me.lblMAY.AutoSize = True
        Me.lblMAY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMAY.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAY.Location = New System.Drawing.Point(534, 58)
        Me.lblMAY.Name = "lblMAY"
        Me.lblMAY.Size = New System.Drawing.Size(29, 24)
        Me.lblMAY.TabIndex = 205
        Me.lblMAY.Text = "M"
        '
        'tbControl
        '
        Me.tbControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbControl.Location = New System.Drawing.Point(467, 58)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.Size = New System.Drawing.Size(68, 24)
        Me.tbControl.TabIndex = 203
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(468, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(67, 25)
        Me.Label11.TabIndex = 204
        Me.Label11.Text = "Control"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        '_tbMax_14
        '
        Me._tbMax_14.AcceptsReturn = True
        Me._tbMax_14.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_14.Location = New System.Drawing.Point(338, 68)
        Me._tbMax_14.MaxLength = 0
        Me._tbMax_14.Name = "_tbMax_14"
        Me._tbMax_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_14.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_14.TabIndex = 170
        Me._tbMax_14.Text = "0000"
        Me._tbMax_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_13
        '
        Me._tbMax_13.AcceptsReturn = True
        Me._tbMax_13.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_13.Location = New System.Drawing.Point(338, 45)
        Me._tbMax_13.MaxLength = 0
        Me._tbMax_13.Name = "_tbMax_13"
        Me._tbMax_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_13.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_13.TabIndex = 169
        Me._tbMax_13.Text = "0000"
        Me._tbMax_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMax_12
        '
        Me._tbMax_12.AcceptsReturn = True
        Me._tbMax_12.BackColor = System.Drawing.SystemColors.Window
        Me._tbMax_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMax_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMax_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMax_12.Location = New System.Drawing.Point(338, 20)
        Me._tbMax_12.MaxLength = 0
        Me._tbMax_12.Name = "_tbMax_12"
        Me._tbMax_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMax_12.Size = New System.Drawing.Size(45, 24)
        Me._tbMax_12.TabIndex = 202
        Me._tbMax_12.Text = "0000"
        Me._tbMax_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMin_12
        '
        Me._tbMin_12.AcceptsReturn = True
        Me._tbMin_12.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_12.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_12.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_12.Location = New System.Drawing.Point(131, 20)
        Me._tbMin_12.MaxLength = 0
        Me._tbMin_12.Name = "_tbMin_12"
        Me._tbMin_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_12.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_12.TabIndex = 201
        Me._tbMin_12.Text = "0000"
        Me._tbMin_12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_12
        '
        Me._barServo_12.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_12.LargeChange = 1
        Me._barServo_12.Location = New System.Drawing.Point(176, 20)
        Me._barServo_12.Maximum = 32767
        Me._barServo_12.Name = "_barServo_12"
        Me._barServo_12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_12.Size = New System.Drawing.Size(166, 25)
        Me._barServo_12.TabIndex = 198
        Me._barServo_12.TabStop = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 23)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(113, 25)
        Me.Label12.TabIndex = 199
        Me.Label12.Text = "Boca"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tbValorParar_1
        '
        Me._tbValorParar_1.AcceptsReturn = True
        Me._tbValorParar_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_1.Location = New System.Drawing.Point(229, 98)
        Me._tbValorParar_1.MaxLength = 0
        Me._tbValorParar_1.Name = "_tbValorParar_1"
        Me._tbValorParar_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_1.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_1.TabIndex = 196
        Me._tbValorParar_1.Text = "0000"
        Me._tbValorParar_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbParar_1
        '
        Me._tbParar_1.Image = Global.MiRobot.My.Resources.Resources.parar1
        Me._tbParar_1.Location = New System.Drawing.Point(165, 98)
        Me._tbParar_1.Name = "_tbParar_1"
        Me._tbParar_1.Size = New System.Drawing.Size(31, 23)
        Me._tbParar_1.TabIndex = 195
        Me._tbParar_1.UseVisualStyleBackColor = True
        '
        '_tbMenos_1
        '
        Me._tbMenos_1.Image = Global.MiRobot.My.Resources.Resources.izquierda_1
        Me._tbMenos_1.Location = New System.Drawing.Point(131, 98)
        Me._tbMenos_1.Name = "_tbMenos_1"
        Me._tbMenos_1.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_1.TabIndex = 194
        Me._tbMenos_1.UseVisualStyleBackColor = True
        '
        '_tbMas_1
        '
        Me._tbMas_1.Image = Global.MiRobot.My.Resources.Resources.derecha_1
        Me._tbMas_1.Location = New System.Drawing.Point(199, 98)
        Me._tbMas_1.Name = "_tbMas_1"
        Me._tbMas_1.Size = New System.Drawing.Size(31, 23)
        Me._tbMas_1.TabIndex = 193
        Me._tbMas_1.UseVisualStyleBackColor = True
        '
        '_tbMaxPos_1
        '
        Me._tbMaxPos_1.AcceptsReturn = True
        Me._tbMaxPos_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_1.Location = New System.Drawing.Point(448, 98)
        Me._tbMaxPos_1.MaxLength = 0
        Me._tbMaxPos_1.Name = "_tbMaxPos_1"
        Me._tbMaxPos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_1.Size = New System.Drawing.Size(45, 24)
        Me._tbMaxPos_1.TabIndex = 192
        Me._tbMaxPos_1.Text = "0000"
        Me._tbMaxPos_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_1
        '
        Me._tbMinPos_1.AcceptsReturn = True
        Me._tbMinPos_1.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_1.Location = New System.Drawing.Point(268, 99)
        Me._tbMinPos_1.MaxLength = 0
        Me._tbMinPos_1.Name = "_tbMinPos_1"
        Me._tbMinPos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_1.Size = New System.Drawing.Size(45, 24)
        Me._tbMinPos_1.TabIndex = 191
        Me._tbMinPos_1.Text = "0000"
        Me._tbMinPos_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServoPos_1
        '
        Me._barServoPos_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_1.LargeChange = 1
        Me._barServoPos_1.Location = New System.Drawing.Point(316, 98)
        Me._barServoPos_1.Maximum = 32767
        Me._barServoPos_1.Name = "_barServoPos_1"
        Me._barServoPos_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_1.Size = New System.Drawing.Size(131, 25)
        Me._barServoPos_1.TabIndex = 188
        Me._barServoPos_1.TabStop = True
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.SystemColors.Control
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(6, 98)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(113, 25)
        Me.Label30.TabIndex = 189
        Me.Label30.Text = "Altura Kinect"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tbMin_14
        '
        Me._tbMin_14.AcceptsReturn = True
        Me._tbMin_14.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_14.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_14.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_14.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_14.Location = New System.Drawing.Point(131, 71)
        Me._tbMin_14.MaxLength = 0
        Me._tbMin_14.Name = "_tbMin_14"
        Me._tbMin_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_14.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_14.TabIndex = 179
        Me._tbMin_14.Text = "0000"
        Me._tbMin_14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_14
        '
        Me._barServo_14.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_14.LargeChange = 1
        Me._barServo_14.Location = New System.Drawing.Point(176, 68)
        Me._barServo_14.Maximum = 32767
        Me._barServo_14.Name = "_barServo_14"
        Me._barServo_14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_14.Size = New System.Drawing.Size(166, 25)
        Me._barServo_14.TabIndex = 178
        Me._barServo_14.TabStop = True
        '
        '_tbMin_13
        '
        Me._tbMin_13.AcceptsReturn = True
        Me._tbMin_13.BackColor = System.Drawing.SystemColors.Window
        Me._tbMin_13.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMin_13.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMin_13.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMin_13.Location = New System.Drawing.Point(131, 43)
        Me._tbMin_13.MaxLength = 0
        Me._tbMin_13.Name = "_tbMin_13"
        Me._tbMin_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMin_13.Size = New System.Drawing.Size(45, 24)
        Me._tbMin_13.TabIndex = 177
        Me._tbMin_13.Text = "0000"
        Me._tbMin_13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServo_13
        '
        Me._barServo_13.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServo_13.LargeChange = 1
        Me._barServo_13.Location = New System.Drawing.Point(176, 43)
        Me._barServo_13.Maximum = 32767
        Me._barServo_13.Name = "_barServo_13"
        Me._barServo_13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServo_13.Size = New System.Drawing.Size(166, 25)
        Me._barServo_13.TabIndex = 174
        Me._barServo_13.TabStop = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(10, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(113, 25)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Adelanta-Atrás"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(113, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Derecha-Izq"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me._cmdPlay_8)
        Me.Frame4.Controls.Add(Me._cmdPlay_7)
        Me.Frame4.Controls.Add(Me._cmdPlay_6)
        Me.Frame4.Controls.Add(Me._tbValorRot_8)
        Me.Frame4.Controls.Add(Me._tbValorRot_7)
        Me.Frame4.Controls.Add(Me._tbValorRot_6)
        Me.Frame4.Controls.Add(Me.cbPosiciones)
        Me.Frame4.Controls.Add(Me.tbServoPosMen7)
        Me.Frame4.Controls.Add(Me.tbServoPosMas7)
        Me.Frame4.Controls.Add(Me.tbServoPosMen6)
        Me.Frame4.Controls.Add(Me.tbServoPosMas6)
        Me.Frame4.Controls.Add(Me.tbServoPosMen5)
        Me.Frame4.Controls.Add(Me.tbServoPosMas5)
        Me.Frame4.Controls.Add(Me._tbMaxPos_9)
        Me.Frame4.Controls.Add(Me._tbMaxPos_8)
        Me.Frame4.Controls.Add(Me._tbMaxPos_7)
        Me.Frame4.Controls.Add(Me._tbMaxPos_6)
        Me.Frame4.Controls.Add(Me._tbValorParar_9)
        Me.Frame4.Controls.Add(Me._tbValorParar_8)
        Me.Frame4.Controls.Add(Me._tbValorParar_7)
        Me.Frame4.Controls.Add(Me._tbValorParar_6)
        Me.Frame4.Controls.Add(Me._tbParar_9)
        Me.Frame4.Controls.Add(Me._tbMenos_9)
        Me.Frame4.Controls.Add(Me._tbMas_9)
        Me.Frame4.Controls.Add(Me._tbParar_8)
        Me.Frame4.Controls.Add(Me._tbMenos_8)
        Me.Frame4.Controls.Add(Me._tbMas_8)
        Me.Frame4.Controls.Add(Me._tbParar_7)
        Me.Frame4.Controls.Add(Me._tbMenos_7)
        Me.Frame4.Controls.Add(Me._tbMas_7)
        Me.Frame4.Controls.Add(Me._tbParar_6)
        Me.Frame4.Controls.Add(Me._tbMenos_6)
        Me.Frame4.Controls.Add(Me._tbMas_6)
        Me.Frame4.Controls.Add(Me._tbMinPos_9)
        Me.Frame4.Controls.Add(Me._tbMinPos_8)
        Me.Frame4.Controls.Add(Me._tbMinPos_7)
        Me.Frame4.Controls.Add(Me._tbMinPos_6)
        Me.Frame4.Controls.Add(Me._barServoPos_9)
        Me.Frame4.Controls.Add(Me._barServoPos_8)
        Me.Frame4.Controls.Add(Me._barServoPos_7)
        Me.Frame4.Controls.Add(Me._barServoPos_6)
        Me.Frame4.Controls.Add(Me._tbNumServoPos_9)
        Me.Frame4.Controls.Add(Me._tbNumServoPos_8)
        Me.Frame4.Controls.Add(Me._tbNumServoPos_7)
        Me.Frame4.Controls.Add(Me._tbNumServoPos_6)
        Me.Frame4.Controls.Add(Me._tbValServoPos_6)
        Me.Frame4.Controls.Add(Me._tbValServoPos_7)
        Me.Frame4.Controls.Add(Me._tbValServoPos_8)
        Me.Frame4.Controls.Add(Me._tbValServoPos_9)
        Me.Frame4.Controls.Add(Me.Label8)
        Me.Frame4.Controls.Add(Me.Label7)
        Me.Frame4.Controls.Add(Me.Label6)
        Me.Frame4.Controls.Add(Me.Label5)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(10, 251)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(565, 93)
        Me.Frame4.TabIndex = 14
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "Brazo Izquierdo "
        '
        '_cmdPlay_8
        '
        Me._cmdPlay_8.Image = Global.MiRobot.My.Resources.Resources.play
        Me._cmdPlay_8.Location = New System.Drawing.Point(484, 62)
        Me._cmdPlay_8.Name = "_cmdPlay_8"
        Me._cmdPlay_8.Size = New System.Drawing.Size(26, 27)
        Me._cmdPlay_8.TabIndex = 221
        Me._cmdPlay_8.UseVisualStyleBackColor = True
        '
        '_cmdPlay_7
        '
        Me._cmdPlay_7.Image = Global.MiRobot.My.Resources.Resources.play
        Me._cmdPlay_7.Location = New System.Drawing.Point(484, 39)
        Me._cmdPlay_7.Name = "_cmdPlay_7"
        Me._cmdPlay_7.Size = New System.Drawing.Size(26, 27)
        Me._cmdPlay_7.TabIndex = 220
        Me._cmdPlay_7.UseVisualStyleBackColor = True
        '
        '_cmdPlay_6
        '
        Me._cmdPlay_6.Image = Global.MiRobot.My.Resources.Resources.play
        Me._cmdPlay_6.Location = New System.Drawing.Point(483, 14)
        Me._cmdPlay_6.Name = "_cmdPlay_6"
        Me._cmdPlay_6.Size = New System.Drawing.Size(26, 27)
        Me._cmdPlay_6.TabIndex = 219
        Me._cmdPlay_6.UseVisualStyleBackColor = True
        '
        '_tbValorRot_8
        '
        Me._tbValorRot_8.AcceptsReturn = True
        Me._tbValorRot_8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValorRot_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorRot_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorRot_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorRot_8.Location = New System.Drawing.Point(453, 63)
        Me._tbValorRot_8.MaxLength = 0
        Me._tbValorRot_8.Name = "_tbValorRot_8"
        Me._tbValorRot_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorRot_8.Size = New System.Drawing.Size(30, 24)
        Me._tbValorRot_8.TabIndex = 218
        Me._tbValorRot_8.Text = "0000"
        Me._tbValorRot_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorRot_7
        '
        Me._tbValorRot_7.AcceptsReturn = True
        Me._tbValorRot_7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValorRot_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorRot_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorRot_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorRot_7.Location = New System.Drawing.Point(453, 39)
        Me._tbValorRot_7.MaxLength = 0
        Me._tbValorRot_7.Name = "_tbValorRot_7"
        Me._tbValorRot_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorRot_7.Size = New System.Drawing.Size(30, 24)
        Me._tbValorRot_7.TabIndex = 217
        Me._tbValorRot_7.Text = "0000"
        Me._tbValorRot_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorRot_6
        '
        Me._tbValorRot_6.AcceptsReturn = True
        Me._tbValorRot_6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValorRot_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorRot_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorRot_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorRot_6.Location = New System.Drawing.Point(453, 14)
        Me._tbValorRot_6.MaxLength = 0
        Me._tbValorRot_6.Name = "_tbValorRot_6"
        Me._tbValorRot_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorRot_6.Size = New System.Drawing.Size(30, 24)
        Me._tbValorRot_6.TabIndex = 216
        Me._tbValorRot_6.Text = "0000"
        Me._tbValorRot_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbPosiciones
        '
        Me.cbPosiciones.FormattingEnabled = True
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbPosiciones, New Integer(-1) {})
        Me.cbPosiciones.Location = New System.Drawing.Point(6, 60)
        Me.cbPosiciones.Name = "cbPosiciones"
        Me.cbPosiciones.Size = New System.Drawing.Size(56, 26)
        Me.cbPosiciones.TabIndex = 198
        '
        '_tbMaxPos_9
        '
        Me._tbMaxPos_9.AcceptsReturn = True
        Me._tbMaxPos_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_9.Location = New System.Drawing.Point(446, 111)
        Me._tbMaxPos_9.MaxLength = 0
        Me._tbMaxPos_9.Name = "_tbMaxPos_9"
        Me._tbMaxPos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_9.Size = New System.Drawing.Size(45, 24)
        Me._tbMaxPos_9.TabIndex = 166
        Me._tbMaxPos_9.Text = "0000"
        Me._tbMaxPos_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_8
        '
        Me._tbMaxPos_8.AcceptsReturn = True
        Me._tbMaxPos_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_8.Location = New System.Drawing.Point(421, 62)
        Me._tbMaxPos_8.MaxLength = 0
        Me._tbMaxPos_8.Name = "_tbMaxPos_8"
        Me._tbMaxPos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_8.Size = New System.Drawing.Size(30, 24)
        Me._tbMaxPos_8.TabIndex = 165
        Me._tbMaxPos_8.Text = "000"
        Me._tbMaxPos_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_7
        '
        Me._tbMaxPos_7.AcceptsReturn = True
        Me._tbMaxPos_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_7.Location = New System.Drawing.Point(421, 38)
        Me._tbMaxPos_7.MaxLength = 0
        Me._tbMaxPos_7.Name = "_tbMaxPos_7"
        Me._tbMaxPos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_7.Size = New System.Drawing.Size(30, 24)
        Me._tbMaxPos_7.TabIndex = 164
        Me._tbMaxPos_7.Text = "000"
        Me._tbMaxPos_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_6
        '
        Me._tbMaxPos_6.AcceptsReturn = True
        Me._tbMaxPos_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_6.Location = New System.Drawing.Point(421, 14)
        Me._tbMaxPos_6.MaxLength = 0
        Me._tbMaxPos_6.Name = "_tbMaxPos_6"
        Me._tbMaxPos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_6.Size = New System.Drawing.Size(30, 24)
        Me._tbMaxPos_6.TabIndex = 163
        Me._tbMaxPos_6.Text = "000"
        Me._tbMaxPos_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_9
        '
        Me._tbValorParar_9.AcceptsReturn = True
        Me._tbValorParar_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_9.Location = New System.Drawing.Point(229, 110)
        Me._tbValorParar_9.MaxLength = 0
        Me._tbValorParar_9.Name = "_tbValorParar_9"
        Me._tbValorParar_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_9.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_9.TabIndex = 190
        Me._tbValorParar_9.Text = "0000"
        Me._tbValorParar_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_8
        '
        Me._tbValorParar_8.AcceptsReturn = True
        Me._tbValorParar_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_8.Location = New System.Drawing.Point(213, 63)
        Me._tbValorParar_8.MaxLength = 0
        Me._tbValorParar_8.Name = "_tbValorParar_8"
        Me._tbValorParar_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_8.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_8.TabIndex = 189
        Me._tbValorParar_8.Text = "0000"
        Me._tbValorParar_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_7
        '
        Me._tbValorParar_7.AcceptsReturn = True
        Me._tbValorParar_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_7.Location = New System.Drawing.Point(213, 39)
        Me._tbValorParar_7.MaxLength = 0
        Me._tbValorParar_7.Name = "_tbValorParar_7"
        Me._tbValorParar_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_7.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_7.TabIndex = 188
        Me._tbValorParar_7.Text = "0000"
        Me._tbValorParar_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_6
        '
        Me._tbValorParar_6.AcceptsReturn = True
        Me._tbValorParar_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_6.Location = New System.Drawing.Point(213, 13)
        Me._tbValorParar_6.MaxLength = 0
        Me._tbValorParar_6.Name = "_tbValorParar_6"
        Me._tbValorParar_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_6.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_6.TabIndex = 187
        Me._tbValorParar_6.Text = "0000"
        Me._tbValorParar_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbParar_9
        '
        Me._tbParar_9.Location = New System.Drawing.Point(165, 109)
        Me._tbParar_9.Name = "_tbParar_9"
        Me._tbParar_9.Size = New System.Drawing.Size(31, 23)
        Me._tbParar_9.TabIndex = 186
        Me._tbParar_9.Text = "X"
        Me._tbParar_9.UseVisualStyleBackColor = True
        '
        '_tbMenos_9
        '
        Me._tbMenos_9.Location = New System.Drawing.Point(131, 109)
        Me._tbMenos_9.Name = "_tbMenos_9"
        Me._tbMenos_9.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_9.TabIndex = 185
        Me._tbMenos_9.Text = "<"
        Me._tbMenos_9.UseVisualStyleBackColor = True
        '
        '_tbMas_9
        '
        Me._tbMas_9.Location = New System.Drawing.Point(199, 109)
        Me._tbMas_9.Name = "_tbMas_9"
        Me._tbMas_9.Size = New System.Drawing.Size(31, 23)
        Me._tbMas_9.TabIndex = 184
        Me._tbMas_9.Text = ">"
        Me._tbMas_9.UseVisualStyleBackColor = True
        '
        '_tbParar_8
        '
        Me._tbParar_8.Image = CType(resources.GetObject("_tbParar_8.Image"), System.Drawing.Image)
        Me._tbParar_8.Location = New System.Drawing.Point(152, 62)
        Me._tbParar_8.Name = "_tbParar_8"
        Me._tbParar_8.Size = New System.Drawing.Size(28, 23)
        Me._tbParar_8.TabIndex = 183
        Me._tbParar_8.UseVisualStyleBackColor = True
        '
        '_tbMenos_8
        '
        Me._tbMenos_8.Image = Global.MiRobot.My.Resources.Resources.arriba_1
        Me._tbMenos_8.Location = New System.Drawing.Point(126, 61)
        Me._tbMenos_8.Name = "_tbMenos_8"
        Me._tbMenos_8.Size = New System.Drawing.Size(25, 23)
        Me._tbMenos_8.TabIndex = 182
        Me._tbMenos_8.UseVisualStyleBackColor = True
        '
        '_tbMas_8
        '
        Me._tbMas_8.Image = Global.MiRobot.My.Resources.Resources.abajo1
        Me._tbMas_8.Location = New System.Drawing.Point(181, 62)
        Me._tbMas_8.Name = "_tbMas_8"
        Me._tbMas_8.Size = New System.Drawing.Size(31, 23)
        Me._tbMas_8.TabIndex = 181
        Me._tbMas_8.UseVisualStyleBackColor = True
        '
        '_tbParar_7
        '
        Me._tbParar_7.Image = CType(resources.GetObject("_tbParar_7.Image"), System.Drawing.Image)
        Me._tbParar_7.Location = New System.Drawing.Point(152, 38)
        Me._tbParar_7.Name = "_tbParar_7"
        Me._tbParar_7.Size = New System.Drawing.Size(28, 23)
        Me._tbParar_7.TabIndex = 180
        Me._tbParar_7.UseVisualStyleBackColor = True
        '
        '_tbMenos_7
        '
        Me._tbMenos_7.Image = Global.MiRobot.My.Resources.Resources.arriba_1
        Me._tbMenos_7.Location = New System.Drawing.Point(181, 38)
        Me._tbMenos_7.Name = "_tbMenos_7"
        Me._tbMenos_7.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_7.TabIndex = 179
        Me._tbMenos_7.UseVisualStyleBackColor = True
        '
        '_tbMas_7
        '
        Me._tbMas_7.Image = Global.MiRobot.My.Resources.Resources.abajo1
        Me._tbMas_7.Location = New System.Drawing.Point(126, 37)
        Me._tbMas_7.Name = "_tbMas_7"
        Me._tbMas_7.Size = New System.Drawing.Size(25, 23)
        Me._tbMas_7.TabIndex = 178
        Me._tbMas_7.UseVisualStyleBackColor = True
        '
        '_tbParar_6
        '
        Me._tbParar_6.Image = CType(resources.GetObject("_tbParar_6.Image"), System.Drawing.Image)
        Me._tbParar_6.Location = New System.Drawing.Point(152, 14)
        Me._tbParar_6.Name = "_tbParar_6"
        Me._tbParar_6.Size = New System.Drawing.Size(28, 23)
        Me._tbParar_6.TabIndex = 177
        Me._tbParar_6.UseVisualStyleBackColor = True
        '
        '_tbMenos_6
        '
        Me._tbMenos_6.Image = Global.MiRobot.My.Resources.Resources.derecha_1
        Me._tbMenos_6.Location = New System.Drawing.Point(181, 14)
        Me._tbMenos_6.Name = "_tbMenos_6"
        Me._tbMenos_6.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_6.TabIndex = 176
        Me._tbMenos_6.UseVisualStyleBackColor = True
        '
        '_tbMas_6
        '
        Me._tbMas_6.Image = Global.MiRobot.My.Resources.Resources.izquierda_1
        Me._tbMas_6.Location = New System.Drawing.Point(126, 14)
        Me._tbMas_6.Name = "_tbMas_6"
        Me._tbMas_6.Size = New System.Drawing.Size(25, 23)
        Me._tbMas_6.TabIndex = 175
        Me._tbMas_6.UseVisualStyleBackColor = True
        '
        '_tbMinPos_9
        '
        Me._tbMinPos_9.AcceptsReturn = True
        Me._tbMinPos_9.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_9.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_9.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_9.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_9.Location = New System.Drawing.Point(266, 108)
        Me._tbMinPos_9.MaxLength = 0
        Me._tbMinPos_9.Name = "_tbMinPos_9"
        Me._tbMinPos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_9.Size = New System.Drawing.Size(45, 24)
        Me._tbMinPos_9.TabIndex = 174
        Me._tbMinPos_9.Text = "0000"
        Me._tbMinPos_9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_8
        '
        Me._tbMinPos_8.AcceptsReturn = True
        Me._tbMinPos_8.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_8.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_8.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_8.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_8.Location = New System.Drawing.Point(255, 61)
        Me._tbMinPos_8.MaxLength = 0
        Me._tbMinPos_8.Name = "_tbMinPos_8"
        Me._tbMinPos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_8.Size = New System.Drawing.Size(34, 24)
        Me._tbMinPos_8.TabIndex = 173
        Me._tbMinPos_8.Text = "000"
        Me._tbMinPos_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_7
        '
        Me._tbMinPos_7.AcceptsReturn = True
        Me._tbMinPos_7.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_7.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_7.Location = New System.Drawing.Point(255, 37)
        Me._tbMinPos_7.MaxLength = 0
        Me._tbMinPos_7.Name = "_tbMinPos_7"
        Me._tbMinPos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_7.Size = New System.Drawing.Size(34, 24)
        Me._tbMinPos_7.TabIndex = 172
        Me._tbMinPos_7.Text = "000"
        Me._tbMinPos_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_6
        '
        Me._tbMinPos_6.AcceptsReturn = True
        Me._tbMinPos_6.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_6.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_6.Location = New System.Drawing.Point(255, 13)
        Me._tbMinPos_6.MaxLength = 0
        Me._tbMinPos_6.Name = "_tbMinPos_6"
        Me._tbMinPos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_6.Size = New System.Drawing.Size(34, 24)
        Me._tbMinPos_6.TabIndex = 171
        Me._tbMinPos_6.Text = "000"
        Me._tbMinPos_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServoPos_9
        '
        Me._barServoPos_9.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_9.LargeChange = 1
        Me._barServoPos_9.Location = New System.Drawing.Point(314, 111)
        Me._barServoPos_9.Maximum = 32767
        Me._barServoPos_9.Name = "_barServoPos_9"
        Me._barServoPos_9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_9.Size = New System.Drawing.Size(133, 25)
        Me._barServoPos_9.TabIndex = 170
        Me._barServoPos_9.TabStop = True
        '
        '_barServoPos_8
        '
        Me._barServoPos_8.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_8.LargeChange = 1
        Me._barServoPos_8.Location = New System.Drawing.Point(289, 61)
        Me._barServoPos_8.Maximum = 32767
        Me._barServoPos_8.Name = "_barServoPos_8"
        Me._barServoPos_8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_8.Size = New System.Drawing.Size(129, 25)
        Me._barServoPos_8.TabIndex = 169
        Me._barServoPos_8.TabStop = True
        '
        '_barServoPos_7
        '
        Me._barServoPos_7.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_7.LargeChange = 1
        Me._barServoPos_7.Location = New System.Drawing.Point(289, 38)
        Me._barServoPos_7.Maximum = 32767
        Me._barServoPos_7.Name = "_barServoPos_7"
        Me._barServoPos_7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_7.Size = New System.Drawing.Size(129, 25)
        Me._barServoPos_7.TabIndex = 168
        Me._barServoPos_7.TabStop = True
        '
        '_barServoPos_6
        '
        Me._barServoPos_6.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_6.LargeChange = 1
        Me._barServoPos_6.Location = New System.Drawing.Point(289, 13)
        Me._barServoPos_6.Maximum = 32767
        Me._barServoPos_6.Name = "_barServoPos_6"
        Me._barServoPos_6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_6.Size = New System.Drawing.Size(129, 25)
        Me._barServoPos_6.TabIndex = 167
        Me._barServoPos_6.TabStop = True
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(115, 25)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Hombro-Cuerpo"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(6, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(115, 25)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Hombro-Brazo"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Biceps"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(8, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(113, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Antebrazo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.SystemColors.Control
        Me.Frame3.Controls.Add(Me.cmdLeerPosServosRot)
        Me.Frame3.Controls.Add(Me.cmdEjecutarMovRot)
        Me.Frame3.Controls.Add(Me._cmdPlay_4)
        Me.Frame3.Controls.Add(Me._cmdPlay_3)
        Me.Frame3.Controls.Add(Me._cmdPlay_2)
        Me.Frame3.Controls.Add(Me._tbValorRot_4)
        Me.Frame3.Controls.Add(Me._tbValorRot_3)
        Me.Frame3.Controls.Add(Me._tbValorRot_2)
        Me.Frame3.Controls.Add(Me.cmdEnviarPosParada)
        Me.Frame3.Controls.Add(Me.tbServoPosMen3)
        Me.Frame3.Controls.Add(Me.tbServoPosMas3)
        Me.Frame3.Controls.Add(Me.tbServoPosMen2)
        Me.Frame3.Controls.Add(Me.tbServoPosMas2)
        Me.Frame3.Controls.Add(Me.tbServoPosMen1)
        Me.Frame3.Controls.Add(Me.tbServoPosMas1)
        Me.Frame3.Controls.Add(Me._tbMaxPos_5)
        Me.Frame3.Controls.Add(Me._tbMaxPos_4)
        Me.Frame3.Controls.Add(Me._tbMaxPos_3)
        Me.Frame3.Controls.Add(Me._tbMaxPos_2)
        Me.Frame3.Controls.Add(Me._tbValorParar_5)
        Me.Frame3.Controls.Add(Me._tbValorParar_4)
        Me.Frame3.Controls.Add(Me._tbValorParar_3)
        Me.Frame3.Controls.Add(Me._tbValorParar_2)
        Me.Frame3.Controls.Add(Me._tbParar_5)
        Me.Frame3.Controls.Add(Me._tbMenos_5)
        Me.Frame3.Controls.Add(Me._tbMas_5)
        Me.Frame3.Controls.Add(Me._tbParar_4)
        Me.Frame3.Controls.Add(Me._tbMenos_4)
        Me.Frame3.Controls.Add(Me._tbMas_4)
        Me.Frame3.Controls.Add(Me._tbParar_3)
        Me.Frame3.Controls.Add(Me._tbMenos_3)
        Me.Frame3.Controls.Add(Me._tbMas_3)
        Me.Frame3.Controls.Add(Me._tbParar_2)
        Me.Frame3.Controls.Add(Me._tbMenos_2)
        Me.Frame3.Controls.Add(Me._tbMas_2)
        Me.Frame3.Controls.Add(Me._tbMinPos_5)
        Me.Frame3.Controls.Add(Me._tbMinPos_4)
        Me.Frame3.Controls.Add(Me._tbMinPos_3)
        Me.Frame3.Controls.Add(Me._tbMinPos_2)
        Me.Frame3.Controls.Add(Me._barServoPos_5)
        Me.Frame3.Controls.Add(Me._barServoPos_4)
        Me.Frame3.Controls.Add(Me._barServoPos_3)
        Me.Frame3.Controls.Add(Me._barServoPos_2)
        Me.Frame3.Controls.Add(Me._tbNumServoPos_5)
        Me.Frame3.Controls.Add(Me._tbNumServoPos_4)
        Me.Frame3.Controls.Add(Me._tbNumServoPos_3)
        Me.Frame3.Controls.Add(Me._tbNumServoPos_2)
        Me.Frame3.Controls.Add(Me._tbValServoPos_5)
        Me.Frame3.Controls.Add(Me._tbValServoPos_4)
        Me.Frame3.Controls.Add(Me._tbValServoPos_3)
        Me.Frame3.Controls.Add(Me._tbValServoPos_2)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.Controls.Add(Me.Label3)
        Me.Frame3.Controls.Add(Me.Label2)
        Me.Frame3.Controls.Add(Me.Label1)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(10, 153)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame3.Size = New System.Drawing.Size(569, 95)
        Me.Frame3.TabIndex = 1
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "Brazo Derecho "
        '
        '_cmdPlay_4
        '
        Me._cmdPlay_4.Image = Global.MiRobot.My.Resources.Resources.play
        Me._cmdPlay_4.Location = New System.Drawing.Point(484, 63)
        Me._cmdPlay_4.Name = "_cmdPlay_4"
        Me._cmdPlay_4.Size = New System.Drawing.Size(26, 27)
        Me._cmdPlay_4.TabIndex = 208
        Me._cmdPlay_4.UseVisualStyleBackColor = True
        '
        '_cmdPlay_3
        '
        Me._cmdPlay_3.Image = Global.MiRobot.My.Resources.Resources.play
        Me._cmdPlay_3.Location = New System.Drawing.Point(484, 40)
        Me._cmdPlay_3.Name = "_cmdPlay_3"
        Me._cmdPlay_3.Size = New System.Drawing.Size(26, 27)
        Me._cmdPlay_3.TabIndex = 207
        Me._cmdPlay_3.UseVisualStyleBackColor = True
        '
        '_cmdPlay_2
        '
        Me._cmdPlay_2.Image = Global.MiRobot.My.Resources.Resources.play
        Me._cmdPlay_2.Location = New System.Drawing.Point(483, 14)
        Me._cmdPlay_2.Name = "_cmdPlay_2"
        Me._cmdPlay_2.Size = New System.Drawing.Size(26, 27)
        Me._cmdPlay_2.TabIndex = 206
        Me._cmdPlay_2.UseVisualStyleBackColor = True
        '
        '_tbValorRot_4
        '
        Me._tbValorRot_4.AcceptsReturn = True
        Me._tbValorRot_4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValorRot_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorRot_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorRot_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorRot_4.Location = New System.Drawing.Point(453, 64)
        Me._tbValorRot_4.MaxLength = 0
        Me._tbValorRot_4.Name = "_tbValorRot_4"
        Me._tbValorRot_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorRot_4.Size = New System.Drawing.Size(30, 24)
        Me._tbValorRot_4.TabIndex = 205
        Me._tbValorRot_4.Text = "0000"
        Me._tbValorRot_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorRot_3
        '
        Me._tbValorRot_3.AcceptsReturn = True
        Me._tbValorRot_3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValorRot_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorRot_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorRot_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorRot_3.Location = New System.Drawing.Point(453, 40)
        Me._tbValorRot_3.MaxLength = 0
        Me._tbValorRot_3.Name = "_tbValorRot_3"
        Me._tbValorRot_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorRot_3.Size = New System.Drawing.Size(30, 24)
        Me._tbValorRot_3.TabIndex = 204
        Me._tbValorRot_3.Text = "0000"
        Me._tbValorRot_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorRot_2
        '
        Me._tbValorRot_2.AcceptsReturn = True
        Me._tbValorRot_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._tbValorRot_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorRot_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorRot_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorRot_2.Location = New System.Drawing.Point(453, 15)
        Me._tbValorRot_2.MaxLength = 0
        Me._tbValorRot_2.Name = "_tbValorRot_2"
        Me._tbValorRot_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorRot_2.Size = New System.Drawing.Size(30, 24)
        Me._tbValorRot_2.TabIndex = 203
        Me._tbValorRot_2.Text = "0000"
        Me._tbValorRot_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_5
        '
        Me._tbMaxPos_5.AcceptsReturn = True
        Me._tbMaxPos_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_5.Location = New System.Drawing.Point(450, 98)
        Me._tbMaxPos_5.MaxLength = 0
        Me._tbMaxPos_5.Name = "_tbMaxPos_5"
        Me._tbMaxPos_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_5.Size = New System.Drawing.Size(45, 24)
        Me._tbMaxPos_5.TabIndex = 158
        Me._tbMaxPos_5.Text = "0000"
        Me._tbMaxPos_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_4
        '
        Me._tbMaxPos_4.AcceptsReturn = True
        Me._tbMaxPos_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_4.Location = New System.Drawing.Point(422, 63)
        Me._tbMaxPos_4.MaxLength = 0
        Me._tbMaxPos_4.Name = "_tbMaxPos_4"
        Me._tbMaxPos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_4.Size = New System.Drawing.Size(30, 24)
        Me._tbMaxPos_4.TabIndex = 157
        Me._tbMaxPos_4.Text = "000"
        Me._tbMaxPos_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_3
        '
        Me._tbMaxPos_3.AcceptsReturn = True
        Me._tbMaxPos_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_3.Location = New System.Drawing.Point(422, 39)
        Me._tbMaxPos_3.MaxLength = 0
        Me._tbMaxPos_3.Name = "_tbMaxPos_3"
        Me._tbMaxPos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_3.Size = New System.Drawing.Size(30, 24)
        Me._tbMaxPos_3.TabIndex = 156
        Me._tbMaxPos_3.Text = "000"
        Me._tbMaxPos_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMaxPos_2
        '
        Me._tbMaxPos_2.AcceptsReturn = True
        Me._tbMaxPos_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbMaxPos_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMaxPos_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMaxPos_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMaxPos_2.Location = New System.Drawing.Point(422, 15)
        Me._tbMaxPos_2.MaxLength = 0
        Me._tbMaxPos_2.Name = "_tbMaxPos_2"
        Me._tbMaxPos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMaxPos_2.Size = New System.Drawing.Size(30, 24)
        Me._tbMaxPos_2.TabIndex = 155
        Me._tbMaxPos_2.Text = "0000"
        Me._tbMaxPos_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_5
        '
        Me._tbValorParar_5.AcceptsReturn = True
        Me._tbValorParar_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_5.Location = New System.Drawing.Point(231, 98)
        Me._tbValorParar_5.MaxLength = 0
        Me._tbValorParar_5.Name = "_tbValorParar_5"
        Me._tbValorParar_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_5.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_5.TabIndex = 182
        Me._tbValorParar_5.Text = "0000"
        Me._tbValorParar_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_4
        '
        Me._tbValorParar_4.AcceptsReturn = True
        Me._tbValorParar_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_4.Location = New System.Drawing.Point(213, 65)
        Me._tbValorParar_4.MaxLength = 0
        Me._tbValorParar_4.Name = "_tbValorParar_4"
        Me._tbValorParar_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_4.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_4.TabIndex = 181
        Me._tbValorParar_4.Text = "0000"
        Me._tbValorParar_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_3
        '
        Me._tbValorParar_3.AcceptsReturn = True
        Me._tbValorParar_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_3.Location = New System.Drawing.Point(213, 41)
        Me._tbValorParar_3.MaxLength = 0
        Me._tbValorParar_3.Name = "_tbValorParar_3"
        Me._tbValorParar_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_3.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_3.TabIndex = 180
        Me._tbValorParar_3.Text = "0000"
        Me._tbValorParar_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbValorParar_2
        '
        Me._tbValorParar_2.AcceptsReturn = True
        Me._tbValorParar_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_2.Location = New System.Drawing.Point(213, 15)
        Me._tbValorParar_2.MaxLength = 0
        Me._tbValorParar_2.Name = "_tbValorParar_2"
        Me._tbValorParar_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_2.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_2.TabIndex = 179
        Me._tbValorParar_2.Text = "0000"
        Me._tbValorParar_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbParar_5
        '
        Me._tbParar_5.Location = New System.Drawing.Point(167, 98)
        Me._tbParar_5.Name = "_tbParar_5"
        Me._tbParar_5.Size = New System.Drawing.Size(31, 23)
        Me._tbParar_5.TabIndex = 178
        Me._tbParar_5.Text = "X"
        Me._tbParar_5.UseVisualStyleBackColor = True
        '
        '_tbMenos_5
        '
        Me._tbMenos_5.Location = New System.Drawing.Point(133, 98)
        Me._tbMenos_5.Name = "_tbMenos_5"
        Me._tbMenos_5.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_5.TabIndex = 177
        Me._tbMenos_5.Text = "<"
        Me._tbMenos_5.UseVisualStyleBackColor = True
        '
        '_tbMas_5
        '
        Me._tbMas_5.Location = New System.Drawing.Point(201, 98)
        Me._tbMas_5.Name = "_tbMas_5"
        Me._tbMas_5.Size = New System.Drawing.Size(31, 23)
        Me._tbMas_5.TabIndex = 176
        Me._tbMas_5.Text = ">"
        Me._tbMas_5.UseVisualStyleBackColor = True
        '
        '_tbParar_4
        '
        Me._tbParar_4.Image = CType(resources.GetObject("_tbParar_4.Image"), System.Drawing.Image)
        Me._tbParar_4.Location = New System.Drawing.Point(152, 66)
        Me._tbParar_4.Name = "_tbParar_4"
        Me._tbParar_4.Size = New System.Drawing.Size(28, 23)
        Me._tbParar_4.TabIndex = 175
        Me._tbParar_4.UseVisualStyleBackColor = True
        '
        '_tbMenos_4
        '
        Me._tbMenos_4.Image = Global.MiRobot.My.Resources.Resources.arriba_1
        Me._tbMenos_4.Location = New System.Drawing.Point(126, 66)
        Me._tbMenos_4.Name = "_tbMenos_4"
        Me._tbMenos_4.Size = New System.Drawing.Size(25, 23)
        Me._tbMenos_4.TabIndex = 174
        Me._tbMenos_4.UseVisualStyleBackColor = True
        '
        '_tbMas_4
        '
        Me._tbMas_4.Image = Global.MiRobot.My.Resources.Resources.abajo1
        Me._tbMas_4.Location = New System.Drawing.Point(180, 66)
        Me._tbMas_4.Name = "_tbMas_4"
        Me._tbMas_4.Size = New System.Drawing.Size(31, 23)
        Me._tbMas_4.TabIndex = 173
        Me._tbMas_4.UseVisualStyleBackColor = True
        '
        '_tbParar_3
        '
        Me._tbParar_3.Image = CType(resources.GetObject("_tbParar_3.Image"), System.Drawing.Image)
        Me._tbParar_3.Location = New System.Drawing.Point(152, 42)
        Me._tbParar_3.Name = "_tbParar_3"
        Me._tbParar_3.Size = New System.Drawing.Size(28, 23)
        Me._tbParar_3.TabIndex = 172
        Me._tbParar_3.UseVisualStyleBackColor = True
        '
        '_tbMenos_3
        '
        Me._tbMenos_3.Image = Global.MiRobot.My.Resources.Resources.abajo1
        Me._tbMenos_3.Location = New System.Drawing.Point(126, 42)
        Me._tbMenos_3.Name = "_tbMenos_3"
        Me._tbMenos_3.Size = New System.Drawing.Size(25, 23)
        Me._tbMenos_3.TabIndex = 171
        Me._tbMenos_3.UseVisualStyleBackColor = True
        '
        '_tbMas_3
        '
        Me._tbMas_3.Image = Global.MiRobot.My.Resources.Resources.arriba_1
        Me._tbMas_3.Location = New System.Drawing.Point(180, 42)
        Me._tbMas_3.Name = "_tbMas_3"
        Me._tbMas_3.Size = New System.Drawing.Size(31, 23)
        Me._tbMas_3.TabIndex = 170
        Me._tbMas_3.UseVisualStyleBackColor = True
        '
        '_tbParar_2
        '
        Me._tbParar_2.Image = CType(resources.GetObject("_tbParar_2.Image"), System.Drawing.Image)
        Me._tbParar_2.Location = New System.Drawing.Point(152, 16)
        Me._tbParar_2.Name = "_tbParar_2"
        Me._tbParar_2.Size = New System.Drawing.Size(28, 23)
        Me._tbParar_2.TabIndex = 169
        Me._tbParar_2.UseVisualStyleBackColor = True
        '
        '_tbMenos_2
        '
        Me._tbMenos_2.Image = Global.MiRobot.My.Resources.Resources.derecha_1
        Me._tbMenos_2.Location = New System.Drawing.Point(180, 16)
        Me._tbMenos_2.Name = "_tbMenos_2"
        Me._tbMenos_2.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_2.TabIndex = 168
        Me._tbMenos_2.UseVisualStyleBackColor = True
        '
        '_tbMas_2
        '
        Me._tbMas_2.Image = Global.MiRobot.My.Resources.Resources.izquierda_1
        Me._tbMas_2.Location = New System.Drawing.Point(126, 16)
        Me._tbMas_2.Name = "_tbMas_2"
        Me._tbMas_2.Size = New System.Drawing.Size(25, 23)
        Me._tbMas_2.TabIndex = 167
        Me._tbMas_2.UseVisualStyleBackColor = True
        '
        '_tbMinPos_5
        '
        Me._tbMinPos_5.AcceptsReturn = True
        Me._tbMinPos_5.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_5.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_5.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_5.Location = New System.Drawing.Point(268, 97)
        Me._tbMinPos_5.MaxLength = 0
        Me._tbMinPos_5.Name = "_tbMinPos_5"
        Me._tbMinPos_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_5.Size = New System.Drawing.Size(45, 24)
        Me._tbMinPos_5.TabIndex = 166
        Me._tbMinPos_5.Text = "0000"
        Me._tbMinPos_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_4
        '
        Me._tbMinPos_4.AcceptsReturn = True
        Me._tbMinPos_4.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_4.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_4.Location = New System.Drawing.Point(257, 62)
        Me._tbMinPos_4.MaxLength = 0
        Me._tbMinPos_4.Name = "_tbMinPos_4"
        Me._tbMinPos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_4.Size = New System.Drawing.Size(32, 24)
        Me._tbMinPos_4.TabIndex = 165
        Me._tbMinPos_4.Text = "000"
        Me._tbMinPos_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_3
        '
        Me._tbMinPos_3.AcceptsReturn = True
        Me._tbMinPos_3.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_3.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_3.Location = New System.Drawing.Point(257, 38)
        Me._tbMinPos_3.MaxLength = 0
        Me._tbMinPos_3.Name = "_tbMinPos_3"
        Me._tbMinPos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_3.Size = New System.Drawing.Size(32, 24)
        Me._tbMinPos_3.TabIndex = 164
        Me._tbMinPos_3.Text = "000"
        Me._tbMinPos_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbMinPos_2
        '
        Me._tbMinPos_2.AcceptsReturn = True
        Me._tbMinPos_2.BackColor = System.Drawing.SystemColors.Window
        Me._tbMinPos_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbMinPos_2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbMinPos_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbMinPos_2.Location = New System.Drawing.Point(257, 14)
        Me._tbMinPos_2.MaxLength = 0
        Me._tbMinPos_2.Name = "_tbMinPos_2"
        Me._tbMinPos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbMinPos_2.Size = New System.Drawing.Size(32, 24)
        Me._tbMinPos_2.TabIndex = 163
        Me._tbMinPos_2.Text = "000"
        Me._tbMinPos_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_barServoPos_5
        '
        Me._barServoPos_5.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_5.LargeChange = 1
        Me._barServoPos_5.Location = New System.Drawing.Point(316, 97)
        Me._barServoPos_5.Maximum = 32767
        Me._barServoPos_5.Name = "_barServoPos_5"
        Me._barServoPos_5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_5.Size = New System.Drawing.Size(135, 25)
        Me._barServoPos_5.TabIndex = 162
        Me._barServoPos_5.TabStop = True
        '
        '_barServoPos_4
        '
        Me._barServoPos_4.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_4.LargeChange = 1
        Me._barServoPos_4.Location = New System.Drawing.Point(289, 62)
        Me._barServoPos_4.Maximum = 32767
        Me._barServoPos_4.Name = "_barServoPos_4"
        Me._barServoPos_4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_4.Size = New System.Drawing.Size(129, 25)
        Me._barServoPos_4.TabIndex = 161
        Me._barServoPos_4.TabStop = True
        '
        '_barServoPos_3
        '
        Me._barServoPos_3.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_3.LargeChange = 1
        Me._barServoPos_3.Location = New System.Drawing.Point(289, 39)
        Me._barServoPos_3.Maximum = 32767
        Me._barServoPos_3.Name = "_barServoPos_3"
        Me._barServoPos_3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_3.Size = New System.Drawing.Size(129, 25)
        Me._barServoPos_3.TabIndex = 160
        Me._barServoPos_3.TabStop = True
        '
        '_barServoPos_2
        '
        Me._barServoPos_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._barServoPos_2.LargeChange = 1
        Me._barServoPos_2.Location = New System.Drawing.Point(289, 14)
        Me._barServoPos_2.Maximum = 32767
        Me._barServoPos_2.Name = "_barServoPos_2"
        Me._barServoPos_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._barServoPos_2.Size = New System.Drawing.Size(129, 25)
        Me._barServoPos_2.TabIndex = 159
        Me._barServoPos_2.TabStop = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(8, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(113, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Antebrazo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(61, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Biceps"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hombro-Brazo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(119, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Hombro-Cuerpo"
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.Control
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(506, 453)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(70, 25)
        Me.Label28.TabIndex = 124
        Me.Label28.Text = "Unidad "
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.SystemColors.Control
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label27.Location = New System.Drawing.Point(506, 425)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(60, 25)
        Me.Label27.TabIndex = 94
        Me.Label27.Text = "Envío"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dispositivosD
        '
        Me.dispositivosD.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispositivosD.FormattingEnabled = True
        Me.listBoxComboBoxHelper1.SetItemData(Me.dispositivosD, New Integer(-1) {})
        Me.dispositivosD.Location = New System.Drawing.Point(12, 24)
        Me.dispositivosD.Name = "dispositivosD"
        Me.dispositivosD.Size = New System.Drawing.Size(265, 25)
        Me.dispositivosD.TabIndex = 20
        '
        'dispositivosI
        '
        Me.dispositivosI.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dispositivosI.FormattingEnabled = True
        Me.listBoxComboBoxHelper1.SetItemData(Me.dispositivosI, New Integer(-1) {})
        Me.dispositivosI.Location = New System.Drawing.Point(283, 24)
        Me.dispositivosI.Name = "dispositivosI"
        Me.dispositivosI.Size = New System.Drawing.Size(270, 25)
        Me.dispositivosI.TabIndex = 22
        '
        'cbRostroPython
        '
        Me.cbRostroPython.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRostroPython.FormattingEnabled = True
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbRostroPython, New Integer() {0, 0, 0})
        Me.cbRostroPython.Items.AddRange(New Object() {"Detectar", "Saludar", "Saludar y Conversar"})
        Me.cbRostroPython.Location = New System.Drawing.Point(156, 345)
        Me.cbRostroPython.Name = "cbRostroPython"
        Me.cbRostroPython.Size = New System.Drawing.Size(121, 22)
        Me.cbRostroPython.TabIndex = 213
        Me.cbRostroPython.Text = "Detectar"
        '
        'cbKinect
        '
        Me.cbKinect.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKinect.FormattingEnabled = True
        Me.listBoxComboBoxHelper1.SetItemData(Me.cbKinect, New Integer() {0, 0, 0, 0, 0})
        Me.cbKinect.Items.AddRange(New Object() {"Kinect Off", "Kinect Audio", "Kinect RGB", "Kinect Depth", "Kinect XNA"})
        Me.cbKinect.Location = New System.Drawing.Point(283, 344)
        Me.cbKinect.Name = "cbKinect"
        Me.cbKinect.Size = New System.Drawing.Size(88, 23)
        Me.cbKinect.TabIndex = 218
        Me.cbKinect.Text = "Kinect On"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btParar)
        Me.GroupBox1.Controls.Add(Me.btArrancar)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.HScrollBar2)
        Me.GroupBox1.Controls.Add(Me.Label32)
        Me.GroupBox1.Controls.Add(Me.tbVelMax)
        Me.GroupBox1.Controls.Add(Me.tbVelMin)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.barServoVel)
        Me.GroupBox1.Controls.Add(Me.tbVelValor)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.btAdelante)
        Me.GroupBox1.Controls.Add(Me.btAtras)
        Me.GroupBox1.Controls.Add(Me.tbServoDirMin)
        Me.GroupBox1.Controls.Add(Me.barServoDir)
        Me.GroupBox1.Controls.Add(Me.tbServoDirMax)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.tbDirValor)
        Me.GroupBox1.Controls.Add(Me.Label33)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 381)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(488, 107)
        Me.GroupBox1.TabIndex = 192
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base"
        '
        'btParar
        '
        Me.btParar.Image = CType(resources.GetObject("btParar.Image"), System.Drawing.Image)
        Me.btParar.Location = New System.Drawing.Point(121, 47)
        Me.btParar.Name = "btParar"
        Me.btParar.Size = New System.Drawing.Size(31, 23)
        Me.btParar.TabIndex = 201
        Me.btParar.UseVisualStyleBackColor = True
        '
        'btArrancar
        '
        Me.btArrancar.Image = Global.MiRobot.My.Resources.Resources.izquierda_1
        Me.btArrancar.Location = New System.Drawing.Point(87, 47)
        Me.btArrancar.Name = "btArrancar"
        Me.btArrancar.Size = New System.Drawing.Size(31, 23)
        Me.btArrancar.TabIndex = 200
        Me.btArrancar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(367, 74)
        Me.TextBox1.MaxLength = 0
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox1.Size = New System.Drawing.Size(45, 24)
        Me.TextBox1.TabIndex = 198
        Me.TextBox1.Text = "0000"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox6
        '
        Me.TextBox6.AcceptsReturn = True
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox6.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox6.Location = New System.Drawing.Point(90, 74)
        Me.TextBox6.MaxLength = 0
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBox6.Size = New System.Drawing.Size(45, 24)
        Me.TextBox6.TabIndex = 197
        Me.TextBox6.Text = "0000"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HScrollBar2
        '
        Me.HScrollBar2.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScrollBar2.LargeChange = 1
        Me.HScrollBar2.Location = New System.Drawing.Point(136, 75)
        Me.HScrollBar2.Maximum = 32767
        Me.HScrollBar2.Name = "HScrollBar2"
        Me.HScrollBar2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HScrollBar2.Size = New System.Drawing.Size(228, 25)
        Me.HScrollBar2.TabIndex = 193
        Me.HScrollBar2.TabStop = True
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.SystemColors.Control
        Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label32.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label32.Location = New System.Drawing.Point(5, 74)
        Me.Label32.Name = "Label32"
        Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label32.Size = New System.Drawing.Size(91, 25)
        Me.Label32.TabIndex = 195
        Me.Label32.Text = "Obstáculos"
        '
        'tbVelMax
        '
        Me.tbVelMax.AcceptsReturn = True
        Me.tbVelMax.BackColor = System.Drawing.SystemColors.Window
        Me.tbVelMax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVelMax.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVelMax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbVelMax.Location = New System.Drawing.Point(367, 47)
        Me.tbVelMax.MaxLength = 0
        Me.tbVelMax.Name = "tbVelMax"
        Me.tbVelMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbVelMax.Size = New System.Drawing.Size(45, 24)
        Me.tbVelMax.TabIndex = 192
        Me.tbVelMax.Text = "255"
        Me.tbVelMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbVelMin
        '
        Me.tbVelMin.AcceptsReturn = True
        Me.tbVelMin.BackColor = System.Drawing.SystemColors.Window
        Me.tbVelMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbVelMin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbVelMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbVelMin.Location = New System.Drawing.Point(156, 48)
        Me.tbVelMin.MaxLength = 0
        Me.tbVelMin.Name = "tbVelMin"
        Me.tbVelMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbVelMin.Size = New System.Drawing.Size(45, 24)
        Me.tbVelMin.TabIndex = 191
        Me.tbVelMin.Text = "0"
        Me.tbVelMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'barServoVel
        '
        Me.barServoVel.Cursor = System.Windows.Forms.Cursors.Default
        Me.barServoVel.LargeChange = 1
        Me.barServoVel.Location = New System.Drawing.Point(204, 46)
        Me.barServoVel.Maximum = 255
        Me.barServoVel.Name = "barServoVel"
        Me.barServoVel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.barServoVel.Size = New System.Drawing.Size(160, 25)
        Me.barServoVel.TabIndex = 188
        Me.barServoVel.TabStop = True
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.SystemColors.Control
        Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label31.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(1, 46)
        Me.Label31.Name = "Label31"
        Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label31.Size = New System.Drawing.Size(79, 25)
        Me.Label31.TabIndex = 189
        Me.Label31.Text = "Velocidad"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btAdelante
        '
        Me.btAdelante.Image = Global.MiRobot.My.Resources.Resources.izquierda_1
        Me.btAdelante.Location = New System.Drawing.Point(88, 19)
        Me.btAdelante.Name = "btAdelante"
        Me.btAdelante.Size = New System.Drawing.Size(31, 23)
        Me.btAdelante.TabIndex = 181
        Me.btAdelante.UseVisualStyleBackColor = True
        '
        'btAtras
        '
        Me.btAtras.Image = Global.MiRobot.My.Resources.Resources.derecha_1
        Me.btAtras.Location = New System.Drawing.Point(121, 19)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(31, 23)
        Me.btAtras.TabIndex = 180
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'tbServoDirMin
        '
        Me.tbServoDirMin.AcceptsReturn = True
        Me.tbServoDirMin.BackColor = System.Drawing.SystemColors.Window
        Me.tbServoDirMin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbServoDirMin.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbServoDirMin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbServoDirMin.Location = New System.Drawing.Point(156, 20)
        Me.tbServoDirMin.MaxLength = 0
        Me.tbServoDirMin.Name = "tbServoDirMin"
        Me.tbServoDirMin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbServoDirMin.Size = New System.Drawing.Size(45, 24)
        Me.tbServoDirMin.TabIndex = 177
        Me.tbServoDirMin.Text = "0"
        Me.tbServoDirMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'barServoDir
        '
        Me.barServoDir.Cursor = System.Windows.Forms.Cursors.Default
        Me.barServoDir.LargeChange = 1
        Me.barServoDir.Location = New System.Drawing.Point(204, 18)
        Me.barServoDir.Maximum = 255
        Me.barServoDir.Name = "barServoDir"
        Me.barServoDir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.barServoDir.Size = New System.Drawing.Size(162, 25)
        Me.barServoDir.TabIndex = 174
        Me.barServoDir.TabStop = True
        Me.barServoDir.Value = 85
        '
        'tbServoDirMax
        '
        Me.tbServoDirMax.AcceptsReturn = True
        Me.tbServoDirMax.BackColor = System.Drawing.SystemColors.Window
        Me.tbServoDirMax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbServoDirMax.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbServoDirMax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbServoDirMax.Location = New System.Drawing.Point(367, 20)
        Me.tbServoDirMax.MaxLength = 0
        Me.tbServoDirMax.Name = "tbServoDirMax"
        Me.tbServoDirMax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbServoDirMax.Size = New System.Drawing.Size(43, 24)
        Me.tbServoDirMax.TabIndex = 169
        Me.tbServoDirMax.Text = "255"
        Me.tbServoDirMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.SystemColors.Control
        Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label33.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(3, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label33.Size = New System.Drawing.Size(77, 25)
        Me.Label33.TabIndex = 32
        Me.Label33.Text = "Direccion"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.cmdSAPPO_1)
        Me.GroupBox2.Controls.Add(Me.cmdSAPPO_0)
        Me.GroupBox2.Controls.Add(Me.cmdControlLimitesOn)
        Me.GroupBox2.Controls.Add(Me.cmdControlLimitesOff)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.cmdControlLimOn)
        Me.GroupBox2.Controls.Add(Me.cmdControlLimOff)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me._tbValorParar_0)
        Me.GroupBox2.Controls.Add(Me._tbParar_0)
        Me.GroupBox2.Controls.Add(Me._tbMas_0)
        Me.GroupBox2.Controls.Add(Me._tbMenos_0)
        Me.GroupBox2.Controls.Add(Me.cmdCabeza1)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.tbControlPosOn)
        Me.GroupBox2.Controls.Add(Me.cmdCabeza0)
        Me.GroupBox2.Controls.Add(Me.tbControlPosOff)
        Me.GroupBox2.Controls.Add(Me.cmdCuerpo1)
        Me.GroupBox2.Controls.Add(Me.cmdBase1)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.cmdCuerpo0)
        Me.GroupBox2.Controls.Add(Me.cmdBase0)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(10, 493)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(487, 79)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Alimentación"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.SystemColors.Control
        Me.Label35.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label35.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(113, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label35.Size = New System.Drawing.Size(76, 25)
        Me.Label35.TabIndex = 213
        Me.Label35.Text = "C.Lim.Off"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(2, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(52, 25)
        Me.Label29.TabIndex = 210
        Me.Label29.Text = "C.Pos."
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_tbValorParar_0
        '
        Me._tbValorParar_0.AcceptsReturn = True
        Me._tbValorParar_0.BackColor = System.Drawing.SystemColors.Window
        Me._tbValorParar_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._tbValorParar_0.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tbValorParar_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me._tbValorParar_0.Location = New System.Drawing.Point(452, 16)
        Me._tbValorParar_0.MaxLength = 0
        Me._tbValorParar_0.Name = "_tbValorParar_0"
        Me._tbValorParar_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._tbValorParar_0.Size = New System.Drawing.Size(31, 24)
        Me._tbValorParar_0.TabIndex = 206
        Me._tbValorParar_0.Text = "0000"
        Me._tbValorParar_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '_tbParar_0
        '
        Me._tbParar_0.Image = CType(resources.GetObject("_tbParar_0.Image"), System.Drawing.Image)
        Me._tbParar_0.Location = New System.Drawing.Point(399, 16)
        Me._tbParar_0.Name = "_tbParar_0"
        Me._tbParar_0.Size = New System.Drawing.Size(31, 23)
        Me._tbParar_0.TabIndex = 205
        Me._tbParar_0.UseVisualStyleBackColor = True
        '
        '_tbMas_0
        '
        Me._tbMas_0.Image = Global.MiRobot.My.Resources.Resources.abajo1
        Me._tbMas_0.Location = New System.Drawing.Point(428, 16)
        Me._tbMas_0.Name = "_tbMas_0"
        Me._tbMas_0.Size = New System.Drawing.Size(25, 23)
        Me._tbMas_0.TabIndex = 204
        Me._tbMas_0.UseVisualStyleBackColor = True
        '
        '_tbMenos_0
        '
        Me._tbMenos_0.Image = Global.MiRobot.My.Resources.Resources.abajo1
        Me._tbMenos_0.Location = New System.Drawing.Point(369, 16)
        Me._tbMenos_0.Name = "_tbMenos_0"
        Me._tbMenos_0.Size = New System.Drawing.Size(31, 23)
        Me._tbMenos_0.TabIndex = 203
        Me._tbMenos_0.UseVisualStyleBackColor = True
        '
        'cmdCabeza1
        '
        Me.cmdCabeza1.Image = CType(resources.GetObject("cmdCabeza1.Image"), System.Drawing.Image)
        Me.cmdCabeza1.Location = New System.Drawing.Point(210, 13)
        Me.cmdCabeza1.Name = "cmdCabeza1"
        Me.cmdCabeza1.Size = New System.Drawing.Size(31, 27)
        Me.cmdCabeza1.TabIndex = 202
        Me.cmdCabeza1.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.SystemColors.Control
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(113, 19)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(68, 25)
        Me.Label26.TabIndex = 201
        Me.Label26.Text = "Cabeza"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdCabeza0
        '
        Me.cmdCabeza0.Image = CType(resources.GetObject("cmdCabeza0.Image"), System.Drawing.Image)
        Me.cmdCabeza0.Location = New System.Drawing.Point(181, 13)
        Me.cmdCabeza0.Name = "cmdCabeza0"
        Me.cmdCabeza0.Size = New System.Drawing.Size(31, 27)
        Me.cmdCabeza0.TabIndex = 200
        Me.cmdCabeza0.UseVisualStyleBackColor = True
        '
        'cmdCuerpo1
        '
        Me.cmdCuerpo1.Image = CType(resources.GetObject("cmdCuerpo1.Image"), System.Drawing.Image)
        Me.cmdCuerpo1.Location = New System.Drawing.Point(330, 13)
        Me.cmdCuerpo1.Name = "cmdCuerpo1"
        Me.cmdCuerpo1.Size = New System.Drawing.Size(31, 27)
        Me.cmdCuerpo1.TabIndex = 185
        Me.cmdCuerpo1.UseVisualStyleBackColor = True
        '
        'cmdBase1
        '
        Me.cmdBase1.Image = CType(resources.GetObject("cmdBase1.Image"), System.Drawing.Image)
        Me.cmdBase1.Location = New System.Drawing.Point(81, 14)
        Me.cmdBase1.Name = "cmdBase1"
        Me.cmdBase1.Size = New System.Drawing.Size(31, 27)
        Me.cmdBase1.TabIndex = 184
        Me.cmdBase1.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.SystemColors.Control
        Me.Label34.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label34.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(233, 19)
        Me.Label34.Name = "Label34"
        Me.Label34.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label34.Size = New System.Drawing.Size(68, 25)
        Me.Label34.TabIndex = 183
        Me.Label34.Text = "Cuerpo"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdCuerpo0
        '
        Me.cmdCuerpo0.Image = CType(resources.GetObject("cmdCuerpo0.Image"), System.Drawing.Image)
        Me.cmdCuerpo0.Location = New System.Drawing.Point(301, 13)
        Me.cmdCuerpo0.Name = "cmdCuerpo0"
        Me.cmdCuerpo0.Size = New System.Drawing.Size(31, 27)
        Me.cmdCuerpo0.TabIndex = 182
        Me.cmdCuerpo0.UseVisualStyleBackColor = True
        '
        'cmdBase0
        '
        Me.cmdBase0.Image = CType(resources.GetObject("cmdBase0.Image"), System.Drawing.Image)
        Me.cmdBase0.Location = New System.Drawing.Point(52, 14)
        Me.cmdBase0.Name = "cmdBase0"
        Me.cmdBase0.Size = New System.Drawing.Size(31, 27)
        Me.cmdBase0.TabIndex = 181
        Me.cmdBase0.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.SystemColors.Control
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(3, 20)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(51, 25)
        Me.Label36.TabIndex = 32
        Me.Label36.Text = "Base"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label38.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(363, 49)
        Me.Label38.Name = "Label38"
        Me.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label38.Size = New System.Drawing.Size(61, 25)
        Me.Label38.TabIndex = 219
        Me.Label38.Text = "SAPPO"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.SystemColors.Control
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(245, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(58, 25)
        Me.Label37.TabIndex = 216
        Me.Label37.Text = "Ctr.Lím"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbTexto
        '
        Me.tbTexto.AcceptsReturn = True
        Me.tbTexto.BackColor = System.Drawing.SystemColors.Window
        Me.tbTexto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbTexto.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTexto.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbTexto.Location = New System.Drawing.Point(9, 696)
        Me.tbTexto.MaxLength = 0
        Me.tbTexto.Multiline = True
        Me.tbTexto.Name = "tbTexto"
        Me.tbTexto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbTexto.Size = New System.Drawing.Size(413, 35)
        Me.tbTexto.TabIndex = 194
        '
        'Video
        '
        Me.Video.Controls.Add(Me.cmdControl)
        Me.Video.Controls.Add(Me.cbKinect)
        Me.Video.Controls.Add(Me.cmdFd)
        Me.Video.Controls.Add(Me.cmdFoto)
        Me.Video.Controls.Add(Me.cmdSimular)
        Me.Video.Controls.Add(Me.cbRostroPython)
        Me.Video.Controls.Add(Me.chkDetecRostroPython)
        Me.Video.Controls.Add(Me.tbDebug)
        Me.Video.Controls.Add(Me.chkSeguirCara)
        Me.Video.Controls.Add(Me.cmdVista3D)
        Me.Video.Controls.Add(Me.chkMovimiento)
        Me.Video.Controls.Add(Me.lblPixel)
        Me.Video.Controls.Add(Me.lblPos2)
        Me.Video.Controls.Add(Me.lblPos1)
        Me.Video.Controls.Add(Me.chkRostro)
        Me.Video.Controls.Add(Me.cmdResI)
        Me.Video.Controls.Add(Me.cmdConfigI)
        Me.Video.Controls.Add(Me.cmdFinI)
        Me.Video.Controls.Add(Me.cmdResD)
        Me.Video.Controls.Add(Me.cmdConfigD)
        Me.Video.Controls.Add(Me.cmdFinD)
        Me.Video.Controls.Add(Me.cmdIniciarI)
        Me.Video.Controls.Add(Me.dispositivosI)
        Me.Video.Controls.Add(Me.cmdIniciarD)
        Me.Video.Controls.Add(Me.dispositivosD)
        Me.Video.Controls.Add(Me.picVideoI)
        Me.Video.Controls.Add(Me.picVideoD)
        Me.Video.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Video.Location = New System.Drawing.Point(689, 365)
        Me.Video.Name = "Video"
        Me.Video.Size = New System.Drawing.Size(563, 402)
        Me.Video.TabIndex = 196
        Me.Video.TabStop = False
        Me.Video.Text = "Video"
        '
        'cmdControl
        '
        Me.cmdControl.Location = New System.Drawing.Point(402, 369)
        Me.cmdControl.Name = "cmdControl"
        Me.cmdControl.Size = New System.Drawing.Size(75, 23)
        Me.cmdControl.TabIndex = 219
        Me.cmdControl.UseVisualStyleBackColor = True
        '
        'cmdFd
        '
        Me.cmdFd.Location = New System.Drawing.Point(528, 55)
        Me.cmdFd.Name = "cmdFd"
        Me.cmdFd.Size = New System.Drawing.Size(24, 30)
        Me.cmdFd.TabIndex = 216
        Me.cmdFd.Text = "F"
        Me.cmdFd.UseVisualStyleBackColor = True
        '
        'cmdFoto
        '
        Me.cmdFoto.Location = New System.Drawing.Point(253, 55)
        Me.cmdFoto.Name = "cmdFoto"
        Me.cmdFoto.Size = New System.Drawing.Size(24, 30)
        Me.cmdFoto.TabIndex = 215
        Me.cmdFoto.Text = "F"
        Me.cmdFoto.UseVisualStyleBackColor = True
        '
        'cmdSimular
        '
        Me.cmdSimular.Location = New System.Drawing.Point(203, 55)
        Me.cmdSimular.Name = "cmdSimular"
        Me.cmdSimular.Size = New System.Drawing.Size(45, 30)
        Me.cmdSimular.TabIndex = 214
        Me.cmdSimular.Text = "Sim"
        Me.cmdSimular.UseVisualStyleBackColor = True
        '
        'chkDetecRostroPython
        '
        Me.chkDetecRostroPython.AutoSize = True
        Me.chkDetecRostroPython.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDetecRostroPython.Location = New System.Drawing.Point(12, 348)
        Me.chkDetecRostroPython.Name = "chkDetecRostroPython"
        Me.chkDetecRostroPython.Size = New System.Drawing.Size(142, 20)
        Me.chkDetecRostroPython.TabIndex = 212
        Me.chkDetecRostroPython.Text = "Detec.rostro Python"
        Me.chkDetecRostroPython.UseVisualStyleBackColor = True
        '
        'tbDebug
        '
        Me.tbDebug.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.tbDebug.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDebug.Location = New System.Drawing.Point(52, 1)
        Me.tbDebug.Name = "tbDebug"
        Me.tbDebug.Size = New System.Drawing.Size(502, 21)
        Me.tbDebug.TabIndex = 211
        Me.tbDebug.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkSeguirCara
        '
        Me.chkSeguirCara.AutoSize = True
        Me.chkSeguirCara.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeguirCara.Location = New System.Drawing.Point(195, 372)
        Me.chkSeguirCara.Name = "chkSeguirCara"
        Me.chkSeguirCara.Size = New System.Drawing.Size(104, 19)
        Me.chkSeguirCara.TabIndex = 36
        Me.chkSeguirCara.Text = "Seguir Rostro"
        Me.chkSeguirCara.UseVisualStyleBackColor = True
        '
        'cmdVista3D
        '
        Me.cmdVista3D.Location = New System.Drawing.Point(478, 369)
        Me.cmdVista3D.Name = "cmdVista3D"
        Me.cmdVista3D.Size = New System.Drawing.Size(75, 23)
        Me.cmdVista3D.TabIndex = 35
        Me.cmdVista3D.Text = "Vista3D"
        Me.cmdVista3D.UseVisualStyleBackColor = True
        '
        'chkMovimiento
        '
        Me.chkMovimiento.AutoSize = True
        Me.chkMovimiento.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMovimiento.Location = New System.Drawing.Point(310, 370)
        Me.chkMovimiento.Name = "chkMovimiento"
        Me.chkMovimiento.Size = New System.Drawing.Size(95, 20)
        Me.chkMovimiento.TabIndex = 34
        Me.chkMovimiento.Text = "Detec Mov."
        Me.chkMovimiento.UseVisualStyleBackColor = True
        '
        'lblPixel
        '
        Me.lblPixel.AutoSize = True
        Me.lblPixel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPixel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPixel.Location = New System.Drawing.Point(185, 370)
        Me.lblPixel.Name = "lblPixel"
        Me.lblPixel.Size = New System.Drawing.Size(2, 20)
        Me.lblPixel.TabIndex = 33
        '
        'lblPos2
        '
        Me.lblPos2.AutoSize = True
        Me.lblPos2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPos2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPos2.Location = New System.Drawing.Point(164, 370)
        Me.lblPos2.Name = "lblPos2"
        Me.lblPos2.Size = New System.Drawing.Size(21, 20)
        Me.lblPos2.TabIndex = 32
        Me.lblPos2.Text = "N"
        '
        'lblPos1
        '
        Me.lblPos1.AutoSize = True
        Me.lblPos1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblPos1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPos1.Location = New System.Drawing.Point(143, 370)
        Me.lblPos1.Name = "lblPos1"
        Me.lblPos1.Size = New System.Drawing.Size(21, 20)
        Me.lblPos1.TabIndex = 31
        Me.lblPos1.Text = "N"
        '
        'chkRostro
        '
        Me.chkRostro.AutoSize = True
        Me.chkRostro.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRostro.Location = New System.Drawing.Point(12, 370)
        Me.chkRostro.Name = "chkRostro"
        Me.chkRostro.Size = New System.Drawing.Size(133, 20)
        Me.chkRostro.TabIndex = 30
        Me.chkRostro.Text = "Detección Rostro"
        Me.chkRostro.UseVisualStyleBackColor = True
        '
        'cmdResI
        '
        Me.cmdResI.Enabled = False
        Me.cmdResI.Location = New System.Drawing.Point(471, 55)
        Me.cmdResI.Name = "cmdResI"
        Me.cmdResI.Size = New System.Drawing.Size(51, 30)
        Me.cmdResI.TabIndex = 29
        Me.cmdResI.Text = "Res"
        Me.cmdResI.UseVisualStyleBackColor = True
        '
        'cmdConfigI
        '
        Me.cmdConfigI.Enabled = False
        Me.cmdConfigI.Location = New System.Drawing.Point(410, 55)
        Me.cmdConfigI.Name = "cmdConfigI"
        Me.cmdConfigI.Size = New System.Drawing.Size(55, 30)
        Me.cmdConfigI.TabIndex = 28
        Me.cmdConfigI.Text = "Cfg"
        Me.cmdConfigI.UseVisualStyleBackColor = True
        '
        'cmdFinI
        '
        Me.cmdFinI.Enabled = False
        Me.cmdFinI.Location = New System.Drawing.Point(356, 55)
        Me.cmdFinI.Name = "cmdFinI"
        Me.cmdFinI.Size = New System.Drawing.Size(48, 30)
        Me.cmdFinI.TabIndex = 27
        Me.cmdFinI.Text = "Fin"
        Me.cmdFinI.UseVisualStyleBackColor = True
        '
        'cmdResD
        '
        Me.cmdResD.Enabled = False
        Me.cmdResD.Location = New System.Drawing.Point(156, 55)
        Me.cmdResD.Name = "cmdResD"
        Me.cmdResD.Size = New System.Drawing.Size(45, 30)
        Me.cmdResD.TabIndex = 26
        Me.cmdResD.Text = "Res"
        Me.cmdResD.UseVisualStyleBackColor = True
        '
        'cmdConfigD
        '
        Me.cmdConfigD.Enabled = False
        Me.cmdConfigD.Location = New System.Drawing.Point(109, 55)
        Me.cmdConfigD.Name = "cmdConfigD"
        Me.cmdConfigD.Size = New System.Drawing.Size(45, 30)
        Me.cmdConfigD.TabIndex = 25
        Me.cmdConfigD.Text = "Cfg"
        Me.cmdConfigD.UseVisualStyleBackColor = True
        '
        'cmdFinD
        '
        Me.cmdFinD.Enabled = False
        Me.cmdFinD.Location = New System.Drawing.Point(58, 55)
        Me.cmdFinD.Name = "cmdFinD"
        Me.cmdFinD.Size = New System.Drawing.Size(48, 30)
        Me.cmdFinD.TabIndex = 24
        Me.cmdFinD.Text = "Fin"
        Me.cmdFinD.UseVisualStyleBackColor = True
        '
        'cmdIniciarI
        '
        Me.cmdIniciarI.Enabled = False
        Me.cmdIniciarI.Location = New System.Drawing.Point(283, 55)
        Me.cmdIniciarI.Name = "cmdIniciarI"
        Me.cmdIniciarI.Size = New System.Drawing.Size(70, 30)
        Me.cmdIniciarI.TabIndex = 23
        Me.cmdIniciarI.Text = "Iniciar"
        Me.cmdIniciarI.UseVisualStyleBackColor = True
        '
        'cmdIniciarD
        '
        Me.cmdIniciarD.Enabled = False
        Me.cmdIniciarD.Location = New System.Drawing.Point(12, 55)
        Me.cmdIniciarD.Name = "cmdIniciarD"
        Me.cmdIniciarD.Size = New System.Drawing.Size(44, 30)
        Me.cmdIniciarD.TabIndex = 21
        Me.cmdIniciarD.Text = "Ini"
        Me.cmdIniciarD.UseVisualStyleBackColor = True
        '
        'picVideoI
        '
        Me.picVideoI.Location = New System.Drawing.Point(283, 91)
        Me.picVideoI.Name = "picVideoI"
        Me.picVideoI.Size = New System.Drawing.Size(270, 219)
        Me.picVideoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVideoI.TabIndex = 1
        Me.picVideoI.TabStop = False
        '
        'picVideoD
        '
        Me.picVideoD.Location = New System.Drawing.Point(12, 91)
        Me.picVideoD.Name = "picVideoD"
        Me.picVideoD.Size = New System.Drawing.Size(265, 219)
        Me.picVideoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVideoD.TabIndex = 0
        Me.picVideoD.TabStop = False
        '
        'Radar
        '
        Me.Radar.Controls.Add(Me.cmdBarridoLaserVer)
        Me.Radar.Controls.Add(Me.cmdBarridoLaserHor)
        Me.Radar.Controls.Add(Me.tbDistD)
        Me.Radar.Controls.Add(Me.tbDistC)
        Me.Radar.Controls.Add(Me.tbDistI)
        Me.Radar.Controls.Add(Me.tbDistT)
        Me.Radar.Controls.Add(Me.picRadar)
        Me.Radar.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radar.Location = New System.Drawing.Point(506, 484)
        Me.Radar.Name = "Radar"
        Me.Radar.Size = New System.Drawing.Size(177, 227)
        Me.Radar.TabIndex = 197
        Me.Radar.TabStop = False
        Me.Radar.Text = "Radar proximidad"
        '
        'cmdBarridoLaserVer
        '
        Me.cmdBarridoLaserVer.Image = Global.MiRobot.My.Resources.Resources.arriba_1
        Me.cmdBarridoLaserVer.Location = New System.Drawing.Point(16, 201)
        Me.cmdBarridoLaserVer.Name = "cmdBarridoLaserVer"
        Me.cmdBarridoLaserVer.Size = New System.Drawing.Size(25, 23)
        Me.cmdBarridoLaserVer.TabIndex = 206
        Me.cmdBarridoLaserVer.UseVisualStyleBackColor = True
        '
        'cmdBarridoLaserHor
        '
        Me.cmdBarridoLaserHor.Image = Global.MiRobot.My.Resources.Resources.derecha_1
        Me.cmdBarridoLaserHor.Location = New System.Drawing.Point(141, 201)
        Me.cmdBarridoLaserHor.Name = "cmdBarridoLaserHor"
        Me.cmdBarridoLaserHor.Size = New System.Drawing.Size(25, 23)
        Me.cmdBarridoLaserHor.TabIndex = 205
        Me.cmdBarridoLaserHor.UseVisualStyleBackColor = True
        '
        'tbDistD
        '
        Me.tbDistD.AcceptsReturn = True
        Me.tbDistD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tbDistD.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDistD.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDistD.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDistD.Location = New System.Drawing.Point(126, 18)
        Me.tbDistD.MaxLength = 0
        Me.tbDistD.Name = "tbDistD"
        Me.tbDistD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDistD.Size = New System.Drawing.Size(45, 24)
        Me.tbDistD.TabIndex = 130
        Me.tbDistD.Text = "0000"
        Me.tbDistD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDistC
        '
        Me.tbDistC.AcceptsReturn = True
        Me.tbDistC.BackColor = System.Drawing.SystemColors.Window
        Me.tbDistC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDistC.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDistC.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDistC.Location = New System.Drawing.Point(66, 19)
        Me.tbDistC.MaxLength = 0
        Me.tbDistC.Name = "tbDistC"
        Me.tbDistC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDistC.Size = New System.Drawing.Size(45, 24)
        Me.tbDistC.TabIndex = 129
        Me.tbDistC.Text = "0000"
        Me.tbDistC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDistI
        '
        Me.tbDistI.AcceptsReturn = True
        Me.tbDistI.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.tbDistI.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDistI.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDistI.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDistI.Location = New System.Drawing.Point(6, 18)
        Me.tbDistI.MaxLength = 0
        Me.tbDistI.Name = "tbDistI"
        Me.tbDistI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDistI.Size = New System.Drawing.Size(45, 24)
        Me.tbDistI.TabIndex = 128
        Me.tbDistI.Text = "0000"
        Me.tbDistI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbDistT
        '
        Me.tbDistT.AcceptsReturn = True
        Me.tbDistT.BackColor = System.Drawing.SystemColors.Window
        Me.tbDistT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbDistT.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDistT.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbDistT.Location = New System.Drawing.Point(44, 200)
        Me.tbDistT.MaxLength = 0
        Me.tbDistT.Name = "tbDistT"
        Me.tbDistT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbDistT.Size = New System.Drawing.Size(95, 24)
        Me.tbDistT.TabIndex = 127
        Me.tbDistT.Text = "0000"
        Me.tbDistT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'picRadar
        '
        Me.picRadar.Image = Global.MiRobot.My.Resources.Resources.Radar
        Me.picRadar.Location = New System.Drawing.Point(4, 45)
        Me.picRadar.Name = "picRadar"
        Me.picRadar.Size = New System.Drawing.Size(170, 153)
        Me.picRadar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRadar.TabIndex = 0
        Me.picRadar.TabStop = False
        '
        'tmrBateria
        '
        Me.tmrBateria.Enabled = True
        Me.tmrBateria.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tbPorcentajeCarga)
        Me.Panel1.Controls.Add(Me.lblPor)
        Me.Panel1.Controls.Add(Me.picBateriaCritica)
        Me.Panel1.Controls.Add(Me.picBateriaBaja)
        Me.Panel1.Controls.Add(Me.picBateriaAlta)
        Me.Panel1.Controls.Add(Me.picAlimentacion)
        Me.Panel1.Controls.Add(Me.picCargando)
        Me.Panel1.Location = New System.Drawing.Point(522, 713)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(154, 45)
        Me.Panel1.TabIndex = 198
        '
        'tbPorcentajeCarga
        '
        Me.tbPorcentajeCarga.AcceptsReturn = True
        Me.tbPorcentajeCarga.BackColor = System.Drawing.SystemColors.Window
        Me.tbPorcentajeCarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbPorcentajeCarga.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPorcentajeCarga.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbPorcentajeCarga.Location = New System.Drawing.Point(97, 10)
        Me.tbPorcentajeCarga.MaxLength = 0
        Me.tbPorcentajeCarga.Name = "tbPorcentajeCarga"
        Me.tbPorcentajeCarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbPorcentajeCarga.Size = New System.Drawing.Size(34, 24)
        Me.tbPorcentajeCarga.TabIndex = 128
        Me.tbPorcentajeCarga.Text = "000"
        Me.tbPorcentajeCarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPor
        '
        Me.lblPor.AutoSize = True
        Me.lblPor.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPor.Location = New System.Drawing.Point(129, 16)
        Me.lblPor.Name = "lblPor"
        Me.lblPor.Size = New System.Drawing.Size(21, 18)
        Me.lblPor.TabIndex = 134
        Me.lblPor.Text = "%"
        '
        'picBateriaCritica
        '
        Me.picBateriaCritica.Image = Global.MiRobot.My.Resources.Resources.bateria_critica
        Me.picBateriaCritica.Location = New System.Drawing.Point(6, 4)
        Me.picBateriaCritica.Name = "picBateriaCritica"
        Me.picBateriaCritica.Size = New System.Drawing.Size(26, 33)
        Me.picBateriaCritica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBateriaCritica.TabIndex = 133
        Me.picBateriaCritica.TabStop = False
        '
        'picBateriaBaja
        '
        Me.picBateriaBaja.Image = Global.MiRobot.My.Resources.Resources.bateria_baja
        Me.picBateriaBaja.Location = New System.Drawing.Point(6, 3)
        Me.picBateriaBaja.Name = "picBateriaBaja"
        Me.picBateriaBaja.Size = New System.Drawing.Size(26, 33)
        Me.picBateriaBaja.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBateriaBaja.TabIndex = 132
        Me.picBateriaBaja.TabStop = False
        '
        'picBateriaAlta
        '
        Me.picBateriaAlta.Image = Global.MiRobot.My.Resources.Resources.bateria_alta
        Me.picBateriaAlta.Location = New System.Drawing.Point(6, 3)
        Me.picBateriaAlta.Name = "picBateriaAlta"
        Me.picBateriaAlta.Size = New System.Drawing.Size(26, 33)
        Me.picBateriaAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBateriaAlta.TabIndex = 131
        Me.picBateriaAlta.TabStop = False
        '
        'picAlimentacion
        '
        Me.picAlimentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picAlimentacion.Image = Global.MiRobot.My.Resources.Resources.bateria_cargando
        Me.picAlimentacion.Location = New System.Drawing.Point(62, 0)
        Me.picAlimentacion.Name = "picAlimentacion"
        Me.picAlimentacion.Size = New System.Drawing.Size(31, 37)
        Me.picAlimentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAlimentacion.TabIndex = 130
        Me.picAlimentacion.TabStop = False
        '
        'picCargando
        '
        Me.picCargando.Image = Global.MiRobot.My.Resources.Resources.bateria_cargando1
        Me.picCargando.Location = New System.Drawing.Point(34, 3)
        Me.picCargando.Name = "picCargando"
        Me.picCargando.Size = New System.Drawing.Size(26, 33)
        Me.picCargando.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCargando.TabIndex = 129
        Me.picCargando.TabStop = False
        '
        'tmrDistancia
        '
        Me.tmrDistancia.Enabled = True
        Me.tmrDistancia.Interval = 500
        '
        'cmdDANI
        '
        Me.cmdDANI.Location = New System.Drawing.Point(427, 578)
        Me.cmdDANI.Name = "cmdDANI"
        Me.cmdDANI.Size = New System.Drawing.Size(75, 23)
        Me.cmdDANI.TabIndex = 199
        Me.cmdDANI.Text = "DANI"
        Me.cmdDANI.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.tbCPU)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Location = New System.Drawing.Point(428, 604)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(71, 76)
        Me.Panel2.TabIndex = 204
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MiRobot.My.Resources.Resources.uso_cpu
        Me.PictureBox1.Location = New System.Drawing.Point(9, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 137
        Me.PictureBox1.TabStop = False
        '
        'tbCPU
        '
        Me.tbCPU.AcceptsReturn = True
        Me.tbCPU.BackColor = System.Drawing.SystemColors.Window
        Me.tbCPU.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tbCPU.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCPU.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tbCPU.Location = New System.Drawing.Point(23, 47)
        Me.tbCPU.MaxLength = 0
        Me.tbCPU.Name = "tbCPU"
        Me.tbCPU.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbCPU.Size = New System.Drawing.Size(28, 24)
        Me.tbCPU.TabIndex = 135
        Me.tbCPU.Text = "000"
        Me.tbCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(49, 53)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(21, 18)
        Me.Label25.TabIndex = 136
        Me.Label25.Text = "%"
        '
        'tmrDeteccion
        '
        Me.tmrDeteccion.Interval = 1200
        '
        'tmrControlesGenerales
        '
        Me.tmrControlesGenerales.Enabled = True
        Me.tmrControlesGenerales.Interval = 300
        '
        'tmrMoverBoca
        '
        Me.tmrMoverBoca.Interval = 200
        '
        'chkMoverBoca
        '
        Me.chkMoverBoca.AutoSize = True
        Me.chkMoverBoca.Checked = True
        Me.chkMoverBoca.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMoverBoca.Location = New System.Drawing.Point(9, 737)
        Me.chkMoverBoca.Name = "chkMoverBoca"
        Me.chkMoverBoca.Size = New System.Drawing.Size(84, 17)
        Me.chkMoverBoca.TabIndex = 205
        Me.chkMoverBoca.Text = "Mover Boca"
        Me.chkMoverBoca.UseVisualStyleBackColor = True
        '
        'tmrLeerDatosArduino
        '
        '
        'chkRecuperarPosiciones
        '
        Me.chkRecuperarPosiciones.AutoSize = True
        Me.chkRecuperarPosiciones.Checked = True
        Me.chkRecuperarPosiciones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRecuperarPosiciones.Location = New System.Drawing.Point(99, 737)
        Me.chkRecuperarPosiciones.Name = "chkRecuperarPosiciones"
        Me.chkRecuperarPosiciones.Size = New System.Drawing.Size(86, 17)
        Me.chkRecuperarPosiciones.TabIndex = 206
        Me.chkRecuperarPosiciones.Text = "Leer Arduino"
        Me.chkRecuperarPosiciones.UseVisualStyleBackColor = True
        '
        'chkControlMovimiento
        '
        Me.chkControlMovimiento.AutoSize = True
        Me.chkControlMovimiento.Location = New System.Drawing.Point(191, 737)
        Me.chkControlMovimiento.Name = "chkControlMovimiento"
        Me.chkControlMovimiento.Size = New System.Drawing.Size(97, 17)
        Me.chkControlMovimiento.TabIndex = 207
        Me.chkControlMovimiento.Text = "Limites Off Soft"
        Me.chkControlMovimiento.UseVisualStyleBackColor = True
        '
        'chkEnviarPosIniServosControl
        '
        Me.chkEnviarPosIniServosControl.AutoSize = True
        Me.chkEnviarPosIniServosControl.Location = New System.Drawing.Point(311, 737)
        Me.chkEnviarPosIniServosControl.Name = "chkEnviarPosIniServosControl"
        Me.chkEnviarPosIniServosControl.Size = New System.Drawing.Size(102, 17)
        Me.chkEnviarPosIniServosControl.TabIndex = 208
        Me.chkEnviarPosIniServosControl.Text = "Env. Pos. Inicial"
        Me.chkEnviarPosIniServosControl.UseVisualStyleBackColor = True
        '
        'chkDebug
        '
        Me.chkDebug.AutoSize = True
        Me.chkDebug.Location = New System.Drawing.Point(419, 737)
        Me.chkDebug.Name = "chkDebug"
        Me.chkDebug.Size = New System.Drawing.Size(58, 17)
        Me.chkDebug.TabIndex = 210
        Me.chkDebug.Text = "Debug"
        Me.chkDebug.UseVisualStyleBackColor = True
        '
        'picIzq
        '
        Me.picIzq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIzq.Image = Global.MiRobot.My.Resources.Resources.derecha_1
        Me.picIzq.Location = New System.Drawing.Point(540, 10)
        Me.picIzq.Name = "picIzq"
        Me.picIzq.Size = New System.Drawing.Size(26, 26)
        Me.picIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIzq.TabIndex = 201
        Me.picIzq.TabStop = False
        Me.picIzq.Visible = False
        '
        'picDer
        '
        Me.picDer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDer.Image = Global.MiRobot.My.Resources.Resources.izquierda_1
        Me.picDer.Location = New System.Drawing.Point(472, 10)
        Me.picDer.Name = "picDer"
        Me.picDer.Size = New System.Drawing.Size(26, 26)
        Me.picDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDer.TabIndex = 200
        Me.picDer.TabStop = False
        '
        'picEstado
        '
        Me.picEstado.BackColor = System.Drawing.Color.Red
        Me.picEstado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picEstado.Cursor = System.Windows.Forms.Cursors.Default
        Me.picEstado.Location = New System.Drawing.Point(638, 397)
        Me.picEstado.Name = "picEstado"
        Me.picEstado.Size = New System.Drawing.Size(29, 25)
        Me.picEstado.TabIndex = 121
        Me.picEstado.TabStop = False
        '
        'Parada
        '
        Me.Parada.BackColor = System.Drawing.SystemColors.Control
        Me.Parada.Cursor = System.Windows.Forms.Cursors.Default
        Me.Parada.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Parada.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Parada.Image = Global.MiRobot.My.Resources.Resources.parar1
        Me.Parada.Location = New System.Drawing.Point(638, 368)
        Me.Parada.Name = "Parada"
        Me.Parada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Parada.Size = New System.Drawing.Size(29, 27)
        Me.Parada.TabIndex = 120
        Me.Parada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Parada.UseVisualStyleBackColor = False
        '
        'cmdArranque
        '
        Me.cmdArranque.BackColor = System.Drawing.SystemColors.Control
        Me.cmdArranque.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdArranque.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArranque.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdArranque.Image = Global.MiRobot.My.Resources.Resources._on
        Me.cmdArranque.Location = New System.Drawing.Point(604, 368)
        Me.cmdArranque.Name = "cmdArranque"
        Me.cmdArranque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdArranque.Size = New System.Drawing.Size(33, 27)
        Me.cmdArranque.TabIndex = 119
        Me.cmdArranque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdArranque.UseVisualStyleBackColor = False
        '
        'picRobot
        '
        Me.picRobot.BackColor = System.Drawing.SystemColors.Control
        Me.picRobot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picRobot.Cursor = System.Windows.Forms.Cursors.Default
        Me.picRobot.Image = CType(resources.GetObject("picRobot.Image"), System.Drawing.Image)
        Me.picRobot.Location = New System.Drawing.Point(472, 10)
        Me.picRobot.Name = "picRobot"
        Me.picRobot.Size = New System.Drawing.Size(94, 116)
        Me.picRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRobot.TabIndex = 77
        Me.picRobot.TabStop = False
        '
        'tmrDeteccionPython
        '
        Me.tmrDeteccionPython.Interval = 1000
        '
        'picFrame
        '
        Me.picFrame.Location = New System.Drawing.Point(472, 127)
        Me.picFrame.Name = "picFrame"
        Me.picFrame.Size = New System.Drawing.Size(200, 201)
        Me.picFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFrame.TabIndex = 211
        Me.picFrame.TabStop = False
        '
        'picInfo
        '
        Me.picInfo.Location = New System.Drawing.Point(572, 42)
        Me.picInfo.Name = "picInfo"
        Me.picInfo.Size = New System.Drawing.Size(100, 82)
        Me.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picInfo.TabIndex = 212
        Me.picInfo.TabStop = False
        '
        'frmControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1264, 766)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdPosIni)
        Me.Controls.Add(Me.picInfo)
        Me.Controls.Add(Me.cmdEjecMovTemp)
        Me.Controls.Add(Me.picFrame)
        Me.Controls.Add(Me.chkDebug)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.chkEnviarPosIniServosControl)
        Me.Controls.Add(Me.picBrazo)
        Me.Controls.Add(Me.picMano)
        Me.Controls.Add(Me.chkControlMovimiento)
        Me.Controls.Add(Me.chkRecuperarPosiciones)
        Me.Controls.Add(Me.chkMoverBoca)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.picIzq)
        Me.Controls.Add(Me.picDer)
        Me.Controls.Add(Me.cmdDANI)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Radar)
        Me.Controls.Add(Me.Video)
        Me.Controls.Add(Me.cmdHablar)
        Me.Controls.Add(Me.tbTexto)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdMoverRatón)
        Me.Controls.Add(Me.cbUnidad)
        Me.Controls.Add(Me.tbCom)
        Me.Controls.Add(Me.picEstado)
        Me.Controls.Add(Me.Parada)
        Me.Controls.Add(Me.cmdArranque)
        Me.Controls.Add(Me.cbModoEnvio)
        Me.Controls.Add(Me.cmdGenerarArduino)
        Me.Controls.Add(Me.cbPuerto)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.picRobot)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(3, 21)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmControl"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANI - Domótica Autónoma con Navegación Inteligente"
        CType(Me.picBrazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame6.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame9.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.listBoxComboBoxHelper1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Video.ResumeLayout(False)
        Me.Video.PerformLayout()
        CType(Me.picVideoI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVideoD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Radar.ResumeLayout(False)
        Me.Radar.PerformLayout()
        CType(Me.picRadar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picBateriaCritica, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBateriaBaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBateriaAlta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAlimentacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCargando, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIzq, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRobot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFrame, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Sub ReLoadForm(ByVal addEvents As Boolean)
        InitializetbValServo()
        InitializebarServo()
        InitializetbNumServo()
        InitializetbMin()
        InitializetbMax()

        InicializartbMenos()
        InicializartbParar()
        InicializartbMas()
        InicializartbValorParar()
        InicializartbMinPos()
        InicializartbMaxPos()
        InicializartbValorRot()
        InicializarcmdPlay()
        InicializartbValServoPos()
        InicializartbNumServoPos()
        InicializarbarServoPos()

        Form_Load()
        If addEvents Then
            AddHandler MyBase.Closed, AddressOf Me.frmControl_Closed
        End If
    End Sub
    Sub InitializetbValServo()
        ReDim tbValServo(15)
        Me.tbValServo(12) = _tbValServo_12
        Me.tbValServo(9) = _tbValServo_9
        Me.tbValServo(8) = _tbValServo_8
        Me.tbValServo(7) = _tbValServo_7
        Me.tbValServo(6) = _tbValServo_6
        Me.tbValServo(10) = _tbValServo_10
        Me.tbValServo(11) = _tbValServo_11
        Me.tbValServo(5) = _tbValServo_5
        Me.tbValServo(4) = _tbValServo_4
        Me.tbValServo(0) = _tbValServo_0
        Me.tbValServo(1) = _tbValServo_1
        Me.tbValServo(2) = _tbValServo_2
        Me.tbValServo(3) = _tbValServo_3
        Me.tbValServo(13) = _tbValServo_13
        Me.tbValServo(14) = _tbValServo_14
    End Sub
    Sub InitializetbNumServo()
        ReDim tbNumServo(15)
        Me.tbNumServo(12) = _tbNumServo_12
        Me.tbNumServo(11) = _tbNumServo_11
        Me.tbNumServo(10) = _tbNumServo_10
        Me.tbNumServo(9) = _tbNumServo_9
        Me.tbNumServo(8) = _tbNumServo_8
        Me.tbNumServo(7) = _tbNumServo_7
        Me.tbNumServo(6) = _tbNumServo_6
        Me.tbNumServo(5) = _tbNumServo_5
        Me.tbNumServo(4) = _tbNumServo_4
        Me.tbNumServo(3) = _tbNumServo_3
        Me.tbNumServo(2) = _tbNumServo_2
        Me.tbNumServo(1) = _tbNumServo_1
        Me.tbNumServo(0) = _tbNumServo_0
        Me.tbNumServo(13) = _tbNumServo_13
        Me.tbNumServo(14) = _tbNumServo_14
    End Sub
    Sub InitializetbMin()
        ReDim tbMin(15)
        Me.tbMin(12) = _tbMin_12
        Me.tbMin(11) = _tbMin_11
        Me.tbMin(10) = _tbMin_10
        Me.tbMin(9) = _tbMin_9
        Me.tbMin(8) = _tbMin_8
        Me.tbMin(7) = _tbMin_7
        Me.tbMin(6) = _tbMin_6
        Me.tbMin(5) = _tbMin_5
        Me.tbMin(4) = _tbMin_4
        Me.tbMin(3) = _tbMin_3
        Me.tbMin(2) = _tbMin_2
        Me.tbMin(1) = _tbMin_1
        Me.tbMin(0) = _tbMin_0
        Me.tbMin(13) = _tbMin_13
        Me.tbMin(14) = _tbMin_14
    End Sub
    Sub InitializetbMax()
        ReDim tbMax(15)
        Me.tbMax(12) = _tbMax_12
        Me.tbMax(11) = _tbMax_11
        Me.tbMax(10) = _tbMax_10
        Me.tbMax(9) = _tbMax_9
        Me.tbMax(8) = _tbMax_8
        Me.tbMax(7) = _tbMax_7
        Me.tbMax(6) = _tbMax_6
        Me.tbMax(5) = _tbMax_5
        Me.tbMax(4) = _tbMax_4
        Me.tbMax(3) = _tbMax_3
        Me.tbMax(2) = _tbMax_2
        Me.tbMax(1) = _tbMax_1
        Me.tbMax(0) = _tbMax_0
        Me.tbMax(13) = _tbMax_13
        Me.tbMax(14) = _tbMax_14
    End Sub
    Sub InitializebarServo()
        ReDim barServo(15)
        Me.barServo(12) = _barServo_12
        Me.barServo(9) = _barServo_9
        Me.barServo(8) = _barServo_8
        Me.barServo(7) = _barServo_7
        Me.barServo(6) = _barServo_6
        Me.barServo(10) = _barServo_10
        Me.barServo(11) = _barServo_11
        Me.barServo(5) = _barServo_5
        Me.barServo(4) = _barServo_4
        Me.barServo(0) = _barServo_0
        Me.barServo(1) = _barServo_1
        Me.barServo(2) = _barServo_2
        Me.barServo(3) = _barServo_3
        Me.barServo(13) = _barServo_13
        Me.barServo(14) = _barServo_14
    End Sub

    Sub InicializartbMenos()
        ReDim tbMenos(10)
        Me.tbMenos(0) = _tbMenos_0
        Me.tbMenos(1) = _tbMenos_1
        Me.tbMenos(2) = _tbMenos_2
        Me.tbMenos(3) = _tbMenos_3
        Me.tbMenos(4) = _tbMenos_4
        Me.tbMenos(5) = _tbMenos_5
        Me.tbMenos(6) = _tbMenos_6
        Me.tbMenos(7) = _tbMenos_7
        Me.tbMenos(8) = _tbMenos_8
        Me.tbMenos(9) = _tbMenos_9
    End Sub
    Sub InicializartbParar()
        ReDim tbParar(10)
        tbParar(0) = _tbParar_0
        tbParar(1) = _tbParar_1
        tbParar(2) = _tbParar_2
        tbParar(3) = _tbParar_3
        tbParar(4) = _tbParar_4
        tbParar(5) = _tbParar_5
        tbParar(6) = _tbParar_6
        tbParar(7) = _tbParar_7
        tbParar(8) = _tbParar_8
        tbParar(9) = _tbParar_9
    End Sub
    Sub InicializartbMas()
        ReDim tbMas(10)
        tbMas(0) = _tbMas_0
        tbMas(1) = _tbMas_1
        tbMas(2) = _tbMas_2
        tbMas(3) = _tbMas_3
        tbMas(4) = _tbMas_4
        tbMas(5) = _tbMas_5
        tbMas(6) = _tbMas_6
        tbMas(7) = _tbMas_7
        tbMas(8) = _tbMas_8
        tbMas(9) = _tbMas_9
    End Sub
    Sub InicializartbValorRot()
        ReDim tbValorRot(10)
        tbValorRot(0) = Nothing
        tbValorRot(1) = Nothing
        tbValorRot(2) = _tbValorRot_2
        tbValorRot(3) = _tbValorRot_3
        tbValorRot(4) = _tbValorRot_4
        tbValorRot(5) = Nothing
        tbValorRot(6) = _tbValorRot_6
        tbValorRot(7) = _tbValorRot_7
        tbValorRot(8) = _tbValorRot_8
        tbValorRot(9) = Nothing
    End Sub
    Sub InicializarcmdPlay()
        ReDim cmdPlay(10)
        cmdPlay(0) = Nothing
        cmdPlay(1) = Nothing
        cmdPlay(2) = _cmdPlay_2
        cmdPlay(3) = _cmdPlay_3
        cmdPlay(4) = _cmdPlay_4
        cmdPlay(5) = Nothing
        cmdPlay(6) = _cmdPlay_6
        cmdPlay(7) = _cmdPlay_7
        cmdPlay(8) = _cmdPlay_8
        cmdPlay(9) = Nothing
    End Sub
    Sub InicializartbValorParar()
        ReDim tbValorParar(10)
        tbValorParar(0) = _tbValorParar_0
        tbValorParar(1) = _tbValorParar_1
        tbValorParar(2) = _tbValorParar_2
        tbValorParar(3) = _tbValorParar_3
        tbValorParar(4) = _tbValorParar_4
        tbValorParar(5) = _tbValorParar_5
        tbValorParar(6) = _tbValorParar_6
        tbValorParar(7) = _tbValorParar_7
        tbValorParar(8) = _tbValorParar_8
        tbValorParar(9) = _tbValorParar_9
    End Sub

    Sub InicializartbMinPos()
        ReDim tbMinPos(10)
        tbMinPos(0) = _tbMin_14
        tbMinPos(1) = _tbMinPos_1
        tbMinPos(2) = _tbMinPos_2
        tbMinPos(3) = _tbMinPos_3
        tbMinPos(4) = _tbMinPos_4
        tbMinPos(5) = _tbMinPos_5
        tbMinPos(6) = _tbMinPos_6
        tbMinPos(7) = _tbMinPos_7
        tbMinPos(8) = _tbMinPos_8
        tbMinPos(9) = _tbMinPos_9
    End Sub
    Sub InicializartbMaxPos()
        ReDim tbMaxPos(10)
        tbMaxPos(0) = _tbMax_14
        tbMaxPos(1) = _tbMaxPos_1
        tbMaxPos(2) = _tbMaxPos_2
        tbMaxPos(3) = _tbMaxPos_3
        tbMaxPos(4) = _tbMaxPos_4
        tbMaxPos(5) = _tbMaxPos_5
        tbMaxPos(6) = _tbMaxPos_6
        tbMaxPos(7) = _tbMaxPos_7
        tbMaxPos(8) = _tbMaxPos_8
        tbMaxPos(9) = _tbMaxPos_9
    End Sub
    Sub InicializartbValServoPos()
        ReDim tbValServoPos(10)
        tbValServoPos(0) = _tbValServo_14
        tbValServoPos(1) = _tbValServoPos_1
        tbValServoPos(2) = _tbValServoPos_2
        tbValServoPos(3) = _tbValServoPos_3
        tbValServoPos(4) = _tbValServoPos_4
        tbValServoPos(5) = _tbValServoPos_5
        tbValServoPos(6) = _tbValServoPos_6
        tbValServoPos(7) = _tbValServoPos_7
        tbValServoPos(8) = _tbValServoPos_8
        tbValServoPos(9) = _tbValServoPos_9
    End Sub
    Sub InicializartbNumServoPos()
        ReDim tbNumServoPos(10)
        tbNumServoPos(0) = _tbNumServo_14
        tbNumServoPos(1) = _tbNumServoPos_1
        tbNumServoPos(2) = _tbNumServoPos_2
        tbNumServoPos(3) = _tbNumServoPos_3
        tbNumServoPos(4) = _tbNumServoPos_4
        tbNumServoPos(5) = _tbNumServoPos_5
        tbNumServoPos(6) = _tbNumServoPos_6
        tbNumServoPos(7) = _tbNumServoPos_7
        tbNumServoPos(8) = _tbNumServoPos_8
        tbNumServoPos(9) = _tbNumServoPos_9
    End Sub
    Sub InicializarbarServoPos()
        ReDim barServoPos(10)
        barServoPos(0) = _barServo_14
        barServoPos(1) = _barServoPos_1
        barServoPos(2) = _barServoPos_2
        barServoPos(3) = _barServoPos_3
        barServoPos(4) = _barServoPos_4
        barServoPos(5) = _barServoPos_5
        barServoPos(6) = _barServoPos_6
        barServoPos(7) = _barServoPos_7
        barServoPos(8) = _barServoPos_8
        barServoPos(9) = _barServoPos_9
    End Sub


    Private WithEvents _tbMin_13 As System.Windows.Forms.TextBox
    Private WithEvents _barServo_13 As System.Windows.Forms.HScrollBar
    Private WithEvents _tbMin_14 As System.Windows.Forms.TextBox
    Private WithEvents _barServo_14 As System.Windows.Forms.HScrollBar
    Private WithEvents _tbMinPos_9 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_8 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_7 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_6 As System.Windows.Forms.TextBox
    Private WithEvents _barServoPos_9 As System.Windows.Forms.HScrollBar
    Private WithEvents _barServoPos_8 As System.Windows.Forms.HScrollBar
    Private WithEvents _barServoPos_7 As System.Windows.Forms.HScrollBar
    Private WithEvents _barServoPos_6 As System.Windows.Forms.HScrollBar
    Private WithEvents _tbMinPos_5 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_4 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_3 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_2 As System.Windows.Forms.TextBox
    Private WithEvents _barServoPos_5 As System.Windows.Forms.HScrollBar
    Private WithEvents _barServoPos_4 As System.Windows.Forms.HScrollBar
    Private WithEvents _barServoPos_3 As System.Windows.Forms.HScrollBar
    Private WithEvents _barServoPos_2 As System.Windows.Forms.HScrollBar
    Friend WithEvents _tbParar_9 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_9 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_9 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_8 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_8 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_8 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_7 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_7 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_7 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_6 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_6 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_6 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_5 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_5 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_5 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_4 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_4 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_4 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_3 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_3 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_3 As System.Windows.Forms.Button
    Friend WithEvents _tbParar_2 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_2 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_2 As System.Windows.Forms.Button
    Private WithEvents _tbMaxPos_1 As System.Windows.Forms.TextBox
    Private WithEvents _tbMinPos_1 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServoPos_1 As System.Windows.Forms.TextBox
    Private WithEvents _barServoPos_1 As System.Windows.Forms.HScrollBar
    Private WithEvents _tbValServoPos_1 As System.Windows.Forms.TextBox
    Public WithEvents Label30 As System.Windows.Forms.Label
    Private WithEvents _tbValorParar_9 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_8 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_7 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_6 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_5 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_4 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_3 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_2 As System.Windows.Forms.TextBox
    Private WithEvents _tbValorParar_1 As System.Windows.Forms.TextBox
    Friend WithEvents _tbParar_1 As System.Windows.Forms.Button
    Friend WithEvents _tbMenos_1 As System.Windows.Forms.Button
    Friend WithEvents _tbMas_1 As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox
    Private WithEvents TextBox6 As System.Windows.Forms.TextBox
    Private WithEvents TextBox7 As System.Windows.Forms.TextBox
    Private WithEvents TextBox9 As System.Windows.Forms.TextBox
    Private WithEvents HScrollBar2 As System.Windows.Forms.HScrollBar
    Public WithEvents Label32 As System.Windows.Forms.Label
    Private WithEvents tbVelMax As System.Windows.Forms.TextBox
    Private WithEvents tbVelMin As System.Windows.Forms.TextBox
    Private WithEvents TextBox4 As System.Windows.Forms.TextBox
    Private WithEvents barServoVel As System.Windows.Forms.HScrollBar
    Private WithEvents tbVelValor As System.Windows.Forms.TextBox
    Public WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents btAdelante As System.Windows.Forms.Button
    Friend WithEvents btAtras As System.Windows.Forms.Button
    Private WithEvents tbServoDirMin As System.Windows.Forms.TextBox
    Private WithEvents barServoDir As System.Windows.Forms.HScrollBar
    Private WithEvents tbServoDirMax As System.Windows.Forms.TextBox
    Private WithEvents TextBox12 As System.Windows.Forms.TextBox
    Private WithEvents tbDirValor As System.Windows.Forms.TextBox
    Public WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdCuerpo1 As System.Windows.Forms.Button
    Friend WithEvents cmdBase1 As System.Windows.Forms.Button
    Public WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmdCuerpo0 As System.Windows.Forms.Button
    Friend WithEvents cmdBase0 As System.Windows.Forms.Button
    Public WithEvents Label36 As System.Windows.Forms.Label
    Private WithEvents _tbMax_12 As System.Windows.Forms.TextBox
    Private WithEvents _tbMin_12 As System.Windows.Forms.TextBox
    Private WithEvents _tbNumServo_12 As System.Windows.Forms.TextBox
    Private WithEvents _barServo_12 As System.Windows.Forms.HScrollBar
    Private WithEvents _tbValServo_12 As System.Windows.Forms.TextBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btParar As System.Windows.Forms.Button
    Friend WithEvents btArrancar As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Public WithEvents tbTexto As System.Windows.Forms.TextBox
    Friend WithEvents cmdHablar As System.Windows.Forms.Button
    Private WithEvents tbMarcas As System.Windows.Forms.TextBox
    Friend WithEvents Video As System.Windows.Forms.GroupBox
    Friend WithEvents Radar As System.Windows.Forms.GroupBox
    Friend WithEvents picRadar As System.Windows.Forms.PictureBox
    Friend WithEvents picVideoI As System.Windows.Forms.PictureBox
    Friend WithEvents picVideoD As System.Windows.Forms.PictureBox
    Private WithEvents tbDistD As System.Windows.Forms.TextBox
    Private WithEvents tbDistC As System.Windows.Forms.TextBox
    Private WithEvents tbDistI As System.Windows.Forms.TextBox
    Private WithEvents tbDistT As System.Windows.Forms.TextBox
    Friend WithEvents cmdIniciarD As System.Windows.Forms.Button
    Private WithEvents dispositivosD As System.Windows.Forms.ComboBox
    Friend WithEvents cmdIniciarI As System.Windows.Forms.Button
    Private WithEvents dispositivosI As System.Windows.Forms.ComboBox
    Friend WithEvents cmdResD As System.Windows.Forms.Button
    Friend WithEvents cmdConfigD As System.Windows.Forms.Button
    Friend WithEvents cmdFinD As System.Windows.Forms.Button
    Friend WithEvents cmdResI As System.Windows.Forms.Button
    Friend WithEvents cmdConfigI As System.Windows.Forms.Button
    Friend WithEvents cmdFinI As System.Windows.Forms.Button
    Friend WithEvents tmrBateria As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents picCargando As System.Windows.Forms.PictureBox
    Private WithEvents tbPorcentajeCarga As System.Windows.Forms.TextBox
    Friend WithEvents picAlimentacion As System.Windows.Forms.PictureBox
    Friend WithEvents picBateriaAlta As System.Windows.Forms.PictureBox
    Friend WithEvents picBateriaBaja As System.Windows.Forms.PictureBox
    Friend WithEvents picBateriaCritica As System.Windows.Forms.PictureBox
    Friend WithEvents lblPor As System.Windows.Forms.Label
    Friend WithEvents tmrDistancia As System.Windows.Forms.Timer
    Friend WithEvents cmdDANI As System.Windows.Forms.Button
    Friend WithEvents picDer As System.Windows.Forms.PictureBox
    Friend WithEvents picIzq As System.Windows.Forms.PictureBox
    Friend WithEvents tbControl As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents picBrazo As System.Windows.Forms.PictureBox
    Friend WithEvents picMano As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents tbCPU As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkRostro As System.Windows.Forms.CheckBox
    Friend WithEvents tmrDeteccion As System.Windows.Forms.Timer
    Friend WithEvents lblPos1 As System.Windows.Forms.Label
    Friend WithEvents lblPos2 As System.Windows.Forms.Label
    Friend WithEvents lblPixel As System.Windows.Forms.Label
    Friend WithEvents lblMAY As System.Windows.Forms.Label
    Friend WithEvents tmrControlesGenerales As System.Windows.Forms.Timer
    Friend WithEvents chkMovimiento As System.Windows.Forms.CheckBox
    Friend WithEvents cmdVista3D As System.Windows.Forms.Button
    Friend WithEvents cmdCabeza1 As System.Windows.Forms.Button
    Public WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cmdCabeza0 As System.Windows.Forms.Button
    Friend WithEvents chkSeguirCara As System.Windows.Forms.CheckBox
    Private WithEvents tbLogInt As System.Windows.Forms.TextBox
    Friend WithEvents tmrMoverBoca As System.Windows.Forms.Timer
    Friend WithEvents chkMoverBoca As System.Windows.Forms.CheckBox
    Friend WithEvents tmrLeerDatosArduino As Timer
    Friend WithEvents chkRecuperarPosiciones As CheckBox
    Friend WithEvents chkControlMovimiento As CheckBox
    Friend WithEvents tbControlPosOn As Button
    Friend WithEvents tbControlPosOff As Button
    Friend WithEvents chkEnviarPosIniServosControl As CheckBox
    Friend WithEvents cmdBorrar As Button
    Friend WithEvents chkDebug As CheckBox
    Friend WithEvents tbServoPosMen7 As Button
    Friend WithEvents tbServoPosMas7 As Button
    Friend WithEvents tbServoPosMen6 As Button
    Friend WithEvents tbServoPosMas6 As Button
    Friend WithEvents tbServoPosMen5 As Button
    Friend WithEvents tbServoPosMas5 As Button
    Friend WithEvents tbServoPosMen3 As Button
    Friend WithEvents tbServoPosMas3 As Button
    Friend WithEvents tbServoPosMen2 As Button
    Friend WithEvents tbServoPosMas2 As Button
    Friend WithEvents tbServoPosMen1 As Button
    Friend WithEvents tbServoPosMas1 As Button
    Friend WithEvents cmdSensorLineaR As Button
    Friend WithEvents cmdSensorLineaC As Button
    Friend WithEvents cmdSensorLineaL As Button
    Private WithEvents _tbValorParar_0 As TextBox
    Friend WithEvents _tbParar_0 As Button
    Friend WithEvents _tbMas_0 As Button
    Friend WithEvents _tbMenos_0 As Button
    Public WithEvents Label35 As Label
    Friend WithEvents cmdControlLimOn As Button
    Friend WithEvents cmdControlLimOff As Button
    Public WithEvents Label29 As Label
    Public WithEvents Label37 As Label
    Friend WithEvents cmdControlLimitesOn As Button
    Friend WithEvents cmdControlLimitesOff As Button
    Friend WithEvents cbPosiciones As ComboBox
    Public WithEvents cmdReset As Button
    Friend WithEvents tbDebug As TextBox
    Public WithEvents cmdEnviarPosParada As Button
    Private WithEvents tbAngSonido As TextBox
    Private WithEvents _tbValorRot_8 As TextBox
    Private WithEvents _tbValorRot_7 As TextBox
    Private WithEvents _tbValorRot_6 As TextBox
    Private WithEvents _tbValorRot_4 As TextBox
    Private WithEvents _tbValorRot_3 As TextBox
    Private WithEvents _tbValorRot_2 As TextBox
    Friend WithEvents _cmdPlay_8 As Button
    Friend WithEvents _cmdPlay_7 As Button
    Friend WithEvents _cmdPlay_6 As Button
    Friend WithEvents _cmdPlay_4 As Button
    Friend WithEvents _cmdPlay_3 As Button
    Friend WithEvents _cmdPlay_2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdEjecMovTemp As Button
    Friend WithEvents cmdLeerPosServosRot As Button
    Friend WithEvents cmdEjecutarMovRot As Button
    Friend WithEvents cmdPosIni As Button
    Friend WithEvents cmdSAPPO_1 As Button
    Friend WithEvents cmdSAPPO_0 As Button
    Public WithEvents Label38 As Label
    Friend WithEvents cmdBarridoLaserVer As Button
    Friend WithEvents cmdBarridoLaserHor As Button
    Friend WithEvents chkDetecRostroPython As CheckBox
    Friend WithEvents cbRostroPython As ComboBox
    Friend WithEvents tmrDeteccionPython As Timer
    Friend WithEvents picFrame As PictureBox
    Friend WithEvents cmdFoto As Button
    Friend WithEvents cmdSimular As Button
    Friend WithEvents picInfo As PictureBox
    Friend WithEvents cmdFd As Button
    Private WithEvents KinectAltura As HScrollBar
    Friend WithEvents Label39 As Label
    Friend WithEvents cbKinect As ComboBox
    Friend WithEvents cmdControl As Button
    Friend WithEvents cmdOff As Button
    Friend WithEvents cmdPrueba As Button
#End Region
End Class