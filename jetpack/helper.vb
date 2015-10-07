Public Class Globals
    Public Shared Function random_num(lowerbound As Integer, upperbound As Integer) As Integer
        Return CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    End Function

    Public Shared Function modulus(a As Integer, b As Integer) As Integer
        While a - b >= 0
            a -= b
        End While
        Return a
    End Function
End Class