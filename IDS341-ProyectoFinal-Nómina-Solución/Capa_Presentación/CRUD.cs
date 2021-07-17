using Capa_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Presentación
{
    public partial class CRUD : Form
    {
        private string DNI = null;
        CN_Negocio objectCN = new CN_Negocio();

        string EditDNI;
        bool Editar = false;

        public CRUD()
        {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            ShowPayroll();
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
        public double SocialSecurity(double vSocialSec)
        {
            vSocialSec *= Math.Round((0.0304 + 0.0287), 2);
            return vSocialSec;
        }

        // Cálculo de Impuesto sobre la renta (ISR) en función del sueldo bruto, aplicándole los descuentos anteriores.
        public double Taxes(double vSalary, double vSocialSec)
        {
            double Taxes = 0;
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

        // Save button
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Trim() != "" || txtLastName.Text.Trim() != "" || txtDNI.Text.Trim() != "" || txtAssistance.Text.Trim() != "" || txtPhoneNumber.Text.Trim() != "" || txtPosition.Text.Trim() != "" || txtSalary.Text.Trim() != "")
            {
                try
                {
                    double vSocialSec = SocialSecurity(Convert.ToDouble(txtSalary.Text));
                    double vTaxes = Taxes(Convert.ToDouble(txtSalary.Text), vSocialSec);
                    double NetPayment = Convert.ToDouble(txtSalary.Text) - vTaxes;

                    string query = "SELECT COUNT(*) FROM Payroll WHERE DNI=@Id";
                    if (Editar == false)
                    {

                        if (objectCN.ExisteRegistro(txtDNI.Text, query) == false)
                        {
                            objectCN.Insert(txtDNI.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtPhoneNumber.Text, txtSalary.Text, vSocialSec.ToString(), vTaxes.ToString(), NetPayment.ToString(), txtAssistance.Text);
                            // Mejorar
                            MessageBox.Show("Process succesfully completed", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("The current DNI already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        objectCN.Edit(txtDNI.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtPhoneNumber.Text, txtSalary.Text, vSocialSec.ToString(), vTaxes.ToString(), NetPayment.ToString(), txtAssistance.Text);
                        // Mejorar
                        MessageBox.Show("Process succesfully completed", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Editar = false;


                    }


                    ShowPayroll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERROR{ex}");
                }
            }
            else
                MessageBox.Show("You must fill all the fields to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Edit button
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPayroll.SelectedRows.Count > 0)
            {
                Editar = true;

                EditDNI = dgvPayroll.CurrentRow.Cells[0].Value.ToString();
                txtDNI.Text = dgvPayroll.CurrentRow.Cells[0].Value.ToString();
                txtFirstName.Text = dgvPayroll.CurrentRow.Cells[1].Value.ToString();
                txtLastName.Text = dgvPayroll.CurrentRow.Cells[2].Value.ToString();
                txtPosition.Text = dgvPayroll.CurrentRow.Cells[3].Value.ToString();
                txtPhoneNumber.Text = dgvPayroll.CurrentRow.Cells[4].Value.ToString();
                txtSalary.Text = dgvPayroll.CurrentRow.Cells[5].Value.ToString();
                txtAssistance.Text = dgvPayroll.CurrentRow.Cells[9].Value.ToString();
            }
            else
                MessageBox.Show("You must select a row in order to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Delete
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
                MessageBox.Show("You must select a row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
