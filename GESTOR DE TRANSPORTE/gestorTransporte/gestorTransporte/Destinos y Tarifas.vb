Public Class Destinos_y_Tarifas
    Dim conexion As New conexion
    Dim dt As New DataTable
    Dim costo, precioViaje As Integer
    Dim estado, codigoDestino, nombreDestino, estadoDestino As String

    Private Sub Destinos_y_Tarifas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        llenarHistorial()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        costo = txtCostoTarifa.Text
        estado = cmbEstadoTarifa.Text

        If conexion.agregarTarifa(costo, estado) Then
            MessageBox.Show("La tarifa se registro correctamente", "Registro Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se produjo un error al registrar la tarifa", "Registro Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        conexion.conexion.Close()
    End Sub

    Private Function llenarHistorial()
        conexion.LlenarTablaTarifas("Select costo as 'Costo de Tarifa', estado as 'Estado de Tarifa' from tarifas", "tarifas")
        dgvRegistroTarifas.DataSource = conexion.ds.Tables("tarifas")
    End Function

    Private Sub dgvRegistroTarifas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistroTarifas.CellClick
        txtCostoTarifa.Text = dgvRegistroTarifas.CurrentRow.Cells(0).Value.ToString
        cmbEstadoTarifa.Text = dgvRegistroTarifas.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        costo = txtCostoTarifa.Text
        estado = cmbEstadoTarifa.Text

        If conexion.modificarTarifa(costo, estado) Then
            MessageBox.Show("La tarifa se modifico correctamente", "Registro Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se produjo un error al modificarar la tarifa", "Registro Tarifas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        conexion.conexion.Close()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If conexion.eliminarTarifa(costo) Then
            estado = "Inactiva"
            MessageBox.Show("Tarifa eliminada exitosamente")
            llenarHistorial()
            conexion.conexion.Close()
        Else
            MessageBox.Show("Error al eliminar Tarifa")
            conexion.conexion.Close()
        End If

    End Sub



    '----------------Destinos----------------

    Private Sub btnVerHistorialDestinos_Click(sender As Object, e As EventArgs) Handles btnVerHistorialDestinos.Click
        llenarHistorialDestinos()
    End Sub

    Private Sub btnAgregarDestino_Click(sender As Object, e As EventArgs) Handles btnAgregarDestino.Click
        codigoDestino = txtCodigoDestino.Text
        nombreDestino = txtNombreDestino.Text
        precioViaje = txtPrecio.Text
        estadoDestino = cmbEstado.Text

        If conexion.agregarDestino(codigoDestino, nombreDestino, precioViaje, estadoDestino) Then
            MessageBox.Show("El Destino se agrego correctamente", "Registro Destinos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al registrar el destino", "Registro Destinos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Function llenarHistorialDestinos()
        conexion.LlenarTablaDestios("Select codigoDestino as 'Codigo del Destino', nombreDestino as 'Nombre del Destino', precioViaje as 'Id Tarifa', estado as 'Estado' from destinos", "destinos")
        dgvRegistroDestinos.DataSource = conexion.ds.Tables("destinos")
    End Function

    Private Sub dgvRegistroDestinos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistroDestinos.CellClick
        txtCodigoDestino.Text = dgvRegistroDestinos.CurrentRow.Cells(0).Value.ToString
        txtNombreDestino.Text = dgvRegistroDestinos.CurrentRow.Cells(1).Value.ToString
        txtPrecio.Text = dgvRegistroDestinos.CurrentRow.Cells(2).Value.ToString
        cmbEstado.Text = dgvRegistroDestinos.CurrentRow.Cells(3).Value.ToString
    End Sub

    Private Sub btnModificarDestino_Click(sender As Object, e As EventArgs) Handles btnModificarDestino.Click
        codigoDestino = txtCodigoDestino.Text
        nombreDestino = txtNombreDestino.Text
        precioViaje = txtPrecio.Text
        estadoDestino = cmbEstado.Text

        If conexion.modificarDestino(codigoDestino, nombreDestino, precioViaje, estadoDestino) Then
            MessageBox.Show("El Destino se modifico correctamente", "Registro Destinos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al modificar el destino", "Registro Destinos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminarDestino_Click(sender As Object, e As EventArgs) Handles btnEliminarDestino.Click
        codigoDestino = txtCodigoDestino.Text
        If conexion.eliminarDestino(codigoDestino) Then
            estado = "Inactivo"
            MessageBox.Show("Destino eliminado exitosamente")
            llenarHistorialDestinos()
            conexion.conexion.Close()
        Else
            MessageBox.Show("Error al eliminar el Destino")
            conexion.conexion.Close()
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        txtCostoTarifa.Clear()
        cmbEstadoTarifa.ResetText()
        txtCodigoDestino.Clear()
        txtNombreDestino.Clear()
        txtPrecio.Clear()
        cmbEstado.ResetText()
    End Sub

End Class