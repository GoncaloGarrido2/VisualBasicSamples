Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Pi: " + GetPi(2).ToString())
    End Sub
    Public Function GetPi(Val As Double) As Double
        ' Calculate the value of pi.
        Return 4.0 * Math.Atan(1.0)
    End Function
End Module
