Imports System

Module Program
    Sub Main(args As String())
        Dim Contador03 As Integer = 1

        Do
            Dim opcao As Integer

            Console.Write("Digite um número de 1 a 3: ")
            opcao = Integer.Parse(Console.ReadLine())

            Select Case opcao
                Case 1
                    Console.WriteLine("Você escolheu a opção 1.")
                Case 2
                    Console.WriteLine("Você escolheu a opção 2.")
                Case 3
                    Console.WriteLine("Você escolheu a opção 3.")
                Case Else
                    Console.WriteLine("Opção inválida.")
            End Select
        Loop While Contador03 <= 5


        Console.ReadKey()
    End Sub
End Module
