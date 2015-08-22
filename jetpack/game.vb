Public Class game
    Dim render As New List(Of Sprite)
    Const PLAYER_GRAVITY As Decimal = 0.6
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Structure Velocity
        Dim X As Decimal
        Dim Y As Decimal
    End Structure

    Class Sprite
        Public coord As Point
        Public img As Image
        Public vel As Velocity
        Public id As String
    End Class

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles EventLoop.Tick
        For i As Integer = 0 To render.Count() - 1
            Dim obj = render.Item(i)
            Select Case obj.id
                Case "PLAYER"
                    'gravity
                    If True Then ' TODO: above ground
                        obj.vel.Y += PLAYER_GRAVITY
                    End If
                Case Else
            End Select
            'update positions
            obj.coord.X += obj.vel.X
            obj.coord.Y += obj.vel.Y
            render(i) = obj
        Next
        Me.Invalidate()
    End Sub

    Private Sub draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        For Each obj As Sprite In render
            e.Graphics.DrawImage(obj.img, obj.coord.X, obj.coord.Y)
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
        EventLoop.Interval = 1000 / 30
        EventLoop.Enabled = True
    End Sub
End Class
