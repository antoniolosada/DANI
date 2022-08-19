' https://www.youtube.com/watch?v=qXMJSeZEq_8


Imports System.Net
Imports System.Text
Imports System.IO


Public Class ServidorWeb
    Public a1 As Integer = 0
    Public a2 As Integer = 0
    Public a3 As Integer = 0
    Public a4 As Integer = 0
    Public a5 As Integer = 0
    Public VRCabeza As Boolean = False

    Dim SERVIDOR As HttpListener
    Dim HEBRA As Threading.Thread
    Dim RESPUESTA As String = "CONECTADO"
    Dim Timer As Long
    Structure sValores
        Dim par1 As Integer
        Dim par2 As Integer
        Dim par3 As Integer
        Dim par4 As Integer
        Dim par5 As Integer
        Dim cont As Long
    End Structure
    Dim lValores As List(Of sValores) = New List(Of sValores)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            SERVIDOR = New HttpListener
            If chkPrefijo.Checked Then
                SERVIDOR.Prefixes.Add(TextBoxSERVER.Text) 'Las aplicaciones que no se ejecutan con privilegios de administrador necesitan reserva de dominio
            Else
                SERVIDOR.Prefixes.Add("http://*:8080/") 'Para este modo hay que ser administrador
            End If
            ' Reservar dominio para no necesitar ser administrador: netsh http add urlacl url=http://*:8080/ user=Xunta
            SERVIDOR.Start()
            HEBRA = New Threading.Thread(AddressOf RESPONDE)
            HEBRA.Start()
            Button1.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
            SERVIDOR.Close()
        End Try

    End Sub

    Public Sub RESPONDE()
        While True
            Try
                Dim CONTEXTO As HttpListenerContext = SERVIDOR.GetContext
                CONTEXTO.Response.ContentLength64 = Encoding.UTF8.GetByteCount(RESPUESTA)
                CONTEXTO.Response.StatusCode = HttpStatusCode.OK
                Dim MISTREAM As Stream = CONTEXTO.Response.OutputStream
                Using (MISTREAM)
                    Using ESCRITOR As StreamWriter = New StreamWriter(MISTREAM)
                        ESCRITOR.Write(RESPUESTA)
                    End Using
                End Using

                Try
                    a1 = Convert.ToInt16(CONTEXTO.Request.QueryString.Item("par1").ToString())
                    a2 = Convert.ToInt16(CONTEXTO.Request.QueryString.Item("par2").ToString())
                    a3 = Convert.ToInt16(CONTEXTO.Request.QueryString.Item("par3").ToString())
                    a4 = Convert.ToInt16(CONTEXTO.Request.QueryString.Item("par4").ToString())
                    a5 = Convert.ToInt16(CONTEXTO.Request.QueryString.Item("par5").ToString())

                    System.Threading.Thread.Sleep(300)
                Catch ex As Exception
                    'Si no hay parámetros ignoramos el error
                End Try
            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

        End While

    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            HEBRA.Abort()
            SERVIDOR.Stop()
            Application.Exit()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RESPUESTA = TextBoxTEXTO.Text
        TextBoxTEXTO.Text = ""
    End Sub

    Public Sub CerrarServidor()
        Try
            HEBRA.Abort()
            SERVIDOR.Stop()
            Application.Exit()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tmrLOG_Tick(sender As Object, e As EventArgs) Handles tmrLOG.Tick
        Static sTimer As Long = 0
        If chkLOG.Checked Then
            sTimer += 1

            Dim g As Graphics
            g = picGrafica.CreateGraphics
            Dim pn As New Pen(Color.Blue, 2)
            Dim puntomedio = picGrafica.Height / 2
            If sTimer > picGrafica.Width Then
                picGrafica.Refresh()
                sTimer = 0
            End If
            g.DrawLine(Pens.Red, New Point(sTimer, puntomedio + a1), New Point(sTimer + 1, puntomedio + a1))
            g.DrawLine(Pens.Blue, New Point(sTimer, puntomedio + a2), New Point(sTimer + 1, puntomedio + a2))
            g.DrawLine(Pens.Green, New Point(sTimer, puntomedio + a3), New Point(sTimer + 1, puntomedio + a3))

            tbLOG.Text = a1 & ";" & a2 & ";" & a3 & ";" & a4 & ";" & a5 & ";" & Environment.NewLine & tbLOG.Text
        End If
    End Sub

    Private Sub chkVR_Cabeza_CheckedChanged(sender As Object, e As EventArgs) Handles chkVR_Cabeza.CheckedChanged
        If chkVR_Cabeza.Checked Then
            VRCabeza = True
        Else
            VRCabeza = False
        End If
    End Sub
End Class
