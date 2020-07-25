Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= MEJIA09\TEW_SQLEXPRESS;Initial Catalog=terminalAutobuses; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comand As SqlCommand
    Public dv As New DataView
    Public adap As SqlDataAdapter
    Public datos2 As DataSet
    Public cmd As New SqlCommand

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conexión realizada exitosamente")
        Catch ex As Exception
            MessageBox.Show("Error conexion de base de datos")
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub Llenar(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dv.Table = ds.Tables(0)
    End Sub
    Public Function ingresarBus(matricula As String, marca As String, modelo As String, NoAsientos As Integer, añosServicio As Integer, kilometraje As Integer, color As String, estado As String, conductor As String, ayudante As String)
        Try
            conexion.Open()
            comand = New SqlCommand("agregarAutobus", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@matricula", matricula)
            comand.Parameters.AddWithValue("@marca", marca)
            comand.Parameters.AddWithValue("@modelo", modelo)
            comand.Parameters.AddWithValue("@NoAsientos", NoAsientos)
            comand.Parameters.AddWithValue("@añosServicio", añosServicio)
            comand.Parameters.AddWithValue("@kilometraje", kilometraje)
            comand.Parameters.AddWithValue("@color", color)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@conductorAsignado", conductor)
            comand.Parameters.AddWithValue("@ayudanteAsignado", ayudante)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function modificarBus(matricula As String, marca As String, modelo As String, NoAsientos As Integer, añosServicio As Integer, kilometraje As Integer, color As String, estado As String, conductor As String, ayudante As String)
        Try
            conexion.Open()
            comand = New SqlCommand("actualizarAutobus", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@matricula", matricula)
            comand.Parameters.AddWithValue("@marca", marca)
            comand.Parameters.AddWithValue("@modelo", modelo)
            comand.Parameters.AddWithValue("@NoAsientos", NoAsientos)
            comand.Parameters.AddWithValue("@añosServicio", añosServicio)
            comand.Parameters.AddWithValue("@kilometraje", kilometraje)
            comand.Parameters.AddWithValue("@color", color)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@conductorAsignado", conductor)
            comand.Parameters.AddWithValue("@ayudanteAsignado", ayudante)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function eliminarBus(ByVal matricula As String)
        Dim sqlComm As SqlCommand = conexion.CreateCommand()
        sqlComm.CommandText = "eliminarRegistro"
        sqlComm.CommandType = CommandType.StoredProcedure
        sqlComm.Parameters.AddWithValue("@matricula", matricula)
        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then
            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    '---------------------------------Empleados----------------------------------
    Public Function LlenarTabla(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dv.Table = ds.Tables(0)
    End Function

    Public Function agregarEmpleado(codigo As String, identidadEmpleado As String, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, edad As Integer, añosDeServicio As Integer, estado As String, cargo As String)
        Try
            conexion.Open()
            comand = New SqlCommand("agregarEmpleados", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@identidadEmpleado", identidadEmpleado)
            comand.Parameters.AddWithValue("@primerNombre", primerNombre)
            comand.Parameters.AddWithValue("@segundoNombre", segundoNombre)
            comand.Parameters.AddWithValue("@primerApellido", primerApellido)
            comand.Parameters.AddWithValue("@segundoApellido", segundoApellido)
            comand.Parameters.AddWithValue("@edad", edad)
            comand.Parameters.AddWithValue("@añosDEServicio", añosDeServicio)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@cargo", cargo)

            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Public Function actualizarEmpleados(codigo As String, identidadEmpleado As String, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, edad As Integer, añosDeServicio As Integer, estado As String, cargo As String)

        Try
            conexion.Open()
            comand = New SqlCommand("actualizarEmpleados", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@codigo", codigo)
            comand.Parameters.AddWithValue("@identidadEmpleado", identidadEmpleado)
            comand.Parameters.AddWithValue("@primerNombre", primerNombre)
            comand.Parameters.AddWithValue("@segundoNombre", segundoNombre)
            comand.Parameters.AddWithValue("@primerApellido", primerApellido)
            comand.Parameters.AddWithValue("@segundoApellido", segundoApellido)
            comand.Parameters.AddWithValue("@edad", edad)
            comand.Parameters.AddWithValue("@añosDEServicio", añosDeServicio)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@cargo", cargo)

            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function eliminarEmpleado(ByVal table, ByVal condicion)
        conexion.Open()
        Dim eliminarE As String = "delete from " + table + " where " + condicion
        comand = New SqlCommand(eliminarE, conexion)
        Dim i As Integer = comand.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function buscarEmpleado(ByVal condicion) As DataTable

        Try
            conexion.Open()
            Dim search As String = "select * from empleados " + " where " + condicion

            Dim comand As New SqlCommand(search, conexion)
            If comand.ExecuteNonQuery Then
                Dim dataT As New DataTable
                Dim dataA As New SqlDataAdapter(comand)
                dataA.Fill(dataT)
                Return dataT
            Else
                Return Nothing
            End If
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
