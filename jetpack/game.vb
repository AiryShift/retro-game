Public Class game
    Dim render As New List(Of Sprite)
    Const LOOP_SPEED As Integer = 1000 / 40
    Const GRAVITY As Decimal = 0.9
    Const X_DIR As Boolean = True
    Const Y_DIR As Boolean = False
    Const CHECKDIR_NONE As Integer = 0
    Const CHECKDIR_X As Integer = 1
    Const CHECKDIR_Y As Integer = 2
    Public Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As Int32) As UShort

    Private Function isLegalMovement(sprite As Sprite, Optional dir As Integer = CHECKDIR_NONE) As Boolean
        'If no direction is provided, check both direction vectors, returning true/false
        'If a direction is provided, return true/false if that vector is valid
        If dir = CHECKDIR_X Or dir = CHECKDIR_NONE Then
            If sprite.coord.X + sprite.vel.X < 0 Or sprite.coord.X + sprite.vel.X > Me.Width - sprite.img.Width Then
                Return False
            End If
        End If
        If dir = CHECKDIR_Y Or dir = CHECKDIR_NONE Then
            If sprite.coord.Y + sprite.vel.Y < 0 Or sprite.coord.Y + sprite.vel.Y > Me.Height - sprite.img.Height Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles EventLoop.Tick
        For i As Integer = 0 To render.Count() - 1
            Dim sprite = render.Item(i)
            Select Case sprite.id
                Case "PLAYER"
                Case "FISH"
                    If Not isLegalMovement(sprite, CHECKDIR_X) Then
                        sprite.vel.X *= -1
                    End If
                    If Not isLegalMovement(sprite, CHECKDIR_Y) Then
                        sprite.vel.Y = -30
                    End If
            End Select
            If True Then ' TODO: above ground
                sprite.vel.Y += GRAVITY
            End If

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
            If isLegalMovement(sprite) Then
                sprite.coord.X += sprite.vel.X
                sprite.coord.Y += sprite.vel.Y
            End If
            render.Item(i) = sprite
        Next
        Me.Invalidate()
    End Sub

    Private Sub draw(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        For Each sprite As Sprite In render
            e.Graphics.DrawImage(sprite.img, sprite.coord.X, sprite.coord.Y)
        Next
    End Sub

    Private Sub addToDrawing(sprite As Sprite)
        render.Add(sprite)
    End Sub

    Private Sub init() Handles Me.GotFocus
        addToDrawing(New Sprite(My.Resources.mario, 200, 200, "PLAYER"))
        addToDrawing(New Sprite(My.Resources.fish_1, 400, 200, "FISH", 10))
        EventLoop.Interval = LOOP_SPEED
        EventLoop.Enabled = True
    End Sub

    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property
End Class
