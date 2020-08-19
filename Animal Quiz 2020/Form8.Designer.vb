<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.optTower = New System.Windows.Forms.RadioButton()
        Me.optTrample = New System.Windows.Forms.RadioButton()
        Me.optHerd = New System.Windows.Forms.RadioButton()
        Me.optSpire = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(669, 424)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 29
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optTower
        '
        Me.optTower.AutoSize = True
        Me.optTower.Location = New System.Drawing.Point(207, 325)
        Me.optTower.Name = "optTower"
        Me.optTower.Size = New System.Drawing.Size(130, 36)
        Me.optTower.TabIndex = 28
        Me.optTower.TabStop = True
        Me.optTower.Text = "Tower"
        Me.optTower.UseVisualStyleBackColor = True
        '
        'optTrample
        '
        Me.optTrample.AutoSize = True
        Me.optTrample.Location = New System.Drawing.Point(474, 325)
        Me.optTrample.Name = "optTrample"
        Me.optTrample.Size = New System.Drawing.Size(156, 36)
        Me.optTrample.TabIndex = 27
        Me.optTrample.TabStop = True
        Me.optTrample.Text = "Trample"
        Me.optTrample.UseVisualStyleBackColor = True
        '
        'optHerd
        '
        Me.optHerd.AutoSize = True
        Me.optHerd.Location = New System.Drawing.Point(474, 214)
        Me.optHerd.Name = "optHerd"
        Me.optHerd.Size = New System.Drawing.Size(113, 36)
        Me.optHerd.TabIndex = 26
        Me.optHerd.TabStop = True
        Me.optHerd.Text = "Herd"
        Me.optHerd.UseVisualStyleBackColor = True
        '
        'optSpire
        '
        Me.optSpire.AutoSize = True
        Me.optSpire.Location = New System.Drawing.Point(207, 214)
        Me.optSpire.Name = "optSpire"
        Me.optSpire.Size = New System.Drawing.Size(119, 36)
        Me.optSpire.TabIndex = 25
        Me.optSpire.TabStop = True
        Me.optSpire.Text = "Spire"
        Me.optSpire.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(811, 44)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "7 )     What is the name for a group of Giraffes?"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 618)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optTower)
        Me.Controls.Add(Me.optTrample)
        Me.Controls.Add(Me.optHerd)
        Me.Controls.Add(Me.optSpire)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form8"
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nextbtn As Button
    Friend WithEvents optTower As RadioButton
    Friend WithEvents optTrample As RadioButton
    Friend WithEvents optHerd As RadioButton
    Friend WithEvents optSpire As RadioButton
    Friend WithEvents Label1 As Label
End Class
