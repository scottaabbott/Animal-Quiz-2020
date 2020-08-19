<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.optFlipper = New System.Windows.Forms.RadioButton()
        Me.optSchool = New System.Windows.Forms.RadioButton()
        Me.optPod = New System.Windows.Forms.RadioButton()
        Me.optBottle = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(692, 409)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 23
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optFlipper
        '
        Me.optFlipper.AutoSize = True
        Me.optFlipper.Location = New System.Drawing.Point(230, 310)
        Me.optFlipper.Name = "optFlipper"
        Me.optFlipper.Size = New System.Drawing.Size(140, 36)
        Me.optFlipper.TabIndex = 22
        Me.optFlipper.TabStop = True
        Me.optFlipper.Text = "Flipper"
        Me.optFlipper.UseVisualStyleBackColor = True
        '
        'optSchool
        '
        Me.optSchool.AutoSize = True
        Me.optSchool.Location = New System.Drawing.Point(497, 310)
        Me.optSchool.Name = "optSchool"
        Me.optSchool.Size = New System.Drawing.Size(140, 36)
        Me.optSchool.TabIndex = 21
        Me.optSchool.TabStop = True
        Me.optSchool.Text = "School"
        Me.optSchool.UseVisualStyleBackColor = True
        '
        'optPod
        '
        Me.optPod.AutoSize = True
        Me.optPod.Location = New System.Drawing.Point(497, 199)
        Me.optPod.Name = "optPod"
        Me.optPod.Size = New System.Drawing.Size(103, 36)
        Me.optPod.TabIndex = 20
        Me.optPod.TabStop = True
        Me.optPod.Text = "Pod"
        Me.optPod.UseVisualStyleBackColor = True
        '
        'optBottle
        '
        Me.optBottle.AutoSize = True
        Me.optBottle.Location = New System.Drawing.Point(230, 199)
        Me.optBottle.Name = "optBottle"
        Me.optBottle.Size = New System.Drawing.Size(126, 36)
        Me.optBottle.TabIndex = 19
        Me.optBottle.TabStop = True
        Me.optBottle.Text = "Bottle"
        Me.optBottle.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(824, 44)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "6 )     What is the name for a group of Dolphins?"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 567)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optFlipper)
        Me.Controls.Add(Me.optSchool)
        Me.Controls.Add(Me.optPod)
        Me.Controls.Add(Me.optBottle)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nextbtn As Button
    Friend WithEvents optFlipper As RadioButton
    Friend WithEvents optSchool As RadioButton
    Friend WithEvents optPod As RadioButton
    Friend WithEvents optBottle As RadioButton
    Friend WithEvents Label1 As Label
End Class
