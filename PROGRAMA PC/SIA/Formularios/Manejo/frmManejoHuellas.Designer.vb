<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManejoHuellas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManejoHuellas))
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.txtIdGrupo = New System.Windows.Forms.TextBox()
        Me.txtIdCurso = New System.Windows.Forms.TextBox()
        Me.tmrMostrarLectores = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbxHuella = New System.Windows.Forms.PictureBox()
        Me.gbxFiltros = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdbSinHuella = New System.Windows.Forms.RadioButton()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.rdbTodos = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.pbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pbxCargar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.gbxCargar = New System.Windows.Forms.GroupBox()
        Me.dgvAlumnos = New System.Windows.Forms.DataGridView()
        Me.Huella = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvAux = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIdLector = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMac = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreL = New System.Windows.Forms.TextBox()
        Me.tmrLectura = New System.Windows.Forms.Timer(Me.components)
        Me.lblEsperando = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxFiltros.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxCargar.SuspendLayout()
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAux, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.Color.LightCoral
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtResultado.Location = New System.Drawing.Point(188, 17)
        Me.txtResultado.MaxLength = 10
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(56, 20)
        Me.txtResultado.TabIndex = 129
        Me.txtResultado.Visible = False
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdGrupo.Location = New System.Drawing.Point(307, 17)
        Me.txtIdGrupo.MaxLength = 10
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.Size = New System.Drawing.Size(44, 20)
        Me.txtIdGrupo.TabIndex = 131
        Me.txtIdGrupo.Visible = False
        '
        'txtIdCurso
        '
        Me.txtIdCurso.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCurso.Location = New System.Drawing.Point(250, 17)
        Me.txtIdCurso.MaxLength = 10
        Me.txtIdCurso.Name = "txtIdCurso"
        Me.txtIdCurso.Size = New System.Drawing.Size(51, 20)
        Me.txtIdCurso.TabIndex = 130
        Me.txtIdCurso.Visible = False
        '
        'tmrMostrarLectores
        '
        Me.tmrMostrarLectores.Interval = 500
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox2.Controls.Add(Me.pbxHuella)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(721, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(220, 219)
        Me.GroupBox2.TabIndex = 127
        Me.GroupBox2.TabStop = False
        '
        'pbxHuella
        '
        Me.pbxHuella.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxHuella.BackColor = System.Drawing.Color.Transparent
        Me.pbxHuella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxHuella.Image = Global.SIA.My.Resources.Resources.IconoHuellaNo
        Me.pbxHuella.Location = New System.Drawing.Point(6, 15)
        Me.pbxHuella.Name = "pbxHuella"
        Me.pbxHuella.Size = New System.Drawing.Size(209, 196)
        Me.pbxHuella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxHuella.TabIndex = 117
        Me.pbxHuella.TabStop = False
        '
        'gbxFiltros
        '
        Me.gbxFiltros.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbxFiltros.BackColor = System.Drawing.Color.Transparent
        Me.gbxFiltros.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxFiltros.Controls.Add(Me.Label4)
        Me.gbxFiltros.Controls.Add(Me.rdbSinHuella)
        Me.gbxFiltros.Controls.Add(Me.cbxCurso)
        Me.gbxFiltros.Controls.Add(Me.cbxGrupo)
        Me.gbxFiltros.Controls.Add(Me.rdbTodos)
        Me.gbxFiltros.Controls.Add(Me.Label3)
        Me.gbxFiltros.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFiltros.ForeColor = System.Drawing.Color.White
        Me.gbxFiltros.Location = New System.Drawing.Point(221, 84)
        Me.gbxFiltros.Name = "gbxFiltros"
        Me.gbxFiltros.Size = New System.Drawing.Size(720, 74)
        Me.gbxFiltros.TabIndex = 117
        Me.gbxFiltros.TabStop = False
        Me.gbxFiltros.Text = " Filtros "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(4, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Curso"
        '
        'rdbSinHuella
        '
        Me.rdbSinHuella.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbSinHuella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.rdbSinHuella.FlatAppearance.BorderSize = 2
        Me.rdbSinHuella.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.rdbSinHuella.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.rdbSinHuella.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.rdbSinHuella.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbSinHuella.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdbSinHuella.Location = New System.Drawing.Point(343, 25)
        Me.rdbSinHuella.Name = "rdbSinHuella"
        Me.rdbSinHuella.Size = New System.Drawing.Size(180, 35)
        Me.rdbSinHuella.TabIndex = 126
        Me.rdbSinHuella.Text = "Alumnos Sin Huella"
        Me.rdbSinHuella.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbSinHuella.UseVisualStyleBackColor = True
        '
        'cbxCurso
        '
        Me.cbxCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCurso.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(6, 43)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(283, 24)
        Me.cbxCurso.TabIndex = 119
        '
        'cbxGrupo
        '
        Me.cbxGrupo.BackColor = System.Drawing.Color.Salmon
        Me.cbxGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGrupo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Location = New System.Drawing.Point(196, 10)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(93, 24)
        Me.cbxGrupo.TabIndex = 120
        Me.cbxGrupo.Text = "Todos"
        Me.cbxGrupo.Visible = False
        '
        'rdbTodos
        '
        Me.rdbTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.rdbTodos.FlatAppearance.BorderSize = 2
        Me.rdbTodos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.rdbTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.rdbTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.rdbTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbTodos.ForeColor = System.Drawing.Color.DarkOrange
        Me.rdbTodos.Location = New System.Drawing.Point(534, 25)
        Me.rdbTodos.Name = "rdbTodos"
        Me.rdbTodos.Size = New System.Drawing.Size(180, 35)
        Me.rdbTodos.TabIndex = 125
        Me.rdbTodos.Text = "Todos"
        Me.rdbTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbTodos.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(131, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 121
        Me.Label3.Text = "Grupo"
        Me.Label3.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox4.Controls.Add(Me.pbxEliminar)
        Me.GroupBox4.Controls.Add(Me.pbxCargar)
        Me.GroupBox4.Controls.Add(Me.pbxSalir)
        Me.GroupBox4.Controls.Add(Me.pbxCancelar)
        Me.GroupBox4.Controls.Add(Me.pbxGuardar)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(212, 591)
        Me.GroupBox4.TabIndex = 115
        Me.GroupBox4.TabStop = False
        '
        'pbxEliminar
        '
        Me.pbxEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbxEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxEliminar.Image = Global.SIA.My.Resources.Resources.btnEliminarNo
        Me.pbxEliminar.Location = New System.Drawing.Point(8, 137)
        Me.pbxEliminar.Name = "pbxEliminar"
        Me.pbxEliminar.Size = New System.Drawing.Size(196, 105)
        Me.pbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEliminar.TabIndex = 117
        Me.pbxEliminar.TabStop = False
        '
        'pbxCargar
        '
        Me.pbxCargar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxCargar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCargar.Image = Global.SIA.My.Resources.Resources.btnCargarHuellaNo
        Me.pbxCargar.Location = New System.Drawing.Point(8, 26)
        Me.pbxCargar.Name = "pbxCargar"
        Me.pbxCargar.Size = New System.Drawing.Size(196, 105)
        Me.pbxCargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCargar.TabIndex = 116
        Me.pbxCargar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(8, 470)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(196, 105)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 35
        Me.pbxSalir.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Image = Global.SIA.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.Location = New System.Drawing.Point(8, 248)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(196, 105)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 39
        Me.pbxCancelar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Image = Global.SIA.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.Location = New System.Drawing.Point(8, 359)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(196, 105)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 38
        Me.pbxGuardar.TabStop = False
        '
        'gbxCargar
        '
        Me.gbxCargar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxCargar.BackColor = System.Drawing.Color.Transparent
        Me.gbxCargar.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxCargar.Controls.Add(Me.dgvAlumnos)
        Me.gbxCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCargar.ForeColor = System.Drawing.Color.White
        Me.gbxCargar.Location = New System.Drawing.Point(221, 164)
        Me.gbxCargar.Name = "gbxCargar"
        Me.gbxCargar.Size = New System.Drawing.Size(494, 429)
        Me.gbxCargar.TabIndex = 36
        Me.gbxCargar.TabStop = False
        Me.gbxCargar.Text = " Seleccionar Alumno Para Asignar Huella "
        '
        'dgvAlumnos
        '
        Me.dgvAlumnos.AllowUserToAddRows = False
        Me.dgvAlumnos.AllowUserToDeleteRows = False
        Me.dgvAlumnos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvAlumnos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvAlumnos.ColumnHeadersHeight = 30
        Me.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAlumnos.ColumnHeadersVisible = False
        Me.dgvAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Huella})
        Me.dgvAlumnos.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlumnos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAlumnos.Location = New System.Drawing.Point(6, 25)
        Me.dgvAlumnos.MultiSelect = False
        Me.dgvAlumnos.Name = "dgvAlumnos"
        Me.dgvAlumnos.ReadOnly = True
        Me.dgvAlumnos.RowHeadersVisible = False
        Me.dgvAlumnos.RowHeadersWidth = 100
        Me.dgvAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlumnos.Size = New System.Drawing.Size(481, 395)
        Me.dgvAlumnos.TabIndex = 122
        '
        'Huella
        '
        Me.Huella.HeaderText = "Huella"
        Me.Huella.Name = "Huella"
        Me.Huella.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox3.Controls.Add(Me.dgvAux)
        Me.GroupBox3.Controls.Add(Me.txtIdLector)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtIdGrupo)
        Me.GroupBox3.Controls.Add(Me.txtIP)
        Me.GroupBox3.Controls.Add(Me.txtIdCurso)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtResultado)
        Me.GroupBox3.Controls.Add(Me.txtMac)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txtNombreL)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(221, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 75)
        Me.GroupBox3.TabIndex = 132
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = " Lector Seleccionado "
        '
        'dgvAux
        '
        Me.dgvAux.AllowUserToAddRows = False
        Me.dgvAux.AllowUserToDeleteRows = False
        Me.dgvAux.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvAux.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvAux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAux.BackgroundColor = System.Drawing.Color.LightCoral
        Me.dgvAux.ColumnHeadersHeight = 30
        Me.dgvAux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAux.ColumnHeadersVisible = False
        Me.dgvAux.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dgvAux.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAux.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvAux.Location = New System.Drawing.Point(422, 17)
        Me.dgvAux.MultiSelect = False
        Me.dgvAux.Name = "dgvAux"
        Me.dgvAux.ReadOnly = True
        Me.dgvAux.RowHeadersVisible = False
        Me.dgvAux.RowHeadersWidth = 100
        Me.dgvAux.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAux.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAux.Size = New System.Drawing.Size(101, 20)
        Me.dgvAux.TabIndex = 123
        Me.dgvAux.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Huella"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'txtIdLector
        '
        Me.txtIdLector.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdLector.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdLector.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdLector.Location = New System.Drawing.Point(126, 17)
        Me.txtIdLector.MaxLength = 10
        Me.txtIdLector.Name = "txtIdLector"
        Me.txtIdLector.Size = New System.Drawing.Size(56, 20)
        Me.txtIdLector.TabIndex = 132
        Me.txtIdLector.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label6.Location = New System.Drawing.Point(544, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 20)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "IP"
        '
        'txtIP
        '
        Me.txtIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIP.Enabled = False
        Me.txtIP.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIP.Location = New System.Drawing.Point(540, 43)
        Me.txtIP.MaxLength = 255
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(169, 26)
        Me.txtIP.TabIndex = 122
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(369, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "MAC"
        '
        'txtMac
        '
        Me.txtMac.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMac.Enabled = False
        Me.txtMac.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtMac.Location = New System.Drawing.Point(364, 43)
        Me.txtMac.MaxLength = 255
        Me.txtMac.Name = "txtMac"
        Me.txtMac.Size = New System.Drawing.Size(170, 26)
        Me.txtMac.TabIndex = 120
        Me.txtMac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(18, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "Nombre"
        '
        'txtNombreL
        '
        Me.txtNombreL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreL.Enabled = False
        Me.txtNombreL.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtNombreL.Location = New System.Drawing.Point(12, 43)
        Me.txtNombreL.MaxLength = 255
        Me.txtNombreL.Name = "txtNombreL"
        Me.txtNombreL.Size = New System.Drawing.Size(346, 26)
        Me.txtNombreL.TabIndex = 1
        '
        'tmrLectura
        '
        Me.tmrLectura.Interval = 5000
        '
        'lblEsperando
        '
        Me.lblEsperando.BackColor = System.Drawing.Color.Maroon
        Me.lblEsperando.Font = New System.Drawing.Font("Arial Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsperando.ForeColor = System.Drawing.Color.White
        Me.lblEsperando.Location = New System.Drawing.Point(718, 386)
        Me.lblEsperando.Name = "lblEsperando"
        Me.lblEsperando.Size = New System.Drawing.Size(223, 40)
        Me.lblEsperando.TabIndex = 133
        Me.lblEsperando.Text = "ESPERANDO HUELLA"
        Me.lblEsperando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEsperando.Visible = False
        '
        'frmManejoHuellas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(948, 596)
        Me.Controls.Add(Me.lblEsperando)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxFiltros)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbxCargar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManejoHuellas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbxHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxFiltros.ResumeLayout(False)
        Me.gbxFiltros.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxCargar.ResumeLayout(False)
        CType(Me.dgvAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvAux, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxCargar As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCargar As System.Windows.Forms.PictureBox
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cbxGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents dgvAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents rdbTodos As RadioButton
    Friend WithEvents rdbSinHuella As RadioButton
    Friend WithEvents gbxFiltros As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbxHuella As PictureBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents txtIdGrupo As TextBox
    Friend WithEvents txtIdCurso As TextBox
    Friend WithEvents tmrMostrarLectores As Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMac As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombreL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIdLector As System.Windows.Forms.TextBox
    Friend WithEvents pbxEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents Huella As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents dgvAux As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmrLectura As System.Windows.Forms.Timer
    Friend WithEvents lblEsperando As System.Windows.Forms.Label
End Class
