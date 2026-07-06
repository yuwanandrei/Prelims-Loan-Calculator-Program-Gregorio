Public Class MainMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the program?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Hide()
            LoginScreen.Show()
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
        If String.IsNullOrEmpty(pendingLoans.lblLoanCode.Text) Then
            switchpanel(applyLoan)
        Else
            MessageBox.Show("Please Settle Your Loan First Before Applying Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnViewPendingLoan_Click(sender As Object, e As EventArgs) Handles btnViewPendingLoan.Click
        If String.IsNullOrEmpty(pendingLoans.lblLoanCode.Text) Then
            MessageBox.Show("You Currenly Have No Pending Loans.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            switchpanel(pendingLoans)
        End If

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        switchpanel(About)
    End Sub
End Class