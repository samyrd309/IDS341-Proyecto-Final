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

        //Delete Payroll Method

        public void DeletePayroll(string DNI)
        {
            objectCD.Delete(DNI);
        }
    }
}
