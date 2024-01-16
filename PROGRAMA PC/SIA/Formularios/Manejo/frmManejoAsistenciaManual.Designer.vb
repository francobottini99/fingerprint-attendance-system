<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManejoAsistenciaManual
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManejoAsistenciaManual))
        Me.gbxSeleccion = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMsgCurso = New System.Windows.Forms.Label()
        Me.cbxGrupos = New System.Windows.Forms.ComboBox()
        Me.txtIdGrupo = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtGrupo = New System.Windows.Forms.TextBox()
        Me.txtIngreso = New System.Windows.Forms.TextBox()
        Me.txtIdCurso = New System.Windows.Forms.TextBox()
        Me.txtFechaSeleccionada = New System.Windows.Forms.TextBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.mtcFecha = New System.Windows.Forms.MonthCalendar()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbxPlanilla = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvPlanillaAlumnos = New System.Windows.Forms.DataGridView()
        Me.Asistencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetiroAnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Justificada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbxDetalles = New System.Windows.Forms.GroupBox()
        Me.txtIdHorario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblIngreso = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnJust = New System.Windows.Forms.Button()
        Me.txtGoM = New System.Windows.Forms.TextBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.gbxSeleccion.SuspendLayout()
        Me.gbxPlanilla.SuspendLayout()
        CType(Me.dgvPlanillaAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxDetalles.SuspendLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxSeleccion
        '
        Me.gbxSeleccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSeleccion.BackColor = System.Drawing.Color.Transparent
        Me.gbxSeleccion.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxSeleccion.Controls.Add(Me.Label3)
        Me.gbxSeleccion.Controls.Add(Me.lblMsgCurso)
        Me.gbxSeleccion.Controls.Add(Me.cbxGrupos)
        Me.gbxSeleccion.Controls.Add(Me.txtIdGrupo)
        Me.gbxSeleccion.Controls.Add(Me.txtTipo)
        Me.gbxSeleccion.Controls.Add(Me.txtGrupo)
        Me.gbxSeleccion.Controls.Add(Me.txtIngreso)
        Me.gbxSeleccion.Controls.Add(Me.txtIdCurso)
        Me.gbxSeleccion.Controls.Add(Me.txtFechaSeleccionada)
        Me.gbxSeleccion.Controls.Add(Me.btnCargar)
        Me.gbxSeleccion.Controls.Add(Me.mtcFecha)
        Me.gbxSeleccion.Controls.Add(Me.cbxTurno)
        Me.gbxSeleccion.Controls.Add(Me.Label1)
        Me.gbxSeleccion.Controls.Add(Me.cbxCurso)
        Me.gbxSeleccion.Controls.Add(Me.Label2)
        Me.gbxSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSeleccion.ForeColor = System.Drawing.Color.White
        Me.gbxSeleccion.Location = New System.Drawing.Point(219, 2)
        Me.gbxSeleccion.Name = "gbxSeleccion"
        Me.gbxSeleccion.Size = New System.Drawing.Size(499, 218)
        Me.gbxSeleccion.TabIndex = 22
        Me.gbxSeleccion.TabStop = False
        Me.gbxSeleccion.Text = " Ingrese Datos "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(238, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Grupo"
        '
        'lblMsgCurso
        '
        Me.lblMsgCurso.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgCurso.ForeColor = System.Drawing.Color.Red
        Me.lblMsgCurso.Location = New System.Drawing.Point(243, 123)
        Me.lblMsgCurso.Name = "lblMsgCurso"
        Me.lblMsgCurso.Size = New System.Drawing.Size(248, 35)
        Me.lblMsgCurso.TabIndex = 38
        Me.lblMsgCurso.Text = "Selecciona primero fecha y turno"
        Me.lblMsgCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbxGrupos
        '
        Me.cbxGrupos.BackColor = System.Drawing.SystemColors.Window
        Me.cbxGrupos.Enabled = False
        Me.cbxGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxGrupos.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxGrupos.FormattingEnabled = True
        Me.cbxGrupos.Location = New System.Drawing.Point(300, 94)
        Me.cbxGrupos.Name = "cbxGrupos"
        Me.cbxGrupos.Size = New System.Drawing.Size(191, 24)
        Me.cbxGrupos.TabIndex = 43
        '
        'txtIdGrupo
        '
        Me.txtIdGrupo.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdGrupo.Location = New System.Drawing.Point(380, 0)
        Me.txtIdGrupo.MaxLength = 10
        Me.txtIdGrupo.Name = "txtIdGrupo"
        Me.txtIdGrupo.Size = New System.Drawing.Size(51, 20)
        Me.txtIdGrupo.TabIndex = 42
        Me.txtIdGrupo.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.BackColor = System.Drawing.Color.LightCoral
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtTipo.Location = New System.Drawing.Point(266, 0)
        Me.txtTipo.MaxLength = 10
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(51, 20)
        Me.txtTipo.TabIndex = 41
        Me.txtTipo.Visible = False
        '
        'txtGrupo
        '
        Me.txtGrupo.BackColor = System.Drawing.Color.LightCoral
        Me.txtGrupo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrupo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtGrupo.Location = New System.Drawing.Point(437, 0)
        Me.txtGrupo.MaxLength = 10
        Me.txtGrupo.Name = "txtGrupo"
        Me.txtGrupo.Size = New System.Drawing.Size(51, 20)
        Me.txtGrupo.TabIndex = 40
        Me.txtGrupo.Visible = False
        '
        'txtIngreso
        '
        Me.txtIngreso.BackColor = System.Drawing.Color.LightCoral
        Me.txtIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngreso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIngreso.Location = New System.Drawing.Point(209, 0)
        Me.txtIngreso.MaxLength = 10
        Me.txtIngreso.Name = "txtIngreso"
        Me.txtIngreso.Size = New System.Drawing.Size(51, 20)
        Me.txtIngreso.TabIndex = 39
        Me.txtIngreso.Visible = False
        '
        'txtIdCurso
        '
        Me.txtIdCurso.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdCurso.Location = New System.Drawing.Point(323, 0)
        Me.txtIdCurso.MaxLength = 10
        Me.txtIdCurso.Name = "txtIdCurso"
        Me.txtIdCurso.Size = New System.Drawing.Size(51, 20)
        Me.txtIdCurso.TabIndex = 37
        Me.txtIdCurso.Visible = False
        '
        'txtFechaSeleccionada
        '
        Me.txtFechaSeleccionada.BackColor = System.Drawing.Color.LightCoral
        Me.txtFechaSeleccionada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSeleccionada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFechaSeleccionada.Location = New System.Drawing.Point(147, 0)
        Me.txtFechaSeleccionada.MaxLength = 10
        Me.txtFechaSeleccionada.Name = "txtFechaSeleccionada"
        Me.txtFechaSeleccionada.Size = New System.Drawing.Size(56, 20)
        Me.txtFechaSeleccionada.TabIndex = 36
        Me.txtFechaSeleccionada.Visible = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Transparent
        Me.btnCargar.FlatAppearance.BorderSize = 3
        Me.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown
        Me.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.ForeColor = System.Drawing.Color.DarkOrange
        Me.btnCargar.Location = New System.Drawing.Point(243, 164)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(248, 37)
        Me.btnCargar.TabIndex = 35
        Me.btnCargar.Text = "CARGAR ASISTENCIA"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'mtcFecha
        '
        Me.mtcFecha.Location = New System.Drawing.Point(8, 32)
        Me.mtcFecha.MaxSelectionCount = 1
        Me.mtcFecha.Name = "mtcFecha"
        Me.mtcFecha.ShowToday = False
        Me.mtcFecha.ShowTodayCircle = False
        Me.mtcFecha.TabIndex = 34
        '
        'cbxTurno
        '
        Me.cbxTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTurno.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.cbxTurno.Location = New System.Drawing.Point(300, 32)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(191, 24)
        Me.cbxTurno.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(239, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Turno"
        '
        'cbxCurso
        '
        Me.cbxCurso.Enabled = False
        Me.cbxCurso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCurso.ForeColor = System.Drawing.Color.SaddleBrown
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(300, 63)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(191, 24)
        Me.cbxCurso.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(239, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Curso"
        '
        'gbxPlanilla
        '
        Me.gbxPlanilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPlanilla.BackColor = System.Drawing.Color.Transparent
        Me.gbxPlanilla.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxPlanilla.Controls.Add(Me.Label7)
        Me.gbxPlanilla.Controls.Add(Me.dgvPlanillaAlumnos)
        Me.gbxPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPlanilla.ForeColor = System.Drawing.Color.White
        Me.gbxPlanilla.Location = New System.Drawing.Point(219, 223)
        Me.gbxPlanilla.Name = "gbxPlanilla"
        Me.gbxPlanilla.Size = New System.Drawing.Size(857, 434)
        Me.gbxPlanilla.TabIndex = 35
        Me.gbxPlanilla.TabStop = False
        Me.gbxPlanilla.Text = " Planilla de Asistencia "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DarkRed
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(214, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(615, 18)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = """ NOTA: Doble Click sobre el Alumno cambia su estado de 'Presente' a 'Tarde' , 'A" & _
    "usente' o 'Ret. Anticipado' """
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvPlanillaAlumnos
        '
        Me.dgvPlanillaAlumnos.AllowUserToAddRows = False
        Me.dgvPlanillaAlumnos.AllowUserToDeleteRows = False
        Me.dgvPlanillaAlumnos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvPlanillaAlumnos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPlanillaAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvPlanillaAlumnos.ColumnHeadersHeight = 30
        Me.dgvPlanillaAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPlanillaAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Asistencia, Me.RetiroAnt, Me.Justificada})
        Me.dgvPlanillaAlumnos.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPlanillaAlumnos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPlanillaAlumnos.Location = New System.Drawing.Point(6, 23)
        Me.dgvPlanillaAlumnos.MultiSelect = False
        Me.dgvPlanillaAlumnos.Name = "dgvPlanillaAlumnos"
        Me.dgvPlanillaAlumnos.ReadOnly = True
        Me.dgvPlanillaAlumnos.RowHeadersVisible = False
        Me.dgvPlanillaAlumnos.RowHeadersWidth = 100
        Me.dgvPlanillaAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvPlanillaAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPlanillaAlumnos.Size = New System.Drawing.Size(843, 400)
        Me.dgvPlanillaAlumnos.TabIndex = 11
        '
        'Asistencia
        '
        Me.Asistencia.HeaderText = "Asistencia"
        Me.Asistencia.Name = "Asistencia"
        Me.Asistencia.ReadOnly = True
        Me.Asistencia.Visible = False
        '
        'RetiroAnt
        '
        Me.RetiroAnt.HeaderText = "Retiro Anticipado"
        Me.RetiroAnt.Name = "RetiroAnt"
        Me.RetiroAnt.ReadOnly = True
        Me.RetiroAnt.Visible = False
        '
        'Justificada
        '
        Me.Justificada.HeaderText = "Justificada"
        Me.Justificada.Name = "Justificada"
        Me.Justificada.ReadOnly = True
        Me.Justificada.Visible = False
        '
        'gbxDetalles
        '
        Me.gbxDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxDetalles.BackColor = System.Drawing.Color.Transparent
        Me.gbxDetalles.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxDetalles.Controls.Add(Me.txtIdHorario)
        Me.gbxDetalles.Controls.Add(Me.Label6)
        Me.gbxDetalles.Controls.Add(Me.Label4)
        Me.gbxDetalles.Controls.Add(Me.lblTurno)
        Me.gbxDetalles.Controls.Add(Me.Label14)
        Me.gbxDetalles.Controls.Add(Me.lblDia)
        Me.gbxDetalles.Controls.Add(Me.Label12)
        Me.gbxDetalles.Controls.Add(Me.lblIngreso)
        Me.gbxDetalles.Controls.Add(Me.Label8)
        Me.gbxDetalles.Controls.Add(Me.lblGrupo)
        Me.gbxDetalles.Controls.Add(Me.Label10)
        Me.gbxDetalles.Controls.Add(Me.lblCurso)
        Me.gbxDetalles.Controls.Add(Me.Label5)
        Me.gbxDetalles.Controls.Add(Me.lblFecha)
        Me.gbxDetalles.Controls.Add(Me.Label72)
        Me.gbxDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDetalles.ForeColor = System.Drawing.Color.White
        Me.gbxDetalles.Location = New System.Drawing.Point(723, 2)
        Me.gbxDetalles.Name = "gbxDetalles"
        Me.gbxDetalles.Size = New System.Drawing.Size(353, 218)
        Me.gbxDetalles.TabIndex = 35
        Me.gbxDetalles.TabStop = False
        Me.gbxDetalles.Text = " Resumen "
        '
        'txtIdHorario
        '
        Me.txtIdHorario.BackColor = System.Drawing.Color.LightCoral
        Me.txtIdHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdHorario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIdHorario.Location = New System.Drawing.Point(269, 193)
        Me.txtIdHorario.MaxLength = 10
        Me.txtIdHorario.Name = "txtIdHorario"
        Me.txtIdHorario.Size = New System.Drawing.Size(51, 20)
        Me.txtIdHorario.TabIndex = 45
        Me.txtIdHorario.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(2, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(350, 1)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(176, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1, 210)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Label4"
        '
        'lblTurno
        '
        Me.lblTurno.BackColor = System.Drawing.Color.SlateGray
        Me.lblTurno.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTurno.ForeColor = System.Drawing.Color.White
        Me.lblTurno.Location = New System.Drawing.Point(91, 155)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(79, 35)
        Me.lblTurno.TabIndex = 125
        Me.lblTurno.Text = "Mañana"
        Me.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Silver
        Me.Label14.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(91, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 23)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "TURNO"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDia
        '
        Me.lblDia.BackColor = System.Drawing.Color.SlateGray
        Me.lblDia.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.ForeColor = System.Drawing.Color.White
        Me.lblDia.Location = New System.Drawing.Point(6, 155)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(79, 35)
        Me.lblDia.TabIndex = 123
        Me.lblDia.Text = "Lunes"
        Me.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Silver
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(6, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 23)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "DÌA"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblIngreso
        '
        Me.lblIngreso.BackColor = System.Drawing.Color.SlateGray
        Me.lblIngreso.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreso.ForeColor = System.Drawing.Color.White
        Me.lblIngreso.Location = New System.Drawing.Point(268, 155)
        Me.lblIngreso.Name = "lblIngreso"
        Me.lblIngreso.Size = New System.Drawing.Size(79, 35)
        Me.lblIngreso.TabIndex = 121
        Me.lblIngreso.Text = "7:30"
        Me.lblIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(268, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 23)
        Me.Label8.TabIndex = 120
        Me.Label8.Text = "INGRESO"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrupo
        '
        Me.lblGrupo.BackColor = System.Drawing.Color.SlateGray
        Me.lblGrupo.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrupo.ForeColor = System.Drawing.Color.White
        Me.lblGrupo.Location = New System.Drawing.Point(183, 155)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(79, 35)
        Me.lblGrupo.TabIndex = 119
        Me.lblGrupo.Text = "Todos"
        Me.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Silver
        Me.Label10.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(183, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 23)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "GRUPO"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCurso
        '
        Me.lblCurso.BackColor = System.Drawing.Color.SlateGray
        Me.lblCurso.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurso.ForeColor = System.Drawing.Color.White
        Me.lblCurso.Location = New System.Drawing.Point(181, 60)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(166, 35)
        Me.lblCurso.TabIndex = 117
        Me.lblCurso.Text = "1º ""B"""
        Me.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(181, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 23)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "CURSO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.Color.SlateGray
        Me.lblFecha.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(6, 60)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(166, 35)
        Me.lblFecha.TabIndex = 115
        Me.lblFecha.Text = "05/05/2018"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.Color.Silver
        Me.Label72.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label72.Location = New System.Drawing.Point(6, 37)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(166, 23)
        Me.Label72.TabIndex = 114
        Me.Label72.Text = "FECHA"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(9, 539)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(196, 105)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 35
        Me.pbxSalir.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox4.Controls.Add(Me.btnJust)
        Me.GroupBox4.Controls.Add(Me.txtGoM)
        Me.GroupBox4.Controls.Add(Me.pbxSalir)
        Me.GroupBox4.Controls.Add(Me.pbxCancelar)
        Me.GroupBox4.Controls.Add(Me.pbxGuardar)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(212, 655)
        Me.GroupBox4.TabIndex = 114
        Me.GroupBox4.TabStop = False
        '
        'btnJust
        '
        Me.btnJust.BackColor = System.Drawing.Color.DarkRed
        Me.btnJust.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJust.Location = New System.Drawing.Point(22, 277)
        Me.btnJust.Name = "btnJust"
        Me.btnJust.Size = New System.Drawing.Size(168, 43)
        Me.btnJust.TabIndex = 13
        Me.btnJust.Text = "Falta Justificada"
        Me.btnJust.UseVisualStyleBackColor = False
        '
        'txtGoM
        '
        Me.txtGoM.BackColor = System.Drawing.Color.LightCoral
        Me.txtGoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGoM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtGoM.Location = New System.Drawing.Point(6, 0)
        Me.txtGoM.MaxLength = 10
        Me.txtGoM.Name = "txtGoM"
        Me.txtGoM.Size = New System.Drawing.Size(51, 20)
        Me.txtGoM.TabIndex = 46
        Me.txtGoM.Text = "G"
        Me.txtGoM.Visible = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Image = Global.SIA.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.Location = New System.Drawing.Point(9, 23)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(196, 105)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 39
        Me.pbxCancelar.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Image = Global.SIA.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.Location = New System.Drawing.Point(9, 144)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(196, 105)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 38
        Me.pbxGuardar.TabStop = False
        '
        'frmManejoAsistenciaManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbxDetalles)
        Me.Controls.Add(Me.gbxPlanilla)
        Me.Controls.Add(Me.gbxSeleccion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmManejoAsistenciaManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmManejoAsistenciaManual"
        Me.gbxSeleccion.ResumeLayout(False)
        Me.gbxSeleccion.PerformLayout()
        Me.gbxPlanilla.ResumeLayout(False)
        CType(Me.dgvPlanillaAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxDetalles.ResumeLayout(False)
        Me.gbxDetalles.PerformLayout()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxSeleccion As System.Windows.Forms.GroupBox
    Friend WithEvents mtcFecha As System.Windows.Forms.MonthCalendar
    Friend WithEvents cbxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents gbxPlanilla As System.Windows.Forms.GroupBox
    Private WithEvents dgvPlanillaAlumnos As System.Windows.Forms.DataGridView
    Friend WithEvents gbxDetalles As System.Windows.Forms.GroupBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents lblTurno As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblDia As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblIngreso As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblCurso As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtFechaSeleccionada As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCurso As System.Windows.Forms.TextBox
    Friend WithEvents lblMsgCurso As System.Windows.Forms.Label
    Friend WithEvents txtGrupo As System.Windows.Forms.TextBox
    Friend WithEvents txtIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtIdGrupo As System.Windows.Forms.TextBox
    Friend WithEvents cbxGrupos As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdHorario As System.Windows.Forms.TextBox
    Friend WithEvents txtGoM As System.Windows.Forms.TextBox
    Friend WithEvents Asistencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetiroAnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Justificada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnJust As System.Windows.Forms.Button
End Class
