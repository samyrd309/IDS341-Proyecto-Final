
namespace Capa_Presentación
{
    partial class CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtDNI = new System.Windows.Forms.TextBox();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.txtPhoneNumber = new System.Windows.Forms.TextBox();
			this.txtSalary = new System.Windows.Forms.TextBox();
			this.txtAssistance = new System.Windows.Forms.TextBox();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblDNI = new System.Windows.Forms.Label();
			this.lblPosition = new System.Windows.Forms.Label();
			this.lblSalary = new System.Windows.Forms.Label();
			this.lblPhoneNumber = new System.Windows.Forms.Label();
			this.lblAssistance = new System.Windows.Forms.Label();
			this.btnLogout = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvPayroll = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).BeginInit();
			this.SuspendLayout();
			// 
			// txtFirstName
			// 
			this.txtFirstName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFirstName.Location = new System.Drawing.Point(19, 145);
			this.txtFirstName.MaxLength = 45;
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(233, 23);
			this.txtFirstName.TabIndex = 1;
			// 
			// txtLastName
			// 
			this.txtLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLastName.Location = new System.Drawing.Point(19, 199);
			this.txtLastName.MaxLength = 45;
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(233, 23);
			this.txtLastName.TabIndex = 2;
			// 
			// txtDNI
			// 
			this.txtDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDNI.Location = new System.Drawing.Point(19, 89);
			this.txtDNI.MaxLength = 11;
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(233, 23);
			this.txtDNI.TabIndex = 3;
			this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
			// 
			// txtPosition
			// 
			this.txtPosition.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPosition.Location = new System.Drawing.Point(301, 123);
			this.txtPosition.MaxLength = 45;
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(233, 23);
			this.txtPosition.TabIndex = 4;
			// 
			// txtPhoneNumber
			// 
			this.txtPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPhoneNumber.Location = new System.Drawing.Point(19, 257);
			this.txtPhoneNumber.MaxLength = 11;
			this.txtPhoneNumber.Name = "txtPhoneNumber";
			this.txtPhoneNumber.Size = new System.Drawing.Size(233, 23);
			this.txtPhoneNumber.TabIndex = 5;
			// 
			// txtSalary
			// 
			this.txtSalary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSalary.Location = new System.Drawing.Point(301, 245);
			this.txtSalary.Name = "txtSalary";
			this.txtSalary.Size = new System.Drawing.Size(233, 23);
			this.txtSalary.TabIndex = 6;
			this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
			// 
			// txtAssistance
			// 
			this.txtAssistance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAssistance.Location = new System.Drawing.Point(301, 190);
			this.txtAssistance.MaxLength = 3;
			this.txtAssistance.Name = "txtAssistance";
			this.txtAssistance.Size = new System.Drawing.Size(233, 23);
			this.txtAssistance.TabIndex = 9;
			this.txtAssistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAssistance_KeyPress);
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFirstName.Location = new System.Drawing.Point(19, 124);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(85, 18);
			this.lblFirstName.TabIndex = 10;
			this.lblFirstName.Text = "First name:";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLastName.Location = new System.Drawing.Point(19, 178);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(86, 18);
			this.lblLastName.TabIndex = 11;
			this.lblLastName.Text = "Last name:";
			// 
			// lblDNI
			// 
			this.lblDNI.AutoSize = true;
			this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDNI.Location = new System.Drawing.Point(19, 68);
			this.lblDNI.Name = "lblDNI";
			this.lblDNI.Size = new System.Drawing.Size(38, 18);
			this.lblDNI.TabIndex = 12;
			this.lblDNI.Text = "DNI:";
			// 
			// lblPosition
			// 
			this.lblPosition.AutoSize = true;
			this.lblPosition.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPosition.Location = new System.Drawing.Point(301, 102);
			this.lblPosition.Name = "lblPosition";
			this.lblPosition.Size = new System.Drawing.Size(67, 18);
			this.lblPosition.TabIndex = 13;
			this.lblPosition.Text = "Position:";
			// 
			// lblSalary
			// 
			this.lblSalary.AutoSize = true;
			this.lblSalary.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSalary.Location = new System.Drawing.Point(301, 224);
			this.lblSalary.Name = "lblSalary";
			this.lblSalary.Size = new System.Drawing.Size(58, 18);
			this.lblSalary.TabIndex = 14;
			this.lblSalary.Text = "Salary:";
			// 
			// lblPhoneNumber
			// 
			this.lblPhoneNumber.AutoSize = true;
			this.lblPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPhoneNumber.Location = new System.Drawing.Point(19, 236);
			this.lblPhoneNumber.Name = "lblPhoneNumber";
			this.lblPhoneNumber.Size = new System.Drawing.Size(119, 18);
			this.lblPhoneNumber.TabIndex = 15;
			this.lblPhoneNumber.Text = "Phone number:";
			// 
			// lblAssistance
			// 
			this.lblAssistance.AutoSize = true;
			this.lblAssistance.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAssistance.Location = new System.Drawing.Point(301, 167);
			this.lblAssistance.Name = "lblAssistance";
			this.lblAssistance.Size = new System.Drawing.Size(88, 18);
			this.lblAssistance.TabIndex = 17;
			this.lblAssistance.Text = "Assistance:";
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.Maroon;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLogout.Location = new System.Drawing.Point(903, 622);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(113, 32);
			this.btnLogout.TabIndex = 21;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(255, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(528, 44);
			this.label1.TabIndex = 22;
			this.label1.Text = "Payroll management system";
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(884, 236);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(132, 35);
			this.btnDelete.TabIndex = 20;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
			this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnEdit.Image = global::Capa_Presentación.Properties.Resources.edit;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(884, 183);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(132, 35);
			this.btnEdit.TabIndex = 19;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.SystemColors.WindowFrame;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnSave.Image = global::Capa_Presentación.Properties.Resources.save;
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(884, 123);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(132, 35);
			this.btnSave.TabIndex = 18;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dgvPayroll
			// 
			this.dgvPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPayroll.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvPayroll.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dgvPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvPayroll.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Info;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPayroll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPayroll.ColumnHeadersHeight = 30;
			this.dgvPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPayroll.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPayroll.EnableHeadersVisualStyles = false;
			this.dgvPayroll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.dgvPayroll.Location = new System.Drawing.Point(22, 290);
			this.dgvPayroll.MultiSelect = false;
			this.dgvPayroll.Name = "dgvPayroll";
			this.dgvPayroll.ReadOnly = true;
			this.dgvPayroll.RowHeadersVisible = false;
			this.dgvPayroll.RowHeadersWidth = 51;
			this.dgvPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPayroll.Size = new System.Drawing.Size(994, 330);
			this.dgvPayroll.TabIndex = 23;
			// 
			// CRUD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(1028, 662);
			this.Controls.Add(this.dgvPayroll);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblAssistance);
			this.Controls.Add(this.lblPhoneNumber);
			this.Controls.Add(this.lblSalary);
			this.Controls.Add(this.lblPosition);
			this.Controls.Add(this.lblDNI);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txtAssistance);
			this.Controls.Add(this.txtSalary);
			this.Controls.Add(this.txtPhoneNumber);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.txtDNI);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtFirstName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CRUD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Payroll manager";
			this.Load += new System.EventHandler(this.CRUD_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPayroll)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtAssistance;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAssistance;
        private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		public System.Windows.Forms.DataGridView dgvPayroll;
	}
}