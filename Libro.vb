Public Class Libro
    Inherits Producto

    Public Sub New(ByVal titulo As String, ByVal precio As Double, ByVal costo As Double)
        MyBase.New(titulo, precio, costo)
    End Sub

    Public Overrides Function imprimirDatos() As String
        Return "Book: " & nombreProducto & " Price: " & precioVenta
    End Function
End Class
