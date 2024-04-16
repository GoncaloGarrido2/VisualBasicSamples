Imports System

Module Program
    Sub Main(args As String())

        'Operador <

        'Operador <=

        'Operador >

        'Operador >=

        'Operador =

        'Operador <>

        Dim Valor01 As Integer
        Dim Valor02 As Integer

        Console.Write("Insira o primeiro Valor:")
        Valor01 = Integer.Parse(Console.ReadLine())

        Console.Write("Insira o segundo Valor:")
        Valor02 = Integer.Parse(Console.ReadLine())

        Console.WriteLine(" ------- Resultados ------")

        If Valor01 = Valor02 Then
            Console.WriteLine("Os Valores sao Iguais")
        End If

        If Valor01 <Valor02 Then
            Console.WriteLine("O valor 1 é maior")
        End If

        If Valor01 > Valor02 Then
            Console.WriteLine("O Valor 2 é maior")
        End If

        If Valor01 <> Valor02 Then
            Console.WriteLine("Os Valores sao Diferentes")
        End If

    End Sub
End Module
