<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.optBlob = New System.Windows.Forms.RadioButton()
        Me.optFloat = New System.Windows.Forms.RadioButton()
        Me.optSmack = New System.Windows.Forms.RadioButton()
        Me.optHerd = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(668, 415)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 35
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optBlob
        '
        Me.optBlob.AutoSize = True
        Me.optBlob.Location = New System.Drawing.Point(206, 316)
        Me.optBlob.Name = "optBlob"
        Me.optBlob.Size = New System.Drawing.Size(110, 36)
        Me.optBlob.TabIndex = 34
        Me.optBlob.TabStop = True
        Me.optBlob.Text = "Blob"
        Me.optBlob.UseVisualStyleBackColor = True
        '
        'optFloat
        '
        Me.optFloat.AutoSize = True
        Me.optFloat.Location = New System.Drawing.Point(473, 316)
        Me.optFloat.Name = "optFloat"
        Me.optFloat.Size = New System.Drawing.Size(116, 36)
        Me.optFloat.TabIndex = 33
        Me.optFloat.TabStop = True
        Me.optFloat.Text = "Float"
        Me.optFloat.UseVisualStyleBackColor = True
        '
        'optSmack
        '
        Me.optSmack.AutoSize = True
        Me.optSmack.Location = New System.Drawing.Point(473, 205)
        Me.optSmack.Name = "optSmack"
        Me.optSmack.Size = New System.Drawing.Size(138, 36)
        Me.optSmack.TabIndex = 32
        Me.optSmack.TabStop = True
        Me.optSmack.Text = "Smack"
        Me.optSmack.UseVisualStyleBackColor = True
        '
        'optHerd
        '
        Me.optHerd.AutoSize = True
        Me.optHerd.Location = New System.Drawing.Point(206, 205)
        Me.optHerd.Name = "optHerd"
        Me.optHerd.Size = New System.Drawing.Size(113, 36)
        Me.optHerd.TabIndex = 31
        Me.optHerd.TabStop = True
        Me.optHerd.Text = "Herd"
        Me.optHerd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(813, 44)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "8 )     What is the name for a group of Jellyfish?"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 554)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optBlob)
        Me.Controls.Add(Me.optFloat)
        Me.Controls.Add(Me.optSmack)
        Me.Controls.Add(Me.optHerd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nextbtn As Button
    Friend WithEvents optBlob As RadioButton
    Friend WithEvents optFloat As RadioButton
    Friend WithEvents optSmack As RadioButton
    Friend WithEvents optHerd As RadioButton
    Friend WithEvents Label1 As Label
End Class
