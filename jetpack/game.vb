Public Class game
    Dim render As New List(Of Sprite)
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort
    Structure Direction
        Dim X As Decimal
        Dim Y As Decimal
    End Structure

    Structure Sprite
        Dim coord As Point
        Dim img As Image
        Dim dir As Direction
    End Structure

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles universalTick.Tick
        Me.Invalidate()
    End Sub

    Private Sub draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        For Each i As Sprite In render
            e.Graphics.DrawImage(i.img, i.coord.X, i.coord.Y)
        Next
    End Sub

    Private Sub init() Handles Me.GotFocus
        Dim player As New Sprite
        player.coord.X = 200
        player.coord.Y = 200
        player.img = My.Resources.test
        render.Add(player)
        universalTick.Enabled = True
    End Sub
End Class
