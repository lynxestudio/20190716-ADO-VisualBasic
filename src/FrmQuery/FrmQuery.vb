Imports System.Configuration
Imports System.Data.SqlClient


Public Class FrmQuery

    Private Sub btnRun_Click(sender As System.Object, e As System.EventArgs) Handles btnRun.Click
        Dim queryText As String
        If query1.Checked Then
            queryText = query1.Text
        End If
        If query2.Checked Then
            queryText = query2.Text
        End If
        If query3.Checked Then
            queryText = query3.Text
        End If
        If query4.Checked Then
            queryText = query4.Text
        End If
        If query5.Checked Then
            queryText = query5.Text
        End If
        Try
            Dim connectionString As String = ConfigurationManager.ConnectionStrings("advWorks").ConnectionString
            Dim connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(queryText, connection)
            command.CommandType = CommandType.Text
            connection.Open()
            Dim count As Integer = CInt(command.ExecuteScalar())
            connection.Close()
            txtOutput.Text = "Executing the method ExecuteScalar()"
            txtOutput.Text += " Total: " + count.ToString()
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
