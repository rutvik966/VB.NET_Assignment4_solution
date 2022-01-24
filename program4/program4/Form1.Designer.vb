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
        Me.uname = New System.Windows.Forms.TextBox()
        Me.upass = New System.Windows.Forms.TextBox()
        Me.login = New System.Windows.Forms.Button()
        Me.uclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(205, 57)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(190, 31)
        Me.uname.TabIndex = 0
        '
        'upass
        '
        Me.upass.Location = New System.Drawing.Point(205, 140)
        Me.upass.Name = "upass"
        Me.upass.Size = New System.Drawing.Size(190, 31)
        Me.upass.TabIndex = 1
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(83, 228)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(112, 34)
        Me.login.TabIndex = 2
        Me.login.Text = "Login"
        Me.login.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.login.UseVisualStyleBackColor = True
        '
        'uclose
        '
        Me.uclose.Location = New System.Drawing.Point(243, 228)
        Me.uclose.Name = "uclose"
        Me.uclose.Size = New System.Drawing.Size(112, 34)
        Me.uclose.TabIndex = 3
        Me.uclose.Text = "Close"
        Me.uclose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 319)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.uclose)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.upass)
        Me.Controls.Add(Me.uname)
        Me.Name = "Form1"
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents uname As TextBox
    Friend WithEvents upass As TextBox
    Friend WithEvents login As Button
    Friend WithEvents uclose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
