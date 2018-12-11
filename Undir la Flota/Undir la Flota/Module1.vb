Module Module1

    Sub Main()
        Dim intentos As Integer = 0
        Dim aleatorio As Random = New Random
        Dim matriz(4, 4) As Integer
        Dim cero As Integer = 0
        Dim ataque1 As Integer = 0
        Dim ataque2 As Integer = 0
        Dim cont As Boolean = True
        Dim aciertos As Integer = 0
        Dim contadorI As Integer = 0
        Dim contadorJ As Integer = 0

        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                matriz(i, j) = aleatorio.Next(0, 9)
            Next
        Next

        For i As Integer = aleatorio.Next(0, 4) To matriz.GetUpperBound(0) Step 1
            contadorI += 1
            For j As Integer = aleatorio.Next(0, 4) To matriz.GetUpperBound(1) Step 1
                If contadorI >= 3 Then
                    cont = False
                    Exit For
                ElseIf contadorJ >= 3 Then
                    Exit For
                End If
                contadorJ += 1
                If cont = True Then
                    matriz(i, j) = cero
                End If


            Next
            If cont = False Then
                Exit For
            End If
        Next

        Dim copia(4, 4) As Integer
        For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
            For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                copia(i, j) = matriz(i, j)
            Next

        Next

        Do
            Console.WriteLine("Escribe la primera cordenada del barco(Entre 0 y 5) : ")
            ataque1 = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Escribe la segunda cordenada del barco(Entre 0 y 5) : ")
            ataque2 = Convert.ToInt32(Console.ReadLine())

            For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                    copia(i, j) = 0
                    Console.Write(copia(i, j) & " ")
                Next
                Console.WriteLine()
            Next
            copia(ataque1 - 1, ataque2 - 1) = matriz(ataque1 - 1, ataque2 - 1)
            Console.ReadLine()
            If matriz(ataque1 - 1, ataque2 - 1) = 0 Then
                Console.WriteLine("Le has dado")
                aciertos += 1
                For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                        Console.Write(copia(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next

            Else
                Console.WriteLine("No le has dado, intentos -1")
                intentos += 1
                For i As Integer = 0 To matriz.GetUpperBound(0) Step 1
                    For j As Integer = 0 To matriz.GetUpperBound(1) Step 1
                        Console.Write(matriz(i, j) & " ")
                    Next
                    Console.WriteLine()
                Next
                If aciertos >= 3 Then
                    Console.WriteLine("Has ganado")
                    Exit Select
                End If
            End If
            If intentos >= 6 Then
                Console.WriteLine("Se te acabaron los intentos")
                Exit Select
            End If
        Loop
        Console.ReadLine()
    End Sub

End Module
