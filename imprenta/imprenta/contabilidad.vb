Public Class contabilidad

    Private Sub Salir_Btn_Click(sender As Object, e As EventArgs) Handles Salir_Btn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub contabilidad_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()

    End Sub

    Private Sub contabilidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.PedidosCliente' Puede moverla o quitarla según sea necesario.
        Me.PedidosClienteTableAdapter.Fill(Me.ImprentaDataSet.PedidosCliente)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.ImprentaDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.TipoMaterial' Puede moverla o quitarla según sea necesario.
        Me.TipoMaterialTableAdapter.Fill(Me.ImprentaDataSet.TipoMaterial)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Compras_Proveedor' Puede moverla o quitarla según sea necesario.
        Me.Compras_ProveedorTableAdapter.Fill(Me.ImprentaDataSet.Compras_Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ImprentaDataSet.Factura)

    End Sub

    Private Sub FacturaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.FacturaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)

        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Me.Validate()
            Me.Compras_ProveedorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try

    End Sub

    Private Sub CantidadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles CantidadTextBox1.TextChanged
        TotalTextBox.Text = Precio_MaterialTextBox.Text * CantidadTextBox1.Text

    End Sub
End Class