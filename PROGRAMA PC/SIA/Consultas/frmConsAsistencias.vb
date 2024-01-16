Imports MySql.Data.MySqlClient

Public Class frmConsAsistencias
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

    Private Sub pbxFiltro_GotFocus(sender As Object, e As EventArgs) Handles pbxFiltro.GotFocus
        pbxFiltro.Image = SIA.My.Resources.btnFiltrarSi
    End Sub

    Private Sub pbxFiltro_LostFocus(sender As Object, e As EventArgs) Handles pbxFiltro.LostFocus
        pbxFiltro.Image = SIA.My.Resources.btnFiltrarNo
    End Sub

    Private Sub pbxFiltro_MouseEnter(sender As Object, e As EventArgs) Handles pbxFiltro.MouseEnter
        pbxFiltro.Image = SIA.My.Resources.btnFiltrarSi
    End Sub

    Private Sub pbxFiltro_MouseLeave(sender As Object, e As EventArgs) Handles pbxFiltro.MouseLeave
        pbxFiltro.Image = SIA.My.Resources.btnFiltrarNo
    End Sub

    Private Sub pbxImprimir_GotFocus(sender As Object, e As EventArgs) Handles pbxImprimir.GotFocus
        pbxImprimir.Image = SIA.My.Resources.btnImprimirSi
    End Sub

    Private Sub pbxImprimir_LostFocus(sender As Object, e As EventArgs) Handles pbxImprimir.LostFocus
        pbxImprimir.Image = SIA.My.Resources.btnImprimirNo
    End Sub

    Private Sub pbxImprimir_MouseEnter(sender As Object, e As EventArgs) Handles pbxImprimir.MouseEnter
        pbxImprimir.Image = SIA.My.Resources.btnImprimirSi
    End Sub

    Private Sub pbxImprimir_MouseLeave(sender As Object, e As EventArgs) Handles pbxImprimir.MouseLeave
        pbxImprimir.Image = SIA.My.Resources.btnImprimirNo
    End Sub

    Private Sub frmConsAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Consultar Planillas de Asistencia"

    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub pbxFiltro_Click(sender As Object, e As EventArgs) Handles pbxFiltro.Click
        Dim _Dt As New DataTable
        Dim _Dv As New DataView
        Dim Cadena As String = ""

        If txtFecD.Text <> "" Then
            Dim Fd As Date
            Fd = Format(CDate(txtFecD.Text), "yyyy/MM/dd")
            If Cadena = "" Then
                Cadena = "Asistencia.Fecha >= " & Fd
            Else
                Cadena = Cadena & " AND Asistencia.Fecha >= " & Fd
            End If
        End If
        If txtFecH.Text <> "" Then
            Dim Fh As Date
            Fh = Format(CDate(txtFecH.Text), "yyyy/MM/dd")
            If Cadena = "" Then
                Cadena = "Asistencia.Fecha <= " & Fh
            Else
                Cadena = Cadena & " AND Asistencia.Fecha <= " & Fh
            End If
        End If
        If txtAlumno.Text <> "" Then
            If Cadena = "" Then
                Cadena = "Alumnos.Nombre like '%" & txtAlumno.Text & "%'"
            Else
                Cadena = Cadena & " AND Alumnos.Nombre like '%" & txtAlumno.Text & "%'"
            End If
        End If
        If cbxAsistencia.Text <> "" Then
            If Cadena = "" Then
                Cadena = "Asistencia.Asistencia = '" & cbxAsistencia.Text & "'"
            Else
                Cadena = Cadena & " AND Asistencia.Asistencia = '" & cbxAsistencia.Text & "'"
            End If
        End If
        If cbxCurso.Text <> "" Then
            If Cadena = "" Then
                Cadena = "Curso.Año = " & CInt(cbxCurso.Text)
            Else
                Cadena = Cadena & " AND Curso.Año = " & CInt(cbxCurso.Text)
            End If
        End If
        If cbxDivision.Text <> "" Then
            If Cadena = "" Then
                Cadena = "Curso.Division = '" & cbxDivision.Text & "'"
            Else
                Cadena = Cadena & " AND Curso.Division = '" & cbxDivision.Text & "'"
            End If
        End If
        If cbxSexo.Text <> "" Then
            If Cadena = "" Then
                Cadena = "Alumnos.Sexo = '" & cbxSexo.Text & "'"
            Else
                Cadena = Cadena & " AND Alumnos.Sexo = '" & cbxSexo.Text & "'"
            End If
        End If
        If cbxTurno.Text <> "" Then
            If Cadena = "" Then
                Cadena = "Horarios.Turno = '" & cbxTurno.Text & "'"
            Else
                Cadena = Cadena & " AND Horarios.Turno = '" & cbxTurno.Text & "'"
            End If
        End If
        Cadena = Cadena & " AND Alumnos.CicloLectivo_idCiclo_Lectivo = " & frmIngresoSIA.txtCicloID.Text

        If Cadena <> "" Then
            Dim Filtro As String = ""
            Filtro = Filtro & "SELECT Alumnos.idAlumnos, Alumnos.Nombre, Alumnos.Sexo, Alumnos.idHuella_Digital,"
            Filtro = Filtro & " Alumnos.Modelo_Huella, Alumnos.Estado, Alumnos.Observaciones AlumObserv,"
            Filtro = Filtro & " Alumnos.CicloLectivo_idCiclo_Lectivo, Asistencia.idAsistencia, Asistencia.Fecha,"
            Filtro = Filtro & " Asistencia.Asistencia, Asistencia.HoraIngreso, Asistencia.RetiroAnticipado,"
            Filtro = Filtro & " Asistencia.Justificada, Asistencia.Observaciones AsisObserv, Curso.idCurso, Curso.Año,"
            Filtro = Filtro & " Curso.Division, Horarios.idHorarios, Horarios.Dia, Horarios.Turno, Horarios.Entrada,"
            Filtro = Filtro & " Horarios.Tipo FROM Alumnos JOIN Asistencia ON Alumnos.idAlumnos = Asistencia.Alumnos_idAlumnos"
            Filtro = Filtro & " JOIN Grupo ON Grupo.idGrupo = Alumnos.Grupo_idGrupo JOIN Curso ON Curso.idCurso ="
            Filtro = Filtro & " Grupo.Curso_idCurso JOIN Horarios ON Horarios.idHorarios = Asistencia.Horarios_idHorarios WHERE "
            Filtro = Filtro & Cadena

            BDcnn()
            Dim _Da As New MySqlDataAdapter(Filtro, _cX)
            BDxxx()

            _Da.Fill(_Dt)

            dgvAsistencia.DataSource = _Dt
            dgvAsistencia.ColumnHeadersVisible = False
            dgvAsistencia.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)
            dgvAsistencia.DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)
            dgvAsistencia.AlternatingRowsDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)
            'dgvAsistencia.Columns("idAlumnos").Visible = False
            'dgvAsistencia.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'dgvAsistencia.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgvAsistencia.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgvAsistencia.Columns("TotalClases").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAsistencia.Columns("Presentes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAsistencia.Columns("Tarde").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAsistencia.Columns("Ausentes").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAsistencia.Columns("FaltasJust").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAsistencia.Columns("PorcAsis").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'dgvAsistencia.Columns("Alumno").Width = 350
            'dgvAsistencia.Columns("Año").Width = 80
            'dgvAsistencia.Columns("Division").Width = 80
            'dgvAsistencia.Columns("TotalClases").Width = 80
            'dgvAsistencia.Columns("Tarde").Width = 80
            'dgvAsistencia.Columns("FaltasJust").Width = 80
            'dgvAsistencia.Columns("PorcAsis").Width = 100
            'dgvAsistencia.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            'dgvAsistencia.Sort(dgvAsistencia.Columns("Alumno"), System.ComponentModel.ListSortDirection.Ascending)

        Else
            MsgBox("Error: No se ingresaron parámetros para filtrar !", vbInformation, "Servico de Alertas")
        End If

    End Sub

    Private Sub pbxImprimir_Click(sender As Object, e As EventArgs) Handles pbxImprimir.Click

    End Sub
End Class