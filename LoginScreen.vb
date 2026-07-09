Public Class LoginScreen
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        MainMenu.Hide()
        If txtUsername.Text = "Admin" And txtPassword.Text = "Admin123" Then
            Me.Hide()
            MainMenu.Show()
            txtPassword.Text = ""
            txtUsername.Text = ""
            MsgBox("Login Successful", MsgBoxStyle.Information)
        Else
            MsgBox("Incorrect username/password. Try Again.", MsgBoxStyle.Exclamation)
            txtPassword.Text = ""
            txtUsername.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnHideShowPass.Click
        If txtPassword.UseSystemPasswordChar = True Then
            txtPassword.UseSystemPasswordChar = False
        ElseIf txtPassword.UseSystemPasswordChar = False Then
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class