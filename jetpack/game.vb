Public Class game
    Dim WithEvents tick As New Timer

    Public Class sprite
        Dim yVector As Decimal = 0
        Dim xVector As Decimal = 0
    End Class

    Private Class player : Inherits sprite
    End Class

    Private Class enemy : Inherits sprite
    End Class

    Private Sub init() Handles Me.Activated

    End Sub
End Class
