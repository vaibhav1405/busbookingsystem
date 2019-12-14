<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HOME
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO BUS TICKET BOOKING SYSTEM"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 64)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CLICK HERE FOR BUS SEARCH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 64)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CLICK HERE FOR TICKET BOOKING"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(28, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 64)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "CLICK HERE FOR TICKET CANCELLATION"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(192, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 64)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "TELEPHONE DIRECTORY"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(28, 114)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 64)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "CLICK HERE FOR TICKET BOOKING DATABASE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(192, 114)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 64)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "VIEW BUS TICKET"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'HOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 272)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HOME"
        Me.Text = "HOME"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
