Public Class Clientes
    Dim conexion As New conexion
    Dim dt As New DataTable
    Dim identidadCliente, primerNombre, segundoNombre, primerApellido, segundoApellido, edad, depto, estado As String


    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub HistorialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HistorialToolStripMenuItem.Click
        GroupBox3.Visible = True
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
        identidadCliente = mktIdentidadCliente.Text
        primerNombre = txtPrimerNombre.Text
        segundoNombre = txtSegundoNombre.Text
        primerApellido = txtPrimerApellido.Text
        segundoApellido = txtSegundoApellido.Text
        edad = mktEdad.Text
        depto = cmbDeptos.Text
        estado = cmbEstado.Text

        If conexion.agregarCliente(identidadCliente, primerNombre, segundoNombre, primerApellido, segundoApellido, edad, depto, estado) Then
            MessageBox.Show("Cliente agregado exitosamente!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Se produjo un error al agregar el cliente!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        conexion.conexion.Close()
    End Sub

    Private Sub llenarHistorial()
        conexion.LlenarTablaClientes("Select identidadCliente as 'Identidad', primerNombre as 'Primer Nombre', segundoNombre as 'Segundo Nombre', primerApellido as 'Primer Apellido', segundoApellido as 'Segundo Apellido', edadCliente as 'Edad', departamento as 'Departamento', estado as 'Estado' from clientes", "clientes")
        dgvRegistroClientes.DataSource = conexion.ds.Tables("clientes")
    End Sub

    Private Sub dgvRegistroClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistroClientes.CellClick
        mktIdentidadCliente.Text = dgvRegistroClientes.CurrentRow.Cells(0).Value.ToString
        txtPrimerNombre.Text = dgvRegistroClientes.CurrentRow.Cells(1).Value.ToString
        txtSegundoNombre.Text = dgvRegistroClientes.CurrentRow.Cells(2).Value.ToString
        txtPrimerApellido.Text = dgvRegistroClientes.CurrentRow.Cells(3).Value.ToString
        txtSegundoApellido.Text = dgvRegistroClientes.CurrentRow.Cells(4).Value.ToString
        mktEdad.Text = dgvRegistroClientes.CurrentRow.Cells(5).Value.ToString
        cmbDeptos.Text = dgvRegistroClientes.CurrentRow.Cells(6).Value.ToString
        cmbEstado.Text = dgvRegistroClientes.CurrentRow.Cells(7).Value.ToString
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            identidadCliente = mktIdentidadCliente.Text
            primerNombre = txtPrimerNombre.Text
            segundoNombre = txtSegundoNombre.Text
            primerApellido = txtPrimerApellido.Text
            segundoApellido = txtSegundoApellido.Text
            edad = mktEdad.Text
            depto = cmbDeptos.Text
            estado = cmbEstado.Text

            If conexion.actualizarCliente(identidadCliente, primerNombre, segundoNombre, primerApellido, segundoApellido, edad, depto, estado) Then
                MessageBox.Show("Cliente actualizado exitosamente!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Se produjo un error al actualizar el cliente!", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            conexion.conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function buscarCliente()

        dt = conexion.buscarCliente("identidadCliente like '%" + mktIdentidadCliente.Text + "%'")
        If dt.Rows.Count <> 0 Then
            dgvRegistroClientes.DataSource = dt
            conexion.conexion.Close()
        Else
            MessageBox.Show("No se encontro un Cliente con la identidad ingresada", "Buscar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvRegistroClientes.DataSource = Nothing
            conexion.conexion.Close()
        End If
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarCliente()
        GroupBox3.Visible = True
    End Sub

    Private Function eliminarCliente()
        If conexion.eliminarCliente("clientes", "identidadCliente=" + mktIdentidadCliente.Text) Then
            MessageBox.Show("Cliente eliminado exitosamente")
            llenarHistorial()
            conexion.conexion.Close()
        Else
            MessageBox.Show("Error al eliminar el Cliente")
            conexion.conexion.Close()
        End If
    End Function
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        buscarCliente()
        eliminarCliente()
        GroupBox3.Visible = True
    End Sub

    Private Function limpiarDatos()
        mktIdentidadCliente.Clear()
        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        mktEdad.Clear()
        cmbDeptos.ResetText()
        cmbEstado.ResetText()
    End Function
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        limpiarDatos()
    End Sub
End Class