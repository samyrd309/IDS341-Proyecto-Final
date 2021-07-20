using Capa_Negocio;
using System;
using System.Windows.Forms;

namespace Capa_Presentación
{
	public partial class CRUD : Form
	{
		private string DNI = null;
		CN_Negocio objectCN = new CN_Negocio();
		Login LoginW = new Login();

		string EditDNI;
		bool bEdit = false;

		public CRUD()
		{
			InitializeComponent();
		}

		// Load form function
		private void CRUD_Load(object sender, EventArgs e)
		{
			ShowPayroll();
		}

		// FUNCTIONS //

		// Show data
		private void ShowPayroll()
		{
			CN_Negocio objectCN = new CN_Negocio();
			dgvPayroll.DataSource = objectCN.ShowPayroll();
		}

		/* Calculus of taxes corresponding to:
         * Family Social Security (SFS).
         * Pension fund administrator (AFP). 
         */
		public double SocialSecurity(double vSocialSec)
		{
			vSocialSec *= Math.Round((0.0304 + 0.0287), 2);
			return vSocialSec;
		}

		// Calculus of Income taxes (ISR) based on the gross family, applying the previuos discounts: 
		public double Taxes(double vSalary, double vSocialSec)
		{
			double Taxes = (vSalary - vSocialSec) * 12;
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
			if (txtFirstName.Text.Trim() != "" && txtLastName.Text.Trim() != "" && txtDNI.Text.Length == 11 && txtAssistance.Text.Trim() != "" && txtPhoneNumber.Text.Trim() != "" && txtPosition.Text.Trim() != "" && txtSalary.Text.Trim() != "")
			{
				// Taxes Discount functions
				double vSocialSec = SocialSecurity(Convert.ToDouble(txtSalary.Text));
				double vTaxes = Taxes(Convert.ToDouble(txtSalary.Text), vSocialSec);
				double NetPayment = Convert.ToDouble(txtSalary.Text) - vTaxes;

				string query = "SELECT COUNT(*) FROM Payroll WHERE DNI=@DNI";

				try
				{
					if (bEdit == false)
					{
						if (objectCN.ExisteRegistro(txtDNI.Text, query) == false)
							objectCN.Insert(txtDNI.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtPhoneNumber.Text, txtSalary.Text, vSocialSec.ToString(), vTaxes.ToString(), NetPayment.ToString(), txtAssistance.Text);
						else
							MessageBox.Show("The current DNI already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						objectCN.Edit(txtDNI.Text, txtFirstName.Text, txtLastName.Text, txtPosition.Text, txtPhoneNumber.Text, txtSalary.Text, vSocialSec.ToString(), vTaxes.ToString(), NetPayment.ToString(), txtAssistance.Text);
						bEdit = false;
						btnEdit.Text = "Edit";
						txtDNI.Enabled = true;
					}

					MessageBox.Show("Process succesfully completed", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
					CleanFields();
					ShowPayroll();
				}
				catch (Exception ex)
				{
					MessageBox.Show($"ERROR: {ex}");
				}
			}
			else
			{
				MessageBox.Show("You must fill all the fields to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txtDNI.Focus();
			}
		}

		// Edit button
		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (bEdit)
			{
				case false:
					if (dgvPayroll.SelectedRows.Count > 0)
					{
						bEdit = true;
						btnEdit.Text = "Cancel";
						txtDNI.Enabled = false;

						// Textboxes data load
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
					break;

				case true:
					if(MessageBox.Show("Are you sure you want to cancel the edition?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
						txtDNI.Enabled = true;
						btnEdit.Text = "Edit";
						bEdit = false;
						CleanFields();
					}
					break;
			}
		}

		// Delete button
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvPayroll.SelectedRows.Count > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete the row?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					DNI = dgvPayroll.CurrentRow.Cells[0].Value.ToString();
					objectCN.DeletePayroll(DNI);
					MessageBox.Show("Register correctly removed");
					ShowPayroll();
				}
			}
			else
				MessageBox.Show("You must select a row to delete it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		// Logout button
		private void btnLogout_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to logout?", "Action confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
				LoginW.Show();
			}
		}

		// Clean fields function
		private void CleanFields()
		{
			txtAssistance.Clear();
			txtDNI.Clear();
			txtFirstName.Clear();
			txtLastName.Clear();
			txtPhoneNumber.Clear();
			txtPosition.Clear();
			txtSalary.Clear();
		}

		// Salary input only numbers control
		private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}

			// Allows only one decimal point
			if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
			{
				e.Handled = true;
			}
		}

		// Assitance input only numbers control
		private void txtAssistance_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// DNI input only numbers control
		private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}