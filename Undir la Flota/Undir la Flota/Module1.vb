Module Module1

    Sub Main()
        Dim intentos As Integer = 0
        Dim aleatorio As Random = New Random
        Dim matriz(5, 5) As Integer
        Dim cero As Integer = 0
        Dim ataque1 As Integer = 0
        Dim ataque2 As Integer = 0
        Dim cont As Integer = 0
        Dim aciertos As Integer = 0
        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                matriz(i, j) = aleatorio.Next
            Next
        Next

        For i As Integer = aleatorio.Next(0, 5) To matriz.GetUpperBound(0) + 1 Step 1
            For j As Integer = aleatorio.Next(0, 5) To matriz.GetUpperBound(1) + 1 Step 1

                matriz(i, j) = cero
                cont += 1
                If cont = 3 Then
                    Exit For
                End If
            Next
            If cont >= 3 Then
                Exit For
            End If
        Next

        Do
            Console.WriteLine("Escribe la primera cordenada del barco(Entre 0 y 5) : ")
            ataque1 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Escribe la segunda cordenada del barco(Entre 0 y 5) : ")
            ataque2 = Convert.ToInt32(Console.ReadLine())



            If matriz(ataque1, ataque2) = 0 Then
                Console.WriteLine("Le has dado")
                aciertos += 1
            Else
                Console.WriteLine("No le has dado, intentos -1")
                intentos += 1
            End If
        Loop While intentos < 6 Or aciertos < 3
        Console.ReadLine()
    End Sub

End Module
