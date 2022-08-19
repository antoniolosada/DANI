<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vista3D
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.tbControl = New System.Windows.Forms.TextBox()
        Me.lblMAY = New System.Windows.Forms.Label()
        Me.picVideoD = New System.Windows.Forms.PictureBox()
        Me.picVideoI = New System.Windows.Forms.PictureBox()
        Me.cmdVerRecorte = New System.Windows.Forms.Button()
        Me.chkDiferido = New System.Windows.Forms.CheckBox()
        Me.chkRecorteD = New System.Windows.Forms.CheckBox()
        Me.chkRecorteI = New System.Windows.Forms.CheckBox()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.cmdFinI = New System.Windows.Forms.Button()
        Me.cmdIniciarI = New System.Windows.Forms.Button()
        Me.cbDispositivos3DI = New System.Windows.Forms.ComboBox()
        Me.cmdOcultar = New System.Windows.Forms.Button()
        Me.cmdFinD = New System.Windows.Forms.Button()
        Me.cmdIniciarD = New System.Windows.Forms.Button()
        Me.cbDispositivos3DD = New System.Windows.Forms.ComboBox()
        Me.tmrControl = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRecorte = New System.Windows.Forms.Timer(Me.components)
        Me.tmrDiferido = New System.Windows.Forms.Timer(Me.components)
        Me.cbTiempo = New System.Windows.Forms.ComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.picVideoD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVideoI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbTiempo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdVerRecorte)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkDiferido)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkRecorteD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkRecorteI)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdCerrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdFinI)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdIniciarI)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbDispositivos3DI)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdOcultar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdFinD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdIniciarD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbDispositivos3DD)
        Me.SplitContainer1.Size = New System.Drawing.Size(1228, 739)
        Me.SplitContainer1.SplitterDistance = 710
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.tbControl)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblMAY)
        Me.SplitContainer2.Panel1.Controls.Add(Me.picVideoD)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.picVideoI)
        Me.SplitContainer2.Size = New System.Drawing.Size(1228, 710)
        Me.SplitContainer2.SplitterDistance = 610
        Me.SplitContainer2.TabIndex = 0
        '
        'tbControl
        '
        Me.tbControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbControl.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbControl.Location = New System.Drawing.Point(25, -1)
        Me.tbControl.Name = "tbControl"
        Me.tbControl.Size = New System.Drawing.Size(13, 20)
        Me.tbControl.TabIndex = 206
        '
        'lblMAY
        '
        Me.lblMAY.AutoSize = True
        Me.lblMAY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblMAY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMAY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAY.Location = New System.Drawing.Point(0, 0)
        Me.lblMAY.Name = "lblMAY"
        Me.lblMAY.Size = New System.Drawing.Size(19, 16)
        Me.lblMAY.TabIndex = 207
        Me.lblMAY.Text = "M"
        '
        'picVideoD
        '
        Me.picVideoD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picVideoD.Location = New System.Drawing.Point(0, 0)
        Me.picVideoD.Name = "picVideoD"
        Me.picVideoD.Size = New System.Drawing.Size(610, 710)
        Me.picVideoD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVideoD.TabIndex = 0
        Me.picVideoD.TabStop = False
        '
        'picVideoI
        '
        Me.picVideoI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picVideoI.Location = New System.Drawing.Point(0, 0)
        Me.picVideoI.Name = "picVideoI"
        Me.picVideoI.Size = New System.Drawing.Size(614, 710)
        Me.picVideoI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVideoI.TabIndex = 0
        Me.picVideoI.TabStop = False
        '
        'cmdVerRecorte
        '
        Me.cmdVerRecorte.Location = New System.Drawing.Point(1080, 3)
        Me.cmdVerRecorte.Name = "cmdVerRecorte"
        Me.cmdVerRecorte.Size = New System.Drawing.Size(34, 23)
        Me.cmdVerRecorte.TabIndex = 11
        Me.cmdVerRecorte.Text = "Ver"
        Me.cmdVerRecorte.UseVisualStyleBackColor = True
        '
        'chkDiferido
        '
        Me.chkDiferido.AutoSize = True
        Me.chkDiferido.Location = New System.Drawing.Point(793, 6)
        Me.chkDiferido.Name = "chkDiferido"
        Me.chkDiferido.Size = New System.Drawing.Size(62, 17)
        Me.chkDiferido.TabIndex = 10
        Me.chkDiferido.Text = "Diferido"
        Me.chkDiferido.UseVisualStyleBackColor = True
        '
        'chkRecorteD
        '
        Me.chkRecorteD.AutoSize = True
        Me.chkRecorteD.Location = New System.Drawing.Point(979, 6)
        Me.chkRecorteD.Name = "chkRecorteD"
        Me.chkRecorteD.Size = New System.Drawing.Size(81, 17)
        Me.chkRecorteD.TabIndex = 9
        Me.chkRecorteD.Text = "RecorteDer"
        Me.chkRecorteD.UseVisualStyleBackColor = True
        '
        'chkRecorteI
        '
        Me.chkRecorteI.AutoSize = True
        Me.chkRecorteI.Location = New System.Drawing.Point(895, 5)
        Me.chkRecorteI.Name = "chkRecorteI"
        Me.chkRecorteI.Size = New System.Drawing.Size(78, 17)
        Me.chkRecorteI.TabIndex = 8
        Me.chkRecorteI.Text = "RecorteIzq"
        Me.chkRecorteI.UseVisualStyleBackColor = True
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(1115, 3)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(48, 23)
        Me.cmdCerrar.TabIndex = 7
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'cmdFinI
        '
        Me.cmdFinI.Location = New System.Drawing.Point(705, 2)
        Me.cmdFinI.Name = "cmdFinI"
        Me.cmdFinI.Size = New System.Drawing.Size(49, 23)
        Me.cmdFinI.TabIndex = 6
        Me.cmdFinI.Text = "Parar"
        Me.cmdFinI.UseVisualStyleBackColor = True
        '
        'cmdIniciarI
        '
        Me.cmdIniciarI.Location = New System.Drawing.Point(650, 2)
        Me.cmdIniciarI.Name = "cmdIniciarI"
        Me.cmdIniciarI.Size = New System.Drawing.Size(49, 23)
        Me.cmdIniciarI.TabIndex = 5
        Me.cmdIniciarI.Text = "Iniciar"
        Me.cmdIniciarI.UseVisualStyleBackColor = True
        '
        'cbDispositivos3DI
        '
        Me.cbDispositivos3DI.FormattingEnabled = True
        Me.cbDispositivos3DI.Location = New System.Drawing.Point(378, 3)
        Me.cbDispositivos3DI.Name = "cbDispositivos3DI"
        Me.cbDispositivos3DI.Size = New System.Drawing.Size(266, 21)
        Me.cbDispositivos3DI.TabIndex = 4
        '
        'cmdOcultar
        '
        Me.cmdOcultar.Location = New System.Drawing.Point(1169, 2)
        Me.cmdOcultar.Name = "cmdOcultar"
        Me.cmdOcultar.Size = New System.Drawing.Size(56, 23)
        Me.cmdOcultar.TabIndex = 3
        Me.cmdOcultar.Text = "Ocultar"
        Me.cmdOcultar.UseVisualStyleBackColor = True
        '
        'cmdFinD
        '
        Me.cmdFinD.Location = New System.Drawing.Point(327, 2)
        Me.cmdFinD.Name = "cmdFinD"
        Me.cmdFinD.Size = New System.Drawing.Size(45, 23)
        Me.cmdFinD.TabIndex = 2
        Me.cmdFinD.Text = "Parar"
        Me.cmdFinD.UseVisualStyleBackColor = True
        '
        'cmdIniciarD
        '
        Me.cmdIniciarD.Location = New System.Drawing.Point(272, 2)
        Me.cmdIniciarD.Name = "cmdIniciarD"
        Me.cmdIniciarD.Size = New System.Drawing.Size(49, 23)
        Me.cmdIniciarD.TabIndex = 1
        Me.cmdIniciarD.Text = "Iniciar"
        Me.cmdIniciarD.UseVisualStyleBackColor = True
        '
        'cbDispositivos3DD
        '
        Me.cbDispositivos3DD.FormattingEnabled = True
        Me.cbDispositivos3DD.Location = New System.Drawing.Point(0, 2)
        Me.cbDispositivos3DD.Name = "cbDispositivos3DD"
        Me.cbDispositivos3DD.Size = New System.Drawing.Size(266, 21)
        Me.cbDispositivos3DD.TabIndex = 0
        '
        'tmrControl
        '
        Me.tmrControl.Enabled = True
        '
        'tmrRecorte
        '
        '
        'tmrDiferido
        '
        Me.tmrDiferido.Interval = 300
        '
        'cbTiempo
        '
        Me.cbTiempo.FormattingEnabled = True
        Me.cbTiempo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbTiempo.Location = New System.Drawing.Point(851, 1)
        Me.cbTiempo.Name = "cbTiempo"
        Me.cbTiempo.Size = New System.Drawing.Size(38, 21)
        Me.cbTiempo.TabIndex = 12
        '
        'Vista3D
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1228, 739)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vista3D"
        Me.Text = "Vista3D"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.picVideoD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVideoI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents picVideoD As System.Windows.Forms.PictureBox
    Friend WithEvents picVideoI As System.Windows.Forms.PictureBox
    Friend WithEvents cmdOcultar As System.Windows.Forms.Button
    Friend WithEvents cmdFinD As System.Windows.Forms.Button
    Friend WithEvents cmdIniciarD As System.Windows.Forms.Button
    Friend WithEvents cbDispositivos3DD As System.Windows.Forms.ComboBox
    Friend WithEvents cmdFinI As System.Windows.Forms.Button
    Friend WithEvents cmdIniciarI As System.Windows.Forms.Button
    Friend WithEvents cbDispositivos3DI As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCerrar As System.Windows.Forms.Button
    Friend WithEvents tmrControl As System.Windows.Forms.Timer
    Friend WithEvents lblMAY As System.Windows.Forms.Label
    Friend WithEvents tbControl As System.Windows.Forms.TextBox
    Friend WithEvents chkRecorteI As System.Windows.Forms.CheckBox
    Friend WithEvents tmrRecorte As System.Windows.Forms.Timer
    Friend WithEvents chkRecorteD As System.Windows.Forms.CheckBox
    Friend WithEvents tmrDiferido As System.Windows.Forms.Timer
    Friend WithEvents chkDiferido As System.Windows.Forms.CheckBox
    Friend WithEvents cmdVerRecorte As System.Windows.Forms.Button
    Friend WithEvents cbTiempo As ComboBox
End Class
