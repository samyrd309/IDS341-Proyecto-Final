using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;

namespace Capa_Negocio
{
    public class CN_Negocio
    {
        private CD_Datos objectCD = new CD_Datos();

        //Show Payroll Method
        public DataTable ShowPayroll()
        {
            DataTable table = new DataTable();
            table = objectCD.Show();
            return table;
        }

        // Insert payroll method        
        public void Insert(string DNI, string FirstName, string LastName, string Position, string PhoneNumber, string Salary, string SocialSecurity, string Taxes, string Payment, string Assistance)
        {
            objectCD.Insert(DNI, FirstName, LastName, Position, PhoneNumber, Convert.ToDouble(Salary), Convert.ToDouble(SocialSecurity), Convert.ToDouble(Taxes), Convert.ToDouble(Payment), Convert.ToInt32(Assistance));
        }

        // Edit payroll method        
        public void Edit(string DNI, string FirstName, string LastName, string Position, string PhoneNumber, string Salary, string SocialSecurity, string Taxes, string Payment, string Assistance)
        {
            objectCD.Edit(DNI, FirstName, LastName, Position, PhoneNumber, Convert.ToDouble(Salary), Convert.ToDouble(SocialSecurity), Convert.ToDouble(Taxes), Convert.ToDouble(Payment), Convert.ToInt32(Assistance));
        }

        //Delete Payroll Method
        public void DeletePayroll(string DNI)
        {
            objectCD.Delete(DNI);
        }

        // Función para encontrar registros iguales
        public bool ExisteRegistro(string id, string query)
        {
            return objectCD.ExisteRegistro(id, query);
        }
    }
}
