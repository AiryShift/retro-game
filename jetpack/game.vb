Public Class game
    Dim drawing As Sprite()

    Public Class Sprite
        Public coord As Point
        Public img As Bitmap
    End Class

    Public Sub draw(ByVal sender As Object, ByVal e As PaintEventArgs) Handles MyBase.Paint
        For Each i In drawing
            ' Create rectangle for displaying image.
            Dim destRect As New Rectangle(i.coord.X, i.coord.Y, i.img.Width, i.img.Height)

            ' Draw image to screen.
            e.Graphics.DrawImage(i.img, destRect)
        Next
    End Sub

    Private Sub screenUpdate(sender As System.Object, e As System.EventArgs) Handles universalTick.Tick
        Me.Invalidate()
    End Sub

    Private Sub init() Handles Me.Activated
        Dim player As New Sprite
        player.coord.X = 0
        player.coord.Y = 0
        player.img = My.Resources.mario
    End Sub
End Class
