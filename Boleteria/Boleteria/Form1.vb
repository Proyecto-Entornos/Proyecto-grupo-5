Public Class Form1
    Dim Conexion As New Conexion
    Dim NoAsientos, añosServicio, kilometraje As Integer
    Dim matricula, marca, modelo, color, estado, conductor, ayudante As String

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If Conexion.eliminarBus(txtMatricula.Text) Then
            MsgBox("ELIMINADO", vbInformation)
            Conexion.Llenar("Select id as 'ID', matricula as 'Matricula', marca as 'Marca', modelo as 'Modelo', NoAsientos as 'No. Asientos', añosServicio as 'Años de servicio', kilometraje as 'Kilométraje', color as 'Color', estado as 'Estado', conductorAsignado as 'Conductor', ayudanteAsignado as 'Ayudante' from autobuses where matricula = '" & txtMatricula.Text & "'", "autobuses")
            DataBus.DataSource = Conexion.ds.Tables("autobuses")
            Limpiar()
        Else
            MsgBox("ERROR INESPERADO", vbCritical)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion.conectar()
        Llenar()
    End Sub
    Private Sub Llenar()
        Conexion.Llenar("Select id as 'ID', matricula as 'Matricula', marca as 'Marca', modelo as 'Modelo', NoAsientos as 'No. Asientos', añosServicio as 'Años de servicio', kilometraje as 'Kilométraje', color as 'Color', estado as 'Estado', conductorAsignado as 'Conductor', ayudanteAsignado as 'Ayudante' from autobuses", "autobuses")
        DataBus.DataSource = Conexion.ds.Tables("autobuses")
    End Sub
    Private Sub agregarAutobus()
        matricula = txtMatricula.Text
        marca = txtMarca.Text
        modelo = txtModelo.Text
        NoAsientos = txtAsiento.Text
        añosServicio = txtAño.Text
        kilometraje = txtKM.Text
        Color = cmbColor.Text
        estado = cmbEstado.Text
        conductor = cmbConductor.Text
        ayudante = cmbAyudante.Text
        Try
            If Conexion.ingresarBus(matricula, marca, modelo, NoAsientos, añosServicio, kilometraje, Color, estado, conductor, ayudante) Then
                MessageBox.Show("Guardado", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregarAutobus()
    End Sub

    Private Sub DataBus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataBus.CellClick
        Dim FilaActual As Integer
        FilaActual = DataBus.CurrentRow.Index
        txtMatricula.Text = DataBus.Rows(FilaActual).Cells(1).Value
        txtMarca.Text = DataBus.Rows(FilaActual).Cells(2).Value
        txtModelo.Text = DataBus.Rows(FilaActual).Cells(3).Value
        txtAsiento.Text = DataBus.Rows(FilaActual).Cells(4).Value
        txtAño.Text = DataBus.Rows(FilaActual).Cells(5).Value
        txtKM.Text = DataBus.Rows(FilaActual).Cells(6).Value
        cmbColor.Text = DataBus.Rows(FilaActual).Cells(7).Value
        cmbEstado.Text = DataBus.Rows(FilaActual).Cells(8).Value
        cmbConductor.Text = DataBus.Rows(FilaActual).Cells(9).Value
        cmbAyudante.Text = DataBus.Rows(FilaActual).Cells(10).Value
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        matricula = txtMatricula.Text
        marca = txtMarca.Text
        modelo = txtModelo.Text
        NoAsientos = txtAsiento.Text
        añosServicio = txtAño.Text
        kilometraje = txtKM.Text
        color = cmbColor.Text
        estado = cmbEstado.Text
        conductor = cmbConductor.Text
        ayudante = cmbAyudante.Text
        Try
            If Conexion.modificarBus(matricula, marca, modelo, NoAsientos, añosServicio, kilometraje, color, estado, conductor, ayudante) Then
                MsgBox("Datos Actualizados", vbInformation)
                Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Limpiar()
        txtMatricula.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtAsiento.Clear()
        txtAño.Clear()
        txtKM.Clear()
        cmbColor.SelectedIndex = 0
        cmbEstado.SelectedIndex = 0
        cmbConductor.SelectedIndex = 0
        cmbAyudante.SelectedIndex = 0
    End Sub
End Class
