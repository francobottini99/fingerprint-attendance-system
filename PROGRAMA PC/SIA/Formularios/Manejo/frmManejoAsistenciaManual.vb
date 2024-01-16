Public Class frmManejoAsistenciaManual
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

    Private Sub pbxCancelar_GotFocus(sender As Object, e As EventArgs) Handles pbxCancelar.GotFocus
        pbxCancelar.Image = SIA.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelar_LostFocus(sender As Object, e As EventArgs) Handles pbxCancelar.LostFocus
        pbxCancelar.Image = SIA.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxCancelar_MouseEnter(sender As Object, e As EventArgs) Handles pbxCancelar.MouseEnter
        pbxCancelar.Image = SIA.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelar_MouseLeave(sender As Object, e As EventArgs) Handles pbxCancelar.MouseLeave
        pbxCancelar.Image = SIA.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxGuardar_GotFocus(sender As Object, e As EventArgs) Handles pbxGuardar.GotFocus
        pbxGuardar.Image = SIA.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardar_LostFocus(sender As Object, e As EventArgs) Handles pbxGuardar.LostFocus
        pbxGuardar.Image = SIA.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxGuardar_MouseEnter(sender As Object, e As EventArgs) Handles pbxGuardar.MouseEnter
        pbxGuardar.Image = SIA.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardar_MouseLeave(sender As Object, e As EventArgs) Handles pbxGuardar.MouseLeave
        pbxGuardar.Image = SIA.My.Resources.btnGuardarNo
    End Sub

    Private Sub frmManejoAsistenciaManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Manejo Asistencia Manual"

        mtcFecha.MaxDate = Date.Now.Date
        mtcFecha.MinDate = New DateTime(DateTime.Today.Year, 1, 1)
        Dim Fecha As Date = New DateTime(DateTime.Today.Year, 1, 1)

        LimpiarDetalles()
    End Sub

    Private Sub CargarCursosCBX()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        cbxCurso.Items.Clear()

        _Dt = _Ver.verFeriado_Paro_Fecha(CDate(mtcFecha.SelectionRange.Start.ToShortDateString()))

        If _Dt.Rows.Count < 1 Then
            _Dt = _Ver.consHorarios_Grupo_Curso

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("Día") = StrConv(New System.Globalization.CultureInfo("Es-Es").DateTimeFormat.GetDayName(CDate(txtFechaSeleccionada.Text).DayOfWeek), VbStrConv.ProperCase) And cbxTurno.Text = _Dr("Trn") Then
                    cbxCurso.Items.Add(_Dr("Año") & "° " & """" & _Dr("Divs") & """")
                End If
            Next
        End If
    End Sub

    Private Sub LimpiarDetalles()
        lblFecha.Text = "-"
        lblDia.Text = "-"
        lblTurno.Text = "-"
        lblIngreso.Text = "-"
        lblCurso.Text = "-"
        lblGrupo.Text = "-"
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub cbxCurso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCurso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            cbxTurno.SelectionLength = Len(cbxTurno.Text)
            cbxTurno.Select()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cbxTurno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTurno.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnCargar.Select()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim X As Integer

        Dim Fecha As Date = mtcFecha.SelectionRange.Start.ToShortDateString()

        If txtFechaSeleccionada.Text = "" Then
            MsgBox("Error: Selecciona la Fecha a la que cargar asistencia... !", vbInformation, "Servico de Alertas")
        Else
            If Fecha.DayOfWeek = DayOfWeek.Saturday Or Fecha.DayOfWeek = DayOfWeek.Sunday Then
                MsgBox("Error: La fecha seleccionada corresponde a un fin de semana... !", vbInformation, "Servico de Alertas")
            Else
                If cbxTurno.Text = "" Then
                    MsgBox("Error: Selecciona el Turno al que cargar asistencia... !", vbInformation, "Servico de Alertas")
                    cbxTurno.Select()
                Else
                    If cbxCurso.Text = "" Then
                        MsgBox("Error: No hay clases en esa Fecha y Turno... !", vbInformation, "Servico de Alertas")
                    Else
                        If cbxCurso.Text = "" Then
                            MsgBox("Error: Selecciona el Curso al que cargar asistencia... !", vbInformation, "Servico de Alertas")
                            cbxCurso.Select()
                        Else
                            If cbxGrupos.Text = "" Then
                                MsgBox("Error: Selecciona el Grupo al que cargar asistencia... !", vbInformation, "Servico de Alertas")
                                cbxCurso.Select()
                            Else
                                'ActivarCtrls(Me.Name)
                                _Dt = _Ver.consAsistencia_Curso_Dia_Turno_Grupo(CDate(lblFecha.Text), CInt(txtIdCurso.Text), lblTurno.Text, CInt(txtIdGrupo.Text))

                                If _Dt.Rows.Count > 0 Then
                                    dgvPlanillaAlumnos.DataSource = _Dt

                                    dgvPlanillaAlumnos.ColumnHeadersVisible = True
                                    dgvPlanillaAlumnos.Columns("Asistencia").Visible = True
                                    dgvPlanillaAlumnos.Columns("RetiroAnt").Visible = True
                                    dgvPlanillaAlumnos.Columns("Justificada").Visible = True
                                    dgvPlanillaAlumnos.Columns("Fecha").Visible = False
                                    dgvPlanillaAlumnos.Columns("idAlumnos").Visible = False
                                    dgvPlanillaAlumnos.Columns("idAsistencia").Visible = False
                                    dgvPlanillaAlumnos.Columns("Asis").Visible = False
                                    dgvPlanillaAlumnos.Columns("Retiro").Visible = False
                                    dgvPlanillaAlumnos.Columns("HoraIngreso").Visible = False
                                    dgvPlanillaAlumnos.Columns("Just").Visible = False
                                    dgvPlanillaAlumnos.Columns("idHorarios").Visible = False
                                    dgvPlanillaAlumnos.Columns("Dia").Visible = False
                                    dgvPlanillaAlumnos.Columns("Turno").Visible = False
                                    dgvPlanillaAlumnos.Columns("Entrada").Visible = False
                                    dgvPlanillaAlumnos.Columns("Tipo").Visible = False
                                    dgvPlanillaAlumnos.Columns("Usuarios_idUsuarios").Visible = False
                                    dgvPlanillaAlumnos.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False

                                    dgvPlanillaAlumnos.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                                    dgvPlanillaAlumnos.Columns("Asistencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.Columns("RetiroAnt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.Columns("Justificada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.Columns("Asistencia").Width = 150
                                    dgvPlanillaAlumnos.Columns("RetiroAnt").Width = 170
                                    dgvPlanillaAlumnos.Columns("Justificada").Width = 150
                                    dgvPlanillaAlumnos.Columns("Nombre").Width = 350
                                    dgvPlanillaAlumnos.Sort(dgvPlanillaAlumnos.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

                                    For X = 0 To dgvPlanillaAlumnos.Columns.Count - 1
                                        dgvPlanillaAlumnos.Columns(X).SortMode = DataGridViewColumnSortMode.NotSortable
                                    Next
                                    For X = 0 To _Dt.Rows.Count - 1
                                        dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value = _Dt.Rows(X).Item("Asis")
                                        dgvPlanillaAlumnos.Rows(X).Cells("RetiroAnt").Value = _Dt.Rows(X).Item("Retiro")
                                        dgvPlanillaAlumnos.Rows(X).Cells("Justificada").Value = _Dt.Rows(X).Item("Just")
                                    Next
                                    txtGoM.Text = "M"
                                Else
                                    _Dt = _Ver.consAlumno_Curso(CInt(txtIdCurso.Text), CInt(frmIngresoSIA.txtCicloID.Text))
                                    dgvPlanillaAlumnos.DataSource = _Dt
                                    dgvPlanillaAlumnos.ColumnHeadersVisible = True
                                    dgvPlanillaAlumnos.Columns("idAlumnos").Visible = False
                                    dgvPlanillaAlumnos.Columns("Sexo").Visible = False
                                    dgvPlanillaAlumnos.Columns("idHuella_Digital").Visible = False
                                    dgvPlanillaAlumnos.Columns("Modelo_Huella").Visible = False
                                    dgvPlanillaAlumnos.Columns("Estado").Visible = False
                                    dgvPlanillaAlumnos.Columns("Año").Visible = False
                                    dgvPlanillaAlumnos.Columns("Division").Visible = False
                                    dgvPlanillaAlumnos.Columns("idCurso").Visible = False
                                    dgvPlanillaAlumnos.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False
                                    dgvPlanillaAlumnos.Columns("Usuarios_idUsuarios").Visible = False
                                    dgvPlanillaAlumnos.Columns("Asistencia").Visible = True
                                    dgvPlanillaAlumnos.Columns("RetiroAnt").Visible = True
                                    dgvPlanillaAlumnos.Columns("Justificada").Visible = True
                                    dgvPlanillaAlumnos.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                                    dgvPlanillaAlumnos.Columns("Asistencia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.Columns("RetiroAnt").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.Columns("Justificada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                    dgvPlanillaAlumnos.Columns("Asistencia").Width = 150
                                    dgvPlanillaAlumnos.Columns("RetiroAnt").Width = 170
                                    dgvPlanillaAlumnos.Columns("Justificada").Width = 150
                                    dgvPlanillaAlumnos.Columns("Nombre").Width = 350
                                    dgvPlanillaAlumnos.Sort(dgvPlanillaAlumnos.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

                                    For X = 0 To dgvPlanillaAlumnos.Rows.Count - 1
                                        dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value = "Presente"
                                        dgvPlanillaAlumnos.Rows(X).Cells("RetiroAnt").Value = "No"
                                        dgvPlanillaAlumnos.Rows(X).Cells("Justificada").Value = "-"
                                    Next
                                    For X = 0 To dgvPlanillaAlumnos.Columns.Count - 1
                                        dgvPlanillaAlumnos.Columns(X).SortMode = DataGridViewColumnSortMode.NotSortable
                                    Next
                                    txtGoM.Text = "G"
                                End If

                                pbxCancelar.Enabled = True
                                pbxGuardar.Enabled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbxCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCurso.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim SepDiv As String = Mid(cbxCurso.Text, 5, 1)
        Dim SepAño As String = Microsoft.VisualBasic.Left(cbxCurso.Text, 1)

        _Dt = _Ver.verCurso

        txtIdCurso.Text = ""

        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("Año") = SepAño And _Dr("Division") = SepDiv Then
                txtIdCurso.Text = _Dr("idCurso")
            End If
        Next

        _Dt = _Ver.consHorarios_Curso_Tipo_Dia_Turno("Temporal", StrConv(New System.Globalization.CultureInfo("Es-Es").DateTimeFormat.GetDayName(CDate(txtFechaSeleccionada.Text).DayOfWeek), VbStrConv.ProperCase), cbxTurno.Text, txtIdCurso.Text)

        cbxGrupos.Items.Clear()
        If _Dt.Rows.Count > 0 Then
            cbxGrupos.Enabled = True
            For Each _Dr As DataRow In _Dt.Rows
                cbxGrupos.Items.Add(_Dr("Grupo"))
            Next
        End If

        _Dt = _Ver.consHorarios_Curso_Tipo_Dia_Turno("Permanente", StrConv(New System.Globalization.CultureInfo("Es-Es").DateTimeFormat.GetDayName(CDate(txtFechaSeleccionada.Text).DayOfWeek), VbStrConv.ProperCase), cbxTurno.Text, txtIdCurso.Text)

        If _Dt.Rows.Count > 0 Then
            cbxGrupos.Enabled = True
            For Each _Dr As DataRow In _Dt.Rows
                cbxGrupos.Items.Add(_Dr("Grupo"))
            Next
        End If

        lblCurso.Text = cbxCurso.Text
        cbxGrupos.Select()
    End Sub

    Private Sub mtcFecha_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mtcFecha.DateChanged
        Dim Fecha As Date = mtcFecha.SelectionRange.Start.ToShortDateString()
        Dim DiaS As String = StrConv(New System.Globalization.CultureInfo("Es-Es").DateTimeFormat.GetDayName(CDate(mtcFecha.SelectionRange.Start).DayOfWeek), VbStrConv.ProperCase)

        txtFechaSeleccionada.Text = Fecha

        If txtFechaSeleccionada.Text <> "" Then
            If cbxTurno.Text <> "" Then
                CargarCursosCBX()
                lblFecha.Text = Fecha
                lblDia.Text = DiaS

                If cbxCurso.Items.Count > 0 Then
                    cbxCurso.Enabled = True
                    lblMsgCurso.Visible = False
                    If cbxTurno.Text <> "" Then
                        lblTurno.Text = cbxTurno.Text
                    End If

                    cbxCurso.Select()
                Else
                    cbxCurso.Enabled = False
                    lblMsgCurso.Visible = True
                    lblMsgCurso.Text = "No hay clases en esa fecha y turno"
                End If
            Else
                lblMsgCurso.Text = "Selecciona primero fecha y turno"
            End If
        Else
            lblMsgCurso.Text = "Selecciona primero fecha y turno"
        End If
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        cbxTurno.Text = ""
        cbxCurso.Text = ""
        cbxGrupos.Text = ""
        cbxCurso.Items.Clear()
        cbxGrupos.Items.Clear()
        lblFecha.Text = "-"
        lblTurno.Text = "-"
        lblCurso.Text = "-"
        lblDia.Text = "-"
        lblGrupo.Text = "-"
        lblIngreso.Text = "-"
        txtGoM.Text = "G"
        cbxCurso.Enabled = False
        cbxGrupos.Enabled = False
        pbxCancelar.Enabled = False
        pbxGuardar.Enabled = False

        dgvPlanillaAlumnos.DataSource = Nothing
        dgvPlanillaAlumnos.ColumnHeadersVisible = False
        cbxTurno.Select()
    End Sub

    Private Sub cbxTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTurno.SelectedIndexChanged
        If txtFechaSeleccionada.Text <> "" Then
            If cbxTurno.Text <> "" Then
                Dim DiaS As String = StrConv(New System.Globalization.CultureInfo("Es-Es").DateTimeFormat.GetDayName(CDate(mtcFecha.SelectionRange.Start).DayOfWeek), VbStrConv.ProperCase)
                CargarCursosCBX()
                lblFecha.Text = mtcFecha.SelectionRange.Start
                lblDia.Text = DiaS

                If cbxCurso.Items.Count > 0 Then
                    cbxCurso.Enabled = True
                    lblMsgCurso.Visible = False
                    lblTurno.Text = cbxTurno.Text

                    cbxCurso.Select()
                Else
                    cbxCurso.Enabled = False
                    lblMsgCurso.Visible = True
                    lblMsgCurso.Text = "No hay clases en esa fecha y turno"
                End If
            Else
                lblMsgCurso.Text = "Selecciona primero fecha y turno"
            End If
        Else
            lblMsgCurso.Text = "Selecciona primero fecha y turno"
        End If
    End Sub

    Private Sub cbxGrupos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGrupos.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim idG As Integer = 0

        _Dt = _Ver.verGrupo_Grupo_idCurso(cbxGrupos.Text, CInt(txtIdCurso.Text), CInt(frmIngresoSIA.txtCicloID.Text))
        If _Dt.Rows.Count > 0 Then
            idG = _Dt.Rows(0).Item("idGrupo")
        End If
        If cbxGrupos.Items.Count > 0 Then
            _Dt = _Ver.consHorarios_Curso_Tipo_Dia_Turno_Grupo("Permanente", StrConv(New System.Globalization.CultureInfo("Es-Es").DateTimeFormat.GetDayName(CDate(txtFechaSeleccionada.Text).DayOfWeek), VbStrConv.ProperCase), cbxTurno.Text, txtIdCurso.Text, idG)

            txtTipo.Text = _Dt.Rows(0).Item("Tipo")
            txtIdHorario.Text = _Dt.Rows(0).Item("idHorarios")
            txtIngreso.Text = _Dt.Rows(0).Item("Entrada")
            txtGrupo.Text = _Dt.Rows(0).Item("Grupo")
            txtIdGrupo.Text = _Dt.Rows(0).Item("idGrupo")

            lblGrupo.Text = txtGrupo.Text
            lblIngreso.Text = txtIngreso.Text
        End If
    End Sub

    Private Sub dgvPlanillaAlumnos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPlanillaAlumnos.CellContentDoubleClick
        If e.RowIndex >= 0 Then
            If dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Presente" Then
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Tarde"
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("RetiroAnt").Value = "No"
            ElseIf dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Tarde" Then
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Ausente"
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("RetiroAnt").Value = "No"
            ElseIf dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Ausente" And dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("RetiroAnt").Value = "No" Then
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Ausente"
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("RetiroAnt").Value = "Si"
            Else
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("Asistencia").Value = "Presente"
                dgvPlanillaAlumnos.Rows(e.RowIndex).Cells("RetiroAnt").Value = "No"
            End If
        End If
    End Sub

    Private Sub dgvPlanillaAlumnos_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvPlanillaAlumnos.CellFormatting
        Select Case dgvPlanillaAlumnos.Columns(e.ColumnIndex).Index
            Case 0
                Dim Fila As DataGridViewRow = dgvPlanillaAlumnos.Rows(e.RowIndex)
                'Dim Celda As DataGridViewCell = dgvPlanillaAlumnos.Rows(e.RowIndex).Cells(0)
                'Celda.Style.BackColor = Color.Red
                Select Case System.Convert.ToString(e.Value)
                    Case "Presente"
                        Fila.DefaultCellStyle.BackColor = Color.LightGreen
                    Case "Tarde"
                        Fila.DefaultCellStyle.BackColor = Color.Yellow
                    Case "Ausente"
                        Fila.DefaultCellStyle.BackColor = Color.Tomato
                End Select

        End Select

    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As New DialogResult
        Dim X As Integer

        If dgvPlanillaAlumnos.Rows.Count = 0 Then
            MsgBox("Error: Cargue primero la planilla de asistencias !", vbInformation, "Servico de Alertas")
        Else
            resP = MessageBox.Show("Grabar Asistencia ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                If txtGoM.Text = "G" Then
                    For X = 0 To dgvPlanillaAlumnos.Rows.Count - 1
                        Dim Minutos As Integer = Mid(lblIngreso.Text, Len(lblIngreso.Text) - 1, 2)
                        Dim Resto As String = Mid(lblIngreso.Text, 1, Len(lblIngreso.Text) - 2)
                        Dim Hora As String = ""

                        If dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value = "Ausente" Then
                            Hora = "NO"
                        ElseIf dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value = "Tarde" Then
                            Minutos = Minutos + 5
                            Hora = Resto & Minutos
                        Else
                            Hora = lblIngreso.Text
                        End If
                        G.Grabar("Asistencia", "NoImagen", "sistema_asistencia.insAsistencia", Format(CDate(lblFecha.Text), "yyyy/MM/dd"), dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value, _
                                 Hora, dgvPlanillaAlumnos.Rows(X).Cells("RetiroAnt").Value, "-", dgvPlanillaAlumnos.Rows(X).Cells("idAlumnos").Value, CInt(txtIdHorario.Text), CInt(frmIngresoSIA.txtCicloID.Text), CInt(frmIngresoSIA.txtIdUs.Text))
                    Next
                Else
                    For X = 0 To dgvPlanillaAlumnos.Rows.Count - 1
                        Dim Minutos As Integer = Mid(lblIngreso.Text, Len(lblIngreso.Text) - 1, 2)
                        Dim Resto As String = Mid(lblIngreso.Text, 1, Len(lblIngreso.Text) - 2)
                        Dim Hora As String = ""
                        If dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value = "Ausente" Then
                            Hora = "NO"
                        ElseIf dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value = "Tarde" Then
                            Minutos = Minutos + 5
                            Hora = Resto & Minutos
                        Else
                            Hora = lblIngreso.Text
                        End If
                        G.Grabar("Asistencia", "NoImagen", "sistema_asistencia.modAsistencia", dgvPlanillaAlumnos.Rows(X).Cells("idAsistencia").Value, Format(CDate(lblFecha.Text), "yyyy/MM/dd"), dgvPlanillaAlumnos.Rows(X).Cells("Asistencia").Value, _
                                  Hora, dgvPlanillaAlumnos.Rows(X).Cells("RetiroAnt").Value, dgvPlanillaAlumnos.Rows(X).Cells("Justificada").Value, dgvPlanillaAlumnos.Rows(X).Cells("idAlumnos").Value, CInt(txtIdHorario.Text), CInt(frmIngresoSIA.txtCicloID.Text), CInt(frmIngresoSIA.txtIdUs.Text))
                    Next
                End If
                cbxTurno.Text = ""
                cbxCurso.Text = ""
                cbxGrupos.Text = ""
                cbxCurso.Items.Clear()
                cbxGrupos.Items.Clear()
                lblFecha.Text = "-"
                lblTurno.Text = "-"
                lblCurso.Text = "-"
                lblDia.Text = "-"
                lblGrupo.Text = "-"
                lblIngreso.Text = "-"
                txtGoM.Text = "G"
                cbxCurso.Enabled = False
                cbxGrupos.Enabled = False
                pbxCancelar.Enabled = False
                pbxGuardar.Enabled = False

                dgvPlanillaAlumnos.DataSource = Nothing
                dgvPlanillaAlumnos.ColumnHeadersVisible = False
                cbxTurno.Select()
            End If
        End If
    End Sub

    Private Sub btnJust_Click(sender As Object, e As EventArgs) Handles btnJust.Click
        If dgvPlanillaAlumnos.Rows.Count > 0 Then
            If dgvPlanillaAlumnos.CurrentRow.Cells("Asistencia").Value = "Ausente" Then
                If dgvPlanillaAlumnos.CurrentRow.Cells("Justificada").Value = "Si" Then
                    dgvPlanillaAlumnos.CurrentRow.Cells("Justificada").Value = "No"
                ElseIf dgvPlanillaAlumnos.CurrentRow.Cells("Justificada").Value = "No" Then
                    dgvPlanillaAlumnos.CurrentRow.Cells("Justificada").Value = "-"
                Else
                    dgvPlanillaAlumnos.CurrentRow.Cells("Justificada").Value = "Si"
                End If
            Else
                MsgBox("Error: El Alumno debe estar Ausente para poder Justificar una falta !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Cargue primero la planilla de asistencias !", vbInformation, "Servico de Alertas")
        End If
    End Sub

End Class