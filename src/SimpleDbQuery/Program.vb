imports System.Data.SqlClient
imports System.Configuration

Module Program
	Sub Main()
	Dim connectionString as String =  _ 
	ConfigurationManager.ConnectionStrings("advWorks").ConnectionString
	Dim connection as New SqlConnection(connectionString)
	Dim command as New SqlCommand( _
	"SELECT COUNT(*) FROM Production.Product", _
	connection)
	command.CommandType = CommandType.Text
	connection.Open()
	Dim count as Integer = CInt(command.ExecuteScalar())
	connection.Close()
	Console.Clear()
		Console.WriteLine(" [ Executing the method ExecuteScalar() ]")
		Console.WriteLine()
		Console.WriteLine(" Total of products: {0}", count)
		Console.WriteLine()		
		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
