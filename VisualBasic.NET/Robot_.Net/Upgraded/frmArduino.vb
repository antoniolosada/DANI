Option Strict Off
Option Explicit On
Imports System

Structure sInfoServos
	Dim nombre As String
	Dim numero As Integer
End Structure



Partial Friend Class frmArduino
	Inherits System.Windows.Forms.Form

	Public aNombreServos() As String =
		{
		"mano_derecha_pulgar",
		"mano_derecha_indice",
		"mano_derecha_medio",
		"mano_derecha_anular",
		"mano_derecha_menique",
		"mano_derecha_muneca",
		"mano_izquierda_pulgar",
		"mano_izquierda_indice",
		"mano_izquierda_medio",
		"mano_izquierda_anular",
		"mano_izquierda_menique",
		"mano_izquierda_muneca",
		"boca",
		"guinada",
		"cabeceo",
		"direccion"
		}
	Public aNumServos() As Integer = {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16}
	Public aNombreServosRot() As String =
		{
			"hombro_cuerpo_derecho",
			"hombro_brazo_derecho",
			"biceps_derecho",
			"hombro_cuerpo_iquierdo",
			"hombro_brazo_iquierdo",
			"biceps_izquierdo"
		}
	Public aNumServosRot() As Integer = {18, 19, 20, 22, 23, 24}

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


	Private Sub cmdCerrar_Click(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles cmdCerrar.Click
		Me.Close()
	End Sub

	'UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2080.aspx
	Private Sub Form_Load()
		Dim GRADOS As Integer

		With frmControl.DefInstance
			tbCodigo.Text = "//Valores de configuración servos rotacionales" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "sInfoServosRot InfoServosRot[NUM_SERVOS_ROT] =" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "{" & Environment.NewLine
			Dim i As Integer = 2
			For n As Integer = 2 To 8
				If n <> 5 Then
					tbCodigo.Text = tbCodigo.Text & "   {" & aNombreServosRot(i - 2) & "," & .tbValorParar(n).Tag & ", " & .tbValorParar(n).Text & "," & .tbMinPos(n).Text & "," & .tbMaxPos(n).Text & "," & .aToleranciaServos(i - 2) & ",0,0,0}"
					If n <> 8 Then tbCodigo.Text = tbCodigo.Text + "," + Environment.NewLine
					i = i + 1
				End If
			Next
			tbCodigo.Text = tbCodigo.Text & "};" & Environment.NewLine & Environment.NewLine & Environment.NewLine

			tbCodigo.Text = tbCodigo.Text & "//Valores de configuración servos normales" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "sInfoServos InfoServos[NUM_SERVOS] =" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "   {" & Environment.NewLine
			For i = 0 To 14
				tbCodigo.Text = tbCodigo.Text & "     {" & aNombreServos(i) & ", " & .barServo(i).Value.ToString() & ", " & .tbMin(i).Text & ", " & .tbMax(i).Text & "}," & Environment.NewLine
			Next
			tbCodigo.Text = tbCodigo.Text & "     {" & aNombreServos(15) & ", " & .RecCfg("valor_ini", "RASPER.giro") & ", " & .RecCfgLimiteMin("RASPER.giro") & ", " & .RecCfgLimiteMax("RASPER.giro") & "}" & Environment.NewLine
			tbCodigo.Text = tbCodigo.Text & "   };" & Environment.NewLine
		End With

	End Sub
	Private Sub frmArduino_Closed(ByVal eventSender As Object, ByVal eventArgs As EventArgs) Handles MyBase.Closed
	End Sub
End Class