Public Class frmAltasAlumnos

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

    Private Sub pbxAyuda_GotFocus(sender As Object, e As EventArgs) Handles pbxAyuda.GotFocus
        pbxAyuda.Image = SIA.My.Resources.btnAyudaSi
    End Sub

    Private Sub pbxAyuda_LostFocus(sender As Object, e As EventArgs) Handles pbxAyuda.LostFocus
        pbxAyuda.Image = SIA.My.Resources.btnAyudaNo
    End Sub

    Private Sub pbxAyuda_MouseEnter(sender As Object, e As EventArgs) Handles pbxAyuda.MouseEnter
        pbxAyuda.Image = SIA.My.Resources.btnAyudaSi
    End Sub

    Private Sub pbxAyuda_MouseLeave(sender As Object, e As EventArgs) Handles pbxAyuda.MouseLeave
        pbxAyuda.Image = SIA.My.Resources.btnAyudaNo
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

    Private Sub btnGrabar_GotFocus(sender As Object, e As EventArgs) Handles pbxAgregar.GotFocus
        If (pbxAgregar.Enabled = True) Then
            pbxAgregar.Image = SIA.My.Resources.btnAgregarAlumnosSi
        End If
    End Sub

    Private Sub btnGrabar_LostFocus(sender As Object, e As EventArgs) Handles pbxAgregar.LostFocus
        If (pbxAgregar.Enabled = True) Then
            pbxAgregar.Image = SIA.My.Resources.btnAgregarAlumnosNo
        End If
    End Sub

    Private Sub btnGrabar_MouseEnter(sender As Object, e As EventArgs) Handles pbxAgregar.MouseEnter
        If (pbxAgregar.Enabled = True) Then
            pbxAgregar.Image = SIA.My.Resources.btnAgregarAlumnosSi
        End If
    End Sub

    Private Sub btnGrabar_MouseLeave(sender As Object, e As EventArgs) Handles pbxAgregar.MouseLeave
        If (pbxAgregar.Enabled = True) Then
            pbxAgregar.Image = SIA.My.Resources.btnAgregarAlumnosNo
        End If
    End Sub

    Private Sub btnImpExcel_GotFocus(sender As Object, e As EventArgs) Handles btnImpExcel.GotFocus
        If (btnImpExcel.Enabled = True) Then
            btnImpExcel.Image = SIA.My.Resources.btnImportarExcelSi
        End If
    End Sub

    Private Sub btnImpExcel_LostFocus(sender As Object, e As EventArgs) Handles btnImpExcel.LostFocus
        If (btnImpExcel.Enabled = True) Then
            btnImpExcel.Image = SIA.My.Resources.btnImportarExcelNo
        End If
    End Sub

    Private Sub btnImpExcel_MouseEnter(sender As Object, e As EventArgs) Handles btnImpExcel.MouseEnter
        If (btnImpExcel.Enabled = True) Then
            btnImpExcel.Image = SIA.My.Resources.btnImportarExcelSi
        End If
    End Sub

    Private Sub btnImpExcel_MouseLeave(sender As Object, e As EventArgs) Handles btnImpExcel.MouseLeave
        If (btnImpExcel.Enabled = True) Then
            btnImpExcel.Image = SIA.My.Resources.btnImportarExcelNo
        End If
    End Sub

    Private Sub cbxCurso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxCurso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNombre.SelectionLength = Len(txtNombre.Text)
            txtNombre.Select()
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            cbxSexo.SelectionLength = Len(cbxSexo.Text)
            cbxSexo.Select()
        End If
    End Sub

    Private Sub cbxSexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxSexo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            If txtOrigen.Text = "Nuevo" Then
                pbxAgregar.Select()
            Else
                pbxGuardar.Select()
            End If
        Else
            e.Handled = True
        End If
    End Sub

    'Private Sub cbxGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxGrupo.KeyPress
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        e.Handled = True
    '        btnCargarAlumnos.Select()
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub cbxGrupo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxGrupo.SelectedIndexChanged
    '    Dim _Dt As New DataTable
    '    Dim _Ver As New Mostrar

    '    _Dt = _Ver.verGrupo

    '    txtIdGrupo.Text = ""

    '    For Each _Dr As DataRow In _Dt.Rows
    '        If _Dr("Grupo") = cbxGrupo.Text And _Dr("Curso_idCurso") = txtIdCurso.Text Then
    '            txtIdGrupo.Text = _Dr("idGrupo")
    '        End If
    '    Next
    'End Sub

    Private Sub cbxCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCurso.SelectedIndexChanged
        Dim _Dt, _Dt2 As New DataTable
        Dim _Ver As New Mostrar
        Dim SepDiv As String = Mid(cbxCurso.Text, 5, 1)
        Dim SepAño As String = Microsoft.VisualBasic.Left(cbxCurso.Text, 1)

        _Dt = _Ver.verCurso
        _Dt2 = _Ver.verGrupo

        txtIdCurso.Text = ""

        cbxGrupo.Items.Clear()

        cbxGrupo.Items.Add("Ninguno")

        cbxGrupo.Text = "Ninguno"

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

    Private Sub Cancelar()
        gbxDatos.Enabled = False
        gbxCursos.Enabled = True

        pbxNuevo.Enabled = True
        pbxGuardar.Enabled = False
        pbxCancelar.Enabled = False
        pbxModificar.Enabled = True
        pbxSalir.Enabled = True

        txtNombre.Text = ""
        cbxGrupo.Text = ""
        cbxSexo.Text = ""
        cbxCurso.Text = ""
        txtIdGrupo.Text = ""
        txtIdCurso.Text = ""
        txtOrigen.Text = ""

        gbxDatos.Enabled = False

        pbxNuevo.Image = SIA.My.Resources.btnNuevoNo
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvCursos.CurrentCell = Nothing
        dgvAlumnos.CurrentCell = Nothing
        dgvAlumnos.Visible = True
        dgvAlumnosPreGrabados.Visible = False

        dgvAlumnos.DataSource = Nothing

        Dim rows As Integer = dgvAlumnosPreGrabados.Rows.Count - 1

        If dgvAlumnosPreGrabados.Rows.Count > 0 Then
            For j As Integer = rows To 0 Step -1
                dgvAlumnosPreGrabados.Rows.Remove(dgvAlumnosPreGrabados.Rows(j))
            Next
        End If

        dgvAlumnosPreGrabados.ColumnHeadersVisible = False

        lblMsg.Text = ""
        lblMsg.Visible = False

        pbxNuevo.Focus()
    End Sub

    Private Sub btnGuardar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxGuardar_Click(1, Nothing)
        End If
    End Sub

    Private Sub pbxSalir_Click(sender As Object, e As EventArgs) Handles pbxSalir.Click
        Me.Close()
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
        dgvCursos.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCursos.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCursos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvCursos.Sort(dgvCursos.Columns("Año"), System.ComponentModel.ListSortDirection.Ascending)

        dgvCursos.ClearSelection()
        dgvCursos.CurrentCell = Nothing

        cbxCurso.Items.Clear()
        For Each _Dr As DataRow In _Dt.Rows
            cbxCurso.Items.Add(_Dr("Año") & "° " & """" & _Dr("Division") & """")
        Next
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

    Private Sub btnAgregar(ByVal sender As System.Object, ByVal e As KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            pbxAgregar_Click(1, Nothing)
        End If
    End Sub

    Private Sub frmAltasAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctlNuevo As Control = DirectCast(pbxNuevo, Control)
        Dim keyprNuevo = New KeyPressEventHandler(AddressOf btnNuevo)

        Dim ctlGuardar As Control = DirectCast(pbxGuardar, Control)
        Dim keyprGuardar = New KeyPressEventHandler(AddressOf btnGuardar)

        Dim ctlModificar As Control = DirectCast(pbxModificar, Control)
        Dim keyprModificar = New KeyPressEventHandler(AddressOf btnModificar)

        Dim ctlAgrAlum As Control = DirectCast(pbxAgregar, Control)
        Dim keyprAgrAlum = New KeyPressEventHandler(AddressOf btnAgregar)

        AddHandler ctlNuevo.KeyPress, keyprNuevo
        AddHandler ctlGuardar.KeyPress, keyprGuardar
        AddHandler ctlModificar.KeyPress, keyprModificar
        AddHandler ctlAgrAlum.KeyPress, keyprAgrAlum

        Me.Text = "S.I.A - Sistema Inteligente de Asistencia - Formulario Alta Alumnos"

        dgvAlumnosPreGrabados.DefaultCellStyle.ForeColor = Color.Black
        dgvAlumnos.DefaultCellStyle.ForeColor = Color.Black
        dgvCursos.DefaultCellStyle.ForeColor = Color.Black

        dgvCursos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
        dgvAlumnos.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
        dgvAlumnosPreGrabados.DefaultCellStyle.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
        CargarCursos()
        pbxNuevo.Select()
    End Sub

    Private Sub pbxNuevo_Click(sender As Object, e As EventArgs) Handles pbxNuevo.Click
        ActivarCtrls(Me.Name)
        txtOrigen.Text = "Nuevo"

        pbxNuevo.Image = SIA.My.Resources.btnNuevoSi
        pbxModificar.Image = SIA.My.Resources.btnModificarNo

        dgvCursos.CurrentCell = Nothing
        dgvAlumnos.DataSource = Nothing
        dgvAlumnos.Visible = False
        dgvAlumnosPreGrabados.Visible = True

        cbxCurso.Text = ""
        cbxGrupo.Text = ""
        cbxSexo.Text = ""
        txtNombre.Text = ""
        lblMsg.Text = "Los Alumnos que se muestran en esta lista NO estás dados de alta definitivamente, para ello debe precionar el botón GUARDAR una vez que termine de ingresarlos !"
        lblMsg.Visible = True

        cbxCurso.Select()
    End Sub

    Private Sub pbxModificar_Click(sender As Object, e As EventArgs) Handles pbxModificar.Click
        If dgvAlumnos.CurrentRow IsNot Nothing Then
            ActivarCtrls(Me.Name)
            txtOrigen.Text = "Modficar"

            btnImpExcel.Enabled = False
            pbxAgregar.Enabled = False
            pbxAyuda.Enabled = False

            pbxModificar.Image = SIA.My.Resources.btnModificarSi
            pbxNuevo.Image = SIA.My.Resources.btnNuevoNo

            cbxCurso.Select()
        Else
            MsgBox("Error: Selecciona un alumno de la lista para poder modificarlo... !", vbInformation, "Servico de Alertas")
        End If
    End Sub

    Private Sub pbxGuardar_Click(sender As Object, e As EventArgs) Handles pbxGuardar.Click
        Dim G As New GrabaDatos
        Dim resP As DialogResult
        Dim _Ver As New Mostrar
        Dim _Dt As New DataTable
        Dim ulTid As Integer

        _Dt = _Ver.verCicloLectivo()
        ulTid = _Dt.Rows(_Dt.Rows.Count - 1).Item(0)

        If txtOrigen.Text = "Nuevo" Then
            If dgvAlumnosPreGrabados.Rows.Count < 1 Then
                MsgBox("Error: No hay ningun alumno cargado para guardar... !", vbExclamation, "Servico de Alertas")
            Else
                resP = MessageBox.Show("Grabar alumnos ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then
                    For i As Integer = 0 To dgvAlumnosPreGrabados.Rows.Count - 1
                        Dim Msg As Boolean = False
                        Dim resN As DialogResult
                        Dim idGrupo As Integer

                        _Dt = _Ver.verAlumno_Nombre_idCurso(dgvAlumnosPreGrabados.Rows(i).Cells.Item(2).Value, dgvAlumnosPreGrabados.Rows(i).Cells.Item(0).Value)

                        If _Dt.Rows.Count > 0 Then
                            Msg = True
                        Else
                            Msg = False
                        End If

                        If Msg = False Then
                            resN = Windows.Forms.DialogResult.OK
                        Else
                            resN = MessageBox.Show("Ya existe un alumno con el nombre '" & dgvAlumnosPreGrabados.Rows(i).Cells.Item(2).Value & "' en el mismo curso (" & dgvAlumnosPreGrabados.Rows(i).Cells.Item(4).Value & "), ¿ desea grabarlo de todas formas ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        End If

                        If resN = Windows.Forms.DialogResult.OK Then
                            If dgvAlumnosPreGrabados.Rows(i).Cells.Item(1).Value = "" Then
                                _Dt = _Ver.verGrupo_Grupo_idCurso("Ninguno", dgvAlumnosPreGrabados.Rows(i).Cells.Item(0).Value, ulTid)

                                If _Dt.Rows.Count < 1 Then
                                    G.Grabar("Grupo", "NoImagen", "sistema_asistencia.insGrupo", "Ninguno", dgvAlumnosPreGrabados.Rows(i).Cells.Item(0).Value, ulTid, frmIngresoSIA.txtIdUs.Text)
                                End If

                                _Dt = _Ver.verGrupo_Grupo_idCurso("Ninguno", dgvAlumnosPreGrabados.Rows(i).Cells.Item(0).Value, ulTid)

                                idGrupo = _Dt.Rows(0).Item(0)
                            Else
                                idGrupo = dgvAlumnosPreGrabados.Rows(i).Cells.Item(1).Value
                            End If

                            G.Grabar("Alumnos", "NoImagen", "sistema_asistencia.insAlumno", dgvAlumnosPreGrabados.Rows(i).Cells.Item(2).Value, _
                                     dgvAlumnosPreGrabados.Rows(i).Cells.Item(3).Value, 0, "-", "Activo", "-", idGrupo, CInt(frmIngresoSIA.txtCicloID.Text), _
                                     CInt(frmIngresoSIA.txtIdUs.Text), CInt(txtIdCurso.Text))
                        End If
                    Next

                    Cancelar()
                    lblMsg.Text = ""
                    lblMsg.Visible = False
                    MsgBox("Alumnos grabados con exito... !", vbInformation, "Servico de Alertas")
                End If
            End If
        Else
            resP = MessageBox.Show("Modificar alumno ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If resP = Windows.Forms.DialogResult.OK Then
                G.Grabar("Alumnos", "NoImagen", "sistema_asistencia.modAlumno", dgvAlumnos.CurrentRow.Cells.Item(0).Value, txtNombre.Text,
                         cbxSexo.Text, txtIdCurso.Text)

                MsgBox("Alumno modificado con exito... !", vbInformation, "Servico de Alertas")
            End If

            pbxAgregar.Enabled = True
            btnImpExcel.Enabled = True
            pbxAyuda.Enabled = True

            Cancelar()
        End If
    End Sub

    Private Sub pbxCancelar_Click(sender As Object, e As EventArgs) Handles pbxCancelar.Click
        Cancelar()
    End Sub

    Private Sub pbxAgregar_Click(sender As Object, e As EventArgs) Handles pbxAgregar.Click
        If txtNombre.Text = "" Then
            MsgBox("Error: 'Apellido y Nombre' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
            txtNombre.Select()
        Else
            If cbxSexo.Text = "" Then
                MsgBox("Error: 'Sexo' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                cbxSexo.Select()
            Else
                If cbxCurso.Text = "" Then
                    MsgBox("Error: 'Curso' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                    cbxCurso.Select()
                Else
                    If cbxGrupo.Text = "" Then
                        MsgBox("Error: 'Grupo' es un campo obligatorio... !", vbInformation, "Servico de Alertas")
                        cbxGrupo.Select()
                    Else
                        If txtIdGrupo.Text = "" And cbxGrupo.Text <> "Ninguno" Then
                            MsgBox("Error: El grupo ingresado no se encuentra en la base de datos... !", vbInformation, "Servico de Alertas")
                            cbxGrupo.Select()
                        Else
                            If txtIdCurso.Text = "" Then
                                MsgBox("Error: El curso ingresado no se encuentra en la base de datos... !", vbInformation, "Servico de Alertas")
                                cbxCurso.Select()
                            Else
                                GenerarDGVAlumnosPreGrabados()

                                Dim rows As Integer = dgvAlumnosPreGrabados.Rows.Count - 1
                                Dim Msg As Boolean = False
                                Dim resP As DialogResult

                                For j As Integer = rows To 0 Step -1
                                    If dgvAlumnosPreGrabados.Rows(j).Cells.Item(2).Value = txtNombre.Text Then
                                        Msg = True
                                    End If
                                Next

                                If Msg = False Then
                                    resP = Windows.Forms.DialogResult.OK
                                Else
                                    resP = MessageBox.Show("Ya existe un alumno pre-grabado con ese nombre, ¿ desea continuar de todas formas ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                                End If

                                If resP = Windows.Forms.DialogResult.OK Then
                                    dgvAlumnosPreGrabados.Rows.Add(txtIdCurso.Text, "", (txtNombre.Text), cbxSexo.Text, cbxCurso.Text, "Ninguno")

                                    txtNombre.Text = ""

                                    txtNombre.Select()
                                    dgvAlumnosPreGrabados.CurrentCell = Nothing
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub GenerarDGVAlumnosPreGrabados()
        dgvAlumnosPreGrabados.RowTemplate.Height = 25
        dgvAlumnosPreGrabados.ColumnCount = 6
        dgvAlumnosPreGrabados.Columns(0).Name = "idCurso"
        dgvAlumnosPreGrabados.Columns(1).Name = "idGrupo"
        dgvAlumnosPreGrabados.Columns(2).Name = "Nombre y Apellido"
        dgvAlumnosPreGrabados.Columns(3).Name = "Sexo"
        dgvAlumnosPreGrabados.Columns(4).Name = "Curso"
        dgvAlumnosPreGrabados.Columns(5).Name = "Grupo"

        dgvAlumnosPreGrabados.Columns(0).Visible = False
        dgvAlumnosPreGrabados.Columns(1).Visible = False
        dgvAlumnosPreGrabados.Columns(5).Visible = False
        dgvAlumnosPreGrabados.ColumnHeadersVisible = True

        dgvAlumnosPreGrabados.Columns("Nombre y Apellido").Width = 400
        dgvAlumnosPreGrabados.Columns("Sexo").Width = 120
        dgvAlumnosPreGrabados.Columns("Curso").Width = 80
    End Sub

    Private Sub dgvAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumnos.CellClick
        If dgvAlumnos.CurrentRow.Index > -1 Then
            txtNombre.Text = dgvAlumnos.CurrentRow.Cells.Item(1).Value
            cbxSexo.Text = dgvAlumnos.CurrentRow.Cells.Item(2).Value
            txtIdCurso.Text = dgvAlumnos.CurrentRow.Cells.Item(6).Value
            cbxCurso.Text = dgvAlumnos.CurrentRow.Cells.Item(7).Value & "° " & """" & dgvAlumnos.CurrentRow.Cells.Item(8).Value & """"
            pbxModificar.Select()
        End If
    End Sub

    Private Sub dgvCursos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellClick
        If dgvCursos.CurrentRow.Index > -1 Then
            Dim _Dt As New DataTable
            Dim _Ver As New Mostrar

            _Dt = _Ver.consAlumno_Curso(dgvCursos.CurrentRow.Cells.Item(0).Value, frmIngresoSIA.txtCicloID.Text)

            txtNombre.Text = ""
            cbxGrupo.Text = ""
            cbxSexo.Text = ""
            cbxCurso.Text = ""
            txtIdGrupo.Text = ""
            txtIdCurso.Text = ""

            If _Dt.Rows.Count < 1 Then
                dgvAlumnos.ColumnHeadersVisible = False
            Else
                dgvAlumnos.ColumnHeadersVisible = True
            End If

            dgvAlumnos.DataSource = _Dt

            dgvAlumnos.Columns("idAlumnos").Visible = False
            dgvAlumnos.Columns("idHuella_Digital").Visible = False
            dgvAlumnos.Columns("Modelo_Huella").Visible = False
            dgvAlumnos.Columns("Estado").Visible = False
            dgvAlumnos.Columns("idCurso").Visible = False
            dgvAlumnos.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False
            dgvAlumnos.Columns("Usuarios_idUsuarios").Visible = False
            dgvAlumnos.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvAlumnos.Columns("Sexo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvAlumnos.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvAlumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvAlumnos.Columns("Nombre").Width = 120
            dgvAlumnos.Columns("Sexo").Width = 50
            dgvAlumnos.Columns("Año").Width = 50
            dgvAlumnos.Columns("Division").Width = 70

            dgvAlumnos.Sort(dgvAlumnos.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

            dgvAlumnos.ClearSelection()
            dgvAlumnos.CurrentCell = Nothing

            If dgvAlumnos.RowCount <= 0 Then
                MsgBox("Error: No hay alumnos en ese curso... !", vbInformation, "Servico de Alertas")
                dgvCursos.ClearSelection()
                dgvCursos.CurrentCell = Nothing
            End If
        End If
    End Sub

    Private Sub pbxEliminar_Click(sender As Object, e As EventArgs) Handles pbxEliminar.Click
        If dgvAlumnosPreGrabados.Visible = True Then
            If dgvAlumnosPreGrabados.CurrentRow Is Nothing Then
                MsgBox("Error: Selecciona un Alumno de la lista para borrarlo... !", vbInformation, "Servico de Alertas")
            Else
                Dim resP As DialogResult

                resP = MessageBox.Show("Eliminas el alumno de la lista ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then
                    If dgvAlumnosPreGrabados.CurrentRow.Index > -1 Then
                        If dgvAlumnosPreGrabados.RowCount = 1 Then
                            dgvAlumnosPreGrabados.ColumnHeadersVisible = False
                        End If

                        dgvAlumnosPreGrabados.Rows.Remove(dgvAlumnosPreGrabados.CurrentRow)

                        dgvAlumnos.ClearSelection()
                        dgvAlumnosPreGrabados.CurrentCell = Nothing
                    End If
                End If
            End If
        Else
            If dgvAlumnos.CurrentRow IsNot Nothing Then
                Dim G As New GrabaDatos
                Dim resP As DialogResult
                Dim _Ver As New Mostrar
                Dim _Dt As New DataTable

                resP = MessageBox.Show("Seguro que quieres eliminar este alumno ?", "Servico de Alertas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If resP = Windows.Forms.DialogResult.OK Then
                    G.Grabar("Alumnos", "NoImagen", "sistema_asistencia.elimAlumno", dgvAlumnos.CurrentRow.Cells.Item(0).Value)

                    If dgvCursos.CurrentRow.Index > -1 Then
                        _Dt = _Ver.consAlumno_Curso(dgvCursos.CurrentRow.Cells.Item(0).Value, frmIngresoSIA.txtCicloID.Text)

                        txtNombre.Text = ""
                        cbxGrupo.Text = ""
                        cbxSexo.Text = ""
                        cbxCurso.Text = ""
                        txtIdGrupo.Text = ""
                        txtIdCurso.Text = ""

                        If _Dt.Rows.Count < 1 Then
                            dgvAlumnos.ColumnHeadersVisible = False
                        Else
                            dgvAlumnos.ColumnHeadersVisible = True
                        End If

                        dgvAlumnos.DataSource = _Dt

                        dgvAlumnos.Columns("idAlumnos").Visible = False
                        dgvAlumnos.Columns("idHuella_Digital").Visible = False
                        dgvAlumnos.Columns("Modelo_Huella").Visible = False
                        dgvAlumnos.Columns("Estado").Visible = False
                        dgvAlumnos.Columns("idCurso").Visible = False
                        dgvAlumnos.Columns("CicloLectivo_idCiclo_Lectivo").Visible = False
                        dgvAlumnos.Columns("Usuarios_idUsuarios").Visible = False
                        dgvAlumnos.Columns("Año").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvAlumnos.Columns("Sexo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvAlumnos.Columns("Division").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvAlumnos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgvAlumnos.Columns("Nombre").Width = 120
                        dgvAlumnos.Columns("Sexo").Width = 50
                        dgvAlumnos.Columns("Año").Width = 50
                        dgvAlumnos.Columns("Division").Width = 70

                        dgvAlumnos.Sort(dgvAlumnos.Columns("Nombre"), System.ComponentModel.ListSortDirection.Ascending)

                        dgvAlumnos.ClearSelection()
                        dgvAlumnos.CurrentCell = Nothing

                        If dgvAlumnos.RowCount <= 0 Then
                            MsgBox("Error: No hay alumnos en ese curso... !", vbInformation, "Servico de Alertas")
                            dgvCursos.ClearSelection()
                            dgvCursos.CurrentCell = Nothing
                        End If
                    End If

                    MsgBox("Alumno eliminado... !", vbInformation, "Servico de Alertas")
                End If
            Else
                MsgBox("Error: Selecciona un Alumno de la lista para borrarlo... !", vbInformation, "Servico de Alertas")
            End If
        End If
    End Sub

    Private Sub btnImpExcel_Click(sender As Object, e As EventArgs) Handles btnImpExcel.Click
        If cbxCurso.Text <> "" Then
            If cbxGrupo.Text <> "" Then
                importarExcel(dgvExcel)

                Dim rows As Integer = dgvExcel.Rows.Count - 1
                Dim columns As Integer = dgvExcel.ColumnCount - 1
                Dim ColSexo As Integer = 0
                Dim ColNombre As Integer = 0
                Dim RowTitulos As Integer = 0
                Dim Sexo As String = ""

                If dgvExcel.Rows.Count > 0 Then

                    Dim col As DataGridViewColumn = Nothing
                    Dim h As Integer = 0

                    Do While (h < dgvExcel.Columns.Count)
                        If h = 0 Then
                            col = dgvExcel.Columns.GetFirstColumn(DataGridViewElementStates.Visible)
                        Else
                            col = dgvExcel.Columns.GetNextColumn(col, DataGridViewElementStates.Visible, DataGridViewElementStates.None)
                        End If

                        If UCase$(col.Name.ToString).Replace(" "c, String.Empty) = "SEXO" Then
                            ColSexo = h
                            RowTitulos = -1
                        ElseIf UCase$(col.Name.ToString).Replace(" "c, String.Empty) = "NOMBRE" Then
                            ColNombre = h
                        End If

                        h = h + 1
                    Loop

                    If RowTitulos <> -1 Then
                        For j As Integer = 0 To rows Step 1
                            For i As Integer = 0 To columns Step 1
                                If dgvExcel.Rows(j).Cells.Item(i).Value.ToString.Replace(" "c, String.Empty) <> "" Then
                                    If UCase$(dgvExcel.Rows(j).Cells.Item(i).Value.ToString).Replace(" "c, String.Empty) = "SEXO" Then
                                        ColSexo = i
                                        RowTitulos = j
                                    ElseIf UCase$(dgvExcel.Rows(j).Cells.Item(i).Value.ToString).Replace(" "c, String.Empty) = "NOMBRE" Then
                                        ColNombre = i
                                    End If
                                End If
                            Next
                        Next
                    End If

                    GenerarDGVAlumnosPreGrabados()

                    For j As Integer = 0 To rows Step 1
                        If ColNombre <> 0 Or ColSexo <> 0 Then
                            If dgvExcel.Rows(j).Cells.Item(ColNombre).Value.ToString.Replace(" "c, String.Empty) <> "" And j > RowTitulos Then
                                If UCase$(dgvExcel.Rows(j).Cells.Item(ColSexo).Value.ToString).Replace(" "c, String.Empty) = "V" Then
                                    Sexo = "Masculino"
                                ElseIf UCase$(dgvExcel.Rows(j).Cells.Item(ColSexo).Value.ToString).Replace(" "c, String.Empty) = "M" Then
                                    Sexo = "Femenino"
                                Else
                                    Sexo = "-"
                                End If

                                dgvAlumnosPreGrabados.Rows.Add(txtIdCurso.Text, "", dgvExcel.Rows(j).Cells.Item(ColNombre).Value.ToString, Sexo, cbxCurso.Text, "Ninguno")
                            End If
                        End If
                    Next

                    If dgvAlumnosPreGrabados.RowCount > 0 Then
                        dgvAlumnosPreGrabados.CurrentCell = Nothing

                        MsgBox("PLANILLA IMPORTADA !" + Chr(13) + Chr(13) + "Si los datos mostrados no son los correctos verifique el formato de la planilla excel (Mas informacion del formato en el boton de Ayuda que se encuentra a la derecha del boton Importar Execel)", vbInformation, "Servico de Alertas")
                    Else
                        dgvAlumnosPreGrabados.ColumnHeadersVisible = False
                        MsgBox("Error: El formato de la planilla excel es incorrecto... !", vbInformation, "Servico de Alertas")
                        frmAyudaAltasAlumnos.ShowDialog()
                    End If
                End If
            Else
                MsgBox("Error: Antes de importar la lista de alumnos selecciona el Grupo al que seran ingresados... !", vbInformation, "Servico de Alertas")
                cbxGrupo.Select()
            End If
        Else
            MsgBox("Error: Antes de importar la lista de alumnos selecciona el Curso al que seran ingresados... !", vbInformation, "Servico de Alertas")
            cbxCurso.Select()
        End If
    End Sub

    Private Sub pbxAyuda_Click(sender As Object, e As EventArgs) Handles pbxAyuda.Click
        frmAyudaAltasAlumnos.ShowDialog()
    End Sub

    Private Sub cbxGrupo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxGrupo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            txtNombre.SelectionLength = Len(txtNombre.Text)
            txtNombre.Select()
        Else
            e.Handled = True
        End If
    End Sub
End Class