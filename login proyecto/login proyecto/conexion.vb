Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source= DESKTOP-IKI4BG5\MSSQLSERVER01;Initial Catalog=terminalAutobuses; Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public comand As SqlCommand
    Public comm As SqlCommand
    Public dv As New DataView
    Public adap As SqlDataAdapter
    Public datos2 As DataSet
    Public cmd As New SqlCommand
    Function comparar(ByVal ID, ByVal Contraseña)
        Dim READER As SqlDataReader
        Dim cont As Int32 = 0
        Dim cont2 As Int32 = 0
        conexion.Open()
        comm = New SqlCommand("select identidad from empleados where identidad ='" + ID + "'", conexion)
        READER = comm.ExecuteReader()
        While READER.Read
            cont = cont + 1
        End While
        READER.Close()
        If (cont = 1) Then
            comando = New SqlCommand("Select codigo from empleados where codigo ='" + Contraseña + "'", conexion)
            Dim i As SqlDataReader = comando.ExecuteReader
            While i.Read
                cont2 = cont2 + 1
            End While
            i.Close()
            conexion.Close()
            If (cont2 = 1) Then
                Return True
            End If
        Else
            conexion.Close()
            Return False
        End If
    End Function
End Class
