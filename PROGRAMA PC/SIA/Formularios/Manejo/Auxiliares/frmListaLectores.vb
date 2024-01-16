Imports System.Threading
Imports System.Net.NetworkInformation
Imports System.Net
Imports System.Net.Sockets

Public Class frmListaLectores

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

    Private Sub pbxSeleccionar_GotFocus(sender As Object, e As EventArgs) Handles pbxSeleccionar.GotFocus
        pbxSeleccionar.Image = SIA.My.Resources.btnSeleccionarLectorSi
    End Sub

    Private Sub pbxSeleccionar_LostFocus(sender As Object, e As EventArgs) Handles pbxSeleccionar.LostFocus
        pbxSeleccionar.Image = SIA.My.Resources.btnSeleccionarLectorNo
    End Sub

    Private Sub pbxSeleccionar_MouseEnter(sender As Object, e As EventArgs) Handles pbxSeleccionar.MouseEnter
        pbxSeleccionar.Image = SIA.My.Resources.btnSeleccionarLectorSi
    End Sub

    Private Sub pbxSeleccionar_MouseLeave(sender As Object, e As EventArgs) Handles pbxSeleccionar.MouseLeave
        pbxSeleccionar.Image = SIA.My.Resources.btnSeleccionarLectorNo
    End Sub

    Dim _Dt As New DataTable

    Private Sub frmListaLectores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim rows As Integer = dgvLectoresDisp.Rows.Count - 1

        If dgvLectoresDisp.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvLectoresDisp.Rows.Remove(dgvLectoresDisp.Rows(j))
            Next
        End If

        dgvLectoresDisp.ColumnHeadersVisible = False
    End Sub

    Private Sub frmListaLectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _Ver As New Mostrar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Lectores"

        dgvLectoresDisp.Height = 322
        dgvLectoresDisp.Top = 52

        lblSelecciona.Visible = False
        gbxLectores.Enabled = False
        lblScan.Visible = True

        lblScan.Top = 189
        lblScan.Left = 20
        lblScan.BringToFront()

        _Dt = _Ver.verLectores

        Timer.Interval = _Dt.Rows.Count * 500

        Dim rows As Integer = _Dt.Rows.Count - 1

        If _Dt.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                Ping(_Dt.Rows(j).Item("IPLector"), 200)
            Next
        Else
            lblScan.Visible = False
            MsgBox("Error: No hay Lectores Configurados... !", vbInformation, "Servico de Alertas")
            Me.Close()
        End If

        Timer.Enabled = True
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Dim rows As Integer = dgvLectoresDisp.Rows.Count - 1

        If dgvLectoresDisp.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvLectoresDisp.Rows.Remove(dgvLectoresDisp.Rows(j))
            Next
        End If

        dgvLectoresDisp.ColumnHeadersVisible = False

        Me.Close()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Timer.Enabled = False

        If _Dt.Rows.Count > 0 Then
            dgvLectoresDisp.RowTemplate.Height = 25
            dgvLectoresDisp.DataSource = _Dt
            dgvLectoresDisp.Columns("Servidor_idServidor").Visible = False
            dgvLectoresDisp.Columns("Usuarios_idUsuarios").Visible = False
            dgvLectoresDisp.Columns("Estado").Visible = False
            dgvLectoresDisp.Columns("DNS").Visible = False
            dgvLectoresDisp.Columns("MascSubred").Visible = False
            dgvLectoresDisp.Columns("DHCP").Visible = False
            dgvLectoresDisp.Columns("PuertaEnlace").Visible = False
            dgvLectoresDisp.Columns("idLector").Visible = False

            dgvLectoresDisp.DefaultCellStyle.ForeColor = Color.Black

            dgvLectoresDisp.DefaultCellStyle.Font = New Font("OCR A", 11, FontStyle.Regular)
            dgvLectoresDisp.AlternatingRowsDefaultCellStyle.Font = New Font("OCR A", 11, FontStyle.Regular)

            dgvLectoresDisp.Columns("Nombre").HeaderText = "NOMBRE"
            dgvLectoresDisp.Columns("IPLector").HeaderText = "IP"

            dgvLectoresDisp.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgvLectoresDisp.Columns("MAC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgvLectoresDisp.Columns("IPLector").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            dgvLectoresDisp.Height = 306
            dgvLectoresDisp.Top = 68

            lblSelecciona.Visible = True
            gbxLectores.Enabled = True
            lblScan.Visible = False

            dgvLectoresDisp.ColumnHeadersVisible = True

            dgvLectoresDisp.CurrentCell = Nothing
            dgvLectoresDisp.ClearSelection()
        Else
            lblScan.Visible = False
            MsgBox("Error: No se encontraron Terminales disponibles... !", vbInformation, "Servico de Alertas")
            Me.Close()
        End If
    End Sub

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

    Private Sub PingCompleted(ByVal sender As Object, ByVal e As PingCompletedEventArgs)
        Dim ip As String = CStr(e.UserState)

        If e.Reply IsNot Nothing AndAlso e.Reply.Status = IPStatus.Success Then
            Dim macaddres As String = GetMacAddress(ip)

            If Me.InvokeRequired Then
                Me.Invoke(New Action(Sub()
                                         Dim rows As Integer = _Dt.Rows.Count - 1

                                         If _Dt.Rows.Count > 0 Then
                                             For j As Integer = rows To 0 Step -1
                                                 If _Dt.Rows(j).Item("MAC") <> macaddres And _Dt.Rows(j).Item("IPLector") = ip Then
                                                     _Dt.Rows.Remove(_Dt.Rows(j))
                                                 End If
                                             Next
                                         End If
                                     End Sub))

            End If
        Else
            If Me.InvokeRequired Then
                Me.Invoke(New Action(Sub()
                                         Dim rows As Integer = _Dt.Rows.Count - 1

                                         If _Dt.Rows.Count > 0 Then
                                             For j As Integer = rows To 0 Step -1
                                                 If _Dt.Rows(j).Item("IPLector") = ip Then
                                                     _Dt.Rows.Remove(_Dt.Rows(j))
                                                 End If
                                             Next
                                         End If
                                     End Sub))
            End If
        End If
    End Sub

    Private Sub pbxSeleccionar_Click(sender As Object, e As EventArgs) Handles pbxSeleccionar.Click
        If dgvLectoresDisp.CurrentRow IsNot Nothing Then
            Dim _CA As New Arduino

            If _CA.Arduino_Connect(dgvLectoresDisp.CurrentRow.Cells.Item("IPLector").Value, 80) = False Then
                MsgBox("Error: Conexión con lector FALLIDA !", vbInformation, "Servico de Alertas")
            Else
                frmManejoHuellas.txtIdLector.Text = dgvLectoresDisp.CurrentRow.Cells.Item("idLector").Value
                frmManejoHuellas.txtNombreL.Text = dgvLectoresDisp.CurrentRow.Cells.Item("Nombre").Value
                frmManejoHuellas.txtMac.Text = dgvLectoresDisp.CurrentRow.Cells.Item("MAC").Value
                frmManejoHuellas.txtIP.Text = dgvLectoresDisp.CurrentRow.Cells.Item("IPLector").Value

                _CA.Arduino_Write("E")
                _CA.Arduino_Disconnect()
            End If

            Me.Close()
        Else
            MsgBox("Error: No seleccionaste ningun lector de la lista... !", vbInformation, "Servico de Alertas")

            dgvLectoresDisp.CurrentCell = Nothing
            dgvLectoresDisp.ClearSelection()
        End If
    End Sub
End Class