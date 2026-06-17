using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.HolaMundo
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
            lblResultado.Visible = false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                float valor1 = float.Parse(txtValor1.Text.Trim());
                float valor2 = float.Parse(txtValor2.Text.Trim());
                float resultado = valor1 + valor2;
                lblResultado.Text = "El resultado de la operacion es : " + resultado;
                lblResultado.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el error : "+ex.Message);
            }
            
            
            
        }

        private void txtValor1_Leave(object sender, EventArgs e)
        {
            /*string valor= txtValor1.Text.Trim();

            if(valor.Length == 0)
            {
                MessageBox.Show("Esta caja no puede quedar vacia...");
                txtValor1.Focus();
            }*/
        }
    }
}
