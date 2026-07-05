Public Class loanComputation
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCompany_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblOccupation_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblContact_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCN_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblCustomerInformation_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Address_Click(sender As Object, e As EventArgs) Handles Address.Click

    End Sub

    Private Sub pnlLoanComputation_Paint(sender As Object, e As PaintEventArgs) Handles pnlLoanComputation.Paint


    End Sub
    Private Sub LoanComputation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomerName.Text = applyLoan.txtCustomerName.Text
        Address.Text = applyLoan.txtAddress.Text
        ContactNumber.Text = applyLoan.txtContactNumber.Text
        Occupation.Text = applyLoan.txtOccupation.Text
        CompanyName.Text = applyLoan.txtCompanyName.Text
        MonthlySalary.Text = "₱" + applyLoan.txtMonthlySalary.Text
    End Sub
End Class