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
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.radioButton2 = New System.Windows.Forms.RadioButton()
        Me.radioButton1 = New System.Windows.Forms.RadioButton()
        Me.label1 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(222, 131)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(131, 20)
        Me.textBox3.TabIndex = 22
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(222, 94)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(131, 20)
        Me.textBox2.TabIndex = 21
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(222, 54)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(341, 20)
        Me.textBox1.TabIndex = 20
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(74, 134)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(30, 13)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Time"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(74, 94)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(79, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Rate of interest"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(278, 327)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 17
        Me.button3.Text = "Calculate"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(77, 327)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 16
        Me.button2.Text = "Clear"
        Me.button2.UseVisualStyleBackColor = True
        '
        'radioButton2
        '
        Me.radioButton2.AutoSize = True
        Me.radioButton2.Location = New System.Drawing.Point(239, 191)
        Me.radioButton2.Name = "radioButton2"
        Me.radioButton2.Size = New System.Drawing.Size(114, 17)
        Me.radioButton2.TabIndex = 15
        Me.radioButton2.Text = "Compound Interest"
        Me.radioButton2.UseVisualStyleBackColor = True
        '
        'radioButton1
        '
        Me.radioButton1.AutoSize = True
        Me.radioButton1.Checked = True
        Me.radioButton1.Location = New System.Drawing.Point(77, 191)
        Me.radioButton1.Name = "radioButton1"
        Me.radioButton1.Size = New System.Drawing.Size(94, 17)
        Me.radioButton1.TabIndex = 14
        Me.radioButton1.TabStop = True
        Me.radioButton1.Text = "Simple Interest"
        Me.radioButton1.UseVisualStyleBackColor = True
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(74, 54)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(43, 13)
        Me.label1.TabIndex = 13
        Me.label1.Text = "Amount"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(488, 327)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 12
        Me.button1.Text = "Close"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(222, 246)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(242, 20)
        Me.textBox4.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 252)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Simple Interest"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 382)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.radioButton2)
        Me.Controls.Add(Me.radioButton1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Interest Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents radioButton2 As RadioButton
    Private WithEvents radioButton1 As RadioButton
    Private WithEvents label1 As Label
    Private WithEvents button1 As Button
    Private WithEvents textBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
