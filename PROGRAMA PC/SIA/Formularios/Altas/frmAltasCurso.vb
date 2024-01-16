Public Class frmAltasCurso
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

    Private Sub frmAltasCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        Dim ctlModificar As Control = DirectCast(pbxModificar, Control)
        Dim keyprModificar = New KeyPressEventHandler(AddressOf btnModificar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        AddHandler ctlModificar.KeyPress, keyprModificar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Alta Curso"

        dgvCursos.DefaultCellStyle.ForeColor = Color.Black

        dgvCursos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)

        pbxNuevo.Select()
        CargarCursos()
    End Sub

    Private Sub CargarCursos()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCurso

        dgvCursos.RowTemplate.Height = 30
        dgvCursos.DataSource = _Dt
        dgvCursos.Columns("idCurso").Visible = False
        dgvCursos.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False
        dgvCursos.Columns("Usuarios_idUsuarios").Visible = False
        dgvCursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCursos.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCursos.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvCursos.Sort(dgvCursos.Columns("Año"), System.ComponentModel.ListSortDirection.Ascending)

        If dgvCursos.Rows.Count > 0 Then
            dgvCursos.ColumnHeadersVisible = True
        Else
            dgvCursos.ColumnHeadersVisible = False
        End If

        dgvCursos.ClearSelection()
        dgvCursos.CurrentCell = Nothing
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

    Private Sub dgvCursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellClick
        If dgvCursos.CurrentRow.Index > -1 Then
            txtAño.Text = dgvCursos.CurrentRow.Cells.Item(1).Value
            txtDivision.Text = dgvCursos.CurrentRow.Cells.Item(2).Value

            pbxModificar.Select()
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub Cancelar()
        gbxPPal.Enabled = False
        gbxCursos.Enabled = True

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        txtAño.Text = ""
        txtDivision.Text = ""
        txtOrigen.Text = ""

        pbxNuevo.Image = SIA.My.Resources.btnNuevoNo
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvCursos.CurrentCell = Nothing

        pbxNuevo.Focus()
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        ActivarCtrls(Me.Name)
        txtOrigen.Text = "Nuevo"

        pbxNuevo.Image = SIA.My.Resources.btnNuevoSi
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvCursos.CurrentCell = Nothing

        txtAño.Text = ""
        txtDivision.Text = ""

        txtAño.Select()
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        If txtAño.Text = "" Then
            MsgBox("Error: 'Año' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
            txtAño.Select()
        Else
            If txtDivision.Text = "" Then
                MsgBox("Error: 'Division' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                txtDivision.Select()
            Else
                Dim G As New GrabaDatos

                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable
                Dim ulTid As Integer = 0

                _Dt = _Ver.verCicloLectivo()
                ulTid = _Dt.Rows(_Dt.Rows.Count - 1).Item(0)

                _Dt = _Ver.verCurso_Año_Divsion(CInt(txtAño.Text), txtDivision.Text, ulTid)

                Dim resP As DialogResult
                If _Dt.Rows.Count < 1 Then
                    If txtOrigen.Text = "Nuevo" Then
                        resP = MessageBox.Show("Grabar nuevo curso ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                        If resP = Windows.Forms.DialogResult.OK Then
                            G.Grabar("Curso", "NoImagen", "sistema_asistencia.insCurso", CInt(txtAño.Text), txtDivision.Text, ulTid, frmIngresoSIA.txtIdUs.Text)

                            Cancelar()
                            CargarCursos()
                            MsgBox("Curso grabado con exito... !", vbInformation, "Servico de Alertas")
                        End If
                    Else
                        resP = MessageBox.Show("Modificar curso ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                        If resP = Windows.Forms.DialogResult.OK Then
                            G.Grabar("Curso", "NoImagen", "sistema_asistencia.modCurso", CInt(dgvCursos.CurrentRow.Cells.Item(0).Value), CInt(txtAño.Text), txtDivision.Text, frmIngresoSIA.txtIdUs.Text)

                            Cancelar()
                            CargarCursos()
                            MsgBox("Curso modificado con exito... !", vbInformation, "Servico de Alertas")
                        End If
                    End If
                Else
                    MsgBox("Error: El curso " & txtAño.Text & "° """ & txtDivision.Text & """ ya existe dentro de la base de datos... !", vbInformation, "Servico de Alertas")
                    txtAño.Select()
                End If
            End If
            End If
    End Sub

    Private Sub txtAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAño.KeyPress
        If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtDivision.SelectionLength = Len(txtDivision.Text)
            txtDivision.Select()
        End If
    End Sub

    Private Sub txtDivision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDivision.KeyPress
        If IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.Enter And e.KeyChar <> ChrW(8) Then
            e.Handled = True
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxEliminar_Click(sender As Object, e As EventArgs) Handles pbxEliminar.Click
        If dgvCursos.CurrentRow IsNot Nothing Then
            Dim G As New GrabaDatos
            Dim resP As DialogResult
            Dim _Ver As New Mostrar
            Dim _Dt As New DataTable

            _Dt = _Ver.consAlumno_Curso(dgvCursos.CurrentRow.Cells.Item(0).Value, frmIngresoSIA.txtCicloID.Text)

            If _Dt.Rows.Count < 1 Then
                _Dt = _Ver.verGrupo_Curso(dgvCursos.CurrentRow.Cells.Item(0).Value)

                If _Dt.Rows.Count < 1 Then
                    resP = MessageBox.Show("Seguro que quieres eliminar este curso ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = Windows.Forms.DialogResult.OK Then
                        G.Grabar("Curso", "NoImagen", "sistema_asistencia.elimCurso", dgvCursos.CurrentRow.Cells.Item(0).Value)

                        Cancelar()
                        CargarCursos()
                        MsgBox("Curso eliminado... !", vbInformation, "Servico de Alertas")
                    End If
                Else
                    MsgBox("Error: No puedes eliminar un curso que contiene grupos cargados... !", vbInformation, "Servico de Alertas")
                End If
            Else
                MsgBox("Error: No puedes eliminar un curso que contiene alumnos cargados... !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Selecciona un Curso de la lista para borrarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If dgvCursos.CurrentRow IsNot Nothing Then
            ActivarCtrls(Me.Name)
            txtOrigen.Text = "Modificar"

            pbxModificar.Image = SIA.My.Resources.btnModificarSi
            pbxNuevo.Image = SIA.My.Resources.btnNuevoNo

            txtAño.Select()
        Else
            MsgBox("Error: Selecciona un curso de la lista para poder modificarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub tmrElim_Tick(sender As Object, e As EventArgs) Handles tmrElim.Tick
        If dgvCursos.CurrentRow IsNot Nothing And txtOrigen.Text <> "Modificar" Then
            pbxEliminar.Enabled = True
        Else
            pbxEliminar.Enabled = False
        End If
    End Sub
End Class