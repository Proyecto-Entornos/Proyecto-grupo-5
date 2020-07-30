Public Class Login
    Dim conexion As New conexion
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If (conexion.comparar(txtusuario.Text, txtcontra.Text)) Then
            MsgBox("Exito")
        Else
            MessageBox.Show("Usuario o contraseña incorrectos.")
        End If
    End Sub
End Class
