Public Class ventaBoletos

    Dim conexion As conexion = New conexion()

    Dim codigoBoleto As String
    Dim boletoAnterior As Integer
    Dim contadorBuses As Integer = 1
    Dim fechas As Date
    Dim identidad As String



    Dim contadorSalida As Integer
    Dim asientosBus As Integer

    Dim tipoBoleto As Integer = 0
    Dim y As Integer

    Private flag As Boolean

    Private Sub ventaBoletos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiarBoleto()

        asientoO1.Visible = False
        asientoO2.Visible = False
        asientoO3.Visible = False
        asientoO4.Visible = False
        asientoO5.Visible = False
        asientoO6.Visible = False
        asientoO7.Visible = False
        asientoO8.Visible = False
        asientoO9.Visible = False
        asientoO10.Visible = False
        asientoO11.Visible = False
        asientoO12.Visible = False
        asientoO13.Visible = False
        asientoO14.Visible = False
        asientoO15.Visible = False
        asientoO16.Visible = False
        asientoO17.Visible = False
        asientoO18.Visible = False
        asientoO19.Visible = False
        asientoO20.Visible = False
        asientoO21.Visible = False
        asientoO22.Visible = False
        asientoO23.Visible = False
        asientoO24.Visible = False
        asientoO25.Visible = False
        asientoO26.Visible = False
        asientoO27.Visible = False
        asientoO28.Visible = False
        asientoO29.Visible = False
        asientoO30.Visible = False
        asientoO31.Visible = False
        asientoO32.Visible = False
        asientoO33.Visible = False
        asientoO34.Visible = False
        asientoO35.Visible = False
        asientoO36.Visible = False
        asientoO37.Visible = False
        asientoO38.Visible = False
        asientoO39.Visible = False
        asientoO40.Visible = False
        asientoO41.Visible = False
        asientoO42.Visible = False
        asientoO43.Visible = False

        timerRestante.Enabled = False

        timerRestante.Interval = 3600
        y = 80

        actualizarBoleto()


        txtIdentidadCliente.Enabled = False
        txtNombreCliente.Enabled = False
        btnVenderBoleto.Enabled = False
        cmbDestino.Enabled = False
        cmbSalida.Enabled = False
        txtOtroDestino.Enabled = False
        mskNoAsiento.Enabled = False
        cmbSalida.SelectedIndex = 0
        lblSalida.Text = cmbSalida.SelectedItem


        analizarDia()
        cargarSalidaDiaria()

        verificarSalidaActual()

        contadorSalida = moduloTimers.nSalidaArranca


        txtMatriculaBus.Text = conexion.retornarPrimerAutobus(contadorBuses)



        moduloTimers.fechaActual = Format(Now, "yyyy/MM/dd")


        moduloTimers.temporalSalidaActual = contadorSalida

        lblFecha.Text = Format(Now, ("yyyy/MM/dd"))
        actualizarDatosBus()
        cargarDestinosCMB()
        estadoAsientos()

        systemHour.Enabled = True
        systemHour.Interval = 1



    End Sub

    Private Sub grpTimer_Enter(sender As Object, e As EventArgs) Handles grpTimer.Enter

    End Sub

    Private Sub timerRestante_Tick(sender As Object, e As EventArgs) Handles timerRestante.Tick


        y = y - 1

        If y > 60 And y > 70 Then
            tempSalida.Text = "01:" & y - 60

        ElseIf y > 60 And y < 70 Then
            tempSalida.Text = "01:0" & y - 60
        ElseIf y < 60 Then
            tempSalida.Text = "00:" & y
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkMembresia.CheckedChanged
        If chkMembresia.Checked = True Then

            chkClienteNormal.Checked = False
            chkClienteNormal.Enabled = False
            txtIdentidadCliente.Enabled = True


        Else
            chkClienteNormal.Enabled = True
            txtIdentidadCliente.Enabled = False
            txtNombreCliente.Clear()
            txtIdentidadCliente.Clear()

        End If


    End Sub

    Private Sub chkClienteNormal_CheckedChanged(sender As Object, e As EventArgs) Handles chkClienteNormal.CheckedChanged
        If chkClienteNormal.Checked = True Then

            chkMembresia.Checked = False
            chkMembresia.Enabled = False
            txtNombreCliente.Enabled = True
            identidad = "0000000000000"
        Else

            chkMembresia.Enabled = True
            txtNombreCliente.Enabled = False
            txtNombreCliente.Clear()

        End If


    End Sub

    Private Sub cmbAutobuses_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub actualizarDatosBus()

        For i = 0 To 3 Step 1
            Select Case i
                Case 0
                    marcaBusTxt.Text = conexion.retornarDatosAutobus(txtMatriculaBus.Text, 0)
                Case 1
                    capacidadPasajerosTxt.Text = conexion.retornarDatosAutobus(txtMatriculaBus.Text, 1)
                    asientosBus = Val(capacidadPasajerosTxt.Text)
                    lblAsientosDisp.Text = asientosBus
                Case 2
                    conductorTxt.Text = conexion.retornarDatosAutobus(txtMatriculaBus.Text, 2)
                Case 3
                    ayudanteTxt.Text = conexion.retornarDatosAutobus(txtMatriculaBus.Text, 3)
            End Select

        Next

    End Sub

    Private Sub cargarDestinosCMB()

        cmbDestino.Items.Add("<SELECCIONE>")
        cmbDestino.SelectedIndex = 0
        For i = 0 To 1 Step 1

            cmbDestino.Items.Add(conexion.cargarDestinos(i + 1))

        Next


    End Sub

    Private Sub cmbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDestino.SelectedIndexChanged
        If cmbDestino.SelectedIndex <> 0 Then
            txtPrecioBoleto.Text = conexion.retornarTarifa(cmbDestino.SelectedIndex)

            lblDestino.Text = cmbDestino.SelectedItem
            lblPrecio.Text = txtPrecioBoleto.Text & " Lps"

            txtOtroDestino.Enabled = False
            txtOtroDestino.Clear()

        Else
            txtPrecioBoleto.Clear()

        End If


    End Sub

    Private Sub btnVenderBoleto_Click(sender As Object, e As EventArgs) Handles btnVenderBoleto.Click
        Dim temporalDestino As Integer
        Dim temporalPrecio As Integer

        Try

            If (txtIdentidadCliente.Text <> String.Empty Or txtNombreCliente.Text <> String.Empty) And (cmbDestino.SelectedIndex <> 0 Or txtOtroDestino.Text <> String.Empty) And cmbSalida.SelectedItem <> "" And txtPrecioBoleto.Text <> String.Empty And mskNoAsiento.Text <> String.Empty Then

                If cmbDestino.SelectedIndex = 0 Then
                    tipoBoleto = 2
                    temporalPrecio = Val(txtPrecioBoleto.Text)
                Else
                    temporalDestino = cmbDestino.SelectedIndex
                    tipoBoleto = 1
                    temporalPrecio = 0
                End If
                If conexion.ventaRegistradaBoleto(tipoBoleto, Format(Now, ("yyyy/MM/dd")), txtCodigoBoleto.Text, identidad, txtMatriculaBus.Text, Val(mskNoAsiento.Text), UCase(cmbSalida.SelectedItem), Val(temporalDestino), temporalPrecio, UCase(txtOtroDestino.Text), contadorSalida) Then
                    asientos(Val(mskNoAsiento.Text)) = "OCUPADO"
                    verificarAsientos()
                    MsgBox("BOLETO VENDIDO", vbInformation)
                    asientosBus -= 1
                    lblAsientosDisp.Text = asientosBus
                    actualizarBoleto()
                    limpiarPantalla()
                Else
                    MsgBox("ERROR AL VENDER", vbInformation)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub mskNoAsiento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskNoAsiento.MaskInputRejected

    End Sub


    Private Sub mskNoAsiento_TextChanged(sender As Object, e As EventArgs) Handles mskNoAsiento.TextChanged
        If mskNoAsiento.Text <> String.Empty Then

            If Val(mskNoAsiento.Text) > 0 And Val(mskNoAsiento.Text) < 45 Then

                If asientos(Val(mskNoAsiento.Text)) <> "OCUPADO" Then
                    mskNoAsiento.ForeColor = Color.Green
                    lblNoAsiento.Text = mskNoAsiento.Text
                    btnVenderBoleto.Enabled = True

                Else
                    btnVenderBoleto.Enabled = False
                    mskNoAsiento.ForeColor = Color.Red
                End If
            End If
        End If

    End Sub

    Private Sub txtIdentidadCliente_TextChanged(sender As Object, e As EventArgs) Handles txtIdentidadCliente.TextChanged
        If txtIdentidadCliente.Text <> String.Empty And IsNumeric(txtIdentidadCliente.Text) = True And txtIdentidadCliente.TextLength = 13 And conexion.retornarNombreMembresia(txtIdentidadCliente.Text) <> String.Empty Then

            txtIdentidadCliente.ForeColor = Color.Green

            txtNombreCliente.Text = conexion.retornarNombreMembresia(txtIdentidadCliente.Text)

            lblNombre.Text = txtNombreCliente.Text

            cmbSalida.Enabled = True
            cmbDestino.Enabled = True

            identidad = txtIdentidadCliente.Text
        Else
            txtIdentidadCliente.ForeColor = Color.Black
            cmbSalida.Enabled = False
            txtNombreCliente.Clear()

            cmbDestino.Enabled = False

        End If
    End Sub

    Private Sub txtNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCliente.TextChanged
        If txtNombreCliente.Text <> String.Empty And IsNumeric(txtNombreCliente.Text) = False And txtNombreCliente.TextLength > 5 Then

            txtNombreCliente.ForeColor = Color.Green

            lblNombre.Text = txtNombreCliente.Text

            cmbSalida.Enabled = True
            cmbDestino.Enabled = True

        Else
            txtNombreCliente.ForeColor = Color.Black
            cmbSalida.Enabled = False
            cmbDestino.Enabled = False


        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkOtroDestino.CheckedChanged
        If chkOtroDestino.Checked = True Then
            cmbDestino.SelectedIndex = 0
            txtOtroDestino.Enabled = True
            cmbDestino.Enabled = False

        Else
            cmbDestino.Enabled = True

            txtOtroDestino.Enabled = False
            txtOtroDestino.Clear()
            txtPrecioBoleto.Clear()


        End If
    End Sub

    Private Sub grpVentBoleto_Enter(sender As Object, e As EventArgs) Handles grpVentBoleto.Enter

    End Sub

    Private Sub txtOtroDestino_TextChanged(sender As Object, e As EventArgs) Handles txtOtroDestino.TextChanged
        If txtOtroDestino.Text <> String.Empty And txtOtroDestino.TextLength > 4 Then

            txtPrecioBoleto.Enabled = True
            txtPrecioBoleto.ReadOnly = False

        Else
            txtPrecioBoleto.Enabled = False
            txtPrecioBoleto.ReadOnly = True

        End If
    End Sub

    Private Sub txtPrecioBoleto_TextChanged(sender As Object, e As EventArgs) Handles txtPrecioBoleto.TextChanged
        If txtPrecioBoleto.Text <> String.Empty And IsNumeric(txtPrecioBoleto.Text) = True And Val(txtPrecioBoleto.Text) > 10 And Val(txtPrecioBoleto.Text) <= 120 Then

            mskNoAsiento.Enabled = True
            lblPrecio.Text = txtPrecioBoleto.Text & " Lps"
        Else

            mskNoAsiento.Enabled = False

        End If
    End Sub

    Private Sub cmbSalida_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSalida.SelectedIndexChanged

    End Sub

    Private Sub lblSalida_Click(sender As Object, e As EventArgs) Handles lblSalida.Click

    End Sub






    Private Sub limpiarBoleto()
        lblNombre.Text = "---"
        lblCodigo.Text = "---"
        lblDestino.Text = "---"
        lblFecha.Text = "---"
        lblPrecio.Text = "-- Lps"
        lblSalida.Text = "---"
        lblNoAsiento.Text = "--"

    End Sub

    Public Sub actualizarBoleto()
        If Val(conexion.retornarUltimoBoleto()) = 0 Then
            boletoAnterior = "00001"
            txtCodigoBoleto.Text = "00001"
            lblCodigo.Text = txtCodigoBoleto.Text
        Else
            boletoAnterior = conexion.retornarUltimoBoleto()
            If boletoAnterior >= 1 Then
                txtCodigoBoleto.Text = "0000" & boletoAnterior + 1
                lblCodigo.Text = txtCodigoBoleto.Text
            ElseIf boletoAnterior >= 10 Then
                txtCodigoBoleto.Text = "000" & boletoAnterior + 1
                lblCodigo.Text = txtCodigoBoleto.Text
            ElseIf boletoAnterior >= 100 Then
                txtCodigoBoleto.Text = "00" & boletoAnterior + 1
                lblCodigo.Text = txtCodigoBoleto.Text
            ElseIf boletoAnterior >= 1000 Then
                txtCodigoBoleto.Text = "0" & boletoAnterior + 1
                lblCodigo.Text = txtCodigoBoleto.Text
            End If



        End If
    End Sub

    Private Sub limpiarPantalla()
        chkMembresia.Checked = False
        chkClienteNormal.Checked = False
        txtIdentidadCliente.Clear()
        txtNombreCliente.Clear()
        cmbSalida.SelectedIndex = 0
        cmbDestino.SelectedIndex = 0
        chkOtroDestino.Checked = False
        txtOtroDestino.Clear()
        txtPrecioBoleto.Clear()
        mskNoAsiento.Clear()
        btnVenderBoleto.Enabled = False

        limpiarBoleto()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiarPantalla()
    End Sub



    Private Sub systemHour_Tick(sender As Object, e As EventArgs) Handles systemHour.Tick

        restarHoras()


    End Sub

    Private Sub nextDepart_Click(sender As Object, e As EventArgs) Handles nextDepart.Click

        Dim Pregunta As String

        Pregunta = MsgBox("ROTAR AUTOBUS?", vbYesNo + vbQuestion, "SIGUIENTE AUTOBUS")

        If Pregunta = vbNo Then

        Else

            estadosAutobuses.Show()
            If contadorSalida = 14 Then
                nextDepart.Enabled = False

            Else
                identificarSalida(contadorSalida)

                moduloTimers.temporalSalidaActual = contadorSalida

                contadorSalida = contadorSalida + 1
                contadorBuses = contadorBuses + 1
                txtMatriculaBus.Text = conexion.retornarPrimerAutobus(contadorBuses)


                actualizarDatosBus()
                estadoAsientos()
                verificarAsientos()
            End If
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles eliminarBoletos.Click
        Me.Hide()
        eliminarBoleto.Show()

    End Sub

    Private Sub restarHoras()
        Try
            Dim inicial As String = Format(Now, ("HH:mm"))
            Dim final As String = Format(horasDiarias(contadorSalida), ("hh:mm"))
            Dim rest As String

            Dim tiempoI As TimeSpan
            Dim tiempoF As TimeSpan
            Dim resta As TimeSpan

            tiempoI = TimeSpan.Parse(inicial)
            tiempoF = TimeSpan.Parse(final)

            tiempoI = TimeSpan.Parse(inicial)
            tiempoF = TimeSpan.Parse(final)


            If StrComp(inicial, final, vbTextCompare) <> 0 Then


                If Val(Mid(inicial, 1, 2)) > 17 Then
                    tempSalida.Text = " --:-- "


                ElseIf Val(Mid(inicial, 1, 2)) < 17 Then

                    resta = tiempoF - tiempoI

                    rest = resta.ToString()

                    resta = tiempoF - tiempoI

                    rest = resta.ToString()


                    tempSalida.Text = Mid(rest, 1, 5)

                    horaDespegue.Text = final
                End If



            ElseIf StrComp(inicial, final, vbTextCompare) = 0 Then

                nextDepart.ForeColor = Color.White
                nextDepart.BackColor = Color.Red

                moduloTimers.TriggerTimerUno = 1

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSalidas_Click(sender As Object, e As EventArgs) Handles btnSalidas.Click
        estadosAutobuses.Show()
    End Sub

    Private Sub asientoO37_Click(sender As Object, e As EventArgs) Handles asientoO37.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        timerPulsacion.Interval = 1000
        flag = False
        timerPulsacion.Start()


    End Sub

    Private Sub timerPulsacion_Tick(sender As Object, e As EventArgs) Handles timerPulsacion.Tick

        If flag Then


            picTiempoSalida.Visible = True
            picTiempoSalida.BackColor = Color.Red
            flag = False



        Else
            picTiempoSalida.Visible = False
            flag = True

        End If


    End Sub

    Private Sub identificarSalida(ByVal NoSalida As Integer)
        Select Case NoSalida
            Case 1
                moduloTimers.TriggerTimerUno = 1
            Case 2
                moduloTimers.TriggerTimerDos = 1
            Case 3
                moduloTimers.TriggerTimerTres = 1
            Case 4
                moduloTimers.TriggerTimerCuatro = 1
            Case 5
                moduloTimers.TriggerTimerCinco = 1
            Case 6
                moduloTimers.TriggerTimerSeis = 1
            Case 7
                moduloTimers.TriggerTimerSiete = 1
            Case 8
                moduloTimers.TriggerTimerOcho = 1
            Case 9
                moduloTimers.TriggerTimerNueve = 1
            Case 10
                moduloTimers.TriggerTimerDiez = 1
            Case 11
                moduloTimers.TriggerTimerOnce = 1
            Case 12
                moduloTimers.TriggerTimerDoce = 1
            Case 13
                moduloTimers.TriggerTimerTrece = 1
            Case 14
                moduloTimers.TriggerTimerCatorce = 1
        End Select

    End Sub

    Private Sub verificarAsientos()

        If asientos(1) = "OCUPADO" Then
            asientoO1.Visible = True
        Else
            asientoO1.Visible = False
        End If

        If asientos(2) = "OCUPADO" Then
            asientoO2.Visible = True
        Else
            asientoO2.Visible = False
        End If
        If asientos(3) = "OCUPADO" Then
            asientoO3.Visible = True
        Else
            asientoO3.Visible = False
        End If
        If asientos(4) = "OCUPADO" Then
            asientoO4.Visible = True
        Else
            asientoO4.Visible = False
        End If

        If asientos(5) = "OCUPADO" Then
            asientoO5.Visible = True
        Else
            asientoO5.Visible = False
        End If
        If asientos(2) = "OCUPADO" Then
            asientoO2.Visible = True
        Else
            asientoO2.Visible = False
        End If
        If asientos(6) = "OCUPADO" Then
            asientoO6.Visible = True
        Else
            asientoO6.Visible = False
        End If
        If asientos(7) = "OCUPADO" Then
            asientoO7.Visible = True
        Else
            asientoO7.Visible = False
        End If
        If asientos(8) = "OCUPADO" Then
            asientoO8.Visible = True
        Else
            asientoO8.Visible = False
        End If
        If asientos(9) = "OCUPADO" Then
            asientoO9.Visible = True
        Else
            asientoO9.Visible = False
        End If
        If asientos(10) = "OCUPADO" Then
            asientoO10.Visible = True
        Else
            asientoO10.Visible = False
        End If
        If asientos(11) = "OCUPADO" Then
            asientoO11.Visible = True
        Else
            asientoO11.Visible = False
        End If
        If asientos(12) = "OCUPADO" Then
            asientoO12.Visible = True
        Else
            asientoO12.Visible = False
        End If
        If asientos(13) = "OCUPADO" Then
            asientoO13.Visible = True
        Else
            asientoO13.Visible = False
        End If
        If asientos(14) = "OCUPADO" Then
            asientoO14.Visible = True
        Else
            asientoO14.Visible = False
        End If
        If asientos(15) = "OCUPADO" Then
            asientoO15.Visible = True
        Else
            asientoO15.Visible = False
        End If
        If asientos(16) = "OCUPADO" Then
            asientoO16.Visible = True
        Else
            asientoO16.Visible = False
        End If
        If asientos(17) = "OCUPADO" Then
            asientoO17.Visible = True
        Else
            asientoO17.Visible = False
        End If
        If asientos(18) = "OCUPADO" Then
            asientoO18.Visible = True
        Else
            asientoO18.Visible = False
        End If
        If asientos(19) = "OCUPADO" Then
            asientoO19.Visible = True
        Else
            asientoO19.Visible = False
        End If
        If asientos(20) = "OCUPADO" Then
            asientoO20.Visible = True
        Else
            asientoO20.Visible = False
        End If
        If asientos(21) = "OCUPADO" Then
            asientoO21.Visible = True
        Else
            asientoO21.Visible = False
        End If
        If asientos(22) = "OCUPADO" Then
            asientoO22.Visible = True
        Else
            asientoO22.Visible = False
        End If
        If asientos(23) = "OCUPADO" Then
            asientoO23.Visible = True
        Else
            asientoO23.Visible = False
        End If
        If asientos(24) = "OCUPADO" Then
            asientoO24.Visible = True
        Else
            asientoO24.Visible = False
        End If
        If asientos(25) = "OCUPADO" Then
            asientoO25.Visible = True
        Else
            asientoO25.Visible = False
        End If
        If asientos(26) = "OCUPADO" Then
            asientoO26.Visible = True
        Else
            asientoO26.Visible = False
        End If
        If asientos(27) = "OCUPADO" Then
            asientoO27.Visible = True
        Else
            asientoO27.Visible = False
        End If
        If asientos(28) = "OCUPADO" Then
            asientoO28.Visible = True
        Else
            asientoO28.Visible = False
        End If
        If asientos(29) = "OCUPADO" Then
            asientoO29.Visible = True
        Else
            asientoO29.Visible = False
        End If
        If asientos(29) = "OCUPADO" Then
            asientoO29.Visible = True
        Else
            asientoO29.Visible = False
        End If

        If asientos(30) = "OCUPADO" Then
            asientoO30.Visible = True
        Else
            asientoO30.Visible = False
        End If

        If asientos(31) = "OCUPADO" Then
            asientoO31.Visible = True
        Else
            asientoO31.Visible = False
        End If

        If asientos(32) = "OCUPADO" Then
            asientoO32.Visible = True
        Else
            asientoO32.Visible = False
        End If

        If asientos(33) = "OCUPADO" Then
            asientoO33.Visible = True
        Else
            asientoO33.Visible = False
        End If

        If asientos(34) = "OCUPADO" Then
            asientoO34.Visible = True
        Else
            asientoO34.Visible = False
        End If

        If asientos(35) = "OCUPADO" Then
            asientoO35.Visible = True
        Else
            asientoO35.Visible = False
        End If

        If asientos(36) = "OCUPADO" Then
            asientoO36.Visible = True
        Else
            asientoO36.Visible = False
        End If

        If asientos(37) = "OCUPADO" Then
            asientoO37.Visible = True
        Else
            asientoO37.Visible = False
        End If

        If asientos(38) = "OCUPADO" Then
            asientoO38.Visible = True
        Else
            asientoO38.Visible = False
        End If

        If asientos(39) = "OCUPADO" Then
            asientoO39.Visible = True
        Else
            asientoO39.Visible = False
        End If

        If asientos(40) = "OCUPADO" Then
            asientoO40.Visible = True
        Else
            asientoO40.Visible = False
        End If

        If asientos(41) = "OCUPADO" Then
            asientoO41.Visible = True
        Else
            asientoO41.Visible = False
        End If

        If asientos(42) = "OCUPADO" Then
            asientoO42.Visible = True
        Else
            asientoO42.Visible = False
        End If

        If asientos(43) = "OCUPADO" Then
            asientoO43.Visible = True
        Else
            asientoO43.Visible = False
        End If



    End Sub

    Private Sub btnModificarSalidas_Click(sender As Object, e As EventArgs) Handles btnModificarSalidas.Click
        modificarOrdenesDeSalida.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class