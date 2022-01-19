<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Me.textbox = New System.Windows.Forms.TextBox()
        Me.b7 = New System.Windows.Forms.Button()
        Me.b0 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b6 = New System.Windows.Forms.Button()
        Me.b5 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.b9 = New System.Windows.Forms.Button()
        Me.b8 = New System.Windows.Forms.Button()
        Me.division = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.subtraction = New System.Windows.Forms.Button()
        Me.b00 = New System.Windows.Forms.Button()
        Me.multiplication = New System.Windows.Forms.Button()
        Me.addition = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textbox
        '
        Me.textbox.Location = New System.Drawing.Point(34, 26)
        Me.textbox.Name = "textbox"
        Me.textbox.Size = New System.Drawing.Size(368, 31)
        Me.textbox.TabIndex = 0
        '
        'b7
        '
        Me.b7.Location = New System.Drawing.Point(34, 80)
        Me.b7.Name = "b7"
        Me.b7.Size = New System.Drawing.Size(71, 68)
        Me.b7.TabIndex = 1
        Me.b7.Text = "7"
        Me.b7.UseVisualStyleBackColor = True
        '
        'b0
        '
        Me.b0.Location = New System.Drawing.Point(34, 370)
        Me.b0.Name = "b0"
        Me.b0.Size = New System.Drawing.Size(71, 68)
        Me.b0.TabIndex = 2
        Me.b0.Text = "0"
        Me.b0.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Location = New System.Drawing.Point(232, 264)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(71, 68)
        Me.b3.TabIndex = 3
        Me.b3.Text = "3"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Location = New System.Drawing.Point(130, 264)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(71, 68)
        Me.b2.TabIndex = 4
        Me.b2.Text = "2"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.Location = New System.Drawing.Point(34, 264)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(71, 68)
        Me.b1.TabIndex = 5
        Me.b1.Text = "1"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b6
        '
        Me.b6.Location = New System.Drawing.Point(232, 169)
        Me.b6.Name = "b6"
        Me.b6.Size = New System.Drawing.Size(71, 68)
        Me.b6.TabIndex = 6
        Me.b6.Text = "6"
        Me.b6.UseVisualStyleBackColor = True
        '
        'b5
        '
        Me.b5.Location = New System.Drawing.Point(130, 169)
        Me.b5.Name = "b5"
        Me.b5.Size = New System.Drawing.Size(71, 68)
        Me.b5.TabIndex = 7
        Me.b5.Text = "5"
        Me.b5.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.Location = New System.Drawing.Point(34, 169)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(71, 68)
        Me.b4.TabIndex = 8
        Me.b4.Text = "4"
        Me.b4.UseVisualStyleBackColor = True
        '
        'b9
        '
        Me.b9.Location = New System.Drawing.Point(232, 80)
        Me.b9.Name = "b9"
        Me.b9.Size = New System.Drawing.Size(71, 68)
        Me.b9.TabIndex = 9
        Me.b9.Text = "9"
        Me.b9.UseVisualStyleBackColor = True
        '
        'b8
        '
        Me.b8.Location = New System.Drawing.Point(130, 80)
        Me.b8.Name = "b8"
        Me.b8.Size = New System.Drawing.Size(71, 68)
        Me.b8.TabIndex = 10
        Me.b8.Text = "8"
        Me.b8.UseVisualStyleBackColor = True
        '
        'division
        '
        Me.division.Location = New System.Drawing.Point(331, 169)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(71, 68)
        Me.division.TabIndex = 11
        Me.division.Text = "/"
        Me.division.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Location = New System.Drawing.Point(331, 80)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(71, 68)
        Me.clear.TabIndex = 12
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = True
        '
        'subtraction
        '
        Me.subtraction.Location = New System.Drawing.Point(232, 370)
        Me.subtraction.Name = "subtraction"
        Me.subtraction.Size = New System.Drawing.Size(71, 68)
        Me.subtraction.TabIndex = 13
        Me.subtraction.Text = "-"
        Me.subtraction.UseVisualStyleBackColor = True
        '
        'b00
        '
        Me.b00.Location = New System.Drawing.Point(130, 370)
        Me.b00.Name = "b00"
        Me.b00.Size = New System.Drawing.Size(71, 68)
        Me.b00.TabIndex = 14
        Me.b00.Text = "="
        Me.b00.UseVisualStyleBackColor = True
        '
        'multiplication
        '
        Me.multiplication.Location = New System.Drawing.Point(331, 264)
        Me.multiplication.Name = "multiplication"
        Me.multiplication.Size = New System.Drawing.Size(71, 68)
        Me.multiplication.TabIndex = 16
        Me.multiplication.Text = "X"
        Me.multiplication.UseVisualStyleBackColor = True
        '
        'addition
        '
        Me.addition.Location = New System.Drawing.Point(331, 370)
        Me.addition.Name = "addition"
        Me.addition.Size = New System.Drawing.Size(71, 68)
        Me.addition.TabIndex = 17
        Me.addition.Text = "+"
        Me.addition.UseVisualStyleBackColor = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 457)
        Me.Controls.Add(Me.addition)
        Me.Controls.Add(Me.multiplication)
        Me.Controls.Add(Me.b00)
        Me.Controls.Add(Me.subtraction)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.b8)
        Me.Controls.Add(Me.b9)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.b5)
        Me.Controls.Add(Me.b6)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b0)
        Me.Controls.Add(Me.b7)
        Me.Controls.Add(Me.textbox)
        Me.Name = "calculator"
        Me.Text = "calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbox As TextBox
    Friend WithEvents b7 As Button
    Friend WithEvents b0 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents b6 As Button
    Friend WithEvents b5 As Button
    Friend WithEvents b4 As Button
    Friend WithEvents b9 As Button
    Friend WithEvents b8 As Button
    Friend WithEvents division As Button
    Friend WithEvents clear As Button
    Friend WithEvents subtraction As Button
    Friend WithEvents b00 As Button
    Friend WithEvents multiplication As Button
    Friend WithEvents addition As Button
End Class
