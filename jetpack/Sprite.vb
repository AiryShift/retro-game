Public Structure Velocity
    Dim X As Decimal
    Dim Y As Decimal
End Structure

Public Class Sprite
    Public coord As Point
    Public img As Image
    Public vel As Velocity
    Public id As String

    Public Sub New(imgIn As Image, x As Integer, y As Integer, Optional idIn As String = "", Optional xV As Decimal = 0, Optional yV As Decimal = 0)
        img = imgIn
        coord.X = x
        coord.Y = y
        id = idIn
        vel.X = xV
        vel.Y = yV
    End Sub
End Class