Imports System.Data

Public Interface ICliente
    Inherits IConnection

    Function getCliente() As DataTable

    Function getClientebyName(_descripcion As String) As DataTable
    Function insertCliente(_cliente As Cliente) As Boolean

    Function updateCliente(_cliente As Cliente) As Boolean

    Function deleteCliente(Id As Integer) As Boolean
End Interface
