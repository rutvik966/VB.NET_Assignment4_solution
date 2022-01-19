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
        Me.jhgd = New System.Windows.Forms.Label()
        Me.hgjgjgj = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.no = New System.Windows.Forms.TextBox()
        Me.capital = New System.Windows.Forms.TextBox()
        Me.small = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'jhgd
        '
        Me.jhgd.AutoSize = True
        Me.jhgd.Location = New System.Drawing.Point(67, 64)
        Me.jhgd.Name = "jhgd"
        Me.jhgd.Size = New System.Drawing.Size(119, 25)
        Me.jhgd.TabIndex = 0
        Me.jhgd.Text = "Only Number"
        '
        'hgjgjgj
        '
        Me.hgjgjgj.AutoSize = True
        Me.hgjgjgj.Location = New System.Drawing.Point(67, 123)
        Me.hgjgjgj.Name = "hgjgjgj"
        Me.hgjgjgj.Size = New System.Drawing.Size(115, 25)
        Me.hgjgjgj.TabIndex = 1
        Me.hgjgjgj.Text = "Capital Letter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Small Letter"
        '
        'no
        '
        Me.no.Location = New System.Drawing.Point(204, 64)
        Me.no.Name = "no"
        Me.no.Size = New System.Drawing.Size(150, 31)
        Me.no.TabIndex = 3
        '
        'capital
        '
        Me.capital.Location = New System.Drawing.Point(204, 117)
        Me.capital.Name = "capital"
        Me.capital.Size = New System.Drawing.Size(150, 31)
        Me.capital.TabIndex = 4
        '
        'small
        '
        Me.small.Location = New System.Drawing.Point(204, 179)
        Me.small.Name = "small"
        Me.small.Size = New System.Drawing.Size(150, 31)
        Me.small.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 273)
        Me.Controls.Add(Me.small)
        Me.Controls.Add(Me.capital)
        Me.Controls.Add(Me.no)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.hgjgjgj)
        Me.Controls.Add(Me.jhgd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jhgd As Label
    Friend WithEvents hgjgjgj As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents no As TextBox
    Friend WithEvents capital As TextBox
    Friend WithEvents small As TextBox
End Class
