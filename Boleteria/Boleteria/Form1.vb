Imports System.ComponentModel

Public Class Form1
    Dim Conexion As New Conexion
    Dim NoAsientos, añosServicio, kilometraje, añoFabricacion As Integer
    Dim matricula, marca, modelo, color, estado, conductor, ayudante, ubicacion As String

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Conexion.eliminarBus(txtMatricula.Text) Then
            MsgBox("ELIMINADO", vbInformation)
            Llenar()
            limpiar()
            Conexion.conexion.Close()
        Else
            MsgBox("ERROR INESPERADO", vbCritical)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.conectar()
        Llenar()
        llenarcbAyudante()
        llenarcbConductor()
    End Sub

    Private Sub llenarcbAyudante()
        Conexion.llenarcbAyudante()
        cmbAyudante.DataSource = Conexion.datos2.Tables("empleados")
        cmbAyudante.DisplayMember = "codigo"
    End Sub

    Private Sub llenarcbConductor()
        Conexion.llenarcbConductor()
        cmbConductor.DataSource = Conexion.datos2.Tables("empleados")
        cmbConductor.DisplayMember = "codigo"
    End Sub

    Private Sub Llenar()
        Conexion.Llenar("Select id as 'ID', matricula as 'Matricula', marca as 'Marca', modelo as 'Modelo', NoAsientos as 'No. Asientos', añosServicio as 'Años de servicio', añoFabricacion as 'Año de Fabricación', kilometraje as 'Kilométraje', color as 'Color', estado as 'Estado', conductorAsignado as 'Conductor', ayudanteAsignado as 'Ayudante', ubicacionActual as 'Ubicación Actual' from autobuses", "autobuses")
        DataBus.DataSource = Conexion.ds.Tables("autobuses")
    End Sub

    Private Sub agregarAutobus()
        matricula = txtMatricula.Text
        marca = txtMarca.Text
        modelo = txtModelo.Text
        NoAsientos = txtAsiento.Text
        añosServicio = txtAño.Text
        añoFabricacion = txtFabricacion.Text
        kilometraje = txtKM.Text
        color = cmbColor.Text
        estado = cmbEstado.Text
        conductor = cmbConductor.Text
        ayudante = cmbAyudante.Text
        ubicacion = txtUbicacion.Text
        Try
            If Conexion.ingresarBus(matricula, marca, modelo, NoAsientos, añosServicio, añoFabricacion, kilometraje, color, estado, conductor, ayudante, ubicacion) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Llenar()
                Conexion.conexion.Close()
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If Me.ValidateChildren And txtMatricula.Text <> String.Empty And txtMarca.Text <> String.Empty And txtModelo.Text <> String.Empty And IsNumeric(txtAsiento.Text) = True And IsNumeric(txtAño.Text) = True And IsNumeric(txtFabricacion.Text) = True And IsNumeric(txtKM.Text) = True And cmbEstado.SelectedItem <> "" And cmbColor.SelectedItem <> "" And txtUbicacion.Text <> String.Empty Then
                agregarAutobus()
                limpiar()
            Else
                MsgBox("Datos incompletos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataBus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBus.CellClick
        Dim FilaActual As Integer
        FilaActual = DataBus.CurrentRow.Index
        txtMatricula.Text = DataBus.Rows(FilaActual).Cells(1).Value
        txtMarca.Text = DataBus.Rows(FilaActual).Cells(2).Value
        txtModelo.Text = DataBus.Rows(FilaActual).Cells(3).Value
        txtAsiento.Text = DataBus.Rows(FilaActual).Cells(4).Value
        txtAño.Text = DataBus.Rows(FilaActual).Cells(5).Value
        txtFabricacion.Text = DataBus.Rows(FilaActual).Cells(6).Value
        txtKM.Text = DataBus.Rows(FilaActual).Cells(7).Value
        cmbColor.Text = DataBus.Rows(FilaActual).Cells(8).Value
        cmbEstado.Text = DataBus.Rows(FilaActual).Cells(9).Value
        cmbConductor.Text = DataBus.Rows(FilaActual).Cells(10).Value
        cmbAyudante.Text = DataBus.Rows(FilaActual).Cells(11).Value
        txtUbicacion.Text = DataBus.Rows(FilaActual).Cells(12).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        matricula = txtMatricula.Text
        marca = txtMarca.Text
        modelo = txtModelo.Text
        NoAsientos = txtAsiento.Text
        añosServicio = txtAño.Text
        añoFabricacion = txtFabricacion.Text
        kilometraje = txtKM.Text
        color = cmbColor.Text
        estado = cmbEstado.Text
        conductor = cmbConductor.Text
        ayudante = cmbAyudante.Text
        ubicacion = txtUbicacion.Text
        Try
            If Conexion.modificarBus(matricula, marca, modelo, NoAsientos, añosServicio, añoFabricacion, kilometraje, color, estado, conductor, ayudante, ubicacion) Then
                MsgBox("Datos Actualizados", vbInformation)
                Llenar()
                Limpiar()
                Conexion.conexion.Close()
                Conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtMatricula_Validating(sender As Object, e As CancelEventArgs) Handles txtMatricula.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese la matricula del bus")
        End If
    End Sub

    Private Sub txtMarca_Validating(sender As Object, e As CancelEventArgs) Handles txtMarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider2.SetError(sender, "")
        Else
            Me.ErrorProvider2.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtModelo_Validating(sender As Object, e As CancelEventArgs) Handles txtModelo.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider3.SetError(sender, "")
        Else
            Me.ErrorProvider3.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As CancelEventArgs) Handles cmbEstado.Validating
        If (cmbEstado.SelectedItem <> "") Then
            Me.ErrorProvider4.SetError(sender, "")
        Else
            Me.ErrorProvider4.SetError(sender, "Seleccione el estado")
        End If
    End Sub

    Private Sub txtAsiento_Validating(sender As Object, e As CancelEventArgs) Handles txtAsiento.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider5.SetError(sender, "")
        Else
            Me.ErrorProvider5.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtAño_Validating(sender As Object, e As CancelEventArgs) Handles txtAño.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider6.SetError(sender, "")
        Else
            Me.ErrorProvider6.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtKM_Validating(sender As Object, e As CancelEventArgs) Handles txtKM.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider7.SetError(sender, "")
        Else
            Me.ErrorProvider7.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub cmbColor_Validating(sender As Object, e As CancelEventArgs) Handles cmbColor.Validating
        If (cmbColor.SelectedItem <> "") Then
            Me.ErrorProvider8.SetError(sender, "")
        Else
            Me.ErrorProvider8.SetError(sender, "Seleccione un Color")
        End If
    End Sub

    Private Sub txtFabricacion_Validating(sender As Object, e As CancelEventArgs) Handles txtFabricacion.Validating
        If DirectCast(sender, TextBox).Text.Length = 4 Then
            Me.ErrorProvider9.SetError(sender, "")
        Else
            Me.ErrorProvider9.SetError(sender, "Ingrese el año de fabricación")
        End If
    End Sub

    Private Sub txtUbicacion_Validating(sender As Object, e As CancelEventArgs) Handles txtUbicacion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider10.SetError(sender, "")
        Else
            Me.ErrorProvider10.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtAsiento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAsiento.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtAño_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAño.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtKM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKM.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtFabricacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFabricacion.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub limpiar()
        txtMatricula.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtAsiento.Clear()
        txtAño.Clear()
        txtFabricacion.Clear()
        txtKM.Clear()
        txtUbicacion.Clear()
        cmbEstado.SelectedItem = ""
        cmbColor.SelectedItem = ""
    End Sub
End Class
