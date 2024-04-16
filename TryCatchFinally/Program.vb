Imports System

Module Program
    Sub Main(args As String())
        Dim x As Integer = 5
        Dim y As Integer = 0

        Try
            x = x \ y

            Console.WriteLine("Fim do bloco")
        Catch ex As Exception
            Console.WriteLine(ex.Message)

            Console.WriteLine("Erro: " & vbCrLf & ex.Message)
        Finally
            Console.WriteLine("Final do Programa")
        End Try
    End Sub
End Module
