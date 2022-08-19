Imports AForge.Controls
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports AForge
Imports AForge.Imaging
Imports AForge.Imaging.Filters
Imports AForge.Math.Geometry

Public Class Vista3D
#Region "Video"
    Dim FuenteDeVideoD As VideoCaptureDevice = Nothing
    Dim FuenteDeVideoI As VideoCaptureDevice = Nothing
    Dim DispositivosDeVideo As FilterInfoCollection
    Dim VideoResolucion As Integer = 0
    Dim ExistenDispositivos As Boolean = False

    Public ImagenX As Integer = 0
    Public ImagenY As Integer = 0
    Public ImagenAncho As Integer = 497
    Public ImagenAlto As Integer = 365
    Dim PuntoActivo As Integer = 0

    'Dim v3D As Vista3D = New Vista3D()
    Dim TomarImagenD As Boolean = False
    Dim TomarImagenI As Boolean = False
    Dim Imagen As Bitmap
    Public fControl As frmControl
    Dim ImageI As System.Drawing.Image
    Public FramesSegundo As Integer = 10

#End Region

    Private Sub cmdOcultar_Click(sender As Object, e As EventArgs) Handles cmdOcultar.Click
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub cmdVisualizarPanel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picVideoD.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles picVideoD.DoubleClick
        If SplitContainer1.Panel2Collapsed Then
            SplitContainer1.Panel2Collapsed = False
        Else
            SplitContainer1.Panel2Collapsed = True
        End If
    End Sub

    Private Sub tmrControl_Tick(sender As Object, e As EventArgs) Handles tmrControl.Tick
        If My.Computer.Keyboard.CapsLock Then
            lblMAY.Text = "M"
        Else
            lblMAY.Text = "C"
        End If
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
            If Not chkDiferido.Checked Then
                Imagen = CType(eventArgs.Frame.Clone, Bitmap)
                If Not chkRecorteI.Checked Then
                    picVideoD.Image = Imagen
                End If
            Else
                If TomarImagenD Then
                    TomarImagenD = False
                    Imagen = CType(eventArgs.Frame.Clone, Bitmap)
                End If
            End If
        Catch e As Exception

        End Try

    End Sub

    Private Sub video_NuevoFrameI(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            If Not chkDiferido.Checked Then
                ImageI = CType(eventArgs.Frame.Clone, Bitmap)
                If Not chkRecorteD.Checked Then
                    picVideoI.Image = Imagen
                End If
            Else
                If TomarImagenI Then
                    TomarImagenI = False
                    ImageI = CType(eventArgs.Frame.Clone, Bitmap)
                End If
            End If
        Catch e As Exception

        End Try

    End Sub
    Public Sub BuscarDispositivos()
        DispositivosDeVideo = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        If (DispositivosDeVideo.Count = 0) Then
            ExistenDispositivos = False
        Else
            ExistenDispositivos = True
            CargarDispositivos(cbDispositivos3DD)
            CargarDispositivos(cbDispositivos3DI)
            cmdIniciarI.Enabled = True
            cmdFinI.Enabled = True

            cmdIniciarD.Enabled = True
            cmdFinD.Enabled = True
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

    Private Sub Vista3D_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarDispositivos()
    End Sub

    Private Sub cmdIniciarD_Click(sender As Object, e As EventArgs) Handles cmdIniciarD.Click
        InicializarVideo(FuenteDeVideoD, cbDispositivos3DD, "D")
        tbControl.Focus()
    End Sub

    Private Sub cmdIniciarI_Click(sender As Object, e As EventArgs) Handles cmdIniciarI.Click
        InicializarVideo(FuenteDeVideoI, cbDispositivos3DI, "I")
        tbControl.Focus()
    End Sub

    Private Sub cmdFinD_Click(sender As Object, e As EventArgs) Handles cmdFinD.Click
        TerminarFuenteDeVideo(FuenteDeVideoD)
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

    Private Sub cmdFinI_Click(sender As Object, e As EventArgs) Handles cmdFinI.Click
        TerminarFuenteDeVideo(FuenteDeVideoI)
    End Sub

    Private Sub tbControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbControl.KeyPress
        If chkRecorteI.Checked Or chkRecorteD.Checked Then
            Select Case e.KeyChar.ToString()
                Case "8"
                    If PuntoActivo = 0 Then
                        If ImagenY > 0 Then ImagenY -= 1
                    Else
                        If ImagenAlto > 0 Then ImagenAlto -= 1
                    End If
                Case "2"
                    If PuntoActivo = 0 Then
                        If ImagenY < picVideoD.Height Then ImagenY += 1
                    Else
                        If ImagenAlto < picVideoD.Height Then ImagenAlto += 1
                    End If
                Case "4"
                    If PuntoActivo = 0 Then
                        If ImagenX > 0 Then ImagenX -= 1
                    Else
                        If ImagenAncho > 0 Then ImagenAncho -= 1
                    End If
                Case "6"
                    If PuntoActivo = 0 Then
                        If ImagenX < picVideoD.Width Then ImagenX += 1
                    Else
                        If ImagenAncho < picVideoD.Width Then ImagenAncho += 1
                    End If
                Case "5"
                    ImagenX = 0
                    ImagenY = 0
                    ImagenAncho = picVideoD.Width
                    ImagenAlto = picVideoD.Height
                Case "7"
                    If PuntoActivo = 0 Then
                        PuntoActivo = 1
                    Else
                        PuntoActivo = 0
                    End If
                Case Else
                    tbControl.Text = ""
                    e.Handled = False
                    Return
            End Select
            e.Handled = True
            tbControl.Text = ""
        Else
            fControl.ProcesarTeclado(e.KeyChar)
        End If
    End Sub

    Private Sub RecortarImagen(ImagenSrc As System.Drawing.Image, picVideo As System.Windows.Forms.PictureBox)
        'Dim src As Bitmap = New Bitmap(ImagenSrc)
        Dim src As Bitmap = ImagenSrc
        Dim dest As Bitmap = New Bitmap(picVideo.Width, picVideo.Height)
        Dim width As Integer = src.Width
        Dim height As Integer = src.Height
        'Dim sourceRect As RectangleF = New RectangleF(ImagenX, ImagenY, ImagenAncho, ImagenAlto)
        Dim sourceRect As RectangleF = New RectangleF(ImagenX, ImagenY, ImagenAncho, ImagenAlto)
        Dim ge As Graphics = Graphics.FromImage(dest)
        ' Draw a portion of the image. Scale that portion of the image
        ' so that it fills the destination rectangle.
        Dim destRect As RectangleF = New RectangleF(0, 0, picVideo.Width, picVideo.Height)
        'ge.DrawImage(src, 0, 0);
        ge.DrawImage(src, destRect, sourceRect, GraphicsUnit.Pixel)
        picVideo.Image = dest
    End Sub

    Private Sub chkRecorteIzq_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecorteI.CheckedChanged
        tbControl.Focus()
        If chkRecorteI.Checked = True Or chkRecorteD.Checked = True Then
            tmrRecorte.Enabled = True
        Else
            tmrRecorte.Enabled = False
        End If
    End Sub

    Private Sub tmrRecorte_Tick(sender As Object, e As EventArgs) Handles tmrRecorte.Tick
        If chkRecorteI.Checked Then
            RecortarImagen(Imagen, picVideoD)
        End If
        If chkRecorteD.Checked Then
            RecortarImagen(ImageI, picVideoI)
        End If
    End Sub

    Private Sub chkRecorteD_CheckedChanged(sender As Object, e As EventArgs) Handles chkRecorteD.CheckedChanged
        tbControl.Focus()
        If chkRecorteI.Checked = True Or chkRecorteD.Checked = True Then
            tmrRecorte.Enabled = True
        Else
            tmrRecorte.Enabled = False
        End If
    End Sub

    Private Sub tbControl_TextChanged(sender As Object, e As EventArgs) Handles tbControl.TextChanged

    End Sub

    Private Sub tmrDiferido_Tick(sender As Object, e As EventArgs) Handles tmrDiferido.Tick
        TomarImagenD = True
        TomarImagenI = True

        If Not chkRecorteD.Checked And chkDiferido.Checked Then
            picVideoD.Image = Imagen
        End If
        If Not chkRecorteI.Checked And chkDiferido.Checked Then
            picVideoI.Image = ImageI
        End If
    End Sub

    Private Sub chkDiferido_CheckedChanged(sender As Object, e As EventArgs) Handles chkDiferido.CheckedChanged
        If chkDiferido.Checked Then
            tmrDiferido.Interval = 1000 / FramesSegundo
            tmrDiferido.Enabled = True
        Else
            tmrDiferido.Enabled = False
        End If
    End Sub
    Public Sub ApagarCamaras()
        TerminarFuenteDeVideo(FuenteDeVideoD)
        TerminarFuenteDeVideo(FuenteDeVideoI)
    End Sub

    Private Sub Vista3D_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ApagarCamaras()
    End Sub

    Private Sub cmdVerRecorte_Click(sender As Object, e As EventArgs) Handles cmdVerRecorte.Click
        MessageBox.Show("X: " & ImagenX & ", Y: " & ImagenY & ", Ancho: " & ImagenAncho & ", Alto: " & ImagenAlto)
    End Sub

    Private Sub cbTiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTiempo.SelectedIndexChanged
        tmrDiferido.Interval = Val(cbTiempo.Text) * 100
    End Sub
End Class