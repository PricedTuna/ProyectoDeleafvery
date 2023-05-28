Imports System.Data.OleDb

Public Class RealizarPedidos

    Function CostoTotal() As Integer
        Dim verdura1Value As Integer = verdura1.Text
        Dim verdura2Value As Integer = verdura2.Text
        Dim verdura3Value As Integer = verdura3.Text
        Dim verdura4Value As Integer = verdura4.Text
        Dim verdura5Value As Integer = verdura5.Text

        Dim total As Integer = (verdura1Value * 3) + (verdura2Value * 5) + (verdura3Value * 2) + (verdura4Value * 6) + (verdura5Value * 4)
        Return total
    End Function

    Function RealizarInsert() As Boolean
        Dim pro As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edgar\OneDrive\Escritorio\ProyectoProgramacion\FinalVery\Deleafvery\deleafveryDTB.accdb"
        Dim constring As String = pro
        Dim miConexion As New OleDbConnection(constring)
        Dim resultado As Boolean = False

        Try
            miConexion.Open()

            Dim comando As String = "INSERT INTO pedidos (verdura1, verdura2, verdura3, verdura4, verdura5, id_cliente, precioTotal) VALUES (@verdura1, @verdura2, @verdura3, @verdura4, @verdura5, @id_cliente, @precioTotal)"
            Dim cmd As New OleDbCommand(comando, miConexion)
            cmd.Parameters.AddWithValue("@verdura1", verdura1.Text)
            cmd.Parameters.AddWithValue("@verdura2", verdura2.Text)
            cmd.Parameters.AddWithValue("@verdura3", verdura3.Text)
            cmd.Parameters.AddWithValue("@verdura4", verdura4.Text)
            cmd.Parameters.AddWithValue("@verdura5", verdura5.Text)
            cmd.Parameters.AddWithValue("@id_cliente", variables.IDUsuarioGlobal)
            cmd.Parameters.AddWithValue("@precioTotal", CostoTotal)
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




    Function SelectPedidos() As Boolean
        Dim pro As String = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edgar\OneDrive\Escritorio\ProyectoProgramacion\FinalVery\Deleafvery\deleafveryDTB.accdb"
        Dim constring As String = pro
        Dim miConexion As New OleDbConnection(constring)
        Dim resultado As Boolean = False

        Try
            miConexion.Open()

            Dim comando As String = "SELECT * FROM pedidos WHERE id_cliente = @idCliente"
            Dim cmd As New OleDbCommand(comando, miConexion)
            cmd.Parameters.AddWithValue("@idCliente", variables.IDUsuarioGlobal)
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













    Private Sub HacerPedidoBtn_Click(sender As Object, e As EventArgs) Handles HacerPedidoBtn.Click
        If RealizarInsert() Then
            Me.Hide()
            ConfirmarPedido.Show()
        End If
    End Sub

    Private Sub CalcTotalBtn_Click(sender As Object, e As EventArgs) Handles CalcTotalBtn.Click
        TotalLabel.Text = CostoTotal()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub VerPedidosBtn_Click(sender As Object, e As EventArgs) Handles VerPedidosBtn.Click
        MisPedidos.Show()
    End Sub
End Class