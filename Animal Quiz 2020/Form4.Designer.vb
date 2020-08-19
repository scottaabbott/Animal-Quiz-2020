<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.optPack = New System.Windows.Forms.RadioButton()
        Me.optSwarm = New System.Windows.Forms.RadioButton()
        Me.optCongregation = New System.Windows.Forms.RadioButton()
        Me.optSnap = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(699, 426)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 11
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optPack
        '
        Me.optPack.AutoSize = True
        Me.optPack.Location = New System.Drawing.Point(237, 327)
        Me.optPack.Name = "optPack"
        Me.optPack.Size = New System.Drawing.Size(115, 36)
        Me.optPack.TabIndex = 10
        Me.optPack.TabStop = True
        Me.optPack.Text = "Pack"
        Me.optPack.UseVisualStyleBackColor = True
        '
        'optSwarm
        '
        Me.optSwarm.AutoSize = True
        Me.optSwarm.Location = New System.Drawing.Point(504, 327)
        Me.optSwarm.Name = "optSwarm"
        Me.optSwarm.Size = New System.Drawing.Size(139, 36)
        Me.optSwarm.TabIndex = 9
        Me.optSwarm.TabStop = True
        Me.optSwarm.Text = "Swarm"
        Me.optSwarm.UseVisualStyleBackColor = True
        '
        'optCongregation
        '
        Me.optCongregation.AutoSize = True
        Me.optCongregation.Location = New System.Drawing.Point(504, 216)
        Me.optCongregation.Name = "optCongregation"
        Me.optCongregation.Size = New System.Drawing.Size(224, 36)
        Me.optCongregation.TabIndex = 8
        Me.optCongregation.TabStop = True
        Me.optCongregation.Text = "Congregation"
        Me.optCongregation.UseVisualStyleBackColor = True
        '
        'optSnap
        '
        Me.optSnap.AutoSize = True
        Me.optSnap.Location = New System.Drawing.Point(237, 216)
        Me.optSnap.Name = "optSnap"
        Me.optSnap.Size = New System.Drawing.Size(119, 36)
        Me.optSnap.TabIndex = 7
        Me.optSnap.TabStop = True
        Me.optSnap.Text = "Snap"
        Me.optSnap.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(825, 44)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "3 )     What is the name for a group of Aligators?"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 599)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optPack)
        Me.Controls.Add(Me.optSwarm)
        Me.Controls.Add(Me.optCongregation)
        Me.Controls.Add(Me.optSnap)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Nextbtn As Button
    Friend WithEvents optPack As RadioButton
    Friend WithEvents optSwarm As RadioButton
    Friend WithEvents optCongregation As RadioButton
    Friend WithEvents optSnap As RadioButton
    Friend WithEvents Label2 As Label
End Class
