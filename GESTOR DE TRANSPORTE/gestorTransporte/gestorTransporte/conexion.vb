Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class conexion

    Public conexion As New SqlConnection("Data Source=MEJIA09\TEW_SQLEXPRESS;Initial Catalog=terminalAutobuses;Integrated Security=True")
    Private cmb As New SqlCommandBuilder
    Public cmd As New SqlCommand
    Public ds As New DataSet
    Public da As New SqlDataAdapter
    Public comando As SqlCommand
    Public comand As New SqlCommand
    Public dv As New DataView

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

    Function ventaRegistradaBoleto(ByVal tipoBoleto As Integer, ByVal fecha As Date, ByVal codigoBoleto As String, ByVal identidadCliente As String, ByVal matriculaAutobus As String, ByVal numeroAsiento As Integer, ByVal terminalSalida As String, ByVal destino As Integer, ByVal otroPrecio As Integer, ByVal otroDestino As String, ByVal Nsalida As Integer)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "agregarBoleto"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@tipoBoleto", tipoBoleto)

        sqlComm.Parameters.AddWithValue("@fecha", fecha)
        sqlComm.Parameters.AddWithValue("@codigoBoleto", codigoBoleto)
        sqlComm.Parameters.AddWithValue("@identidadCliente", identidadCliente)
        sqlComm.Parameters.AddWithValue("@matriculaAutobus", matriculaAutobus)
        sqlComm.Parameters.AddWithValue("@numeroAsiento", numeroAsiento)
        sqlComm.Parameters.AddWithValue("@terminalSalida", terminalSalida)
        sqlComm.Parameters.AddWithValue("@destino", destino)
        sqlComm.Parameters.AddWithValue("@otroPrecio", otroPrecio)
        sqlComm.Parameters.AddWithValue("@otroDestino", otroDestino)
        sqlComm.Parameters.AddWithValue("@Nsalida", Nsalida)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function



    Function modificarBoletos(ByVal tipoBolNuevo As Integer, ByVal codigoBoleto As String, ByVal numeroAsiento As Integer, ByVal destino As Integer, ByVal otroPrecio As Integer, ByVal otroDestino As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "modificarBoleto"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@tipoBoletoNuevo", tipoBolNuevo)

        sqlComm.Parameters.AddWithValue("@codigoBoleto", codigoBoleto)
        sqlComm.Parameters.AddWithValue("@numeroAsiento", numeroAsiento)
        sqlComm.Parameters.AddWithValue("@destino", destino)
        sqlComm.Parameters.AddWithValue("@otroPrecio", otroPrecio)
        sqlComm.Parameters.AddWithValue("@otroDestino", otroDestino)


        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function actualizarUbicacionBus(ByVal matricula As String, ByVal ubicacionActual As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "actualizarUbicacionAutobus"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@matricula", matricula)
        sqlComm.Parameters.AddWithValue("@ubicacionActual", ubicacionActual)


        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    'Function comprobarAsientoOcupado(ByVal NAsiento As Integer)

    '    Dim cmd As SqlCommand = conexion.CreateCommand()

    '    cmd.CommandText = ("SELECT id from empleados WHERE identidadEmpleado = '" & identidadUsuario & "'")

    '    conexion.Open()

    '    Dim numReg As Integer = CInt(cmd.ExecuteScalar())

    '    If numReg > 0 Then
    '        conexion.Close()
    '        Return 1

    '    Else
    '        conexion.Close()
    '        Return 2

    '    End If
    'End Function

    Function retornarUltimoBoleto()
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT MAX(id) FROM boleteria")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarPrimerAutobus(ByVal numeroHora As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()


            Select Case numeroHora
                Case 1
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.primeraSalida = autobuses.id")
                Case 2
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.segundaSalida = autobuses.id")
                Case 3
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.terceraSalida = autobuses.id")
                Case 4
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.cuartaSalida = autobuses.id")
                Case 5
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.quintaSalida = autobuses.id")
                Case 6
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.sextaSalida = autobuses.id")
                Case 7
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.septimaSalida = autobuses.id")
                Case 8
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.octavaSalida = autobuses.id")
                Case 9
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.novenaSalida = autobuses.id")
                Case 10
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.decimaSalida = autobuses.id")
                Case 11
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.onceSalida = autobuses.id")
                Case 12
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.doceSalida = autobuses.id")
                Case 13
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.treceSalida = autobuses.id")
                Case 14
                    cmd.CommandText = ("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON salidaDiaria.catorceSalida = autobuses.id")

            End Select

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarDatosAutobus(ByVal codigoAutobus As String, ByVal contador As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()


            Select Case contador

                Case 0
                    cmd.CommandText = ("SELECT marca FROM autobuses WHERE autobuses.matricula = '" & codigoAutobus & "'")
                Case 1
                    cmd.CommandText = ("SELECT NoAsientos FROM autobuses WHERE autobuses.matricula = '" & codigoAutobus & "'")
                Case 2
                    cmd.CommandText = ("SELECT CONCAT(primerNombre, ' ', primerApellido)  FROM autobuses INNER JOIN empleados ON autobuses.matricula = '" & codigoAutobus & "' and autobuses.conductorAsignado = empleados.codigo")
                Case 3
                    cmd.CommandText = ("SELECT CONCAT(primerNombre, ' ', primerApellido)  FROM autobuses INNER JOIN empleados ON autobuses.matricula = '" & codigoAutobus & "' and autobuses.ayudanteAsignado = empleados.codigo")

            End Select

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function cargarDestinos(ByVal contador As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()


            Select Case contador

                Case 1
                    cmd.CommandText = ("SELECT nombreDestino FROM destinos WHERE destinos.id = " & contador)
                Case 2
                    cmd.CommandText = ("SELECT nombreDestino FROM destinos WHERE destinos.id = " & contador)

            End Select

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarTarifa(ByVal idDestino As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()


            cmd.CommandText = ("SELECT costo FROM destinos INNER JOIN tarifas ON destinos.id = " & idDestino & " and destinos.precioViaje = tarifas.id")


            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarNombreMembresia(ByVal identidadCliente As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()


            cmd.CommandText = ("SELECT CONCAT(primerNombre, ' ', primerApellido)  FROM clientes WHERE identidadCliente = '" & identidadCliente & "'")


            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarSalidasDiarias(ByVal numeroSalida As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()

            Select Case numeroSalida
                Case 1
                    cmd.CommandText = ("SELECT primeraSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 2
                    cmd.CommandText = ("SELECT segundaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 3
                    cmd.CommandText = ("SELECT terceraSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 4
                    cmd.CommandText = ("SELECT cuartaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 5
                    cmd.CommandText = ("SELECT quintaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 6
                    cmd.CommandText = ("SELECT sextaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 7
                    cmd.CommandText = ("SELECT septimaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 8
                    cmd.CommandText = ("SELECT octavaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 9
                    cmd.CommandText = ("SELECT novenaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 10
                    cmd.CommandText = ("SELECT decimaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 11
                    cmd.CommandText = ("SELECT onceSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 12
                    cmd.CommandText = ("SELECT doceSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 13
                    cmd.CommandText = ("SELECT treceSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 14
                    cmd.CommandText = ("SELECT cuartaSalida  FROM salidaDiaria WHERE id = " & idDiaSalida & "")


            End Select



            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function


    Function retornarHoras(ByVal numeroHora As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()

            Select Case numeroHora
                Case 1
                    cmd.CommandText = ("SELECT primeraHora FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 2
                    cmd.CommandText = ("SELECT segundoHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 3
                    cmd.CommandText = ("SELECT terceraHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 4
                    cmd.CommandText = ("SELECT cuartaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 5
                    cmd.CommandText = ("SELECT quintaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 6
                    cmd.CommandText = ("SELECT sextaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 7
                    cmd.CommandText = ("SELECT septimaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 8
                    cmd.CommandText = ("SELECT octavaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 9
                    cmd.CommandText = ("SELECT novenaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 10
                    cmd.CommandText = ("SELECT decimaHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 11
                    cmd.CommandText = ("SELECT onceHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 12
                    cmd.CommandText = ("SELECT doceHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 13
                    cmd.CommandText = ("SELECT treceHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")
                Case 14
                    cmd.CommandText = ("SELECT catorceHora  FROM salidaDiaria WHERE id = " & idDiaSalida & "")


            End Select



            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function


    Function eliminarBoleto(ByVal codigoBoleto As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "eliminarBoleto"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@codigoBoleto", codigoBoleto)


        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function


    Function llenarBoletos()
        ds.Tables.Clear()
        conexion.Open()
        da = New SqlDataAdapter("SELECT codigoBoleto FROM boleteria WHERE fecha = '" & moduloTimers.fechaActual & "' AND noSalida = " & moduloTimers.temporalSalidaActual & "", conexion)
        ds = New DataSet

        ds.Tables.Add("boleteria")
        da.Fill(ds, "boleteria")
        conexion.Close()

    End Function

    Function retornarDatosBoleto(ByVal codigoBoleto As String, ByVal contador As Integer)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()


            Select Case contador

                Case 0
                    cmd.CommandText = ("SELECT numeroAsiento FROM boleteria WHERE codigoBoleto = '" & codigoBoleto & "'")
                Case 1
                    cmd.CommandText = ("SELECT nombreDestino FROM boleteria INNER JOIN destinos ON boleteria.destino = destinos.id and codigoBoleto = '" & codigoBoleto & "'")
                Case 2
                    cmd.CommandText = ("SELECT costo FROM boleteria INNER JOIN destinos ON boleteria.destino = destinos.id INNER JOIN tarifas ON destinos.precioViaje = tarifas.id WHERE codigoBoleto = '" & codigoBoleto & "'")
                Case 4
                    cmd.CommandText = ("SELECT otroPrecio FROM boleteria WHERE codigoBoleto = '" & codigoBoleto & "'")
                Case 3
                    cmd.CommandText = ("SELECT otroDestino FROM boleteria WHERE codigoBoleto = '" & codigoBoleto & "'")
            End Select

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarTipoBoleto(ByVal codigoBoleto As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT tipoBoleto FROM boleteria WHERE codigoBoleto = '" & codigoBoleto & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarAsientoBoleto(ByVal codigoBoleto As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT numeroAsiento FROM boleteria WHERE codigoBoleto = '" & codigoBoleto & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function llenarBusesDisponibles()
        ds.Tables.Clear()
        conexion.Open()
        da = New SqlDataAdapter("SELECT matricula FROM salidaDiaria INNER JOIN autobuses ON (primeraSalida <> matricula and segundaSalida <> matricula and terceraSalida <> matricula and cuartaSalida <> matricula and quintaSalida <> matricula and sextaSalida <> matricula and septimaSalida <> matricula and octavaSalida <> matricula and novenaSalida <> matricula and decimaSalida <> matricula and onceSalida <> matricula and doceSalida <> matricula and treceSalida <> matricula and catorceSalida <> matricula) and (ubicacionActual = 'LA ESPERANZA') and salidaDiaria.id = " & idDiaSalida & "", conexion)
        ds = New DataSet

        ds.Tables.Add("autobuses")
        da.Fill(ds, "autobuses")
        conexion.Close()

    End Function

    Function modificarSalidaDiaria(ByVal id As Integer, ByVal primeraSalida As String, ByVal segundaSalida As String, ByVal terceraSalida As String, ByVal cuartaSalida As String, ByVal quintaSalida As String, ByVal sextaSalida As String, ByVal septimaSalida As String,
                                   ByVal octavaSalida As String, ByVal novenaSalida As String, ByVal decimaSalida As String, ByVal onceSalida As String, ByVal doceSalida As String, ByVal treceSalida As String, ByVal catorceSalida As String)


        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "modificarOrdenSalida"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@id", id)

        sqlComm.Parameters.AddWithValue("@primeraSalida", primeraSalida)
        sqlComm.Parameters.AddWithValue("@segundaSalida", segundaSalida)
        sqlComm.Parameters.AddWithValue("@terceraSalida", terceraSalida)
        sqlComm.Parameters.AddWithValue("@cuartaSalida", cuartaSalida)
        sqlComm.Parameters.AddWithValue("@quintaSalida", quintaSalida)
        sqlComm.Parameters.AddWithValue("@sextaSalida", sextaSalida)
        sqlComm.Parameters.AddWithValue("@septimaSalida", septimaSalida)
        sqlComm.Parameters.AddWithValue("@octavaSalida", octavaSalida)
        sqlComm.Parameters.AddWithValue("@novenaSalida", novenaSalida)
        sqlComm.Parameters.AddWithValue("@decimaSalida", decimaSalida)
        sqlComm.Parameters.AddWithValue("@onceSalida", onceSalida)
        sqlComm.Parameters.AddWithValue("@doceSalida", doceSalida)
        sqlComm.Parameters.AddWithValue("@treceSalida ", treceSalida)
        sqlComm.Parameters.AddWithValue("@catorceSalida", catorceSalida)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function



    '---------------------------- Funciones para Empleados ----------------------------

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


    '-----------------------------------Funciones Para Clientes-----------------------------------

    Public Function LlenarTablaClientes(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dv.Table = ds.Tables(0)
    End Function

    Public Function agregarCliente(identidadCliente As String, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, edad As String, depto As String, estado As String)
        Try
            conexion.Open()
            comand = New SqlCommand("agregarCliente", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@identidadCliente", identidadCliente)
            comand.Parameters.AddWithValue("@primerNombre", primerNombre)
            comand.Parameters.AddWithValue("@segundoNombre", segundoNombre)
            comand.Parameters.AddWithValue("@primerApellido", primerApellido)
            comand.Parameters.AddWithValue("@segundoApellido", segundoApellido)
            comand.Parameters.AddWithValue("@edadCliente", edad)
            comand.Parameters.AddWithValue("@departamento", depto)
            comand.Parameters.AddWithValue("@estado", estado)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function actualizarCliente(identidadCliente As String, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, edad As String, depto As String, estado As String)
        Try
            conexion.Open()
            comand = New SqlCommand("actualizarCliente", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@identidadCliente", identidadCliente)
            comand.Parameters.AddWithValue("@primerNombre", primerNombre)
            comand.Parameters.AddWithValue("@segundoNombre", segundoNombre)
            comand.Parameters.AddWithValue("@primerApellido", primerApellido)
            comand.Parameters.AddWithValue("@segundoApellido", segundoApellido)
            comand.Parameters.AddWithValue("@edadCliente", edad)
            comand.Parameters.AddWithValue("@departamento", depto)
            comand.Parameters.AddWithValue("@estado", estado)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function eliminarCliente(ByVal table, ByVal condicion)
        conexion.Open()
        Dim eliminarC As String = "delete from " + table + " where " + condicion
        comand = New SqlCommand(eliminarC, conexion)

        If comand.ExecuteNonQuery() Then
            Return True
            conexion.Close()
        Else
            Return False
            conexion.Close()
        End If
    End Function

    Public Function buscarCliente(ByVal condicion) As DataTable
        Try
            conexion.Open()
            Dim buscarC As String = "select * from clientes " + " where " + condicion

            Dim comand As New SqlCommand(buscarC, conexion)
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



    '----------------------------Funciones para Tarifas------------------------------

    Public Function LlenarTablaTarifas(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dv.Table = ds.Tables(0)
    End Function

    Public Function agregarTarifa(costo As Integer, estado As String)
        Try
            conexion.Open()
            comand = New SqlCommand("insertarTarifa", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@costo", costo)
            comand.Parameters.AddWithValue("@estado", estado)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function modificarTarifa(costo As Integer, estado As String)
        Try
            conexion.Open()
            comand = New SqlCommand("modificarTarifa", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@costo", costo)
            comand.Parameters.AddWithValue("@estado", estado)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function eliminarTarifa(costo As Integer)
        conexion.Open()
        cmd = New SqlCommand("eliminarTarifa", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@costo", costo)

        If cmd.ExecuteNonQuery <> 0 Then
            Return True
            conexion.Close()
        Else
            Return False
        End If
        conexion.Close()
    End Function


    '-----------------------------Funciones para Destinos-----------------------------

    Public Function LlenarTablaDestios(ByVal sql, ByVal tabla)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
        dv.Table = ds.Tables(0)
    End Function

    Public Function agregarDestino(codigoDestino As String, nombreDestino As String, precioViaje As Integer, estado As String)
        Try
            conexion.Open()
            comand = New SqlCommand("agregarDestino", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@codigoDestino", codigoDestino)
            comand.Parameters.AddWithValue("@nombreDestino", nombreDestino)
            comand.Parameters.AddWithValue("@precioViaje", precioViaje)
            comand.Parameters.AddWithValue("@estado", estado)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function modificarDestino(codigoDestino As String, nombreDestino As String, precioViaje As Integer, estado As String)
        Try
            conexion.Open()
            comand = New SqlCommand("modificarDestino", conexion)
            comand.CommandType = CommandType.StoredProcedure
            comand.Parameters.AddWithValue("@codigoDestino", codigoDestino)
            comand.Parameters.AddWithValue("@nombreDestino", nombreDestino)
            comand.Parameters.AddWithValue("@precioViaje", precioViaje)
            comand.Parameters.AddWithValue("@estado", estado)
            If comand.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function eliminarDestino(codigoDestino As String)

        conexion.Open()
        cmd = New SqlCommand("borrarDestino", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@codigoDestino", codigoDestino)
        If cmd.ExecuteNonQuery <> 0 Then
            Return True
            conexion.Close()
        Else
            Return False
        End If
        conexion.Close()

    End Function

End Class




