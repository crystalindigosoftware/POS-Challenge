<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProducto))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBCategoria = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblIdProducto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVProductos = New System.Windows.Forms.DataGridView()
        Me.LblAviso = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBCategoria)
        Me.GroupBox1.Controls.Add(Me.TBPrecio)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LblIdProducto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 141)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del producto"
        '
        'TBCategoria
        '
        Me.TBCategoria.Location = New System.Drawing.Point(131, 100)
        Me.TBCategoria.Name = "TBCategoria"
        Me.TBCategoria.Size = New System.Drawing.Size(260, 20)
        Me.TBCategoria.TabIndex = 7
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(131, 74)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(260, 20)
        Me.TBPrecio.TabIndex = 6
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(131, 48)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(260, 20)
        Me.TBNombre.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'LblIdProducto
        '
        Me.LblIdProducto.AutoSize = True
        Me.LblIdProducto.Location = New System.Drawing.Point(134, 31)
        Me.LblIdProducto.Name = "LblIdProducto"
        Me.LblIdProducto.Size = New System.Drawing.Size(13, 13)
        Me.LblIdProducto.TabIndex = 1
        Me.LblIdProducto.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Producto"
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(717, 176)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(108, 23)
        Me.BtnGrabar.TabIndex = 12
        Me.BtnGrabar.Text = "Modificar datos"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(569, 176)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(142, 23)
        Me.BtnLimpiar.TabIndex = 11
        Me.BtnLimpiar.Text = "Limpiar - Nuevo producto"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(328, 177)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(235, 20)
        Me.TBBuscar.TabIndex = 10
        '
        'CBFiltro
        '
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.Location = New System.Drawing.Point(82, 176)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(240, 21)
        Me.CBFiltro.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Buscar por"
        '
        'DGVProductos
        '
        Me.DGVProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProductos.Location = New System.Drawing.Point(21, 205)
        Me.DGVProductos.Name = "DGVProductos"
        Me.DGVProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVProductos.Size = New System.Drawing.Size(804, 324)
        Me.DGVProductos.TabIndex = 7
        '
        'LblAviso
        '
        Me.LblAviso.AutoSize = True
        Me.LblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAviso.LinkColor = System.Drawing.Color.Red
        Me.LblAviso.Location = New System.Drawing.Point(357, 356)
        Me.LblAviso.Name = "LblAviso"
        Me.LblAviso.Size = New System.Drawing.Size(142, 17)
        Me.LblAviso.TabIndex = 14
        Me.LblAviso.TabStop = True
        Me.LblAviso.Text = "Sin datos disponibles"
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 541)
        Me.Controls.Add(Me.LblAviso)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.TBBuscar)
        Me.Controls.Add(Me.CBFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos - Alta, modificación y consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBCategoria As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblIdProducto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVProductos As DataGridView
    Friend WithEvents LblAviso As LinkLabel
End Class
