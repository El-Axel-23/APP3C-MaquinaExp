using APP3C.HolaMundo;
using APP3C.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calculadora = Application.OpenForms["frmCalculadora"];

            if (calculadora != null)
            {
                if(calculadora.WindowState == FormWindowState.Minimized)
                {
                    calculadora.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                calculadora = new frmCalculadora();
                calculadora.MdiParent = this;
                calculadora.FormClosed += (s, args) => calculadora.Dispose(); //Cerrar formulario
                calculadora.Show();
            }


            ////crear objeto
            //frmCalculadora calculadora = new frmCalculadora();
            ////verificar que no sea objeto suelto
            //calculadora.MdiParent=this;
            //calculadora.Show();
        }

        private void cafeteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cafeteria = Application.OpenForms["frmCafeteria"];

            if (cafeteria != null)
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                {
                    cafeteria.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                cafeteria = new frmCafeteria();
                cafeteria.MdiParent = this;
                cafeteria.FormClosed += (s, args) => cafeteria.Dispose(); //Cerrar formulario
                cafeteria.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abreinstancias(Form form)
        {

        }
    }
}
