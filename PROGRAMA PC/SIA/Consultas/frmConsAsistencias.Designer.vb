<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsAsistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsAsistencias))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxImprimir = New System.Windows.Forms.PictureBox()
        Me.pbxFiltro = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.gbxSeleccion = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbxDivision = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbxSexo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxAsistencia = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlumno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFecH = New System.Windows.Forms.TextBox()
        Me.txtFecD = New System.Windows.Forms.TextBox()
        Me.cbxTurno = New System.Windows.Forms.ComboBox()
        Me.cbxCurso = New System.Windows.Forms.ComboBox()
        Me.gbxPlanilla = New System.Windows.Forms.GroupBox()
        Me.dgvAsistencia = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxImprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxSeleccion.SuspendLayout()
        Me.gbxPlanilla.SuspendLayout()
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxImprimir)
        Me.GroupBox1.Controls.Add(Me.pbxFiltro)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(645, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 122)
        Me.GroupBox1.TabIndex = 118
        Me.GroupBox1.TabStop = False
        '
        'pbxImprimir
        '
        Me.pbxImprimir.BackColor = System.Drawing.Color.Transparent
        Me.pbxImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxImprimir.Image = Global.SIA.My.Resources.Resources.btnImprimirNo
        Me.pbxImprimir.Location = New System.Drawing.Point(21, 30)
        Me.pbxImprimir.Name = "pbxImprimir"
        Me.pbxImprimir.Size = New System.Drawing.Size(127, 70)
        Me.pbxImprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxImprimir.TabIndex = 61
        Me.pbxImprimir.TabStop = False
        '
        'pbxFiltro
        '
        Me.pbxFiltro.BackColor = System.Drawing.Color.Transparent
        Me.pbxFiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxFiltro.Image = Global.SIA.My.Resources.Resources.btnFiltrarNo
        Me.pbxFiltro.Location = New System.Drawing.Point(154, 30)
        Me.pbxFiltro.Name = "pbxFiltro"
        Me.pbxFiltro.Size = New System.Drawing.Size(127, 70)
        Me.pbxFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxFiltro.TabIndex = 60
        Me.pbxFiltro.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(287, 30)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(127, 70)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 35
        Me.pbxSalir.TabStop = False
        '
        'gbxSeleccion
        '
        Me.gbxSeleccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxSeleccion.BackColor = System.Drawing.Color.Transparent
        Me.gbxSeleccion.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxSeleccion.Controls.Add(Me.Label5)
        Me.gbxSeleccion.Controls.Add(Me.cbxDivision)
        Me.gbxSeleccion.Controls.Add(Me.Label4)
        Me.gbxSeleccion.Controls.Add(Me.cbxSexo)
        Me.gbxSeleccion.Controls.Add(Me.Label3)
        Me.gbxSeleccion.Controls.Add(Me.cbxAsistencia)
        Me.gbxSeleccion.Controls.Add(Me.Label1)
        Me.gbxSeleccion.Controls.Add(Me.Label2)
        Me.gbxSeleccion.Controls.Add(Me.txtAlumno)
        Me.gbxSeleccion.Controls.Add(Me.Label13)
        Me.gbxSeleccion.Controls.Add(Me.Label11)
        Me.gbxSeleccion.Controls.Add(Me.Label9)
        Me.gbxSeleccion.Controls.Add(Me.txtFecH)
        Me.gbxSeleccion.Controls.Add(Me.txtFecD)
        Me.gbxSeleccion.Controls.Add(Me.cbxTurno)
        Me.gbxSeleccion.Controls.Add(Me.cbxCurso)
        Me.gbxSeleccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSeleccion.ForeColor = System.Drawing.Color.White
        Me.gbxSeleccion.Location = New System.Drawing.Point(2, 1)
        Me.gbxSeleccion.Name = "gbxSeleccion"
        Me.gbxSeleccion.Size = New System.Drawing.Size(637, 122)
        Me.gbxSeleccion.TabIndex = 115
        Me.gbxSeleccion.TabStop = False
        Me.gbxSeleccion.Text = " Filtros "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label5.Location = New System.Drawing.Point(84, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "División"
        '
        'cbxDivision
        '
        Me.cbxDivision.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDivision.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxDivision.FormattingEnabled = True
        Me.cbxDivision.Location = New System.Drawing.Point(87, 86)
        Me.cbxDivision.Name = "cbxDivision"
        Me.cbxDivision.Size = New System.Drawing.Size(67, 24)
        Me.cbxDivision.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label4.Location = New System.Drawing.Point(479, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Sexo"
        '
        'cbxSexo
        '
        Me.cbxSexo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxSexo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxSexo.FormattingEnabled = True
        Me.cbxSexo.Location = New System.Drawing.Point(478, 86)
        Me.cbxSexo.Name = "cbxSexo"
        Me.cbxSexo.Size = New System.Drawing.Size(153, 24)
        Me.cbxSexo.TabIndex = 56
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label3.Location = New System.Drawing.Point(320, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Asistencia"
        '
        'cbxAsistencia
        '
        Me.cbxAsistencia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAsistencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxAsistencia.FormattingEnabled = True
        Me.cbxAsistencia.Location = New System.Drawing.Point(319, 86)
        Me.cbxAsistencia.Name = "cbxAsistencia"
        Me.cbxAsistencia.Size = New System.Drawing.Size(154, 24)
        Me.cbxAsistencia.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label1.Location = New System.Drawing.Point(160, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Turno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(286, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Alumno"
        '
        'txtAlumno
        '
        Me.txtAlumno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlumno.Location = New System.Drawing.Point(289, 40)
        Me.txtAlumno.Name = "txtAlumno"
        Me.txtAlumno.Size = New System.Drawing.Size(342, 22)
        Me.txtAlumno.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label13.Location = New System.Drawing.Point(15, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(44, 16)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "Curso"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label11.Location = New System.Drawing.Point(146, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Fecha Hasta"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label9.Location = New System.Drawing.Point(10, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 16)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Fecha Desde"
        '
        'txtFecH
        '
        Me.txtFecH.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecH.Location = New System.Drawing.Point(149, 40)
        Me.txtFecH.Name = "txtFecH"
        Me.txtFecH.Size = New System.Drawing.Size(117, 22)
        Me.txtFecH.TabIndex = 46
        Me.txtFecH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFecD
        '
        Me.txtFecD.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecD.Location = New System.Drawing.Point(14, 40)
        Me.txtFecD.Name = "txtFecD"
        Me.txtFecD.Size = New System.Drawing.Size(116, 22)
        Me.txtFecD.TabIndex = 45
        Me.txtFecD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cbxTurno
        '
        Me.cbxTurno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxTurno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxTurno.FormattingEnabled = True
        Me.cbxTurno.Items.AddRange(New Object() {"Mañana", "Tarde"})
        Me.cbxTurno.Location = New System.Drawing.Point(160, 86)
        Me.cbxTurno.Name = "cbxTurno"
        Me.cbxTurno.Size = New System.Drawing.Size(154, 24)
        Me.cbxTurno.TabIndex = 33
        '
        'cbxCurso
        '
        Me.cbxCurso.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxCurso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbxCurso.FormattingEnabled = True
        Me.cbxCurso.Location = New System.Drawing.Point(14, 86)
        Me.cbxCurso.Name = "cbxCurso"
        Me.cbxCurso.Size = New System.Drawing.Size(67, 24)
        Me.cbxCurso.TabIndex = 31
        '
        'gbxPlanilla
        '
        Me.gbxPlanilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPlanilla.BackColor = System.Drawing.Color.Transparent
        Me.gbxPlanilla.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxPlanilla.Controls.Add(Me.dgvAsistencia)
        Me.gbxPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPlanilla.ForeColor = System.Drawing.Color.White
        Me.gbxPlanilla.Location = New System.Drawing.Point(2, 129)
        Me.gbxPlanilla.Name = "gbxPlanilla"
        Me.gbxPlanilla.Size = New System.Drawing.Size(1075, 528)
        Me.gbxPlanilla.TabIndex = 117
        Me.gbxPlanilla.TabStop = False
        Me.gbxPlanilla.Text = " Planilla de Asistencia "
        '
        'dgvAsistencia
        '
        Me.dgvAsistencia.AllowUserToAddRows = False
        Me.dgvAsistencia.AllowUserToDeleteRows = False
        Me.dgvAsistencia.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAsistencia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvAsistencia.ColumnHeadersHeight = 30
        Me.dgvAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvAsistencia.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAsistencia.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAsistencia.Location = New System.Drawing.Point(6, 25)
        Me.dgvAsistencia.MultiSelect = False
        Me.dgvAsistencia.Name = "dgvAsistencia"
        Me.dgvAsistencia.ReadOnly = True
        Me.dgvAsistencia.RowHeadersVisible = False
        Me.dgvAsistencia.RowHeadersWidth = 100
        Me.dgvAsistencia.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAsistencia.Size = New System.Drawing.Size(1063, 497)
        Me.dgvAsistencia.TabIndex = 19
        '
        'frmConsAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1081, 660)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxSeleccion)
        Me.Controls.Add(Me.gbxPlanilla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConsAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsAsistencias"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxImprimir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxSeleccion.ResumeLayout(False)
        Me.gbxSeleccion.PerformLayout()
        Me.gbxPlanilla.ResumeLayout(False)
        CType(Me.dgvAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPlanilla As System.Windows.Forms.GroupBox
    Friend WithEvents cbxCurso As System.Windows.Forms.ComboBox
    Friend WithEvents cbxTurno As System.Windows.Forms.ComboBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents txtFecD As System.Windows.Forms.TextBox
    Friend WithEvents txtFecH As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbxSeleccion As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlumno As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbxDivision As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbxSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbxAsistencia As System.Windows.Forms.ComboBox
    Friend WithEvents pbxFiltro As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxImprimir As System.Windows.Forms.PictureBox
    Private WithEvents dgvAsistencia As System.Windows.Forms.DataGridView
End Class
