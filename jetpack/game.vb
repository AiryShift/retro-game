Public Class game
    Dim drawing As List(Of Sprite)

    Structure Direction
        Dim X As Decimal
        Dim Y As Decimal
    End Structure

    Structure Sprite
        Dim coord As Point
        Dim img As PictureBox
        Dim dir As Direction
    End Structure

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles universalTick.Tick
        moveSprites()
        draw()
    End Sub

    Public Sub moveSprites()
        For Each i In drawing
            i.coord.X += i.dir.X
            i.coord.Y += i.dir.Y
        Next
    End Sub

    Private Sub draw()
        For Each i In drawing
            i.img.Left = i.coord.X
            i.img.Top = i.coord.Y
        Next
    End Sub

    Private Sub init() Handles Me.GotFocus
        Dim player As New Sprite
        player.coord.X = 200
        player.coord.Y = 200
        player.img.Image = My.Resources.test
        player.img.SizeMode = PictureBoxSizeMode.StretchImage
        drawing.Add(player)

        universalTick.Enabled = True
    End Sub
End Class
