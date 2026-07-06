<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class help
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(help))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblHelpInfo = New System.Windows.Forms.Label()
        Me.lblfirstPart = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblfirstPart)
        Me.Panel1.Controls.Add(Me.lblHelpInfo)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(909, 708)
        Me.Panel1.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(21, 30)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(156, 69)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Help"
        '
        'lblHelpInfo
        '
        Me.lblHelpInfo.AutoSize = True
        Me.lblHelpInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpInfo.Location = New System.Drawing.Point(28, 190)
        Me.lblHelpInfo.Name = "lblHelpInfo"
        Me.lblHelpInfo.Size = New System.Drawing.Size(742, 275)
        Me.lblHelpInfo.TabIndex = 3
        Me.lblHelpInfo.Text = resources.GetString("lblHelpInfo.Text")
        '
        'lblfirstPart
        '
        Me.lblfirstPart.AutoSize = True
        Me.lblfirstPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirstPart.Location = New System.Drawing.Point(27, 130)
        Me.lblfirstPart.Name = "lblfirstPart"
        Me.lblfirstPart.Size = New System.Drawing.Size(450, 36)
        Me.lblfirstPart.TabIndex = 4
        Me.lblfirstPart.Text = "To apply for a loan, you need to: "
        '
        'help
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 708)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "help"
        Me.Text = "help"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblfirstPart As Label
    Friend WithEvents lblHelpInfo As Label
End Class
