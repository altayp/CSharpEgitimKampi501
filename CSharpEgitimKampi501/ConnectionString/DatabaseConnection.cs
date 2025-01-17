using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.ConnectionString
{
	public static class DatabaseConnection
	{
		public static void ConnectToDatabase()
		{
			SqlConnection connection = new SqlConnection("Server=ALTAY\\SQLEXPRESS; initial Catalog=EgitimKampi501Db;integrated security=true");
		}
	}
}
