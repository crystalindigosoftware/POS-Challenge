Imports System.Data.SqlClient
Public Class ProductoRepository
    Inherits Connection
    Implements IProducto

    Public Function getProductoByName(_descripcion As String) As DataTable Implements IProducto.getProductoByName
        Dim SqlQuery As String = "SELECT * FROM productos WHERE Nombre LIKE '%" & _descripcion & "%'"
        Dim TableResult As New DataTable()

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(TableResult)

            Return TableResult
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            Disconnect()
        End Try
    End Function
    Public Function getProducto() As DataTable Implements IProducto.getProducto
        Dim SqlQuery As String = "SELECT * FROM productos"
        Dim TableResult As New DataTable()

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Dim Adapter As New SqlDataAdapter(Command)
            Adapter.Fill(TableResult)

            Return TableResult
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            Disconnect()
        End Try
    End Function

    Public Function insertProducto(_producto As Producto) As Boolean Implements IProducto.insertProducto
        Dim SqlQuery As String = "INSERT INTO productos(Nombre,Precio,Categoria) VALUES (@Nombre,@Precio,@Categoria)"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@Nombre", _producto.Nombre)
            Command.Parameters.AddWithValue("@Precio", _producto.Precio)
            Command.Parameters.AddWithValue("@Categoria", _producto.Categoria)

            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Disconnect()
        End Try
    End Function

    Public Function updateProducto(_producto As Producto) As Boolean Implements IProducto.updateProducto
        Dim SqlQuery As String = "UPDATE productos SET Nombre = @Nombre,Precio=@Precio,Categoria=@Categoria WHERE ID=@ID"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@Nombre", _producto.Nombre)
            Command.Parameters.AddWithValue("@Precio", _producto.Precio)
            Command.Parameters.AddWithValue("@Categoria", _producto.Categoria)
            Command.Parameters.AddWithValue("@ID", _producto.Id)

            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Disconnect()
        End Try
    End Function

    Public Function deleteProducto(Id As Integer) As Boolean Implements IProducto.deleteProducto
        Dim SqlQuery As String = "DELETE FROM productos WHERE ID=@ID"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@ID", Id)

            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Disconnect()
        End Try
    End Function
End Class
