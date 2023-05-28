Imports System.Data.OleDb

Public Class Form2

    Function VerificarCredenciales(ByVal correo As String, ByVal contraseña As String) As Integer
        Dim pro As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edgar\OneDrive\Escritorio\ProyectoProgramacion\FinalVery\Deleafvery\deleafveryDTB.accdb"
        Dim constring As String = pro
        Dim miConexion As New OleDbConnection(constring)
        Dim resultado As Integer = -1

        Try
            miConexion.Open()

            Dim comando As String = "SELECT id FROM usuarios WHERE email = @correo AND contrasena = @contrasena"
            Dim cmd As New OleDbCommand(comando, miConexion)
            cmd.Parameters.AddWithValue("@correo", correo)
            cmd.Parameters.AddWithValue("@contrasena", contraseña)

            Dim id As Object = cmd.ExecuteScalar()

            If id IsNot Nothing Then
                ' Las credenciales son válidas, se encontró un usuario correspondiente
                resultado = CInt(id)
            Else
                ' Las credenciales no son válidas, no se encontró un usuario correspondiente
                resultado = -1
            End If

        Catch ex As Exception
            ' Ocurrió un error durante la ejecución del comando
            MessageBox.Show("Error al ejecutar el comando: " & ex.Message)

        Finally
            ' Cerrar la conexión sin importar si hubo un error o no
            miConexion.Close()

        End Try

        Return resultado
    End Function


    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        Dim correo As String = correoSearch.Text
        Dim contra As String = contraSearch.Text


        If VerificarCredenciales(correo, contra) <> -1 Then
            variables.IDUsuarioGlobal = VerificarCredenciales(correo, contra)
            Me.Hide()
            RealizarPedidos.Show()
        End If

    End Sub
End Class