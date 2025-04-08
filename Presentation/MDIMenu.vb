Imports System.Windows.Forms

'Examen de validación de conocimientos para TACTICASOFT
'Uso unicamente con fines validatorios
'Autor : Marcos Enrique Gonzalez
'mgonzalezsoft@outlook.com
Public Class MDIMenu

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub TreeView1_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        Select Case e.Node.Name
            Case "NSClienteAltaModificacion"
                OpenChildForm(New FrmCliente())
            Case "NSProductosAltaModificacion"
                OpenChildForm(New FrmProducto())
            Case "NSReporteProducto"
                OpenChildForm(New FrmReportProducto())
            Case "NSRealizarVenta"
                OpenChildForm(New FrmVentaRealizar())
            Case "NSModificarVenta"
                OpenChildForm(New FrmConsultaModificacionVenta())
            Case "NSReporteVenta"
                OpenChildForm(New FrmReportAllVentas())
        End Select
    End Sub

    Private Sub OpenChildForm(childForm As Form)
        ' Cerrar cualquier formulario hijo abierto
        For Each frm As Form In Me.MdiChildren
            frm.Close()
        Next

        ' Configurar el nuevo formulario hijo
        childForm.MdiParent = Me
        childForm.Dock = DockStyle.Fill
        childForm.Show()
    End Sub
End Class
