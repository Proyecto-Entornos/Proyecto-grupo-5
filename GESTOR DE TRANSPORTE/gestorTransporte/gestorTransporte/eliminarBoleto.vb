Public Class eliminarBoleto
    Dim conexion As conexion = New conexion()
    Dim codigoTemp As String
    Dim tipoBoleto As Integer = 0
    Dim numeroAsiento As Integer

    Private Sub eliminarBoleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEliminar.Enabled = True
        conexion.Consulta("SELECT * FROM boleteria WHERE fecha = '" & moduloTimers.fechaActual & "' AND noSalida = " & moduloTimers.temporalSalidaActual & "", "data")
        dgvBoleto.DataSource = conexion.ds.Tables("data")
        llenarBoleteria()
        cargarDestinosCMB()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        ventaBoletos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try

            If conexion.eliminarBoleto(cmbBoletos.SelectedValue) Then
                MsgBox("ELIMINADO", vbInformation)
            Else
                MsgBox("ERROR INESPERADO", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub llenarBoleteria()
        conexion.llenarBoletos()
        cmbBoletos.DataSource = conexion.ds.Tables("boleteria")
        cmbBoletos.DisplayMember = "codigoBoleto"
        cmbBoletos.ValueMember = "codigoBoleto"
    End Sub


    Private Sub cargarDestinosCMB()

        cmbDestino.Items.Add("<SELECCIONE>")
        cmbDestino.SelectedIndex = 0
        For i = 0 To 1 Step 1

            cmbDestino.Items.Add(conexion.cargarDestinos(i + 1))

        Next


    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        Try
            tipoBoleto = conexion.retornarTipoBoleto(cmbBoletos.SelectedValue)


            If tipoBoleto = 1 Then

                For i = 0 To 2 Step 1
                    Select Case i
                        Case 0
                            numeroAsiento = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 0)
                            If numeroAsiento < 9 And numeroAsiento > 0 Then
                                mskNoAsiento.Text = "0" & numeroAsiento
                            Else
                                mskNoAsiento.Text = numeroAsiento
                            End If
                        Case 1
                            cmbDestino.SelectedItem = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 1)
                        Case 2
                            txtPrecioBoleto.Text = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 2)

                    End Select


                Next

            ElseIf tipoBoleto = 2 Then
                For i = 0 To 4 Step 1
                    Select Case i
                        Case 0
                            numeroAsiento = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 0)
                            If numeroAsiento <= 9 And numeroAsiento > 0 Then
                                mskNoAsiento.Text = "0" & numeroAsiento
                            Else
                                mskNoAsiento.Text = numeroAsiento
                            End If
                        Case 3
                            txtOtroDestino.Text = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 3)
                        Case 4
                            txtPrecioBoleto.Text = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 4)

                    End Select


                Next
                cmbDestino.SelectedIndex = 0
                chkOtroDestino.Checked = True

            End If
            cmbDestino.SelectedItem = conexion.retornarDatosBoleto(cmbBoletos.SelectedValue, 1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkOtroDestino_CheckedChanged(sender As Object, e As EventArgs) Handles chkOtroDestino.CheckedChanged
        If chkOtroDestino.Checked = True Then
            cmbDestino.SelectedIndex = 0
            cmbDestino.Enabled = False
            txtOtroDestino.Enabled = True
            txtPrecioBoleto.ReadOnly = False
        Else
            txtOtroDestino.Clear()
            cmbDestino.Enabled = True
            txtOtroDestino.Enabled = False
            txtPrecioBoleto.ReadOnly = True
        End If

    End Sub

    Private Sub mskNoAsiento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskNoAsiento.MaskInputRejected

    End Sub

    Private Sub mskNoAsiento_TextChanged(sender As Object, e As EventArgs) Handles mskNoAsiento.TextChanged
        If mskNoAsiento.Text <> String.Empty Then

            If Val(mskNoAsiento.Text) > 0 And Val(mskNoAsiento.Text) < 45 And Val(mskNoAsiento.Text) <> Val(conexion.retornarAsientoBoleto(cmbBoletos.SelectedValue)) Then

                If moduloTimers.asientos(Val(mskNoAsiento.Text)) <> "OCUPADO" Then
                    mskNoAsiento.ForeColor = Color.Green

                Else

                        mskNoAsiento.ForeColor = Color.Red
                End If

            ElseIf Val(mskNoAsiento.Text) = Val(conexion.retornarAsientoBoleto(cmbBoletos.SelectedValue)) Then
                mskNoAsiento.ForeColor = Color.Green

            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim temporalPrecio As Integer
        Dim temporalDestino As Integer
        Dim tipoBoletoNuevo As Integer

        Try

            If mskNoAsiento.MaskCompleted = True And txtPrecioBoleto.Text <> String.Empty And (cmbDestino.SelectedIndex <> 0 Or txtOtroDestino.Text <> String.Empty) Then

                If cmbDestino.SelectedIndex = 0 Then

                    temporalPrecio = Val(txtPrecioBoleto.Text)
                    tipoBoletoNuevo = 2
                Else
                    temporalDestino = cmbDestino.SelectedIndex
                    temporalPrecio = 0
                    tipoBoletoNuevo = 1

                End If

                If conexion.modificarBoletos(tipoBoletoNuevo, cmbBoletos.SelectedValue, mskNoAsiento.Text, temporalDestino, temporalPrecio, txtOtroDestino.Text) Then
                    MsgBox("BOLETO MODIFICADO!", vbInformation)
                Else
                    MsgBox("Error Inesperado", vbCritical)
                End If

            Else
                MsgBox("REVISE LOS DATOS DEL BOLETO!", vbCritical)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDestino.SelectedIndexChanged
        If cmbDestino.SelectedIndex <> 0 Then
            txtPrecioBoleto.Text = conexion.retornarTarifa(cmbDestino.SelectedIndex)

            txtOtroDestino.Enabled = False
            txtOtroDestino.Clear()

        Else
            'txtPrecioBoleto.Clear()

        End If
    End Sub
End Class