Public Class frmLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUser.Text
        Dim contraseña As String = txtPsw.Text
        If usuario = "1" AndAlso contraseña = "2" Then
            frmMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Usuario incorrecto. Inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtPsw_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub txtUser_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtUser_TextChanged_1(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class