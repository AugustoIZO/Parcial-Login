Public Class frmLotes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles labSuperficie.Click

    End Sub

    Private Sub labLado2_Click(sender As Object, e As EventArgs) Handles labLado2.Click

    End Sub

    Private Sub labLado1_Click(sender As Object, e As EventArgs) Handles labLado1.Click

    End Sub

    Private Sub btnCalcularLote_Click(sender As Object, e As EventArgs) Handles btnCalcularLote.Click
        Dim numero1, numero2 As Single
        Dim total As Single
        numero1 = Val(txtLado1box.Text)
        numero2 = Val(txtLado2box.Text)
        total = numero1 * numero2
        txtSuperficiebox.Text = total

    End Sub
    Private Sub LimpiarTextBox()
        ' Establecer los TextBox en blanco
        txtLado1box.Text = ""
        txtLado2box.Text = ""
        txtSuperficiebox.Text = ""
    End Sub
    Private Sub frmLotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llamar a la función para limpiar los TextBox al iniciar el formulario
        LimpiarTextBox()
    End Sub

    Private Sub txtSuperficiebox_TextChanged(sender As Object, e As EventArgs) Handles txtSuperficiebox.TextChanged

    End Sub
End Class