Public Class Empleados
    Dim conexion As conexion = New conexion()
    Dim dt As New DataTable
    Dim edad, añosDeServicio As Integer
    Dim codigo, identidadEmpleado, primerNombre, segundoNombre, primerApellido, segundoApellido, estado, cargo As String

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
        Try
            codigo = txtCodigoEmpleado.Text
            identidadEmpleado = mktIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            segundoNombre = txtSegundoNombre.Text
            primerApellido = txtPrimerApellido.Text
            segundoApellido = txtSegundoApellido.Text
            edad = mktEdad.Text
            añosDeServicio = txtAñosLab.Text
            estado = cmbEstado.Text
            cargo = cmbCargo.Text

            If conexion.agregarEmpleado(codigo, identidadEmpleado, primerNombre, segundoNombre, primerApellido, segundoApellido, edad, añosDeServicio, estado, cargo) Then
                MessageBox.Show("Empleado agregado exitosamente!", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Se produjo un error al agregar el empleado!", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
    End Sub

    Private Sub llenarHistorial()
        conexion.LlenarTabla("Select codigo as 'Codigo', identidadEmpleado as 'Identidad',  primerNombre as 'Primer Nombre', segundoNombre as 'Segundo Nombre', primerApellido as 'Primer Apellido', segundoApellido as 'Segundo Apellido', edad as 'Edad', añosDeServicio as 'Años Laborales', estado as 'Estado', cargo as 'Cargo' from empleados", "empleados")
        dgvRegistroEmpleados.DataSource = conexion.ds.Tables("empleados")
    End Sub

    Private Sub dgvRegistroEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistroEmpleados.CellClick
        txtCodigoEmpleado.Text = dgvRegistroEmpleados.CurrentRow.Cells(0).Value.ToString
        mktIdentidad.Text = dgvRegistroEmpleados.CurrentRow.Cells(1).Value.ToString
        txtPrimerNombre.Text = dgvRegistroEmpleados.CurrentRow.Cells(2).Value.ToString
        txtSegundoNombre.Text = dgvRegistroEmpleados.CurrentRow.Cells(3).Value.ToString
        txtPrimerApellido.Text = dgvRegistroEmpleados.CurrentRow.Cells(4).Value.ToString
        txtSegundoApellido.Text = dgvRegistroEmpleados.CurrentRow.Cells(5).Value.ToString
        mktEdad.Text = dgvRegistroEmpleados.CurrentRow.Cells(6).Value.ToString
        txtAñosLab.Text = dgvRegistroEmpleados.CurrentRow.Cells(7).Value.ToString
        cmbEstado.Text = dgvRegistroEmpleados.CurrentRow.Cells(8).Value.ToString
        cmbCargo.Text = dgvRegistroEmpleados.CurrentRow.Cells(9).Value.ToString
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        btnAgregar.Enabled = False
        Try
            codigo = txtCodigoEmpleado.Text
            identidadEmpleado = mktIdentidad.Text
            primerNombre = txtPrimerNombre.Text
            segundoNombre = txtSegundoNombre.Text
            primerApellido = txtPrimerApellido.Text
            segundoApellido = txtSegundoApellido.Text
            edad = mktEdad.Text
            añosDeServicio = txtAñosLab.Text
            estado = cmbEstado.Text
            cargo = cmbCargo.Text

            If conexion.actualizarEmpleados(codigo, identidadEmpleado, primerNombre, segundoNombre, primerApellido, segundoApellido, edad, añosDeServicio, estado, cargo) Then
                MessageBox.Show("Empleado actualizado exitosamente!", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                conexion.conexion.Close()
            Else
                MessageBox.Show("Se produjo un error al actualizar el empleado!", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Function buscarEmpleado()
        Try

            dt = conexion.buscarEmpleado("codigo like '%" + txtCodigoEmpleado.Text + "%'")
            If dt.Rows.Count <> 0 Then
                dgvRegistroEmpleados.DataSource = dt
                conexion.conexion.Close()
            Else
                MessageBox.Show("No se encontro un Empleado con el codigo ingresaso", "Buscar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dgvRegistroEmpleados.DataSource = Nothing
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        buscarEmpleado()
        GroupBox3.Visible = True
    End Sub

    Private Function eliminatUsuario()
        Try
            If (conexion.eliminarEmpleado("empleados", "codigo=" + txtCodigoEmpleado.Text)) Then
                MessageBox.Show("Empleado eliminado exitosamente")
                llenarHistorial()
                conexion.conexion.Close()
            Else
                MessageBox.Show("Error al eliminar el Empleado")
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        buscarEmpleado()
        eliminatUsuario()
    End Sub

    Private Function Limpiar()
        txtCodigoEmpleado.Clear()
        mktIdentidad.Clear()
        txtPrimerNombre.Clear()
        txtSegundoNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        mktEdad.Clear()
        txtAñosLab.Clear()
        cmbCargo.ResetText()
        cmbEstado.ResetText()
    End Function
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Limpiar()
    End Sub
End Class