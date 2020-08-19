<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.optGlare = New System.Windows.Forms.RadioButton()
        Me.optCorral = New System.Windows.Forms.RadioButton()
        Me.optFeral = New System.Windows.Forms.RadioButton()
        Me.optClump = New System.Windows.Forms.RadioButton()
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(754, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "2 )     What is the name for a group of Cats?"
        '
        'optGlare
        '
        Me.optGlare.AutoSize = True
        Me.optGlare.Location = New System.Drawing.Point(251, 219)
        Me.optGlare.Name = "optGlare"
        Me.optGlare.Size = New System.Drawing.Size(122, 36)
        Me.optGlare.TabIndex = 1
        Me.optGlare.TabStop = True
        Me.optGlare.Text = "Glare"
        Me.optGlare.UseVisualStyleBackColor = True
        '
        'optCorral
        '
        Me.optCorral.AutoSize = True
        Me.optCorral.Location = New System.Drawing.Point(518, 219)
        Me.optCorral.Name = "optCorral"
        Me.optCorral.Size = New System.Drawing.Size(129, 36)
        Me.optCorral.TabIndex = 2
        Me.optCorral.TabStop = True
        Me.optCorral.Text = "Corral"
        Me.optCorral.UseVisualStyleBackColor = True
        '
        'optFeral
        '
        Me.optFeral.AutoSize = True
        Me.optFeral.Location = New System.Drawing.Point(518, 330)
        Me.optFeral.Name = "optFeral"
        Me.optFeral.Size = New System.Drawing.Size(117, 36)
        Me.optFeral.TabIndex = 3
        Me.optFeral.TabStop = True
        Me.optFeral.Text = "Feral"
        Me.optFeral.UseVisualStyleBackColor = True
        '
        'optClump
        '
        Me.optClump.AutoSize = True
        Me.optClump.Location = New System.Drawing.Point(251, 330)
        Me.optClump.Name = "optClump"
        Me.optClump.Size = New System.Drawing.Size(134, 36)
        Me.optClump.TabIndex = 4
        Me.optClump.TabStop = True
        Me.optClump.Text = "Clump"
        Me.optClump.UseVisualStyleBackColor = True
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(713, 429)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 5
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 598)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optClump)
        Me.Controls.Add(Me.optFeral)
        Me.Controls.Add(Me.optCorral)
        Me.Controls.Add(Me.optGlare)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents optGlare As RadioButton
    Friend WithEvents optCorral As RadioButton
    Friend WithEvents optFeral As RadioButton
    Friend WithEvents optClump As RadioButton
    Friend WithEvents Nextbtn As Button
End Class
