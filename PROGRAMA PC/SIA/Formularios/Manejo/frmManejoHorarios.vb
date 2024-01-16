Public Class frmManejoHorarios
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

    Private Sub pbxEliminar_GotFocus(sender As Object, e As EventArgs) Handles pbxEliminar.GotFocus
        If (pbxEliminar.Enabled = True) Then
            pbxEliminar.Image = SIA.My.Resources.btnEliminarSi
        End If
    End Sub

    Private Sub pbxEliminar_LostFocus(sender As Object, e As EventArgs) Handles pbxEliminar.LostFocus
        If (pbxEliminar.Enabled = True) Then
            pbxEliminar.Image = SIA.My.Resources.btnEliminarNo
        End If
    End Sub

    Private Sub pbxEliminar_MouseEnter(sender As Object, e As EventArgs) Handles pbxEliminar.MouseEnter
        If (pbxEliminar.Enabled = True) Then
            pbxEliminar.Image = SIA.My.Resources.btnEliminarSi
        End If
    End Sub

    Private Sub pbxEliminar_MouseLeave(sender As Object, e As EventArgs) Handles pbxEliminar.MouseLeave
        If (pbxEliminar.Enabled = True) Then
            pbxEliminar.Image = SIA.My.Resources.btnEliminarNo
        End If
    End Sub

    Private Sub pbxModificar_GotFocus(sender As Object, e As EventArgs) Handles pbxModificar.GotFocus
        If (pbxModificar.Enabled = True) Then
            pbxModificar.Image = SIA.My.Resources.btnModificarSi
        End If
    End Sub

    Private Sub pbxModificar_LostFocus(sender As Object, e As EventArgs) Handles pbxModificar.LostFocus
        If (pbxModificar.Enabled = True) Then
            pbxModificar.Image = SIA.My.Resources.btnModificarNo
        End If
    End Sub

    Private Sub pbxModificar_MouseEnter(sender As Object, e As EventArgs) Handles pbxModificar.MouseEnter
        If (pbxModificar.Enabled = True) Then
            pbxModificar.Image = SIA.My.Resources.btnModificarSi
        End If
    End Sub

    Private Sub pbxModificar_MouseLeave(sender As Object, e As EventArgs) Handles pbxModificar.MouseLeave
        If (pbxModificar.Enabled = True) Then
            pbxModificar.Image = SIA.My.Resources.btnModificarNo
        End If
    End Sub

    Private Sub pbxNuevo_GotFocus(sender As Object, e As EventArgs) Handles pbxNuevo.GotFocus
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.Image = SIA.My.Resources.btnNuevoSi
        End If
    End Sub

    Private Sub pbxNuevo_LostFocus(sender As Object, e As EventArgs) Handles pbxNuevo.LostFocus
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.Image = SIA.My.Resources.btnNuevoNo
        End If
    End Sub

    Private Sub pbxNuevo_MouseEnter(sender As Object, e As EventArgs) Handles pbxNuevo.MouseEnter
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.Image = SIA.My.Resources.btnNuevoSi
        End If
    End Sub

    Private Sub pbxNuevo_MouseLeave(sender As Object, e As EventArgs) Handles pbxNuevo.MouseLeave
        If (pbxNuevo.Enabled = True) Then
            pbxNuevo.Image = SIA.My.Resources.btnNuevoNo
        End If
    End Sub

    Private Sub frmManejoHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        Dim ctlModificar As Control = DirectCast(pbxModificar, Control)
        Dim keyprModificar = New KeyPressEventHandler(AddressOf btnModificar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        AddHandler ctlModificar.KeyPress, keyprModificar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Manejo Horarios"

        dgvHorarios.DefaultCellStyle.ForeColor = Color.Black

        dgvHorarios.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
        dgvHorarios.AlternatingRowsDefaultCellStyle.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)

        CargarHorarios()
        CargarCursosCBX()

        cbxGrupo.Items.Clear()

        pbxNuevo.Select()
    End Sub

    Private Sub btnNuevo(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxNuevo_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnModificar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxModificar_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub Cancelar()
        gbxPPal.Enabled = False
        gbxHorarios.Enabled = True

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        cbxGrupo.Text = ""
        cbxCurso.Text = ""
        txtIdGrupo.Text = ""
        txtIdCurso.Text = ""
        txtOrigen.Text = ""

        dtpIngreso.Text = Now
        dtpIngreso.Enabled = True

        chbLunes.Checked = False
        chbMartes.Checked = False
        chbMiercoles.Checked = False
        chbJueves.Checked = False
        chbViernes.Checked = False

        rdbMañana.Checked = False
        rdbTarde.Checked = False

        rdbPermanente.Checked = False
        rdbTemporal.Checked = False

        pbxNuevo.Image = SIA.My.Resources.btnNuevoNo
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvHorarios.CurrentCell = Nothing

        lblSiNo.Text = "SI/NO"
        lblSiNo.BackColor = Color.Gainsboro
        lblSiNo.ForeColor = Color.DarkRed

        pbxNuevo.Focus()
    End Sub

    Private Sub CargarHorarios()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.consHorarios_Grupo_Curso

        dgvHorarios.RowTemplate.Height = 25
        dgvHorarios.DataSource = _Dt

        dgvHorarios.Columns("idHorarios").Visible = False
        dgvHorarios.Columns("idCurso").Visible = False
        dgvHorarios.Columns("idGrupo").Visible = False
        dgvHorarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvHorarios.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvHorarios.Columns("Divs").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvHorarios.Columns("Grp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvHorarios.Columns("Día").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvHorarios.Columns("Trn").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvHorarios.Columns("Hr_Ing").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvHorarios.Columns("Tipo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvHorarios.Columns("Año").Width = 50
        dgvHorarios.Columns("DivS").Width = 50
        dgvHorarios.Columns("Grp").Width = 100
        dgvHorarios.Columns("Día").Width = 90
        dgvHorarios.Columns("Trn").Width = 80
        dgvHorarios.Columns("Hr_Ing").Width = 70
        dgvHorarios.Columns("Tipo").Width = 110

        dgvHorarios.Sort(dgvHorarios.Columns("Año"), System.ComponentModel.ListSortDirection.Ascending)

        If dgvHorarios.Rows.Count > 0 Then
            dgvHorarios.ColumnHeadersVisible = True
        Else
            dgvHorarios.ColumnHeadersVisible = False
        End If

        dgvHorarios.ClearSelection()
        dgvHorarios.CurrentCell = Nothing
    End Sub

    Private Sub dgvHorarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHorarios.CellClick
        If dgvHorarios.CurrentRow.Index > -1 Then
            If dgvHorarios.CurrentRow.Cells.Item("Tipo").Value = "Permanente" Then
                rdbPermanente.Checked = True
            Else
                rdbTemporal.Checked = True
            End If

            If dgvHorarios.CurrentRow.Cells.Item("Trn").Value = "Mañana" Then
                rdbMañana.Checked = True
            Else
                rdbTarde.Checked = True
            End If

            chbLunes.Checked = False
            chbMartes.Checked = False
            chbMiercoles.Checked = False
            chbJueves.Checked = False
            chbViernes.Checked = False

            If dgvHorarios.CurrentRow.Cells.Item("Día").Value = "Lunes" Then
                chbLunes.Checked = True
            ElseIf dgvHorarios.CurrentRow.Cells.Item("Día").Value = "Martes" Then
                chbMartes.Checked = True
            ElseIf dgvHorarios.CurrentRow.Cells.Item("Día").Value = "Miércoles" Then
                chbMiercoles.Checked = True
            ElseIf dgvHorarios.CurrentRow.Cells.Item("Día").Value = "Jueves" Then
                chbJueves.Checked = True
            ElseIf dgvHorarios.CurrentRow.Cells.Item("Día").Value = "Viernes" Then
                chbViernes.Checked = True
            End If

            txtIdCurso.Text = dgvHorarios.CurrentRow.Cells.Item("idCurso").Value
            txtIdGrupo.Text = dgvHorarios.CurrentRow.Cells.Item("idGrupo").Value

            If dgvHorarios.CurrentRow.Cells.Item("Hr_Ing").Value = "S/C" Then
                lblSiNo.Text = "NO"
                lblSiNo.BackColor = Color.DarkGray
                lblSiNo.ForeColor = Color.White

                dtpIngreso.Enabled = False
                dtpIngreso.Text = "00:00"
            Else
                lblSiNo.Text = "SI"
                lblSiNo.BackColor = Color.DarkOrange
                lblSiNo.ForeColor = Color.DarkRed

                dtpIngreso.Enabled = True
                dtpIngreso.Text = dgvHorarios.CurrentRow.Cells.Item("Hr_Ing").Value
            End If

            cbxCurso.Text = dgvHorarios.CurrentRow.Cells.Item("Año").Value & "° " & """" & dgvHorarios.CurrentRow.Cells.Item("Divc").Value & """"
            cbxGrupo.Text = dgvHorarios.CurrentRow.Cells.Item("Grp").Value
        End If
    End Sub

    Private Sub CargarCursosCBX()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCurso

        For Each _Dr As DataRow In _Dt.Rows
            cbxCurso.Items.Add(_Dr("Año") & "° " & """" & _Dr("Division") & """")
        Next
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If dgvHorarios.CurrentRow IsNot Nothing Then
            ActivarCtrls(Me.Name)
            txtOrigen.Text = "Modificar"


            If lblSiNo.Text = "SI" Then
                dtpIngreso.Enabled = True
            End If

            pbxModificar.Image = SIA.My.Resources.btnModificarSi
            pbxNuevo.Image = SIA.My.Resources.btnNuevoNo

            cbxCurso.Select()
        Else
            MsgBox("Error: Selecciona un Horario de la lista para modificarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        If cbxCurso.Text = "" Then
            MsgBox("Error: 'Curso' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
            cbxCurso.Select()
        Else
            If cbxGrupo.Text = "" Then
                MsgBox("Error: 'Grupo' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                cbxGrupo.Select()
            Else
                If chbLunes.Checked = False And chbMartes.Checked = False And chbMiercoles.Checked = False And chbJueves.Checked = False And chbViernes.Checked = False Then
                    MsgBox("Error: 'Dia' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                    chbLunes.Select()
                Else
                    If rdbMañana.Checked = False And rdbTarde.Checked = False Then
                        MsgBox("Error: 'Turno' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                        rdbMañana.Select()
                    Else
                        If rdbPermanente.Checked = False And rdbTemporal.Checked = False Then
                            MsgBox("Error: 'Tipo' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                            rdbPermanente.Select()
                        Else
                            If dtpIngreso.Text = "" Then
                                MsgBox("Error: 'Ingreso' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                                dtpIngreso.Select()
                            Else
                                If rdbMañana.Checked = True And (Format((TimeValue(dtpIngreso.Text)), "hh:mm") > Format((TimeValue("12:35")), "hh:mm") Or Format((TimeValue(dtpIngreso.Text)), "hh:mm") < Format((TimeValue("7:30")), "hh:mm")) Then
                                    MsgBox("Error: El horario de la mañana va entre las 7:30 y las 12:35... !", vbInformation, "Servico de Alertas")
                                    dtpIngreso.Select()
                                Else
                                    If rdbTarde.Checked = True And lblSiNo.Text = "SI" And (Format((TimeValue(dtpIngreso.Text)), "hh:mm") > Format((TimeValue("18:35")), "hh:mm") Or Format((TimeValue(dtpIngreso.Text)), "hh:mm") < Format((TimeValue("13:30")), "hh:mm")) Then
                                        MsgBox("Error: El horario de la tarde va entre las 13:30 y las 18:35... !", vbInformation, "Servico de Alertas")
                                        dtpIngreso.Select()
                                    Else
                                        Dim G As New GrabaDatos
                                        Dim resP, resP1 As DialogResult
                                        Dim _Ver As New Mostrar
                                        Dim _Dt As New DataTable
                                        Dim Turno, Tipo, Ingreso As String
                                        Dim Dia(5) As String
                                        Dim idGrupo As Double
                                        Dim SelDias As Integer = 5
                                        Dim D1 As Boolean = False
                                        Dim D2 As Boolean = False
                                        Dim D3 As Boolean = False
                                        Dim D4 As Boolean = False
                                        Dim D5 As Boolean = False

                                        If chbLunes.Checked = False Then
                                            SelDias = SelDias - 1
                                        End If

                                        If chbMartes.Checked = False Then
                                            SelDias = SelDias - 1
                                        End If

                                        If chbMiercoles.Checked = False Then
                                            SelDias = SelDias - 1
                                        End If

                                        If chbJueves.Checked = False Then
                                            SelDias = SelDias - 1
                                        End If

                                        If chbViernes.Checked = False Then
                                            SelDias = SelDias - 1
                                        End If

                                        ReDim Dia(SelDias)

                                        For i As Integer = 0 To SelDias - 1
                                            If chbLunes.Checked = True And D1 = False Then
                                                Dia(i) = "Lunes"
                                                D1 = True
                                            ElseIf chbMartes.Checked = True And D2 = False Then
                                                Dia(i) = "Martes"
                                                D2 = True
                                            ElseIf chbMiercoles.Checked = True And D3 = False Then
                                                Dia(i) = "Miércoles"
                                                D3 = True
                                            ElseIf chbJueves.Checked = True And D4 = False Then
                                                Dia(i) = "Jueves"
                                                D4 = True
                                            ElseIf chbViernes.Checked = True And D5 = False Then
                                                Dia(i) = "Viernes"
                                                D5 = True
                                            End If
                                        Next

                                        If rdbMañana.Checked = True Then
                                            Turno = "Mañana"
                                        Else
                                            Turno = "Tarde"
                                        End If

                                        If rdbPermanente.Checked = True Then
                                            Tipo = "Permanente"
                                        Else
                                            Tipo = "Temporal"
                                        End If

                                        If dtpIngreso.Enabled = False Then
                                            Ingreso = "S/C"
                                        Else
                                            Ingreso = dtpIngreso.Text
                                        End If

                                        If cbxGrupo.Text = "Todos" Then
                                            _Dt = _Ver.verGrupo_Grupo_idCurso("Todos", txtIdCurso.Text, frmIngresoSIA.txtCicloID.Text)

                                            If _Dt.Rows.Count < 1 Then
                                                G.Grabar("Grupo", "NoImagen", "sistema_asistencia.insGrupo", "Todos", txtIdCurso.Text, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)
                                            End If

                                            _Dt = _Ver.verGrupo_Grupo_idCurso("Todos", txtIdCurso.Text, frmIngresoSIA.txtCicloID.Text)

                                            idGrupo = _Dt.Rows(0).Item(0)
                                        Else
                                            idGrupo = txtIdGrupo.Text
                                        End If

                                        If txtOrigen.Text = "Nuevo" Then
                                            resP = MessageBox.Show("Grabar nuevo horario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                            If resP = Windows.Forms.DialogResult.OK Then
                                                For i As Integer = 0 To SelDias - 1

                                                    _Dt = _Ver.verHorario_Dia_Turno_Tipo_Curso_Grupo(Dia(i), Turno, Tipo, txtIdCurso.Text, idGrupo)

                                                    If _Dt.Rows.Count < 1 Then
                                                        G.Grabar("Horarios", "NoImagen", "sistema_asistencia.insHorario", Dia(i), Turno, Ingreso, Tipo, idGrupo, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)
                                                    Else
                                                        If Tipo = "Permanente" Then
                                                            resP1 = MessageBox.Show("Ya existe un horario permanente para el grupo """ & cbxGrupo.Text & """ del curso """ & cbxCurso.Text & """ si continua con la modificacion este horario sera reemplazado por el nuevo", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                                            If resP1 = Windows.Forms.DialogResult.OK Then
                                                                G.Grabar("Horarios", "NoImagen", "sistema_asistencia.elimHorario", _Dt.Rows(0).Item(0))

                                                                G.Grabar("Horarios", "NoImagen", "sistema_asistencia.insHorario", Dia(i), Turno, Ingreso, Tipo, idGrupo, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)
                                                            Else
                                                                MsgBox("Horario del día """ & Dia(i) & """ NO fue modificado!", vbInformation, "Servico de Alertas")
                                                                Cancelar()
                                                                CargarHorarios()
                                                            End If
                                                        Else
                                                            G.Grabar("Horarios", "NoImagen", "sistema_asistencia.insHorario", Dia(i), Turno, Ingreso, Tipo, idGrupo, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)
                                                        End If
                                                    End If
                                                Next
                                                MsgBox("Horario grabado con exito... !", vbInformation, "Servico de Alertas")
                                                Cancelar()
                                                CargarHorarios()
                                            End If
                                        Else
                                            _Dt = _Ver.verHorario_Dia_Turno_Tipo_Curso_Grupo(Dia(0), Turno, Tipo, txtIdCurso.Text, idGrupo)

                                            If _Dt.Rows.Count < 1 Then
                                                resP = MessageBox.Show("Modificar Horario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                                If resP = Windows.Forms.DialogResult.OK Then
                                                    G.Grabar("Horarios", "NoImagen", "sistema_asistencia.modHorario", dgvHorarios.CurrentRow.Cells.Item("idHorarios").Value, Dia(0), Turno, Ingreso, Tipo, idGrupo, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)
                                                    Cancelar()
                                                    CargarHorarios()
                                                    MsgBox("Horario Modificado con exito... !", vbInformation, "Servico de Alertas")
                                                Else
                                                    MsgBox("Modificación de Horario cancelada por Usuario... !", vbInformation, "Servico de Alertas")
                                                End If
                                            Else
                                                If _Dt.Rows(0).Item("idHorarios") = dgvHorarios.CurrentRow.Cells.Item("idHorarios").Value Then
                                                    resP = MessageBox.Show("Modificar Horario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                                    If resP = Windows.Forms.DialogResult.OK Then
                                                        G.Grabar("Horarios", "NoImagen", "sistema_asistencia.modHorario", dgvHorarios.CurrentRow.Cells.Item("idHorarios").Value, Dia(0), Turno, Ingreso, Tipo, idGrupo, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)
                                                        Cancelar()
                                                        CargarHorarios()
                                                        MsgBox("Horario Modificado con exito... !", vbInformation, "Servico de Alertas")
                                                    Else
                                                        MsgBox("Modificación de Horario cancelada por Usuario... !", vbInformation, "Servico de Alertas")
                                                    End If
                                                Else
                                                    resP = MessageBox.Show("Ya existe un horario """ & Tipo & """ para el grupo """ & cbxGrupo.Text & """ del curso """ & cbxCurso.Text & """ si continua con la modificacion este horario sera reemplazado por el nuevo", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                                    If resP = Windows.Forms.DialogResult.OK Then
                                                        G.Grabar("Horarios", "NoImagen", "sistema_asistencia.elimHorario", _Dt.Rows(0).Item("idHorarios"))

                                                        G.Grabar("Horarios", "NoImagen", "sistema_asistencia.modHorario", dgvHorarios.CurrentRow.Cells.Item("idHorarios").Value, Dia(0), Turno, Ingreso, Tipo, idGrupo, frmIngresoSIA.txtCicloID.Text, frmIngresoSIA.txtIdUs.Text)

                                                        Cancelar()
                                                        CargarHorarios()
                                                        MsgBox("Horario Modificado con exito... !", vbInformation, "Servico de Alertas")
                                                    Else
                                                        MsgBox("Modificación de Horario cancelada por Usuario... !", vbInformation, "Servico de Alertas")
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        ActivarCtrls(Me.Name)
        txtOrigen.Text = "Nuevo"

        pbxNuevo.Image = SIA.My.Resources.btnNuevoSi
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvHorarios.CurrentCell = Nothing

        cbxCurso.Text = ""
        cbxGrupo.Text = ""

        chbLunes.Checked = False
        chbMartes.Checked = False
        chbMiercoles.Checked = False
        chbJueves.Checked = False
        chbViernes.Checked = False

        rdbMañana.Checked = False
        rdbTarde.Checked = False

        rdbPermanente.Checked = False
        rdbTemporal.Checked = False

        dtpIngreso.Text = Now
        dtpIngreso.Enabled = True

        cbxCurso.Select()
    End Sub

    Private Sub cbxCurso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCurso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxGrupo.SelectionLength = Len(cbxGrupo.Text)
            cbxGrupo.Select()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dtpIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpIngreso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub cbxGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGrupo.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verGrupo

        txtIdGrupo.Text = ""

        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("Grupo") = cbxGrupo.Text And _Dr("Curso_idCurso") = txtIdCurso.Text Then
                txtIdGrupo.Text = _Dr("idGrupo")
            End If
        Next
    End Sub

    Private Sub cbxCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCurso.SelectedIndexChanged
        Dim _Dt, _Dt2 As New DataTable
        Dim _Ver As New Mostrar
        Dim SepDiv As String = Mid(cbxCurso.Text, 5, 1)
        Dim SepAño As String = Microsoft.VisualBasic.Left(cbxCurso.Text, 1)

        _Dt = _Ver.verCurso
        _Dt2 = _Ver.verGrupo

        txtIdCurso.Text = ""

        cbxGrupo.Items.Clear()

        cbxGrupo.Items.Add("Todos")

        cbxGrupo.Text = ""

        For Each _Dr As DataRow In _Dt.Rows
            If _Dr("Año") = SepAño And _Dr("Division") = SepDiv Then
                txtIdCurso.Text = _Dr("idCurso")

                For Each _Dr2 As DataRow In _Dt2.Rows
                    If _Dr("idCurso") = _Dr2("Curso_idCurso") Then
                        If _Dr2("Grupo") <> "Ninguno" And _Dr2("Grupo") <> "Todos" Then
                            cbxGrupo.Items.Add(_Dr2("Grupo"))
                        End If
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub pbxEliminar_Click(sender As Object, e As EventArgs) Handles pbxEliminar.Click
        If dgvHorarios.CurrentRow IsNot Nothing Then
            Dim G As New GrabaDatos
            Dim resP As DialogResult

            resP = MessageBox.Show("Seguro que quieres eliminar este horario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                G.Grabar("Horarios", "NoImagen", "sistema_asistencia.elimHorario", dgvHorarios.CurrentRow.Cells.Item("idHorarios").Value)

                Cancelar()
                CargarHorarios()
                MsgBox("Horario eliminado... !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Selecciona un Horario de la lista para borrarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub rdbTipo_CheckedChanged(sender As Object, e As EventArgs) Handles rdbPermanente.CheckedChanged, rdbTemporal.CheckedChanged
        If rdbTemporal.Checked = True Then
            lblClases.Enabled = True
            lblSiNo.Enabled = True
            dtpIngreso.Enabled = False
        Else
            lblClases.Enabled = False
            lblSiNo.Enabled = False
            dtpIngreso.Enabled = True
        End If

        dtpIngreso.Text = Now
        lblSiNo.Text = "SI/NO"
        lblSiNo.BackColor = Color.Gainsboro
        lblSiNo.ForeColor = Color.DarkRed
    End Sub

    Private Sub lblSiNo_Click(sender As Object, e As EventArgs) Handles lblSiNo.Click
        If lblSiNo.Text = "SI" Then
            lblSiNo.Text = "NO"
            lblSiNo.BackColor = Color.DarkGray
            lblSiNo.ForeColor = Color.White

            dtpIngreso.Enabled = False
            dtpIngreso.Text = "00:00"
        Else
            lblSiNo.Text = "SI"
            lblSiNo.BackColor = Color.DarkOrange
            lblSiNo.ForeColor = Color.DarkRed

            dtpIngreso.Enabled = True
            dtpIngreso.Text = Now
        End If
    End Sub

    Private Sub chbLunes_CheckedChanged(sender As Object, e As EventArgs) Handles chbLunes.Click
        If txtOrigen.Text = "Modificar" Then
            chbMartes.Checked = False
            chbMiercoles.Checked = False
            chbJueves.Checked = False
            chbViernes.Checked = False
        End If
    End Sub

    Private Sub chbMartes_CheckedChanged(sender As Object, e As EventArgs) Handles chbMartes.Click
        If txtOrigen.Text = "Modificar" Then
            chbLunes.Checked = False
            chbMiercoles.Checked = False
            chbJueves.Checked = False
            chbViernes.Checked = False
        End If
    End Sub

    Private Sub chbMiercoles_CheckedChanged(sender As Object, e As EventArgs) Handles chbMiercoles.Click
        If txtOrigen.Text = "Modificar" Then
            chbMartes.Checked = False
            chbLunes.Checked = False
            chbJueves.Checked = False
            chbViernes.Checked = False
        End If
    End Sub

    Private Sub chbJueves_CheckedChanged(sender As Object, e As EventArgs) Handles chbJueves.Click
        If txtOrigen.Text = "Modificar" Then
            chbMartes.Checked = False
            chbMiercoles.Checked = False
            chbLunes.Checked = False
            chbViernes.Checked = False
        End If
    End Sub

    Private Sub chbViernes_CheckedChanged(sender As Object, e As EventArgs) Handles chbViernes.Click
        If txtOrigen.Text = "Modificar" Then
            chbMartes.Checked = False
            chbMiercoles.Checked = False
            chbJueves.Checked = False
            chbLunes.Checked = False
        End If
    End Sub
End Class