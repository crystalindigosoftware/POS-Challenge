<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaAgregarItem
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
        Me.DGVBusqueda = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBBusqueda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGVBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVBusqueda
        '
        Me.DGVBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVBusqueda.Location = New System.Drawing.Point(94, 76)
        Me.DGVBusqueda.Name = "DGVBusqueda"
        Me.DGVBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVBusqueda.Size = New System.Drawing.Size(341, 71)
        Me.DGVBusqueda.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TBCantidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBBusqueda)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 79)
        Me.GroupBox1.TabIndex = 22
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
        'FrmVentaAgregarItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(606, 148)
        Me.Controls.Add(Me.DGVBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmVentaAgregarItem"
        Me.Text = "Agregar item a la venta"
        CType(Me.DGVBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGVBusqueda As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBBusqueda As TextBox
    Friend WithEvents Label3 As Label
End Class
