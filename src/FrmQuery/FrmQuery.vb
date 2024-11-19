Imports System.Configuration
Imports System.Data.SqlClient


Public Class FrmQuery

    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("advWorks").ConnectionString
            Dim connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(txtCommand.Text, connection)
            command.CommandType = CommandType.Text
            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            connection.Close()
            txtOutput.Text = "Executing the method ExecuteScalar()"
            txtOutput.Text = "Total of products " + count.ToString()
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
