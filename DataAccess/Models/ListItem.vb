Public Class ListItem

    Private _IDText As Integer
    Private _DisplayText As String

    Public Sub New(IDText As Integer, DisplayText As String)
        _IDText = IDText
        _DisplayText = DisplayText
    End Sub

    Public Function GetDisplayText() As String
        Return _DisplayText
    End Function
    Public Sub SetDisplayText(DisplayText As String)
        _DisplayText = DisplayText
    End Sub

    Public Function GetIDText() As String
        Return _IDText
    End Function
    Public Sub SetIDText(IDText As Integer)
        _IDText = IDText
    End Sub

    Public Overrides Function ToString() As String
        Return _DisplayText
    End Function
End Class
