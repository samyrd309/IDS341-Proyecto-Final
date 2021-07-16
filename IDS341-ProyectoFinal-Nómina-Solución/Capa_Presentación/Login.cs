using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentación
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "") 
            {
                if (textBox2.Text != "") 
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(textBox1.Text, textBox2.Text);
                    if (validLogin == true)
                    {
                        msgError("Exito");

                        //Mostrar el formulario principal
                        //y olcutar el formulario de Login

                        CRUD crud = new CRUD();
                        crud.Show();
                        this.Hide();

                        //FormPrincipal mainMenu = new FormPrincipal();
                        //mainMenu.Show();
                        //mainMenu.FormClosed += Logout;
                        //this.Hide();/
                    }
                    else
                    {
                        msgError("Wrong username or password. \n Please, try again!.");
                        textBox2.Clear();
                        textBox1.Focus();
                    }
                }
                else msgError("Please enter your password.");
            }
            else msgError("Please enter your username.");
        }
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            lblErrorMessage.Visible = false;
            this.Show();
            textBox1.Focus();
        }
    }
}
