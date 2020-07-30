<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Destinos_y_Tarifas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Destinos_y_Tarifas))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HistorialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbEstadoTarifa = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCostoTarifa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvRegistroTarifas = New System.Windows.Forms.DataGridView()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombreDestino = New System.Windows.Forms.TextBox()
        Me.txtCodigoDestino = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnEliminarDestino = New System.Windows.Forms.Button()
        Me.btnModificarDestino = New System.Windows.Forms.Button()
        Me.btnAgregarDestino = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvRegistroDestinos = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnVerHistorialDestinos = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRegistroTarifas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvRegistroDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistorialToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1101, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HistorialToolStripMenuItem
        '
        Me.HistorialToolStripMenuItem.Name = "HistorialToolStripMenuItem"
        Me.HistorialToolStripMenuItem.Size = New System.Drawing.Size(109, 31)
        Me.HistorialToolStripMenuItem.Text = "Historial"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(97, 31)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(72, 31)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEstadoTarifa)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCostoTarifa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tarifas:"
        '
        'cmbEstadoTarifa
        '
        Me.cmbEstadoTarifa.FormattingEnabled = True
        Me.cmbEstadoTarifa.Items.AddRange(New Object() {"Activa", "Inactiva"})
        Me.cmbEstadoTarifa.Location = New System.Drawing.Point(138, 116)
        Me.cmbEstadoTarifa.Name = "cmbEstadoTarifa"
        Me.cmbEstadoTarifa.Size = New System.Drawing.Size(129, 35)
        Me.cmbEstadoTarifa.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado:"
        '
        'txtCostoTarifa
        '
        Me.txtCostoTarifa.Location = New System.Drawing.Point(212, 58)
        Me.txtCostoTarifa.Name = "txtCostoTarifa"
        Me.txtCostoTarifa.Size = New System.Drawing.Size(82, 34)
        Me.txtCostoTarifa.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Costo de Tarifa:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvRegistroTarifas)
        Me.GroupBox2.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(42, 328)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 194)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro Tarifas:"
        '
        'dgvRegistroTarifas
        '
        Me.dgvRegistroTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistroTarifas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroTarifas.Location = New System.Drawing.Point(3, 30)
        Me.dgvRegistroTarifas.Name = "dgvRegistroTarifas"
        Me.dgvRegistroTarifas.RowHeadersWidth = 62
        Me.dgvRegistroTarifas.RowTemplate.Height = 28
        Me.dgvRegistroTarifas.Size = New System.Drawing.Size(454, 161)
        Me.dgvRegistroTarifas.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(418, 92)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 43)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(418, 164)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(114, 44)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(487, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.ForeColor = System.Drawing.Color.ForestGreen
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 10
        Me.BunifuSeparator1.Location = New System.Drawing.Point(547, 0)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(35, 544)
        Me.BunifuSeparator1.TabIndex = 6
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbEstado)
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.txtNombreDestino)
        Me.GroupBox3.Controls.Add(Me.txtCodigoDestino)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(598, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(312, 268)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Destinos:"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Activo ", "Inactivo"})
        Me.cmbEstado.Location = New System.Drawing.Point(114, 216)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(150, 35)
        Me.cmbEstado.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(114, 163)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(60, 34)
        Me.txtPrecio.TabIndex = 6
        '
        'txtNombreDestino
        '
        Me.txtNombreDestino.Location = New System.Drawing.Point(114, 106)
        Me.txtNombreDestino.Name = "txtNombreDestino"
        Me.txtNombreDestino.Size = New System.Drawing.Size(156, 34)
        Me.txtNombreDestino.TabIndex = 5
        '
        'txtCodigoDestino
        '
        Me.txtCodigoDestino.Location = New System.Drawing.Point(210, 51)
        Me.txtCodigoDestino.Name = "txtCodigoDestino"
        Me.txtCodigoDestino.Size = New System.Drawing.Size(60, 34)
        Me.txtCodigoDestino.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 27)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Estado:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Precio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 27)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 27)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Codigo del Desino:"
        '
        'btnEliminarDestino
        '
        Me.btnEliminarDestino.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarDestino.Location = New System.Drawing.Point(961, 235)
        Me.btnEliminarDestino.Name = "btnEliminarDestino"
        Me.btnEliminarDestino.Size = New System.Drawing.Size(117, 40)
        Me.btnEliminarDestino.TabIndex = 10
        Me.btnEliminarDestino.Text = "Eliminar"
        Me.btnEliminarDestino.UseVisualStyleBackColor = True
        '
        'btnModificarDestino
        '
        Me.btnModificarDestino.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarDestino.Location = New System.Drawing.Point(961, 155)
        Me.btnModificarDestino.Name = "btnModificarDestino"
        Me.btnModificarDestino.Size = New System.Drawing.Size(117, 44)
        Me.btnModificarDestino.TabIndex = 9
        Me.btnModificarDestino.Text = "Modificar"
        Me.btnModificarDestino.UseVisualStyleBackColor = True
        '
        'btnAgregarDestino
        '
        Me.btnAgregarDestino.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarDestino.Location = New System.Drawing.Point(961, 79)
        Me.btnAgregarDestino.Name = "btnAgregarDestino"
        Me.btnAgregarDestino.Size = New System.Drawing.Size(117, 43)
        Me.btnAgregarDestino.TabIndex = 8
        Me.btnAgregarDestino.Text = "Agregar"
        Me.btnAgregarDestino.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvRegistroDestinos)
        Me.GroupBox4.Font = New System.Drawing.Font("Fugaz One", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(598, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(460, 194)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro Destinos:"
        '
        'dgvRegistroDestinos
        '
        Me.dgvRegistroDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistroDestinos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroDestinos.Location = New System.Drawing.Point(3, 30)
        Me.dgvRegistroDestinos.Name = "dgvRegistroDestinos"
        Me.dgvRegistroDestinos.RowHeadersWidth = 62
        Me.dgvRegistroDestinos.RowTemplate.Height = 28
        Me.dgvRegistroDestinos.Size = New System.Drawing.Size(454, 161)
        Me.dgvRegistroDestinos.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1033, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(418, 235)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(117, 40)
        Me.btnEliminar.TabIndex = 12
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnVerHistorialDestinos
        '
        Me.btnVerHistorialDestinos.Font = New System.Drawing.Font("Fugaz One", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerHistorialDestinos.Location = New System.Drawing.Point(967, 300)
        Me.btnVerHistorialDestinos.Name = "btnVerHistorialDestinos"
        Me.btnVerHistorialDestinos.Size = New System.Drawing.Size(91, 34)
        Me.btnVerHistorialDestinos.TabIndex = 13
        Me.btnVerHistorialDestinos.Text = "Ver"
        Me.btnVerHistorialDestinos.UseVisualStyleBackColor = True
        '
        'Destinos_y_Tarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1101, 543)
        Me.Controls.Add(Me.btnVerHistorialDestinos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnEliminarDestino)
        Me.Controls.Add(Me.btnModificarDestino)
        Me.Controls.Add(Me.btnAgregarDestino)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Destinos_y_Tarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Destinos_y_Tarifas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvRegistroTarifas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvRegistroDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbEstadoTarifa As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCostoTarifa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvRegistroTarifas As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents HistorialToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombreDestino As TextBox
    Friend WithEvents txtCodigoDestino As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnEliminarDestino As Button
    Friend WithEvents btnModificarDestino As Button
    Friend WithEvents btnAgregarDestino As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgvRegistroDestinos As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVerHistorialDestinos As Button
End Class
