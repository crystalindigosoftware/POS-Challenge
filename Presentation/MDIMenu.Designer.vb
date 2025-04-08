<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alta, baja, modificación y consulta")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestión de clientes", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Alta, baja, modificación y consulta")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de productos")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestion de productos", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Realizar Venta")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Consultar y modificar venta")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reporte de ventas")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Gestión de ventas", New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMenu))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "NSClienteAltaModificacion"
        TreeNode1.Text = "Alta, baja, modificación y consulta"
        TreeNode2.Name = "NClientes"
        TreeNode2.Text = "Gestión de clientes"
        TreeNode3.Name = "NSProductosAltaModificacion"
        TreeNode3.Text = "Alta, baja, modificación y consulta"
        TreeNode4.Name = "NSReporteProducto"
        TreeNode4.Text = "Reporte de productos"
        TreeNode5.Name = "NProductos"
        TreeNode5.Text = "Gestion de productos"
        TreeNode6.Name = "NSRealizarVenta"
        TreeNode6.Text = "Realizar Venta"
        TreeNode7.Name = "NSModificarVenta"
        TreeNode7.Text = "Consultar y modificar venta"
        TreeNode8.Name = "NSReporteVenta"
        TreeNode8.Text = "Reporte de ventas"
        TreeNode9.Name = "NGestionVentas"
        TreeNode9.Text = "Gestión de ventas"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode5, TreeNode9})
        Me.TreeView1.Size = New System.Drawing.Size(209, 611)
        Me.TreeView1.TabIndex = 9
        '
        'MDIMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 611)
        Me.Controls.Add(Me.TreeView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDIMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TACTICASOFT Demo - Marcos Gonzalez"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents TreeView1 As TreeView
End Class
