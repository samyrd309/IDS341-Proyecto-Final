using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Capa_Datos
{
    public class CD_Datos
    {
        private CD_Conexion connection = new CD_Conexion();

        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        public DataTable Show()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "spShowPayroll";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            table.Load(read);
            connection.CloseConnection();
            return table;
        }

        public void Delete(string DNI)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "spDeleteEmployee";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DNI",DNI);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
