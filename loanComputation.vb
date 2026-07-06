Imports System.Windows

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
        lblLoanType2.Text = applyLoan.cboLoanType.SelectedItem.ToString()
        lblLoanAmount2.Text = "₱" + applyLoan.txtLoanAmount.Text
        lblLoanTerm2.Text = applyLoan.cboLoanTerm.SelectedItem.ToString()

        Dim loanAmount As Double = Convert.ToDouble(applyLoan.txtLoanAmount.Text)
        Dim selectedText As String = applyLoan.cboLoanTerm.SelectedItem.ToString()
        Dim loanTerm As Integer = Integer.Parse(selectedText.Split(" "c)(0))

        If applyLoan.cboLoanType.SelectedItem.ToString() = "Personal Loan" Then
            Dim interestRate As Double = 0.1
            Dim monthlyPayment As Double = (loanAmount * (1 + interestRate)) / loanTerm
            Dim Total As Double = monthlyPayment * loanTerm
            MonthlyAmortization.Text = "₱" + monthlyPayment.ToString("F2")
            Interest.Text = "10%"
            TotalAmountPayable.Text = "₱" + Total.ToString("F2")

        ElseIf applyLoan.cboLoanType.SelectedItem.ToString() = "Appliance Loan" Then
            Dim interestRate As Double = 0.08
            Dim monthlyPayment As Double = (loanAmount * (1 + interestRate)) / loanTerm
            Dim Total As Double = monthlyPayment * loanTerm
            MonthlyAmortization.Text = "₱" + monthlyPayment.ToString("F2")
            Interest.Text = "8%"
            TotalAmountPayable.Text = "₱" + Total.ToString("F2")

        ElseIf applyLoan.cboLoanType.SelectedItem.ToString() = "Gadget Loan" Then
            Dim interestRate As Double = 0.12
            Dim monthlyPayment As Double = (loanAmount * (1 + interestRate)) / loanTerm
            Dim Total As Double = monthlyPayment * loanTerm
            MonthlyAmortization.Text = "₱" + monthlyPayment.ToString("F2")
            Interest.Text = "12%"
            TotalAmountPayable.Text = "₱" + Total.ToString("F2")

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblLoanType.Click

    End Sub

    Private Sub GenerateLoanCode()
        Dim loanCode As String = "LN-" & DateTime.Now.ToString("yyyyMMddHHmmss")
        pendingLoans.lblLoanCode.Text = loanCode
    End Sub


    Private Sub toLoanComputation_Click(sender As Object, e As EventArgs) Handles toLoanComputation.Click
        GenerateLoanCode()
        MessageBox.Show("Loan Approved. Check Pending Loans For More Information.", "APPROVED", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()

    End Sub
    Private Sub lblCN_Click_1(sender As Object, e As EventArgs) Handles lblCN.Click

    End Sub

    Private Sub lblAdd_Click_1(sender As Object, e As EventArgs) Handles lblAdd.Click

    End Sub

    Private Sub lblContact_Click_1(sender As Object, e As EventArgs) Handles lblContact.Click

    End Sub

    Private Sub lblOccupation_Click_1(sender As Object, e As EventArgs) Handles lblOccupation.Click

    End Sub

    Private Sub lblCompany_Click_1(sender As Object, e As EventArgs) Handles lblCompany.Click

    End Sub

    Private Sub lblSalary_Click_1(sender As Object, e As EventArgs) Handles lblSalary.Click

    End Sub
End Class