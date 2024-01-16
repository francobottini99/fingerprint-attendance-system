Public Class frmAltasGrupo
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

    Private Sub frmAltasGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        Dim ctlModificar As Control = DirectCast(pbxModificar, Control)
        Dim keyprModificar = New KeyPressEventHandler(AddressOf btnModificar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        AddHandler ctlModificar.KeyPress, keyprModificar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Alta Grupo"

        dgvGrupos.DefaultCellStyle.ForeColor = Color.Black

        dgvGrupos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)

        pbxNuevo.Select()
        CargarCursos()
        CargarGrupos()
    End Sub

    Private Sub CargarCursos()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCurso

        For Each _Dr As DataRow In _Dt.Rows
            cbxCurso.Items.Add(_Dr("Año") & "° " & """" & _Dr("Division") & """")
        Next

    End Sub

    Private Sub CargarGrupos()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.consGrupo_Curso

        dgvGrupos.RowTemplate.Height = 30
        dgvGrupos.DataSource = _Dt
        dgvGrupos.Columns("idCurso").Visible = False
        dgvGrupos.Columns("idGrupo").Visible = False
        dgvGrupos.Columns("idCurso").Visible = False
        dgvGrupos.Columns("Ciclo").Visible = False
        dgvGrupos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGrupos.Columns("Grupo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvGrupos.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGrupos.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvGrupos.Columns("Grupo").Width = 400

        dgvGrupos.Sort(dgvGrupos.Columns("Año"), System.ComponentModel.ListSortDirection.Ascending)

        If dgvGrupos.Rows.Count > 0 Then
            dgvGrupos.ColumnHeadersVisible = True
        Else
            dgvGrupos.ColumnHeadersVisible = False
        End If

        dgvGrupos.Refresh()
        dgvGrupos.ClearSelection()
        dgvGrupos.CurrentCell = Nothing
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
        gbxGrupos.Enabled = True

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        txtGrupo.Text = ""
        cbxCurso.Text = ""
        txtOrigen.Text = ""

        pbxNuevo.Image = SIA.My.Resources.btnNuevoNo
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvGrupos.CurrentCell = Nothing

        pbxNuevo.Focus()
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        ActivarCtrls(Me.Name)
        txtOrigen.Text = "Nuevo"

        pbxNuevo.Image = SIA.My.Resources.btnNuevoSi
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvGrupos.CurrentCell = Nothing

        txtGrupo.Text = ""
        cbxCurso.Text = ""

        txtGrupo.Select()
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If dgvGrupos.CurrentRow IsNot Nothing Then
            ActivarCtrls(Me.Name)
            txtOrigen.Text = "Modficar"

            pbxModificar.Image = SIA.My.Resources.btnModificarSi
            pbxNuevo.Image = SIA.My.Resources.btnNuevoNo

            txtGrupo.Select()
        Else
            MsgBox("Error: Selecciona un grupo de la lista para poder modificarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        If txtGrupo.Text = "" Then
            MsgBox("Error: 'Nombre Grupo' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
            txtGrupo.Select()
        Else
            If txtGrupo.Text = "Ninguno" Or txtGrupo.Text = "Todos" Then
                MsgBox("Error: '" + txtGrupo.Text + "' no es un nombre valido... !", vbInformation, "Servico de Alertas")
                txtGrupo.Text = ""
                txtGrupo.Select()
            Else
                If cbxCurso.Text = "" Then
                    MsgBox("Error: 'Curso' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxCurso.Select()
                Else
                    If txtIdCurso.Text = "" Then
                        MsgBox("Error: El curso ingresado no se encuentra en la base de datos... !", vbInformation, "Servico de Alertas")
                        cbxCurso.Select()
                    Else
                        Dim G As New GrabaDatos
                        Dim resP As DialogResult
                        Dim _Ver As New Mostrar
                        Dim _Dt As New DataTable
                        Dim ulTid As Integer = 0

                        _Dt = _Ver.verCicloLectivo()
                        ulTid = _Dt.Rows(_Dt.Rows.Count - 1).Item(0)

                        _Dt = _Ver.verGrupo_Grupo_idCurso(txtGrupo.Text, CInt(txtIdCurso.Text), ulTid)

                        If _Dt.Rows.Count < 1 Then
                            If txtOrigen.Text = "Nuevo" Then
                                resP = MessageBox.Show("Grabar nuevo grupo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                If resP = Windows.Forms.DialogResult.OK Then
                                    G.Grabar("Grupo", "NoImagen", "sistema_asistencia.insGrupo", txtGrupo.Text, CInt(txtIdCurso.Text), ulTid, frmIngresoSIA.txtIdUs.Text)

                                    Cancelar()
                                    CargarGrupos()
                                    MsgBox("Grupo grabado con exito... !", vbInformation, "Servico de Alertas")
                                End If
                            Else
                                resP = MessageBox.Show("Modificar grupo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                If resP = Windows.Forms.DialogResult.OK Then
                                    G.Grabar("Grupo", "NoImagen", "sistema_asistencia.modGrupo", CInt(dgvGrupos.CurrentRow.Cells.Item(0).Value), txtGrupo.Text, CInt(txtIdCurso.Text), ulTid, frmIngresoSIA.txtIdUs.Text)

                                    Cancelar()
                                    CargarGrupos()
                                    MsgBox("Grupo modificado con exito... !", vbInformation, "Servico de Alertas")
                                End If
                            End If
                        Else
                            MsgBox("Error: El grupo " & txtGrupo.Text & " - " & cbxCurso.Text & " ya existe dentro de la base de datos... !", vbInformation, "Servico de Alertas")

                            txtGrupo.SelectionLength = Len(txtGrupo.Text)
                            txtGrupo.Select()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrupo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxCurso.SelectionLength = Len(cbxCurso.Text)
            cbxCurso.Select()
        End If
    End Sub

    Private Sub cbxCurso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCurso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        Else
            e.Handled = True
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
    End Sub

    Private Sub dgvGrupos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrupos.CellClick
        If dgvGrupos.CurrentRow.Index > -1 Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.verCurso

            txtGrupo.Text = dgvGrupos.CurrentRow.Cells.Item(1).Value
            txtIdCurso.Text = dgvGrupos.CurrentRow.Cells.Item(2).Value

            For Each _Dr As DataRow In _Dt.Rows
                If _Dr("idCurso") = txtIdCurso.Text Then
                    cbxCurso.Text = _Dr("Año") & "° " & """" & _Dr("Division") & """"
                End If
            Next

            pbxModificar.Select()
        End If
    End Sub

    Private Sub pbxEliminar_Click(sender As Object, e As EventArgs) Handles pbxEliminar.Click
        If dgvGrupos.CurrentRow IsNot Nothing Then
            Dim G As New GrabaDatos
            Dim resP As DialogResult
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.consAlumno_Curso(dgvGrupos.CurrentRow.Cells.Item(0).Value, frmIngresoSIA.txtCicloID.Text)

            If _Dt.Rows.Count < 1 Then
                resP = MessageBox.Show("Seguro que quieres eliminar este grupo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then
                    G.Grabar("Grupo", "NoImagen", "sistema_asistencia.elimGrupo", dgvGrupos.CurrentRow.Cells.Item(0).Value)

                    Cancelar()
                    CargarCursos()
                    CargarGrupos()
                    MsgBox("Grupo eliminado... !", vbInformation, "Servico de Alertas")
                End If
            Else
                MsgBox("Error: No puedes eliminar un Grupo que contiene alumnos cargados... !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Selecciona un Grupo de la lista para borrarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub tmrElim_Tick(sender As Object, e As EventArgs) Handles tmrElim.Tick
        If dgvGrupos.CurrentRow IsNot Nothing And txtOrigen.Text <> "Modificar" Then
            pbxEliminar.Enabled = True
        Else
            pbxEliminar.Enabled = False
        End If
    End Sub
End Class