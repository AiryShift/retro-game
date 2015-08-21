Public Class game
    Dim render As New List(Of Sprite)
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Class Velocity
        Public X As Decimal
        Public Y As Decimal
    End Class

    Class Sprite
        Public coord As Point
        Public img As Image
        Public vel As Velocity
        Public id As String
    End Class

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles universalTick.Tick
        For i As Integer = 0 To render.Count()
            Dim obj = render(i)

            If obj.id = "PLAYER" Then
            End If
            'gravity
            If True Then ' TODO: above ground
                obj.vel.Y -= 0.2
            End If

            render(i) = obj
        Next
        Me.Invalidate()
    End Sub

    Private Sub draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        For i As Integer = 0 To render.Count()
            Dim obj = render(i)
            'update positions
            obj.coord.X += obj.vel.X
            obj.coord.Y += obj.vel.Y
            e.Graphics.DrawImage(obj.img, obj.coord.X, obj.coord.Y)
            render(i) = obj
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
