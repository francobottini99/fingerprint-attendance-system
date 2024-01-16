<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.gbxPanelSuperior = New System.Windows.Forms.GroupBox()
        Me.pbxAltas = New System.Windows.Forms.PictureBox()
        Me.pbxManejo = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxConsultas = New System.Windows.Forms.PictureBox()
        Me.gbxManejo = New System.Windows.Forms.GroupBox()
        Me.pbxManejoMovAlumnos = New System.Windows.Forms.PictureBox()
        Me.pbxManejoVolver = New System.Windows.Forms.PictureBox()
        Me.pbxManejoAsistencia = New System.Windows.Forms.PictureBox()
        Me.pbxManejoAsignarHuellas = New System.Windows.Forms.PictureBox()
        Me.pbxManejoHorarios = New System.Windows.Forms.PictureBox()
        Me.gbxAltas = New System.Windows.Forms.GroupBox()
        Me.pbxSistema = New System.Windows.Forms.PictureBox()
        Me.pbxAltasVolver = New System.Windows.Forms.PictureBox()
        Me.pbxAltasFeriado = New System.Windows.Forms.PictureBox()
        Me.pbxAltasGrupo = New System.Windows.Forms.PictureBox()
        Me.pbxAltasCurso = New System.Windows.Forms.PictureBox()
        Me.pbxAltasAlumnos = New System.Windows.Forms.PictureBox()
        Me.gbxPPal = New System.Windows.Forms.GroupBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.gbxConsultas = New System.Windows.Forms.GroupBox()
        Me.pbxConsultasAsistencia = New System.Windows.Forms.PictureBox()
        Me.pbxConsultasVolver = New System.Windows.Forms.PictureBox()
        Me.gbxPanelSuperior.SuspendLayout()
        CType(Me.pbxAltas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxManejo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxManejo.SuspendLayout()
        CType(Me.pbxManejoMovAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxManejoVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxManejoAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxManejoAsignarHuellas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxManejoHorarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxAltas.SuspendLayout()
        CType(Me.pbxSistema, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAltasVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAltasFeriado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAltasGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAltasCurso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxAltasAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPPal.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxConsultas.SuspendLayout()
        CType(Me.pbxConsultasAsistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxConsultasVolver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxPanelSuperior
        '
        Me.gbxPanelSuperior.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPanelSuperior.BackColor = System.Drawing.Color.Transparent
        Me.gbxPanelSuperior.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxPanelSuperior.Controls.Add(Me.pbxAltas)
        Me.gbxPanelSuperior.Controls.Add(Me.pbxManejo)
        Me.gbxPanelSuperior.Controls.Add(Me.pbxSalir)
        Me.gbxPanelSuperior.Controls.Add(Me.pbxConsultas)
        Me.gbxPanelSuperior.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPanelSuperior.ForeColor = System.Drawing.Color.White
        Me.gbxPanelSuperior.Location = New System.Drawing.Point(12, 12)
        Me.gbxPanelSuperior.Name = "gbxPanelSuperior"
        Me.gbxPanelSuperior.Size = New System.Drawing.Size(1330, 201)
        Me.gbxPanelSuperior.TabIndex = 7
        Me.gbxPanelSuperior.TabStop = False
        '
        'pbxAltas
        '
        Me.pbxAltas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAltas.BackColor = System.Drawing.Color.Transparent
        Me.pbxAltas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAltas.Image = Global.SIA.My.Resources.Resources.btnAltasNo
        Me.pbxAltas.Location = New System.Drawing.Point(30, 37)
        Me.pbxAltas.Name = "pbxAltas"
        Me.pbxAltas.Size = New System.Drawing.Size(305, 138)
        Me.pbxAltas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAltas.TabIndex = 6
        Me.pbxAltas.TabStop = False
        '
        'pbxManejo
        '
        Me.pbxManejo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxManejo.BackColor = System.Drawing.Color.Transparent
        Me.pbxManejo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManejo.Image = Global.SIA.My.Resources.Resources.btnManejoNo1
        Me.pbxManejo.Location = New System.Drawing.Point(350, 37)
        Me.pbxManejo.Name = "pbxManejo"
        Me.pbxManejo.Size = New System.Drawing.Size(305, 138)
        Me.pbxManejo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxManejo.TabIndex = 5
        Me.pbxManejo.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(991, 37)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(305, 138)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 4
        Me.pbxSalir.TabStop = False
        '
        'pbxConsultas
        '
        Me.pbxConsultas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxConsultas.BackColor = System.Drawing.Color.Transparent
        Me.pbxConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxConsultas.Image = Global.SIA.My.Resources.Resources.btnConsultasNo1
        Me.pbxConsultas.Location = New System.Drawing.Point(670, 37)
        Me.pbxConsultas.Name = "pbxConsultas"
        Me.pbxConsultas.Size = New System.Drawing.Size(305, 138)
        Me.pbxConsultas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxConsultas.TabIndex = 3
        Me.pbxConsultas.TabStop = False
        '
        'gbxManejo
        '
        Me.gbxManejo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxManejo.BackColor = System.Drawing.Color.Transparent
        Me.gbxManejo.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxManejo.Controls.Add(Me.pbxSistema)
        Me.gbxManejo.Controls.Add(Me.pbxManejoMovAlumnos)
        Me.gbxManejo.Controls.Add(Me.pbxManejoVolver)
        Me.gbxManejo.Controls.Add(Me.pbxManejoAsistencia)
        Me.gbxManejo.Controls.Add(Me.pbxManejoAsignarHuellas)
        Me.gbxManejo.Controls.Add(Me.pbxManejoHorarios)
        Me.gbxManejo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxManejo.ForeColor = System.Drawing.Color.White
        Me.gbxManejo.Location = New System.Drawing.Point(12, 219)
        Me.gbxManejo.Name = "gbxManejo"
        Me.gbxManejo.Size = New System.Drawing.Size(1330, 510)
        Me.gbxManejo.TabIndex = 13
        Me.gbxManejo.TabStop = False
        Me.gbxManejo.Visible = False
        '
        'pbxManejoMovAlumnos
        '
        Me.pbxManejoMovAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxManejoMovAlumnos.BackColor = System.Drawing.Color.Transparent
        Me.pbxManejoMovAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManejoMovAlumnos.Image = Global.SIA.My.Resources.Resources.btnManejoMovAlumnosNo
        Me.pbxManejoMovAlumnos.Location = New System.Drawing.Point(57, 282)
        Me.pbxManejoMovAlumnos.Name = "pbxManejoMovAlumnos"
        Me.pbxManejoMovAlumnos.Size = New System.Drawing.Size(384, 201)
        Me.pbxManejoMovAlumnos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxManejoMovAlumnos.TabIndex = 13
        Me.pbxManejoMovAlumnos.TabStop = False
        '
        'pbxManejoVolver
        '
        Me.pbxManejoVolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxManejoVolver.BackColor = System.Drawing.Color.Transparent
        Me.pbxManejoVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManejoVolver.Image = Global.SIA.My.Resources.Resources.btnVolverNo
        Me.pbxManejoVolver.Location = New System.Drawing.Point(890, 282)
        Me.pbxManejoVolver.Name = "pbxManejoVolver"
        Me.pbxManejoVolver.Size = New System.Drawing.Size(384, 201)
        Me.pbxManejoVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxManejoVolver.TabIndex = 12
        Me.pbxManejoVolver.TabStop = False
        '
        'pbxManejoAsistencia
        '
        Me.pbxManejoAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxManejoAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.pbxManejoAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManejoAsistencia.Image = Global.SIA.My.Resources.Resources.btnManejoAsistenciaNo
        Me.pbxManejoAsistencia.Location = New System.Drawing.Point(890, 41)
        Me.pbxManejoAsistencia.Name = "pbxManejoAsistencia"
        Me.pbxManejoAsistencia.Size = New System.Drawing.Size(384, 201)
        Me.pbxManejoAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxManejoAsistencia.TabIndex = 9
        Me.pbxManejoAsistencia.TabStop = False
        '
        'pbxManejoAsignarHuellas
        '
        Me.pbxManejoAsignarHuellas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxManejoAsignarHuellas.BackColor = System.Drawing.Color.Transparent
        Me.pbxManejoAsignarHuellas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManejoAsignarHuellas.Image = Global.SIA.My.Resources.Resources.btnManejoAsignarHuellasNo
        Me.pbxManejoAsignarHuellas.Location = New System.Drawing.Point(471, 41)
        Me.pbxManejoAsignarHuellas.Name = "pbxManejoAsignarHuellas"
        Me.pbxManejoAsignarHuellas.Size = New System.Drawing.Size(384, 201)
        Me.pbxManejoAsignarHuellas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxManejoAsignarHuellas.TabIndex = 8
        Me.pbxManejoAsignarHuellas.TabStop = False
        '
        'pbxManejoHorarios
        '
        Me.pbxManejoHorarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxManejoHorarios.BackColor = System.Drawing.Color.Transparent
        Me.pbxManejoHorarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxManejoHorarios.Image = Global.SIA.My.Resources.Resources.btnManejoHorariosNo
        Me.pbxManejoHorarios.Location = New System.Drawing.Point(57, 41)
        Me.pbxManejoHorarios.Name = "pbxManejoHorarios"
        Me.pbxManejoHorarios.Size = New System.Drawing.Size(384, 201)
        Me.pbxManejoHorarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxManejoHorarios.TabIndex = 7
        Me.pbxManejoHorarios.TabStop = False
        '
        'gbxAltas
        '
        Me.gbxAltas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxAltas.BackColor = System.Drawing.Color.Transparent
        Me.gbxAltas.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxAltas.Controls.Add(Me.pbxAltasVolver)
        Me.gbxAltas.Controls.Add(Me.pbxAltasFeriado)
        Me.gbxAltas.Controls.Add(Me.pbxAltasGrupo)
        Me.gbxAltas.Controls.Add(Me.pbxAltasCurso)
        Me.gbxAltas.Controls.Add(Me.pbxAltasAlumnos)
        Me.gbxAltas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAltas.ForeColor = System.Drawing.Color.White
        Me.gbxAltas.Location = New System.Drawing.Point(12, 219)
        Me.gbxAltas.Name = "gbxAltas"
        Me.gbxAltas.Size = New System.Drawing.Size(1330, 510)
        Me.gbxAltas.TabIndex = 9
        Me.gbxAltas.TabStop = False
        Me.gbxAltas.Visible = False
        '
        'pbxSistema
        '
        Me.pbxSistema.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSistema.BackColor = System.Drawing.Color.Transparent
        Me.pbxSistema.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSistema.Image = Global.SIA.My.Resources.Resources.btnSistemaNo
        Me.pbxSistema.Location = New System.Drawing.Point(471, 282)
        Me.pbxSistema.Name = "pbxSistema"
        Me.pbxSistema.Size = New System.Drawing.Size(384, 201)
        Me.pbxSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSistema.TabIndex = 13
        Me.pbxSistema.TabStop = False
        '
        'pbxAltasVolver
        '
        Me.pbxAltasVolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAltasVolver.BackColor = System.Drawing.Color.Transparent
        Me.pbxAltasVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAltasVolver.Image = Global.SIA.My.Resources.Resources.btnVolverNo
        Me.pbxAltasVolver.Location = New System.Drawing.Point(471, 282)
        Me.pbxAltasVolver.Name = "pbxAltasVolver"
        Me.pbxAltasVolver.Size = New System.Drawing.Size(384, 201)
        Me.pbxAltasVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAltasVolver.TabIndex = 12
        Me.pbxAltasVolver.TabStop = False
        '
        'pbxAltasFeriado
        '
        Me.pbxAltasFeriado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAltasFeriado.BackColor = System.Drawing.Color.Transparent
        Me.pbxAltasFeriado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAltasFeriado.Image = Global.SIA.My.Resources.Resources.btnAltasFeriadoNo
        Me.pbxAltasFeriado.Location = New System.Drawing.Point(57, 282)
        Me.pbxAltasFeriado.Name = "pbxAltasFeriado"
        Me.pbxAltasFeriado.Size = New System.Drawing.Size(384, 201)
        Me.pbxAltasFeriado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAltasFeriado.TabIndex = 11
        Me.pbxAltasFeriado.TabStop = False
        '
        'pbxAltasGrupo
        '
        Me.pbxAltasGrupo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAltasGrupo.BackColor = System.Drawing.Color.Transparent
        Me.pbxAltasGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAltasGrupo.Image = Global.SIA.My.Resources.Resources.btnAltasGrupoNo
        Me.pbxAltasGrupo.Location = New System.Drawing.Point(471, 41)
        Me.pbxAltasGrupo.Name = "pbxAltasGrupo"
        Me.pbxAltasGrupo.Size = New System.Drawing.Size(384, 201)
        Me.pbxAltasGrupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAltasGrupo.TabIndex = 8
        Me.pbxAltasGrupo.TabStop = False
        '
        'pbxAltasCurso
        '
        Me.pbxAltasCurso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAltasCurso.BackColor = System.Drawing.Color.Transparent
        Me.pbxAltasCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAltasCurso.Image = Global.SIA.My.Resources.Resources.btnCursoNo
        Me.pbxAltasCurso.Location = New System.Drawing.Point(57, 41)
        Me.pbxAltasCurso.Name = "pbxAltasCurso"
        Me.pbxAltasCurso.Size = New System.Drawing.Size(384, 201)
        Me.pbxAltasCurso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAltasCurso.TabIndex = 7
        Me.pbxAltasCurso.TabStop = False
        '
        'pbxAltasAlumnos
        '
        Me.pbxAltasAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxAltasAlumnos.BackColor = System.Drawing.Color.Transparent
        Me.pbxAltasAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxAltasAlumnos.Image = Global.SIA.My.Resources.Resources.btnAltasAlumnosNo
        Me.pbxAltasAlumnos.Location = New System.Drawing.Point(890, 41)
        Me.pbxAltasAlumnos.Name = "pbxAltasAlumnos"
        Me.pbxAltasAlumnos.Size = New System.Drawing.Size(384, 201)
        Me.pbxAltasAlumnos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxAltasAlumnos.TabIndex = 10
        Me.pbxAltasAlumnos.TabStop = False
        '
        'gbxPPal
        '
        Me.gbxPPal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxPPal.BackColor = System.Drawing.Color.Transparent
        Me.gbxPPal.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxPPal.Controls.Add(Me.pbxLogo)
        Me.gbxPPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPPal.ForeColor = System.Drawing.Color.White
        Me.gbxPPal.Location = New System.Drawing.Point(12, 219)
        Me.gbxPPal.Name = "gbxPPal"
        Me.gbxPPal.Size = New System.Drawing.Size(1330, 510)
        Me.gbxPPal.TabIndex = 8
        Me.gbxPPal.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxLogo.Image = Global.SIA.My.Resources.Resources.CartelitoT
        Me.pbxLogo.Location = New System.Drawing.Point(392, 168)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(548, 210)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 6
        Me.pbxLogo.TabStop = False
        '
        'gbxConsultas
        '
        Me.gbxConsultas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxConsultas.BackColor = System.Drawing.Color.Transparent
        Me.gbxConsultas.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxConsultas.Controls.Add(Me.pbxConsultasAsistencia)
        Me.gbxConsultas.Controls.Add(Me.pbxConsultasVolver)
        Me.gbxConsultas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxConsultas.ForeColor = System.Drawing.Color.White
        Me.gbxConsultas.Location = New System.Drawing.Point(12, 219)
        Me.gbxConsultas.Name = "gbxConsultas"
        Me.gbxConsultas.Size = New System.Drawing.Size(1330, 510)
        Me.gbxConsultas.TabIndex = 14
        Me.gbxConsultas.TabStop = False
        Me.gbxConsultas.Visible = False
        '
        'pbxConsultasAsistencia
        '
        Me.pbxConsultasAsistencia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxConsultasAsistencia.BackColor = System.Drawing.Color.Transparent
        Me.pbxConsultasAsistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxConsultasAsistencia.Image = Global.SIA.My.Resources.Resources.btnConsultarAsistenciaNo
        Me.pbxConsultasAsistencia.Location = New System.Drawing.Point(57, 41)
        Me.pbxConsultasAsistencia.Name = "pbxConsultasAsistencia"
        Me.pbxConsultasAsistencia.Size = New System.Drawing.Size(384, 201)
        Me.pbxConsultasAsistencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxConsultasAsistencia.TabIndex = 7
        Me.pbxConsultasAsistencia.TabStop = False
        '
        'pbxConsultasVolver
        '
        Me.pbxConsultasVolver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxConsultasVolver.BackColor = System.Drawing.Color.Transparent
        Me.pbxConsultasVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxConsultasVolver.Image = Global.SIA.My.Resources.Resources.btnVolverNo
        Me.pbxConsultasVolver.Location = New System.Drawing.Point(471, 41)
        Me.pbxConsultasVolver.Name = "pbxConsultasVolver"
        Me.pbxConsultasVolver.Size = New System.Drawing.Size(384, 201)
        Me.pbxConsultasVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxConsultasVolver.TabIndex = 12
        Me.pbxConsultasVolver.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 741)
        Me.Controls.Add(Me.gbxPanelSuperior)
        Me.Controls.Add(Me.gbxAltas)
        Me.Controls.Add(Me.gbxPPal)
        Me.Controls.Add(Me.gbxConsultas)
        Me.Controls.Add(Me.gbxManejo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbxPanelSuperior.ResumeLayout(False)
        CType(Me.pbxAltas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxManejo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxManejo.ResumeLayout(False)
        CType(Me.pbxManejoMovAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxManejoVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxManejoAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxManejoAsignarHuellas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxManejoHorarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxAltas.ResumeLayout(False)
        CType(Me.pbxSistema, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAltasVolver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAltasFeriado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAltasGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAltasCurso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxAltasAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPPal.ResumeLayout(False)
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxConsultas.ResumeLayout(False)
        CType(Me.pbxConsultasAsistencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxConsultasVolver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPanelSuperior As System.Windows.Forms.GroupBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxConsultas As System.Windows.Forms.PictureBox
    Friend WithEvents pbxManejo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents gbxPPal As System.Windows.Forms.GroupBox
    Friend WithEvents pbxAltas As System.Windows.Forms.PictureBox
    Friend WithEvents gbxAltas As System.Windows.Forms.GroupBox
    Friend WithEvents pbxAltasCurso As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAltasGrupo As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAltasVolver As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAltasFeriado As System.Windows.Forms.PictureBox
    Friend WithEvents pbxAltasAlumnos As System.Windows.Forms.PictureBox
    Friend WithEvents gbxManejo As System.Windows.Forms.GroupBox
    Friend WithEvents pbxManejoVolver As System.Windows.Forms.PictureBox
    Friend WithEvents pbxManejoAsistencia As System.Windows.Forms.PictureBox
    Friend WithEvents pbxManejoAsignarHuellas As System.Windows.Forms.PictureBox
    Friend WithEvents pbxManejoHorarios As System.Windows.Forms.PictureBox
    Friend WithEvents pbxManejoMovAlumnos As System.Windows.Forms.PictureBox
    Friend WithEvents gbxConsultas As System.Windows.Forms.GroupBox
    Friend WithEvents pbxConsultasAsistencia As System.Windows.Forms.PictureBox
    Friend WithEvents pbxConsultasVolver As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSistema As System.Windows.Forms.PictureBox
End Class
