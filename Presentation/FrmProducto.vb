Public Class FrmProducto

    Private ReadOnly _productoService As ProductoService
    Dim TablaProductos As DataTable
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim productoRepository As IProducto = New ProductoRepository()
        _productoService = New ProductoService(productoRepository)
        LblAviso.Visible = False
        BtnGrabar.Text = "Grabar datos"
        LblIdProducto.Visible = False

        CargarFiltros()
        CargarProductos()
    End Sub

    Private Sub CargarProductos()

        TablaProductos = _productoService.getProducto()
        If TablaProductos.Rows.Count > 0 Then
            LblAviso.Visible = False

            DGVProductos.DataSource = TablaProductos

            DGVProductos.ReadOnly = True
            DGVProductos.AllowUserToDeleteRows = False

            If Not DGVProductos.Columns.Contains("Eliminar") Then
                Dim btnCol As New DataGridViewButtonColumn()
                btnCol.HeaderText = "Acciones"
                btnCol.Name = "Eliminar"
                btnCol.Text = "Eliminar"

                btnCol.UseColumnTextForButtonValue = True
                DGVProductos.Columns.Add(btnCol)
            End If


        Else
            LblAviso.Visible = True
        End If

    End Sub

    Private Sub CargarFiltros()
        CBFiltro.Items.Clear()
        CBFiltro.Items.Add("Nombre")
        CBFiltro.Items.Add("Categoria")
        CBFiltro.SelectedIndex = 0
    End Sub

    Private Sub Buscar()
        Dim DS As New DataSet()
        DS.Tables.Add(TablaProductos.Copy()) 'clonamos toda la tabla
        Dim DV As New DataView(DS.Tables(0))

        Try
            DV.RowFilter = CBFiltro.Text + " like'%" & TBBuscar.Text & "%'"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If DV.Count > 0 Then
            DGVProductos.DataSource = DV
            LblAviso.Text = ""
            LblAviso.Visible = False
        Else
            DGVProductos.DataSource = Nothing
            LblAviso.Text = "No se encontraron coincidencias"
            LblAviso.Visible = True
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        LblIdProducto.Text = 0
        LblIdProducto.Visible = False

        TBNombre.Text = ""
        TBPrecio.Text = ""
        TBCategoria.Text = ""

        BtnGrabar.Text = "Grabar datos"
        TBNombre.Focus()
    End Sub

    Private Function ValidarDatos(_producto As Producto) As Boolean
        If String.IsNullOrWhiteSpace(_producto.Nombre) Then
            MessageBox.Show("Debe completar el nombre del producto", "Validación de datos")
            Return False
        ElseIf String.IsNullOrWhiteSpace(_producto.Precio) Then
            MessageBox.Show("Debe completar el precio del producto", "Validación de datos")
            Return False
        End If

        If String.IsNullOrWhiteSpace(_producto.Categoria) Then
            MessageBox.Show("Debe completar la categoria del producto", "Validación de datos")
            Return False
        End If

        Return True
    End Function

    Private Sub DGVProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProductos.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DGVProductos.Columns("Eliminar").Index Then
            ' Confirmar eliminación
            Dim resultado = MessageBox.Show("¿Deseas eliminar el producto seleccionado?", "Confirmar", MessageBoxButtons.YesNo)

            If resultado = DialogResult.Yes Then
                ' Eliminar fila seleccionada
                Dim IdProducto As Integer = Convert.ToInt32(DGVProductos.Rows(e.RowIndex).Cells("ID").Value)

                If _productoService.deleteProducto(IdProducto) = False Then
                    MessageBox.Show("Ocurrió un error al eliminar producto, intente nuevamente", "Aviso")
                End If

                If DGVProductos.Columns.Contains("Eliminar") Then
                    DGVProductos.Columns.Remove("Eliminar")
                End If

                DGVProductos.DataSource = Nothing

                CargarProductos()
                Limpiar()


            End If
        Else
            Try
                BtnGrabar.Text = "Modificar datos"

                Dim fila As DataGridViewRow = DGVProductos.Rows(e.RowIndex)

                LblIdProducto.Text = fila.Cells("ID").Value.ToString()
                LblIdProducto.Visible = True

                TBNombre.Text = fila.Cells("Nombre").Value.ToString()
                TBPrecio.Text = fila.Cells("Precio").Value.ToString()
                TBCategoria.Text = fila.Cells("Categoria").Value.ToString()

                TBNombre.Focus()
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Dim Pregunta As DialogResult
        Dim _producto As New Producto

        If BtnGrabar.Text = "Grabar datos" Then
            Pregunta = MessageBox.Show("Deseas registrar producto", "Registrar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Pregunta = DialogResult.OK Then


                _producto.Nombre = TBNombre.Text
                _producto.Precio = TBPrecio.Text
                _producto.Categoria = TBCategoria.Text

                If ValidarDatos(_producto) = True Then
                    If _productoService.insertProducto(_producto) Then
                        MessageBox.Show("Producto guardado con éxito", "Aviso")

                        CargarProductos()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al guardar producto", "Aviso")
                    End If
                End If
            Else
                MessageBox.Show("Operación cancelada", "Aviso")
            End If

        ElseIf BtnGrabar.Text = "Modificar datos" Then
            Pregunta = MessageBox.Show("Deseas modificar producto", "Modificar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Pregunta = DialogResult.OK Then

                _producto.Id = Integer.Parse(LblIdProducto.Text)
                _producto.Nombre = TBNombre.Text
                _producto.Precio = TBPrecio.Text
                _producto.Categoria = TBCategoria.Text

                If ValidarDatos(_producto) = True Then
                    If _productoService.updateProducto(_producto) Then
                        MessageBox.Show("Producto modificado con éxito", "Aviso")
                        CargarProductos()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al modificar producto", "Aviso")
                    End If
                End If
            Else
                MessageBox.Show("Operación cancelada", "Aviso")
            End If
        End If
    End Sub
End Class