Imports System.Data.SqlClient

Public Class VentaRepository
    Inherits Connection
    Implements IVenta


    Public Function updateVentaAmount(IdVenta As Integer) As Boolean Implements IVenta.updateVentaAmount
        Dim SqlQuery As String = "UPDATE ventas SET Total = (SELECT SUM(PrecioTotal) FROM ventasitems WHERE IDVenta = @IdVenta) WHERE ID = @IdVenta"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IdVenta", IdVenta)

            Command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Disconnect()
        End Try
    End Function

    Public Function getAllVentas() As DataTable Implements IVenta.getAllVentas
        Dim SqlQuery As String = "SELECT V.ID AS IDVenta ,V.Fecha, V.Total, C.ID AS IdCliente , c.Cliente FROM ventas V
                                  INNER JOIN clientes C ON C.ID = V.IDCliente"

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
    Public Function getVentaByIdClient(_IdCliente As Integer) As DataTable Implements IVenta.getVentaByIdClient
        Dim SqlQuery As String = "SELECT V.ID AS IDVenta ,V.Fecha, V.Total, C.ID AS IdCliente , c.Cliente FROM ventas V
                                  INNER JOIN clientes C ON C.ID = V.IDCliente WHERE C.ID = @IdCliente"

        Dim TableResult As New DataTable()

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IdCliente", _IdCliente)

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



    Public Function getVentaById(IdVenta As Integer) As DataTable Implements IVenta.getVentaById
        Dim SqlQuery As String = "SELECT VI.ID AS IdVentaDetalle, VI.IDVenta, P.Nombre AS Articulo,
                                        P.Precio AS PrecioUnitario, VI.Cantidad, VI.PrecioTotal AS Subtotal,
                                        C.ID IdCliente ,C.Cliente, V.Fecha FROM ventasitems VI 
                                        INNER JOIN ventas V ON V.ID = VI.IDVenta
                                        INNER JOIN productos P ON P.ID = VI.IDProducto
                                        INNER JOIN clientes C ON C.ID = V.IDCliente
                                        WHERE VI.IDVenta = @IdVenta"

        Dim TableResult As New DataTable()

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IdVenta", IdVenta)

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

    Public Function insertVenta(_venta As Venta) As Integer Implements IVenta.insertVenta
        Dim SqlQuery As String = "INSERT INTO ventas(IDCliente,Fecha,Total) VALUES (@IDCliente,@Fecha,@Total); SELECT SCOPE_IDENTITY();"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IDCliente", _venta.IdCliente)
            Command.Parameters.AddWithValue("@Fecha", _venta.Fecha)
            Command.Parameters.AddWithValue("@Total", _venta.Total)

            Dim newId As Integer = Convert.ToInt32(Command.ExecuteScalar())
            Return newId

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return -1
        Finally
            Disconnect()
        End Try
    End Function

    Public Function deleteVenta(IdVenta As Integer) As Boolean Implements IVenta.deleteVenta
        Dim SqlQuery As String = "DELETE FROM ventas WHERE ID = @IdVenta"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IdVenta", IdVenta)

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
