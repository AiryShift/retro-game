Public Class Globals
    Public Shared Function random_num(lowerbound As Integer, upperbound As Integer) As Integer
        Return CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    End Function
End Class