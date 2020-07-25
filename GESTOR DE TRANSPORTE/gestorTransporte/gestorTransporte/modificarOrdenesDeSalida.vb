Public Class modificarOrdenesDeSalida
    Dim conexion As conexion = New conexion()

    Dim temporalSalida1 As String
    Dim temporalSalida2 As String
    Dim temporalSalida3 As String
    Dim temporalSalida4 As String
    Dim temporalSalida5 As String
    Dim temporalSalida6 As String
    Dim temporalSalida7 As String
    Dim temporalSalida8 As String
    Dim temporalSalida9 As String
    Dim temporalSalida10 As String
    Dim temporalSalida11 As String
    Dim temporalSalida12 As String
    Dim temporalSalida13 As String
    Dim temporalSalida14 As String


    Private Sub modificarOrdenesDeSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            txtIdSalida.Text = idDiaSalida

            cmbBus1.Items.Add("<SELECCIONE>")
            cmbBus2.Items.Add("<SELECCIONE>")
            cmbBus3.Items.Add("<SELECCIONE>")
            cmbBus4.Items.Add("<SELECCIONE>")
            cmbBus5.Items.Add("<SELECCIONE>")
            cmbBus6.Items.Add("<SELECCIONE>")
            cmbBus7.Items.Add("<SELECCIONE>")
            cmbBus8.Items.Add("<SELECCIONE>")
            cmbBus9.Items.Add("<SELECCIONE>")
            cmbBus10.Items.Add("<SELECCIONE>")
            cmbBus11.Items.Add("<SELECCIONE>")
            cmbBus12.Items.Add("<SELECCIONE>")
            cmbBus13.Items.Add("<SELECCIONE>")
            cmbBus14.Items.Add("<SELECCIONE>")


            temporalSalida1 = (salidasDiarias(1))
            temporalSalida2 = (salidasDiarias(2))
            temporalSalida3 = (salidasDiarias(3))
            temporalSalida4 = (salidasDiarias(4))
            temporalSalida5 = (salidasDiarias(5))
            temporalSalida6 = (salidasDiarias(6))
            temporalSalida7 = (salidasDiarias(7))
            temporalSalida8 = (salidasDiarias(8))
            temporalSalida9 = (salidasDiarias(9))
            temporalSalida10 = (salidasDiarias(10))
            temporalSalida11 = (salidasDiarias(11))
            temporalSalida12 = (salidasDiarias(12))
            temporalSalida13 = (salidasDiarias(13))
            temporalSalida14 = (salidasDiarias(14))


            For i = 0 To 13 Step 1
                llenarBusesDisp(i + 1)
            Next
            seleccionarBus()


            btnModificar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub seleccionarBus()
        Try


            cmbBus1.SelectedIndex = cmbBus1.Items.Count - 1
            txtDetallesBus1.Text = conexion.retornarDatosAutobus(salidasDiarias(1), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(1), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(1), 2)

            cmbBus2.SelectedIndex = cmbBus2.Items.Count - 1
            txtDetallesBus2.Text = conexion.retornarDatosAutobus(salidasDiarias(2), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(2), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(2), 2)

            cmbBus3.SelectedIndex = cmbBus3.Items.Count - 1
            txtDetallesBus3.Text = conexion.retornarDatosAutobus(salidasDiarias(3), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(3), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(3), 2)

            cmbBus4.SelectedIndex = cmbBus4.Items.Count - 1
            txtDetallesBus4.Text = conexion.retornarDatosAutobus(salidasDiarias(4), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(4), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(4), 2)

            cmbBus5.SelectedIndex = cmbBus5.Items.Count - 1
            txtDetallesBus5.Text = conexion.retornarDatosAutobus(salidasDiarias(5), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(5), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(5), 2)

            cmbBus6.SelectedIndex = cmbBus6.Items.Count - 1
            txtDetallesBus6.Text = conexion.retornarDatosAutobus(salidasDiarias(6), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(6), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(6), 2)

            cmbBus7.SelectedIndex = cmbBus7.Items.Count - 1
            txtDetallesBus7.Text = conexion.retornarDatosAutobus(salidasDiarias(7), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(7), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(7), 2)

            cmbBus8.SelectedIndex = cmbBus8.Items.Count - 1
            txtDetallesBus8.Text = conexion.retornarDatosAutobus(salidasDiarias(8), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(8), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(8), 2)

            cmbBus9.SelectedIndex = cmbBus9.Items.Count - 1
            txtDetallesBus9.Text = conexion.retornarDatosAutobus(salidasDiarias(9), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(9), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(9), 2)

            cmbBus10.SelectedIndex = cmbBus10.Items.Count - 1
            txtDetallesBus10.Text = conexion.retornarDatosAutobus(salidasDiarias(10), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(10), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(10), 2)

            cmbBus11.SelectedIndex = cmbBus11.Items.Count - 1
            txtDetallesBus11.Text = conexion.retornarDatosAutobus(salidasDiarias(11), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(11), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(11), 2)

            cmbBus12.SelectedIndex = cmbBus12.Items.Count - 1
            txtDetallesBus12.Text = conexion.retornarDatosAutobus(salidasDiarias(12), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(12), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(12), 2)

            cmbBus13.SelectedIndex = cmbBus13.Items.Count - 1
            txtDetallesBus13.Text = conexion.retornarDatosAutobus(salidasDiarias(13), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(13), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(13), 2)

            cmbBus14.SelectedIndex = cmbBus14.Items.Count - 1
            txtDetallesBus14.Text = conexion.retornarDatosAutobus(salidasDiarias(14), 0) & ", " & conexion.retornarDatosAutobus(salidasDiarias(14), 1) & ", " & conexion.retornarDatosAutobus(salidasDiarias(14), 2)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub deleteBus1_Click(sender As Object, e As EventArgs) Handles deleteBus1.Click

        cmbBus1.Enabled = True
        btnReturn1.Enabled = True

        llenarBusesDisp(1)

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False


        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True




    End Sub

    Private Sub deleteBus2_Click(sender As Object, e As EventArgs) Handles deleteBus2.Click


        cmbBus2.Enabled = True
        btnReturn2.Enabled = True

        llenarBusesDisp(2)
        cmbBus2.SelectedIndex = 0
        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False


        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True

    End Sub

    Private Sub deleteBus3_Click(sender As Object, e As EventArgs) Handles deleteBus3.Click


        cmbBus3.Enabled = True
        btnReturn3.Enabled = True

        cmbBus3.SelectedIndex = 0


        llenarBusesDisp(3)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus4_Click(sender As Object, e As EventArgs) Handles deleteBus4.Click

        cmbBus4.Enabled = True
        btnReturn4.Enabled = True

        cmbBus4.SelectedIndex = 0


        llenarBusesDisp(4)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus5_Click(sender As Object, e As EventArgs) Handles deleteBus5.Click


        cmbBus5.Enabled = True
        btnReturn5.Enabled = True

        cmbBus5.SelectedIndex = 0

        llenarBusesDisp(5)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus6_Click(sender As Object, e As EventArgs) Handles deleteBus6.Click


        cmbBus6.Enabled = True
        btnReturn6.Enabled = True

        cmbBus6.SelectedIndex = 0

        llenarBusesDisp(6)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus7_Click(sender As Object, e As EventArgs) Handles deleteBus7.Click


        cmbBus7.Enabled = True
        btnReturn7.Enabled = True

        cmbBus7.SelectedIndex = 0

        llenarBusesDisp(7)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus8_Click(sender As Object, e As EventArgs) Handles deleteBus8.Click

        cmbBus8.Enabled = True
        btnReturn8.Enabled = True

        cmbBus8.SelectedIndex = 0

        llenarBusesDisp(8)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus9_Click(sender As Object, e As EventArgs) Handles deleteBus9.Click


        cmbBus9.Enabled = True
        btnReturn9.Enabled = True

        cmbBus9.SelectedIndex = 0

        llenarBusesDisp(9)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus10_Click(sender As Object, e As EventArgs) Handles deleteBus10.Click

        cmbBus10.Enabled = True
        btnReturn10.Enabled = True

        cmbBus10.SelectedIndex = 0

        llenarBusesDisp(10)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus11_Click(sender As Object, e As EventArgs) Handles deleteBus11.Click


        cmbBus11.Enabled = True
        btnReturn11.Enabled = True

        cmbBus11.SelectedIndex = 0

        llenarBusesDisp(11)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus12_Click(sender As Object, e As EventArgs) Handles deleteBus12.Click


        cmbBus12.Enabled = True
        btnReturn12.Enabled = True

        cmbBus12.SelectedIndex = 0

        llenarBusesDisp(12)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus13_Click(sender As Object, e As EventArgs) Handles deleteBus13.Click


        cmbBus13.Enabled = True
        btnReturn13.Enabled = True

        cmbBus13.SelectedIndex = 0

        llenarBusesDisp(13)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        cmbBus14.Enabled = False
        deleteBus14.Enabled = False
        btnReturn14.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub deleteBus14_Click(sender As Object, e As EventArgs) Handles deleteBus14.Click


        cmbBus14.Enabled = True
        btnReturn14.Enabled = True

        cmbBus14.SelectedIndex = 0

        llenarBusesDisp(14)

        cmbBus1.Enabled = False
        deleteBus1.Enabled = False
        btnReturn1.Enabled = False

        cmbBus2.Enabled = False
        deleteBus2.Enabled = False
        btnReturn2.Enabled = False

        cmbBus4.Enabled = False
        deleteBus4.Enabled = False
        btnReturn4.Enabled = False

        cmbBus3.Enabled = False
        deleteBus3.Enabled = False
        btnReturn3.Enabled = False

        cmbBus6.Enabled = False
        deleteBus6.Enabled = False
        btnReturn6.Enabled = False

        cmbBus7.Enabled = False
        deleteBus7.Enabled = False
        btnReturn7.Enabled = False

        cmbBus8.Enabled = False
        deleteBus8.Enabled = False
        btnReturn8.Enabled = False

        cmbBus9.Enabled = False
        deleteBus9.Enabled = False
        btnReturn9.Enabled = False

        cmbBus10.Enabled = False
        deleteBus10.Enabled = False
        btnReturn10.Enabled = False

        cmbBus11.Enabled = False
        deleteBus11.Enabled = False
        btnReturn11.Enabled = False

        cmbBus12.Enabled = False
        deleteBus12.Enabled = False
        btnReturn12.Enabled = False

        cmbBus13.Enabled = False
        deleteBus13.Enabled = False
        btnReturn13.Enabled = False

        cmbBus5.Enabled = False
        deleteBus5.Enabled = False
        btnReturn5.Enabled = False

        btnModificar.Enabled = True
    End Sub

    Private Sub llenarBusesDisp(ByVal numeroID As Integer)


        Select Case numeroID
            Case 1
                conexion.llenarBusesDisponibles()
                cmbBus1.DataSource = conexion.ds.Tables("autobuses")
                cmbBus1.DisplayMember = "matricula"
                cmbBus1.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus1.DataSource

                dt.Rows.Add(temporalSalida1)

                cmbBus1.DataSource = dt

            Case 2
                conexion.llenarBusesDisponibles()
                cmbBus2.DataSource = conexion.ds.Tables("autobuses")
                cmbBus2.DisplayMember = "matricula"
                cmbBus2.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus2.DataSource

                dt.Rows.Add(temporalSalida2)

                cmbBus2.DataSource = dt

            Case 3
                conexion.llenarBusesDisponibles()
                cmbBus3.DataSource = conexion.ds.Tables("autobuses")
                cmbBus3.DisplayMember = "matricula"
                cmbBus3.ValueMember = "matricula"


                Dim dt As DataTable = cmbBus3.DataSource

                dt.Rows.Add(temporalSalida3)

                cmbBus3.DataSource = dt

            Case 4
                conexion.llenarBusesDisponibles()
                cmbBus4.DataSource = conexion.ds.Tables("autobuses")
                cmbBus4.DisplayMember = "matricula"
                cmbBus4.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus4.DataSource

                dt.Rows.Add(temporalSalida4)
                cmbBus4.DataSource = dt



            Case 5
                conexion.llenarBusesDisponibles()
                cmbBus5.DataSource = conexion.ds.Tables("autobuses")
                cmbBus5.DisplayMember = "matricula"
                cmbBus5.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus5.DataSource

                dt.Rows.Add(temporalSalida5)

                cmbBus5.DataSource = dt

            Case 6
                conexion.llenarBusesDisponibles()
                cmbBus6.DataSource = conexion.ds.Tables("autobuses")
                cmbBus6.DisplayMember = "matricula"
                cmbBus6.ValueMember = "matricula"


                Dim dt As DataTable = cmbBus6.DataSource

                dt.Rows.Add(temporalSalida6)

                cmbBus6.DataSource = dt

            Case 7
                conexion.llenarBusesDisponibles()
                cmbBus7.DataSource = conexion.ds.Tables("autobuses")
                cmbBus7.DisplayMember = "matricula"
                cmbBus7.ValueMember = "matricula"


                Dim dt As DataTable = cmbBus7.DataSource

                dt.Rows.Add(temporalSalida7)

                cmbBus7.DataSource = dt

            Case 8
                conexion.llenarBusesDisponibles()
                cmbBus8.DataSource = conexion.ds.Tables("autobuses")
                cmbBus8.DisplayMember = "matricula"
                cmbBus8.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus8.DataSource

                dt.Rows.Add(temporalSalida8)

                cmbBus8.DataSource = dt

            Case 9
                conexion.llenarBusesDisponibles()
                cmbBus9.DataSource = conexion.ds.Tables("autobuses")
                cmbBus9.DisplayMember = "matricula"
                cmbBus9.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus9.DataSource

                dt.Rows.Add(temporalSalida9)

                cmbBus9.DataSource = dt


            Case 10
                conexion.llenarBusesDisponibles()
                cmbBus10.DataSource = conexion.ds.Tables("autobuses")
                cmbBus10.DisplayMember = "matricula"
                cmbBus10.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus10.DataSource

                dt.Rows.Add(temporalSalida10)

                cmbBus10.DataSource = dt

            Case 11
                conexion.llenarBusesDisponibles()
                cmbBus11.DataSource = conexion.ds.Tables("autobuses")
                cmbBus11.DisplayMember = "matricula"
                cmbBus11.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus11.DataSource

                dt.Rows.Add(temporalSalida11)

                cmbBus11.DataSource = dt


            Case 12
                conexion.llenarBusesDisponibles()
                cmbBus12.DataSource = conexion.ds.Tables("autobuses")
                cmbBus12.DisplayMember = "matricula"
                cmbBus12.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus12.DataSource

                dt.Rows.Add(temporalSalida12)

                cmbBus12.DataSource = dt

            Case 13
                conexion.llenarBusesDisponibles()
                cmbBus13.DataSource = conexion.ds.Tables("autobuses")
                cmbBus13.DisplayMember = "matricula"
                cmbBus13.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus13.DataSource

                dt.Rows.Add(temporalSalida13)

                cmbBus13.DataSource = dt

            Case 14
                conexion.llenarBusesDisponibles()
                cmbBus14.DataSource = conexion.ds.Tables("autobuses")
                cmbBus14.DisplayMember = "matricula"
                cmbBus14.ValueMember = "matricula"

                Dim dt As DataTable = cmbBus14.DataSource

                dt.Rows.Add(temporalSalida14)

                cmbBus14.DataSource = dt

        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub txtDetallesBus4_TextChanged(sender As Object, e As EventArgs) Handles txtDetallesBus4.TextChanged

    End Sub

    Private Sub activarModificacion_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReturn1_Click(sender As Object, e As EventArgs) Handles btnReturn1.Click
        Try
            Me.cmbBus1.DataSource = Nothing
            cmbBus1.DisplayMember = Nothing
            cmbBus1.ValueMember = Nothing

            cmbBus1.Items.Add(temporalSalida1)
            cmbBus1.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click
        Try
            Me.cmbBus2.DataSource = Nothing
            cmbBus2.DisplayMember = Nothing
            cmbBus2.ValueMember = Nothing

            cmbBus2.Items.Add(temporalSalida2)
            cmbBus2.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn3_Click(sender As Object, e As EventArgs) Handles btnReturn3.Click
        Try
            Me.cmbBus3.DataSource = Nothing
            cmbBus3.DisplayMember = Nothing
            cmbBus3.ValueMember = Nothing

            cmbBus3.Items.Add(temporalSalida3)
            cmbBus3.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn4_Click(sender As Object, e As EventArgs) Handles btnReturn4.Click
        Try
            Me.cmbBus4.DataSource = Nothing
            cmbBus4.DisplayMember = Nothing
            cmbBus4.ValueMember = Nothing

            cmbBus4.Items.Add(temporalSalida4)
            cmbBus4.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn5_Click(sender As Object, e As EventArgs) Handles btnReturn5.Click
        Try
            Me.cmbBus5.DataSource = Nothing
            cmbBus5.DisplayMember = Nothing
            cmbBus5.ValueMember = Nothing

            cmbBus5.Items.Add(temporalSalida5)
            cmbBus5.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn6_Click(sender As Object, e As EventArgs) Handles btnReturn6.Click
        Try
            Me.cmbBus6.DataSource = Nothing
            cmbBus6.DisplayMember = Nothing
            cmbBus6.ValueMember = Nothing

            cmbBus6.Items.Add(temporalSalida6)
            cmbBus6.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnReturn7_Click(sender As Object, e As EventArgs) Handles btnReturn7.Click

        Try
            Me.cmbBus7.DataSource = Nothing
            cmbBus7.DisplayMember = Nothing
            cmbBus7.ValueMember = Nothing

            cmbBus7.Items.Add(temporalSalida7)
            cmbBus7.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn8_Click(sender As Object, e As EventArgs) Handles btnReturn8.Click

        Try
            Me.cmbBus8.DataSource = Nothing
            cmbBus8.DisplayMember = Nothing
            cmbBus8.ValueMember = Nothing

            cmbBus8.Items.Add(temporalSalida8)
            cmbBus8.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn9_Click(sender As Object, e As EventArgs) Handles btnReturn9.Click

        Try
            Me.cmbBus9.DataSource = Nothing
            cmbBus9.DisplayMember = Nothing
            cmbBus9.ValueMember = Nothing

            cmbBus9.Items.Add(temporalSalida9)
            cmbBus9.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn10_Click(sender As Object, e As EventArgs) Handles btnReturn10.Click

        Try
            Me.cmbBus10.DataSource = Nothing
            cmbBus10.DisplayMember = Nothing
            cmbBus10.ValueMember = Nothing

            cmbBus10.Items.Add(temporalSalida10)
            cmbBus10.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn11_Click(sender As Object, e As EventArgs) Handles btnReturn11.Click

        Try
            Me.cmbBus11.DataSource = Nothing
            cmbBus11.DisplayMember = Nothing
            cmbBus11.ValueMember = Nothing

            cmbBus11.Items.Add(temporalSalida11)
            cmbBus11.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn12_Click(sender As Object, e As EventArgs) Handles btnReturn12.Click
        Try
            Me.cmbBus12.DataSource = Nothing
            cmbBus12.DisplayMember = Nothing
            cmbBus12.ValueMember = Nothing

            cmbBus12.Items.Add(temporalSalida12)
            cmbBus12.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn13_Click(sender As Object, e As EventArgs) Handles btnReturn13.Click

        Try
            Me.cmbBus13.DataSource = Nothing
            cmbBus13.DisplayMember = Nothing
            cmbBus13.ValueMember = Nothing

            cmbBus13.Items.Add(temporalSalida13)
            cmbBus13.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReturn14_Click(sender As Object, e As EventArgs) Handles btnReturn14.Click
        Try
            Me.cmbBus14.DataSource = Nothing
            cmbBus14.DisplayMember = Nothing
            cmbBus14.ValueMember = Nothing

            cmbBus14.Items.Add(temporalSalida2)
            cmbBus14.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try



            If conexion.modificarSalidaDiaria(Val(txtIdSalida.Text), cmbBus1.SelectedValue, cmbBus2.SelectedValue, cmbBus3.SelectedValue, cmbBus4.SelectedValue, cmbBus5.SelectedValue, cmbBus6.SelectedValue, cmbBus7.SelectedValue,
                                              cmbBus8.SelectedValue, cmbBus9.SelectedValue, cmbBus10.SelectedValue, cmbBus11.SelectedValue, cmbBus12.SelectedValue, cmbBus13.SelectedValue, cmbBus14.SelectedValue) Then

                MsgBox("ACTUALIZADO!", vbInformation)
                cargarSalidaDiaria()
                bloquearInterfaz()
            Else

                MsgBox("ERROR!", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub bloquearInterfaz()

        cmbBus1.Enabled = False
        cmbBus2.Enabled = False
        cmbBus3.Enabled = False
        cmbBus4.Enabled = False
        cmbBus5.Enabled = False
        cmbBus6.Enabled = False
        cmbBus7.Enabled = False
        cmbBus8.Enabled = False
        cmbBus9.Enabled = False
        cmbBus10.Enabled = False
        cmbBus11.Enabled = False
        cmbBus12.Enabled = False
        cmbBus13.Enabled = False
        cmbBus14.Enabled = False

        btnReturn1.Enabled = False
        btnReturn2.Enabled = False
        btnReturn3.Enabled = False
        btnReturn4.Enabled = False
        btnReturn5.Enabled = False
        btnReturn6.Enabled = False
        btnReturn7.Enabled = False
        btnReturn8.Enabled = False
        btnReturn9.Enabled = False
        btnReturn10.Enabled = False
        btnReturn11.Enabled = False
        btnReturn12.Enabled = False
        btnReturn13.Enabled = False
        btnReturn14.Enabled = False


        deleteBus1.Enabled = True
        deleteBus2.Enabled = True
        deleteBus3.Enabled = True
        deleteBus4.Enabled = True
        deleteBus5.Enabled = True
        deleteBus6.Enabled = True
        deleteBus7.Enabled = True
        deleteBus8.Enabled = True
        deleteBus9.Enabled = True
        deleteBus10.Enabled = True
        deleteBus11.Enabled = True
        deleteBus12.Enabled = True
        deleteBus13.Enabled = True
        deleteBus14.Enabled = True


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtIdSalida.TextChanged

    End Sub
End Class