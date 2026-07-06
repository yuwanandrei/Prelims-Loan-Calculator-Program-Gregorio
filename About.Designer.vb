<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.aboutPage = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.lblLMS = New System.Windows.Forms.Label()
        Me.aboutPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'aboutPage
        '
        Me.aboutPage.Controls.Add(Me.lblLMS)
        Me.aboutPage.Controls.Add(Me.lblTitle)
        Me.aboutPage.Controls.Add(Me.lblBody)
        Me.aboutPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aboutPage.Location = New System.Drawing.Point(0, 0)
        Me.aboutPage.Name = "aboutPage"
        Me.aboutPage.Size = New System.Drawing.Size(906, 708)
        Me.aboutPage.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 35)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(547, 69)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "About the Program"
        '
        'lblBody
        '
        Me.lblBody.AutoSize = True
        Me.lblBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBody.Location = New System.Drawing.Point(38, 205)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(774, 374)
        Me.lblBody.TabIndex = 0
        Me.lblBody.Text = resources.GetString("lblBody.Text")
        '
        'lblLMS
        '
        Me.lblLMS.AutoSize = True
        Me.lblLMS.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLMS.Location = New System.Drawing.Point(35, 128)
        Me.lblLMS.Name = "lblLMS"
        Me.lblLMS.Size = New System.Drawing.Size(464, 42)
        Me.lblLMS.TabIndex = 2
        Me.lblLMS.Text = "Loan Management System"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 708)
        Me.Controls.Add(Me.aboutPage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.aboutPage.ResumeLayout(False)
        Me.aboutPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents aboutPage As Panel
    Friend WithEvents lblBody As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLMS As Label
End Class
