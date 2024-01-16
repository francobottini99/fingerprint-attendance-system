<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaLectores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaLectores))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.gbxLectores = New System.Windows.Forms.GroupBox()
        Me.pbxSeleccionar = New System.Windows.Forms.PictureBox()
        Me.pbxCancelar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvLectoresDisp = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblSelecciona = New System.Windows.Forms.Label()
        Me.lblScan = New System.Windows.Forms.Label()
        Me.gbxLectores.SuspendLayout()
        CType(Me.pbxSeleccionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLectoresDisp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        '
        'gbxLectores
        '
        Me.gbxLectores.BackColor = System.Drawing.Color.Transparent
        Me.gbxLectores.BackgroundImage = Global.SIA.My.Resources.Resources.Panel1
        Me.gbxLectores.Controls.Add(Me.pbxSeleccionar)
        Me.gbxLectores.Controls.Add(Me.pbxCancelar)
        Me.gbxLectores.Controls.Add(Me.Label1)
        Me.gbxLectores.Controls.Add(Me.dgvLectoresDisp)
        Me.gbxLectores.Controls.Add(Me.PictureBox2)
        Me.gbxLectores.Controls.Add(Me.lblSelecciona)
        Me.gbxLectores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxLectores.ForeColor = System.Drawing.Color.White
        Me.gbxLectores.Location = New System.Drawing.Point(5, 5)
        Me.gbxLectores.Name = "gbxLectores"
        Me.gbxLectores.Size = New System.Drawing.Size(756, 446)
        Me.gbxLectores.TabIndex = 37
        Me.gbxLectores.TabStop = False
        '
        'pbxSeleccionar
        '
        Me.pbxSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxSeleccionar.BackColor = System.Drawing.Color.Transparent
        Me.pbxSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxSeleccionar.Image = Global.SIA.My.Resources.Resources.btnSeleccionarLectorNo
        Me.pbxSeleccionar.Location = New System.Drawing.Point(495, 380)
        Me.pbxSeleccionar.Name = "pbxSeleccionar"
        Me.pbxSeleccionar.Size = New System.Drawing.Size(124, 60)
        Me.pbxSeleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxSeleccionar.TabIndex = 130
        Me.pbxSeleccionar.TabStop = False
        '
        'pbxCancelar
        '
        Me.pbxCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbxCancelar.BackColor = System.Drawing.Color.Transparent
        Me.pbxCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxCancelar.Image = Global.SIA.My.Resources.Resources.btnCancelarNo
        Me.pbxCancelar.Location = New System.Drawing.Point(625, 380)
        Me.pbxCancelar.Name = "pbxCancelar"
        Me.pbxCancelar.Size = New System.Drawing.Size(124, 60)
        Me.pbxCancelar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxCancelar.TabIndex = 129
        Me.pbxCancelar.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(120, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(513, 25)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "LECTORES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvLectoresDisp
        '
        Me.dgvLectoresDisp.AllowUserToAddRows = False
        Me.dgvLectoresDisp.AllowUserToDeleteRows = False
        Me.dgvLectoresDisp.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Peru
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvLectoresDisp.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLectoresDisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLectoresDisp.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvLectoresDisp.ColumnHeadersHeight = 30
        Me.dgvLectoresDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvLectoresDisp.ColumnHeadersVisible = False
        Me.dgvLectoresDisp.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.BurlyWood
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGoldenrod
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLectoresDisp.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLectoresDisp.Location = New System.Drawing.Point(6, 68)
        Me.dgvLectoresDisp.MultiSelect = False
        Me.dgvLectoresDisp.Name = "dgvLectoresDisp"
        Me.dgvLectoresDisp.ReadOnly = True
        Me.dgvLectoresDisp.RowHeadersVisible = False
        Me.dgvLectoresDisp.RowHeadersWidth = 100
        Me.dgvLectoresDisp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvLectoresDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLectoresDisp.Size = New System.Drawing.Size(744, 306)
        Me.dgvLectoresDisp.TabIndex = 122
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Silver
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(6, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(744, 30)
        Me.PictureBox2.TabIndex = 127
        Me.PictureBox2.TabStop = False
        '
        'lblSelecciona
        '
        Me.lblSelecciona.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(3, Byte), Integer))
        Me.lblSelecciona.Font = New System.Drawing.Font("Arial Black", 7.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelecciona.ForeColor = System.Drawing.Color.Silver
        Me.lblSelecciona.Location = New System.Drawing.Point(6, 49)
        Me.lblSelecciona.Name = "lblSelecciona"
        Me.lblSelecciona.Size = New System.Drawing.Size(743, 16)
        Me.lblSelecciona.TabIndex = 131
        Me.lblSelecciona.Text = "SELECCIONA EL TERMINAL DESDE EL QUE VAS A INGRESAR LAS HUELLAS"
        Me.lblSelecciona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSelecciona.Visible = False
        '
        'lblScan
        '
        Me.lblScan.BackColor = System.Drawing.Color.Maroon
        Me.lblScan.Font = New System.Drawing.Font("Arial Black", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScan.ForeColor = System.Drawing.Color.White
        Me.lblScan.Location = New System.Drawing.Point(9, 454)
        Me.lblScan.Name = "lblScan"
        Me.lblScan.Size = New System.Drawing.Size(724, 40)
        Me.lblScan.TabIndex = 132
        Me.lblScan.Text = "********************* BUSCANDO TERMINALES *********************"
        Me.lblScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblScan.Visible = False
        '
        'frmListaLectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.ClientSize = New System.Drawing.Size(766, 456)
        Me.Controls.Add(Me.lblScan)
        Me.Controls.Add(Me.gbxLectores)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListaLectores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEstadoConexion"
        Me.gbxLectores.ResumeLayout(False)
        CType(Me.pbxSeleccionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxCancelar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLectoresDisp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer As System.Windows.Forms.Timer
    Friend WithEvents gbxLectores As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents dgvLectoresDisp As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxSeleccionar As System.Windows.Forms.PictureBox
    Friend WithEvents pbxCancelar As System.Windows.Forms.PictureBox
    Friend WithEvents lblSelecciona As System.Windows.Forms.Label
    Friend WithEvents lblScan As System.Windows.Forms.Label
End Class
