Imports System

Module Program
    Sub Main(args As String())
        Dim Contador03 As Integer = 1

        Do
            Dim opcao As Integer

            Console.Write("Digite um n�mero de 1 a 3: ")
            opcao = Integer.Parse(Console.ReadLine())

            Select Case opcao
                Case 1
                    Console.WriteLine("Voc� escolheu a op��o 1.")
                Case 2
                    Console.WriteLine("Voc� escolheu a op��o 2.")
                Case 3
                    Console.WriteLine("Voc� escolheu a op��o 3.")
                Case Else
                    Console.WriteLine("Op��o inv�lida.")
            End Select
        Loop While Contador03 <= 5


        Console.ReadKey()
    End Sub
End Module
