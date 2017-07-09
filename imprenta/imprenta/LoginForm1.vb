Imports System.Data.SqlClient
Public Class LoginForm1
    Inherits System.Windows.Forms.Form
    'Crear objetos de ADO.NET.
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        'Crear un objeto Command.
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT tipo FROM Usuario WHERE usuario='" + UsernameTextBox.Text +
         "' AND contrasenia='" + PasswordTextBox.Text + "' "
        Try
                myReader = myCmd.ExecuteReader()
            'Concatenar el resultado de la consulta en una cadena.
            Do While myReader.Read()
                results = myReader.GetString(0)
            Loop
            If (results <> "") Then
                Me.Hide()
                Form1.tipoUsuario.Text = results
                Form1.Show()

                myConn.Close()
            Else
                MsgBox("Usuario y/o contraseña erroneas", 1, "Error")
            End If

        Catch ex As Exception
                MsgBox(ex.Message, 1, "error")

            End Try





    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
        End

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Crear un objeto Connection.
        myConn = New SqlConnection("Initial Catalog=imprenta;" &
                "Data Source=DESKTOP-GNPAAGD\MSSQLSERVER2;Integrated Security=SSPI;")
        Try
            myConn.Open()
        Catch ex As Exception
            MsgBox(ex.Message, 1, "Error")

        End Try    'Abrir la conexión.



    End Sub
End Class
