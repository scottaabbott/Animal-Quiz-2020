<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class score
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
        Me.scoretxt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'scoretxt
        '
        Me.scoretxt.AutoSize = True
        Me.scoretxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoretxt.Location = New System.Drawing.Point(355, 178)
        Me.scoretxt.Name = "scoretxt"
        Me.scoretxt.Size = New System.Drawing.Size(0, 83)
        Me.scoretxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 61)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "And your Final Score is......"
        '
        'score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scoretxt)
        Me.Name = "score"
        Me.Text = "score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents scoretxt As Label
    Friend WithEvents Label1 As Label
End Class
