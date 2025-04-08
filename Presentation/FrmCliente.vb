Imports System.Linq.Expressions
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmCliente

    Private ReadOnly _clienteService As ClienteService
    Dim TablaClientes As DataTable
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim clienteRepository As ICliente = New ClienteRepository()
        _clienteService = New ClienteService(clienteRepository)
        LblAviso.Visible = False
        BtnGrabar.Text = "Grabar datos"
        LblIdCliente.Visible = False

        CargarFiltros()
        CargarClientes()

    End Sub

    Private Sub CargarClientes()
        TablaClientes = _clienteService.getCliente()
        If TablaClientes.Rows.Count > 0 Then
            LblAviso.Visible = False
            DGVClientes.DataSource = TablaClientes

            DGVClientes.ReadOnly = True
            DGVClientes.AllowUserToDeleteRows = False

            If Not DGVClientes.Columns.Contains("Eliminar") Then
                Dim btnCol As New DataGridViewButtonColumn()
                btnCol.HeaderText = "Acciones"
                btnCol.Name = "Eliminar"
                btnCol.Text = "Eliminar"

                btnCol.UseColumnTextForButtonValue = True
                DGVClientes.Columns.Add(btnCol)
            End If
        Else
            LblAviso.Visible = True
        End If

    End Sub

    Private Sub CargarFiltros()
        CBFiltro.Items.Clear()
        CBFiltro.Items.Add("Nombre")
        CBFiltro.Items.Add("Correo")
        CBFiltro.Items.Add("Telefono")
        CBFiltro.SelectedIndex = 0
    End Sub
    Private Sub Buscar()
        Dim DS As New DataSet()
        DS.Tables.Add(TablaClientes.Copy()) 'clonamos toda la tabla
        Dim DV As New DataView(DS.Tables(0))

        Try
            DV.RowFilter = CBFiltro.Text + " like'%" & TBBuscar.Text & "%'"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If DV.Count > 0 Then
            DGVClientes.DataSource = DV
            LblAviso.Text = ""
            LblAviso.Visible = False
        Else
            DGVClientes.DataSource = Nothing
            LblAviso.Text = "No se encontraron coincidencias"
            LblAviso.Visible = True
        End If
    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged
        Buscar()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Dim Pregunta As DialogResult
        Dim _cliente As New Cliente
        If BtnGrabar.Text = "Grabar datos" Then
            Pregunta = MessageBox.Show("Deseas registrar cliente", "Registrar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Pregunta = DialogResult.OK Then


                _cliente.Cliente = TBNombre.Text
                _cliente.Telefono = TBTelefono.Text
                _cliente.Correo = TBCorreo.Text

                If ValidarDatos(_cliente) = True Then
                    If _clienteService.insertCliente(_cliente) Then
                        MessageBox.Show("Cliente guardado con éxito", "Aviso")

                        CargarClientes()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al guardar cliente", "Aviso")
                    End If
                End If
            Else
                MessageBox.Show("Operación cancelada", "Aviso")
            End If

        ElseIf BtnGrabar.Text = "Modificar datos" Then
            Pregunta = MessageBox.Show("Deseas modificar cliente", "Modificar cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If Pregunta = DialogResult.OK Then

                _cliente.Id = Integer.Parse(LblIdCliente.Text)
                _cliente.Cliente = TBNombre.Text
                _cliente.Telefono = TBTelefono.Text
                _cliente.Correo = TBCorreo.Text

                If ValidarDatos(_cliente) = True Then
                    If _clienteService.updateCliente(_cliente) Then
                        MessageBox.Show("Cliente modificado con éxito", "Aviso")
                        CargarClientes()
                        Limpiar()
                    Else
                        MessageBox.Show("Error al modificar cliente", "Aviso")
                    End If
                End If
            Else
                MessageBox.Show("Operación cancelada", "Aviso")
            End If
        End If
    End Sub

    Private Function ValidarDatos(_cliente As Cliente) As Boolean
        If String.IsNullOrWhiteSpace(_cliente.Cliente) Then
            MessageBox.Show("Debe completar el nombre del cliente", "Validación de datos")
            Return False
        ElseIf String.IsNullOrWhiteSpace(_cliente.Telefono) Then
            MessageBox.Show("Debe completar el nombre del cliente", "Validación de datos")
            Return False
        End If

        If String.IsNullOrWhiteSpace(_cliente.Correo) Then
            MessageBox.Show("Debe completar el correo electronico", "Validación de datos")
            Return False
        End If

        If ValidarCorreo(_cliente.Correo) = False Then
            MessageBox.Show(" el correo electronico debe usar el formato tunombre@dominio.com", "Validación de datos")
            Return False
        End If

        Return True
    End Function

    Private Function ValidarCorreo(email As String) As Boolean
        Dim ExpresionReg As String = "^\w+([-.+']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"

        Return Regex.IsMatch(email, ExpresionReg)
    End Function

    Private Sub Limpiar()
        LblIdCliente.Text = 0
        LblIdCliente.Visible = False

        TBNombre.Text = ""
        TBTelefono.Text = ""
        TBCorreo.Text = ""

        BtnGrabar.Text = "Grabar datos"
        TBNombre.Focus()
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub DGVClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVClientes.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = DGVClientes.Columns("Eliminar").Index Then
            ' Confirmar eliminación
            Dim resultado = MessageBox.Show("¿Deseas eliminar el cliente seleccionado?", "Confirmar", MessageBoxButtons.YesNo)

            If resultado = DialogResult.Yes Then
                ' Eliminar fila seleccionada
                Dim IdCliente As Integer = Convert.ToInt32(DGVClientes.Rows(e.RowIndex).Cells("ID").Value)

                If _clienteService.deleteCliente(IdCliente) = False Then
                    MessageBox.Show("Ocurrió un error al eliminar cliente, intente nuevamente", "Aviso")
                End If

                If DGVClientes.Columns.Contains("Eliminar") Then
                    DGVClientes.Columns.Remove("Eliminar")
                End If

                DGVClientes.DataSource = Nothing
                CargarClientes()
                Limpiar()


            End If
        Else
            Try
                BtnGrabar.Text = "Modificar datos"

                Dim fila As DataGridViewRow = DGVClientes.Rows(e.RowIndex)

                LblIdCliente.Text = fila.Cells("ID").Value.ToString()
                LblIdCliente.Visible = True

                TBNombre.Text = fila.Cells("Nombre").Value.ToString()
                TBTelefono.Text = fila.Cells("Telefono").Value.ToString()
                TBCorreo.Text = fila.Cells("Correo").Value.ToString()

                TBNombre.Focus()
            Catch ex As Exception

            End Try

        End If

    End Sub
End Class