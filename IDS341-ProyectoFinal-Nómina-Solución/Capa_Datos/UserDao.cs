using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
	public class UserDao : ConnectionToSql
	{
		private ConnectionToSql connection = new ConnectionToSql();

		SqlDataReader read;
		SqlCommand command = new SqlCommand();

		public bool Login(string user, string pass)
		{
			command.Connection = connection.OpenConnection();
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
			connection.CloseConnection();
		}
	}
}
