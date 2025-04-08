Imports System.Data.SqlClient
Public Class ClienteRepository
    Inherits Connection
    Implements ICliente
    Public Function getCliente() As DataTable Implements ICliente.getCliente
        Dim SqlQuery As String = "SELECT ID, Cliente As [Nombre],Telefono,Correo FROM clientes"
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

    Public Function getClienteByName(_descripcion As String) As DataTable Implements ICliente.getClientebyName
        Dim SqlQuery As String = "SELECT ID, Cliente As [Nombre] FROM clientes WHERE Cliente LIKE '%" & _descripcion & "%'"
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
    Public Function insertCliente(_cliente As Cliente) As Boolean Implements ICliente.insertCliente
        Dim SqlQuery As String = "INSERT INTO clientes(Cliente,Telefono,Correo) VALUES (@Cliente,@Telefono,@Correo)"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@Cliente", _cliente.Cliente)
            Command.Parameters.AddWithValue("@Telefono", _cliente.Telefono)
            Command.Parameters.AddWithValue("@Correo", _cliente.Correo)

            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Disconnect()
        End Try
    End Function

    Public Function updateCliente(_cliente As Cliente) As Boolean Implements ICliente.updateCliente
        Dim SqlQuery As String = "UPDATE clientes SET Cliente = @Cliente,Telefono=@Telefono,Correo=@Correo WHERE ID=@ID"

        Try
            Connect()
            Dim Command As New SqlCommand(SqlQuery)
            Command.CommandType = CommandType.Text
            Command.Connection = Connector

            Command.Parameters.AddWithValue("@Cliente", _cliente.Cliente)
            Command.Parameters.AddWithValue("@Telefono", _cliente.Telefono)
            Command.Parameters.AddWithValue("@Correo", _cliente.Correo)
            Command.Parameters.AddWithValue("@ID", _cliente.Id)

            Command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        Finally
            Disconnect()
        End Try
    End Function

    Public Function deleteCliente(Id As Integer) As Boolean Implements ICliente.deleteCliente
        Dim SqlQuery As String = "DELETE FROM clientes WHERE ID=@ID"

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
