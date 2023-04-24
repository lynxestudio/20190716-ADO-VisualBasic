# How to execute simple Database Queries with VB .NET

The SqlCommand class in the .NET Framework Data Provider has four methods that you can use to execute SQL statements:

ExecuteScalar: Executes a query that returns a single scalar value.
ExecuteReader: Executes a query that returns a result set.
ExecuteNonQuery: Executes a data update statements or a catalog update statement.
ExecuteXmlReader: Executes a query that returns an Extensible Markup Language (XML) result set, this method is only avaliable in the SqlCommand class.
To execute a simple database query
Import the System.Configuration namespace
Use the ConfigurationManager.ConnectionStrings property to get a collection of connection strings from the application configuration file.
Index into the collection of connection strings by using the programmatic name of the connection string you want to access.
Use the ConnectionString property to get the connection string information.
Create a connection object.
Create a command object.
If you want to execute an SQL statement, set the CommandType property of the command object to the CommandType.Text enumeration value. If you want to call a stored procedure, set the CommandType property of the command object to the CommandType.StoredProcedure enumeration value.
Call the Open method on the connection object.
Call the ExecuteScalar method on the command object. Assign the result to a suitably typed variable.
Call the Close method on the connection object.
The following example shows how to execute a query to determine the number of products in the AdventureWorks2016CTP3 database on the local SQL Server instance.

Fig 1. Main program

Fig 2. App config

Fig 3. Output program

Download example source code.
