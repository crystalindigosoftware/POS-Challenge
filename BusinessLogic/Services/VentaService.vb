Public Class VentaService

    Private ReadOnly _ventaRepository As IVenta

    Private ReadOnly _ventaItemRepository As IVentaItem
    ' Aplicamos Inyección de Dependencias (DIP)
    Public Sub New(ventaRepository As IVenta, ventaItemRepository As IVentaItem)
        _ventaRepository = ventaRepository
        _ventaItemRepository = ventaItemRepository
    End Sub

    Public Sub New(ventaRepository As IVenta)
        _ventaRepository = ventaRepository
    End Sub
    Public Function insertVentaCompleta(_venta As Venta, _ventasitem As List(Of VentaItem)) As Boolean

        _venta.Fecha = Today

        Dim IdVenta As Integer = _ventaRepository.insertVenta(_venta)

        If _ventaItemRepository.insertVentaItem(_ventasitem, IdVenta) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getVentaById(IdVenta As Integer) As DataTable
        Return _ventaRepository.getVentaById(IdVenta)
    End Function

    Public Function getVentaByIdClient(_IdCliente As Integer) As DataTable
        Return _ventaRepository.getVentaByIdClient(_IdCliente)
    End Function

    Public Function getAllVentas() As DataTable
        Return _ventaRepository.getAllVentas()
    End Function
    Public Function deleteVentaItem(IdVentaDetalle As Integer, IdVenta As Integer) As Boolean
        Dim Resultado As Boolean
        Resultado = _ventaItemRepository.deleteVentaItem(IdVentaDetalle)

        If Resultado = True Then
            Return _ventaRepository.updateVentaAmount(IdVenta)
        End If

        Return False

    End Function

    Public Function updateVentaItem(_ventaItem As VentaItem) As Boolean
        Dim Resultado As Boolean
        Resultado = _ventaItemRepository.updateVentaItem(_ventaItem)

        If Resultado = True Then
            Return _ventaRepository.updateVentaAmount(_ventaItem.IdVenta)
        End If

        Return False
    End Function

    Public Function deleteVentaCompleta(IdVenta As Integer) As Boolean
        If _ventaItemRepository.deleteVentaDetalle(IdVenta) Then
            Return _ventaRepository.deleteVenta(IdVenta)
        End If

        Return True
    End Function
End Class
