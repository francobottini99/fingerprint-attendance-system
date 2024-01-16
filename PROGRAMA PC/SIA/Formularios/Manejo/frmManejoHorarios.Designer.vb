<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManejoHorarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManejoHorarios))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxHorarios = New System.Windows.Forms.GroupBox()
        Me.pbxEliminar = New System.Windows.Forms.PictureBox()
        Me.dgvHorarios = New System.Windows.Forms.DataGridView()
        Me.gbxPPal = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rdbTarde = New System.Windows.Forms.RadioButton()
        Me.rdbMañana = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdbPermanente = New System.Windows.Forms.RadioButton()
        Me.rdbTemporal = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chbViernes = New System.Windows.Forms.CheckBox()
        Me.chbJueves = New System.Windows.Forms.CheckBox()
        Me.chbLunes = New System.Windows.Forms.CheckBox()
        Me.chbMiercoles = New System.Windows.Forms.CheckBox()
        Me.chbMartes = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtIdGrupo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.cbxGrupo = New System.Windows.Forms.ComboBox()
        Me.txtIdCurso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.lblClases = New System.Windows.Forms.Label()
        Me.lblSiNo = New System.Windows.Forms.Label()
        Me.gbxIngreso = New System.Windows.Forms.GroupBox()
        Me.dtpIngreso = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxModificar = New System.Windows.Forms.PictureBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.gbxHorarios.SuspendLayout()
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPPal.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbxIngreso.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxHorarios
        '
        Me.gbxHorarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxHorarios.BackColor = System.Drawing.Color.Transparent
        Me.gbxHorarios.BackgroundImage = CType(resources.GetObject("gbxHorarios.BackgroundImage"), System.Drawing.Image)
        Me.gbxHorarios.Controls.Add(Me.pbxEliminar)
        Me.gbxHorarios.Controls.Add(Me.dgvHorarios)
        Me.gbxHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxHorarios.ForeColor = System.Drawing.Color.White
        Me.gbxHorarios.Location = New System.Drawing.Point(684, 6)
        Me.gbxHorarios.Name = "gbxHorarios"
        Me.gbxHorarios.Size = New System.Drawing.Size(390, 642)
        Me.gbxHorarios.TabIndex = 19
        Me.gbxHorarios.TabStop = False
        Me.gbxHorarios.Text = "  Horarios  "
        '
        'pbxEliminar
        '
        Me.pbxEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbxEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxEliminar.Image = CType(resources.GetObject("pbxEliminar.Image"), System.Drawing.Image)
        Me.pbxEliminar.Location = New System.Drawing.Point(272, 580)
        Me.pbxEliminar.Name = "pbxEliminar"
        Me.pbxEliminar.Size = New System.Drawing.Size(112, 53)
        Me.pbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEliminar.TabIndex = 14
        Me.pbxEliminar.TabStop = False
        '
        'dgvHorarios
        '
        Me.dgvHorarios.AllowUserToAddRows = False
        Me.dgvHorarios.AllowUserToDeleteRows = False
        Me.dgvHorarios.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvHorarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHorarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvHorarios.ColumnHeadersHeight = 30
        Me.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHorarios.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHorarios.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvHorarios.Location = New System.Drawing.Point(8, 25)
        Me.dgvHorarios.MultiSelect = False
        Me.dgvHorarios.Name = "dgvHorarios"
        Me.dgvHorarios.ReadOnly = True
        Me.dgvHorarios.RowHeadersVisible = False
        Me.dgvHorarios.RowHeadersWidth = 100
        Me.dgvHorarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHorarios.Size = New System.Drawing.Size(374, 549)
        Me.dgvHorarios.TabIndex = 9
        '
        'gbxPPal
        '
        Me.gbxPPal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPPal.BackColor = System.Drawing.Color.Transparent
        Me.gbxPPal.BackgroundImage = CType(resources.GetObject("gbxPPal.BackgroundImage"), System.Drawing.Image)
        Me.gbxPPal.Controls.Add(Me.Label1)
        Me.gbxPPal.Controls.Add(Me.GroupBox7)
        Me.gbxPPal.Controls.Add(Me.GroupBox5)
        Me.gbxPPal.Controls.Add(Me.GroupBox4)
        Me.gbxPPal.Controls.Add(Me.GroupBox2)
        Me.gbxPPal.Controls.Add(Me.lblClases)
        Me.gbxPPal.Controls.Add(Me.lblSiNo)
        Me.gbxPPal.Controls.Add(Me.gbxIngreso)
        Me.gbxPPal.Enabled = False
        Me.gbxPPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPPal.ForeColor = System.Drawing.Color.White
        Me.gbxPPal.Location = New System.Drawing.Point(225, 6)
        Me.gbxPPal.Name = "gbxPPal"
        Me.gbxPPal.Size = New System.Drawing.Size(453, 642)
        Me.gbxPPal.TabIndex = 18
        Me.gbxPPal.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 603)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 23)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "- - - - - - - - - - - - - - - - >"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.rdbTarde)
        Me.GroupBox7.Controls.Add(Me.rdbMañana)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.White
        Me.GroupBox7.Location = New System.Drawing.Point(8, 298)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(432, 82)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = " Seleccione Turno "
        '
        'rdbTarde
        '
        Me.rdbTarde.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbTarde.BackColor = System.Drawing.Color.Gainsboro
        Me.rdbTarde.FlatAppearance.BorderSize = 3
        Me.rdbTarde.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rdbTarde.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbTarde.ForeColor = System.Drawing.Color.DarkRed
        Me.rdbTarde.Location = New System.Drawing.Point(226, 26)
        Me.rdbTarde.Name = "rdbTarde"
        Me.rdbTarde.Size = New System.Drawing.Size(200, 38)
        Me.rdbTarde.TabIndex = 50
        Me.rdbTarde.Text = "Tarde"
        Me.rdbTarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbTarde.UseVisualStyleBackColor = False
        '
        'rdbMañana
        '
        Me.rdbMañana.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbMañana.BackColor = System.Drawing.Color.Gainsboro
        Me.rdbMañana.FlatAppearance.BorderSize = 3
        Me.rdbMañana.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rdbMañana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbMañana.ForeColor = System.Drawing.Color.DarkRed
        Me.rdbMañana.Location = New System.Drawing.Point(10, 26)
        Me.rdbMañana.Name = "rdbMañana"
        Me.rdbMañana.Size = New System.Drawing.Size(197, 38)
        Me.rdbMañana.TabIndex = 51
        Me.rdbMañana.Text = "Mañana"
        Me.rdbMañana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbMañana.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.rdbPermanente)
        Me.GroupBox5.Controls.Add(Me.rdbTemporal)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(8, 122)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(432, 82)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "  Seleccione Tipo de Registro "
        '
        'rdbPermanente
        '
        Me.rdbPermanente.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbPermanente.BackColor = System.Drawing.Color.Gainsboro
        Me.rdbPermanente.FlatAppearance.BorderSize = 3
        Me.rdbPermanente.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rdbPermanente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbPermanente.ForeColor = System.Drawing.Color.DarkRed
        Me.rdbPermanente.Location = New System.Drawing.Point(16, 29)
        Me.rdbPermanente.Name = "rdbPermanente"
        Me.rdbPermanente.Size = New System.Drawing.Size(197, 38)
        Me.rdbPermanente.TabIndex = 51
        Me.rdbPermanente.Text = "Permanente"
        Me.rdbPermanente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbPermanente.UseVisualStyleBackColor = False
        '
        'rdbTemporal
        '
        Me.rdbTemporal.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdbTemporal.BackColor = System.Drawing.Color.Gainsboro
        Me.rdbTemporal.FlatAppearance.BorderSize = 3
        Me.rdbTemporal.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.rdbTemporal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdbTemporal.ForeColor = System.Drawing.Color.DarkRed
        Me.rdbTemporal.Location = New System.Drawing.Point(226, 29)
        Me.rdbTemporal.Name = "rdbTemporal"
        Me.rdbTemporal.Size = New System.Drawing.Size(197, 38)
        Me.rdbTemporal.TabIndex = 50
        Me.rdbTemporal.Text = "Temporal"
        Me.rdbTemporal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdbTemporal.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.chbViernes)
        Me.GroupBox4.Controls.Add(Me.chbJueves)
        Me.GroupBox4.Controls.Add(Me.chbLunes)
        Me.GroupBox4.Controls.Add(Me.chbMiercoles)
        Me.GroupBox4.Controls.Add(Me.chbMartes)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(8, 210)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 82)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "  Dias para aplicar el Horarrio  "
        '
        'chbViernes
        '
        Me.chbViernes.Appearance = System.Windows.Forms.Appearance.Button
        Me.chbViernes.BackColor = System.Drawing.Color.Gainsboro
        Me.chbViernes.FlatAppearance.BorderSize = 3
        Me.chbViernes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chbViernes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbViernes.ForeColor = System.Drawing.Color.DarkRed
        Me.chbViernes.Location = New System.Drawing.Point(346, 28)
        Me.chbViernes.Name = "chbViernes"
        Me.chbViernes.Size = New System.Drawing.Size(78, 40)
        Me.chbViernes.TabIndex = 60
        Me.chbViernes.Text = "Vier"
        Me.chbViernes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbViernes.UseVisualStyleBackColor = False
        '
        'chbJueves
        '
        Me.chbJueves.Appearance = System.Windows.Forms.Appearance.Button
        Me.chbJueves.BackColor = System.Drawing.Color.Gainsboro
        Me.chbJueves.FlatAppearance.BorderSize = 3
        Me.chbJueves.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chbJueves.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbJueves.ForeColor = System.Drawing.Color.DarkRed
        Me.chbJueves.Location = New System.Drawing.Point(262, 28)
        Me.chbJueves.Name = "chbJueves"
        Me.chbJueves.Size = New System.Drawing.Size(78, 40)
        Me.chbJueves.TabIndex = 59
        Me.chbJueves.Text = "Juev"
        Me.chbJueves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbJueves.UseVisualStyleBackColor = False
        '
        'chbLunes
        '
        Me.chbLunes.Appearance = System.Windows.Forms.Appearance.Button
        Me.chbLunes.BackColor = System.Drawing.Color.Gainsboro
        Me.chbLunes.FlatAppearance.BorderSize = 3
        Me.chbLunes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chbLunes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbLunes.ForeColor = System.Drawing.Color.DarkRed
        Me.chbLunes.Location = New System.Drawing.Point(10, 30)
        Me.chbLunes.Name = "chbLunes"
        Me.chbLunes.Size = New System.Drawing.Size(78, 38)
        Me.chbLunes.TabIndex = 56
        Me.chbLunes.Text = "Lun"
        Me.chbLunes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbLunes.UseVisualStyleBackColor = False
        '
        'chbMiercoles
        '
        Me.chbMiercoles.Appearance = System.Windows.Forms.Appearance.Button
        Me.chbMiercoles.BackColor = System.Drawing.Color.Gainsboro
        Me.chbMiercoles.FlatAppearance.BorderSize = 3
        Me.chbMiercoles.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chbMiercoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMiercoles.ForeColor = System.Drawing.Color.DarkRed
        Me.chbMiercoles.Location = New System.Drawing.Point(178, 30)
        Me.chbMiercoles.Name = "chbMiercoles"
        Me.chbMiercoles.Size = New System.Drawing.Size(78, 38)
        Me.chbMiercoles.TabIndex = 58
        Me.chbMiercoles.Text = "Mier"
        Me.chbMiercoles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbMiercoles.UseVisualStyleBackColor = False
        '
        'chbMartes
        '
        Me.chbMartes.Appearance = System.Windows.Forms.Appearance.Button
        Me.chbMartes.BackColor = System.Drawing.Color.Gainsboro
        Me.chbMartes.FlatAppearance.BorderSize = 3
        Me.chbMartes.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkOrange
        Me.chbMartes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMartes.ForeColor = System.Drawing.Color.DarkRed
        Me.chbMartes.Location = New System.Drawing.Point(94, 30)
        Me.chbMartes.Name = "chbMartes"
        Me.chbMartes.Size = New System.Drawing.Size(78, 38)
        Me.chbMartes.TabIndex = 57
        Me.chbMartes.Text = "Mar"
        Me.chbMartes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chbMartes.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtIdGrupo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbxCurso)
        Me.GroupBox2.Controls.Add(Me.cbxGrupo)
        Me.GroupBox2.Controls.Add(Me.txtIdCurso)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtOrigen)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 105)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Ingrese Curso y Grupo "
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdGrupo.Location = New System.Drawing.Point(318, 11)
        Me.txtIdGrupo.MaxLength = 10
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.Size = New System.Drawing.Size(44, 20)
        Me.txtIdGrupo.TabIndex = 55
        Me.txtIdGrupo.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(16, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Curso"
        '
        'cbxCurso
        '
        Me.cbxCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCurso.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(86, 30)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(338, 24)
        Me.cbxCurso.TabIndex = 43
        '
        'cbxGrupo
        '
        Me.cbxGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGrupo.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxGrupo.FormattingEnabled = True
        Me.cbxGrupo.Location = New System.Drawing.Point(86, 64)
        Me.cbxGrupo.Name = "cbxGrupo"
        Me.cbxGrupo.Size = New System.Drawing.Size(338, 24)
        Me.cbxGrupo.TabIndex = 44
        '
        'txtIdCurso
        '
        Me.txtIdCurso.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCurso.Location = New System.Drawing.Point(268, 11)
        Me.txtIdCurso.MaxLength = 10
        Me.txtIdCurso.Name = "txtIdCurso"
        Me.txtIdCurso.Size = New System.Drawing.Size(44, 20)
        Me.txtIdCurso.TabIndex = 54
        Me.txtIdCurso.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Grupo"
        '
        'txtOrigen
        '
        Me.txtOrigen.BackColor = System.Drawing.Color.LightCoral
        Me.txtOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOrigen.Location = New System.Drawing.Point(213, 11)
        Me.txtOrigen.MaxLength = 10
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(49, 20)
        Me.txtOrigen.TabIndex = 25
        Me.txtOrigen.Visible = False
        '
        'lblClases
        '
        Me.lblClases.BackColor = System.Drawing.Color.Gainsboro
        Me.lblClases.Enabled = False
        Me.lblClases.ForeColor = System.Drawing.Color.DarkRed
        Me.lblClases.Location = New System.Drawing.Point(9, 593)
        Me.lblClases.Name = "lblClases"
        Me.lblClases.Size = New System.Drawing.Size(158, 40)
        Me.lblClases.TabIndex = 58
        Me.lblClases.Text = "Tienen Clases ?"
        Me.lblClases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSiNo
        '
        Me.lblSiNo.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSiNo.Enabled = False
        Me.lblSiNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSiNo.ForeColor = System.Drawing.Color.DarkRed
        Me.lblSiNo.Location = New System.Drawing.Point(371, 593)
        Me.lblSiNo.Name = "lblSiNo"
        Me.lblSiNo.Size = New System.Drawing.Size(69, 40)
        Me.lblSiNo.TabIndex = 57
        Me.lblSiNo.Text = "SI/NO"
        Me.lblSiNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbxIngreso
        '
        Me.gbxIngreso.BackColor = System.Drawing.Color.Transparent
        Me.gbxIngreso.Controls.Add(Me.dtpIngreso)
        Me.gbxIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxIngreso.ForeColor = System.Drawing.Color.White
        Me.gbxIngreso.Location = New System.Drawing.Point(8, 386)
        Me.gbxIngreso.Name = "gbxIngreso"
        Me.gbxIngreso.Size = New System.Drawing.Size(432, 198)
        Me.gbxIngreso.TabIndex = 56
        Me.gbxIngreso.TabStop = False
        Me.gbxIngreso.Text = "  Hora de Ingreso  "
        '
        'dtpIngreso
        '
        Me.dtpIngreso.CalendarFont = New System.Drawing.Font("Gill Sans Ultra Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIngreso.CustomFormat = "HH:mm"
        Me.dtpIngreso.Font = New System.Drawing.Font("Arial Black", 80.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIngreso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpIngreso.Location = New System.Drawing.Point(42, 27)
        Me.dtpIngreso.Name = "dtpIngreso"
        Me.dtpIngreso.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpIngreso.ShowUpDown = True
        Me.dtpIngreso.Size = New System.Drawing.Size(346, 158)
        Me.dtpIngreso.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxModificar)
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 642)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = CType(resources.GetObject("pbxSalir.Image"), System.Drawing.Image)
        Me.pbxSalir.Location = New System.Drawing.Point(9, 522)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(196, 105)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 16
        Me.pbxSalir.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Image = CType(resources.GetObject("pbxCancelar.Image"), System.Drawing.Image)
        Me.pbxCancelar.Location = New System.Drawing.Point(9, 398)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(196, 105)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 15
        Me.pbxCancelar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Image = CType(resources.GetObject("pbxGuardar.Image"), System.Drawing.Image)
        Me.pbxGuardar.Location = New System.Drawing.Point(9, 273)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(196, 105)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 14
        Me.pbxGuardar.TabStop = False
        '
        'pbxModificar
        '
        Me.pbxModificar.BackColor = System.Drawing.Color.Transparent
        Me.pbxModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxModificar.Image = CType(resources.GetObject("pbxModificar.Image"), System.Drawing.Image)
        Me.pbxModificar.Location = New System.Drawing.Point(10, 147)
        Me.pbxModificar.Name = "pbxModificar"
        Me.pbxModificar.Size = New System.Drawing.Size(196, 105)
        Me.pbxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxModificar.TabIndex = 13
        Me.pbxModificar.TabStop = False
        '
        'pbxNuevo
        '
        Me.pbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevo.Image = CType(resources.GetObject("pbxNuevo.Image"), System.Drawing.Image)
        Me.pbxNuevo.Location = New System.Drawing.Point(9, 22)
        Me.pbxNuevo.Name = "pbxNuevo"
        Me.pbxNuevo.Size = New System.Drawing.Size(196, 105)
        Me.pbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevo.TabIndex = 12
        Me.pbxNuevo.TabStop = False
        '
        'frmManejoHorarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxHorarios)
        Me.Controls.Add(Me.gbxPPal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManejoHorarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManejoHorarios"
        Me.gbxHorarios.ResumeLayout(False)
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPPal.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbxIngreso.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxModificar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxModificar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents gbxPPal As System.Windows.Forms.GroupBox
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rdbMañana As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTarde As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxHorarios As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHorarios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbPermanente As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTemporal As System.Windows.Forms.RadioButton
    Friend WithEvents dtpIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCurso As System.Windows.Forms.TextBox
    Friend WithEvents pbxEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblClases As System.Windows.Forms.Label
    Friend WithEvents lblSiNo As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents gbxIngreso As System.Windows.Forms.GroupBox
    Friend WithEvents chbLunes As System.Windows.Forms.CheckBox
    Friend WithEvents chbMartes As System.Windows.Forms.CheckBox
    Friend WithEvents chbViernes As System.Windows.Forms.CheckBox
    Friend WithEvents chbJueves As System.Windows.Forms.CheckBox
    Friend WithEvents chbMiercoles As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As Label
End Class
