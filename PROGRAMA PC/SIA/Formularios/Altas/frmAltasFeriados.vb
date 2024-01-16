Imports System
Imports System.Windows.Forms

Public Class frmAltasFeriados
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

    Private Sub frmAltasGrupo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        Dim ctlEliminar As Control = DirectCast(pbxEliminar, Control)
        Dim keyprEliminar = New KeyPressEventHandler(AddressOf btnEliminar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        AddHandler ctlEliminar.KeyPress, keyprEliminar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Alta Feriado / Paro"

        dgvFeriados.DefaultCellStyle.ForeColor = Color.Black

        dgvFeriados.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)

        mtcCalendario.MinDate = Date.Now.Date
        mtcCalendario.MaxDate = New DateTime((Date.Now.Year + 1), 1, 1).AddDays(-1)

        lblFecSel.Text = Format(Date.Now.Date, "dd/MM/yyyy")

        CargarFeriado()
        pbxNuevo.Select()
    End Sub

    Private Sub CargarFeriado()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verFeriado_Paro

        dgvFeriados.RowTemplate.Height = 30
        dgvFeriados.DataSource = _Dt
        dgvFeriados.Columns("idFeriados_Paros").Visible = False
        dgvFeriados.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False
        dgvFeriados.Columns("Usuarios_idUsuarios").Visible = False
        dgvFeriados.Columns("Fecha").Width = 100
        dgvFeriados.Columns("Motivo").Width = 398
        dgvFeriados.Columns("Fecha").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvFeriados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        If dgvFeriados.Rows.Count > 0 Then
            dgvFeriados.ColumnHeadersVisible = True
        Else
            dgvFeriados.ColumnHeadersVisible = False
        End If

        dgvFeriados.Sort(dgvFeriados.Columns("Fecha"), System.ComponentModel.ListSortDirection.Ascending)

        dgvFeriados.ClearSelection()
        dgvFeriados.CurrentCell = Nothing
    End Sub

    Private Sub btnNuevo(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxNuevo_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnEliminar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxEliminar_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub Cancelar()
        mtcCalendario.Enabled = False
        gbxFeriados.Enabled = True
        txtMotivo.Enabled = False

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxEliminar.Enabled = True
        pbxSalir.Enabled = True

        txtFecha.Text = ""
        txtMotivo.Text = ""

        pbxNuevo.Image = SIA.My.Resources.btnNuevoNo

        dgvFeriados.CurrentCell = Nothing

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

        pbxNuevo.Image = SIA.My.Resources.btnNuevoSi

        dgvFeriados.CurrentCell = Nothing
    End Sub

    Private Sub pbxEliminar_Click(sender As Object, e As EventArgs) Handles pbxEliminar.Click
        If dgvFeriados.CurrentRow IsNot Nothing Then
            Dim G As New GrabaDatos
            Dim resP As DialogResult

            resP = MessageBox.Show("Eliminar feriado / paro ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                G.Grabar("Feriados_Paros", "NoImagen", "sistema_asistencia.elimFeriado_Paro", dgvFeriados.CurrentRow.Cells.Item(0).Value)

                CargarFeriado()
                pbxNuevo.Select()
            End If
        Else
            MsgBox("Error: Selecciona un feriado / paro de la lista para poder eliminarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        If txtFecha.Text = "" Then
            MsgBox("Error: Selecciona la a fecha a guardar como paro o feriado... !", vbInformation, "Servico de Alertas")
        Else
            If txtMotivo.Text = "" Then
                MsgBox("Error: El Motivo no puede quedar vacío !", vbInformation, "Servico de Alertas")
            Else
                Dim G As New GrabaDatos
                Dim resP As DialogResult
                Dim uLtID As Integer
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                _Dt = _Ver.verCicloLectivo()
                uLtID = _Dt.Rows(_Dt.Rows.Count - 1).Item(0)

                _Dt = _Ver.verFeriado_Paro_Fecha(txtFecha.Text)

                If _Dt.Rows.Count < 1 Then

                    resP = MessageBox.Show("Grabar nuevo feriado / paro ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = Windows.Forms.DialogResult.OK Then
                        G.Grabar("Feriados_Paros", "NoImagen", "sistema_asistencia.insFeriado_Paro", Format(CDate(txtFecha.Text), "yyyy/MM/dd"),
                        txtMotivo.Text, uLtID, CInt(frmIngresoSIA.txtIdUs.Text))

                        Cancelar()
                        CargarFeriado()
                        MsgBox("Feriado / paro grabado con exito... !", vbInformation, "Servico de Alertas")
                    End If
                Else
                    MsgBox("Error: El dia " & txtFecha.Text & " ya existe dentro de la base de datos grabado como feriado / paro... !", vbInformation, "Servico de Alertas")
                End If
            End If
        End If
    End Sub

    Private Sub mtcCalendario_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mtcCalendario.DateChanged
        txtFecha.Text = mtcCalendario.SelectionRange.End.ToShortDateString()
        lblFecSel.Text = mtcCalendario.SelectionRange.End.ToShortDateString()
    End Sub

    Private Sub dgvFeriados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFeriados.CellClick
        If dgvFeriados.CurrentRow.Index > -1 Then
            pbxEliminar.Select()
        End If
    End Sub

    Private Sub txtMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMotivo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardar.Select()
        End If
    End Sub
End Class