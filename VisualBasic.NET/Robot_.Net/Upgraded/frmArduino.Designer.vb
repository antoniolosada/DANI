<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArduino
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As frmArduino
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As frmArduino
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = CreateInstance()
				m_InitializingDefInstance = False
			End If
			Return m_vb6FormDefInstance
		End Get
		Set(ByVal Value As frmArduino)
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region
#Region "Windows Form Designer generated code "
	Public Shared Function CreateInstance() As frmArduino
		Dim theInstance As frmArduino = New frmArduino()
		theInstance.Form_Load()
		Return theInstance
	End Function
	Private visualControls() As String = New String() {"components", "ToolTipMain", "cmdCerrar", "tbCodigo"}
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTipMain As System.Windows.Forms.ToolTip
	Public WithEvents cmdCerrar As System.Windows.Forms.Button
	Public WithEvents tbCodigo As System.Windows.Forms.TextBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	 Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArduino))
		Me.ToolTipMain = New System.Windows.Forms.ToolTip(Me.components)
		Me.cmdCerrar = New System.Windows.Forms.Button()
		Me.tbCodigo = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		' 
		'cmdCerrar
		' 
		Me.cmdCerrar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdCerrar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCerrar.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.cmdCerrar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdCerrar.Location = New System.Drawing.Point(152, 306)
		Me.cmdCerrar.Name = "cmdCerrar"
		Me.cmdCerrar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCerrar.Size = New System.Drawing.Size(223, 29)
		Me.cmdCerrar.TabIndex = 1
		Me.cmdCerrar.Text = "Cerrar"
		Me.cmdCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.cmdCerrar.UseVisualStyleBackColor = False
		' 
		'tbCodigo
		' 
		Me.tbCodigo.AcceptsReturn = True
		Me.tbCodigo.BackColor = System.Drawing.SystemColors.Window
		Me.tbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.tbCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.tbCodigo.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0)
		Me.tbCodigo.ForeColor = System.Drawing.SystemColors.WindowText
		Me.tbCodigo.Location = New System.Drawing.Point(4, 6)
		Me.tbCodigo.MaxLength = 0
		Me.tbCodigo.Multiline = True
		Me.tbCodigo.Name = "tbCodigo"
		Me.tbCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.tbCodigo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.tbCodigo.Size = New System.Drawing.Size(525, 291)
		Me.tbCodigo.TabIndex = 0
		Me.tbCodigo.Text = "tbCodigo"
		' 
		'frmArduino
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6, 13)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(533, 341)
		Me.ControlBox = False
		Me.Controls.Add(Me.cmdCerrar)
		Me.Controls.Add(Me.tbCodigo)
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Location = New System.Drawing.Point(3, 23)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmArduino"
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = False
		Me.Text = "||frmCodigoArduino"
		Me.ResumeLayout(False)
	End Sub
	Sub ReLoadForm(ByVal addEvents As Boolean)
		Form_Load()
		If addEvents Then
			AddHandler MyBase.Closed, AddressOf Me.frmArduino_Closed
		End If
	End Sub
#End Region
End Class