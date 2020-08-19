<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optMurder = New System.Windows.Forms.RadioButton()
        Me.optFlock = New System.Windows.Forms.RadioButton()
        Me.optHoard = New System.Windows.Forms.RadioButton()
        Me.optSquable = New System.Windows.Forms.RadioButton()
        Me.Nextbtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(783, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1 )     What is the name for a group of Crows?"
        '
        'optMurder
        '
        Me.optMurder.AutoSize = True
        Me.optMurder.Location = New System.Drawing.Point(203, 195)
        Me.optMurder.Name = "optMurder"
        Me.optMurder.Size = New System.Drawing.Size(141, 36)
        Me.optMurder.TabIndex = 1
        Me.optMurder.TabStop = True
        Me.optMurder.Text = "Murder"
        Me.optMurder.UseVisualStyleBackColor = True
        '
        'optFlock
        '
        Me.optFlock.AutoSize = True
        Me.optFlock.Location = New System.Drawing.Point(477, 195)
        Me.optFlock.Name = "optFlock"
        Me.optFlock.Size = New System.Drawing.Size(120, 36)
        Me.optFlock.TabIndex = 2
        Me.optFlock.TabStop = True
        Me.optFlock.Text = "Flock"
        Me.optFlock.UseVisualStyleBackColor = True
        '
        'optHoard
        '
        Me.optHoard.AutoSize = True
        Me.optHoard.Location = New System.Drawing.Point(203, 306)
        Me.optHoard.Name = "optHoard"
        Me.optHoard.Size = New System.Drawing.Size(129, 36)
        Me.optHoard.TabIndex = 3
        Me.optHoard.TabStop = True
        Me.optHoard.Text = "Hoard"
        Me.optHoard.UseVisualStyleBackColor = True
        '
        'optSquable
        '
        Me.optSquable.AutoSize = True
        Me.optSquable.Location = New System.Drawing.Point(477, 306)
        Me.optSquable.Name = "optSquable"
        Me.optSquable.Size = New System.Drawing.Size(158, 36)
        Me.optSquable.TabIndex = 4
        Me.optSquable.TabStop = True
        Me.optSquable.Text = "Squable"
        Me.optSquable.UseVisualStyleBackColor = True
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(657, 417)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(187, 54)
        Me.Nextbtn.TabIndex = 5
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 603)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optSquable)
        Me.Controls.Add(Me.optHoard)
        Me.Controls.Add(Me.optFlock)
        Me.Controls.Add(Me.optMurder)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents optMurder As RadioButton
    Friend WithEvents optFlock As RadioButton
    Friend WithEvents optHoard As RadioButton
    Friend WithEvents optSquable As RadioButton
    Friend WithEvents Nextbtn As Button
End Class
