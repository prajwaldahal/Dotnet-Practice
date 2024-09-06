using System;
using System.Data.SqlClient;
class program
{
    public static void Main()
    {
        SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
        sb.DataSource = @"(localdb)\MSSQLLocalDB";; //server connection
        sb.InitialCatalog="dotnet"; //dbname
        sb.IntegratedSecurity = true; //integrating window security
        using (SqlConnection con = new SqlConnection(sb.ConnectionString))
        {
            con.Open();
            string createDB = @"create table product(id int primary key,name varchar(20),price int)";
            SqlCommand cmd = new SqlCommand(createDB, con);
            try
            {
                cmd.ExecuteNonQuery();
				Console.WriteLine("table created");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
