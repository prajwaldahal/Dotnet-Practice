using System;
using System.Data;
using System.Data.SqlClient;
namespace db{
		class program
{
    public static void Main()
    {
		//SqlDataReader reader;
        SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
        sb.DataSource = @"(localdb)\MSSQLLocalDB";; //server connection
        sb.InitialCatalog="dotnet"; //dbname
        sb.IntegratedSecurity = true; //integrating window security
        using (SqlConnection con = new SqlConnection(sb.ConnectionString))
        {
            con.Open();
            //string insertDB = @"insert into customer values(3,'roshan kumar sunwar'),(4,'padam raj joshi')";
            //SqlCommand cmd = new SqlCommand(insertDB, con);
			
			string retrieveDB=@"select * from customer";
			SqlDataAdapter sqd = new SqlDataAdapter(retrieveDB,con);
			DataSet d= new DataSet();
			
			sqd.Fill(d);
			
			foreach (DataRow ds in d.Tables[0].Rows)
			{
				Console.WriteLine(ds[1]);
			}
            // try
            // {
                // //cmd.ExecuteNonQuery();
				// Console.WriteLine("record inserted");
				
				// Console.WriteLine("records: ");
				// reader=cmd1.ExecuteReader();
				// while(reader.Read())
				// {
					
					// int x=Convert.ToInt32(reader["id"]);
					// string name=reader["name"].ToString();
					// Console.Write("{0} {1}\n",x,name);
					
				// }
            // }
            // catch (Exception e)
            // {
                // Console.WriteLine(e);
            // }
        }
    }
}

}
