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
        Me.ship = New System.Windows.Forms.PictureBox()
        CType(Me.ship, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ship
        '
        Me.ship.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ship.Location = New System.Drawing.Point(337, 317)
        Me.ship.Name = "ship"
        Me.ship.Size = New System.Drawing.Size(30, 30)
        Me.ship.TabIndex = 0
        Me.ship.TabStop = False
        '
        'game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 662)
        Me.Controls.Add(Me.ship)
        Me.Name = "game"
        Me.Text = "Form1"
        CType(Me.ship, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ship As System.Windows.Forms.PictureBox

End Class
