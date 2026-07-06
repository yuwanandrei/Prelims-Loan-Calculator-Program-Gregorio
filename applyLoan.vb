Public Class applyLoan
    Private Sub ClearAllFields(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Clear()
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = -1
            End If

            If ctrl.HasChildren Then
                ClearAllFields(ctrl)
            End If
        Next
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblLoanAmount.Click

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles toLoanComputation.Click
        If txtCustomerName.Text = "" Or txtAddress.Text = "" Or txtContactNumber.Text = "" Or txtOccupation.Text = "" Or txtCompanyName.Text = "" Or txtMonthlySalary.Text = "" Or cboLoanType.SelectedIndex = -1 Or cboLoanTerm.SelectedIndex = -1 Or txtLoanAmount.Text = "" Then
            MessageBox.Show("Please fill in all the required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim salary As Decimal

        If Not Decimal.TryParse(txtMonthlySalary.Text, salary) Then
            MessageBox.Show("Please enter numbers only for Monthly Salary.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMonthlySalary.Focus()
            txtMonthlySalary.Clear()
            Return
        End If

        Dim Loan As Decimal

        If Not Decimal.TryParse(txtLoanAmount.Text, Loan) Then
            MessageBox.Show("Please enter numbers only for Loan Amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLoanAmount.Focus()
            txtLoanAmount.Clear()
            Return
        End If

        Dim selectedText As String = cboLoanTerm.SelectedItem.ToString()
        Dim months As Integer = Integer.Parse(selectedText.Split(" "c)(0))
        Dim monthlyAmortization As Double
        monthlyAmortization = Val(txtLoanAmount.Text) / months

        If txtMonthlySalary.Text < 20000 Then
            MessageBox.Show("Monthy Salary Must Be At Least P20,000.", "DISAPPROVED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            ClearAllFields(Me)
        ElseIf monthlyAmortization > (Val(txtMonthlySalary.Text) * 0.35) Then
            MessageBox.Show("Monthy Amortization Must Not Exceed 35% of the Customer's Monthly Salary.", "DISAPPROVED", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Hide()
            ClearAllFields(Me)
        Else
            MainMenu.switchpanel(loanComputation)
            ClearAllFields(Me)
        End If
    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblCompany_Click(sender As Object, e As EventArgs) Handles lblCompany.Click

    End Sub

    Private Sub lblOccupation_Click(sender As Object, e As EventArgs) Handles lblOccupation.Click

    End Sub

    Private Sub lblContact_Click(sender As Object, e As EventArgs) Handles lblContact.Click

    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click

    End Sub

    Private Sub lblCN_Click(sender As Object, e As EventArgs) Handles lblCN.Click

    End Sub

    Private Sub lblSalary_Click(sender As Object, e As EventArgs) Handles lblSalary.Click

    End Sub

    Private Sub lblCustomerInformation_Click(sender As Object, e As EventArgs) Handles lblCustomerInformation.Click

    End Sub

    Private Sub cboLoanTerm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanTerm.SelectedIndexChanged

    End Sub

    Private Sub lblLoanTerm_Click(sender As Object, e As EventArgs) Handles lblLoanTerm.Click

    End Sub

    Private Sub txtLoanAmount_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmount.TextChanged

    End Sub

    Private Sub lblLoanDetails_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblLoanType_Click(sender As Object, e As EventArgs) Handles lblLoanType.Click

    End Sub

    Private Sub cboLoanType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanType.SelectedIndexChanged

    End Sub

    Private Sub lblLoanInformation_Click(sender As Object, e As EventArgs) Handles lblLoanInformation.Click

    End Sub

    Private Sub txtMonthlySalary_TextChanged(sender As Object, e As EventArgs) Handles txtMonthlySalary.TextChanged

    End Sub

    Private Sub txtCompanyName_TextChanged(sender As Object, e As EventArgs) Handles txtCompanyName.TextChanged

    End Sub

    Private Sub txtOccupation_TextChanged(sender As Object, e As EventArgs) Handles txtOccupation.TextChanged

    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged

    End Sub

    Private Sub txtAddress_TextChanged(sender As Object, e As EventArgs) Handles txtAddress.TextChanged

    End Sub

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class