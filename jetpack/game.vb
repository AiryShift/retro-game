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

    Private Function isLegalMovement(obj As Sprite, Optional dir As Integer = CHECKDIR_NONE) As Boolean
        'If no direction is provided, check both direction vectors, returning true/false
        'If a direction is provided, return true/false if that vector is valid
        If dir = CHECKDIR_X Or dir = CHECKDIR_NONE Then
            If obj.coord.X + obj.vel.X < 0 Or obj.coord.X + obj.vel.X > Me.Width - obj.img.Width Then
                Return False
            End If
        End If
        If dir = CHECKDIR_Y Or dir = CHECKDIR_NONE Then
            If obj.coord.Y + obj.vel.Y < 0 Or obj.coord.Y + obj.vel.Y > Me.Height - obj.img.Height Then
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub updateSprites(sender As System.Object, e As System.EventArgs) Handles EventLoop.Tick
        For i As Integer = 0 To render.Count() - 1
            Dim obj = render.Item(i)
            Select Case obj.id
                Case "PLAYER"
                Case "FISH"
                    If Not isLegalMovement(obj, CHECKDIR_X) Then
                        obj.vel.X *= -1
                    End If
                    If Not isLegalMovement(obj, CHECKDIR_Y) Then
                        obj.vel.Y = -30
                    End If
            End Select
            If True Then ' TODO: above ground
                obj.vel.Y += GRAVITY
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
            If isLegalMovement(obj) Then
                obj.coord.X += obj.vel.X
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


    Private Sub init() Handles Me.GotFocus
        Dim player = New Sprite(My.Resources.mario, 200, 200, "PLAYER")
        Dim fish = New Sprite(My.Resources.fish_1, 400, 200, "FISH", 10)
        render.Add(player)
        render.Add(fish)
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
