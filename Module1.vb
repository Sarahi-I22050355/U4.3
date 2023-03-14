Module Module1
    Sub Main()
        Dim miLibro As New Libro("Programming Fundamentals", 54.95, 39.95)
        Dim miDVD As New DVD("Java Multimedia Course", 29.95, 19.95)

        Console.WriteLine("The data of my products.")
        Console.WriteLine(miLibro.imprimirDatos())
        Console.WriteLine(miDVD.imprimirDatos())

        Console.WriteLine("press enter for close.")
        Console.ReadLine()
    End Sub
End Module
