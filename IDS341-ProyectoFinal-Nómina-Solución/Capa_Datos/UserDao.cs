using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
	public class UserDao : ConnectionToSql
	{
		public bool Login(string user, string pass)
		{
			using (var connection = GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "select * from Register where UserName=@User and UserPassword=@pass";
					command.Parameters.AddWithValue("@user", user);
					command.Parameters.AddWithValue("@pass", pass);
					command.CommandType = CommandType.Text;
					SqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						return true;
					}
					else
						return false;
				}
			}
		}
	}
}
