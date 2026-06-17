using APP3C.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.login
{
    public partial class  FrmLogin : Form
    {
        private Principal principal;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (usuario=="1" && password=="1")
            {
                principal = new Principal();
                principal.Show();
                this.Hide();
            }
            else
            {
                lblLeyenda.Text = "Credenciales incorrectas \nIntenta de nuevo";
                lblLeyenda.Visible = true;
                txtUser.Clear();
                txtPassword.Clear();
                //txtUser.Focus();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }
        private void txtUser_DragEnter(object sender, EventArgs e)
        {
            lblLeyenda.Visible = false;
        }
    }
}
