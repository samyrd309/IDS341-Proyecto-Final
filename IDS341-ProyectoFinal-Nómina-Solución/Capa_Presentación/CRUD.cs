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
    }
}
