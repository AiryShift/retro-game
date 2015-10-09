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
        Me.SpawnLoop = New System.Windows.Forms.Timer(Me.components)
        Me.life = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        'SpawnLoop
        '
        '
        'life
        '
        Me.life.AutoSize = True
        Me.life.Font = New System.Drawing.Font("Jokerman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.life.ForeColor = System.Drawing.Color.White
        Me.life.Location = New System.Drawing.Point(489, 9)
        Me.life.Name = "life"
        Me.life.Size = New System.Drawing.Size(369, 55)
        Me.life.TabIndex = 2
        Me.life.Text = "You have 1 life left!"
        Me.life.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.life.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(258, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 55)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Score:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1084, 662)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.life)
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
    Friend WithEvents SpawnLoop As System.Windows.Forms.Timer
    Friend WithEvents life As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
