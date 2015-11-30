Module Module1

    Sub Main()
        Dim answer As Integer
        Dim a As Boolean

        Console.Beep(523, 1000)
        Console.ReadLine()
        Console.ForegroundColor = ConsoleColor.Green
        For i = 1 To 10
            Console.WriteLine("Hello everypony")
        Next
        Do
            Try
                Console.WriteLine("Introduce un numero del 1 al 15")
                answer = Console.ReadLine()
                a = True
            Catch ex As Exception
                a = False
            End Try
        Loop Until a
        Console.ForegroundColor = answer
        For i = 1 To 10
            Console.WriteLine("Hello everypony")
        Next
        Console.ReadLine()
    End Sub

End Module
