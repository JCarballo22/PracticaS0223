Module Module1

    Sub Main()
        'Tipos de datos numeros
        Dim numero As Integer = 12
        Dim pulgada As Double = 2.54
        'Tipos de caracter
        Dim letra As Char = "a"
        Dim cadena As String = "Programación II"
        'Tipo de Booleano
        Dim condicion As Boolean = False

        Console.WriteLine(numero)
        Console.WriteLine(pulgada)
        Console.WriteLine(letra)
        Console.WriteLine(cadena)
        Console.WriteLine(condicion)

        Dim num1 As Integer = 1
        Dim num2 As Integer = 1
        Dim suma As Integer = num1 + num2
        Console.WriteLine("Numero 1 = " & num1 & " Numero 2 = " & num2 & " Suma = " & suma)
        Console.WriteLine("La variable cadena = " + cadena)
        Console.WriteLine(num1)

        Dim numD1 As Double = 1.4, numD2 As Double = 1.7, sumaD As Double = numD1 + numD2

        Console.WriteLine(numD1 & " + " & numD2 & " + " & " = " & sumaD)

        Dim numF As Single = 1.5
        Dim sumaDF = numD1 + numF
        Console.WriteLine("La variable numF =" & numF.GetType.ToString())
        Console.WriteLine("La suma de un numero Flotante y un Double =" & sumaDF.GetType.ToString())

        'Declaraciones de variables Explicitas e implicitas
        Dim cadenaExplicita As String = "Programación II - 2023"
        Dim cadenaImplicita = "Programación II - 2023"
        Console.WriteLine("Variable Explicita = " & cadenaExplicita.GetType.ToString)
        Console.WriteLine("Variable Implicita = " & cadenaImplicita.GetType.ToString)

        Dim numExplicita As Double = 5.4
        Dim numImplicita = 5.4
        Console.WriteLine("Variable Explicita = " & numExplicita.GetType.ToString)
        Console.WriteLine("Variable implicita = " & numImplicita.GetType.ToString)

        Dim floatExplicita As Single = 4.5
        Dim floatImplicita = 4.5F
        Console.WriteLine("Variable Explicita = " & floatExplicita.GetType.ToString)
        Console.WriteLine("Variable Implicita = " & floatImplicita.GetType.ToString)

        NuevaR()

        Dim materia = "Programación II"
        'materia = materia.ToUpper()
        materia = materia.ToLower()

        Console.WriteLine(materia)


    End Sub

    Sub NuevaR()

        Dim edad As Byte
        edad = 25

        Call OtraR(edad)
        Console.WriteLine(edad)

    End Sub

    Sub OtraR(ByRef edad As Byte)
        'Console.WriteLine(edad * 2)
        edad = edad * 2
    End Sub

End Module
