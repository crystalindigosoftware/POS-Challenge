'Examen de validación de conocimientos para TACTICASOFT
'Uso unicamente con fines validatorios
'Autor : Marcos Enrique Gonzalez
'mgonzalezsoft@outlook.com

Imports System.Data.SqlClient
Public Class Connection

    Implements IConnection

    Protected ConnectionString As String = My.Settings.SqlConnectionString
    Protected Connector As New SqlConnection(ConnectionString)

    Protected Sub Connect()
        Try
            Connector.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Protected Sub Disconnect()
        Try
            If Connector.State = ConnectionState.Open Then
                Connector.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub IConnection_Connect() Implements IConnection.Connect
        Throw New NotImplementedException()
    End Sub

    Private Sub IConnection_Disconnect() Implements IConnection.Disconnect
        Throw New NotImplementedException()
    End Sub
End Class
