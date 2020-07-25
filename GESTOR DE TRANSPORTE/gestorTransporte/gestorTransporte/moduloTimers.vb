Module moduloTimers

    Dim conexion As conexion = New conexion()

    Dim horaSistema As String = Format(Now, ("hh:mm"))

    Public nSalidaArranca As Integer

    Public TriggerTimerUno As Integer = 0
    Public TriggerTimerDos As Integer = 0
    Public TriggerTimerTres As Integer = 0
    Public TriggerTimerCuatro As Integer = 0
    Public TriggerTimerCinco As Integer = 0
    Public TriggerTimerSeis As Integer = 0
    Public TriggerTimerSiete As Integer = 0
    Public TriggerTimerOcho As Integer = 0
    Public TriggerTimerNueve As Integer = 0
    Public TriggerTimerDiez As Integer = 0
    Public TriggerTimerOnce As Integer = 0
    Public TriggerTimerDoce As Integer = 0
    Public TriggerTimerTrece As Integer = 0
    Public TriggerTimerCatorce As Integer = 0

    Public temporalSalidaActual As Integer
    Public fechaActual As String
    Public asientos(45) As String
    Public salidasDiarias(14) As String
    Public horasDiarias(14) As Date

    Public idDiaSalida As Integer


    Public Sub analizarDia()
        Dim nombredia As String = Now.ToString("dddd")

        If nombredia = "domingo" Then
            idDiaSalida = 1
        ElseIf nombredia = "lunes" Then
            idDiaSalida = 2
        ElseIf nombredia = "martes" Then
            idDiaSalida = 3
        ElseIf nombredia = "miercoles" Then
            idDiaSalida = 4
        ElseIf nombredia = "jueves" Then
            idDiaSalida = 5
        ElseIf nombredia = "viernes" Then
            idDiaSalida = 5
        ElseIf nombredia = "sabado" Then
            idDiaSalida = 7
        End If
    End Sub



    Public Sub estadoAsientos()

        For i = 0 To 43 Step 1

            asientos(i) = "LIBRE"

        Next

    End Sub

    Public Sub cargarSalidaDiaria()

        For i = 0 To 13 Step 1

            salidasDiarias(i + 1) = conexion.retornarSalidasDiarias(i + 1)
            horasDiarias(i + 1) = conexion.retornarHoras(i + 1)

        Next
    End Sub


    Public Sub verificarSalidaActual()

        If Val(Mid(horaSistema, 1, 2)) >= 1 And Val(Mid(horaSistema, 1, 2)) <= 4 Then
            nSalidaArranca = 1
        End If
        If Val(Mid(horaSistema, 1, 2)) = 4 And Val(Mid(horaSistema, 1, 2)) > 0 And Val(Mid(horaSistema, 1, 2)) <= 15 Then
            nSalidaArranca = 1
        End If

        If Val(Mid(horaSistema, 1, 2)) = 4 And Val(Mid(horaSistema, 4, 5)) > 15 And Val(Mid(horaSistema, 4, 5)) <= 45 Then
            nSalidaArranca = 2
        End If
        If Val(Mid(horaSistema, 1, 2)) = 4 And Val(Mid(horaSistema, 4, 5)) > 45 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 3
        End If
        If Val(Mid(horaSistema, 1, 2)) = 5 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 50 Then
            nSalidaArranca = 3
        End If
        If Val(Mid(horaSistema, 1, 2)) = 5 And Val(Mid(horaSistema, 4, 5)) > 50 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 4
        End If
        If Val(Mid(horaSistema, 1, 2)) = 6 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 4
        End If
        If Val(Mid(horaSistema, 1, 2)) = 7 And Val(Mid(horaSistema, 4, 5)) = 0 Then
            nSalidaArranca = 4
        End If
        If Val(Mid(horaSistema, 1, 2)) = 7 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 45 Then
            nSalidaArranca = 5
        End If
        If Val(Mid(horaSistema, 1, 2)) = 7 And Val(Mid(horaSistema, 4, 5)) > 45 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 6
        End If
        If Val(Mid(horaSistema, 1, 2)) = 8 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 6
        End If
        If Val(Mid(horaSistema, 1, 2)) = 8 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 7
        End If
        If Val(Mid(horaSistema, 1, 2)) = 9 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 7
        End If
        If Val(Mid(horaSistema, 1, 2)) = 9 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 8
        End If
        If Val(Mid(horaSistema, 1, 2)) = 10 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 8
        End If
        If Val(Mid(horaSistema, 1, 2)) = 10 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 9
        End If
        If Val(Mid(horaSistema, 1, 2)) = 11 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 9
        End If
        If Val(Mid(horaSistema, 1, 2)) = 11 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 10
        End If
        If Val(Mid(horaSistema, 1, 2)) = 12 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 10
        End If
        If Val(Mid(horaSistema, 1, 2)) = 12 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 11
        End If
        If Val(Mid(horaSistema, 1, 2)) = 13 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 11
        End If
        If Val(Mid(horaSistema, 1, 2)) = 13 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 12
        End If
        If Val(Mid(horaSistema, 1, 2)) = 14 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 20 Then
            nSalidaArranca = 12
        End If
        If Val(Mid(horaSistema, 1, 2)) = 14 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 13
        End If
        If Val(Mid(horaSistema, 1, 2)) = 15 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 13
        End If
        If Val(Mid(horaSistema, 1, 2)) = 15 And Val(Mid(horaSistema, 4, 5)) > 30 And Val(Mid(horaSistema, 4, 5)) < 60 Then
            nSalidaArranca = 14
        End If
        If Val(Mid(horaSistema, 1, 2)) = 16 And Val(Mid(horaSistema, 4, 5)) > 0 And Val(Mid(horaSistema, 4, 5)) <= 30 Then
            nSalidaArranca = 14
        End If

    End Sub


End Module
