<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.optCroak = New System.Windows.Forms.RadioButton()
        Me.optRibbit = New System.Windows.Forms.RadioButton()
        Me.optArmy = New System.Windows.Forms.RadioButton()
        Me.optArmada = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Nextbtn
        '
        Me.Nextbtn.Location = New System.Drawing.Point(694, 420)
        Me.Nextbtn.Name = "Nextbtn"
        Me.Nextbtn.Size = New System.Drawing.Size(172, 54)
        Me.Nextbtn.TabIndex = 11
        Me.Nextbtn.Text = "Next"
        Me.Nextbtn.UseVisualStyleBackColor = True
        '
        'optCroak
        '
        Me.optCroak.AutoSize = True
        Me.optCroak.Location = New System.Drawing.Point(232, 321)
        Me.optCroak.Name = "optCroak"
        Me.optCroak.Size = New System.Drawing.Size(127, 36)
        Me.optCroak.TabIndex = 10
        Me.optCroak.TabStop = True
        Me.optCroak.Text = "Croak"
        Me.optCroak.UseVisualStyleBackColor = True
        '
        'optRibbit
        '
        Me.optRibbit.AutoSize = True
        Me.optRibbit.Location = New System.Drawing.Point(499, 321)
        Me.optRibbit.Name = "optRibbit"
        Me.optRibbit.Size = New System.Drawing.Size(133, 36)
        Me.optRibbit.TabIndex = 9
        Me.optRibbit.TabStop = True
        Me.optRibbit.Text = "Ribbit "
        Me.optRibbit.UseVisualStyleBackColor = True
        '
        'optArmy
        '
        Me.optArmy.AutoSize = True
        Me.optArmy.Location = New System.Drawing.Point(499, 210)
        Me.optArmy.Name = "optArmy"
        Me.optArmy.Size = New System.Drawing.Size(117, 36)
        Me.optArmy.TabIndex = 8
        Me.optArmy.TabStop = True
        Me.optArmy.Text = "Army"
        Me.optArmy.UseVisualStyleBackColor = True
        '
        'optArmada
        '
        Me.optArmada.AutoSize = True
        Me.optArmada.Location = New System.Drawing.Point(232, 210)
        Me.optArmada.Name = "optArmada"
        Me.optArmada.Size = New System.Drawing.Size(151, 36)
        Me.optArmada.TabIndex = 7
        Me.optArmada.TabStop = True
        Me.optArmada.Text = "Armada"
        Me.optArmada.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(773, 44)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "4 )     What is the name for a group of Frogs?"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 594)
        Me.Controls.Add(Me.Nextbtn)
        Me.Controls.Add(Me.optCroak)
        Me.Controls.Add(Me.optRibbit)
        Me.Controls.Add(Me.optArmy)
        Me.Controls.Add(Me.optArmada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nextbtn As Button
    Friend WithEvents optCroak As RadioButton
    Friend WithEvents optRibbit As RadioButton
    Friend WithEvents optArmy As RadioButton
    Friend WithEvents optArmada As RadioButton
    Friend WithEvents Label1 As Label
End Class
