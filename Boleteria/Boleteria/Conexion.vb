﻿Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-IKI4BG5\MSSQLSERVER01;Initial Catalog=terminalAutobuses; Integrated Security=True")
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
            MessageBox.Show("Conexión exitosa")
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
    Public Function ingresarBus(matricula As String, marca As String, modelo As String, NoAsientos As Integer, añosServicio As Integer, añoFabricacion As Integer, kilometraje As Integer, color As String, estado As String, conductor As String, ayudante As String, ubicacion As String)
        Try
            conexion.Open()
            comand = New SqlCommand("agregarAutobus", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@matricula", matricula)
            comand.Parameters.AddWithValue("@marca", marca)
            comand.Parameters.AddWithValue("@modelo", modelo)
            comand.Parameters.AddWithValue("@NoAsientos", NoAsientos)
            comand.Parameters.AddWithValue("@añosServicio", añosServicio)
            comand.Parameters.AddWithValue("@añoFabricacion", añoFabricacion)
            comand.Parameters.AddWithValue("@kilometraje", kilometraje)
            comand.Parameters.AddWithValue("@color", color)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@conductorAsignado", conductor)
            comand.Parameters.AddWithValue("@ayudanteAsignado", ayudante)
            comand.Parameters.AddWithValue("@ubicacionActual", ubicacion)
            If comand.ExecuteNonQuery Then
                Return True
                conexion.Close()
            Else
                Return False
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function modificarBus(matricula As String, marca As String, modelo As String, NoAsientos As Integer, añosServicio As Integer, añoFabricacion As Integer, kilometraje As Integer, color As String, estado As String, conductor As String, ayudante As String, ubicacion As String)
        Try
            conexion.Open()
            comand = New SqlCommand("actualizarAutobus", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@matricula", matricula)
            comand.Parameters.AddWithValue("@marca", marca)
            comand.Parameters.AddWithValue("@modelo", modelo)
            comand.Parameters.AddWithValue("@NoAsientos", NoAsientos)
            comand.Parameters.AddWithValue("@añosServicio", añosServicio)
            comand.Parameters.AddWithValue("@añoFabricacion", añoFabricacion)
            comand.Parameters.AddWithValue("@kilometraje", kilometraje)
            comand.Parameters.AddWithValue("@color", color)
            comand.Parameters.AddWithValue("@estado", estado)
            comand.Parameters.AddWithValue("@conductorAsignado", conductor)
            comand.Parameters.AddWithValue("@ayudanteAsignado", ayudante)
            comand.Parameters.AddWithValue("@ubicacionActual", ubicacion)
            If comand.ExecuteNonQuery Then
                Return True
                conexion.Close()
            Else
                Return False
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Function eliminarBus(ByVal matricula As String)
        Dim sqlComm As SqlCommand = conexion.CreateCommand()
        sqlComm.CommandText = "eliminarAutobus"
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
    Function llenarcbAyudante()
        conexion.Open()
        adap = New SqlDataAdapter("SELECT * FROM empleados where cargo = 'Ayudante'", conexion)
        datos2 = New DataSet
        datos2.Tables.Add("empleados")
        adap.Fill(datos2.Tables("empleados"))
        conexion.Close()
    End Function
    Function llenarcbConductor()
        conexion.Open()
        adap = New SqlDataAdapter("SELECT * FROM empleados where cargo = 'Conductor'", conexion)
        datos2 = New DataSet
        datos2.Tables.Add("empleados")
        adap.Fill(datos2.Tables("empleados"))
        conexion.Close()
    End Function

End Class
