Imports System

Module Program
    Public Sub Main()
        Dim Estudantes(6) As Integer

        Estudantes(0) = 23
        Estudantes(1) = 19
        Estudantes(2) = 21
        Estudantes(3) = 176
        Estudantes(4) = 19
        Estudantes(5) = 20
        Estudantes(6) = 22

        For ctr As Integer = 0 To 6
            Dim grade As String = If(ctr = 0, "estudantes", $"ano {ctr}")
            Console.WriteLine($"Estudantes em {grade}: {Estudantes(ctr)}")
        Next
    End Sub
End Module
