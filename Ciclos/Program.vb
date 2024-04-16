Imports System

Module Program
    Sub Main(args As String())
        '1. Ciclo For
        '    O ciclo For � usado quando voc� sabe quantas vezes deseja que um bloco de c�digo seja executado.

        For i As Integer = 1 To 5
            Console.WriteLine("Este � o Loop n�mero " & i)
        Next
        '2. Ciclo For Each
        '    O ciclo For Each � usado para iterar sobre cada elemento em uma cole��o ou array.

        Dim frutas As String() = {"Ma��", "Banana", "Morango"}

        For Each fruta As String In frutas
            Console.WriteLine(fruta)
        Next
        '3. Ciclo While
        '    O ciclo While � usado quando voc� deseja que um bloco de c�digo seja executado enquanto uma condi��o espec�fica For verdadeira.

        Dim contador As Integer = 1

        While contador <= 5
            Console.WriteLine("Este � o Loop n�mero " & contador)
            contador += 1
        End While
        '4. Ciclo Do While
        '    O ciclo Do While � semelhante ao While, mas a condi��o � verificada no final Do Loop, garantindo que o bloco de c�digo seja executado pelo menos uma vez.

        Dim contador01 As Integer = 1

        Do While contador01 <= 5
            Console.WriteLine("Este � o Loop n�mero " & contador01)
            contador01 += 1
        Loop
        '5. Ciclo Do Until
        '    O ciclo Do Until � o oposto Do Do While, executando o bloco de c�digo at� que a condi��o seja verdadeira.

        Dim contador02 As Integer = 1

        Do Until contador02 > 5
            Console.WriteLine("Este � o Loop n�mero " & contador02)
            contador02 += 1
        Loop
        '6. Ciclo Do
        '    O ciclo Do � usado quando voc� deseja que um bloco de c�digo seja executado pelo menos uma vez e, em seguida, repetido enquanto uma condi��o espec�fica For verdadeira.

        Dim Contador03 As Integer = 1

        Do
            Console.WriteLine("Este � o Loop n�mero " & Contador03)
            Contador03 += 1
        Loop While Contador03 <= 5
    End Sub
End Module