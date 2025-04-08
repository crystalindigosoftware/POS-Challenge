<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaModificacionVenta
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
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBIdCliente = New System.Windows.Forms.TextBox()
        Me.LblTextID = New System.Windows.Forms.Label()
        Me.TBBusquedaCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimirReporte = New System.Windows.Forms.Button()
        Me.CBListadoVentas = New System.Windows.Forms.ComboBox()
        Me.DGVVentaItemDetalle = New System.Windows.Forms.DataGridView()
        Me.BtnAgregarItem = New System.Windows.Forms.Button()
        Me.BtnEliminarVentaDetalle = New System.Windows.Forms.Button()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVVentaItemDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVCliente
        '
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Location = New System.Drawing.Point(205, 75)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVCliente.Size = New System.Drawing.Size(341, 32)
        Me.DGVCliente.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TBIdCliente)
        Me.GroupBox2.Controls.Add(Me.LblTextID)
        Me.GroupBox2.Controls.Add(Me.TBBusquedaCliente)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(123, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(571, 79)
        Me.GroupBox2.TabIndex = 22
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
        'LblTextID
        '
        Me.LblTextID.AutoSize = True
        Me.LblTextID.Location = New System.Drawing.Point(429, 46)
        Me.LblTextID.Name = "LblTextID"
        Me.LblTextID.Size = New System.Drawing.Size(18, 13)
        Me.LblTextID.TabIndex = 4
        Me.LblTextID.Text = "ID"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnImprimirReporte)
        Me.GroupBox1.Controls.Add(Me.CBListadoVentas)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 56)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione venta"
        '
        'BtnImprimirReporte
        '
        Me.BtnImprimirReporte.Location = New System.Drawing.Point(432, 17)
        Me.BtnImprimirReporte.Name = "BtnImprimirReporte"
        Me.BtnImprimirReporte.Size = New System.Drawing.Size(131, 23)
        Me.BtnImprimirReporte.TabIndex = 4
        Me.BtnImprimirReporte.Text = "Imprimir Reporte"
        Me.BtnImprimirReporte.UseVisualStyleBackColor = True
        '
        'CBListadoVentas
        '
        Me.CBListadoVentas.FormattingEnabled = True
        Me.CBListadoVentas.Location = New System.Drawing.Point(82, 19)
        Me.CBListadoVentas.Name = "CBListadoVentas"
        Me.CBListadoVentas.Size = New System.Drawing.Size(341, 21)
        Me.CBListadoVentas.TabIndex = 3
        '
        'DGVVentaItemDetalle
        '
        Me.DGVVentaItemDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVentaItemDetalle.Location = New System.Drawing.Point(123, 175)
        Me.DGVVentaItemDetalle.Name = "DGVVentaItemDetalle"
        Me.DGVVentaItemDetalle.Size = New System.Drawing.Size(571, 303)
        Me.DGVVentaItemDetalle.TabIndex = 25
        '
        'BtnAgregarItem
        '
        Me.BtnAgregarItem.Location = New System.Drawing.Point(563, 484)
        Me.BtnAgregarItem.Name = "BtnAgregarItem"
        Me.BtnAgregarItem.Size = New System.Drawing.Size(131, 23)
        Me.BtnAgregarItem.TabIndex = 26
        Me.BtnAgregarItem.Text = "Agregar Item"
        Me.BtnAgregarItem.UseVisualStyleBackColor = True
        '
        'BtnEliminarVentaDetalle
        '
        Me.BtnEliminarVentaDetalle.Location = New System.Drawing.Point(426, 484)
        Me.BtnEliminarVentaDetalle.Name = "BtnEliminarVentaDetalle"
        Me.BtnEliminarVentaDetalle.Size = New System.Drawing.Size(131, 23)
        Me.BtnEliminarVentaDetalle.TabIndex = 27
        Me.BtnEliminarVentaDetalle.Text = "Eliminar venta completa"
        Me.BtnEliminarVentaDetalle.UseVisualStyleBackColor = True
        '
        'FrmConsultaModificacionVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 541)
        Me.Controls.Add(Me.BtnEliminarVentaDetalle)
        Me.Controls.Add(Me.BtnAgregarItem)
        Me.Controls.Add(Me.DGVVentaItemDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGVCliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmConsultaModificacionVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de ventas - consulta y modificaion de ventas"
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGVVentaItemDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBIdCliente As TextBox
    Friend WithEvents LblTextID As Label
    Friend WithEvents TBBusquedaCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBListadoVentas As ComboBox
    Friend WithEvents DGVVentaItemDetalle As DataGridView
    Friend WithEvents BtnImprimirReporte As Button
    Friend WithEvents BtnAgregarItem As Button
    Friend WithEvents BtnEliminarVentaDetalle As Button
End Class
