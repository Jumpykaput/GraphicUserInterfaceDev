<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNumbers
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblFrench = New System.Windows.Forms.Label()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(95, 87)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(597, 50)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Do you know the French words for the numbers 1 through 5? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                   Cl" &
    "ick the buttons below to see them."
        '
        'lblFrench
        '
        Me.lblFrench.AutoSize = True
        Me.lblFrench.Location = New System.Drawing.Point(387, 285)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(0, 16)
        Me.lblFrench.TabIndex = 1
        Me.lblFrench.Visible = False
        '
        'btnOne
        '
        Me.btnOne.Location = New System.Drawing.Point(39, 197)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(115, 52)
        Me.btnOne.TabIndex = 2
        Me.btnOne.Text = "Button1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Location = New System.Drawing.Point(185, 197)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(114, 52)
        Me.btnTwo.TabIndex = 3
        Me.btnTwo.Text = "Button2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Location = New System.Drawing.Point(330, 197)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(114, 52)
        Me.btnThree.TabIndex = 4
        Me.btnThree.Text = "Button3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Location = New System.Drawing.Point(489, 197)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(114, 52)
        Me.btnFour.TabIndex = 5
        Me.btnFour.Text = "Button4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Location = New System.Drawing.Point(637, 197)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(114, 52)
        Me.btnFive.TabIndex = 6
        Me.btnFive.Text = "Button5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(330, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(116, 41)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFive)
        Me.Controls.Add(Me.btnFour)
        Me.Controls.Add(Me.btnThree)
        Me.Controls.Add(Me.btnTwo)
        Me.Controls.Add(Me.btnOne)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.lblInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNumbers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblFrench As Label
    Friend WithEvents btnOne As Button
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnExit As Button
End Class
