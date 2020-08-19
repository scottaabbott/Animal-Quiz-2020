<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Me.optNutter = New System.Windows.Forms.RadioButton()
        Me.optPack = New System.Windows.Forms.RadioButton()
        Me.optFlight = New System.Windows.Forms.RadioButton()
        Me.optScurry = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(667, 415)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 41
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optNutter
        '
        Me.optNutter.AutoSize = True
        Me.optNutter.Location = New System.Drawing.Point(205, 316)
        Me.optNutter.Name = "optNutter"
        Me.optNutter.Size = New System.Drawing.Size(129, 36)
        Me.optNutter.TabIndex = 40
        Me.optNutter.TabStop = True
        Me.optNutter.Text = "Nutter"
        Me.optNutter.UseVisualStyleBackColor = True
        '
        'optPack
        '
        Me.optPack.AutoSize = True
        Me.optPack.Location = New System.Drawing.Point(472, 316)
        Me.optPack.Name = "optPack"
        Me.optPack.Size = New System.Drawing.Size(115, 36)
        Me.optPack.TabIndex = 39
        Me.optPack.TabStop = True
        Me.optPack.Text = "Pack"
        Me.optPack.UseVisualStyleBackColor = True
        '
        'optFlight
        '
        Me.optFlight.AutoSize = True
        Me.optFlight.Location = New System.Drawing.Point(472, 205)
        Me.optFlight.Name = "optFlight"
        Me.optFlight.Size = New System.Drawing.Size(123, 36)
        Me.optFlight.TabIndex = 38
        Me.optFlight.TabStop = True
        Me.optFlight.Text = "Flight"
        Me.optFlight.UseVisualStyleBackColor = True
        '
        'optScurry
        '
        Me.optScurry.AutoSize = True
        Me.optScurry.Location = New System.Drawing.Point(205, 205)
        Me.optScurry.Name = "optScurry"
        Me.optScurry.Size = New System.Drawing.Size(133, 36)
        Me.optScurry.TabIndex = 37
        Me.optScurry.TabStop = True
        Me.optScurry.Text = "Scurry"
        Me.optScurry.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(827, 44)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "9 )     What is the name for a group of Squirrels?"
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(965, 598)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optNutter)
        Me.Controls.Add(Me.optPack)
        Me.Controls.Add(Me.optFlight)
        Me.Controls.Add(Me.optScurry)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nextbtn As Button
    Friend WithEvents optNutter As RadioButton
    Friend WithEvents optPack As RadioButton
    Friend WithEvents optFlight As RadioButton
    Friend WithEvents optScurry As RadioButton
    Friend WithEvents Label1 As Label
End Class
