Imports Microsoft.Reporting.WinForms

Public Class FrmReportVenta
    Private ReadOnly _ventaService As VentaService

    Public Sub New(IdVenta As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim ventaRepository As IVenta = New VentaRepository()
        _ventaService = New VentaService(ventaRepository)

        CargarInforme(IdVenta)
    End Sub

    Private Sub CargarInforme(IdVenta As Integer)
        Dim TablaVentaItem As DataTable

        TablaVentaItem = _ventaService.getVentaById(IdVenta)

        Dim CuerpoReporte As ReportDataSource
        CuerpoReporte = New ReportDataSource("DSV_VentaItemDetalleById", TablaVentaItem)

        ReportViewer1.LocalReport.DataSources.Clear() 'limpiamos informe por las dudas
        ReportViewer1.LocalReport.DataSources.Add(CuerpoReporte)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
    Private Sub FrmReportVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        ReportViewer1.ZoomPercent = 75
    End Sub
End Class