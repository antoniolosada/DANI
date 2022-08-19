Option Strict Off
Option Explicit On
Imports Artinsoft.VB6.Utils
Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Partial Friend Class frmControlRaton
	Inherits System.Windows.Forms.Form
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
	'Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)
	'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
	'Private Declare Function SetCursorPos Lib "user32" (ByVal x As Integer, ByVal y As Integer) As Integer
	Private Const MOUSEEVENTF_LEFTDOWN As Integer = &H2s
	Private Const MOUSEEVENTF_LEFTUP As Integer = &H4s
	Private Const MOUSEEVENTF_MIDDLEDOWN As Integer = &H20s
	Private Const MOUSEEVENTF_MIDDLEUP As Integer = &H40s
	Private Const MOUSEEVENTF_MOVE As Integer = &H1s
	Private Const MOUSEEVENTF_RIGHTDOWN As Integer = &H8s
	Private Const MOUSEEVENTF_RIGHTUP As Integer = &H10s

	'UPGRADE_NOTE: (2041) The following line was commented. More Information: http://www.vbtonet.com/ewis/ewi2041.aspx
	'Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer)

	Dim iCentroX As Integer
	Dim iCentroY As Integer
	Dim iX As Integer
	Dim iY As Integer
	Dim bControl As Boolean
	Dim bAbsoluto As Boolean

	Const MARGEN As Integer = 10
	Const MARGEN2 As Integer = 20

	Const ARRIBA As Integer = 0
	Const ABAJO As Integer = 1
	Const DERECHA As Integer = 2
	Const IZQUIERDA As Integer = 3
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



	Private Sub cmdActRaton_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdActRaton.Click
		bControl = Not bControl
	End Sub

	Private Sub cmdCentro_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles _cmdCentro_1.Click
		iCentroX = iX
		iCentroY = iY
	End Sub

	Private Sub cmdConectar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdConectar.Click
		Dim sCad, sValor As String
		Dim aCampos(2) As String

		On Error GoTo 0

		'mouse_event MOUSEEVENTF_MOVE, 10, 10, 0, 0
		'mouse_event MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0
		'mouse_event MOUSEEVENTF_LEFTUP, 0, 0, 0, 0

		If Not com.PortOpen Then

			com.Settings = "56000,n,8,1"
			com.CommPort = 15
			com.InputLen = 0
			com.SThreshold = 1
			com.PortOpen = True

			Do While True
				While (sCad.IndexOf(Constants.vbLf) + 1) = 0
					If Not com.PortOpen Then
						Exit Sub
					Else
						sCad = sCad & com.Input
					End If
					Application.DoEvents()
				End While
				If sCad.IndexOf(","c) >= 0 Then
					If RecuperarCampos(",", sCad, aCampos) Then
						tbCom.Text = tbCom.Text & "->" & aCampos(0) & "(" & CStr(iCentroX) & ")" & "," & aCampos(1) & "(" & CStr(iCentroY) & ")" & " --> " & sCad
						If Conversion.Val(aCampos(0)) <> -1 Then iX = Conversion.Val(Strings.Left(aCampos(0), 4))
						If Conversion.Val(aCampos(1)) <> -1 Then iY = Conversion.Val(Strings.Left(aCampos(1), 4))

						sCad = ""
						tbCom.SelectionStart = Strings.Len(tbCom.Text)
						If Strings.Len(tbCom.Text) > 20000 Then tbCom.Text = ""
						Application.DoEvents()

						If bControl Then
							If bAbsoluto Then
								If iCentroX > 0 Then
									RobotSupport.SafeNative.user32.SetCursorPos((iCentroX - iX) * 4 + 800, (iCentroY - iY) * 4 + 500)
								End If
							Else
								If iCentroX > 0 Then
									If iX - iCentroX > MARGEN Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, 4, 0, 0, 0)
										Iconos(DERECHA)
									End If
									If iCentroX - iX > MARGEN Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, -4, 0, 0, 0)
										Iconos(IZQUIERDA)
									End If

									If iY - iCentroY > MARGEN Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, 0, -4, 0, 0)
										Iconos(ARRIBA)
									End If
									If iCentroY - iY > MARGEN Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, 0, 4, 0, 0)
										Iconos(ABAJO)
									End If

									If iX - iCentroX > MARGEN2 Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, 10, 0, 0, 0)
										Iconos(DERECHA)
									End If
									If iCentroX - iX > MARGEN2 Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, -10, 0, 0, 0)
										Iconos(IZQUIERDA)
									End If

									If iY - iCentroY > MARGEN2 Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, 0, -10, 0, 0)
										Iconos(ARRIBA)
									End If
									If iCentroY - iY > MARGEN2 Then
										RobotSupport.SafeNative.user32.mouse_event(MOUSEEVENTF_MOVE, 0, 10, 0, 0)
										Iconos(ABAJO)
									End If
								End If
							End If
						End If
					End If
				End If
				sCad = ""
			Loop 
		Else
			com.PortOpen = False
		End If

	End Sub

	Function RecuperarCampos(ByRef sDelimitador As String, ByVal sCad As String, ByRef asCampos() As String) As Boolean
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

		Return iPos = 1 And Conversion.Val(Strings.Left(asCampos(0), 4)) > 0 And Conversion.Val(Strings.Left(asCampos(1), 4)) > 0
	End Function

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
	Private Sub Form_Load()
		bAbsoluto = False
	End Sub


	Sub Iconos(ByRef iPos As Integer)

		picArriba.Visible = True
		picAbajo.Visible = True
		picDerecha.Visible = True
		picIzq.Visible = True

		Select Case iPos
			Case ARRIBA
				picArriba.Visible = False
			Case ABAJO
				picAbajo.Visible = False
			Case DERECHA
				picDerecha.Visible = False
			Case IZQUIERDA
				picIzq.Visible = False
		End Select
		Application.DoEvents()
	End Sub
	Private Sub frmControlRaton_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
		MemoryHelper.ReleaseMemory()
	End Sub
End Class