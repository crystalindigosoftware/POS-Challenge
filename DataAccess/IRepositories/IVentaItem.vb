Public Interface IVentaItem

    Function insertVentaItem(_ventasitem As List(Of VentaItem), IdVenta As Integer) As Boolean

    Function updateVentaItem(_ventaItem As VentaItem) As Boolean
    Function deleteVentaItem(IdVentaDetalle As Integer) As Boolean
    Function deleteVentaDetalle(IdVenta As Integer) As Boolean

End Interface
