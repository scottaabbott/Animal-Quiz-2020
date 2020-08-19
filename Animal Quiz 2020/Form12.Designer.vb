<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.optSlurry = New System.Windows.Forms.RadioButton()
        Me.optThunder = New System.Windows.Forms.RadioButton()
        Me.optPuddle = New System.Windows.Forms.RadioButton()
        Me.optStomp = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(691, 438)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 47
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optSlurry
        '
        Me.optSlurry.AutoSize = True
        Me.optSlurry.Location = New System.Drawing.Point(229, 339)
        Me.optSlurry.Name = "optSlurry"
        Me.optSlurry.Size = New System.Drawing.Size(126, 36)
        Me.optSlurry.TabIndex = 46
        Me.optSlurry.TabStop = True
        Me.optSlurry.Text = "Slurry"
        Me.optSlurry.UseVisualStyleBackColor = True
        '
        'optThunder
        '
        Me.optThunder.AutoSize = True
        Me.optThunder.Location = New System.Drawing.Point(496, 339)
        Me.optThunder.Name = "optThunder"
        Me.optThunder.Size = New System.Drawing.Size(158, 36)
        Me.optThunder.TabIndex = 45
        Me.optThunder.TabStop = True
        Me.optThunder.Text = "Thunder"
        Me.optThunder.UseVisualStyleBackColor = True
        '
        'optPuddle
        '
        Me.optPuddle.AutoSize = True
        Me.optPuddle.Location = New System.Drawing.Point(496, 228)
        Me.optPuddle.Name = "optPuddle"
        Me.optPuddle.Size = New System.Drawing.Size(142, 36)
        Me.optPuddle.TabIndex = 44
        Me.optPuddle.TabStop = True
        Me.optPuddle.Text = "Puddle"
        Me.optPuddle.UseVisualStyleBackColor = True
        '
        'optStomp
        '
        Me.optStomp.AutoSize = True
        Me.optStomp.Location = New System.Drawing.Point(229, 228)
        Me.optStomp.Name = "optStomp"
        Me.optStomp.Size = New System.Drawing.Size(134, 36)
        Me.optStomp.TabIndex = 43
        Me.optStomp.TabStop = True
        Me.optStomp.Text = "Stomp"
        Me.optStomp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(815, 44)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "11 )     What is the name for a group of Hippos?"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 626)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optSlurry)
        Me.Controls.Add(Me.optThunder)
        Me.Controls.Add(Me.optPuddle)
        Me.Controls.Add(Me.optStomp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form12"
        Me.Text = "Form12"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nextbtn As Button
    Friend WithEvents optSlurry As RadioButton
    Friend WithEvents optThunder As RadioButton
    Friend WithEvents optPuddle As RadioButton
    Friend WithEvents optStomp As RadioButton
    Friend WithEvents Label1 As Label
End Class
