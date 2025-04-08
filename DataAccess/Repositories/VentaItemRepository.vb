Imports System.Data.SqlClient

Public Class VentaItemRepository
    Inherits Connection
    Implements IVentaItem

    Public Function updateVentaItem(_ventaItem As VentaItem) As Boolean Implements IVentaItem.updateVentaItem
        Dim SqlQuery As String = "INSERT INTO ventasitems(IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) 
                              VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Try
            Connect()

            Dim Command As New SqlCommand(SqlQuery, Connector)
            Command.Parameters.AddWithValue("@IDVenta", _ventaItem.IdVenta)
            Command.Parameters.AddWithValue("@IDProducto", _ventaItem.IdProducto)
            Command.Parameters.AddWithValue("@PrecioUnitario", _ventaItem.PrecioUnitario)
            Command.Parameters.AddWithValue("@Cantidad", _ventaItem.Cantidad)
            Command.Parameters.AddWithValue("@PrecioTotal", _ventaItem.PrecioTotal)

            Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MessageBox.Show("Error al agregar detalle de la venta: " & ex.Message)
            Return False

        Finally
            Disconnect()
        End Try
    End Function
    Public Function insertVentaItem(_ventasitem As List(Of VentaItem), IdVenta As Integer) As Boolean Implements IVentaItem.insertVentaItem
        Dim SqlQuery As String = "INSERT INTO ventasitems(IDVenta, IDProducto, PrecioUnitario, Cantidad, PrecioTotal) 
                              VALUES (@IDVenta, @IDProducto, @PrecioUnitario, @Cantidad, @PrecioTotal)"

        Try
            Connect()

            For Each item In _ventasitem
                Dim Command As New SqlCommand(SqlQuery, Connector)
                Command.Parameters.AddWithValue("@IDVenta", IdVenta)
                Command.Parameters.AddWithValue("@IDProducto", item.IdProducto)
                Command.Parameters.AddWithValue("@PrecioUnitario", item.PrecioUnitario)
                Command.Parameters.AddWithValue("@Cantidad", item.Cantidad)
                Command.Parameters.AddWithValue("@PrecioTotal", item.PrecioTotal)

                Command.ExecuteNonQuery()
            Next

            Return True

        Catch ex As Exception
            MessageBox.Show("Error al insertar detalle de la venta: " & ex.Message)
            Return False

        Finally
            Disconnect()
        End Try
    End Function

    Public Function deleteVentaItem(IdVentaDetalle As Integer) As Boolean Implements IVentaItem.deleteVentaItem
        Dim SqlQuery As String = "DELETE FROM ventasitems WHERE ID = @IdVentaDetalle"

        Try
            Connect()

            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IdVentaDetalle", IdVentaDetalle)

            Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MessageBox.Show("Error al modificar detalle de la venta: " & ex.Message)
            Return False

        Finally
            Disconnect()
        End Try
    End Function



    Public Function deleteVentaDetalle(IdVenta As Integer) As Boolean Implements IVentaItem.deleteVentaDetalle
        Dim SqlQuery As String = "DELETE FROM ventasitems WHERE IDVenta = @IdVenta"

        Try
            Connect()

            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@IdVenta", IdVenta)

            Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            MessageBox.Show("Error al modificar detalle de la venta: " & ex.Message)
            Return False

        Finally
            Disconnect()
        End Try
    End Function
End Class
