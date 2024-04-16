Imports System

Module Program
    Sub Main(args As String())
        '1. Ciclo For
        '    O ciclo For é usado quando você sabe quantas vezes deseja que um bloco de código seja executado.

        For i As Integer = 1 To 5
            Console.WriteLine("Este é o Loop número " & i)
        Next
        '2. Ciclo For Each
        '    O ciclo For Each é usado para iterar sobre cada elemento em uma coleção ou array.

        Dim frutas As String() = {"Maçã", "Banana", "Morango"}

        For Each fruta As String In frutas
            Console.WriteLine(fruta)
        Next
        '3. Ciclo While
        '    O ciclo While é usado quando você deseja que um bloco de código seja executado enquanto uma condição específica For verdadeira.

        Dim contador As Integer = 1

        While contador <= 5
            Console.WriteLine("Este é o Loop número " & contador)
            contador += 1
        End While
        '4. Ciclo Do While
        '    O ciclo Do While é semelhante ao While, mas a condição é verificada no final Do Loop, garantindo que o bloco de código seja executado pelo menos uma vez.

        Dim contador01 As Integer = 1

        Do While contador01 <= 5
            Console.WriteLine("Este é o Loop número " & contador01)
            contador01 += 1
        Loop
        '5. Ciclo Do Until
        '    O ciclo Do Until é o oposto Do Do While, executando o bloco de código até que a condição seja verdadeira.

        Dim contador02 As Integer = 1

        Do Until contador02 > 5
            Console.WriteLine("Este é o Loop número " & contador02)
            contador02 += 1
        Loop
        '6. Ciclo Do
        '    O ciclo Do é usado quando você deseja que um bloco de código seja executado pelo menos uma vez e, em seguida, repetido enquanto uma condição específica For verdadeira.

        Dim Contador03 As Integer = 1

        Do
            Console.WriteLine("Este é o Loop número " & Contador03)
            Contador03 += 1
        Loop While Contador03 <= 5
    End Sub
End Module