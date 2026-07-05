<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loanComputation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlLoanComputation = New System.Windows.Forms.Panel()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.lblCustomerInformation = New System.Windows.Forms.Label()
        Me.MonthlySalary = New System.Windows.Forms.Label()
        Me.CompanyName = New System.Windows.Forms.Label()
        Me.Occupation = New System.Windows.Forms.Label()
        Me.ContactNumber = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.Label()
        Me.pnlLoanComputation.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlLoanComputation
        '
        Me.pnlLoanComputation.AutoScroll = True
        Me.pnlLoanComputation.Controls.Add(Me.MonthlySalary)
        Me.pnlLoanComputation.Controls.Add(Me.CompanyName)
        Me.pnlLoanComputation.Controls.Add(Me.Occupation)
        Me.pnlLoanComputation.Controls.Add(Me.ContactNumber)
        Me.pnlLoanComputation.Controls.Add(Me.Address)
        Me.pnlLoanComputation.Controls.Add(Me.CustomerName)
        Me.pnlLoanComputation.Controls.Add(Me.lblStep1)
        Me.pnlLoanComputation.Controls.Add(Me.lblSalary)
        Me.pnlLoanComputation.Controls.Add(Me.lblCompany)
        Me.pnlLoanComputation.Controls.Add(Me.lblOccupation)
        Me.pnlLoanComputation.Controls.Add(Me.lblContact)
        Me.pnlLoanComputation.Controls.Add(Me.lblAdd)
        Me.pnlLoanComputation.Controls.Add(Me.lblCN)
        Me.pnlLoanComputation.Controls.Add(Me.lblCustomerInformation)
        Me.pnlLoanComputation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoanComputation.Location = New System.Drawing.Point(0, 0)
        Me.pnlLoanComputation.Name = "pnlLoanComputation"
        Me.pnlLoanComputation.Size = New System.Drawing.Size(906, 708)
        Me.pnlLoanComputation.TabIndex = 1
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1.Location = New System.Drawing.Point(27, 18)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(242, 69)
        Me.lblStep1.TabIndex = 43
        Me.lblStep1.Text = "STEP 2"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(89, 588)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(142, 25)
        Me.lblSalary.TabIndex = 36
        Me.lblSalary.Text = "Monthly Salary"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(89, 518)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(154, 25)
        Me.lblCompany.TabIndex = 35
        Me.lblCompany.Text = "Company Name"
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupation.Location = New System.Drawing.Point(89, 448)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(112, 25)
        Me.lblOccupation.TabIndex = 34
        Me.lblOccupation.Text = "Occupation"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(89, 379)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(154, 25)
        Me.lblContact.TabIndex = 33
        Me.lblContact.Text = "Contact Number"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(89, 312)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(85, 25)
        Me.lblAdd.TabIndex = 32
        Me.lblAdd.Text = "Address"
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.Location = New System.Drawing.Point(89, 241)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(154, 25)
        Me.lblCN.TabIndex = 31
        Me.lblCN.Text = "Customer Name"
        '
        'lblCustomerInformation
        '
        Me.lblCustomerInformation.AutoSize = True
        Me.lblCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInformation.Location = New System.Drawing.Point(54, 122)
        Me.lblCustomerInformation.Name = "lblCustomerInformation"
        Me.lblCustomerInformation.Size = New System.Drawing.Size(393, 42)
        Me.lblCustomerInformation.TabIndex = 30
        Me.lblCustomerInformation.Text = "Customer Information"
        '
        'MonthlySalary
        '
        Me.MonthlySalary.AutoSize = True
        Me.MonthlySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthlySalary.Location = New System.Drawing.Point(293, 588)
        Me.MonthlySalary.Name = "MonthlySalary"
        Me.MonthlySalary.Size = New System.Drawing.Size(0, 25)
        Me.MonthlySalary.TabIndex = 49
        '
        'CompanyName
        '
        Me.CompanyName.AutoSize = True
        Me.CompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyName.Location = New System.Drawing.Point(293, 518)
        Me.CompanyName.Name = "CompanyName"
        Me.CompanyName.Size = New System.Drawing.Size(0, 25)
        Me.CompanyName.TabIndex = 48
        '
        'Occupation
        '
        Me.Occupation.AutoSize = True
        Me.Occupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Occupation.Location = New System.Drawing.Point(293, 448)
        Me.Occupation.Name = "Occupation"
        Me.Occupation.Size = New System.Drawing.Size(0, 25)
        Me.Occupation.TabIndex = 47
        '
        'ContactNumber
        '
        Me.ContactNumber.AutoSize = True
        Me.ContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactNumber.Location = New System.Drawing.Point(293, 379)
        Me.ContactNumber.Name = "ContactNumber"
        Me.ContactNumber.Size = New System.Drawing.Size(0, 25)
        Me.ContactNumber.TabIndex = 46
        '
        'Address
        '
        Me.Address.AutoSize = True
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(293, 312)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(0, 25)
        Me.Address.TabIndex = 45
        '
        'CustomerName
        '
        Me.CustomerName.AutoSize = True
        Me.CustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerName.Location = New System.Drawing.Point(293, 241)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(0, 25)
        Me.CustomerName.TabIndex = 44
        '
        'loanComputation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 708)
        Me.Controls.Add(Me.pnlLoanComputation)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loanComputation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loanComputation"
        Me.pnlLoanComputation.ResumeLayout(False)
        Me.pnlLoanComputation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlLoanComputation As Panel
    Friend WithEvents lblStep1 As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblOccupation As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblCN As Label
    Friend WithEvents lblCustomerInformation As Label
    Friend WithEvents MonthlySalary As Label
    Friend WithEvents CompanyName As Label
    Friend WithEvents Occupation As Label
    Friend WithEvents ContactNumber As Label
    Friend WithEvents Address As Label
    Friend WithEvents CustomerName As Label
End Class
