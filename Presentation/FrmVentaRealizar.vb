Public Class FrmVentaRealizar

    Private ReadOnly _productoService As ProductoService

    Private ReadOnly _clienteService As ClienteService

    Private ReadOnly _ventaService As VentaService

    Dim TablaBusqueda As DataTable
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim productoRepository As IProducto = New ProductoRepository()
        _productoService = New ProductoService(productoRepository)

        Dim clienteRepository As ICliente = New ClienteRepository()
        _clienteService = New ClienteService(clienteRepository)

        Dim ventaRepository As IVenta = New VentaRepository()
        Dim ventaItemRepository As IVentaItem = New VentaItemRepository

        _ventaService = New VentaService(ventaRepository, ventaItemRepository)

    End Sub

    Private Sub FrmVentaRealizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBCantidad.Text = 1
        EstilizarDGVBusquedaCliente()
        TBIdCliente.Enabled = False
        EstilizarDGVBusqueda()
        ModelarGrillaVenta()
    End Sub

    Private Sub ModelarGrillaVenta()

        DGVVenta.Columns.Add("ColID", "ID")
        DGVVenta.Columns.Add("ColItem", "Item")
        DGVVenta.Columns.Add("ColCantidad", "Cantidad")
        DGVVenta.Columns.Add("ColPrecioUnitario", "Precio unitario")
        DGVVenta.Columns.Add("ColSubtotal", "Subtotal")

        Dim btnCol As New DataGridViewButtonColumn()
        btnCol.HeaderText = "Acciones"
        btnCol.Name = "Eliminar"
        btnCol.Text = "Eliminar"

        btnCol.UseColumnTextForButtonValue = True
        DGVVenta.Columns.Add(btnCol)

        DGVVenta.Columns(0).Visible = False
        DGVVenta.Columns(1).Width = 180
        DGVVenta.Columns(2).Width = 60
        DGVVenta.Columns(4).Width = 90

        DGVVenta.ReadOnly = True
        DGVVenta.AllowUserToDeleteRows = False
    End Sub
    Private Sub MostrarResultadosBusquedaCliente()
        Dim filtro As String = TBBusquedaCliente.Text.Trim()

        If filtro.Length >= 2 Then
            TablaBusqueda = _clienteService.getClienteByName(filtro) ' Devuelve DataTable

            If TablaBusqueda.Rows.Count > 0 Then
                DGVCliente.DataSource = TablaBusqueda

                DGVCliente.Visible = True

                'Redimensionamos
                DGVCliente.Columns(0).Width = (TBBusquedaCliente.Width / 2)
                DGVCliente.Columns(1).Width = (TBBusquedaCliente.Width / 2)

                DGVCliente.Width = TBBusqueda.Width
                DGVCliente.Height = Math.Min(150, TablaBusqueda.Rows.Count * 45) ' Máximo 6 resultados

                DGVCliente.BringToFront()
            Else
                DGVCliente.Visible = False
            End If
        Else
            DGVCliente.Visible = False
        End If
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

    Private Sub DGVBusqueda_LostFocus(sender As Object, e As EventArgs) Handles DGVBusqueda.LostFocus
        DGVBusqueda.Visible = False
    End Sub

    Private Sub TBBusquedaCliente_LostFocus(sender As Object, e As EventArgs) Handles TBBusquedaCliente.LostFocus
        ' Esperar un poco para permitir el click en dgv antes de ocultarlo
        Me.BeginInvoke(Sub()
                           If Not DGVCliente.Focused Then
                               DGVCliente.Visible = False
                           End If
                       End Sub)
    End Sub

    Private Sub DGVCliente_LostFocus(sender As Object, e As EventArgs) Handles DGVCliente.LostFocus
        DGVCliente.Visible = False
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

    Private Sub EstilizarDGVBusquedaCliente()
        With DGVCliente
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

        DGVCliente.Visible = False
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
        Dim nombre As String = row.Cells("Nombre").Value.ToString()
        Dim precio As Decimal = Convert.ToDecimal(row.Cells("Precio").Value)
        Dim cantidad As Integer = Convert.ToInt32(TBCantidad.Text)

        ' Podés validar si ya fue agregado antes
        DGVVenta.Rows.Add(Id, nombre, 1, precio, (cantidad * precio))
        CalcularTotalVenta()

        TBBusqueda.Clear()
        TBCantidad.Text = 1
        DGVBusqueda.Visible = False
    End Sub

    Private Sub CalcularTotalVenta()
        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DGVVenta.Rows
            If row.Cells("ColSubtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("ColSubtotal").Value)
            End If
        Next

        LblTotalVenta.Text = "$" & total.ToString("N2")
    End Sub

    Private Sub TBBusquedaCliente_TextChanged(sender As Object, e As EventArgs) Handles TBBusquedaCliente.TextChanged
        MostrarResultadosBusquedaCliente()
    End Sub

    Private Sub DGVCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCliente.CellClick

        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DGVCliente.Rows(e.RowIndex)

            TBIdCliente.Text = fila.Cells("ID").Value.ToString()
            TBBusquedaCliente.Text = fila.Cells("Nombre").Value.ToString()
            DGVCliente.Visible = False
        End If
    End Sub

    Private Sub TBBusquedaCliente_KeyDown(sender As Object, e As KeyEventArgs) Handles TBBusquedaCliente.KeyDown
        If e.KeyCode = Keys.Enter AndAlso DGVCliente.CurrentRow IsNot Nothing Then

            Dim fila As DataGridViewRow = DGVCliente.CurrentRow

            TBIdCliente.Text = fila.Cells("ID").Value.ToString()
            TBBusquedaCliente.Text = fila.Cells("Nombre").Value.ToString()
            DGVCliente.Visible = False

            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub DGVVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVenta.CellClick
        Try
            If e.RowIndex >= 0 AndAlso DGVVenta.Columns(e.ColumnIndex).Name = "Eliminar" Then
                DGVVenta.Rows.RemoveAt(e.RowIndex)
                CalcularTotalVenta() ' Volvés a calcular el total
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Limpiar()
        TBIdCliente.Text = ""
        TBIdCliente.Visible = False
        TBBusquedaCliente.Text = ""

        TBBusqueda.Text = ""
        TBCantidad.Text = 1

        LblTotalVenta.Text = "$0.00"
        DGVVenta.Rows.Clear()

    End Sub
    Private Sub BtnConfirmar_Click(sender As Object, e As EventArgs) Handles BtnConfirmar.Click

        Dim Pregunta As DialogResult = MessageBox.Show("Deseas registrar venta", "Registrar venta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If Pregunta = DialogResult.OK Then

            Dim detalles As New List(Of VentaItem)
            Dim _venta As New Venta()

            _venta.IdCliente = CInt(TBIdCliente.Text)
            _venta.Total = LblTotalVenta.Text.Replace("$", "").Trim()

            For Each row As DataGridViewRow In DGVVenta.Rows
                If row.IsNewRow = False Then
                    Dim detalle As New VentaItem With {
                        .IdProducto = Convert.ToInt32(row.Cells("ColID").Value),
                        .PrecioUnitario = Convert.ToDecimal(row.Cells("ColPrecioUnitario").Value),
                        .Cantidad = Convert.ToInt32(row.Cells("ColCantidad").Value),
                        .PrecioTotal = Convert.ToDecimal(row.Cells("ColSubtotal").Value)
                    }

                    detalles.Add(detalle)
                End If
            Next

            If _ventaService.insertVentaCompleta(_venta, detalles) Then
                MessageBox.Show("Venta registrada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            Else
                MessageBox.Show("Error al registrar la venta, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
            MessageBox.Show("Operación cancelada", "Aviso", MessageBoxButtons.OK)
        End If

    End Sub
End Class