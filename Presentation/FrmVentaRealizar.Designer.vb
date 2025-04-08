<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaRealizar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBBusqueda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVBusqueda = New System.Windows.Forms.DataGridView()
        Me.DGVVenta = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblTotalVenta = New System.Windows.Forms.Label()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBBusquedaCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBCantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 79)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(477, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Busque el producto por nombre y haga click sobre el articulo para agregar el item" &
    " a la grilla de venta"
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(484, 43)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(79, 20)
        Me.TBCantidad.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(429, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad"
        '
        'TBBusqueda
        '
        Me.TBBusqueda.Location = New System.Drawing.Point(82, 43)
        Me.TBBusqueda.Name = "TBBusqueda"
        Me.TBBusqueda.Size = New System.Drawing.Size(341, 20)
        Me.TBBusqueda.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'DGVBusqueda
        '
        Me.DGVBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBusqueda.Location = New System.Drawing.Point(205, 160)
        Me.DGVBusqueda.Name = "DGVBusqueda"
        Me.DGVBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBusqueda.Size = New System.Drawing.Size(341, 32)
        Me.DGVBusqueda.TabIndex = 15
        '
        'DGVVenta
        '
        Me.DGVVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVenta.Location = New System.Drawing.Point(123, 198)
        Me.DGVVenta.Name = "DGVVenta"
        Me.DGVVenta.Size = New System.Drawing.Size(571, 301)
        Me.DGVVenta.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(118, 503)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "TOTAL"
        '
        'LblTotalVenta
        '
        Me.LblTotalVenta.AutoSize = True
        Me.LblTotalVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalVenta.Location = New System.Drawing.Point(200, 503)
        Me.LblTotalVenta.Name = "LblTotalVenta"
        Me.LblTotalVenta.Size = New System.Drawing.Size(66, 26)
        Me.LblTotalVenta.TabIndex = 18
        Me.LblTotalVenta.Text = "$0.00"
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.Location = New System.Drawing.Point(523, 502)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(171, 31)
        Me.BtnConfirmar.TabIndex = 19
        Me.BtnConfirmar.Text = "Confirmar operacion"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'DGVCliente
        '
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Location = New System.Drawing.Point(205, 75)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCliente.Size = New System.Drawing.Size(341, 32)
        Me.DGVCliente.TabIndex = 21
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TBIdCliente)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TBBusquedaCliente)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(123, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 79)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(365, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Busque el cliente por nombre y haga click sobre el mismo para seleccionarlo"
        '
        'TBIdCliente
        '
        Me.TBIdCliente.Location = New System.Drawing.Point(484, 43)
        Me.TBIdCliente.Name = "TBIdCliente"
        Me.TBIdCliente.Size = New System.Drawing.Size(79, 20)
        Me.TBIdCliente.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ID"
        '
        'TBBusquedaCliente
        '
        Me.TBBusquedaCliente.Location = New System.Drawing.Point(82, 43)
        Me.TBBusquedaCliente.Name = "TBBusquedaCliente"
        Me.TBBusquedaCliente.Size = New System.Drawing.Size(341, 20)
        Me.TBBusquedaCliente.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cliente"
        '
        'FrmVentaRealizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 541)
        Me.Controls.Add(Me.DGVCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.LblTotalVenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGVVenta)
        Me.Controls.Add(Me.DGVBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVentaRealizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas - Nueva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBBusqueda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVBusqueda As DataGridView
    Friend WithEvents DGVVenta As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents LblTotalVenta As Label
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBBusquedaCliente As TextBox
    Friend WithEvents Label7 As Label
End Class
