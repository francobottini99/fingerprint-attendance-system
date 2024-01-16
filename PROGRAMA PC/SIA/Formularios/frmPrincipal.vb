Public Class frmPrincipal

    Private Sub pbxAltas_GotFocus(sender As Object, e As EventArgs) Handles pbxAltas.GotFocus
        If gbxAltas.Visible = False Then
            pbxAltas.Image = SIA.My.Resources.btnAltasSi
        End If
    End Sub

    Private Sub pbxAltas_LostFocus(sender As Object, e As EventArgs) Handles pbxAltas.LostFocus
        If gbxAltas.Visible = False Then
            pbxAltas.Image = SIA.My.Resources.btnAltasNo
        End If
    End Sub

    Private Sub pbxAltas_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltas.MouseEnter
        If gbxAltas.Visible = False Then
            pbxAltas.Image = SIA.My.Resources.btnAltasSi
        End If
    End Sub

    Private Sub pbxAltas_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltas.MouseLeave
        If gbxAltas.Visible = False Then
            pbxAltas.Image = SIA.My.Resources.btnAltasNo
        End If
    End Sub

    Private Sub pbxSalir_GotFocus(sender As Object, e As EventArgs) Handles pbxSalir.GotFocus
        pbxSalir.Image = SIA.My.Resources.btnSalirSi1
    End Sub

    Private Sub pbxSalir_LostFocus(sender As Object, e As EventArgs) Handles pbxSalir.LostFocus
        pbxSalir.Image = SIA.My.Resources.btnSalirNo1
    End Sub

    Private Sub pbxSalir_MouseEnter(sender As Object, e As EventArgs) Handles pbxSalir.MouseEnter
        pbxSalir.Image = SIA.My.Resources.btnSalirSi1
    End Sub

    Private Sub pbxSalir_MouseLeave(sender As Object, e As EventArgs) Handles pbxSalir.MouseLeave
        pbxSalir.Image = SIA.My.Resources.btnSalirNo1
    End Sub

    Private Sub pbxConsultas_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultas.GotFocus
        If gbxConsultas.Visible = False Then
            pbxConsultas.Image = SIA.My.Resources.btnConsultasSi1
        End If
    End Sub

    Private Sub pbxConsultas_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultas.LostFocus
        If gbxConsultas.Visible = False Then
            pbxConsultas.Image = SIA.My.Resources.btnConsultasNo1
        End If
    End Sub

    Private Sub pbxConsultas_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultas.MouseEnter
        If gbxConsultas.Visible = False Then
            pbxConsultas.Image = SIA.My.Resources.btnConsultasSi1
        End If
    End Sub

    Private Sub pbxConsultas_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultas.MouseLeave
        If gbxConsultas.Visible = False Then
            pbxConsultas.Image = SIA.My.Resources.btnConsultasNo1
        End If
    End Sub

    Private Sub pbxManejo_GotFocus(sender As Object, e As EventArgs) Handles pbxManejo.GotFocus
        If gbxManejo.Visible = False Then
            pbxManejo.Image = SIA.My.Resources.btnManejoSi1
        End If
    End Sub

    Private Sub pbxManejo_LostFocus(sender As Object, e As EventArgs) Handles pbxManejo.LostFocus
        If gbxManejo.Visible = False Then
            pbxManejo.Image = SIA.My.Resources.btnManejoNo1
        End If
    End Sub

    Private Sub pbxManejo_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejo.MouseEnter
        If gbxManejo.Visible = False Then
            pbxManejo.Image = SIA.My.Resources.btnManejoSi1
        End If
    End Sub

    Private Sub pbxManejo_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejo.MouseLeave
        If gbxManejo.Visible = False Then
            pbxManejo.Image = SIA.My.Resources.btnManejoNo1
        End If
    End Sub

    Private Sub pbxSistema_GotFocus(sender As Object, e As EventArgs) Handles pbxSistema.GotFocus
        pbxSistema.Image = SIA.My.Resources.btnSistemaSi
    End Sub

    Private Sub pbxSistema_LostFocus(sender As Object, e As EventArgs) Handles pbxSistema.LostFocus
        pbxSistema.Image = SIA.My.Resources.btnSistemaNo
    End Sub

    Private Sub pbxSistema_MouseEnter(sender As Object, e As EventArgs) Handles pbxSistema.MouseEnter
        pbxSistema.Image = SIA.My.Resources.btnSistemaSi
    End Sub

    Private Sub pbxSistema_MouseLeave(sender As Object, e As EventArgs) Handles pbxSistema.MouseLeave
        pbxSistema.Image = SIA.My.Resources.btnSistemaNo
    End Sub

    Private Sub pbxAltasAlumnos_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasAlumnos.GotFocus
        pbxAltasAlumnos.Image = SIA.My.Resources.btnAltasAlumnosSi
    End Sub

    Private Sub pbxAltasAlumnos_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasAlumnos.LostFocus
        pbxAltasAlumnos.Image = SIA.My.Resources.btnAltasAlumnosNo
    End Sub

    Private Sub pbxAltasAlumnos_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasAlumnos.MouseEnter
        pbxAltasAlumnos.Image = SIA.My.Resources.btnAltasAlumnosSi
    End Sub

    Private Sub pbxAltasAlumnos_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasAlumnos.MouseLeave
        pbxAltasAlumnos.Image = SIA.My.Resources.btnAltasAlumnosNo
    End Sub

    Private Sub pbxAltasGrupo_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasGrupo.GotFocus
        pbxAltasGrupo.Image = SIA.My.Resources.btnCursoSi
    End Sub

    Private Sub pbxAltasGrupo_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasGrupo.LostFocus
        pbxAltasGrupo.Image = SIA.My.Resources.btnAltasGrupoNo
    End Sub

    Private Sub pbxAltasGrupo_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasGrupo.MouseEnter
        pbxAltasGrupo.Image = SIA.My.Resources.btnAltasGrupoSi
    End Sub

    Private Sub pbxAltasGrupo_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasGrupo.MouseLeave
        pbxAltasGrupo.Image = SIA.My.Resources.btnAltasGrupoNo
    End Sub

    Private Sub pbxAltasCurso_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasCurso.GotFocus
        pbxAltasCurso.Image = SIA.My.Resources.btnAltasGrupoSi
    End Sub

    Private Sub pbxAltasCurso_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasCurso.LostFocus
        pbxAltasCurso.Image = SIA.My.Resources.btnCursoNo
    End Sub

    Private Sub pbxAltasCurso_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasCurso.MouseEnter
        pbxAltasCurso.Image = SIA.My.Resources.btnCursoSi
    End Sub

    Private Sub pbxAltasCurso_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasCurso.MouseLeave
        pbxAltasCurso.Image = SIA.My.Resources.btnCursoNo
    End Sub

    Private Sub pbxAltasVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasVolver.GotFocus
        pbxAltasVolver.Image = SIA.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxAltasVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasVolver.LostFocus
        pbxAltasVolver.Image = SIA.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxAltasVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasVolver.MouseEnter
        pbxAltasVolver.Image = SIA.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxAltasVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasVolver.MouseLeave
        pbxAltasVolver.Image = SIA.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxFeriado_GotFocus(sender As Object, e As EventArgs) Handles pbxAltasFeriado.GotFocus
        pbxAltasFeriado.Image = SIA.My.Resources.btnAltasFeriadoSi
    End Sub

    Private Sub pbxFeriado_LostFocus(sender As Object, e As EventArgs) Handles pbxAltasFeriado.LostFocus
        pbxAltasFeriado.Image = SIA.My.Resources.btnAltasFeriadoNo
    End Sub

    Private Sub pbxFeriado_MouseEnter(sender As Object, e As EventArgs) Handles pbxAltasFeriado.MouseEnter
        pbxAltasFeriado.Image = SIA.My.Resources.btnAltasFeriadoSi
    End Sub

    Private Sub pbxFeriado_MouseLeave(sender As Object, e As EventArgs) Handles pbxAltasFeriado.MouseLeave
        pbxAltasFeriado.Image = SIA.My.Resources.btnAltasFeriadoNo
    End Sub

    Private Sub pbxManejoHorarios_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoHorarios.GotFocus
        pbxManejoHorarios.Image = SIA.My.Resources.btnManejoHorariosSi
    End Sub

    Private Sub pbxManejoHorarios_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoHorarios.LostFocus
        pbxManejoHorarios.Image = SIA.My.Resources.btnManejoHorariosNo
    End Sub

    Private Sub pbxManejoHorarios_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoHorarios.MouseEnter
        pbxManejoHorarios.Image = SIA.My.Resources.btnManejoHorariosSi
    End Sub

    Private Sub pbxManejoHorarios_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoHorarios.MouseLeave
        pbxManejoHorarios.Image = SIA.My.Resources.btnManejoHorariosNo
    End Sub

    Private Sub pbxManejoAsignarHuellas_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoAsignarHuellas.GotFocus
        pbxManejoAsignarHuellas.Image = SIA.My.Resources.btnManejoAsignarHuellasSi
    End Sub

    Private Sub pbxManejoAsignarHuellas_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoAsignarHuellas.LostFocus
        pbxManejoAsignarHuellas.Image = SIA.My.Resources.btnManejoAsignarHuellasNo
    End Sub

    Private Sub pbxManejoAsignarHuellas_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoAsignarHuellas.MouseEnter
        pbxManejoAsignarHuellas.Image = SIA.My.Resources.btnManejoAsignarHuellasSi
    End Sub

    Private Sub pbxManejoAsignarHuellas_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoAsignarHuellas.MouseLeave
        pbxManejoAsignarHuellas.Image = SIA.My.Resources.btnManejoAsignarHuellasNo
    End Sub

    Private Sub pbxManejoAsistencia_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoAsistencia.GotFocus
        pbxManejoAsistencia.Image = SIA.My.Resources.btnManejoAsistenciaSi
    End Sub

    Private Sub pbxManejoAsistencia_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoAsistencia.LostFocus
        pbxManejoAsistencia.Image = SIA.My.Resources.btnManejoAsistenciaNo
    End Sub

    Private Sub pbxManejoAsistencia_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoAsistencia.MouseEnter
        pbxManejoAsistencia.Image = SIA.My.Resources.btnManejoAsistenciaSi
    End Sub

    Private Sub pbxManejoAsistencia_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoAsistencia.MouseLeave
        pbxManejoAsistencia.Image = SIA.My.Resources.btnManejoAsistenciaNo
    End Sub

    'Private Sub pbxManejoRetiroAnticipado_GotFocus(sender As Object, e As EventArgs)
    '    pbxManejoRetiroAnticipado.Image = SIA.My.Resources.btnManejoRetiroAnticipadoSi()
    'End Sub

    'Private Sub pbxManejoRetiroAnticipado_LostFocus(sender As Object, e As EventArgs)
    '    pbxManejoRetiroAnticipado.Image = SIA.My.Resources.btnManejoRetiroAnticipadoNo
    'End Sub

    'Private Sub pbxManejoRetiroAnticipado_MouseEnter(sender As Object, e As EventArgs)
    '    pbxManejoRetiroAnticipado.Image = SIA.My.Resources.btnManejoRetiroAnticipadoSi
    'End Sub

    'Private Sub pbxManejoRetiroAnticipado_MouseLeave(sender As Object, e As EventArgs)
    '    pbxManejoRetiroAnticipado.Image = SIA.My.Resources.btnManejoRetiroAnticipadoNo
    'End Sub

    Private Sub pbxManejoMovAlumnos_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoMovAlumnos.GotFocus
        pbxManejoMovAlumnos.Image = SIA.My.Resources.btnManejoMovAlumnosSi
    End Sub

    Private Sub pbxManejoMovAlumnos_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoMovAlumnos.LostFocus
        pbxManejoMovAlumnos.Image = SIA.My.Resources.btnManejoMovAlumnosNo
    End Sub

    Private Sub pbxManejoMovAlumnos_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoMovAlumnos.MouseEnter
        pbxManejoMovAlumnos.Image = SIA.My.Resources.btnManejoMovAlumnosSi
    End Sub

    Private Sub pbxManejoMovAlumnos_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoMovAlumnos.MouseLeave
        pbxManejoMovAlumnos.Image = SIA.My.Resources.btnManejoMovAlumnosNo
    End Sub

    Private Sub pbxManejoVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxManejoVolver.GotFocus
        pbxManejoVolver.Image = SIA.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxManejoVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxManejoVolver.LostFocus
        pbxManejoVolver.Image = SIA.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxManejoVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxManejoVolver.MouseEnter
        pbxManejoVolver.Image = SIA.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxManejoVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxManejoVolver.MouseLeave
        pbxManejoVolver.Image = SIA.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxConsultasVolver_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultasVolver.GotFocus
        pbxConsultasVolver.Image = SIA.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxConsultasVolver_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultasVolver.LostFocus
        pbxConsultasVolver.Image = SIA.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxConsultasVolver_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultasVolver.MouseEnter
        pbxConsultasVolver.Image = SIA.My.Resources.btnVolverSi
    End Sub

    Private Sub pbxConsultasVolver_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultasVolver.MouseLeave
        pbxConsultasVolver.Image = SIA.My.Resources.btnVolverNo
    End Sub

    Private Sub pbxConsultasAsistencia_GotFocus(sender As Object, e As EventArgs) Handles pbxConsultasAsistencia.GotFocus
        pbxConsultasAsistencia.Image = SIA.My.Resources.btnConsultarAsistenciaSi
    End Sub

    Private Sub pbxConsultasAsistencia_LostFocus(sender As Object, e As EventArgs) Handles pbxConsultasAsistencia.LostFocus
        pbxConsultasAsistencia.Image = SIA.My.Resources.btnConsultarAsistenciaNo
    End Sub

    Private Sub pbxConsultasAsistencia_MouseEnter(sender As Object, e As EventArgs) Handles pbxConsultasAsistencia.MouseEnter
        pbxConsultasAsistencia.Image = SIA.My.Resources.btnConsultarAsistenciaSi
    End Sub

    Private Sub pbxConsultasAsistencia_MouseLeave(sender As Object, e As EventArgs) Handles pbxConsultasAsistencia.MouseLeave
        pbxConsultasAsistencia.Image = SIA.My.Resources.btnConsultarAsistenciaNo
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Ancho, Alto As Double

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia"

        Ancho = 1366 / Me.Width
        Alto = 768 / Me.Height

        Resolucion(Ancho, Alto)
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Dim G As New GrabaDatos

        G.Grabar("Lectores", "NoImagen", "sistema_asistencia.modEstadoLectorReseteo")

        End
    End Sub

    Private Sub Ocultar()
        gbxAltas.Visible = False
        gbxPPal.Visible = False
        gbxManejo.Visible = False
        gbxConsultas.Visible = False

        pbxAltas.Image = SIA.My.Resources.btnAltasNo
        pbxManejo.Image = SIA.My.Resources.btnManejoNo1
        pbxConsultas.Image = SIA.My.Resources.btnConsultasNo1
    End Sub

    Private Sub pbxAltas_Click(sender As Object, e As EventArgs) Handles pbxAltas.Click
        Ocultar()

        gbxAltas.Visible = True

        pbxAltas.Image = SIA.My.Resources.btnAltasSi
    End Sub

    Private Sub pbxConsultas_Click(sender As Object, e As EventArgs) Handles pbxConsultas.Click
        Ocultar()

        gbxConsultas.Visible = True

        pbxConsultas.Image = SIA.My.Resources.btnConsultasSi1
    End Sub

    Private Sub pbxVolver_Click(sender As Object, e As EventArgs) Handles pbxAltasVolver.Click, pbxManejoVolver.Click, pbxConsultasVolver.Click
        Ocultar()

        gbxPPal.Visible = True
    End Sub

    Private Sub pbxManejo_Click(sender As Object, e As EventArgs) Handles pbxManejo.Click
        Ocultar()

        gbxManejo.Visible = True

        pbxManejo.Image = SIA.My.Resources.btnManejoSi1
    End Sub

    Private Sub Resolucion(Ancho As Double, Alto As Double)

        'AJUSTAR TAMAÑO BOTONES PANEL PPAL Y LOGO
        pbxLogo.Height = pbxLogo.Height / Alto
        pbxLogo.Width = pbxLogo.Width / Ancho
        pbxAltas.Width = pbxAltas.Width / Ancho
        pbxAltas.Height = pbxAltas.Height / Alto
        pbxManejo.Width = pbxManejo.Width / Ancho
        pbxManejo.Height = pbxManejo.Height / Alto
        pbxConsultas.Width = pbxConsultas.Width / Ancho
        pbxConsultas.Height = pbxConsultas.Height / Alto
        pbxSalir.Width = pbxSalir.Width / Ancho
        pbxSalir.Height = pbxSalir.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL ALTAS
        pbxAltasCurso.Width = pbxAltasCurso.Width / Ancho
        pbxAltasCurso.Height = pbxAltasCurso.Height / Alto
        pbxAltasGrupo.Width = pbxAltasGrupo.Width / Ancho
        pbxAltasGrupo.Height = pbxAltasGrupo.Height / Alto
        pbxAltasAlumnos.Width = pbxAltasAlumnos.Width / Ancho
        pbxAltasAlumnos.Height = pbxAltasAlumnos.Height / Alto
        pbxAltasFeriado.Width = pbxAltasFeriado.Width / Ancho
        pbxAltasFeriado.Height = pbxAltasFeriado.Height / Alto
        pbxSistema.Width = pbxSistema.Width / Ancho
        pbxSistema.Height = pbxSistema.Height / Alto
        pbxAltasVolver.Width = pbxAltasVolver.Width / Ancho
        pbxAltasVolver.Height = pbxAltasVolver.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL MANEJO
        pbxManejoHorarios.Width = pbxManejoHorarios.Width / Ancho
        pbxManejoHorarios.Height = pbxManejoHorarios.Height / Alto
        pbxManejoAsistencia.Width = pbxManejoAsistencia.Width / Ancho
        pbxManejoAsistencia.Height = pbxManejoAsistencia.Height / Alto
        pbxManejoAsignarHuellas.Width = pbxManejoAsignarHuellas.Width / Ancho
        pbxManejoAsignarHuellas.Height = pbxManejoAsignarHuellas.Height / Alto
        'pbxManejoRetiroAnticipado.Width = pbxManejoRetiroAnticipado.Width / Ancho
        'pbxManejoRetiroAnticipado.Height = pbxManejoRetiroAnticipado.Height / Alto
        pbxManejoMovAlumnos.Width = pbxManejoMovAlumnos.Width / Ancho
        pbxManejoMovAlumnos.Height = pbxManejoMovAlumnos.Height / Alto
        pbxManejoVolver.Width = pbxManejoVolver.Width / Ancho
        pbxManejoVolver.Height = pbxManejoVolver.Height / Alto

        'AJUSTAR TAMAÑO BOTONES PANEL CONSULTAS
        pbxConsultasAsistencia.Width = pbxConsultasAsistencia.Width / Ancho
        pbxConsultasAsistencia.Height = pbxConsultasAsistencia.Height / Alto
        pbxConsultasVolver.Width = pbxConsultasVolver.Width / Ancho
        pbxConsultasVolver.Height = pbxConsultasVolver.Height / Alto

        'CENTRAR BOTONES ANCHO PANEL PPAL
        pbxAltas.Top = (gbxPanelSuperior.Height - pbxAltas.Height) / 2
        pbxManejo.Top = (gbxPanelSuperior.Height - pbxManejo.Height) / 2
        pbxConsultas.Top = (gbxPanelSuperior.Height - pbxConsultas.Height) / 2
        pbxSalir.Top = (gbxPanelSuperior.Height - pbxSalir.Height) / 2

        'CENTRAR BOTONES ALTO PANEL PPAL
        Dim seParador As Double
        Dim seParador1 As Double

        seParador = gbxPanelSuperior.Width - (pbxAltas.Width * 4)
        seParador = seParador / 5.5

        pbxAltas.Left = seParador + 5
        pbxManejo.Left = pbxAltas.Left + pbxAltas.Width + seParador
        pbxConsultas.Left = pbxManejo.Left + pbxManejo.Width + seParador
        pbxSalir.Left = pbxConsultas.Left + pbxConsultas.Width + seParador

        'CENTRAR LOGO SITRABO
        pbxLogo.Top = (gbxPPal.Height - pbxLogo.Height) / 2
        pbxLogo.Left = (gbxPPal.Width - pbxLogo.Width) / 2

        'CENTRAR BOTONES A LO ANCHO PANEL ALTAS
        seParador = gbxAltas.Height - (pbxAltasCurso.Height * 2)
        seParador = seParador / 3.5
        seParador1 = gbxAltas.Width - (pbxAltasCurso.Width * 3)
        seParador1 = seParador1 / 5

        pbxAltasCurso.Top = seParador + 10
        pbxAltasCurso.Left = seParador1 + 15

        pbxAltasGrupo.Left = pbxAltasCurso.Left + pbxAltasCurso.Width + seParador1
        pbxAltasGrupo.Top = seParador + 10

        pbxAltasAlumnos.Left = pbxAltasGrupo.Left + pbxAltasGrupo.Width + seParador1
        pbxAltasAlumnos.Top = seParador + 10
        '-----------------------------------------------------------------------------------
        pbxAltasFeriado.Top = pbxAltasCurso.Top + pbxAltasCurso.Height + seParador
        pbxAltasFeriado.Left = seParador1 + 15

        pbxAltasVolver.Left = pbxAltasFeriado.Left + pbxAltasFeriado.Width + seParador1
        pbxAltasVolver.Top = pbxAltasCurso.Top + pbxAltasCurso.Height + seParador

        'CENTRAR BOTONES A LO ANCHO PANEL MANEJO
        seParador = gbxManejo.Height - (pbxManejoHorarios.Height * 2)
        seParador = seParador / 3.5
        seParador1 = gbxManejo.Width - (pbxManejoHorarios.Width * 3)
        seParador1 = seParador1 / 5

        pbxManejoHorarios.Top = seParador + 10
        pbxManejoHorarios.Left = seParador1 + 15

        pbxManejoAsignarHuellas.Left = pbxManejoHorarios.Left + pbxManejoHorarios.Width + seParador1
        pbxManejoAsignarHuellas.Top = seParador + 10

        pbxManejoAsistencia.Left = pbxManejoAsignarHuellas.Left + pbxManejoAsignarHuellas.Width + seParador1
        pbxManejoAsistencia.Top = seParador + 10
        '-----------------------------------------------------------------------------------
        'pbxManejoRetiroAnticipado.Top = pbxManejoHorarios.Top + pbxManejoHorarios.Height + seParador
        'pbxManejoRetiroAnticipado.Left = seParador1 + 15

        pbxManejoMovAlumnos.Left = seParador1 + 15
        pbxManejoMovAlumnos.Top = pbxManejoHorarios.Top + pbxManejoHorarios.Height + seParador

        pbxSistema.Left = pbxManejoMovAlumnos.Left + pbxManejoMovAlumnos.Width + seParador1
        pbxSistema.Top = pbxManejoHorarios.Top + pbxManejoHorarios.Height + seParador

        pbxManejoVolver.Left = pbxSistema.Left + pbxSistema.Width + seParador1
        pbxManejoVolver.Top = pbxManejoHorarios.Top + pbxManejoHorarios.Height + seParador

        'CENTRAR BOTONES A LO ANCHO PANEL CONSULTAS
        seParador = gbxConsultas.Height - (pbxConsultasAsistencia.Height * 2)
        seParador = seParador / 3.5
        seParador1 = gbxConsultas.Width - (pbxConsultasAsistencia.Width * 3)
        seParador1 = seParador1 / 5

        pbxConsultasAsistencia.Top = seParador + 10
        pbxConsultasAsistencia.Left = seParador1 + 15

        pbxConsultasVolver.Left = pbxConsultasAsistencia.Left + pbxConsultasAsistencia.Width + seParador1
        pbxConsultasVolver.Top = seParador + 10
    End Sub

    Private Sub pbxAltasCurso_Click(sender As Object, e As EventArgs) Handles pbxAltasCurso.Click
        frmAltasCurso.Show()
    End Sub

    Private Sub pbxAltasGrupo_Click(sender As Object, e As EventArgs) Handles pbxAltasGrupo.Click
        frmAltasGrupo.Show()
    End Sub

    Private Sub pbxAltasAlumnos_Click(sender As Object, e As EventArgs) Handles pbxAltasAlumnos.Click
        frmAltasAlumnos.Show()
    End Sub

    Private Sub pbxAltasFeriado_Click(sender As Object, e As EventArgs) Handles pbxAltasFeriado.Click
        frmAltasFeriados.Show()
    End Sub

    Private Sub pbxManejoHorarios_Click(sender As Object, e As EventArgs) Handles pbxManejoHorarios.Click
        frmManejoHorarios.Show()
    End Sub

    Private Sub pbxManejoAsistencia_Click(sender As Object, e As EventArgs) Handles pbxManejoAsistencia.Click
        frmManejoAsistenciaManual.Show()
    End Sub

    Private Sub pbxSistema_Click(sender As Object, e As EventArgs) Handles pbxSistema.Click
        frmSistema.Show()
    End Sub

    Private Sub pbxManejoAsignarHuellas_Click(sender As Object, e As EventArgs) Handles pbxManejoAsignarHuellas.Click
        frmManejoHuellas.Show()
    End Sub

    Private Sub pbxConsultasAsistencia_Click(sender As Object, e As EventArgs) Handles pbxConsultasAsistencia.Click
        frmConsAsistencias.Show()
    End Sub
End Class