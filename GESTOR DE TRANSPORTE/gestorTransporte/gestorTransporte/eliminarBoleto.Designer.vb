<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminarBoleto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvBoleto = New System.Windows.Forms.DataGridView()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbBoletos = New System.Windows.Forms.ComboBox()
        Me.mskNoAsiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOtroDestino = New System.Windows.Forms.CheckBox()
        Me.txtOtroDestino = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPrecioBoleto = New System.Windows.Forms.TextBox()
        Me.cmbDestino = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.loadButton = New System.Windows.Forms.Button()
        CType(Me.dgvBoleto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Fugaz One", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(722, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SELECCIONE EL CODIGO DE BOLETO"
        '
        'dgvBoleto
        '
        Me.dgvBoleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBoleto.Location = New System.Drawing.Point(61, 67)
        Me.dgvBoleto.Name = "dgvBoleto"
        Me.dgvBoleto.Size = New System.Drawing.Size(896, 177)
        Me.dgvBoleto.TabIndex = 2
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Salmon
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Fugaz One", 15.0!)
        Me.btnEliminar.Location = New System.Drawing.Point(716, 484)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(264, 51)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "ELIMINAR BOLETO"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Tomato
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Fugaz One", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 38)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmbBoletos
        '
        Me.cmbBoletos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbBoletos.Font = New System.Drawing.Font("Fugaz One", 15.0!)
        Me.cmbBoletos.FormattingEnabled = True
        Me.cmbBoletos.Location = New System.Drawing.Point(724, 293)
        Me.cmbBoletos.Name = "cmbBoletos"
        Me.cmbBoletos.Size = New System.Drawing.Size(242, 37)
        Me.cmbBoletos.TabIndex = 5
        '
        'mskNoAsiento
        '
        Me.mskNoAsiento.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.mskNoAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskNoAsiento.Font = New System.Drawing.Font("Fugaz One", 18.0!)
        Me.mskNoAsiento.Location = New System.Drawing.Point(174, 47)
        Me.mskNoAsiento.Margin = New System.Windows.Forms.Padding(1)
        Me.mskNoAsiento.Mask = "00"
        Me.mskNoAsiento.Name = "mskNoAsiento"
        Me.mskNoAsiento.Size = New System.Drawing.Size(69, 36)
        Me.mskNoAsiento.TabIndex = 18
        Me.mskNoAsiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NO. ASIENTO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GroupBox1.Controls.Add(Me.chkOtroDestino)
        Me.GroupBox1.Controls.Add(Me.txtOtroDestino)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtPrecioBoleto)
        Me.GroupBox1.Controls.Add(Me.cmbDestino)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.mskNoAsiento)
        Me.GroupBox1.Font = New System.Drawing.Font("Fugaz One", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 283)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 252)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "MODIFICAR"
        '
        'chkOtroDestino
        '
        Me.chkOtroDestino.AutoSize = True
        Me.chkOtroDestino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkOtroDestino.Location = New System.Drawing.Point(311, 89)
        Me.chkOtroDestino.Name = "chkOtroDestino"
        Me.chkOtroDestino.Size = New System.Drawing.Size(64, 25)
        Me.chkOtroDestino.TabIndex = 36
        Me.chkOtroDestino.Text = "Otro "
        Me.chkOtroDestino.UseVisualStyleBackColor = True
        '
        'txtOtroDestino
        '
        Me.txtOtroDestino.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOtroDestino.Location = New System.Drawing.Point(379, 81)
        Me.txtOtroDestino.Margin = New System.Windows.Forms.Padding(1)
        Me.txtOtroDestino.Multiline = True
        Me.txtOtroDestino.Name = "txtOtroDestino"
        Me.txtOtroDestino.Size = New System.Drawing.Size(179, 37)
        Me.txtOtroDestino.TabIndex = 35
        Me.txtOtroDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Fugaz One", 18.0!)
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(168, 186)
        Me.Label20.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 35)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "PRECIO "
        '
        'txtPrecioBoleto
        '
        Me.txtPrecioBoleto.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPrecioBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioBoleto.Font = New System.Drawing.Font("Fugaz One", 20.0!)
        Me.txtPrecioBoleto.Location = New System.Drawing.Point(298, 181)
        Me.txtPrecioBoleto.Margin = New System.Windows.Forms.Padding(1)
        Me.txtPrecioBoleto.Name = "txtPrecioBoleto"
        Me.txtPrecioBoleto.ReadOnly = True
        Me.txtPrecioBoleto.Size = New System.Drawing.Size(129, 40)
        Me.txtPrecioBoleto.TabIndex = 33
        Me.txtPrecioBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbDestino
        '
        Me.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDestino.FormattingEnabled = True
        Me.cmbDestino.Location = New System.Drawing.Point(379, 41)
        Me.cmbDestino.Margin = New System.Windows.Forms.Padding(1)
        Me.cmbDestino.Name = "cmbDestino"
        Me.cmbDestino.Size = New System.Drawing.Size(179, 27)
        Me.cmbDestino.TabIndex = 32
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(294, 47)
        Me.Label19.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 21)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "DESTINO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Fugaz One", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(359, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(297, 21)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "BOLETOS VENDIDOS EN LA SALIDA ACTUAL"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Wheat
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Fugaz One", 15.0!)
        Me.btnModificar.Location = New System.Drawing.Point(716, 390)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(264, 70)
        Me.btnModificar.TabIndex = 22
        Me.btnModificar.Text = "MODIFICAR "
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'loadButton
        '
        Me.loadButton.BackColor = System.Drawing.Color.Salmon
        Me.loadButton.FlatAppearance.BorderSize = 0
        Me.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loadButton.Font = New System.Drawing.Font("Fugaz One", 10.0!)
        Me.loadButton.Location = New System.Drawing.Point(716, 343)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(253, 24)
        Me.loadButton.TabIndex = 23
        Me.loadButton.Text = "CARGAR"
        Me.loadButton.UseVisualStyleBackColor = False
        '
        'eliminarBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1035, 582)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbBoletos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.dgvBoleto)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "eliminarBoleto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eliminarBoleto"
        CType(Me.dgvBoleto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvBoleto As DataGridView
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbBoletos As ComboBox
    Friend WithEvents mskNoAsiento As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOtroDestino As CheckBox
    Friend WithEvents txtOtroDestino As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtPrecioBoleto As TextBox
    Friend WithEvents cmbDestino As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents loadButton As Button
End Class
