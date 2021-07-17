using Capa_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Presentación
{
    public partial class CRUD : Form
    {
        private string DNI = null;
        CN_Negocio objectCN = new CN_Negocio();
        public CRUD()
        {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            ShowPayroll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPayroll.SelectedRows.Count > 0)
            {
                DNI = dgvPayroll.CurrentRow.Cells[0].Value.ToString();
                objectCN.DeletePayroll(DNI);
                MessageBox.Show("Register correctly removed");
                ShowPayroll();
            }
            else
                MessageBox.Show("You must select a row.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);                          
        }

        //FUNCIONES
        //MOSTRAR DATOS EN EL DATAGRIDVIEW
        private void ShowPayroll()
        {
            CN_Negocio objectCN = new CN_Negocio();
            dgvPayroll.DataSource = objectCN.ShowPayroll();
        }

        /* Cálculo de los impuestos correspondientes a:
         * Seguro Familiar de Salud (SFS).
         * Administradora de fondo de pensiones (AFP).
         */
        public double SocialSecurity (double vSocialSec)
        {
            vSocialSec *= (0.0304+0.0287);
            return vSocialSec;
        }

        // Cálculo de Impuesto sobre la renta (ISR) en función del sueldo bruto, aplicándole los descuentos anteriores.
        public double Taxes (double Taxes, double vSalary, double vSocialSec)
        {
            Taxes = (vSalary - vSocialSec) * 12;
            double vDiscount;

            if (Taxes > 833171.01)
                vDiscount = 0.25;
            else if (Taxes > 599884.01)
                vDiscount = 0.2;
            else if (Taxes > 399923)
                vDiscount = 0.15;
            else
                vDiscount = 0;

            Taxes = Math.Round(((Taxes * vDiscount) / 12), 2);
            return Taxes;
        }


    }
}
