Public MustInherit Class Producto
    Protected precioVenta As Double
    Protected costoFabrica As Double
    Protected nombreProducto As String

    Public Sub New(ByVal nombre As String, ByVal precio As Double, ByVal costo As Double)
        nombreProducto = nombre
        costoFabrica = costo
        precioVenta = precio
    End Sub
    Public MustOverride Function ImprimirDatos() As String
End Class
