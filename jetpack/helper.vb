Public Class Globals
    Public Shared Function random_num(lowerbound As Integer, upperbound As Integer) As Integer
        Return CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
    End Function

    Public Shared Function modulus(a As Integer, b As Integer) As Integer
        Dim i As Integer = 0
        While a - b >= 0
            i += 1
            a -= b
        End While
        Return i
    End Function
End Class