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
        Me.url1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.urllink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Link Lable"
        '
        'url1
        '
        Me.url1.Location = New System.Drawing.Point(143, 131)
        Me.url1.Name = "url1"
        Me.url1.Size = New System.Drawing.Size(371, 31)
        Me.url1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Web URL"
        '
        'urllink
        '
        Me.urllink.AutoSize = True
        Me.urllink.LinkColor = System.Drawing.Color.Black
        Me.urllink.Location = New System.Drawing.Point(238, 201)
        Me.urllink.Name = "urllink"
        Me.urllink.Size = New System.Drawing.Size(78, 25)
        Me.urllink.TabIndex = 3
        Me.urllink.TabStop = True
        Me.urllink.Text = "Click Me"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 310)
        Me.Controls.Add(Me.urllink)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.url1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Link Lable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents url1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents urllink As LinkLabel
End Class
