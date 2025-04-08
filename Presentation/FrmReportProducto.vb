Imports System.Data.SqlClient
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class FrmReportProducto
    Private ReadOnly _productoService As ProductoService

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim productoRepository As IProducto = New ProductoRepository()
        _productoService = New ProductoService(productoRepository)

        CargarInforme()
    End Sub
    Private Sub CargarInforme()
        Dim TablaProductos As DataTable

        TablaProductos = _productoService.getProducto()

        Dim CuerpoReporte As ReportDataSource
        CuerpoReporte = New ReportDataSource("DSTacticaSoftProducto", TablaProductos)

        ReportViewer1.LocalReport.DataSources.Clear() 'limpiamos informe por las dudas
        ReportViewer1.LocalReport.DataSources.Add(CuerpoReporte)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
    Private Sub FrmReportProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        ReportViewer1.ZoomPercent = 75

    End Sub
End Class