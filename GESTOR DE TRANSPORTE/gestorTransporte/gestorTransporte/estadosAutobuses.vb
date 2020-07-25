Public Class estadosAutobuses

    Dim conexion As conexion = New conexion()
    Dim I As Long = 0   'Contador.  
    Dim I2 As Long = 0   'Contador.  
    Dim I3 As Long = 0   'Contador.  
    Dim I4 As Long = 0   'Contador.  
    Dim I5 As Long = 0   'Contador.  
    Dim I6 As Long = 0   'Contador.  
    Dim I7 As Long = 0   'Contador.  
    Dim I8 As Long = 0   'Contador.  
    Dim I9 As Long = 0   'Contador.  
    Dim I10 As Long = 0   'Contador.  
    Dim I11 As Long = 0   'Contador.  
    Dim I12 As Long = 0   'Contador.  
    Dim I13 As Long = 0   'Contador.  
    Dim I14 As Long = 0   'Contador.  

    Dim Tiempo As String  'Tiempo total transcurrido.  
    Dim Tiempo2 As String  'Tiempo total transcurrido. 
    Dim Tiempo3 As String  'Tiempo total transcurrido.
    Dim Tiempo4 As String  'Tiempo total transcurrido.  
    Dim Tiempo5 As String  'Tiempo total transcurrido.  
    Dim Tiempo6 As String  'Tiempo total transcurrido. 
    Dim Tiempo7 As String  'Tiempo total transcurrido.
    Dim Tiempo8 As String  'Tiempo total transcurrido.  
    Dim Tiempo9 As String  'Tiempo total transcurrido.  
    Dim Tiempo10 As String  'Tiempo total transcurrido. 
    Dim Tiempo11 As String  'Tiempo total transcurrido.
    Dim Tiempo12 As String  'Tiempo total transcurrido.  
    Dim Tiempo13 As String  'Tiempo total transcurrido.
    Dim Tiempo14 As String  'Tiempo total transcurrido.  


    Private Sub estadosAutobuses_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        timerRefresh.Enabled = True
        timerRefresh.Interval = 1

        cargarSalidaDiaria()


    End Sub

    Private Sub timerUno_Tick(sender As Object, e As EventArgs) Handles timerUno.Tick
        I = I + 10
        Tiempo = Format(Int(I / 36000) Mod 24, "00") & ":" &
                 Format(Int(I / 600) Mod 60, "00") & ":" &
                 Format(Int(I / 10) Mod 60, "00") & ":" &
                 Format(I Mod 10, "00")

        lblTimerUno.Text = Mid(Tiempo, 1, 5)

        ubicacionBusUno.Text = determinarUbicacion(Mid(Tiempo, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(1), ubicacionBusUno.Text)

    End Sub

    Private Sub timerDos_Tick(sender As Object, e As EventArgs) Handles timerDos.Tick
        I2 = I2 + 10
        Tiempo2 = Format(Int(I2 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I2 / 600) Mod 60, "00") & ":" &
                 Format(Int(I2 / 10) Mod 60, "00") & ":" &
                 Format(I2 Mod 10, "00")

        lblTimerDos.Text = Mid(Tiempo2, 1, 5)

        ubicacionBusDos.Text = determinarUbicacion(Mid(Tiempo2, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(2), ubicacionBusDos.Text)
    End Sub

    Private Sub timerTres_Tick(sender As Object, e As EventArgs) Handles timerTres.Tick
        I3 = I3 + 10
        Tiempo3 = Format(Int(I3 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I3 / 600) Mod 60, "00") & ":" &
                 Format(Int(I3 / 10) Mod 60, "00") & ":" &
                 Format(I3 Mod 10, "00")

        lblTimerTres.Text = Mid(Tiempo3, 1, 5)

        ubicacionBusTres.Text = determinarUbicacion(Mid(Tiempo3, 1, 5))
        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(3), ubicacionBusTres.Text)

    End Sub

    Private Sub timerCuatro_Tick(sender As Object, e As EventArgs) Handles timerCuatro.Tick
        I4 = I4 + 10
        Tiempo4 = Format(Int(I4 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I4 / 600) Mod 60, "00") & ":" &
                 Format(Int(I4 / 10) Mod 60, "00") & ":" &
                 Format(I4 Mod 10, "00")

        lblTimerCuatro.Text = Mid(Tiempo4, 1, 5)

        ubicacionBusCuatro.Text = determinarUbicacion(Mid(Tiempo4, 1, 5))
        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(4), ubicacionBusCuatro.Text)


    End Sub

    Private Sub timerCinco_Tick(sender As Object, e As EventArgs) Handles timerCinco.Tick
        I5 = I5 + 10
        Tiempo5 = Format(Int(I5 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I5 / 600) Mod 60, "00") & ":" &
                 Format(Int(I5 / 10) Mod 60, "00") & ":" &
                 Format(I5 Mod 10, "00")

        lblTimerCinco.Text = Mid(Tiempo5, 1, 5)

        ubicacionBusCinco.Text = determinarUbicacion(Mid(Tiempo5, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(5), ubicacionBusCinco.Text)

    End Sub

    Private Sub timerSeis_Tick(sender As Object, e As EventArgs) Handles timerSeis.Tick
        I6 = I6 + 10
        Tiempo6 = Format(Int(I6 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I6 / 600) Mod 60, "00") & ":" &
                 Format(Int(I6 / 10) Mod 60, "00") & ":" &
                 Format(I6 Mod 10, "00")

        lblTimerSeis.Text = Mid(Tiempo6, 1, 5)

        ubicacionBusSeis.Text = determinarUbicacion(Mid(Tiempo6, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(6), ubicacionBusSeis.Text)

    End Sub

    Private Sub timerSiete_Tick(sender As Object, e As EventArgs) Handles timerSiete.Tick
        I7 = I7 + 10
        Tiempo7 = Format(Int(I7 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I7 / 600) Mod 60, "00") & ":" &
                 Format(Int(I7 / 10) Mod 60, "00") & ":" &
                 Format(I7 Mod 10, "00")

        lblTimerSiete.Text = Mid(Tiempo7, 1, 5)

        ubicacionBusSiete.Text = determinarUbicacion(Mid(Tiempo7, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(7), ubicacionBusSiete.Text)
    End Sub

    Private Sub timerOcho_Tick(sender As Object, e As EventArgs) Handles timerOcho.Tick
        I8 = I8 + 10
        Tiempo8 = Format(Int(I8 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I8 / 600) Mod 60, "00") & ":" &
                 Format(Int(I8 / 10) Mod 60, "00") & ":" &
                 Format(I8 Mod 10, "00")

        lblTimerOcho.Text = Mid(Tiempo8, 1, 5)

        ubicacionBusOcho.Text = determinarUbicacion(Mid(Tiempo8, 1, 5))
        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(8), ubicacionBusOcho.Text)

    End Sub

    Private Sub timerNueve_Tick(sender As Object, e As EventArgs) Handles timerNueve.Tick
        I9 = I9 + 10
        Tiempo9 = Format(Int(I9 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I9 / 600) Mod 60, "00") & ":" &
                 Format(Int(I9 / 10) Mod 60, "00") & ":" &
                 Format(I9 Mod 10, "00")

        lblTimerNueve.Text = Mid(Tiempo9, 1, 5)

        ubicacionBusNueve.Text = determinarUbicacion(Mid(Tiempo9, 1, 5))
        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(9), ubicacionBusNueve.Text)

    End Sub

    Private Sub timerDiez_Tick(sender As Object, e As EventArgs) Handles timerDiez.Tick
        I10 = I10 + 10
        Tiempo10 = Format(Int(I10 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I10 / 600) Mod 60, "00") & ":" &
                 Format(Int(I10 / 10) Mod 60, "00") & ":" &
                 Format(I10 Mod 10, "00")

        lblTimerDiez.Text = Mid(Tiempo10, 1, 5)

        ubicacionBusDiez.Text = determinarUbicacion(Mid(Tiempo10, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(10), ubicacionBusDiez.Text)

    End Sub

    Private Sub timerOnce_Tick(sender As Object, e As EventArgs) Handles timerOnce.Tick
        I11 = I11 + 10
        Tiempo11 = Format(Int(I11 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I11 / 600) Mod 60, "00") & ":" &
                 Format(Int(I11 / 10) Mod 60, "00") & ":" &
                 Format(I11 Mod 10, "00")

        lblTimerOnce.Text = Mid(Tiempo11, 1, 5)

        ubicacionBusOnce.Text = determinarUbicacion(Mid(Tiempo11, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(11), ubicacionBusOnce.Text)
    End Sub

    Private Sub timerDoce_Tick(sender As Object, e As EventArgs) Handles timerDoce.Tick
        I12 = I12 + 10
        Tiempo12 = Format(Int(I12 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I12 / 600) Mod 60, "00") & ":" &
                 Format(Int(I12 / 10) Mod 60, "00") & ":" &
                 Format(I12 Mod 10, "00")

        lblTimerDoce.Text = Mid(Tiempo12, 1, 5)

        ubicacionBusDoce.Text = determinarUbicacion(Mid(Tiempo12, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(12), ubicacionBusDoce.Text)

    End Sub

    Private Sub timerTrece_Tick(sender As Object, e As EventArgs) Handles timerTrece.Tick
        I13 = I13 + 10
        Tiempo13 = Format(Int(I13 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I13 / 600) Mod 60, "00") & ":" &
                 Format(Int(I13 / 10) Mod 60, "00") & ":" &
                 Format(I13 Mod 10, "00")

        lblTimerTrece.Text = Mid(Tiempo13, 1, 5)

        ubicacionBusTrece.Text = determinarUbicacion(Mid(Tiempo13, 1, 5))

        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(13), ubicacionBusTrece.Text)
    End Sub

    Private Sub timerCatorce_Tick(sender As Object, e As EventArgs) Handles timerCatorce.Tick
        I14 = I14 + 10
        Tiempo14 = Format(Int(I14 / 36000) Mod 24, "00") & ":" &
                 Format(Int(I14 / 600) Mod 60, "00") & ":" &
                 Format(Int(I14 / 10) Mod 60, "00") & ":" &
                 Format(I14 Mod 10, "00")

        lblTimerCatorce.Text = Mid(Tiempo14, 1, 5)

        ubicacionBusCatorce.Text = determinarUbicacion(Mid(Tiempo14, 1, 5))
        conexion.actualizarUbicacionBus(moduloTimers.salidasDiarias(14), ubicacionBusCatorce.Text)
    End Sub


    Function determinarUbicacion(ByVal Hora As String)
        Dim lugarAproximado As String

        If Val(Mid(Hora, 1, 2)) = 0 And Val(Mid(Hora, 4, 5)) > 0 And Val(Mid(Hora, 4, 5)) < 49 Then

            lugarAproximado = "TRAYECTO LA ESPERANZA - JESUS DE OTORO"

        ElseIf Val(Mid(Hora, 1, 2)) = 0 And Val(Mid(Hora, 4, 5)) >= 50 And Val(Mid(Hora, 4, 5)) <= 55 Then
            timerUno.Enabled = True  'Detener el cronometro  
            lugarAproximado = "JESUS DE OTORO"

        ElseIf Val(Mid(Hora, 1, 2)) = 0 And Val(Mid(Hora, 4, 5)) > 55 And Val(Mid(Hora, 4, 5)) < 60 Then
            lugarAproximado = "TRAYECTO JESUS DE OTORO - SIGUATEPEQUE"

        ElseIf Val(Mid(Hora, 1, 2)) = 1 And Val(Mid(Hora, 4, 5)) > 0 And Val(Mid(Hora, 4, 5)) < 15 Then

            lugarAproximado = "TRAYECTO JESUS DE OTORO - SIGUATEPEQUE"

        ElseIf Val(Mid(Hora, 1, 2)) = 1 And Val(Mid(Hora, 4, 5)) >= 15 And Val(Mid(Hora, 4, 5)) <= 20 Then

            lugarAproximado = "SIGUATEPEQUE"

        ElseIf Val(Mid(Hora, 1, 2)) = 1 And Val(Mid(Hora, 4, 5)) > 20 And Val(Mid(Hora, 4, 5)) < 55 Then

            lugarAproximado = "TRAYECTO SIGUATEPEQUE - COMAYAGUA"

        ElseIf Val(Mid(Hora, 1, 2)) = 1 And Val(Mid(Hora, 4, 5)) >= 55 And Val(Mid(Hora, 4, 5)) < 60 Then

            lugarAproximado = "COMAYAGUA"


        ElseIf Val(Mid(Hora, 1, 2)) = 2 And Val(Mid(Hora, 4, 5)) > 0 And Val(Mid(Hora, 4, 5)) <= 30 Then

            lugarAproximado = "TRAYECTO COMAYAGUA - EL RODEO"

        ElseIf Val(Mid(Hora, 1, 2)) = 2 And Val(Mid(Hora, 4, 5)) > 30 And Val(Mid(Hora, 4, 5)) < 60 Then

            lugarAproximado = "TRAYECTO EL RODEO - AMARATECA"

        ElseIf Val(Mid(Hora, 1, 2)) = 3 And Val(Mid(Hora, 4, 5)) > 0 And Val(Mid(Hora, 4, 5)) <= 30 Then

            lugarAproximado = "TRAYECTO AMARATECA- EL DURAZNO"

        ElseIf Val(Mid(Hora, 1, 2)) = 3 And Val(Mid(Hora, 4, 5)) > 30 And Val(Mid(Hora, 4, 5)) < 60 Then

            lugarAproximado = "ENTRANDO A TEGUCIGALPA"

        ElseIf Val(Mid(Hora, 1, 2)) = 4 And Val(Mid(Hora, 4, 5)) = 0 Then

            lugarAproximado = "TEGUCIGALPA"

        End If

        Return lugarAproximado
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ventaBoletos.Show()
    End Sub

    Private Sub timerRefresh_Tick(sender As Object, e As EventArgs) Handles timerRefresh.Tick
        If moduloTimers.TriggerTimerUno = 1 Then
            timerUno.Enabled = True  'Detener el cronometro  
            timerUno.Interval = 1
            estadoBusUno.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerDos = 1 Then
            timerDos.Enabled = True  'Detener el cronometro  
            timerDos.Interval = 1
            estadoBusDos.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerTres = 1 Then
            timerTres.Enabled = True  'Detener el cronometro  
            timerTres.Interval = 1
            estadoBusTres.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerCuatro = 1 Then
            timerCuatro.Enabled = True  'Detener el cronometro  
            timerCuatro.Interval = 1
            estadoBusCuatro.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerCinco = 1 Then
            timerCinco.Enabled = True  'Detener el cronometro  
            timerCinco.Interval = 1
            estadoBusCinco.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerSeis = 1 Then
            timerSeis.Enabled = True  'Detener el cronometro  
            timerSeis.Interval = 1
            estadoBusSeis.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerSiete = 1 Then
            timerSiete.Enabled = True  'Detener el cronometro  
            timerSiete.Interval = 1
            estadoBusSiete.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerOcho = 1 Then
            timerOcho.Enabled = True  'Detener el cronometro  
            timerOcho.Interval = 1
            estadoBusOcho.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerNueve = 1 Then
            timerNueve.Enabled = True  'Detener el cronometro  
            timerNueve.Interval = 1
            estadoBusNueve.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerDiez = 1 Then
            timerDiez.Enabled = True  'Detener el cronometro  
            timerDiez.Interval = 1
            estadoBusDiez.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerOnce = 1 Then
            timerOnce.Enabled = True  'Detener el cronometro  
            timerOnce.Interval = 1
            estadoBusOnce.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerDoce = 1 Then
            timerDoce.Enabled = True  'Detener el cronometro  
            timerDoce.Interval = 1
            estadoBusDoce.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerTrece = 1 Then
            timerTrece.Enabled = True  'Detener el cronometro  
            timerTrece.Interval = 1
            estadoBusTrece.Text = "EN VIAJE"
        End If
        If moduloTimers.TriggerTimerCatorce = 1 Then
            timerCatorce.Enabled = True  'Detener el cronometro  
            timerCatorce.Interval = 1
            estadoBusCatorce.Text = "EN VIAJE"
        End If

        If Val(Mid(Tiempo, 1, 2)) = 4 Then
            timerUno.Enabled = False
            estadoBusUno.Text = "COMPLETADO"

        End If
        If Val(Mid(Tiempo2, 1, 2)) = 4 Then
            timerDos.Enabled = False
            estadoBusDos.Text = "COMPLETADO"

        End If
        If Val(Mid(Tiempo3, 1, 2)) = 4 Then
            timerTres.Enabled = False
            estadoBusTres.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo4, 1, 2)) = 4 Then
            timerCuatro.Enabled = False
            estadoBusCuatro.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo5, 1, 2)) = 4 Then
            timerCinco.Enabled = False
            estadoBusCinco.Text = "COMPLETADO"

        End If
        If Val(Mid(Tiempo6, 1, 2)) = 4 Then
            timerSeis.Enabled = False
            estadoBusSeis.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo7, 1, 2)) = 4 Then
            timerSiete.Enabled = False
            estadoBusSiete.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo8, 1, 2)) = 4 Then
            timerOcho.Enabled = False
            estadoBusOcho.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo9, 1, 2)) = 4 Then
            timerNueve.Enabled = False
            estadoBusNueve.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo10, 1, 2)) = 4 Then
            timerDiez.Enabled = False
            estadoBusDiez.Text = "COMPLETADO"

        End If
        If Val(Mid(Tiempo11, 1, 2)) = 4 Then
            timerOnce.Enabled = False
            estadoBusOnce.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo12, 1, 2)) = 4 Then
            timerDoce.Enabled = False
            estadoBusDoce.Text = "COMPLETADO"

        End If
        If Val(Mid(Tiempo13, 1, 2)) = 4 Then
            timerTrece.Enabled = False
            estadoBusTrece.Text = "COMPLETADO"

        End If

        If Val(Mid(Tiempo14, 1, 2)) = 4 Then
            timerCatorce.Enabled = False
            estadoBusCatorce.Text = "COMPLETADO"

        End If


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class