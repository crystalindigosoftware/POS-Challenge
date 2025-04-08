<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBFiltro = New System.Windows.Forms.ComboBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBCorreo = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblIdCliente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblAviso = New System.Windows.Forms.LinkLabel()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVClientes
        '
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(21, 205)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVClientes.Size = New System.Drawing.Size(804, 324)
        Me.DGVClientes.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar por"
        '
        'CBFiltro
        '
        Me.CBFiltro.FormattingEnabled = True
        Me.CBFiltro.Location = New System.Drawing.Point(82, 176)
        Me.CBFiltro.Name = "CBFiltro"
        Me.CBFiltro.Size = New System.Drawing.Size(240, 21)
        Me.CBFiltro.TabIndex = 2
        '
        'TBBuscar
        '
        Me.TBBuscar.Location = New System.Drawing.Point(328, 177)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(239, 20)
        Me.TBBuscar.TabIndex = 3
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(580, 176)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(131, 23)
        Me.BtnLimpiar.TabIndex = 4
        Me.BtnLimpiar.Text = "Limpiar - Nuevo cliente"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(717, 176)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(108, 23)
        Me.BtnGrabar.TabIndex = 5
        Me.BtnGrabar.Text = "Modificar datos"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBCorreo)
        Me.GroupBox1.Controls.Add(Me.TBTelefono)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LblIdCliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(804, 141)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del cliente"
        '
        'TBCorreo
        '
        Me.TBCorreo.Location = New System.Drawing.Point(131, 100)
        Me.TBCorreo.Name = "TBCorreo"
        Me.TBCorreo.Size = New System.Drawing.Size(260, 20)
        Me.TBCorreo.TabIndex = 7
        '
        'TBTelefono
        '
        Me.TBTelefono.Location = New System.Drawing.Point(131, 74)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.Size = New System.Drawing.Size(260, 20)
        Me.TBTelefono.TabIndex = 6
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
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Correo electronico"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre completo"
        '
        'LblIdCliente
        '
        Me.LblIdCliente.AutoSize = True
        Me.LblIdCliente.Location = New System.Drawing.Point(134, 31)
        Me.LblIdCliente.Name = "LblIdCliente"
        Me.LblIdCliente.Size = New System.Drawing.Size(13, 13)
        Me.LblIdCliente.TabIndex = 1
        Me.LblIdCliente.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Cliente"
        '
        'LblAviso
        '
        Me.LblAviso.AutoSize = True
        Me.LblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAviso.LinkColor = System.Drawing.Color.Red
        Me.LblAviso.Location = New System.Drawing.Point(357, 356)
        Me.LblAviso.Name = "LblAviso"
        Me.LblAviso.Size = New System.Drawing.Size(142, 17)
        Me.LblAviso.TabIndex = 7
        Me.LblAviso.TabStop = True
        Me.LblAviso.Text = "Sin datos disponibles"
        '
        'FrmCliente
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
        Me.Controls.Add(Me.DGVClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes - Alta, modificación y consulta"
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CBFiltro As ComboBox
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LblIdCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBCorreo As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblAviso As LinkLabel
End Class
