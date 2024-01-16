Public Class frmManejoHuellas
    Dim Model As String = Nothing
    Dim Id As Integer = 0

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

    Private Sub pbxNuevo_GotFocus(sender As Object, e As EventArgs) Handles pbxCargar.GotFocus
        If (pbxCargar.Enabled = True) Then
            pbxCargar.Image = SIA.My.Resources.btnCargarHuellaSi
        End If
    End Sub

    Private Sub pbxCargar_LostFocus(sender As Object, e As EventArgs) Handles pbxCargar.LostFocus
        If (pbxCargar.Enabled = True) Then
            pbxCargar.Image = SIA.My.Resources.btnCargarHuellaNo
        End If
    End Sub

    Private Sub pbxCargar_MouseEnter(sender As Object, e As EventArgs) Handles pbxCargar.MouseEnter
        If (pbxCargar.Enabled = True) Then
            pbxCargar.Image = SIA.My.Resources.btnCargarHuellaSi
        End If
    End Sub

    Private Sub pbxCargar_MouseLeave(sender As Object, e As EventArgs) Handles pbxCargar.MouseLeave
        If (pbxCargar.Enabled = True) Then
            pbxCargar.Image = SIA.My.Resources.btnCargarHuellaNo
        End If
    End Sub

    Private Sub frmManejoHuellas_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim G As New GrabaDatos
        Dim _CA As New Arduino

        G.Grabar("Lectores", "NoImagen", "sistema_asistencia.modEstadoLectorReseteo")

        If _CA.Arduino_Connect(txtIP.Text, 80) Then
            _CA.Arduino_Write("X")
            _CA.Arduino_Disconnect()
        End If
    End Sub

    Private Sub frmManejoHuellas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlCargar As Control = DirectCast(pbxCargar, Control)
        Dim keyprCargar = New KeyPressEventHandler(AddressOf btnCargar)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        AddHandler ctlCargar.KeyPress, keyprCargar
        AddHandler ctlGuardar.KeyPress, keyprGuardar

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Asignar Huellas"

        dgvAlumnos.DefaultCellStyle.ForeColor = Color.Black
        dgvAlumnos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)

        CargarCursosCBX()
        rdbTodos.Checked = True

        tmrMostrarLectores.Enabled = True
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub btnCargar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxCargar_Click(1, Nothing)
        End If
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Dim G As New GrabaDatos
        Dim _CA As New Arduino

        G.Grabar("Lectores", "NoImagen", "sistema_asistencia.modEstadoLectorReseteo")

        If _CA.Arduino_Connect(txtIP.Text, 80) Then
            _CA.Arduino_Write("N")
            _CA.Arduino_Write("X")
            _CA.Arduino_Disconnect()
        End If

        Me.Close()
    End Sub

    Private Sub pbxCargar_Click(sender As Object, e As EventArgs) Handles pbxCargar.Click
        If dgvAlumnos.CurrentRow IsNot Nothing Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar
            Dim _CA As New Arduino

            If dgvAlumnos.CurrentRow.Cells.Item("Huella").Value = "NO" Then
                _Dt = _Ver.verAlumnos

                Dim dtView As DataView = Nothing
                dtView = New DataView(_Dt)

                dgvAux.DataSource = dtView

                dtView.Sort = "idHuella_Digital ASC"

                Dim rows As Integer = dgvAux.Rows.Count - 1
                Dim i As Integer = 0

                If dgvAux.Rows.Count > 0 Then
                    For j As Integer = 0 To rows
                        If j <= 1000 Then
                            If dgvAux.Rows(j).Cells.Item("idHuella_Digital").Value <> 0 Then
                                i = i + 1

                                If dgvAux.Rows(j).Cells.Item("idHuella_Digital").Value <> i Then
                                    Id = i
                                    Exit For
                                End If
                            End If
                        End If
                    Next
                End If

                If Id = 0 Then
                    If i <= 1000 Then
                        Id = i + 1
                    End If
                End If
            Else
                _Dt = _Ver.verHuella_idAlumno(dgvAlumnos.CurrentRow.Cells.Item("idAlumnos").Value)

                Id = _Dt.Rows(0).Item("idHuella_Digital")
            End If

            If Id <> 0 Then
                pbxSalir.Enabled = False
                pbxGuardar.Enabled = True
                pbxCancelar.Enabled = True
                pbxCargar.Enabled = False
                pbxEliminar.Enabled = False
                gbxCargar.Enabled = False
                gbxFiltros.Enabled = False

                lblEsperando.Visible = True

                pbxCargar.Image = SIA.My.Resources.btnCargarHuellaSi

                If _CA.Arduino_Connect(txtIP.Text, 80) Then
                    _CA.Arduino_Write(Id)

                    tmrLectura.Enabled = True

                    _CA.Arduino_Disconnect()
                Else
                    MsgBox("Error: No se puede comunicar con el terminal... !", vbInformation, "Servico de Alertas")
                End If
            Else
                MsgBox("Error: No hay espacio en la memoria de los terminales para grabar una huella nueva... !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Selecciona un Alumno de la lista para asignarle una Huella... !", vbInformation, "Servico de Alertas")
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

    Private Sub cbxCurso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCurso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxGrupo.SelectionLength = Len(cbxGrupo.Text)
            cbxGrupo.Select()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ListaAlumnos()
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar

        If cbxCurso.Text = "" And rdbTodos.Checked = True Then
            _Dt = _Ver.consAlumno_Todos(frmIngresoSIA.txtCicloID.Text)
        ElseIf cbxCurso.Text <> "" And rdbTodos.Checked = True Then
            _Dt = _Ver.consAlumno_Curso(txtIdCurso.Text, frmIngresoSIA.txtCicloID.Text)
        ElseIf cbxCurso.Text = "" And rdbSinHuella.Checked = True Then
            _Dt = _Ver.consAlumno_SinHuella(frmIngresoSIA.txtCicloID.Text)
        ElseIf cbxCurso.Text <> "" And rdbSinHuella.Checked = True Then
            _Dt = _Ver.consAlumno_Curso_SinHuella(txtIdCurso.Text, frmIngresoSIA.txtCicloID.Text)
        Else
            MsgBox("Error: Filtro no disponible !", vbInformation, "Servico de Alertas")
        End If

        dgvAlumnos.DataSource = _Dt
        dgvAlumnos.RowTemplate.Height = 25
        dgvAlumnos.ColumnHeadersVisible = True

        dgvAlumnos.Columns("idAlumnos").Visible = False
        dgvAlumnos.Columns("Sexo").Visible = False
        dgvAlumnos.Columns("idHuella_Digital").Visible = False
        dgvAlumnos.Columns("Modelo_Huella").Visible = False
        dgvAlumnos.Columns("Estado").Visible = False
        dgvAlumnos.Columns("idCurso").Visible = False
        dgvAlumnos.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False
        dgvAlumnos.Columns("Usuarios_idUsuarios").Visible = False

        dgvAlumnos.Columns("Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvAlumnos.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvAlumnos.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvAlumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvAlumnos.Columns("Huella").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvAlumnos.Columns("Nombre").Width = 280
        dgvAlumnos.Columns("Año").Width = 50
        dgvAlumnos.Columns("Division").Width = 50

        dgvAlumnos.Columns("Huella").DisplayIndex = 10

        dgvAlumnos.Columns("Division").HeaderText = "Div"
        dgvAlumnos.Columns("Huella").HeaderText = "Hue"

        For Each Columna As DataGridViewColumn In dgvAlumnos.Columns
            Columna.SortMode = DataGridViewColumnSortMode.Programmatic
        Next

        Dim dtView As DataView = Nothing
        dtView = New DataView(_Dt)

        dgvAlumnos.DataSource = dtView

        dtView.Sort = "Año, Division, Nombre"

        If dgvAlumnos.Rows.Count = 0 Then
            dgvAlumnos.ColumnHeadersVisible = False
        Else
            dgvAlumnos.ColumnHeadersVisible = True
        End If

        For Each _Dr As DataGridViewRow In dgvAlumnos.Rows
            If _Dr.Cells.Item("idHuella_Digital").Value = 0 Then
                _Dr.Cells.Item("Huella").Value = "NO"
                _Dr.Cells.Item("Huella").Style.BackColor = Color.DarkRed
            Else
                _Dr.Cells.Item("Huella").Value = "SI"
                _Dr.Cells.Item("Huella").Style.BackColor = Color.DarkGreen
            End If

            _Dr.Cells.Item("Huella").Style.ForeColor = Color.White
        Next

        dgvAlumnos.Columns("Huella").Width = 50
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        If Model = Nothing Or Id = 0 Then
            MsgBox("Error: No has ingresado ninguna huella para guardar... !", vbInformation, "Servico de Alertas")
        Else
            Dim G As New GrabaDatos
            Dim resP As DialogResult
            Dim _CA As New Arduino

            resP = MessageBox.Show("Guardar Huella Dactilar ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                If _CA.Arduino_Connect(txtIP.Text, 80) Then
                    G.Grabar("Alumnos", "NoImagen", "sistema_asistencia.modHuella_Modelo", dgvAlumnos.CurrentRow.Cells.Item("idAlumnos").Value, Id, Model)

                    MsgBox("Huella Dactilar grabada con exito... !", vbInformation, "Servico de Alertas")
                    ListaAlumnos()
                    _CA.Arduino_Write("O")
                    Cancelar()
                End If
            End If
        End If
    End Sub

    Private Sub rdb_CheckedChanged(sender As Object, e As EventArgs) Handles rdbTodos.CheckedChanged, rdbSinHuella.CheckedChanged
        ListaAlumnos()

        dgvAlumnos.CurrentCell = Nothing
        dgvAlumnos.ClearSelection()
    End Sub

    Private Sub tmrMostrarLectores_Tick(sender As Object, e As EventArgs) Handles tmrMostrarLectores.Tick
        Dim _Dt As New DataTable
        Dim _Ver As New Mostrar
        Dim G As New GrabaDatos

        dgvAlumnos.CurrentCell = Nothing
        dgvAlumnos.ClearSelection()

        _Dt = _Ver.verAlumnos

        tmrMostrarLectores.Enabled = False

        If _Dt.Rows.Count = 0 Then
            MsgBox("Error: No hay alumnos cargados en el Sistema a los que asignarle Huella... !", vbInformation, "Servico de Alertas")
            Me.Close()
        Else
            frmListaLectores.ShowDialog()

            If txtNombreL.Text <> "" Then
                G.Grabar("Lectores", "NoImagen", "sistema_asistencia.modEstadoLector", CInt(txtIdLector.Text), "EN USO")
            Else
                G.Grabar("Lectores", "NoImagen", "sistema_asistencia.modEstadoLectorReseteo")
                Me.Close()
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

        ListaAlumnos()

        dgvAlumnos.CurrentCell = Nothing
        dgvAlumnos.ClearSelection()
    End Sub

    Private Sub Cancelar()
        pbxSalir.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxCargar.Enabled = True
        pbxEliminar.Enabled = True
        gbxCargar.Enabled = True
        gbxFiltros.Enabled = True

        lblEsperando.Text = "ESPERANDO HUELLA"
        lblEsperando.Visible = False

        Model = Nothing
        Id = 0

        tmrLectura.Enabled = False

        pbxCargar.Image = SIA.My.Resources.btnCargarHuellaNo

        pbxHuella.Image = SIA.My.Resources.IconoHuellaNo

        dgvAlumnos.CurrentCell = Nothing
        dgvAlumnos.ClearSelection()
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Dim _CA As New Arduino

        Cancelar()

        If _CA.Arduino_Connect(txtIP.Text, 80) Then
            _CA.Arduino_Write("N")
            _CA.Arduino_Disconnect()
        End If
    End Sub

    Private Sub tmrLectura_Tick(sender As Object, e As EventArgs) Handles tmrLectura.Tick
        Dim _CA As New Arduino

        If _CA.Arduino_Connect(txtIP.Text, 80) Then
            Model = _CA.Arduino_Read()

            If Model <> Nothing And Model <> "Error" Then
                _CA.Arduino_Write("H")

                tmrLectura.Enabled = False

                Model = RTrim(Model)

                pbxHuella.Image = SIA.My.Resources.IconoHuellaOk

                lblEsperando.Text = "TERMINA DE GUARDAR"

                _CA.Arduino_Disconnect()
            End If
        End If
    End Sub

    Private Sub pbxEliminar_Click(sender As Object, e As EventArgs) Handles pbxEliminar.Click
        If dgvAlumnos.CurrentRow IsNot Nothing Then
            If dgvAlumnos.CurrentRow.Cells.Item("Huella").Value <> "NO" Then
                Dim G As New GrabaDatos
                Dim resP As DialogResult
                Dim _CA As New Arduino

                resP = MessageBox.Show("Eliminar Huella Dactilar ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then

                    G.Grabar("Alumnos", "NoImagen", "sistema_asistencia.modHuella_Modelo", dgvAlumnos.CurrentRow.Cells.Item("idAlumnos").Value, 0, "-")

                    MsgBox("Huella Dactilar eliminada con exito... !", vbInformation, "Servico de Alertas")
                    ListaAlumnos()
                End If
            Else
                MsgBox("Error: El alumno seleccionado no tiene Huella... !", vbInformation, "Servico de Alertas")
            End If
        Else
            MsgBox("Error: Selecciona un Alumno de la lista para eliminar su Huella... !", vbInformation, "Servico de Alertas")
        End If
    End Sub
End Class