<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltasGrupo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltasGrupo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.gbxGrupos = New System.Windows.Forms.GroupBox()
        Me.txtIdCurso = New System.Windows.Forms.TextBox()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.dgvGrupos = New System.Windows.Forms.DataGridView()
        Me.pbxEliminar = New System.Windows.Forms.PictureBox()
        Me.gbxPPal = New System.Windows.Forms.GroupBox()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxElim = New System.Windows.Forms.GroupBox()
        Me.tmrElim = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxGrupos.SuspendLayout()
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPPal.SuspendLayout()
        Me.gbxElim.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Controls.Add(Me.pbxModificar)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 575)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'pbxNuevo
        '
        Me.pbxNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevo.Image = Global.SIA.My.Resources.Resources.btnNuevoNo
        Me.pbxNuevo.Location = New System.Drawing.Point(9, 17)
        Me.pbxNuevo.Name = "pbxNuevo"
        Me.pbxNuevo.Size = New System.Drawing.Size(196, 105)
        Me.pbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevo.TabIndex = 12
        Me.pbxNuevo.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Image = Global.SIA.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.Location = New System.Drawing.Point(9, 350)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(196, 105)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 15
        Me.pbxCancelar.TabStop = False
        '
        'pbxModificar
        '
        Me.pbxModificar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxModificar.BackColor = System.Drawing.Color.Transparent
        Me.pbxModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxModificar.Image = Global.SIA.My.Resources.Resources.btnModificarNo
        Me.pbxModificar.Location = New System.Drawing.Point(9, 128)
        Me.pbxModificar.Name = "pbxModificar"
        Me.pbxModificar.Size = New System.Drawing.Size(196, 105)
        Me.pbxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxModificar.TabIndex = 13
        Me.pbxModificar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Image = Global.SIA.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.Location = New System.Drawing.Point(9, 239)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(196, 105)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 14
        Me.pbxGuardar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(9, 461)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(196, 105)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 16
        Me.pbxSalir.TabStop = False
        '
        'gbxGrupos
        '
        Me.gbxGrupos.BackColor = System.Drawing.Color.Transparent
        Me.gbxGrupos.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxGrupos.Controls.Add(Me.dgvGrupos)
        Me.gbxGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxGrupos.ForeColor = System.Drawing.Color.White
        Me.gbxGrupos.Location = New System.Drawing.Point(232, 251)
        Me.gbxGrupos.Name = "gbxGrupos"
        Me.gbxGrupos.Size = New System.Drawing.Size(844, 336)
        Me.gbxGrupos.TabIndex = 20
        Me.gbxGrupos.TabStop = False
        Me.gbxGrupos.Text = "  Grupos  Existentes  "
        '
        'txtIdCurso
        '
        Me.txtIdCurso.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCurso.Location = New System.Drawing.Point(6, 71)
        Me.txtIdCurso.MaxLength = 10
        Me.txtIdCurso.Name = "txtIdCurso"
        Me.txtIdCurso.Size = New System.Drawing.Size(99, 20)
        Me.txtIdCurso.TabIndex = 31
        Me.txtIdCurso.Visible = False
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.LightCoral
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigen.Location = New System.Drawing.Point(6, 97)
        Me.txtOrigen.MaxLength = 10
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(99, 20)
        Me.txtOrigen.TabIndex = 25
        Me.txtOrigen.Visible = False
        '
        'dgvGrupos
        '
        Me.dgvGrupos.AllowUserToAddRows = False
        Me.dgvGrupos.AllowUserToDeleteRows = False
        Me.dgvGrupos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvGrupos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGrupos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvGrupos.ColumnHeadersHeight = 30
        Me.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvGrupos.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvGrupos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvGrupos.Location = New System.Drawing.Point(9, 25)
        Me.dgvGrupos.MultiSelect = False
        Me.dgvGrupos.Name = "dgvGrupos"
        Me.dgvGrupos.ReadOnly = True
        Me.dgvGrupos.RowHeadersVisible = False
        Me.dgvGrupos.RowHeadersWidth = 100
        Me.dgvGrupos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrupos.Size = New System.Drawing.Size(826, 302)
        Me.dgvGrupos.TabIndex = 9
        '
        'pbxEliminar
        '
        Me.pbxEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbxEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxEliminar.Enabled = False
        Me.pbxEliminar.Image = Global.SIA.My.Resources.Resources.btnEliminarNo
        Me.pbxEliminar.Location = New System.Drawing.Point(676, 19)
        Me.pbxEliminar.Name = "pbxEliminar"
        Me.pbxEliminar.Size = New System.Drawing.Size(143, 67)
        Me.pbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEliminar.TabIndex = 17
        Me.pbxEliminar.TabStop = False
        '
        'gbxPPal
        '
        Me.gbxPPal.BackColor = System.Drawing.Color.Transparent
        Me.gbxPPal.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxPPal.Controls.Add(Me.txtIdCurso)
        Me.gbxPPal.Controls.Add(Me.txtOrigen)
        Me.gbxPPal.Controls.Add(Me.cbxCurso)
        Me.gbxPPal.Controls.Add(Me.Label1)
        Me.gbxPPal.Controls.Add(Me.txtGrupo)
        Me.gbxPPal.Controls.Add(Me.Label2)
        Me.gbxPPal.Enabled = False
        Me.gbxPPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPPal.ForeColor = System.Drawing.Color.White
        Me.gbxPPal.Location = New System.Drawing.Point(232, 12)
        Me.gbxPPal.Name = "gbxPPal"
        Me.gbxPPal.Size = New System.Drawing.Size(844, 130)
        Me.gbxPPal.TabIndex = 19
        Me.gbxPPal.TabStop = False
        '
        'cbxCurso
        '
        Me.cbxCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCurso.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(295, 81)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(524, 28)
        Me.cbxCurso.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(20, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Ingrese Nombre Grupo------------:"
        '
        'txtGrupo
        '
        Me.txtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtGrupo.Location = New System.Drawing.Point(295, 28)
        Me.txtGrupo.MaxLength = 100
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(524, 26)
        Me.txtGrupo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(20, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Asigne Curso Al Grupo------------:"
        '
        'gbxElim
        '
        Me.gbxElim.BackColor = System.Drawing.Color.Transparent
        Me.gbxElim.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxElim.Controls.Add(Me.pbxEliminar)
        Me.gbxElim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxElim.ForeColor = System.Drawing.Color.White
        Me.gbxElim.Location = New System.Drawing.Point(232, 148)
        Me.gbxElim.Name = "gbxElim"
        Me.gbxElim.Size = New System.Drawing.Size(844, 97)
        Me.gbxElim.TabIndex = 23
        Me.gbxElim.TabStop = False
        '
        'tmrElim
        '
        Me.tmrElim.Enabled = True
        '
        'frmAltasGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 596)
        Me.Controls.Add(Me.gbxElim)
        Me.Controls.Add(Me.gbxGrupos)
        Me.Controls.Add(Me.gbxPPal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAltasGrupo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAltasGrupo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxGrupos.ResumeLayout(False)
        CType(Me.dgvGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPPal.ResumeLayout(False)
        Me.gbxPPal.PerformLayout()
        Me.gbxElim.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxModificar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents gbxGrupos As System.Windows.Forms.GroupBox
    Friend WithEvents dgvGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents gbxPPal As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents txtIdCurso As System.Windows.Forms.TextBox
    Friend WithEvents pbxEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents gbxElim As System.Windows.Forms.GroupBox
    Friend WithEvents tmrElim As Timer
End Class
