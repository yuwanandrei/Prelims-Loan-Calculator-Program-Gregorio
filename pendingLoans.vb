Imports System.Net

Public Class pendingLoans
    Private Sub PendingLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CNlbl.Text = loanComputation.CustomerName.Text
        Addlbl.Text = loanComputation.Address.Text
        Contactlbl.Text = loanComputation.ContactNumber.Text
        Occupationlbl.Text = loanComputation.Occupation.Text
        Companylbl.Text = loanComputation.CompanyName.Text
        Salarylbl.Text = loanComputation.MonthlySalary.Text
        Ltypelbl.Text = loanComputation.lblLoanType2.Text
        Lamountlbl.Text = loanComputation.lblLoanAmount2.Text
        Ltermlbl.Text = loanComputation.lblLoanTerm2.Text
        Interestlbl.Text = loanComputation.Interest.Text
        Totallbl.Text = loanComputation.TotalAmountPayable.Text
        Monthlylbl.Text = loanComputation.MonthlyAmortization.Text
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
End Class