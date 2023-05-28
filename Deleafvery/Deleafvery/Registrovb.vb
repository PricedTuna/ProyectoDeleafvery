

Imports System.Data.OleDb

Public Class Registrovb

    Dim pro As String
    Dim constring As String
    Dim comando As String
    Dim miConexion As OleDbConnection = New OleDbConnection


    Function RealizarInsert() As Boolean
        Dim pro As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edgar\OneDrive\Escritorio\ProyectoProgramacion\FinalVery\Deleafvery\deleafveryDTB.accdb"
        Dim constring As String = pro
        Dim miConexion As New OleDbConnection(constring)
        Dim resultado As Boolean = False

        Try
            miConexion.Open()

            Dim comando As String = "INSERT INTO usuarios (nombre, numero, email, contrasena, direccion) VALUES (@nombre, @numero, @email, @contrasena, @direccion)"
            Dim cmd As New OleDbCommand(comando, miConexion)
            cmd.Parameters.AddWithValue("@nombre", nametxt.Text)
            cmd.Parameters.AddWithValue("@numero", numerotxt.Text)
            cmd.Parameters.AddWithValue("@email", correotxt.Text)
            cmd.Parameters.AddWithValue("@contrasena", contrasenatxt.Text)
            cmd.Parameters.AddWithValue("@direccion", direcciontxt.Text)
            cmd.ExecuteNonQuery()

            ' El comando se ejecutó correctamente
            resultado = True

        Catch ex As Exception
            ' Ocurrió un error durante la ejecución del comando
            MessageBox.Show("Error al ejecutar el comando: " & ex.Message)

        Finally
            ' Cerrar la conexión sin importar si hubo un error o no
            miConexion.Close()

        End Try

        Return resultado
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        If RealizarInsert() Then
            Me.Hide()
            Form2.Show()
        End If

    End Sub
End Class