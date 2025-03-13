<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMeasurementConverter
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdoInchesToMeters = New System.Windows.Forms.RadioButton()
        Me.rdoMetersToInches = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.Midterm.My.Resources.Resources.building
        Me.PictureBox1.Location = New System.Drawing.Point(1, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(215, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(316, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Converter App"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(234, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(368, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Enter a value and choose conversion"
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.Purple
        Me.txtInput.Location = New System.Drawing.Point(640, 122)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(98, 32)
        Me.txtInput.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Purple
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rdoInchesToMeters)
        Me.GroupBox1.Controls.Add(Me.rdoMetersToInches)
        Me.GroupBox1.Location = New System.Drawing.Point(412, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(231, 87)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(6, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Convert Measurement"
        '
        'rdoInchesToMeters
        '
        Me.rdoInchesToMeters.AutoSize = True
        Me.rdoInchesToMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoInchesToMeters.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rdoInchesToMeters.Location = New System.Drawing.Point(6, 35)
        Me.rdoInchesToMeters.Name = "rdoInchesToMeters"
        Me.rdoInchesToMeters.Size = New System.Drawing.Size(141, 20)
        Me.rdoInchesToMeters.TabIndex = 5
        Me.rdoInchesToMeters.TabStop = True
        Me.rdoInchesToMeters.Text = "Inches to Meters"
        Me.rdoInchesToMeters.UseVisualStyleBackColor = True
        '
        'rdoMetersToInches
        '
        Me.rdoMetersToInches.AutoSize = True
        Me.rdoMetersToInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoMetersToInches.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rdoMetersToInches.Location = New System.Drawing.Point(6, 61)
        Me.rdoMetersToInches.Name = "rdoMetersToInches"
        Me.rdoMetersToInches.Size = New System.Drawing.Size(141, 20)
        Me.rdoMetersToInches.TabIndex = 6
        Me.rdoMetersToInches.TabStop = True
        Me.rdoMetersToInches.Text = "Meters to Inches"
        Me.rdoMetersToInches.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(402, 329)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 25)
        Me.lblResult.TabIndex = 5
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.BlueViolet
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.Color.Black
        Me.btnConvert.Location = New System.Drawing.Point(30, 370)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(186, 55)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.BlueViolet
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(276, 370)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(186, 55)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.BlueViolet
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(532, 370)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 55)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'frmMeasurementConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmMeasurementConverter"
        Me.Text = "Building Plans Converter"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoInchesToMeters As RadioButton
    Friend WithEvents rdoMetersToInches As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
