Public Interface IProducto
    Inherits IConnection

    Function getProducto() As DataTable
    Function getProductoByName(_descripcion As String) As DataTable
    Function insertProducto(_producto As Producto) As Boolean

    Function updateProducto(_producto As Producto) As Boolean

    Function deleteProducto(Id As Integer) As Boolean
End Interface
