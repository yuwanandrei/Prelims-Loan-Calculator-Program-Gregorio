Public Class Form2
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit Program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            Form1.Show()
            mainPanel.Controls.Clear()
        End If
    End Sub

    Private Sub RichTextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint

    End Sub
    Sub switchpanel(ByVal panel As Form)
        mainPanel.Controls.Clear()
        panel.TopLevel = False
        mainPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnApplyLoan_Click(sender As Object, e As EventArgs) Handles btnApplyLoan.Click
        switchpanel(applyLoan)
    End Sub
End Class