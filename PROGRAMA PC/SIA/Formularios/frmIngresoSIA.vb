Public Class frmIngresoSIA

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

    Private Sub pbxIngresar_GotFocus(sender As Object, e As EventArgs) Handles pbxIngresar.GotFocus
        pbxIngresar.Image = SIA.My.Resources.btnIngresarSi
    End Sub

    Private Sub pbxIngresar_LostFocus(sender As Object, e As EventArgs) Handles pbxIngresar.LostFocus
        pbxIngresar.Image = SIA.My.Resources.btnIngresarNo
    End Sub

    Private Sub pbxIngresar_MouseEnter(sender As Object, e As EventArgs) Handles pbxIngresar.MouseEnter
        pbxIngresar.Image = SIA.My.Resources.btnIngresarSi
    End Sub

    Private Sub pbxIngresar_MouseLeave(sender As Object, e As EventArgs) Handles pbxIngresar.MouseLeave
        pbxIngresar.Image = SIA.My.Resources.btnIngresarNo
    End Sub

    Private Sub IngresoSIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlIngresar As Control = DirectCast(pbxIngresar, Control)
        Dim keyprIngresar = New KeyPressEventHandler(AddressOf btnIngresar)

        AddHandler ctlIngresar.KeyPress, keyprIngresar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia"

        CargarUsuarios()
        CargarCicloLectivo()
    End Sub

    Private Sub CargarUsuarios()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim X As Integer

        _Dt = _Ver.verUsuarios
        cbxUsuario.Items.Clear()
        If _Dt.Rows.Count > 0 Then
            For X = 0 To _Dt.Rows.Count - 1
                cbxUsuario.Items.Add(_Dt.Rows(X).Item("Nombre"))
            Next
        End If
    End Sub

    Private Sub CargarCicloLectivo()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim X As Integer

        _Dt = _Ver.verCicloLectivo()
        cbxCiclo.Items.Clear()
        If _Dt.Rows.Count > 0 Then
            For X = 0 To _Dt.Rows.Count - 1
                cbxCiclo.Items.Add(_Dt.Rows(X).Item("Año"))
                cbxCiclo.Text = _Dt.Rows(X).Item("Año")
                txtCiclo.Text = _Dt.Rows(X).Item("Año")
                txtCicloID.Text = _Dt.Rows(X).Item("idCiclo_Lectivo")
            Next
        End If
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        End
    End Sub

    Private Sub pbxIngresar_Click(sender As Object, e As EventArgs) Handles pbxIngresar.Click
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim resP As DialogResult

        If cbxUsuario.Text = "" Then
            MsgBox("Error: No hay usuario seleccionado !", vbInformation, "Servico de Alertas")
        Else
            If txtClave.Text = "" Then
                MsgBox("Error: No ingreso contraseña !", vbInformation, "Servico de Alertas")
            Else
                If txtCiclo.Text <> cbxCiclo.Text Then
                    resP = MessageBox.Show("Seleccionó un Ciclo Lectivo distinto al actual, Ingresa con este Ciclo ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = vbOK Then
                        _Dt = _Ver.consUsuarioContraseña(cbxUsuario.Text, txtClave.Text)
                        If _Dt.Rows.Count > 0 Then
                            txtIdUs.Text = _Dt.Rows(0).Item(0)
                            txtNombre.Text = _Dt.Rows(0).Item(1)
                            txtCategoria.Text = _Dt.Rows(0).Item(3)

                            frmPrincipal.Show()
                            Me.Hide()
                        Else
                            MsgBox("Error: Usuario y/o contraseña incorrectos !", vbInformation, "Servico de Alertas")
                        End If
                    End If
                Else
                    _Dt = _Ver.consUsuarioContraseña(cbxUsuario.Text, txtClave.Text)
                    If _Dt.Rows.Count > 0 Then
                        txtIdUs.Text = _Dt.Rows(0).Item(0)
                        txtNombre.Text = _Dt.Rows(0).Item(1)
                        txtCategoria.Text = _Dt.Rows(0).Item(3)

                        frmPrincipal.Show()
                        Me.Hide()
                    Else
                        MsgBox("Error: Usuario y/o contraseña incorrectos !", vbInformation, "Servico de Alertas")
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cbxUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxUsuario.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtClave.SelectionLength = Len(txtClave.Text)
            txtClave.Select()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxIngresar.Select()
        End If
    End Sub

    Private Sub btnIngresar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxIngresar_Click(1, Nothing)
        End If
    End Sub

    Private Sub chbCiclo_CheckedChanged(sender As Object, e As EventArgs) Handles chbCiclo.CheckedChanged
        If chbCiclo.Checked = True Then
            cbxCiclo.Enabled = True
            lblCilco.Enabled = True
        Else
            cbxCiclo.Text = txtCiclo.Text
            cbxCiclo.Enabled = False
            lblCilco.Enabled = False
        End If
    End Sub

    Private Sub cbxCiclo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCiclo.SelectedIndexChanged
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCicloLectivoAño(cbxCiclo.Text)
        txtCicloID.Text = _Dt.Rows(0).Item("idCiclo_Lectivo")
    End Sub
End Class