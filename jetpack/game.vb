Public Class game
    Dim locationasd As New Point(0, 0)

    Public Sub draw(ByVal e As PaintEventArgs, img As Image, coords As Point)
        ' Create rectangle for displaying image.
        Dim destRect As New Rectangle(coords.X, coords.Y, img.Width, img.Height)

        ' Draw image to screen.
        e.Graphics.DrawImage(img, destRect)
    End Sub


    Private Sub init() Handles Me.Activated

    End Sub

    Private Sub clearScreen(sender As System.Object, e As System.EventArgs) Handles universalTick.Tick
        Me.Invalidate()
    End Sub
End Class

Public Class SpriteMaster
    Dim currentPosition As New Point(0, 0)
    Dim xVector As Decimal = 0
    Dim yVector As Decimal = 0
End Class

Public Class player : Inherits SpriteMaster
    Dim character As Graphics = Graphics.FromImage(My.Resources.mario)
    draw(character, currentPosition)
End Class

Public Class enemy : Inherits SpriteMaster
End Class