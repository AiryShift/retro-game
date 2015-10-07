<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class game
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
        Me.components = New System.ComponentModel.Container()
        Me.EventLoop = New System.Windows.Forms.Timer(Me.components)
        Me.SecondsLoop = New System.Windows.Forms.Timer(Me.components)
        Me.score = New System.Windows.Forms.Label()
        Me.lose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'EventLoop
        '
        '
        'SecondsLoop
        '
        Me.SecondsLoop.Interval = 1000
        '
        'score
        '
        Me.score.AutoSize = True
        Me.score.Font = New System.Drawing.Font("Jokerman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.ForeColor = System.Drawing.Color.White
        Me.score.Location = New System.Drawing.Point(419, 9)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(50, 55)
        Me.score.TabIndex = 0
        Me.score.Text = "0"
        Me.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lose
        '
        Me.lose.Font = New System.Drawing.Font("Jokerman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lose.Location = New System.Drawing.Point(12, 597)
        Me.lose.Name = "lose"
        Me.lose.Size = New System.Drawing.Size(1060, 53)
        Me.lose.TabIndex = 1
        Me.lose.Text = "You lose, press here to exit"
        Me.lose.UseVisualStyleBackColor = True
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.lose)
        Me.Controls.Add(Me.score)
        Me.DoubleBuffered = True
        Me.Name = "game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EventLoop As System.Windows.Forms.Timer
    Friend WithEvents SecondsLoop As System.Windows.Forms.Timer
    Friend WithEvents score As System.Windows.Forms.Label
    Friend WithEvents lose As System.Windows.Forms.Button

End Class
