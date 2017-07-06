Public Class controldeusuario
    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsuarioBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.UsuarioBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ImprentaDataSet1)
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")
        End Try



    End Sub

    Private Sub controldeusuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ImprentaDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.ImprentaDataSet1.Usuario)

    End Sub
End Class