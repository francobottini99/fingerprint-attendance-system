<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoSIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngresoSIA))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCiclo = New System.Windows.Forms.TextBox()
        Me.txtCicloID = New System.Windows.Forms.TextBox()
        Me.chbCiclo = New System.Windows.Forms.CheckBox()
        Me.lblCilco = New System.Windows.Forms.Label()
        Me.cbxCiclo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdUs = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.cbxUsuario = New System.Windows.Forms.ComboBox()
        Me.pbxIngresar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxIngresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox2.Controls.Add(Me.txtCiclo)
        Me.GroupBox2.Controls.Add(Me.txtCicloID)
        Me.GroupBox2.Controls.Add(Me.chbCiclo)
        Me.GroupBox2.Controls.Add(Me.lblCilco)
        Me.GroupBox2.Controls.Add(Me.cbxCiclo)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCategoria)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtIdUs)
        Me.GroupBox2.Controls.Add(Me.txtClave)
        Me.GroupBox2.Controls.Add(Me.cbxUsuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 144)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        '
        'txtCiclo
        '
        Me.txtCiclo.BackColor = System.Drawing.Color.LightCoral
        Me.txtCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCiclo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCiclo.Location = New System.Drawing.Point(329, 0)
        Me.txtCiclo.MaxLength = 10
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.Size = New System.Drawing.Size(99, 20)
        Me.txtCiclo.TabIndex = 55
        Me.txtCiclo.Visible = False
        '
        'txtCicloID
        '
        Me.txtCicloID.BackColor = System.Drawing.Color.LightCoral
        Me.txtCicloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCicloID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCicloID.Location = New System.Drawing.Point(259, 0)
        Me.txtCicloID.MaxLength = 10
        Me.txtCicloID.Name = "txtCicloID"
        Me.txtCicloID.Size = New System.Drawing.Size(64, 20)
        Me.txtCicloID.TabIndex = 54
        Me.txtCicloID.Visible = False
        '
        'chbCiclo
        '
        Me.chbCiclo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCiclo.Location = New System.Drawing.Point(7, 98)
        Me.chbCiclo.Name = "chbCiclo"
        Me.chbCiclo.Size = New System.Drawing.Size(289, 28)
        Me.chbCiclo.TabIndex = 54
        Me.chbCiclo.Text = "Cambiar Ciclo Lectivo ------------------->"
        Me.chbCiclo.UseVisualStyleBackColor = True
        '
        'lblCilco
        '
        Me.lblCilco.Enabled = False
        Me.lblCilco.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCilco.Location = New System.Drawing.Point(302, 75)
        Me.lblCilco.Name = "lblCilco"
        Me.lblCilco.Size = New System.Drawing.Size(190, 20)
        Me.lblCilco.TabIndex = 53
        Me.lblCilco.Text = "Ciclo Lectivo"
        Me.lblCilco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxCiclo
        '
        Me.cbxCiclo.Enabled = False
        Me.cbxCiclo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxCiclo.FormattingEnabled = True
        Me.cbxCiclo.Location = New System.Drawing.Point(302, 98)
        Me.cbxCiclo.Name = "cbxCiclo"
        Me.cbxCiclo.Size = New System.Drawing.Size(190, 28)
        Me.cbxCiclo.TabIndex = 52
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCategoria
        '
        Me.txtCategoria.BackColor = System.Drawing.Color.LightCoral
        Me.txtCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCategoria.Location = New System.Drawing.Point(174, 0)
        Me.txtCategoria.MaxLength = 10
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(79, 20)
        Me.txtCategoria.TabIndex = 51
        Me.txtCategoria.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.LightCoral
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombre.Location = New System.Drawing.Point(97, 0)
        Me.txtNombre.MaxLength = 10
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(71, 20)
        Me.txtNombre.TabIndex = 50
        Me.txtNombre.Visible = False
        '
        'txtIdUs
        '
        Me.txtIdUs.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdUs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdUs.Location = New System.Drawing.Point(6, 0)
        Me.txtIdUs.MaxLength = 10
        Me.txtIdUs.Name = "txtIdUs"
        Me.txtIdUs.Size = New System.Drawing.Size(85, 20)
        Me.txtIdUs.TabIndex = 49
        Me.txtIdUs.Visible = False
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtClave.Location = New System.Drawing.Point(302, 40)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(190, 29)
        Me.txtClave.TabIndex = 1
        '
        'cbxUsuario
        '
        Me.cbxUsuario.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxUsuario.FormattingEnabled = True
        Me.cbxUsuario.Location = New System.Drawing.Point(7, 40)
        Me.cbxUsuario.Name = "cbxUsuario"
        Me.cbxUsuario.Size = New System.Drawing.Size(289, 28)
        Me.cbxUsuario.TabIndex = 0
        '
        'pbxIngresar
        '
        Me.pbxIngresar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxIngresar.BackColor = System.Drawing.Color.Transparent
        Me.pbxIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxIngresar.Image = Global.SIA.My.Resources.Resources.btnIngresarNo
        Me.pbxIngresar.Location = New System.Drawing.Point(222, 153)
        Me.pbxIngresar.Name = "pbxIngresar"
        Me.pbxIngresar.Size = New System.Drawing.Size(134, 66)
        Me.pbxIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxIngresar.TabIndex = 47
        Me.pbxIngresar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(369, 153)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(134, 66)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 48
        Me.pbxSalir.TabStop = False
        '
        'frmIngresoSIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(508, 222)
        Me.Controls.Add(Me.pbxIngresar)
        Me.Controls.Add(Me.pbxSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmIngresoSIA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IngresoSIA"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbxIngresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents cbxUsuario As ComboBox
    Friend WithEvents pbxIngresar As PictureBox
    Friend WithEvents pbxSalir As PictureBox
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtIdUs As System.Windows.Forms.TextBox
    Friend WithEvents lblCilco As Label
    Friend WithEvents cbxCiclo As ComboBox
    Friend WithEvents txtCicloID As TextBox
    Friend WithEvents chbCiclo As CheckBox
    Friend WithEvents txtCiclo As TextBox
End Class
