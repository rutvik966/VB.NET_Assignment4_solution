﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.no1 = New System.Windows.Forms.TextBox()
        Me.no2 = New System.Windows.Forms.TextBox()
        Me.no3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'no1
        '
        Me.no1.Location = New System.Drawing.Point(351, 98)
        Me.no1.Name = "no1"
        Me.no1.Size = New System.Drawing.Size(150, 31)
        Me.no1.TabIndex = 0
        '
        'no2
        '
        Me.no2.Location = New System.Drawing.Point(351, 173)
        Me.no2.Name = "no2"
        Me.no2.Size = New System.Drawing.Size(150, 31)
        Me.no2.TabIndex = 1
        '
        'no3
        '
        Me.no3.Location = New System.Drawing.Point(351, 249)
        Me.no3.Name = "no3"
        Me.no3.Size = New System.Drawing.Size(150, 31)
        Me.no3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter 1st Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter 2nd Value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(121, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter 3rd Value"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Maximum"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 439)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.no3)
        Me.Controls.Add(Me.no2)
        Me.Controls.Add(Me.no1)
        Me.Name = "Form1"
        Me.Text = "Find Maximum Value"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents no1 As TextBox
    Friend WithEvents no2 As TextBox
    Friend WithEvents no3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
