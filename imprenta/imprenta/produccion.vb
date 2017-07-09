Public Class produccion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Salir_Btn.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub produccion_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

    Private Sub produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ImprentaDataSet.Producto)



        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductoBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProductoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")

        End Try


    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub CantidadLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class