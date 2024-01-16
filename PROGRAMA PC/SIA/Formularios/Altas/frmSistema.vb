Imports System
Imports System.Net
Imports System.Net.Dns
Imports System.DirectoryServices
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Threading
Imports System.Text

Public Class frmSistema
    Private Sub pbxUsuario_GotFocus(sender As Object, e As EventArgs) Handles pbxUsuario.GotFocus
        If (gbxUsuarios.Visible = False) Then
            pbxUsuario.Image = SIA.My.Resources.btnUsuariosSi
        End If
    End Sub

    Private Sub pbxUsuario_LostFocus(sender As Object, e As EventArgs) Handles pbxUsuario.LostFocus
        If (gbxUsuarios.Visible = False) Then
            pbxUsuario.Image = SIA.My.Resources.btnUsuariosNo
        End If
    End Sub

    Private Sub pbxUsuario_MouseEnter(sender As Object, e As EventArgs) Handles pbxUsuario.MouseEnter
        If (gbxUsuarios.Visible = False) Then
            pbxUsuario.Image = SIA.My.Resources.btnUsuariosSi
        End If
    End Sub

    Private Sub pbxUsuario_MouseLeave(sender As Object, e As EventArgs) Handles pbxUsuario.MouseLeave
        If (gbxUsuarios.Visible = False) Then
            pbxUsuario.Image = SIA.My.Resources.btnUsuariosNo
        End If
    End Sub

    Private Sub pbxCiclo_GotFocus(sender As Object, e As EventArgs) Handles pbxCiclo.GotFocus
        If (gbxCiclo.Visible = False) Then
            pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoSi
        End If
    End Sub

    Private Sub pbxCiclo_LostFocus(sender As Object, e As EventArgs) Handles pbxCiclo.LostFocus
        If (gbxCiclo.Visible = False) Then
            pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoNo
        End If
    End Sub

    Private Sub pbxCiclo_MouseEnter(sender As Object, e As EventArgs) Handles pbxCiclo.MouseEnter
        If (gbxCiclo.Visible = False) Then
            pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoSi
        End If
    End Sub

    Private Sub pbxCiclo_MouseLeave(sender As Object, e As EventArgs) Handles pbxCiclo.MouseLeave
        If (gbxCiclo.Visible = False) Then
            pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoNo
        End If
    End Sub
    Private Sub pbxLectores_GotFocus(sender As Object, e As EventArgs) Handles pbxLectores.GotFocus
        If (gbxLectores.Visible = False) Then
            pbxLectores.Image = SIA.My.Resources.btnLectoresSi
        End If
    End Sub

    Private Sub pbxLectores_LostFocus(sender As Object, e As EventArgs) Handles pbxLectores.LostFocus
        If (gbxLectores.Visible = False) Then
            pbxLectores.Image = SIA.My.Resources.btnLectoresNo
        End If
    End Sub

    Private Sub pbxLectores_MouseEnter(sender As Object, e As EventArgs) Handles pbxLectores.MouseEnter
        If (gbxLectores.Visible = False) Then
            pbxLectores.Image = SIA.My.Resources.btnLectoresSi
        End If
    End Sub

    Private Sub pbxLectores_MouseLeave(sender As Object, e As EventArgs) Handles pbxLectores.MouseLeave
        If (gbxLectores.Visible = False) Then
            pbxLectores.Image = SIA.My.Resources.btnLectoresNo
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

    Private Sub pbxCancelarUsuario_GotFocus(sender As Object, e As EventArgs) Handles pbxCancelarUs.GotFocus, pbxCancelarLector.GotFocus
        pbxCancelarUs.Image = SIA.My.Resources.btnCancelarSi
        pbxCancelarLector.Image = SIA.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelarUsuario_LostFocus(sender As Object, e As EventArgs) Handles pbxCancelarUs.LostFocus, pbxCancelarLector.LostFocus
        pbxCancelarUs.Image = SIA.My.Resources.btnCancelarNo
        pbxCancelarLector.Image = SIA.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxCancelarUsuario_MouseEnter(sender As Object, e As EventArgs) Handles pbxCancelarUs.MouseEnter, pbxCancelarLector.MouseEnter
        pbxCancelarUs.Image = SIA.My.Resources.btnCancelarSi
        pbxCancelarLector.Image = SIA.My.Resources.btnCancelarSi
    End Sub

    Private Sub pbxCancelarUsuario_MouseLeave(sender As Object, e As EventArgs) Handles pbxCancelarUs.MouseLeave, pbxCancelarLector.MouseLeave
        pbxCancelarUs.Image = SIA.My.Resources.btnCancelarNo
        pbxCancelarLector.Image = SIA.My.Resources.btnCancelarNo
    End Sub

    Private Sub pbxGuardarUsuario_GotFocus(sender As Object, e As EventArgs) Handles pbxGuardarUs.GotFocus, pbxGuardarLector.GotFocus
        pbxGuardarUs.Image = SIA.My.Resources.btnGuardarSi
        pbxGuardarLector.Image = SIA.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardarUsuario_LostFocus(sender As Object, e As EventArgs) Handles pbxGuardarUs.LostFocus, pbxGuardarLector.LostFocus
        pbxGuardarUs.Image = SIA.My.Resources.btnGuardarNo
        pbxGuardarLector.Image = SIA.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxGuardarUsuario_MouseEnter(sender As Object, e As EventArgs) Handles pbxGuardarUs.MouseEnter, pbxGuardarLector.MouseEnter
        pbxGuardarUs.Image = SIA.My.Resources.btnGuardarSi
        pbxGuardarLector.Image = SIA.My.Resources.btnGuardarSi
    End Sub

    Private Sub pbxGuardarUsuario_MouseLeave(sender As Object, e As EventArgs) Handles pbxGuardarUs.MouseLeave, pbxGuardarLector.MouseLeave
        pbxGuardarUs.Image = SIA.My.Resources.btnGuardarNo
        pbxGuardarLector.Image = SIA.My.Resources.btnGuardarNo
    End Sub

    Private Sub pbxModificarUsuario_GotFocus(sender As Object, e As EventArgs) Handles pbxModificarUs.GotFocus
        If (pbxModificarUs.Enabled = True) Then
            pbxModificarUs.Image = SIA.My.Resources.btnModificarSi
        End If
    End Sub

    Private Sub pbxModificarUsuario_LostFocus(sender As Object, e As EventArgs) Handles pbxModificarUs.LostFocus
        If (pbxModificarUs.Enabled = True) Then
            pbxModificarUs.Image = SIA.My.Resources.btnModificarNo
        End If
    End Sub

    Private Sub pbxModificarUsuario_MouseEnter(sender As Object, e As EventArgs) Handles pbxModificarUs.MouseEnter
        If (pbxModificarUs.Enabled = True) Then
            pbxModificarUs.Image = SIA.My.Resources.btnModificarSi
        End If
    End Sub

    Private Sub pbxModificarUsuario_MouseLeave(sender As Object, e As EventArgs) Handles pbxModificarUs.MouseLeave
        If (pbxModificarUs.Enabled = True) Then
            pbxModificarUs.Image = SIA.My.Resources.btnModificarNo
        End If
    End Sub

    Private Sub pbxNuevoUsuario_GotFocus(sender As Object, e As EventArgs) Handles pbxNuevoUs.GotFocus
        If (pbxNuevoUs.Enabled = True) Then
            pbxNuevoUs.Image = SIA.My.Resources.btnNuevoSi
        End If
    End Sub

    Private Sub pbxNuevoUsuario_LostFocus(sender As Object, e As EventArgs) Handles pbxNuevoUs.LostFocus
        If (pbxNuevoUs.Enabled = True) Then
            pbxNuevoUs.Image = SIA.My.Resources.btnNuevoNo
        End If
    End Sub

    Private Sub pbxNuevoUsuario_MouseEnter(sender As Object, e As EventArgs) Handles pbxNuevoUs.MouseEnter
        If (pbxNuevoUs.Enabled = True) Then
            pbxNuevoUs.Image = SIA.My.Resources.btnNuevoSi
        End If
    End Sub

    Private Sub pbxNuevoUsuario_MouseLeave(sender As Object, e As EventArgs) Handles pbxNuevoUs.MouseLeave
        If (pbxNuevoUs.Enabled = True) Then
            pbxNuevoUs.Image = SIA.My.Resources.btnNuevoNo
        End If
    End Sub

    Private Sub pbxEliminarUsuario_GotFocus(sender As Object, e As EventArgs) Handles pbxEliminarUs.GotFocus
        If (pbxEliminarUs.Enabled = True) Then
            pbxEliminarUs.Image = SIA.My.Resources.btnEliminarSi
        End If
    End Sub

    Private Sub pbxEliminarUsuario_LostFocus(sender As Object, e As EventArgs) Handles pbxEliminarUs.LostFocus
        If (pbxEliminarUs.Enabled = True) Then
            pbxEliminarUs.Image = SIA.My.Resources.btnEliminarNo
        End If
    End Sub

    Private Sub pbxEliminarUsuario_MouseEnter(sender As Object, e As EventArgs) Handles pbxEliminarUs.MouseEnter
        If (pbxEliminarUs.Enabled = True) Then
            pbxEliminarUs.Image = SIA.My.Resources.btnEliminarSi
        End If
    End Sub

    Private Sub pbxEliminarUsuario_MouseLeave(sender As Object, e As EventArgs) Handles pbxEliminarUs.MouseLeave
        If (pbxEliminarUs.Enabled = True) Then
            pbxEliminarUs.Image = SIA.My.Resources.btnEliminarNo
        End If
    End Sub

    Private Sub pbxConfigLector_GotFocus(sender As Object, e As EventArgs) Handles pbxConfigLector.GotFocus
        If (pbxConfigLector.Enabled = True) Then
            pbxConfigLector.Image = SIA.My.Resources.btnConfigurarLectorSi
        End If
    End Sub

    Private Sub pbxConfigLector_LostFocus(sender As Object, e As EventArgs) Handles pbxConfigLector.LostFocus
        If (pbxConfigLector.Enabled = True) Then
            pbxConfigLector.Image = SIA.My.Resources.btnConfigurarLectorNo
        End If
    End Sub

    Private Sub pbxConfigLector_MouseEnter(sender As Object, e As EventArgs) Handles pbxConfigLector.MouseEnter
        If (pbxConfigLector.Enabled = True) Then
            pbxConfigLector.Image = SIA.My.Resources.btnConfigurarLectorSi
        End If
    End Sub

    Private Sub pbxConfigLector_MouseLeave(sender As Object, e As EventArgs) Handles pbxConfigLector.MouseLeave
        If (pbxConfigLector.Enabled = True) Then
            pbxConfigLector.Image = SIA.My.Resources.btnConfigurarLectorNo
        End If
    End Sub

    Private Sub pbxIpServer_GotFocus(sender As Object, e As EventArgs) Handles pbxIpServer.GotFocus
        If (pbxIpServer.Enabled = True) Then
            pbxIpServer.Image = SIA.My.Resources.btnIPServidorSi
        End If
    End Sub

    Private Sub pbxIpServer_LostFocus(sender As Object, e As EventArgs) Handles pbxIpServer.LostFocus
        If (pbxIpServer.Enabled = True) Then
            pbxIpServer.Image = SIA.My.Resources.btnIPServidorNo
        End If
    End Sub

    Private Sub pbxIpServer_MouseEnter(sender As Object, e As EventArgs) Handles pbxIpServer.MouseEnter
        If (pbxIpServer.Enabled = True) Then
            pbxIpServer.Image = SIA.My.Resources.btnIPServidorSi
        End If
    End Sub

    Private Sub pbxIpServer_MouseLeave(sender As Object, e As EventArgs) Handles pbxIpServer.MouseLeave
        If (pbxIpServer.Enabled = True) Then
            pbxIpServer.Image = SIA.My.Resources.btnIPServidorNo
        End If
    End Sub

    Private Sub pbxTolerancia_GotFocus(sender As Object, e As EventArgs) Handles pbxTolerancia.GotFocus
        If (pbxTolerancia.Enabled = True) Then
            pbxTolerancia.Image = SIA.My.Resources.btnToleranciaSi
        End If
    End Sub

    Private Sub pbxTolerancia_LostFocus(sender As Object, e As EventArgs) Handles pbxTolerancia.LostFocus
        If (pbxTolerancia.Enabled = True) Then
            pbxTolerancia.Image = SIA.My.Resources.btnToleranciaNo
        End If
    End Sub

    Private Sub pbxTolerancia_MouseEnter(sender As Object, e As EventArgs) Handles pbxTolerancia.MouseEnter
        If (pbxTolerancia.Enabled = True) Then
            pbxTolerancia.Image = SIA.My.Resources.btnToleranciaSi
        End If
    End Sub

    Private Sub pbxTolerancia_MouseLeave(sender As Object, e As EventArgs) Handles pbxTolerancia.MouseLeave
        If (pbxTolerancia.Enabled = True) Then
            pbxTolerancia.Image = SIA.My.Resources.btnToleranciaNo
        End If
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        CancelarUs()
        CancelarLector()
        dgvLectores.ColumnHeadersVisible = False
        Me.Close()
    End Sub

    Private Sub pbxUsuario_Click(sender As Object, e As EventArgs) Handles pbxUsuario.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        pbxUsuario.Image = SIA.My.Resources.btnUsuariosSi
        pbxLectores.Image = SIA.My.Resources.btnLectoresNo
        pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoNo

        gbxUsuarios.Visible = True
        gbxLectores.Visible = False
        gbxCiclo.Visible = False
        gbxPPal.Visible = False


        _Dt = _Ver.verUsuarios
        If _Dt.Rows.Count > 0 Then
            dgvUsuariosExistentes.DataSource = _Dt
            dgvUsuariosExistentes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            dgvUsuariosExistentes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            dgvUsuariosExistentes.Columns(0).Visible = False
            dgvUsuariosExistentes.Columns(2).Visible = False
        End If

        CancelarLector()
        tmrTiempoScan.Enabled = False

        Dim rows As Integer = dgvLectores.Rows.Count - 1

        If dgvLectores.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvLectores.Rows.Remove(dgvLectores.Rows(j))
            Next
        End If

        lblBarra.Visible = False
        gbxLectoresConectados.Enabled = True

        pbxNuevoUs.Select()
        dgvUsuariosExistentes.CurrentCell = Nothing
    End Sub

    Private Sub pbxCiclo_Click(sender As Object, e As EventArgs) Handles pbxCiclo.Click
        pbxUsuario.Image = SIA.My.Resources.btnUsuariosNo
        pbxLectores.Image = SIA.My.Resources.btnLectoresNo
        pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoSi

        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verCicloLectivo
        If _Dt.Rows.Count > 0 Then
            dgvCicloLec.DataSource = _Dt
            dgvCicloLec.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            dgvCicloLec.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            dgvCicloLec.RowTemplate.Height = 50
            dgvCicloLec.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCicloLec.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvCicloLec.Columns(0).Visible = False
            dgvCicloLec.Columns(2).Visible = False
        End If

        txtUltCL.Text = _Dt.Rows(_Dt.Rows.Count - 1).Item("Año")

        CancelarUs()
        CancelarLector()
        tmrTiempoScan.Enabled = False

        gbxCiclo.Visible = True
        gbxLectores.Visible = False
        gbxUsuarios.Visible = False
        gbxPPal.Visible = False

        Dim rows As Integer = dgvLectores.Rows.Count - 1

        If dgvLectores.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvLectores.Rows.Remove(dgvLectores.Rows(j))
            Next
        End If

        lblBarra.Visible = False
        gbxLectoresConectados.Enabled = True
    End Sub

    Private Sub pbxLectores_Click(sender As Object, e As EventArgs) Handles pbxLectores.Click
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        pbxUsuario.Image = SIA.My.Resources.btnUsuariosNo
        pbxLectores.Image = SIA.My.Resources.btnLectoresSi
        pbxCiclo.Image = SIA.My.Resources.btnCicloLectivoNo
        gbxLectores.Visible = True
        gbxCiclo.Visible = False
        gbxUsuarios.Visible = False
        gbxPPal.Visible = False
        lblBarra.Top = 420
        lblBarra.Left = 290

        _Dt = _Ver.verIPServidor

        If _Dt.Rows.Count > 0 Then
            Dim X As Integer = 1
            Dim Y As Integer = 0
            Dim ip1 As String = ""
            Dim ip2 As String = ""
            Dim ip3 As String = ""
            Dim ip4 As String = ""

            Dim cdnIP As String = _Dt.Rows(0).Item("IP")
            For X = 1 To Len(cdnIP)
                If Mid(cdnIP, X, 1) = "." Then
                    Y = Y + 1
                Else
                    If Y = 0 Then
                        ip1 = ip1 & Mid(cdnIP, X, 1)
                    ElseIf Y = 1 Then
                        ip2 = ip2 & Mid(cdnIP, X, 1)
                    ElseIf Y = 2 Then
                        ip3 = ip3 & Mid(cdnIP, X, 1)
                    ElseIf Y = 3 Then
                        ip4 = ip4 & Mid(cdnIP, X, 1)
                    End If
                End If
            Next
            txtIPS1.Text = ip1
            txtIPS2.Text = ip2
            txtIPS3.Text = ip3
            txtIPS4.Text = ip4
        End If

        _Dt = _Ver.verTolerancia
        If _Dt.Rows.Count > 0 Then
            txtTarde.Text = _Dt.Rows(0).Item("Llegada_Tarde")
            txtAusente.Text = _Dt.Rows(0).Item("Ausente")
        End If

        CancelarUs()

        Dim PE As String = NetworkGateway()

        If PE IsNot Nothing Then
            Dim Array As String() = PE.Split("."c)

            btnRescan.Enabled = True

            If Array(0) = "192" Then
                txtIPD1.Text = Array(0)
                txtIPD2.Text = Array(1)
                txtIPD3.Text = Array(2)

                txtIPH1.Text = Array(0)
                txtIPH2.Text = Array(1)
                txtIPH3.Text = Array(2)

                txtIPD1.Enabled = False
                txtIPD2.Enabled = False
                txtIPD3.Enabled = False
                txtIPD4.Enabled = True

                txtIPH1.Enabled = False
                txtIPH2.Enabled = False
                txtIPH3.Enabled = False
                txtIPH4.Enabled = True
            ElseIf Array(0) = "172" Or Array(0) = "169" Then
                txtIPD1.Text = Array(0)
                txtIPD2.Text = Array(1)

                txtIPH1.Text = Array(0)
                txtIPH2.Text = Array(1)

                txtIPD1.Enabled = False
                txtIPD2.Enabled = False
                txtIPD3.Enabled = True
                txtIPD4.Enabled = True

                txtIPH1.Enabled = False
                txtIPH2.Enabled = False
                txtIPH3.Enabled = True
                txtIPH4.Enabled = True
            ElseIf Array(0) = "10" Then
                txtIPD1.Text = Array(0)

                txtIPH1.Text = Array(0)

                txtIPD1.Enabled = False
                txtIPD2.Enabled = True
                txtIPD3.Enabled = True
                txtIPD4.Enabled = True

                txtIPH1.Enabled = False
                txtIPH2.Enabled = True
                txtIPH3.Enabled = True
                txtIPH4.Enabled = True
            End If
        Else
            txtIPD1.Enabled = False
            txtIPD2.Enabled = False
            txtIPD3.Enabled = False
            txtIPD4.Enabled = False

            txtIPH1.Enabled = False
            txtIPH2.Enabled = False
            txtIPH3.Enabled = False
            txtIPH4.Enabled = False

            txtIPD1.Text = "-"
            txtIPD2.Text = "-"
            txtIPD3.Text = "-"
            txtIPD4.Text = "-"

            txtIPH1.Text = "-"
            txtIPH2.Text = "-"
            txtIPH3.Text = "-"
            txtIPH4.Text = "-"

            txtIPS1.Text = "-"
            txtIPS2.Text = "-"
            txtIPS3.Text = "-"
            txtIPS4.Text = "-"

            btnRescan.Enabled = False

            MsgBox("Error: No estas conectado a ninguna Red... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub frmSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevoUs As Control = DirectCast(pbxNuevoUs, Control)
        Dim keyprNuevoUs = New KeyPressEventHandler(AddressOf btnNuevoUs)

        Dim ctlGuardarUs As Control = DirectCast(pbxGuardarUs, Control)
        Dim keyprGuardarUs = New KeyPressEventHandler(AddressOf btnGuardarUs)

        Dim ctlModificarUs As Control = DirectCast(pbxModificarUs, Control)
        Dim keyprModificarUs = New KeyPressEventHandler(AddressOf btnModificarUs)

        Dim ctlGuardarLector As Control = DirectCast(pbxGuardarLector, Control)
        Dim keyprGuardarLector = New KeyPressEventHandler(AddressOf btnGuardarLector)

        AddHandler ctlNuevoUs.KeyPress, keyprNuevoUs
        AddHandler ctlGuardarUs.KeyPress, keyprGuardarUs
        AddHandler ctlModificarUs.KeyPress, keyprModificarUs
        AddHandler ctlGuardarLector.KeyPress, keyprGuardarLector

        dgvUsuariosExistentes.DefaultCellStyle.ForeColor = Color.Black
        dgvLectores.DefaultCellStyle.ForeColor = Color.Black

        dgvUsuariosExistentes.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
        dgvLectores.DefaultCellStyle.Font = New Font("OCR A", 11, FontStyle.Regular)
        dgvLectores.AlternatingRowsDefaultCellStyle.Font = New Font("OCR A", 11, FontStyle.Regular)

        dgvLectores.RowTemplate.Height = 25
        dgvLectores.ColumnCount = 6
        dgvLectores.Columns(0).Name = "NOMBRE"
        dgvLectores.Columns(1).Name = "MAC"
        dgvLectores.Columns(2).Name = "IP"
        dgvLectores.Columns(3).Name = "P. ENLACE"
        dgvLectores.Columns(4).Name = "DHCP"
        dgvLectores.Columns(5).Name = "IP SERVER"


        dgvLectores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvLectores.Columns("NOMBRE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvLectores.Columns("MAC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvLectores.Columns("IP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvLectores.Columns("P. ENLACE").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvLectores.Columns("DHCP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvLectores.Columns("IP SERVER").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'dgvLectores.Columns("Año").Width = 50
        'dgvLectores.Columns("Divc").Width = 50
        'dgvLectores.Columns("Grp").Width = 100
        'dgvLectores.Columns("Día").Width = 90
        'dgvLectores.Columns("Trn").Width = 80
        'dgvLectores.Columns("Hr_Ing").Width = 70
        'dgvLectores.Columns("Tipo").Width = 110
        dgvLectores.Sort(dgvLectores.Columns("IP"), System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub btnNuevoUs(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxNuevoUs_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnModificarUs(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxModificarUs_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardarLector(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardarLector_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnGuardarUs(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardarUs_Click(1, Nothing)
        End If
    End Sub

    '---------------------------------------------------------------------------------------------------------------

    Private Sub pbxNuevoUs_Click(sender As Object, e As EventArgs) Handles pbxNuevoUs.Click
        pbxNuevoUs.Enabled = False
        pbxModificarUs.Enabled = False
        pbxEliminarUs.Enabled = False
        pbxCancelarUs.Enabled = True
        pbxGuardarUs.Enabled = True

        gbxInfoUsuarios.Enabled = True
        gbxUsuariosExistentes.Enabled = False

        pbxNuevoUs.Image = SIA.My.Resources.btnNuevoSi
        pbxModificarUs.Image = SIA.My.Resources.btnModificarNo

        txtNombreUs.Text = ""
        txtContraseñaUs.Text = ""
        txtCargoUs.Text = ""

        txtOrigen.Text = "Nuevo"

        txtNombreUs.Select()
        dgvUsuariosExistentes.CurrentCell = Nothing
    End Sub

    Private Sub CancelarUs()
        pbxNuevoUs.Enabled = True
        pbxModificarUs.Enabled = True
        pbxEliminarUs.Enabled = True
        pbxCancelarUs.Enabled = False
        pbxGuardarUs.Enabled = False

        gbxInfoUsuarios.Enabled = False
        gbxUsuariosExistentes.Enabled = True

        txtOrigen.Text = ""

        pbxNuevoUs.Image = SIA.My.Resources.btnNuevoNo
        pbxModificarUs.Image = SIA.My.Resources.btnModificarNo

        txtRepitaContraseñaUs.Text = ""
        txtNombreUs.Text = ""
        txtContraseñaUs.Text = ""
        txtCargoUs.Text = ""

        txtNombreUs.Select()
        dgvUsuariosExistentes.CurrentCell = Nothing
    End Sub

    Private Sub CargarUsuarios()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        _Dt = _Ver.verUsuarios

        dgvUsuariosExistentes.RowTemplate.Height = 25
        dgvUsuariosExistentes.DataSource = _Dt
        dgvUsuariosExistentes.Columns("idUsuarios").Visible = False
        dgvUsuariosExistentes.Columns("Clave").Visible = False

        dgvUsuariosExistentes.Sort(dgvUsuariosExistentes.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

        If dgvUsuariosExistentes.Rows.Count > 0 Then
            dgvUsuariosExistentes.ColumnHeadersVisible = True
        Else
            dgvUsuariosExistentes.ColumnHeadersVisible = False
        End If

        dgvUsuariosExistentes.ClearSelection()
        dgvUsuariosExistentes.CurrentCell = Nothing
    End Sub

    Private Sub pbxModificarUs_Click(sender As Object, e As EventArgs) Handles pbxModificarUs.Click
        If dgvUsuariosExistentes.CurrentRow IsNot Nothing Then
            pbxNuevoUs.Enabled = False
            pbxModificarUs.Enabled = False
            pbxEliminarUs.Enabled = False
            pbxCancelarUs.Enabled = True
            pbxGuardarUs.Enabled = True

            gbxInfoUsuarios.Enabled = True
            gbxUsuariosExistentes.Enabled = False

            pbxNuevoUs.Image = SIA.My.Resources.btnNuevoNo
            pbxModificarUs.Image = SIA.My.Resources.btnModificarSi

            txtOrigen.Text = "Modificar"
        Else
            MsgBox("Error: Selecciona un Usuario de la lista para poder modificarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxGuardarUs_Click(sender As Object, e As EventArgs) Handles pbxGuardarUs.Click
        If txtNombreUs.Text = "" Then
            MsgBox("Error: 'Nombre' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
            txtNombreUs.Select()
        Else
            If txtCargoUs.Text = "" Then
                MsgBox("Error: 'Cargo' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                txtCargoUs.Select()
            Else
                If txtContraseñaUs.Text = "" Then
                    MsgBox("Error: No has ingresado una Contraseña... !", vbInformation, "Servico de Alertas")
                    txtContraseñaUs.Select()
                Else
                    If txtContraseñaUs.Text <> txtRepitaContraseñaUs.Text Then
                        MsgBox("Error: Las Contraseñas no coinciden... !", vbInformation, "Servico de Alertas")
                        txtRepitaContraseñaUs.Text = ""
                        txtRepitaContraseñaUs.Select()
                    Else
                        Dim G As New GrabaDatos
                        Dim resP As DialogResult
                        Dim _Ver As New Mostrar
                        Dim _Dt As New DataTable

                        _Dt = _Ver.verUsuario_Nombre(txtNombreUs.Text)

                        If txtOrigen.Text = "Nuevo" Then
                            If _Dt.Rows.Count < 1 Then
                                resP = MessageBox.Show("Grabar nuevo Usuario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                If resP = Windows.Forms.DialogResult.OK Then
                                    G.Grabar("Usuarios", "NoImagen", "sistema_asistencia.insUsuario", txtNombreUs.Text, txtContraseñaUs.Text, txtCargoUs.Text)

                                    CancelarUs()
                                    CargarUsuarios()
                                    MsgBox("Usuario grabado con exito... !", vbInformation, "Servico de Alertas")
                                End If
                            Else
                                MsgBox("Error: El Usuario """ & txtNombreUs.Text & """ ya existe dentro de la base de datos... !", vbInformation, "Servico de Alertas")

                                txtNombreUs.SelectionLength = Len(txtNombreUs.Text)
                                txtNombreUs.Select()
                            End If
                        Else
                            If _Dt.Rows.Count < 1 Or dgvUsuariosExistentes.CurrentRow.Cells.Item("Nombre").Value = txtNombreUs.Text Then
                                resP = MessageBox.Show("Modificar Usuario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                                If resP = Windows.Forms.DialogResult.OK Then
                                    G.Grabar("Usuarios", "NoImagen", "sistema_asistencia.modUsuario", dgvUsuariosExistentes.CurrentRow.Cells.Item("idUsuarios").Value, _
                                             txtNombreUs.Text, txtContraseñaUs.Text, txtCargoUs.Text)

                                    CancelarUs()
                                    CargarUsuarios()
                                    MsgBox("Usuario modificado con exito... !", vbInformation, "Servico de Alertas")
                                End If
                            Else
                                MsgBox("Error: El Usuario """ & txtNombreUs.Text & """ ya existe dentro de la base de datos... !", vbInformation, "Servico de Alertas")

                                txtNombreUs.SelectionLength = Len(txtNombreUs.Text)
                                txtNombreUs.Select()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtNombreUs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreUs.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtCargoUs.SelectionLength = Len(txtCargoUs.Text)
            txtCargoUs.Select()
        End If
    End Sub

    Private Sub txtCargoUs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCargoUs.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtContraseñaUs.SelectionLength = Len(txtContraseñaUs.Text)
            txtContraseñaUs.Select()
        End If
    End Sub

    Private Sub txtContraseñaUs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseñaUs.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtRepitaContraseñaUs.SelectionLength = Len(txtRepitaContraseñaUs.Text)
            txtRepitaContraseñaUs.Select()
        End If
    End Sub

    Private Sub txtRepitaContraseñaUs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRepitaContraseñaUs.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardarUs.Select()
        End If
    End Sub

    Private Sub pbxEliminarUs_Click(sender As Object, e As EventArgs) Handles pbxEliminarUs.Click
        If dgvUsuariosExistentes.CurrentRow IsNot Nothing Then
            Dim G As New GrabaDatos
            Dim resP As DialogResult

            resP = MessageBox.Show("Seguro que quieres eliminar este Usuario ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                G.Grabar("Usuarios", "NoImagen", "sistema_asistencia.elimUsuario", dgvUsuariosExistentes.CurrentRow.Cells.Item(0).Value)

                CancelarUs()
                CargarUsuarios()
                MsgBox("Usuario eliminado... !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Selecciona un Usuario de la lista para borrarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxCancelarUs_Click(sender As Object, e As EventArgs) Handles pbxCancelarUs.Click
        CancelarUs()
    End Sub

    Private Sub dgvUsuariosExistentes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuariosExistentes.CellClick
        If dgvUsuariosExistentes.CurrentRow.Index > -1 Then
            txtNombreUs.Text = dgvUsuariosExistentes.CurrentRow.Cells.Item(1).Value
            txtContraseñaUs.Text = dgvUsuariosExistentes.CurrentRow.Cells.Item(2).Value
            txtCargoUs.Text = dgvUsuariosExistentes.CurrentRow.Cells.Item(3).Value

            pbxModificarUs.Select()
        End If
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------------------

    Private Sub rbtAct_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAct.CheckedChanged, rbtDesac.CheckedChanged
        If rbtDesac.Checked Then
            gbxIPServ.Enabled = True

            Dim PE As String() = NetworkGateway().Split("."c)

            btnRescan.Enabled = True

            txtPE1.Text = PE(0)
            txtPE2.Text = PE(1)
            txtPE3.Text = PE(2)
            txtPE4.Text = PE(3)

            txtIPL1.Text = ""
            txtIPL2.Text = ""
            txtIPL3.Text = ""
            txtIPL4.Text = ""
            txtDNS1.Text = ""
            txtDNS2.Text = ""
            txtDNS3.Text = ""
            txtDNS4.Text = ""

            If PE(0) = "192" Then
                txtMS1.Text = "255"
                txtMS2.Text = "255"
                txtMS3.Text = "255"
                txtMS4.Text = "0"
            ElseIf PE(0) = "172" Or PE(0) = "169" Then
                txtMS1.Text = "255"
                txtMS2.Text = "255"
                txtMS3.Text = "0"
                txtMS4.Text = "0"
            ElseIf PE(0) = "10" Then
                txtMS1.Text = "255"
                txtMS2.Text = "0"
                txtMS3.Text = "0"
                txtMS4.Text = "0"
            End If
        Else
            gbxIPServ.Enabled = False
            txtIPL1.Text = "-"
            txtIPL2.Text = "-"
            txtIPL3.Text = "-"
            txtIPL4.Text = "-"
            txtPE1.Text = "-"
            txtPE2.Text = "-"
            txtPE3.Text = "-"
            txtPE4.Text = "-"
            txtMS1.Text = "-"
            txtMS2.Text = "-"
            txtMS3.Text = "-"
            txtMS4.Text = "-"
            txtDNS1.Text = "-"
            txtDNS2.Text = "-"
            txtDNS3.Text = "-"
            txtDNS4.Text = "-"
        End If
    End Sub

    Private Sub txtIPL1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPL1.KeyPress, txtIPL2.KeyPress, txtIPL3.KeyPress, txtIPL4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtPE1.SelectionLength = Len(txtPE1.Text)
            txtPE1.Select()
        End If
    End Sub

    Private Sub txtPE1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPE1.KeyPress, txtPE2.KeyPress, txtPE3.KeyPress, txtPE4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtMS1.SelectionLength = Len(txtMS1.Text)
            txtMS1.Select()
        End If
    End Sub

    Private Sub txtMS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMS1.KeyPress, txtMS2.KeyPress, txtMS3.KeyPress, txtMS4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtDNS1.SelectionLength = Len(txtDNS1.Text)
            txtDNS1.Select()
        End If
    End Sub

    Private Sub txtDNS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDNS1.KeyPress, txtDNS2.KeyPress, txtDNS3.KeyPress, txtDNS4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            pbxGuardarLector.Select()
        End If
    End Sub

    Private Sub txtIPS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPS1.KeyPress, txtIPS2.KeyPress, txtIPS3.KeyPress, txtIPS4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            pbxGuardarLector.Select()
        End If
    End Sub

    Private Sub txtMAC_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) And Asc(e.KeyChar) <> Keys.A And Asc(e.KeyChar) <> Keys.B And Asc(e.KeyChar) <> Keys.C And Asc(e.KeyChar) <> Keys.D And Asc(e.KeyChar) <> Keys.F And
                Asc(e.KeyChar) <> Keys.A + 32 And Asc(e.KeyChar) <> Keys.B + 32 And Asc(e.KeyChar) <> Keys.C + 32 And Asc(e.KeyChar) <> Keys.D + 32 And Asc(e.KeyChar) <> Keys.F + 32 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTarde_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTarde.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtAusente.SelectionLength = Len(txtAusente.Text)
            txtAusente.Select()
        End If
    End Sub

    Private Sub pbxTolerancia_Click(sender As Object, e As EventArgs) Handles pbxTolerancia.Click
        gbxTolEntr.Enabled = True

        pbxConfigLector.Enabled = False
        pbxIpServer.Enabled = False
        pbxTolerancia.Enabled = False
        pbxCancelarLector.Enabled = True
        pbxGuardarLector.Enabled = True
        gbxLectoresConectados.Enabled = False

        pbxTolerancia.Image = SIA.My.Resources.btnToleranciaSi

        txtOrigen.Text = "Tolerancia"

        LimpiarConfigLec()

        dgvLectores.ClearSelection()
        dgvLectores.CurrentCell = Nothing
        txtTarde.Select()
    End Sub

    Private Sub pbxIpServer_Click(sender As Object, e As EventArgs) Handles pbxIpServer.Click
        If NetworkGateway() IsNot Nothing Then
            gbxServidor.Enabled = True

            pbxConfigLector.Enabled = False
            pbxIpServer.Enabled = False
            pbxTolerancia.Enabled = False
            pbxCancelarLector.Enabled = True
            pbxGuardarLector.Enabled = True
            gbxLectoresConectados.Enabled = False

            pbxIpServer.Image = SIA.My.Resources.btnIPServidorSi

            txtOrigen.Text = "ipServer"

            LimpiarConfigLec()

            dgvLectores.ClearSelection()
            dgvLectores.CurrentCell = Nothing
            txtIPS1.Select()
        Else
            MsgBox("Error: No estas conectado a ninguna Red, no puedes modificar la IP del Servidor... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxConfigLector_Click(sender As Object, e As EventArgs) Handles pbxConfigLector.Click
        If dgvLectores.CurrentRow IsNot Nothing Then
            gbxDatosLect.Enabled = True

            pbxConfigLector.Enabled = False
            pbxIpServer.Enabled = False
            pbxTolerancia.Enabled = False
            pbxCancelarLector.Enabled = True
            pbxGuardarLector.Enabled = True

            gbxLectoresConectados.Enabled = False

            pbxConfigLector.Image = SIA.My.Resources.btnConfigurarLectorSi

            txtOrigen.Text = "Lector"

            txtNombreTerminal.Select()
        Else
            MsgBox("Error: Selecciona un Lector de la lista para poder configurarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub CancelarLector()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        pbxConfigLector.Enabled = True
        pbxIpServer.Enabled = True
        pbxTolerancia.Enabled = True
        pbxCancelarLector.Enabled = False
        pbxGuardarLector.Enabled = False

        gbxDatosLect.Enabled = False
        gbxServidor.Enabled = False
        gbxTolEntr.Enabled = False
        gbxLectoresConectados.Enabled = True

        pbxIpServer.Image = SIA.My.Resources.btnIPServidorNo
        pbxConfigLector.Image = SIA.My.Resources.btnConfigurarLectorNo
        pbxTolerancia.Image = SIA.My.Resources.btnToleranciaNo

        _Dt = _Ver.verIPServidor

        If _Dt.Rows.Count > 0 Then
            Dim X As Integer = 1
            Dim Y As Integer = 0
            Dim ip1 As String = ""
            Dim ip2 As String = ""
            Dim ip3 As String = ""
            Dim ip4 As String = ""

            Dim cdnIP As String = _Dt.Rows(0).Item("IP")
            For X = 1 To Len(cdnIP)
                If Mid(cdnIP, X, 1) = "." Then
                    Y = Y + 1
                Else
                    If Y = 0 Then
                        ip1 = ip1 & Mid(cdnIP, X, 1)
                    ElseIf Y = 1 Then
                        ip2 = ip2 & Mid(cdnIP, X, 1)
                    ElseIf Y = 2 Then
                        ip3 = ip3 & Mid(cdnIP, X, 1)
                    ElseIf Y = 3 Then
                        ip4 = ip4 & Mid(cdnIP, X, 1)
                    End If
                End If
            Next
            txtIPS1.Text = ip1
            txtIPS2.Text = ip2
            txtIPS3.Text = ip3
            txtIPS4.Text = ip4
        End If


        LimpiarConfigLec()

        dgvLectores.ClearSelection()
        dgvLectores.CurrentCell = Nothing
    End Sub

    Private Sub LimpiarConfigLec()
        txtNombreTerminal.Text = ""
        rbtAct.Checked = False
        rbtDesac.Checked = False
        txtIPL1.Text = ""
        txtIPL2.Text = ""
        txtIPL3.Text = ""
        txtIPL4.Text = ""
        txtPE1.Text = ""
        txtPE2.Text = ""
        txtPE3.Text = ""
        txtPE4.Text = ""
        txtMS1.Text = ""
        txtMS2.Text = ""
        txtMS3.Text = ""
        txtMS4.Text = ""
        txtDNS1.Text = ""
        txtDNS2.Text = ""
        txtDNS3.Text = ""
        txtDNS4.Text = ""
    End Sub

    Private Sub pbxCancelarLector_Click(sender As Object, e As EventArgs) Handles pbxCancelarLector.Click
        CancelarLector()
    End Sub

    Private Sub rbt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rbtAct.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            If rbtDesac.Checked Then
                txtIPL1.SelectionLength = Len(txtIPL1.Text)
                txtIPL1.Select()
            Else
                pbxGuardarLector.Select()
            End If
        End If
    End Sub

    Private Shared Function NetworkGateway() As String
        Dim ip As String = Nothing

        For Each f As NetworkInterface In NetworkInterface.GetAllNetworkInterfaces()

            If f.OperationalStatus = OperationalStatus.Up Then

                For Each d As GatewayIPAddressInformation In f.GetIPProperties().GatewayAddresses
                    ip = d.Address.ToString()
                Next
            End If
        Next

        Return ip
    End Function

    Private Sub Ping(ByVal host As String, ByVal timeout As Integer)
        Dim Proceso As New Thread(Sub()
                                      Try
                                          Dim ping As System.Net.NetworkInformation.Ping = New System.Net.NetworkInformation.Ping()
                                          AddHandler ping.PingCompleted, New PingCompletedEventHandler(AddressOf PingCompleted)
                                          ping.SendAsync(host, timeout, host)
                                      Catch
                                      End Try
                                  End Sub)
        Proceso.Start()
    End Sub

    Private Function GetHostName(ByVal ipAddress As String) As String
        Try
            Dim entry As IPHostEntry = Dns.GetHostEntry(ipAddress)

            If entry IsNot Nothing Then
                Return entry.HostName
            End If

        Catch __unusedSocketException1__ As SocketException
        End Try

        Return Nothing
    End Function

    Private Function GetMacAddress(ByVal ipAddress As String) As String
        Dim macAddress As String = String.Empty
        Dim Process As System.Diagnostics.Process = New System.Diagnostics.Process()
        Process.StartInfo.FileName = "arp"
        Process.StartInfo.Arguments = "-a " & ipAddress
        Process.StartInfo.UseShellExecute = False
        Process.StartInfo.RedirectStandardOutput = True
        Process.StartInfo.CreateNoWindow = True
        Process.Start()
        Dim strOutput As String = Process.StandardOutput.ReadToEnd()
        Dim substrings As String() = strOutput.Split("-"c)

        If substrings.Length >= 8 Then
            macAddress = substrings(3).Substring(Math.Max(0, substrings(3).Length - 2)) & "-" & substrings(4) & "-" & substrings(5) & "-" & substrings(6) & "-" & substrings(7) & "-" & substrings(8).Substring(0, 2)
            Return macAddress
        Else
            Return "Desconocido"
        End If
    End Function

    Private Sub PingCompleted(ByVal sender As Object, ByVal e As PingCompletedEventArgs)
        Dim ip As String = CStr(e.UserState)

        If e.Reply IsNot Nothing AndAlso e.Reply.Status = IPStatus.Success Then
            Dim hostname As String = GetHostName(ip)
            Dim macaddres As String = GetMacAddress(ip)
            Dim arr As String() = New String(2) {}
            arr(0) = ip
            arr(1) = hostname
            arr(2) = macaddres

            If arr(1) = "" Then
                arr(1) = "Default"
            End If

            If Me.InvokeRequired Then
                Me.Invoke(New Action(Sub()
                                         Dim _Dt As New DataTable
                                         Dim _Ver As New Mostrar

                                         _Dt = _Ver.verLector_MAC(arr(2))

                                         If macaddres.Contains("90-a2-b4") And _Dt.Rows.Count < 1 Then
                                             Dim rows As Integer = dgvLectores.Rows.Count - 1

                                             If dgvLectores.Rows.Count > 0 Then
                                                 For j As Integer = rows To 0 Step -1
                                                     If dgvLectores.Rows(j).Cells.Item("MAC").Value = arr(2) Then
                                                         dgvLectores.Rows.Remove(dgvLectores.Rows(j))
                                                     End If
                                                 Next
                                             End If

                                             dgvLectores.Rows.Add(arr(1), arr(2), arr(0), NetworkGateway(), "Automatico", "-", "255.255.255.0", "8.8.8.8")
                                             dgvLectores.ColumnHeadersVisible = True

                                             dgvLectores.ClearSelection()
                                             dgvLectores.CurrentCell = Nothing
                                         ElseIf _Dt.Rows.Count > 0 Then
                                             Dim rows As Integer = dgvLectores.Rows.Count - 1

                                             If dgvLectores.Rows.Count > 0 Then
                                                 For j As Integer = rows To 0 Step -1
                                                     If dgvLectores.Rows(j).Cells.Item("MAC").Value = arr(2) Then
                                                         dgvLectores.Rows.Remove(dgvLectores.Rows(j))
                                                     End If
                                                 Next
                                             End If

                                             dgvLectores.Rows.Add(_Dt.Rows(0).Item("Nombre"), _Dt.Rows(0).Item("MAC"), arr(0), _Dt.Rows(0).Item("PuertaEnlace"), _
                                                                  _Dt.Rows(0).Item("DHCP"), (txtIPS1.Text & "." & txtIPS2.Text & "." & txtIPS3.Text & "." & txtIPS4.Text), _Dt.Rows(0).Item("MascSubred"), _Dt.Rows(0).Item("DNS"))

                                             dgvLectores.ColumnHeadersVisible = True

                                             dgvLectores.ClearSelection()
                                             dgvLectores.CurrentCell = Nothing
                                         End If
                                     End Sub))

            End If
        End If
    End Sub

    Private Sub CargarLectores()
        dgvLectores.ColumnCount = 8
        dgvLectores.Columns(0).Name = "NOMBRE"
        dgvLectores.Columns(1).Name = "MAC"
        dgvLectores.Columns(2).Name = "IP"
        dgvLectores.Columns(3).Name = "P. ENLACE"
        dgvLectores.Columns(4).Name = "DHCP"
        dgvLectores.Columns(5).Name = "IP SERVER"
        dgvLectores.Columns(6).Name = "MASC. RED"
        dgvLectores.Columns(7).Name = "DNS"

        dgvLectores.Columns("MASC. RED").Visible = False
        dgvLectores.Columns("DNS").Visible = False

        Dim gate_ip As String = NetworkGateway()

        If gate_ip IsNot Nothing Then
            Dim array As String() = gate_ip.Split("."c)

            If array(0) = "192" Then
                tmrTiempoScan.Interval = (txtIPH4.Text - txtIPD4.Text + 1) * 50
                tmrTiempoScan.Enabled = True

                For i As Integer = txtIPD4.Text To txtIPH4.Text
                    Dim ping_var As String = array(0) & "." & array(1) & "." & array(2) & "." & i
                    Ping(ping_var, 100)
                Next
            ElseIf array(0) = "172" Or array(0) = "169" Then
                Dim Fin As Integer = 0
                Dim Inicio As Integer = 0

                tmrTiempoScan.Interval = ((txtIPH3.Text - txtIPD3.Text + 1) * (txtIPH4.Text - txtIPD4.Text + 1)) * 50
                tmrTiempoScan.Enabled = True

                Inicio = txtIPD4.Text

                For i As Integer = txtIPD3.Text To txtIPH3.Text
                    For j As Integer = Inicio To Fin
                        Dim ping_var As String = array(0) & "." & array(1) & "." & i & "." & j
                        Ping(ping_var, 100)
                    Next

                    If i = txtIPH3.Text Then
                        Fin = txtIPH4.Text
                    Else
                        Fin = 255
                    End If

                    Inicio = 0
                Next
            ElseIf array(0) = "10" Then
                Dim Fin1 As Integer = 0
                Dim Inicio1 As Integer = 0
                Dim Fin2 As Integer = 0
                Dim Inicio2 As Integer = 0

                tmrTiempoScan.Interval = ((txtIPH2.Text - txtIPD2.Text + 1) * (txtIPH3.Text - txtIPD3.Text + 1) * (txtIPH4.Text - txtIPD4.Text + 1)) * 50
                tmrTiempoScan.Enabled = True

                For i As Integer = txtIPD2.Text To txtIPH2.Text
                    If i = txtIPD2.Text Then
                        Inicio1 = txtIPD3.Text
                    Else
                        Inicio1 = 0
                    End If

                    If i = txtIPH2.Text Then
                        Fin1 = txtIPH3.Text
                    Else
                        Fin1 = 255
                    End If

                    For j As Integer = Inicio1 To Fin1
                        If j = txtIPD3.Text Then
                            Inicio2 = txtIPD4.Text
                        Else
                            Inicio2 = 0
                        End If

                        If j = txtIPH3.Text Then
                            Fin2 = txtIPH4.Text
                        Else
                            Fin2 = 255
                        End If

                        For h As Integer = Inicio2 To Fin2
                            Dim ping_var As String = array(0) & "." & i & "." & j & "." & h
                            Ping(ping_var, 100)
                        Next
                    Next
                Next
            End If
        Else
            MsgBox("Error: No estas conectado a ninguna Red... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxGuardarLector_Click(sender As Object, e As EventArgs) Handles pbxGuardarLector.Click
        Dim G As New GrabaDatos
        Dim _CA As New Arduino
        Dim resP As DialogResult
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If txtOrigen.Text = "Tolerancia" Then
            If txtTarde.Text = "" Then
                MsgBox("Error: No has ingresado la tolerancia para la llegada tarde... !", vbInformation, "Servico de Alertas")
                txtTarde.Select()
            Else
                If txtAusente.Text = "" Then
                    MsgBox("Error: No has ingresado la tolerancia para el ausente... !", vbInformation, "Servico de Alertas")
                    txtAusente.Select()
                Else
                    resP = MessageBox.Show("Grabar Tolerancia ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = Windows.Forms.DialogResult.OK Then
                        G.Grabar("Tolerancia", "NoImagen", "sistema_asistencia.modTolerancia", 1, txtTarde.Text, txtAusente.Text, frmIngresoSIA.txtIdUs.Text)

                        CancelarLector()
                        MsgBox("Tolerancia grabada con exito... !", vbInformation, "Servico de Alertas")
                    End If
                End If
            End If
        ElseIf txtOrigen.Text = "ipServer" Then
            If txtIPS1.Text = "" Or txtIPS2.Text = "" Or txtIPS3.Text = "" Or txtIPS4.Text = "" Then
                MsgBox("Error: No has ingresado una IP valida... !", vbInformation, "Servico de Alertas")
                txtIPS1.Select()
            Else
                If txtIPS1.Text > 255 Or txtIPS2.Text > 255 Or txtIPS3.Text > 255 Or txtIPS4.Text > 255 Then
                    MsgBox("Error: No has ingresado una IP valida... !", vbInformation, "Servico de Alertas")
                    txtIPS1.Select()
                Else
                    MsgBox("La modificacion de la IP del servidor solo impacatara de manera inmediata en los Lectores que se encuentren en la lista inferior. En el caso de faltar algun Terminal o directamente no haber ninguno, para efectuar el cambio de IP se debera reconfigurar el o los Lectores luego de guardar el cambio de IP.", vbInformation, "Servico de Alertas")

                    resP = MessageBox.Show("Grabar IP del servidor ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = Windows.Forms.DialogResult.OK Then
                        Dim rows As Integer = dgvLectores.Rows.Count - 1

                        If dgvLectores.Rows.Count > 0 Then
                            tmrTiempoScan.Interval = 5000

                            lblBarra.Visible = True
                            gbxLectoresConectados.Enabled = False

                            For j As Integer = rows To 0 Step -1
                                If _CA.Arduino_Connect(dgvLectores.Rows(j).Cells.Item("IP").Value, 80) Then
                                    _CA.Arduino_Write("S")
                                    _CA.Arduino_Write(txtIPS1.Text & "." & txtIPS2.Text & "." & txtIPS3.Text & "." & txtIPS4.Text)
                                    _CA.Arduino_Disconnect()

                                    Ping(dgvLectores.Rows(j).Cells.Item("IP").Value, 100)
                                    Ping(dgvLectores.Rows(j).Cells.Item("IP").Value, 100)

                                    dgvLectores.Rows.Remove(dgvLectores.Rows(j))

                                    If dgvLectores.Rows.Count < 1 Then
                                        dgvLectores.ColumnHeadersVisible = False
                                    Else
                                        dgvLectores.ColumnHeadersVisible = True
                                    End If

                                    tmrTiempoScan.Enabled = True
                                Else
                                    MsgBox("No se pudo establecer conexion con el Terminal " + dgvLectores.Rows(j).Cells.Item("IP").Value + " Por lo tanto no se le asignara el cambio de IP... !", vbInformation, "Servico de Alertas")
                                End If
                            Next
                        End If

                        G.Grabar("Servidor", "NoImagen", "sistema_asistencia.modServidor", 1, (txtIPS1.Text & "." & txtIPS2.Text & "." & txtIPS3.Text & "." & txtIPS4.Text), frmIngresoSIA.txtIdUs.Text)

                        CancelarLector()
                        MsgBox("IP grabada con exito... !", vbInformation, "Servico de Alertas")
                    End If
                    End If
            End If
        ElseIf txtOrigen.Text = "Lector" Then
            Dim Guardar As Boolean = False

            If txtNombreTerminal.Text = "" Or txtNombreTerminal.Text = "DEFAULT" Then
                MsgBox("Error: El nombre del Terminal no puede quedar vacio ni como ""Default""... !", vbInformation, "Servico de Alertas")
                txtNombreTerminal.Select()
            Else
                If rbtDesac.Checked Then
                    If txtIPL1.Text = "" Or txtIPL2.Text = "" Or txtIPL3.Text = "" Or txtIPL4.Text = "" Then
                        MsgBox("Error: El Terminal no puede quedar sin una direccion IP... !", vbInformation, "Servico de Alertas")
                        txtIPL1.Select()
                    Else
                        If txtPE1.Text = "" Or txtPE2.Text = "" Or txtPE3.Text = "" Or txtPE4.Text = "" Then
                            MsgBox("Error: El Terminal no puede quedar sin una Puerta de Enlace... !", vbInformation, "Servico de Alertas")
                            txtPE1.Select()
                        Else
                            If txtMS1.Text = "" Or txtMS2.Text = "" Or txtMS3.Text = "" Or txtMS4.Text = "" Then
                                MsgBox("Error: El Terminal no puede quedar sin una Mascara de Red... !", vbInformation, "Servico de Alertas")
                                txtMS1.Select()
                            Else
                                If txtDNS1.Text = "" Or txtDNS2.Text = "" Or txtDNS3.Text = "" Or txtDNS4.Text = "" Then
                                    MsgBox("Error: El Terminal no puede quedar sin un DNS... !", vbInformation, "Servico de Alertas")
                                    txtDNS1.Select()
                                Else
                                    Guardar = True
                                End If
                            End If
                        End If
                    End If
                Else
                    Guardar = True
                End If

                If Guardar Then
                    resP = MessageBox.Show("Guardar configuracion del Lector ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                    If resP = Windows.Forms.DialogResult.OK Then
                        If _CA.Arduino_Connect(dgvLectores.CurrentRow.Cells.Item("IP").Value, 80) Then
                            Dim DHCP, L, PE, MS, DNS As String
                            Dim IPLector As String = Nothing

                            If _CA.Arduino_Write("C") Then
                                _CA.Arduino_Write(txtNombreTerminal.Text)

                                If rbtAct.Checked = False Then
                                    DHCP = "Manual"
                                    _CA.Arduino_Write("Manual")

                                    _CA.Arduino_Write(txtIPL1.Text & "." & txtIPL2.Text & "." & txtIPL3.Text & "." & txtIPL4.Text)
                                    L = txtIPL1.Text & "." & txtIPL2.Text & "." & txtIPL3.Text & "." & txtIPL4.Text
                                    _CA.Arduino_Write(txtPE1.Text & "." & txtPE2.Text & "." & txtPE3.Text & "." & txtPE4.Text)
                                    PE = txtPE1.Text & "." & txtPE2.Text & "." & txtPE3.Text & "." & txtPE4.Text
                                    _CA.Arduino_Write(txtMS1.Text & "." & txtMS2.Text & "." & txtMS3.Text & "." & txtMS4.Text)
                                    MS = txtMS1.Text & "." & txtMS2.Text & "." & txtMS3.Text & "." & txtMS4.Text
                                    _CA.Arduino_Write(txtDNS1.Text & "." & txtDNS2.Text & "." & txtDNS3.Text & "." & txtDNS4.Text)
                                    DNS = txtDNS1.Text & "." & txtDNS2.Text & "." & txtDNS3.Text & "." & txtDNS4.Text
                                    _CA.Arduino_Write(txtIPS1.Text & "." & txtIPS2.Text & "." & txtIPS3.Text & "." & txtIPS4.Text)
                                Else
                                    DHCP = "Automatico"
                                    _CA.Arduino_Write("Automatico")
                                    L = "-"
                                    PE = NetworkGateway()
                                    MS = "-"
                                    DNS = "-"
                                End If

                                While _CA.Arduino_Read() = Nothing
                                End While

                                If rbtAct.Checked = False Then
                                    IPLector = txtIPL1.Text & "." & txtIPL2.Text & "." & txtIPL3.Text & "." & txtIPL4.Text
                                Else
                                    IPLector = dgvLectores.CurrentRow.Cells.Item(2).Value
                                End If

                                _Dt = _Ver.verLector_MAC(dgvLectores.CurrentRow.Cells.Item(1).Value)

                                If _Dt.Rows.Count < 1 Then
                                    G.Grabar("Lectores", "NoImagen", "sistema_asistencia.insLector", txtNombreTerminal.Text, dgvLectores.CurrentRow.Cells.Item(1).Value, DHCP,
                                            L, MS, PE, DNS, "-", frmIngresoSIA.txtIdUs.Text, 1)
                                Else
                                    G.Grabar("Lectores", "NoImagen", "sistema_asistencia.modLector", _Dt.Rows(0).Item("idLector"), txtNombreTerminal.Text, dgvLectores.CurrentRow.Cells.Item(1).Value, DHCP,
                                            L, MS, PE, DNS, "-", frmIngresoSIA.txtIdUs.Text, 1)
                                End If

                                dgvLectores.Rows.Remove(dgvLectores.CurrentRow)

                                CancelarLector()

                                lblBarra.Visible = True
                                gbxLectoresConectados.Enabled = False

                                Ping(IPLector, 5000)
                                Ping(IPLector, 5000)

                                tmrTiempoScan.Interval = 9000
                                tmrTiempoScan.Enabled = True

                                If dgvLectores.Rows.Count < 1 Then
                                    dgvLectores.ColumnHeadersVisible = False
                                Else
                                    dgvLectores.ColumnHeadersVisible = True
                                End If

                                MsgBox("Configuracíon guardada... !", vbInformation, "Servico de Alertas")
                            Else
                                MsgBox("Error: Fallo la comunicacion con el Terminal, verifique que el Terminal este conectado a la red... !", vbInformation, "Servico de Alertas")
                            End If

                            _CA.Arduino_Disconnect()
                        Else
                            MsgBox("Error: Fallo la comunicacion con el Terminal, verifique que el Terminal este conectado a la red... !", vbInformation, "Servico de Alertas")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub dgvLectores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLectores.CellClick
        If dgvLectores.CurrentRow.Index > -1 Then
            txtNombreTerminal.Text = dgvLectores.CurrentRow.Cells.Item(0).Value

            If dgvLectores.CurrentRow.Cells.Item(4).Value <> "Automatico" Then
                rbtDesac.Checked = True

                Dim IPL As String() = dgvLectores.CurrentRow.Cells.Item(2).Value.Split("."c)
                Dim PE As String() = dgvLectores.CurrentRow.Cells.Item(3).Value.Split("."c)
                Dim MS As String() = dgvLectores.CurrentRow.Cells.Item(6).Value.Split("."c)
                Dim DNS As String() = dgvLectores.CurrentRow.Cells.Item(7).Value.Split("."c)

                txtIPL1.Text = IPL(0)
                txtIPL2.Text = IPL(1)
                txtIPL3.Text = IPL(2)
                txtIPL4.Text = IPL(3)

                txtPE1.Text = PE(0)
                txtPE2.Text = PE(1)
                txtPE3.Text = PE(2)
                txtPE4.Text = PE(3)

                txtMS1.Text = MS(0)
                txtMS2.Text = MS(1)
                txtMS3.Text = MS(2)
                txtMS4.Text = MS(3)

                txtDNS1.Text = DNS(0)
                txtDNS2.Text = DNS(1)
                txtDNS3.Text = DNS(2)
                txtDNS4.Text = DNS(3)
            Else
                rbtAct.Checked = True
            End If
        End If
    End Sub

    Private Sub txtAusente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAusente.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            pbxGuardarLector.Select()
        End If
    End Sub

    Private Sub btnRescan_Click(sender As Object, e As EventArgs) Handles btnRescan.Click
        If txtIPD1.Text = "" Or txtIPD2.Text = "" Or txtIPD3.Text = "" Or txtIPD4.Text = "" Or txtIPH1.Text = "" Or txtIPH2.Text = "" Or txtIPH3.Text = "" Or txtIPH4.Text = "" Then
            MsgBox("Error: No pueden quedar IP vacíos.... !", vbInformation, "Servico de Alertas")
        Else
            If txtIPD1.Text = "192" Then
                If CInt(txtIPD4.Text) < CInt(txtIPH4.Text) Then
                    lblBarra.Visible = True
                    gbxLectoresConectados.Enabled = False
                    LimpiarConfigLec()

                    Dim rows As Integer = dgvLectores.Rows.Count - 1

                    If dgvLectores.Rows.Count > 0 Then
                        For j As Integer = rows To 0 Step -1
                            dgvLectores.Rows.Remove(dgvLectores.Rows(j))
                        Next
                    End If

                    dgvLectores.ColumnHeadersVisible = False
                    tmrScan.Enabled = True
                Else
                    MsgBox("Error: IP desde NO puede ser mayor o igual a IP hasta !", vbInformation, "Servico de Alertas")
                End If
            ElseIf txtIPD1.Text = "172" Or txtIPD1.Text = "169" Then
                If CInt(txtIPD3.Text) <= CInt(txtIPH3.Text) And CInt(txtIPD4.Text) < CInt(txtIPH4.Text) Then
                    lblBarra.Visible = True
                    gbxLectoresConectados.Enabled = False
                    LimpiarConfigLec()

                    Dim rows As Integer = dgvLectores.Rows.Count - 1

                    If dgvLectores.Rows.Count > 0 Then
                        For j As Integer = rows To 0 Step -1
                            dgvLectores.Rows.Remove(dgvLectores.Rows(j))
                        Next
                    End If

                    dgvLectores.ColumnHeadersVisible = False
                    tmrScan.Enabled = True
                Else
                    MsgBox("Error: IP desde NO puede ser mayor o igual a IP hasta !", vbInformation, "Servico de Alertas")
                End If
            ElseIf txtIPD1.Text = "10" Then
                If CInt(txtIPD2.Text) <= CInt(txtIPH2.Text) And CInt(txtIPD3.Text) <= CInt(txtIPH3.Text) And CInt(txtIPD4.Text) < CInt(txtIPH4.Text) Then
                    lblBarra.Visible = True
                    gbxLectoresConectados.Enabled = False
                    LimpiarConfigLec()

                    Dim rows As Integer = dgvLectores.Rows.Count - 1

                    If dgvLectores.Rows.Count > 0 Then
                        For j As Integer = rows To 0 Step -1
                            dgvLectores.Rows.Remove(dgvLectores.Rows(j))
                        Next
                    End If

                    dgvLectores.ColumnHeadersVisible = False
                    tmrScan.Enabled = True
                Else
                    MsgBox("Error: IP desde NO puede ser mayor o igual a IP hasta !", vbInformation, "Servico de Alertas")
                End If
            End If
        End If
    End Sub

    Private Sub tmrScan_Tick(sender As Object, e As EventArgs) Handles tmrScan.Tick
        CargarLectores()
        gbxLectoresConectados.Enabled = False
        tmrScan.Enabled = False
        LimpiarConfigLec()
    End Sub

    Private Sub txtIPD1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPD1.KeyPress, txtIPD2.KeyPress, txtIPD3.KeyPress, txtIPD4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True

            txtIPH1.SelectionLength = Len(txtIPH1.Text)
            txtIPH1.Select()
        End If
    End Sub

    Private Sub txtIPH1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIPH1.KeyPress, txtIPH2.KeyPress, txtIPH3.KeyPress, txtIPH4.KeyPress
        If Asc(e.KeyChar) <> Keys.Back And Asc(e.KeyChar) <> Keys.Enter Then
            If Not IsNumeric(e.KeyChar) Then
                e.Handled = True
            End If
        ElseIf Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            btnRescan.Select()
        End If
    End Sub

    Private Sub txtIPD_Validated(sender As Object, e As EventArgs) Handles txtIPD1.KeyPress, txtIPD2.KeyPress, txtIPD3.KeyPress, txtIPD4.KeyPress
        If txtIPD1.Text <> "" Then
            If CInt(txtIPD1.Text) < 0 Or CInt(txtIPD1.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPD1.Text = ""
                txtIPD1.Select()
            End If
        End If
        If txtIPD2.Text <> "" Then
            If CInt(txtIPD2.Text) < 0 Or CInt(txtIPD2.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPD2.Text = ""
                txtIPD2.Select()
            End If
        End If
        If txtIPD3.Text <> "" Then
            If CInt(txtIPD3.Text) < 0 Or CInt(txtIPD3.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPD3.Text = ""
                txtIPD3.Select()
            End If
        End If
        If txtIPD4.Text <> "" Then
            If CInt(txtIPD4.Text) < 0 Or CInt(txtIPD4.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPD4.Text = ""
                txtIPD4.Select()
            End If
        End If
    End Sub

    Private Sub txtIPH_Validated(sender As Object, e As EventArgs) Handles txtIPH1.KeyPress, txtIPH2.KeyPress, txtIPH3.KeyPress, txtIPH4.KeyPress
        If txtIPH1.Text <> "" Then
            If CInt(txtIPH1.Text) < 0 Or CInt(txtIPH1.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPH1.Text = ""
                txtIPH1.Select()
            End If
        End If
        If txtIPH2.Text <> "" Then
            If CInt(txtIPH2.Text) < 0 Or CInt(txtIPH2.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPH2.Text = ""
                txtIPH2.Select()
            End If
        End If
        If txtIPH3.Text <> "" Then
            If CInt(txtIPH3.Text) < 0 Or CInt(txtIPH3.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPH3.Text = ""
                txtIPH3.Select()
            End If
        End If
        If txtIPH4.Text <> "" Then
            If CInt(txtIPH4.Text) < 0 Or CInt(txtIPH4.Text) > 255 Then
                MsgBox("Error: IP debe ser un número entre 0 y 255 !", vbInformation, "Servico de Alertas")
                txtIPH4.Text = ""
                txtIPH4.Select()
            End If
        End If
    End Sub

    Private Sub tmrTiempoScan_Tick(sender As Object, e As EventArgs) Handles tmrTiempoScan.Tick
        lblBarra.Visible = False
        gbxLectoresConectados.Enabled = True
        tmrTiempoScan.Enabled = False
    End Sub
End Class