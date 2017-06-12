Public Class ventas

    Private Sub Salir_Btn_Click(sender As Object, e As EventArgs) Handles Salir_Btn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub ventas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()
    End Sub

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.ImprentaDataSet.Producto)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.VentasCliente' Puede moverla o quitarla según sea necesario.
        Me.VentasClienteTableAdapter.Fill(Me.ImprentaDataSet.VentasCliente)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.PedidosCliente' Puede moverla o quitarla según sea necesario.
        Me.PedidosClienteTableAdapter.Fill(Me.ImprentaDataSet.PedidosCliente)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.TipoMaterial' Puede moverla o quitarla según sea necesario.
        Me.TipoMaterialTableAdapter.Fill(Me.ImprentaDataSet.TipoMaterial)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.DetallePedido' Puede moverla o quitarla según sea necesario.
        Me.DetallePedidoTableAdapter.Fill(Me.ImprentaDataSet.DetallePedido)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ImprentaDataSet.Cliente)

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Dim id As Integer = ImprentaDataSet.Cliente.Rows.Count + 1
        Cod_ClienteTextBox.Text = id
        Try
            Me.Validate()
            Me.ClienteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try


    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)
        Try
            Me.Validate()
            Me.DetallePedidoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try

    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Dim id As Integer = ImprentaDataSet.PedidosCliente.Rows.Count + 1
        Cod_PedidoTextBox.Text = id
        Try
            Me.Validate()
            Me.PedidosClienteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try

    End Sub

    Private Sub ToolStripButton15_Click(sender As Object, e As EventArgs) Handles ToolStripButton15.Click
        Dim id As Integer = ImprentaDataSet.VentasCliente.Rows.Count + 1
        Codigo_VentaTextBox.Text = id
        Try
            Me.Validate()
            Me.VentasClienteBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try

    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If ((CantidadTextBox1.Text > CantidadTextBox4.Text) Or (CantidadTextBox1.Text = "")) Then
            MsgBox("Material Insuficiente o cantidad no especificada")
            CantidadTextBox1.Text = ""
            CantidadTextBox1.Focus()
        Else
            CantidadTextBox4.Text = CInt(CantidadTextBox4.Text) - CInt(CantidadTextBox1.Text)
            Dim id As Integer = ImprentaDataSet.DetallePedido.Rows.Count + 1
            Cod_DetalleTextBox.Text = id
            Try
                Me.Validate()
                Me.DetallePedidoBindingSource.EndEdit()
                Me.TipoMaterialBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
            Catch ex As Exception
                MsgBox(ex.Message, 1, "Error")
            End Try

        End If
    End Sub

    Private Sub CantidadTextBox1_TextChanged(sender As Object, e As EventArgs) Handles CantidadTextBox1.TextChanged


    End Sub

    Private Sub CantidadTextBox1_LostFocus(sender As Object, e As EventArgs) Handles CantidadTextBox1.LostFocus

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        NitTextBox.Focus()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Cliente_Cod_ClienteComboBox.Focus()

    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        TipoMaterial_Cod_MaterialComboBox.Focus()

    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Cliente_Cod_ClienteComboBox1.Focus()
    End Sub
End Class