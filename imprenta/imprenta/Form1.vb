Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Ventas_Btn_Click(sender As Object, e As EventArgs)
        ventas.Show()
        Me.Hide()
    End Sub

    Private Sub Contabilidad_Btn_Click(sender As Object, e As EventArgs)
        contabilidad.Show()
        If (tipoUsuario.Text = "User      ") Then
            contabilidad.TabPage2.Parent = Nothing
        End If
        Me.Hide()
    End Sub

    Private Sub Almacen_Btn_Click(sender As Object, e As EventArgs)
        almacen.Show()
        If (tipoUsuario.Text = "User      ") Then
            almacen.TabPage2.Parent = Nothing
        End If
        Me.Hide()
    End Sub

    Private Sub Produccion_Btn_Click(sender As Object, e As EventArgs)
        produccion.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Btn_Click(sender As Object, e As EventArgs) Handles Salir_Btn.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (tipoUsuario.Text = "User      ") Then
            ProduccionToolStripMenuItem.Enabled = False
            control_de_usuario_btn.Enabled = False

        End If
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ContabilidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContabilidadToolStripMenuItem.Click
        contabilidad.Show()
        If (tipoUsuario.Text = "User      ") Then
            contabilidad.TabPage2.Parent = Nothing
        End If
        Me.Hide()
    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlmacenToolStripMenuItem.Click
        almacen.Show()
        If (tipoUsuario.Text = "User      ") Then
            almacen.TabPage2.Parent = Nothing
        End If
        Me.Hide()
    End Sub

    Private Sub ProduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduccionToolStripMenuItem.Click
        produccion.Show()
        Me.Hide()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
