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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.red = New System.Windows.Forms.TextBox()
        Me.green = New System.Windows.Forms.TextBox()
        Me.blue = New System.Windows.Forms.TextBox()
        Me.normal = New System.Windows.Forms.Button()
        Me.maximize = New System.Windows.Forms.Button()
        Me.minimize = New System.Windows.Forms.Button()
        Me.applycolor = New System.Windows.Forms.Button()
        Me.exist = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(46, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(46, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Green"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(46, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Blue"
        '
        'red
        '
        Me.red.Location = New System.Drawing.Point(172, 47)
        Me.red.Name = "red"
        Me.red.Size = New System.Drawing.Size(150, 31)
        Me.red.TabIndex = 3
        '
        'green
        '
        Me.green.Location = New System.Drawing.Point(172, 129)
        Me.green.Name = "green"
        Me.green.Size = New System.Drawing.Size(150, 31)
        Me.green.TabIndex = 4
        '
        'blue
        '
        Me.blue.Location = New System.Drawing.Point(172, 204)
        Me.blue.Name = "blue"
        Me.blue.Size = New System.Drawing.Size(150, 31)
        Me.blue.TabIndex = 5
        '
        'normal
        '
        Me.normal.Location = New System.Drawing.Point(408, 47)
        Me.normal.Name = "normal"
        Me.normal.Size = New System.Drawing.Size(161, 34)
        Me.normal.TabIndex = 6
        Me.normal.Text = "Normal View"
        Me.normal.UseVisualStyleBackColor = True
        '
        'maximize
        '
        Me.maximize.Location = New System.Drawing.Point(408, 126)
        Me.maximize.Name = "maximize"
        Me.maximize.Size = New System.Drawing.Size(161, 34)
        Me.maximize.TabIndex = 7
        Me.maximize.Text = "Maximize View"
        Me.maximize.UseVisualStyleBackColor = True
        '
        'minimize
        '
        Me.minimize.Location = New System.Drawing.Point(408, 207)
        Me.minimize.Name = "minimize"
        Me.minimize.Size = New System.Drawing.Size(161, 34)
        Me.minimize.TabIndex = 8
        Me.minimize.Text = "Minimize View"
        Me.minimize.UseVisualStyleBackColor = True
        '
        'applycolor
        '
        Me.applycolor.Location = New System.Drawing.Point(204, 315)
        Me.applycolor.Name = "applycolor"
        Me.applycolor.Size = New System.Drawing.Size(147, 34)
        Me.applycolor.TabIndex = 9
        Me.applycolor.Text = "Apply Color"
        Me.applycolor.UseVisualStyleBackColor = True
        '
        'exist
        '
        Me.exist.Location = New System.Drawing.Point(408, 315)
        Me.exist.Name = "exist"
        Me.exist.Size = New System.Drawing.Size(112, 34)
        Me.exist.TabIndex = 10
        Me.exist.Text = "Exist"
        Me.exist.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 405)
        Me.Controls.Add(Me.exist)
        Me.Controls.Add(Me.applycolor)
        Me.Controls.Add(Me.minimize)
        Me.Controls.Add(Me.maximize)
        Me.Controls.Add(Me.normal)
        Me.Controls.Add(Me.blue)
        Me.Controls.Add(Me.green)
        Me.Controls.Add(Me.red)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "RGB Function "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents red As TextBox
    Friend WithEvents green As TextBox
    Friend WithEvents blue As TextBox
    Friend WithEvents normal As Button
    Friend WithEvents maximize As Button
    Friend WithEvents minimize As Button
    Friend WithEvents applycolor As Button
    Friend WithEvents exist As Button
End Class
