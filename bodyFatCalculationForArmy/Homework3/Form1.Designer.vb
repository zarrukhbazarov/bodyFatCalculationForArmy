<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.hipTextBox = New System.Windows.Forms.TextBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.neckTextBox = New System.Windows.Forms.TextBox()
        Me.waistTextBox = New System.Windows.Forms.TextBox()
        Me.ageTextBox = New System.Windows.Forms.TextBox()
        Me.hipLabel = New System.Windows.Forms.Label()
        Me.heightLabel = New System.Windows.Forms.Label()
        Me.neckLabel = New System.Windows.Forms.Label()
        Me.waistLabel = New System.Windows.Forms.Label()
        Me.ageLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.newbieRadioButton = New System.Windows.Forms.RadioButton()
        Me.notNewbieRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bodyPercTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.testTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clearButton)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.calcButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 425)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleRadioButton.Location = New System.Drawing.Point(122, 25)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(79, 22)
        Me.femaleRadioButton.TabIndex = 20
        Me.femaleRadioButton.TabStop = True
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleRadioButton.Location = New System.Drawing.Point(6, 25)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(60, 22)
        Me.maleRadioButton.TabIndex = 19
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'calcButton
        '
        Me.calcButton.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.calcButton.Location = New System.Drawing.Point(22, 382)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(85, 28)
        Me.calcButton.TabIndex = 18
        Me.calcButton.Text = "Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'hipTextBox
        '
        Me.hipTextBox.Location = New System.Drawing.Point(71, 136)
        Me.hipTextBox.Name = "hipTextBox"
        Me.hipTextBox.Size = New System.Drawing.Size(76, 26)
        Me.hipTextBox.TabIndex = 16
        Me.hipTextBox.Visible = False
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(71, 110)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(76, 26)
        Me.heightTextBox.TabIndex = 15
        '
        'neckTextBox
        '
        Me.neckTextBox.Location = New System.Drawing.Point(71, 84)
        Me.neckTextBox.Name = "neckTextBox"
        Me.neckTextBox.Size = New System.Drawing.Size(76, 26)
        Me.neckTextBox.TabIndex = 14
        '
        'waistTextBox
        '
        Me.waistTextBox.Location = New System.Drawing.Point(71, 58)
        Me.waistTextBox.Name = "waistTextBox"
        Me.waistTextBox.Size = New System.Drawing.Size(76, 26)
        Me.waistTextBox.TabIndex = 13
        '
        'ageTextBox
        '
        Me.ageTextBox.Location = New System.Drawing.Point(71, 32)
        Me.ageTextBox.Name = "ageTextBox"
        Me.ageTextBox.Size = New System.Drawing.Size(76, 26)
        Me.ageTextBox.TabIndex = 12
        '
        'hipLabel
        '
        Me.hipLabel.AutoSize = True
        Me.hipLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.hipLabel.Location = New System.Drawing.Point(6, 139)
        Me.hipLabel.Name = "hipLabel"
        Me.hipLabel.Size = New System.Drawing.Size(33, 17)
        Me.hipLabel.TabIndex = 11
        Me.hipLabel.Text = "Hip:"
        Me.hipLabel.Visible = False
        '
        'heightLabel
        '
        Me.heightLabel.AutoSize = True
        Me.heightLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.heightLabel.Location = New System.Drawing.Point(6, 113)
        Me.heightLabel.Name = "heightLabel"
        Me.heightLabel.Size = New System.Drawing.Size(53, 17)
        Me.heightLabel.TabIndex = 10
        Me.heightLabel.Text = "Height:"
        '
        'neckLabel
        '
        Me.neckLabel.AutoSize = True
        Me.neckLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.neckLabel.Location = New System.Drawing.Point(6, 87)
        Me.neckLabel.Name = "neckLabel"
        Me.neckLabel.Size = New System.Drawing.Size(45, 17)
        Me.neckLabel.TabIndex = 9
        Me.neckLabel.Text = "Neck:"
        '
        'waistLabel
        '
        Me.waistLabel.AutoSize = True
        Me.waistLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.waistLabel.Location = New System.Drawing.Point(6, 61)
        Me.waistLabel.Name = "waistLabel"
        Me.waistLabel.Size = New System.Drawing.Size(49, 17)
        Me.waistLabel.TabIndex = 8
        Me.waistLabel.Text = "Waist:"
        '
        'ageLabel
        '
        Me.ageLabel.AutoSize = True
        Me.ageLabel.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ageLabel.Location = New System.Drawing.Point(6, 35)
        Me.ageLabel.Name = "ageLabel"
        Me.ageLabel.Size = New System.Drawing.Size(37, 17)
        Me.ageLabel.TabIndex = 7
        Me.ageLabel.Text = "Age:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(348, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 425)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.maleRadioButton)
        Me.GroupBox4.Controls.Add(Me.femaleRadioButton)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 29)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(241, 57)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gender"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.newbieRadioButton)
        Me.GroupBox5.Controls.Add(Me.notNewbieRadioButton)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(296, 75)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Experience"
        '
        'newbieRadioButton
        '
        Me.newbieRadioButton.AutoSize = True
        Me.newbieRadioButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newbieRadioButton.Location = New System.Drawing.Point(6, 31)
        Me.newbieRadioButton.Name = "newbieRadioButton"
        Me.newbieRadioButton.Size = New System.Drawing.Size(110, 22)
        Me.newbieRadioButton.TabIndex = 19
        Me.newbieRadioButton.TabStop = True
        Me.newbieRadioButton.Text = "New Recruit"
        Me.newbieRadioButton.UseVisualStyleBackColor = True
        '
        'notNewbieRadioButton
        '
        Me.notNewbieRadioButton.AutoSize = True
        Me.notNewbieRadioButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notNewbieRadioButton.Location = New System.Drawing.Point(122, 31)
        Me.notNewbieRadioButton.Name = "notNewbieRadioButton"
        Me.notNewbieRadioButton.Size = New System.Drawing.Size(143, 22)
        Me.notNewbieRadioButton.TabIndex = 20
        Me.notNewbieRadioButton.TabStop = True
        Me.notNewbieRadioButton.Text = "After Boot Camp"
        Me.notNewbieRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ageLabel)
        Me.GroupBox6.Controls.Add(Me.ageTextBox)
        Me.GroupBox6.Controls.Add(Me.waistTextBox)
        Me.GroupBox6.Controls.Add(Me.waistLabel)
        Me.GroupBox6.Controls.Add(Me.heightLabel)
        Me.GroupBox6.Controls.Add(Me.hipLabel)
        Me.GroupBox6.Controls.Add(Me.hipTextBox)
        Me.GroupBox6.Controls.Add(Me.neckLabel)
        Me.GroupBox6.Controls.Add(Me.heightTextBox)
        Me.GroupBox6.Controls.Add(Me.neckTextBox)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(6, 173)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(188, 187)
        Me.GroupBox6.TabIndex = 23
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Information"
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.clearButton.Location = New System.Drawing.Point(142, 382)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(85, 28)
        Me.clearButton.TabIndex = 24
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bodyPercTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(23, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(210, 89)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Body Percentage: "
        '
        'bodyPercTextBox
        '
        Me.bodyPercTextBox.Location = New System.Drawing.Point(15, 26)
        Me.bodyPercTextBox.Name = "bodyPercTextBox"
        Me.bodyPercTextBox.ReadOnly = True
        Me.bodyPercTextBox.Size = New System.Drawing.Size(160, 26)
        Me.bodyPercTextBox.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.testTextBox)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(26, 143)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(206, 113)
        Me.GroupBox7.TabIndex = 1
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Test Results: "
        '
        'testTextBox
        '
        Me.testTextBox.Location = New System.Drawing.Point(12, 29)
        Me.testTextBox.Name = "testTextBox"
        Me.testTextBox.ReadOnly = True
        Me.testTextBox.Size = New System.Drawing.Size(160, 26)
        Me.testTextBox.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents calcButton As Button
    Friend WithEvents hipTextBox As TextBox
    Friend WithEvents heightTextBox As TextBox
    Friend WithEvents neckTextBox As TextBox
    Friend WithEvents waistTextBox As TextBox
    Friend WithEvents ageTextBox As TextBox
    Friend WithEvents hipLabel As Label
    Friend WithEvents heightLabel As Label
    Friend WithEvents neckLabel As Label
    Friend WithEvents waistLabel As Label
    Friend WithEvents ageLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents maleRadioButton As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents newbieRadioButton As RadioButton
    Friend WithEvents notNewbieRadioButton As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents clearButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bodyPercTextBox As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents testTextBox As TextBox
End Class
