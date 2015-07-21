Public Class game
    Shadows Const WIDTH As Integer = 28
    Shadows Const HEIGHT As Integer = 31
    Dim curPos As coord
    Dim map(HEIGHT, WIDTH) As PictureBox ' Computers index (y, x)

    Private Sub init() Handles Me.Load
        Console.WriteLine("Initializing map with width: " + WIDTH + " height: " + HEIGHT)
    End Sub

    Private Sub initial_render()
        For y As Integer = 0 To HEIGHT - 1
            For x As Integer = 0 To WIDTH - 1
                map(y, x).Top = 0
                map(y, x).Left = 0
            Next
        Next
    End Sub
End Class

Public Structure coord
    Public y As Integer
    Public x As Integer
End Structure
