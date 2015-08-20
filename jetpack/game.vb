Public Class game
    Dim render As New List(Of Sprite)
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Structure Velocity
        Dim X As Decimal
        Dim Y As Decimal
    End Structure

    Structure Sprite
        Dim coord As Point
        Dim img As Image
        Dim vel As Velocity
        Dim id As String
    End Structure

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles universalTick.Tick
        Me.Invalidate()
    End Sub

    Private Sub draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        For Each i As Sprite In render
            e.Graphics.DrawImage(i.img, i.coord.X, i.coord.Y)
        Next
    End Sub

    Private Function initSprite(img As Image, x As Integer, y As Integer, id As String, Optional xV As Decimal = 0, Optional yV As Decimal = 0)
        Dim a As New Sprite
        a.coord.X = x
        a.coord.Y = y
        a.img = img
        a.id = id
        a.vel.X = xV
        a.vel.Y = yV
        Return a
    End Function

    Private Sub init() Handles Me.GotFocus
        Dim player = initSprite(My.Resources.test, 200, 200, "PLAYER")
        render.Add(player)
        universalTick.Enabled = True
    End Sub
End Class
