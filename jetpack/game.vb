Public Class game
    Dim render As New List(Of Sprite)
    Const PLAYER_GRAVITY As Decimal = 0.6
    Const X_DIR As Boolean = True
    Const Y_DIR As Boolean = False
    Dim FISH_1_HASH As Integer = My.Resources.fish_1.GetHashCode()
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

    Private Function isLegalMovement(pos As Integer, dir As Boolean, vel As Decimal) As Boolean
        Return True
    End Function

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles EventLoop.Tick
        For i As Integer = 0 To render.Count() - 1
            Dim obj = render.Item(i)
            Select Case obj.id
                Case "PLAYER"
                    'gravity
                    If True Then ' TODO: above ground
                        obj.vel.Y += PLAYER_GRAVITY
                    End If
                Case "FISH"
                    If obj.img.GetHashCode() = FISH_1_HASH Then
                        obj.img = My.Resources.fish_2
                    Else
                        obj.img = My.Resources.fish_1
                    End If
                    If Not isLegalMovement(obj.coord.X, X_DIR, obj.vel.X) Then
                        obj.vel.X *= -1
                    End If
            End Select

            'Keyboard capture
            If GetAsyncKeyState(Convert.ToInt32(Keys.A)) Then
            End If
            If GetAsyncKeyState(Convert.ToInt32(Keys.W)) Then
            End If
            If GetAsyncKeyState(Convert.ToInt32(Keys.D)) Then
            End If
            If GetAsyncKeyState(Convert.ToInt32(Keys.S)) Then
            End If

            'update positions
            If isLegalMovement(obj.coord.X, X_DIR, obj.vel.X) Then
                obj.coord.X += obj.vel.X
            End If
            If isLegalMovement(obj.coord.Y, Y_DIR, obj.vel.Y) Then
                obj.coord.Y += obj.vel.Y
            End If
            render.Item(i) = obj
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
        Dim fish = initSprite(My.Resources.fish_1, 400, 200, "FISH", 5)
        render.Add(player)
        render.Add(fish)
        EventLoop.Interval = 1000 / 30
        EventLoop.Enabled = True
    End Sub
End Class
