Public Class FrmVentaAgregarItem

    Private ReadOnly _productoService As ProductoService

    Private ReadOnly _ventaService As VentaService
    Private _IdVenta As Integer
    Private _IdCliente As Integer

    Dim TablaBusqueda As DataTable

    Public Property FormularioPadre As FrmConsultaModificacionVenta
    Public Sub New(IdVenta As Integer, IdCliente As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim productoRepository As IProducto = New ProductoRepository()
        _productoService = New ProductoService(productoRepository)

        Dim ventaRepository As IVenta = New VentaRepository()
        Dim ventaItemRepository As IVentaItem = New VentaItemRepository

        _ventaService = New VentaService(ventaRepository, ventaItemRepository)

        _IdVenta = IdVenta
        _IdCliente = IdCliente
    End Sub
    Private Sub TBBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TBBusqueda.TextChanged
        MostrarResultadosBusqueda()
    End Sub

    Private Sub TBBusqueda_LostFocus(sender As Object, e As EventArgs) Handles TBBusqueda.LostFocus
        ' Esperar un poco para permitir el click en dgv antes de ocultarlo
        Me.BeginInvoke(Sub()
                           If Not DGVBusqueda.Focused Then
                               DGVBusqueda.Visible = False
                           End If
                       End Sub)
    End Sub
    Private Sub EstilizarDGVBusqueda()
        With DGVBusqueda
            .BorderStyle = BorderStyle.FixedSingle
            .BackgroundColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
            .AllowUserToResizeRows = False
            .ReadOnly = True
            .MultiSelect = False
            .ScrollBars = ScrollBars.Vertical
        End With
    End Sub
    Private Sub FrmVentaAgregarItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBCantidad.Text = 1
        DGVBusqueda.Visible = False
        EstilizarDGVBusqueda()
    End Sub

    Private Sub DGVBusqueda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVBusqueda.CellClick
        If e.RowIndex >= 0 Then
            AgregarProductoADetalle(DGVBusqueda.Rows(e.RowIndex))
        End If
    End Sub

    Private Sub TBBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBusqueda.KeyDown
        If e.KeyCode = Keys.Enter AndAlso DGVBusqueda.CurrentRow IsNot Nothing Then
            AgregarProductoADetalle(DGVBusqueda.CurrentRow)
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub AgregarProductoADetalle(row As DataGridViewRow)
        Dim Id As Integer = CInt(row.Cells("ID").Value)
        Dim precio As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)
        Dim cantidad As Integer = Convert.ToInt32(TBCantidad.Text)
        Dim preciototal As Decimal = precio * cantidad

        Dim _ventaItem As New VentaItem

        _ventaItem.IdProducto = Id
        _ventaItem.IdVenta = _IdVenta
        _ventaItem.PrecioUnitario = precio
        _ventaItem.Cantidad = cantidad
        _ventaItem.PrecioTotal = preciototal


        'Insertamos el nuevo item en la base de datos
        _ventaService.updateVentaItem(_ventaItem)

        Me.Close()
    End Sub

    Private Sub MostrarResultadosBusqueda()
        Dim filtro As String = TBBusqueda.Text.Trim()

        If filtro.Length >= 2 Then
            TablaBusqueda = _productoService.getProductoByName(filtro) ' Devuelve DataTable

            If TablaBusqueda.Rows.Count > 0 Then
                DGVBusqueda.DataSource = TablaBusqueda

                'Ocultamos campos
                DGVBusqueda.Columns(0).Visible = False
                DGVBusqueda.Columns(3).Visible = False

                DGVBusqueda.Visible = True

                'Redimensionamos
                DGVBusqueda.Columns(1).Width = (TBBusqueda.Width / 2)
                DGVBusqueda.Columns(2).Width = (TBBusqueda.Width / 2)

                DGVBusqueda.Width = TBBusqueda.Width
                DGVBusqueda.Height = Math.Min(150, TablaBusqueda.Rows.Count * 45) ' Máximo 6 resultados

                DGVBusqueda.BringToFront()
            Else
                DGVBusqueda.Visible = False
            End If
        Else
            DGVBusqueda.Visible = False
        End If
    End Sub


    Private Sub DGVBusqueda_LostFocus(sender As Object, e As EventArgs) Handles DGVBusqueda.LostFocus
        DGVBusqueda.Visible = False
    End Sub

    Private Sub FrmVentaAgregarItem_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If FormularioPadre IsNot Nothing Then
            FormularioPadre.CargarListadoVentasByIdCliente(_IdCliente)
        End If
    End Sub

    Private Sub FrmVentaAgregarItem_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If FormularioPadre IsNot Nothing Then
            FormularioPadre.CargarListadoVentasByIdCliente(_IdCliente)
        End If
    End Sub
End Class