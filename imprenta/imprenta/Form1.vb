Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Ventas_Btn_Click(sender As Object, e As EventArgs) Handles Ventas_Btn.Click
        ventas.Show()
        Me.Hide()
    End Sub

    Private Sub Contabilidad_Btn_Click(sender As Object, e As EventArgs) Handles Contabilidad_Btn.Click
        contabilidad.Show()
        Me.Hide()
    End Sub

    Private Sub Almacen_Btn_Click(sender As Object, e As EventArgs) Handles Almacen_Btn.Click
        almacen.Show()
        Me.Hide()
    End Sub

    Private Sub Produccion_Btn_Click(sender As Object, e As EventArgs) Handles Produccion_Btn.Click
        produccion.Show()
        Me.Hide()
    End Sub

    Private Sub Salir_Btn_Click(sender As Object, e As EventArgs) Handles Salir_Btn.Click
        End
    End Sub
End Class
