Public Interface IVenta

    Function getAllVentas() As DataTable
    Function getVentaById(IdVenta As Integer) As DataTable

    Function getVentaByIdClient(_IdCliente As Integer) As DataTable

    Function insertVenta(_venta As Venta) As Integer

    Function updateVentaAmount(IdVenta As Integer) As Boolean

    Function deleteVenta(IdVenta As Integer) As Boolean

End Interface
