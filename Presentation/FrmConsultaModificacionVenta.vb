Public Class FrmConsultaModificacionVenta

    Private ReadOnly _clienteService As ClienteService

    Private ReadOnly _ventaService As VentaService

    Dim TablaBusqueda As DataTable
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim clienteRepository As ICliente = New ClienteRepository()
        _clienteService = New ClienteService(clienteRepository)

        Dim ventaRepository As IVenta = New VentaRepository()
        Dim ventaItemRepository As IVentaItem = New VentaItemRepository

        _ventaService = New VentaService(ventaRepository, ventaItemRepository)
    End Sub

    Private Sub FrmConsultaModificacionVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBIdCliente.Text = 0
        TBIdCliente.Visible = False
        LblTextID.Visible = False

        BtnImprimirReporte.Enabled = False
        BtnAgregarItem.Enabled = False
        BtnEliminarVentaDetalle.Enabled = False

        EstilizarDGVBusquedaCliente()
        CargarListadoVentasByIdCliente(CInt(TBIdCliente.Text))
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

    Private Sub TBBusquedaCliente_TextChanged(sender As Object, e As EventArgs) Handles TBBusquedaCliente.TextChanged
        MostrarResultadosBusquedaCliente()
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

                DGVCliente.Width = TBBusquedaCliente.Width
                DGVCliente.Height = Math.Min(150, TablaBusqueda.Rows.Count * 45) ' Máximo 6 resultados

                DGVCliente.BringToFront()
            Else
                DGVCliente.Visible = False
            End If
        Else
            DGVCliente.Visible = False
        End If
    End Sub

    Private Sub DGVCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVCliente.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DGVCliente.Rows(e.RowIndex)

            TBIdCliente.Text = fila.Cells("ID").Value.ToString()
            TBBusquedaCliente.Text = fila.Cells("Nombre").Value.ToString()

            CargarListadoVentasByIdCliente(CInt(TBIdCliente.Text))
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

            CargarListadoVentasByIdCliente(CInt(TBIdCliente.Text))
        End If
    End Sub

    Public Sub CargarListadoVentasByIdCliente(_IdCliente As Integer)

        CBListadoVentas.DropDownStyle = ComboBoxStyle.DropDownList

        Try
            If _IdCliente > 0 Then

                Dim TablaVentasItem As DataTable
                TablaVentasItem = _ventaService.getVentaByIdClient(_IdCliente)

                If TablaVentasItem.Rows.Count <= 0 Then
                    CBListadoVentas.Items.Clear()
                    CBListadoVentas.Items.Add(New ListItem(0, "El cliente seleccionado no tiene historial de ventas"))
                    CBListadoVentas.SelectedIndex = 0
                Else
                    ' Agregamos columna combinada
                    TablaVentasItem.Columns.Add("Descripcion", GetType(String))
                    For Each row As DataRow In TablaVentasItem.Rows
                        row("Descripcion") = "Venta Id " & row("IDVenta").ToString() & " - " & CDate(row("Fecha")).ToShortDateString()
                    Next


                    CBListadoVentas.ValueMember = "IDVenta"
                    CBListadoVentas.DisplayMember = "Descripcion"
                    CBListadoVentas.DataSource = TablaVentasItem
                End If
            Else
                CBListadoVentas.DataSource = Nothing
                CBListadoVentas.Items.Add(New ListItem(0, "Seleccione una venta para visualizar el detalle"))
                CBListadoVentas.SelectedIndex = 0

            End If
        Catch ex As Exception
            CBListadoVentas.DataSource = Nothing

            If DGVVentaItemDetalle.Columns.Contains("Eliminar") Then
                DGVVentaItemDetalle.Columns.Remove("Eliminar")
            End If

            DGVVentaItemDetalle.DataSource = Nothing

            CBListadoVentas.Items.Add(New ListItem(0, "Seleccione una venta para visualizar el detalle"))
            CBListadoVentas.SelectedIndex = 0
        End Try

    End Sub

    Private Sub CBListadoVentas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBListadoVentas.SelectedIndexChanged
        If CBListadoVentas.SelectedValue > 0 Then


            If DGVVentaItemDetalle.Columns.Contains("Eliminar") Then
                DGVVentaItemDetalle.Columns.Remove("Eliminar")
            End If

            Dim IdVenta As Integer = CInt(CBListadoVentas.SelectedValue)
            CargaDetalleVentabyId(IdVenta)

            BtnImprimirReporte.Enabled = True
            BtnAgregarItem.Enabled = True
            BtnEliminarVentaDetalle.Enabled = True
        Else
            BtnImprimirReporte.Enabled = False
            BtnAgregarItem.Enabled = False
            BtnEliminarVentaDetalle.Enabled = False
        End If
    End Sub

    Private Sub CargaDetalleVentabyId(IdVenta As Integer)
        Dim TableDetalleVenta = _ventaService.getVentaById(IdVenta)

        If TableDetalleVenta.Rows.Count > 0 Then

            DGVVentaItemDetalle.DataSource = TableDetalleVenta

            If Not DGVVentaItemDetalle.Columns.Contains("Eliminar") Then
                Dim btnCol As New DataGridViewButtonColumn()
                btnCol.HeaderText = "Eliminar"
                btnCol.Name = "Eliminar"
                btnCol.Text = "Eliminar"

                btnCol.UseColumnTextForButtonValue = True
                DGVVentaItemDetalle.Columns.Add(btnCol)
            End If


            'Ocultamos controles
            DGVVentaItemDetalle.Columns(0).Visible = False
            DGVVentaItemDetalle.Columns(1).Visible = False
            DGVVentaItemDetalle.Columns(6).Visible = False
            DGVVentaItemDetalle.Columns(7).Visible = False

            DGVVentaItemDetalle.Columns(4).Width = 60
            DGVVentaItemDetalle.Columns(5).Width = 70
        End If
    End Sub

    Private Sub DGVVentaItemDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVVentaItemDetalle.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DGVVentaItemDetalle.Columns("Eliminar").Index Then
            ' Confirmar eliminación
            Dim resultado = MessageBox.Show("¿Deseas eliminar item de la venta?", "Confirmar", MessageBoxButtons.YesNo)

            If resultado = DialogResult.Yes Then
                ' Eliminar fila seleccionada
                Dim IdVentaDetalle As Integer = Convert.ToInt32(DGVVentaItemDetalle.Rows(e.RowIndex).Cells("IdVentaDetalle").Value)
                Dim IdVenta As Integer = Convert.ToInt32(DGVVentaItemDetalle.Rows(e.RowIndex).Cells("IDVenta").Value)

                If _ventaService.deleteVentaItem(IdVentaDetalle, IdVenta) = False Then
                    MessageBox.Show("Ocurrió un error al eliminar item, intente nuevamente", "Aviso")
                    Exit Sub
                End If

                If DGVVentaItemDetalle.Columns.Contains("Eliminar") Then
                    DGVVentaItemDetalle.Columns.Remove("Eliminar")
                End If

                DGVVentaItemDetalle.DataSource = Nothing

                CargarListadoVentasByIdCliente(TBIdCliente.Text)

            End If
        End If
    End Sub

    Private Sub BtnImprimirReporte_Click(sender As Object, e As EventArgs) Handles BtnImprimirReporte.Click
        Dim IdVenta As Integer = CInt(CBListadoVentas.SelectedValue)

        If IdVenta > 0 Then
            Dim Formulario As New FrmReportVenta(IdVenta)
            Formulario.StartPosition = FormStartPosition.CenterScreen
            Formulario.MdiParent = Me.MdiParent
            Formulario.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Formulario.Dock = DockStyle.Fill
            Formulario.WindowState = FormWindowState.Normal
            Formulario.Show()
        End If
    End Sub

    Private Sub BtnAgregarItem_Click(sender As Object, e As EventArgs) Handles BtnAgregarItem.Click
        Dim IdVenta As Integer = CInt(CBListadoVentas.SelectedValue)

        If IdVenta > 0 Then
            Dim Formulario As New FrmVentaAgregarItem(IdVenta, CInt(TBIdCliente.Text))
            Formulario.StartPosition = FormStartPosition.CenterScreen
            Formulario.FormularioPadre = Me
            Formulario.MdiParent = Me.MdiParent
            Formulario.WindowState = FormWindowState.Normal
            Formulario.Show()

            If DGVVentaItemDetalle.Columns.Contains("Eliminar") Then
                DGVVentaItemDetalle.Columns.Remove("Eliminar")
            End If

            DGVVentaItemDetalle.DataSource = Nothing

            CargarListadoVentasByIdCliente(TBIdCliente.Text)
        End If
    End Sub

    Private Sub BtnEliminarVentaDetalle_Click(sender As Object, e As EventArgs) Handles BtnEliminarVentaDetalle.Click
        Dim resultado = MessageBox.Show("¿Deseas eliminar venta completa?", "Confirmar", MessageBoxButtons.YesNo)

        If resultado = DialogResult.Yes Then
            Dim IdVenta As Integer = CInt(CBListadoVentas.SelectedValue)

            If IdVenta > 0 Then
                If _ventaService.deleteVentaCompleta(IdVenta) Then
                    If DGVVentaItemDetalle.Columns.Contains("Eliminar") Then
                        DGVVentaItemDetalle.Columns.Remove("Eliminar")
                    End If

                    DGVVentaItemDetalle.DataSource = Nothing

                    CargarListadoVentasByIdCliente(TBIdCliente.Text)
                Else
                    MessageBox.Show("Error al eliminar venta completa, intente nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If

    End Sub
End Class