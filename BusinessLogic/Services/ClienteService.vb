Imports System.Data
Public Class ClienteService
    Private ReadOnly _clienteRepository As ICliente

    ' Aplicamos Inyección de Dependencias (DIP)
    Public Sub New(clienteRepository As ICliente)
        _clienteRepository = clienteRepository
    End Sub

    Public Function getCliente() As DataTable
        Return _clienteRepository.getCliente()
    End Function

    Public Function getClienteByName(_descripcion As String) As DataTable
        Return _clienteRepository.getClientebyName(_descripcion)
    End Function
    Public Function insertCliente(_cliente As Cliente) As Boolean
        Return _clienteRepository.insertCliente(_cliente)
    End Function

    Public Function updateCliente(_cliente As Cliente) As Boolean
        Return _clienteRepository.updateCliente(_cliente)
    End Function

    Public Function deleteCliente(Id As Integer) As Boolean
        Return _clienteRepository.deleteCliente(Id)
    End Function
End Class
