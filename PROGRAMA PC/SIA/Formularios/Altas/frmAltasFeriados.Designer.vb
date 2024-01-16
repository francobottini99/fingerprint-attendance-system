<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAltasFeriados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAltasFeriados))
        Me.gbxFeriados = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.dgvFeriados = New System.Windows.Forms.DataGridView()
        Me.gbxPPal = New System.Windows.Forms.GroupBox()
        Me.mtcCalendario = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbxNuevo = New System.Windows.Forms.PictureBox()
        Me.pbxEliminar = New System.Windows.Forms.PictureBox()
        Me.pbxSalir = New System.Windows.Forms.PictureBox()
        Me.pbxGuardar = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.gbxMotivo = New System.Windows.Forms.GroupBox()
        Me.txtMotivo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecSel = New System.Windows.Forms.Label()
        Me.gbxFeriados.SuspendLayout()
        CType(Me.dgvFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPPal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxMotivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxFeriados
        '
        Me.gbxFeriados.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbxFeriados.BackColor = System.Drawing.Color.Transparent
        Me.gbxFeriados.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxFeriados.Controls.Add(Me.dgvFeriados)
        Me.gbxFeriados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxFeriados.ForeColor = System.Drawing.Color.White
        Me.gbxFeriados.Location = New System.Drawing.Point(549, 12)
        Me.gbxFeriados.Name = "gbxFeriados"
        Me.gbxFeriados.Size = New System.Drawing.Size(516, 575)
        Me.gbxFeriados.TabIndex = 23
        Me.gbxFeriados.TabStop = False
        Me.gbxFeriados.Text = "  Feriados / Paros Existentes  "
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.LightCoral
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtFecha.Location = New System.Drawing.Point(7, 17)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(99, 20)
        Me.txtFecha.TabIndex = 26
        Me.txtFecha.Visible = False
        '
        'dgvFeriados
        '
        Me.dgvFeriados.AllowUserToAddRows = False
        Me.dgvFeriados.AllowUserToDeleteRows = False
        Me.dgvFeriados.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvFeriados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFeriados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvFeriados.ColumnHeadersHeight = 30
        Me.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvFeriados.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFeriados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFeriados.Location = New System.Drawing.Point(6, 26)
        Me.dgvFeriados.MultiSelect = False
        Me.dgvFeriados.Name = "dgvFeriados"
        Me.dgvFeriados.ReadOnly = True
        Me.dgvFeriados.RowHeadersVisible = False
        Me.dgvFeriados.RowHeadersWidth = 100
        Me.dgvFeriados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvFeriados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFeriados.Size = New System.Drawing.Size(504, 543)
        Me.dgvFeriados.TabIndex = 9
        '
        'gbxPPal
        '
        Me.gbxPPal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbxPPal.BackColor = System.Drawing.Color.Transparent
        Me.gbxPPal.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxPPal.Controls.Add(Me.txtFecha)
        Me.gbxPPal.Controls.Add(Me.lblFecSel)
        Me.gbxPPal.Controls.Add(Me.Label1)
        Me.gbxPPal.Controls.Add(Me.mtcCalendario)
        Me.gbxPPal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxPPal.ForeColor = System.Drawing.Color.White
        Me.gbxPPal.Location = New System.Drawing.Point(228, 12)
        Me.gbxPPal.Name = "gbxPPal"
        Me.gbxPPal.Size = New System.Drawing.Size(315, 314)
        Me.gbxPPal.TabIndex = 22
        Me.gbxPPal.TabStop = False
        Me.gbxPPal.Text = " Seleccione Día de Paro o Feriado "
        '
        'mtcCalendario
        '
        Me.mtcCalendario.BackColor = System.Drawing.SystemColors.Info
        Me.mtcCalendario.Enabled = False
        Me.mtcCalendario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtcCalendario.ForeColor = System.Drawing.Color.Black
        Me.mtcCalendario.Location = New System.Drawing.Point(34, 36)
        Me.mtcCalendario.MaxSelectionCount = 1
        Me.mtcCalendario.Name = "mtcCalendario"
        Me.mtcCalendario.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.GroupBox1.Controls.Add(Me.pbxNuevo)
        Me.GroupBox1.Controls.Add(Me.pbxEliminar)
        Me.GroupBox1.Controls.Add(Me.pbxSalir)
        Me.GroupBox1.Controls.Add(Me.pbxGuardar)
        Me.GroupBox1.Controls.Add(Me.pbxCancelar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 575)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'pbxNuevo
        '
        Me.pbxNuevo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxNuevo.BackColor = System.Drawing.Color.Transparent
        Me.pbxNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxNuevo.Image = Global.SIA.My.Resources.Resources.btnNuevoNo
        Me.pbxNuevo.Location = New System.Drawing.Point(10, 17)
        Me.pbxNuevo.Name = "pbxNuevo"
        Me.pbxNuevo.Size = New System.Drawing.Size(196, 105)
        Me.pbxNuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxNuevo.TabIndex = 12
        Me.pbxNuevo.TabStop = False
        '
        'pbxEliminar
        '
        Me.pbxEliminar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxEliminar.BackColor = System.Drawing.Color.Transparent
        Me.pbxEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxEliminar.Image = Global.SIA.My.Resources.Resources.btnEliminarNo
        Me.pbxEliminar.Location = New System.Drawing.Point(10, 128)
        Me.pbxEliminar.Name = "pbxEliminar"
        Me.pbxEliminar.Size = New System.Drawing.Size(196, 105)
        Me.pbxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxEliminar.TabIndex = 13
        Me.pbxEliminar.TabStop = False
        '
        'pbxSalir
        '
        Me.pbxSalir.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxSalir.BackColor = System.Drawing.Color.Transparent
        Me.pbxSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSalir.Image = Global.SIA.My.Resources.Resources.btnSalirNo1
        Me.pbxSalir.Location = New System.Drawing.Point(10, 461)
        Me.pbxSalir.Name = "pbxSalir"
        Me.pbxSalir.Size = New System.Drawing.Size(196, 105)
        Me.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSalir.TabIndex = 16
        Me.pbxSalir.TabStop = False
        '
        'pbxGuardar
        '
        Me.pbxGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxGuardar.BackColor = System.Drawing.Color.Transparent
        Me.pbxGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxGuardar.Enabled = False
        Me.pbxGuardar.Image = Global.SIA.My.Resources.Resources.btnGuardarNo
        Me.pbxGuardar.Location = New System.Drawing.Point(10, 239)
        Me.pbxGuardar.Name = "pbxGuardar"
        Me.pbxGuardar.Size = New System.Drawing.Size(196, 105)
        Me.pbxGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxGuardar.TabIndex = 14
        Me.pbxGuardar.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Enabled = False
        Me.pbxCancelar.Image = Global.SIA.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.Location = New System.Drawing.Point(10, 350)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(196, 105)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 15
        Me.pbxCancelar.TabStop = False
        '
        'gbxMotivo
        '
        Me.gbxMotivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gbxMotivo.BackColor = System.Drawing.Color.Transparent
        Me.gbxMotivo.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxMotivo.Controls.Add(Me.txtMotivo)
        Me.gbxMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxMotivo.ForeColor = System.Drawing.Color.White
        Me.gbxMotivo.Location = New System.Drawing.Point(228, 332)
        Me.gbxMotivo.Name = "gbxMotivo"
        Me.gbxMotivo.Size = New System.Drawing.Size(315, 255)
        Me.gbxMotivo.TabIndex = 24
        Me.gbxMotivo.TabStop = False
        Me.gbxMotivo.Text = "  Indique Motivo "
        '
        'txtMotivo
        '
        Me.txtMotivo.Enabled = False
        Me.txtMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivo.Location = New System.Drawing.Point(7, 26)
        Me.txtMotivo.MaxLength = 255
        Me.txtMotivo.Multiline = True
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Size = New System.Drawing.Size(302, 220)
        Me.txtMotivo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Seleccionada"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecSel
        '
        Me.lblFecSel.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.lblFecSel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecSel.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecSel.ForeColor = System.Drawing.Color.Maroon
        Me.lblFecSel.Location = New System.Drawing.Point(34, 239)
        Me.lblFecSel.Name = "lblFecSel"
        Me.lblFecSel.Size = New System.Drawing.Size(248, 61)
        Me.lblFecSel.TabIndex = 3
        Me.lblFecSel.Text = "30/10/2018"
        Me.lblFecSel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAltasFeriados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(1073, 596)
        Me.Controls.Add(Me.gbxMotivo)
        Me.Controls.Add(Me.gbxFeriados)
        Me.Controls.Add(Me.gbxPPal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAltasFeriados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAltasFeriados"
        Me.gbxFeriados.ResumeLayout(False)
        CType(Me.dgvFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPPal.ResumeLayout(False)
        Me.gbxPPal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbxNuevo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxEliminar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxMotivo.ResumeLayout(False)
        Me.gbxMotivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxFeriados As System.Windows.Forms.GroupBox
    Friend WithEvents dgvFeriados As System.Windows.Forms.DataGridView
    Friend WithEvents gbxPPal As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents pbxSalir As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxGuardar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxEliminar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxNuevo As System.Windows.Forms.PictureBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents mtcCalendario As MonthCalendar
    Friend WithEvents gbxMotivo As GroupBox
    Friend WithEvents txtMotivo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecSel As Label
End Class
