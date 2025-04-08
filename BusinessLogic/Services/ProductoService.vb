Public Class ProductoService
    Private ReadOnly _productoRepository As IProducto

    ' Aplicamos Inyección de Dependencias (DIP)
    Public Sub New(productoRepository As IProducto)
        _productoRepository = productoRepository
    End Sub

    Public Function getProducto() As DataTable
        Return _productoRepository.getProducto()
    End Function

    Public Function getProductoByName(_description As String) As DataTable
        Return _productoRepository.getProductoByName(_description)
    End Function

    Public Function insertProducto(_producto As Producto) As Boolean
        Return _productoRepository.insertProducto(_producto)
    End Function

    Public Function updateProducto(_producto As Producto) As Boolean
        Return _productoRepository.updateProducto(_producto)
    End Function

    Public Function deleteProducto(Id As Integer) As Boolean
        Return _productoRepository.deleteProducto(Id)
    End Function
End Class
