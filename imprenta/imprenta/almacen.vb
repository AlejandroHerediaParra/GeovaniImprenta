Public Class almacen
    Private Sub Salir_Btn_Click(sender As Object, e As EventArgs) Handles Salir_Btn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.Proveedor' Puede moverla o quitarla según sea necesario.
        If (Form1.tipoUsuario.Text = "User") Then

            Me.TabPage2.Parent = Nothing
        End If
        Me.ProveedorTableAdapter.Fill(Me.ImprentaDataSet.Proveedor)
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet.TipoMaterial' Puede moverla o quitarla según sea necesario.
        Me.TipoMaterialTableAdapter.Fill(Me.ImprentaDataSet.TipoMaterial)
        If ImprentaDataSet.TipoMaterial.Rows.Count > 0 Then
            For controlador As Integer = 0 To ImprentaDataSet.TipoMaterial.Rows.Count - 1
                If (TipoMaterialDataGridView.Item(5, TipoMaterialDataGridView.Rows(controlador).Index).Value) < 10 Then
                    TipoMaterialDataGridView.Rows(controlador).Cells(5).Style.ForeColor = Color.Red
                    MsgBox(TipoMaterialDataGridView.Item(1, TipoMaterialDataGridView.Rows(controlador).Index).Value, 1, "Error en stock")

                End If
            Next
        End If
    End Sub

    Private Sub almacen_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form1.Show()

    End Sub

    Private Sub TipoMaterialBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TipoMaterialBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TipoMaterialBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try


    End Sub

    Private Sub TipoMaterialDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TipoMaterialDataGridView.CellContentClick

    End Sub

    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Dim cantidad As Integer = ImprentaDataSet.TipoMaterial.Rows.Count
        Cod_MaterialTextBox.Text = ToString(cantidad + 1)
        Try

            Me.Validate()
            Me.ProveedorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try


    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class