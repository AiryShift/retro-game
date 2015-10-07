Public Class settings
    Dim m_MouseIsDown As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Enable dropping.
        PictureBox2.AllowDrop = True
    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If Not PictureBox1.Image Is Nothing Then
            ' Set a flag to show that the mouse is down.
            m_MouseIsDown = True
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If m_MouseIsDown Then
            ' Initiate dragging and allow either copy or move.
            PictureBox1.DoDragDrop(PictureBox1.Image, DragDropEffects.Copy Or DragDropEffects.Move)
        End If
        m_MouseIsDown = False
    End Sub

    Private Sub PictureBox2_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox2.DragEnter
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            ' Check for the CTRL key. 
            If e.KeyState = 9 Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PictureBox2_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles PictureBox2.DragDrop
        ' Assign the image to the PictureBox.
        PictureBox2.Image = e.Data.GetData(DataFormats.Bitmap)
        ' If the CTRL key is not pressed, delete the source picture.
        If Not e.KeyState = 8 Then
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Hide()
    End Sub
End Class