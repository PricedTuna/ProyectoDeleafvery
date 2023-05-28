
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MisPedidos
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\edgar\OneDrive\Escritorio\ProyectoProgramacion\FinalVery\Deleafvery\deleafveryDTB.accdb"
    Dim query As String = "SELECT * FROM pedidos WHERE id_cliente = @id_cliente"
    Dim connection As New OleDbConnection(connectionString)
    Dim command As New OleDbCommand(query, connection)
    Dim reader As OleDbDataReader
    Dim currentIndex As Integer = -1 ' Índice actual del elemento en el lector

    Private Sub AvanzarPedido()
        If reader.Read() Then
            currentIndex += 1
            Dim verdura1 As String = reader.GetValue(1) ' Reemplaza con el tipo de dato correcto según tu columna
            Dim verdura2 As String = reader.GetValue(2) ' Reemplaza con el tipo de dato correcto según tu columna
            Dim verdura3 As String = reader.GetValue(3) ' Reemplaza con el tipo de dato correcto según tu columna
            Dim verdura4 As String = reader.GetValue(4) ' Reemplaza con el tipo de dato correcto según tu columna
            Dim verdura5 As String = reader.GetValue(5) ' Reemplaza con el tipo de dato correcto según tu columna
            Dim costoTotal As String = reader.GetValue(7) ' Reemplaza con el tipo de dato correcto según tu columna

            ' Hacer algo con el elemento obtenido, por ejemplo, mostrarlo en un TextBox
            verdura1Label.Text = verdura1
            verdura2Label.Text = verdura2
            verdura3Label.Text = verdura3
            verdura4Label.Text = verdura4
            verdura5Label.Text = verdura5
            precioTotalLabel.Text = costoTotal

        Else
            MessageBox.Show("No hay más elementos.")
        End If
    End Sub

    Private Sub MisPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
        command.Parameters.AddWithValue("@id_cliente", variables.IDUsuarioGlobal)
        reader = command.ExecuteReader()
        AvanzarPedido()
    End Sub

    Private Sub SiguienteButton_Click(sender As Object, e As EventArgs) Handles SiguienteButton.Click
        AvanzarPedido()
    End Sub

    Private Sub MisPedidos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        reader.Close()
        connection.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub precioTotalLabel_Click(sender As Object, e As EventArgs) Handles precioTotalLabel.Click

    End Sub

    Private Sub verdura5Label_Click(sender As Object, e As EventArgs) Handles verdura5Label.Click

    End Sub

    Private Sub verdura4Label_Click(sender As Object, e As EventArgs) Handles verdura4Label.Click

    End Sub

    Private Sub verdura3Label_Click(sender As Object, e As EventArgs) Handles verdura3Label.Click

    End Sub

    Private Sub verdura2Label_Click(sender As Object, e As EventArgs) Handles verdura2Label.Click

    End Sub

    Private Sub verdura1Label_Click(sender As Object, e As EventArgs) Handles verdura1Label.Click

    End Sub
End Class
