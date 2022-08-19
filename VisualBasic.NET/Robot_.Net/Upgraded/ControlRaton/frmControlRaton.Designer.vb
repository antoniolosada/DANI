<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlRaton
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmControlRaton
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmControlRaton
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmControlRaton)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmControlRaton
		Dim theInstance As frmControlRaton = New frmControlRaton()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "picDerecha", "picAbajo", "picIzq", "picArriba", "picCursores", "_cmdCentro_1", "cmdActRaton", "tbCom", "cmdConectar", "com", "cmdCentro"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents picDerecha As System.Windows.Forms.PictureBox
	Public WithEvents picAbajo As System.Windows.Forms.PictureBox
	Public WithEvents picIzq As System.Windows.Forms.PictureBox
	Public WithEvents picArriba As System.Windows.Forms.PictureBox
	Public WithEvents picCursores As System.Windows.Forms.PictureBox
	Private WithEvents _cmdCentro_1 As System.Windows.Forms.Button
	Public WithEvents cmdActRaton As System.Windows.Forms.Button
	Public WithEvents tbCom As System.Windows.Forms.TextBox
	Public WithEvents cmdConectar As System.Windows.Forms.Button
	Public WithEvents com As AxMSCommLib.AxMSComm
	Public cmdCentro(1) As System.Windows.Forms.Button
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlRaton))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.picDerecha = New System.Windows.Forms.PictureBox()
		Me.picAbajo = New System.Windows.Forms.PictureBox()
		Me.picIzq = New System.Windows.Forms.PictureBox()
		Me.picCursores = New System.Windows.Forms.PictureBox()
		Me.picArriba = New System.Windows.Forms.PictureBox()
		Me._cmdCentro_1 = New System.Windows.Forms.Button()
		Me.cmdActRaton = New System.Windows.Forms.Button()
		Me.tbCom = New System.Windows.Forms.TextBox()
		Me.cmdConectar = New System.Windows.Forms.Button()
		Me.com = New AxMSCommLib.AxMSComm()
		CType(Me.com, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.picCursores.SuspendLayout()
		Me.SuspendLayout()
		' 
		'picDerecha
		' 
		Me.picDerecha.BackColor = System.Drawing.SystemColors.Window
		Me.picDerecha.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picDerecha.CausesValidation = True
		Me.picDerecha.Cursor = System.Windows.Forms.Cursors.Default
		Me.picDerecha.Dock = System.Windows.Forms.DockStyle.None
		Me.picDerecha.Enabled = True
		Me.picDerecha.Location = New System.Drawing.Point(168, 76)
		Me.picDerecha.Name = "picDerecha"
		Me.picDerecha.Size = New System.Drawing.Size(39, 41)
		Me.picDerecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picDerecha.TabIndex = 8
		Me.picDerecha.TabStop = True
		Me.picDerecha.Visible = True
		' 
		'picAbajo
		' 
		Me.picAbajo.BackColor = System.Drawing.SystemColors.Window
		Me.picAbajo.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picAbajo.CausesValidation = True
		Me.picAbajo.Cursor = System.Windows.Forms.Cursors.Default
		Me.picAbajo.Dock = System.Windows.Forms.DockStyle.None
		Me.picAbajo.Enabled = True
		Me.picAbajo.Location = New System.Drawing.Point(124, 76)
		Me.picAbajo.Name = "picAbajo"
		Me.picAbajo.Size = New System.Drawing.Size(43, 41)
		Me.picAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picAbajo.TabIndex = 7
		Me.picAbajo.TabStop = True
		Me.picAbajo.Visible = True
		' 
		'picIzq
		' 
		Me.picIzq.BackColor = System.Drawing.SystemColors.Window
		Me.picIzq.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picIzq.CausesValidation = True
		Me.picIzq.Cursor = System.Windows.Forms.Cursors.Default
		Me.picIzq.Dock = System.Windows.Forms.DockStyle.None
		Me.picIzq.Enabled = True
		Me.picIzq.Location = New System.Drawing.Point(82, 76)
		Me.picIzq.Name = "picIzq"
		Me.picIzq.Size = New System.Drawing.Size(41, 41)
		Me.picIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picIzq.TabIndex = 6
		Me.picIzq.TabStop = True
		Me.picIzq.Visible = True
		' 
		'picCursores
		' 
		Me.picCursores.BackColor = System.Drawing.SystemColors.Window
		Me.picCursores.BackgroundImage = CType(resources.GetObject("picCursores.BackgroundImage"), System.Drawing.Image)
		Me.picCursores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.picCursores.CausesValidation = True
		Me.picCursores.Controls.Add(Me.picArriba)
		Me.picCursores.Cursor = System.Windows.Forms.Cursors.Default
		Me.picCursores.Dock = System.Windows.Forms.DockStyle.None
		Me.picCursores.Enabled = True
		Me.picCursores.Location = New System.Drawing.Point(80, 30)
		Me.picCursores.Name = "picCursores"
		Me.picCursores.Size = New System.Drawing.Size(129, 88)
		Me.picCursores.TabIndex = 4
		Me.picCursores.TabStop = True
		Me.picCursores.Visible = True
		' 
		'picArriba
		' 
		Me.picArriba.BackColor = System.Drawing.SystemColors.Window
		Me.picArriba.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picArriba.CausesValidation = True
		Me.picArriba.Cursor = System.Windows.Forms.Cursors.Default
		Me.picArriba.Dock = System.Windows.Forms.DockStyle.None
		Me.picArriba.Enabled = True
		Me.picArriba.Location = New System.Drawing.Point(44, -2)
		Me.picArriba.Name = "picArriba"
		Me.picArriba.Size = New System.Drawing.Size(41, 45)
		Me.picArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.picArriba.TabIndex = 5
		Me.picArriba.TabStop = True
		Me.picArriba.Visible = True
		' 
		'_cmdCentro_1
		' 
		Me._cmdCentro_1.BackColor = System.Drawing.SystemColors.Control
		Me._cmdCentro_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCentro_1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me._cmdCentro_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCentro_1.Location = New System.Drawing.Point(108, 0)
		Me._cmdCentro_1.Name = "_cmdCentro_1"
		Me._cmdCentro_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCentro_1.Size = New System.Drawing.Size(87, 29)
		Me._cmdCentro_1.TabIndex = 3
		Me._cmdCentro_1.Text = "&Centro"
		Me._cmdCentro_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me._cmdCentro_1.UseVisualStyleBackColor = False
		' 
		'cmdActRaton
		' 
		Me.cmdActRaton.BackColor = System.Drawing.SystemColors.Control
		Me.cmdActRaton.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdActRaton.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.cmdActRaton.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdActRaton.Location = New System.Drawing.Point(0, 0)
		Me.cmdActRaton.Name = "cmdActRaton"
		Me.cmdActRaton.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdActRaton.Size = New System.Drawing.Size(87, 29)
		Me.cmdActRaton.TabIndex = 2
		Me.cmdActRaton.Text = "&Act. Ratón"
		Me.cmdActRaton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdActRaton.UseVisualStyleBackColor = False
		' 
		'tbCom
		' 
		Me.tbCom.AcceptsReturn = True
		Me.tbCom.BackColor = System.Drawing.SystemColors.Window
		Me.tbCom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.tbCom.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.tbCom.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.tbCom.ForeColor = System.Drawing.SystemColors.WindowText
		Me.tbCom.Location = New System.Drawing.Point(8, 126)
		Me.tbCom.MaxLength = 0
		Me.tbCom.Multiline = True
		Me.tbCom.Name = "tbCom"
		Me.tbCom.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.tbCom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.tbCom.Size = New System.Drawing.Size(289, 347)
		Me.tbCom.TabIndex = 1
		Me.tbCom.Text = "tbCom"
		' 
		'cmdConectar
		' 
		Me.cmdConectar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdConectar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdConectar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.cmdConectar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdConectar.Location = New System.Drawing.Point(216, 2)
		Me.cmdConectar.Name = "cmdConectar"
		Me.cmdConectar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdConectar.Size = New System.Drawing.Size(87, 29)
		Me.cmdConectar.TabIndex = 0
		Me.cmdConectar.Text = "Activar"
		Me.cmdConectar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdConectar.UseVisualStyleBackColor = False
		' 
		'com
		' 
		Me.com.Location = New System.Drawing.Point(254, 82)
		Me.com.Name = "com"
		Me.com.OcxState = CType(resources.GetObject("com.OcxState"), System.Windows.Forms.AxHost.State)
		' 
		'frmControlRaton
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(304, 481)
		Me.Controls.Add(Me.picDerecha)
		Me.Controls.Add(Me.picAbajo)
		Me.Controls.Add(Me.picIzq)
		Me.Controls.Add(Me.picCursores)
		Me.Controls.Add(Me._cmdCentro_1)
		Me.Controls.Add(Me.cmdActRaton)
		Me.Controls.Add(Me.tbCom)
		Me.Controls.Add(Me.cmdConectar)
        'Me.Controls.Add(Me.com)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
		Me.Location = New System.Drawing.Point(8, 26)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmControlRaton"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.Text = "Control Ratón"
		CType(Me.com, System.ComponentModel.ISupportInitialize).EndInit()
		Me.picCursores.ResumeLayout(False)
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		InitializecmdCentro()
		Form_Load()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.frmControlRaton_Closed
		End If
	End Sub
	Sub InitializecmdCentro()
		ReDim cmdCentro(1)
		Me.cmdCentro(1) = _cmdCentro_1
	End Sub
#End Region
End Class