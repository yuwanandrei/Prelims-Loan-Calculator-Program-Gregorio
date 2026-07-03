<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class applyLoan
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLoanDetails = New System.Windows.Forms.Label()
        Me.lblLoanType = New System.Windows.Forms.Label()
        Me.cboLoanType = New System.Windows.Forms.ComboBox()
        Me.lblLoanInformation = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.lblOccupation = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.lblCustomerInformation = New System.Windows.Forms.Label()
        Me.txtMonthlySalary = New System.Windows.Forms.TextBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.lblLoanTerm = New System.Windows.Forms.Label()
        Me.cboLoanTerm = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.cboLoanTerm)
        Me.Panel1.Controls.Add(Me.lblLoanTerm)
        Me.Panel1.Controls.Add(Me.lblLoanAmount)
        Me.Panel1.Controls.Add(Me.txtLoanAmount)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.lblLoanDetails)
        Me.Panel1.Controls.Add(Me.lblLoanType)
        Me.Panel1.Controls.Add(Me.cboLoanType)
        Me.Panel1.Controls.Add(Me.lblLoanInformation)
        Me.Panel1.Controls.Add(Me.lblSalary)
        Me.Panel1.Controls.Add(Me.lblCompany)
        Me.Panel1.Controls.Add(Me.lblOccupation)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.lblAdd)
        Me.Panel1.Controls.Add(Me.lblCN)
        Me.Panel1.Controls.Add(Me.lblCustomerInformation)
        Me.Panel1.Controls.Add(Me.txtMonthlySalary)
        Me.Panel1.Controls.Add(Me.txtCompanyName)
        Me.Panel1.Controls.Add(Me.txtOccupation)
        Me.Panel1.Controls.Add(Me.txtContactNumber)
        Me.Panel1.Controls.Add(Me.txtAddress)
        Me.Panel1.Controls.Add(Me.txtCustomerName)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(906, 708)
        Me.Panel1.TabIndex = 0
        '
        'lblLoanDetails
        '
        Me.lblLoanDetails.AutoSize = True
        Me.lblLoanDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanDetails.Location = New System.Drawing.Point(48, 927)
        Me.lblLoanDetails.Name = "lblLoanDetails"
        Me.lblLoanDetails.Size = New System.Drawing.Size(238, 42)
        Me.lblLoanDetails.TabIndex = 33
        Me.lblLoanDetails.Text = "Loan Details"
        '
        'lblLoanType
        '
        Me.lblLoanType.AutoSize = True
        Me.lblLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanType.Location = New System.Drawing.Point(83, 724)
        Me.lblLoanType.Name = "lblLoanType"
        Me.lblLoanType.Size = New System.Drawing.Size(218, 25)
        Me.lblLoanType.TabIndex = 32
        Me.lblLoanType.Text = "Please select loan type:"
        '
        'cboLoanType
        '
        Me.cboLoanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanType.FormattingEnabled = True
        Me.cboLoanType.Items.AddRange(New Object() {"Personal Loan", "Appliance Loan", "Gadget Loan"})
        Me.cboLoanType.Location = New System.Drawing.Point(88, 777)
        Me.cboLoanType.Name = "cboLoanType"
        Me.cboLoanType.Size = New System.Drawing.Size(393, 33)
        Me.cboLoanType.TabIndex = 31
        '
        'lblLoanInformation
        '
        Me.lblLoanInformation.AutoSize = True
        Me.lblLoanInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanInformation.Location = New System.Drawing.Point(48, 657)
        Me.lblLoanInformation.Name = "lblLoanInformation"
        Me.lblLoanInformation.Size = New System.Drawing.Size(312, 42)
        Me.lblLoanInformation.TabIndex = 30
        Me.lblLoanInformation.Text = "Loan Information"
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalary.Location = New System.Drawing.Point(83, 512)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(68, 25)
        Me.lblSalary.TabIndex = 29
        Me.lblSalary.Text = "Salary"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(83, 442)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(154, 25)
        Me.lblCompany.TabIndex = 28
        Me.lblCompany.Text = "Company Name"
        '
        'lblOccupation
        '
        Me.lblOccupation.AutoSize = True
        Me.lblOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOccupation.Location = New System.Drawing.Point(83, 372)
        Me.lblOccupation.Name = "lblOccupation"
        Me.lblOccupation.Size = New System.Drawing.Size(112, 25)
        Me.lblOccupation.TabIndex = 27
        Me.lblOccupation.Text = "Occupation"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(83, 303)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(154, 25)
        Me.lblContact.TabIndex = 26
        Me.lblContact.Text = "Contact Number"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdd.Location = New System.Drawing.Point(83, 236)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(85, 25)
        Me.lblAdd.TabIndex = 25
        Me.lblAdd.Text = "Address"
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.Location = New System.Drawing.Point(83, 165)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(154, 25)
        Me.lblCN.TabIndex = 24
        Me.lblCN.Text = "Customer Name"
        '
        'lblCustomerInformation
        '
        Me.lblCustomerInformation.AutoSize = True
        Me.lblCustomerInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerInformation.Location = New System.Drawing.Point(48, 46)
        Me.lblCustomerInformation.Name = "lblCustomerInformation"
        Me.lblCustomerInformation.Size = New System.Drawing.Size(393, 42)
        Me.lblCustomerInformation.TabIndex = 23
        Me.lblCustomerInformation.Text = "Customer Information"
        '
        'txtMonthlySalary
        '
        Me.txtMonthlySalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlySalary.Location = New System.Drawing.Point(272, 507)
        Me.txtMonthlySalary.Name = "txtMonthlySalary"
        Me.txtMonthlySalary.Size = New System.Drawing.Size(393, 30)
        Me.txtMonthlySalary.TabIndex = 22
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompanyName.Location = New System.Drawing.Point(272, 437)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(393, 30)
        Me.txtCompanyName.TabIndex = 21
        '
        'txtOccupation
        '
        Me.txtOccupation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOccupation.Location = New System.Drawing.Point(272, 367)
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(393, 30)
        Me.txtOccupation.TabIndex = 20
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNumber.Location = New System.Drawing.Point(272, 298)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(393, 30)
        Me.txtContactNumber.TabIndex = 19
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(272, 231)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(393, 30)
        Me.txtAddress.TabIndex = 18
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(272, 162)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(393, 30)
        Me.txtCustomerName.TabIndex = 17
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Personal Loan", "Appliance Loan", "Gadget Loan"})
        Me.ComboBox2.Location = New System.Drawing.Point(55, 1400)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(445, 33)
        Me.ComboBox2.TabIndex = 35
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoanAmount.Location = New System.Drawing.Point(88, 1051)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(393, 30)
        Me.txtLoanAmount.TabIndex = 36
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmount.Location = New System.Drawing.Point(83, 1002)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(239, 25)
        Me.lblLoanAmount.TabIndex = 37
        Me.lblLoanAmount.Text = "Please enter loan amount:"
        '
        'lblLoanTerm
        '
        Me.lblLoanTerm.AutoSize = True
        Me.lblLoanTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanTerm.Location = New System.Drawing.Point(83, 1124)
        Me.lblLoanTerm.Name = "lblLoanTerm"
        Me.lblLoanTerm.Size = New System.Drawing.Size(239, 25)
        Me.lblLoanTerm.TabIndex = 38
        Me.lblLoanTerm.Text = "Please enter loan amount:"
        '
        'cboLoanTerm
        '
        Me.cboLoanTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLoanTerm.FormattingEnabled = True
        Me.cboLoanTerm.Items.AddRange(New Object() {"12 Months", "24 Months", "36 Months"})
        Me.cboLoanTerm.Location = New System.Drawing.Point(88, 1176)
        Me.cboLoanTerm.Name = "cboLoanTerm"
        Me.cboLoanTerm.Size = New System.Drawing.Size(393, 33)
        Me.cboLoanTerm.TabIndex = 39
        '
        'applyLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(906, 708)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "applyLoan"
        Me.Text = "applyLoan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLoanDetails As Label
    Friend WithEvents lblLoanType As Label
    Friend WithEvents cboLoanType As ComboBox
    Friend WithEvents lblLoanInformation As Label
    Friend WithEvents lblSalary As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblOccupation As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblCN As Label
    Friend WithEvents lblCustomerInformation As Label
    Friend WithEvents txtMonthlySalary As TextBox
    Friend WithEvents txtCompanyName As TextBox
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents cboLoanTerm As ComboBox
    Friend WithEvents lblLoanTerm As Label
End Class
