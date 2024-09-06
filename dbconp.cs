using System;
using System.Data.SqlClient;
class DatabaseConnection{
	public static void Main(){
		SqlConnectionStringBuilder Sbc = new SqlConnectionStringBuilder();
		Sbc.DataSource=@"(localdb)\MSSQLLocalDB";
		Sbc.InitialCatalog="dotnet";
		Sbc.IntegratedSecurity=true;
		using(SqlConnection con=new SqlConnection(Sbc.ConnectionString)){
			con.Open();
			Console.WriteLine("connection successful");
		}
	}
}