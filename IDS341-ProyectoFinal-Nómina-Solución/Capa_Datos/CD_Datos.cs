using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Datos
    {
        private ConnectionToSql connection = new ConnectionToSql();

        SqlDataReader read;
        DataTable table = new DataTable();
        SqlCommand command = new SqlCommand();

        // Show payroll
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

        // Insert payroll
        public void Insert(string DNI, string FirstName, string LastName, string Position, string PhoneNumber, double Salary, double SocialSecurity, double Taxes, double Payment, int Assistance)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "spInsertEmployee";
            command.CommandType = CommandType.StoredProcedure;
            
            command.Parameters.AddWithValue("@DNI", DNI);
            command.Parameters.AddWithValue("@Firstname", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Position", Position);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@SocialSecurity", SocialSecurity);
            command.Parameters.AddWithValue("@Taxes", Taxes);
            command.Parameters.AddWithValue("@Payment", Payment);
            command.Parameters.AddWithValue("@Assistance", Assistance);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Connection = connection.CloseConnection();
        }


        // Edit payroll
        public void Edit(string DNI, string FirstName, string LastName, string Position, string PhoneNumber, double Salary, double SocialSecurity, double Taxes, double Payment, int Assistance)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "spUpdateInfo";
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@DNI", DNI);
            command.Parameters.AddWithValue("@Firstname", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Position", Position);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@SocialSecurity", SocialSecurity);
            command.Parameters.AddWithValue("@Taxes", Taxes);
            command.Parameters.AddWithValue("@Payment", Payment);
            command.Parameters.AddWithValue("@Assistance", Assistance);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            command.Connection = connection.CloseConnection();
        }

        // Delete payroll
        public void Delete(string DNI)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "spDeleteEmployee";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DNI", DNI);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        //Function to validate the existence of data
        public bool ExisteRegistro(string DNI, string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection.OpenConnection());
            cmd.Parameters.AddWithValue("@DNI", DNI);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 0)
                return false;
            else
                return true;
        }
    }
}
