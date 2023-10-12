Public Class frmCambio

    Private Sub btnDolar_Click(sender As Object, e As EventArgs) Handles btnCalcularDolar.Click
        Dim numero1, numero2 As Single
        Dim total
        numero1 = Val(txtCantDolarbox.Text)
        numero2 = Val(txtValDolarbox.Text)
        total = numero1 * numero2
        txtPesosAPagarbox.Text = FormatCurrency(total, 2)

        My.Computer.FileSystem.WriteAllText("C:\Users\usuario\Desktop\toro\Logica gg\Parcial login\HISTORIAL_DOLAR.txt", txtPesosAPagarbox.Text & vbCrLf, True)
    End Sub
    Private Sub frmCambio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamar a la función para limpiar los TextBox al iniciar el formulario
        LimpiarTextBox()
    End Sub
    Private Sub LimpiarTextBox()
        ' Establecer los TextBox en blanco
        txtCantDolarbox.Text = ""
        txtValDolarbox.Text = ""
        txtPesosAPagarbox.Text = ""
    End Sub

End Class