using Calificaciones.Cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP3C.Cafeteria
{
    public partial class frmCafeteria : Form
    {
        private List<Bebida> bebidas;
        public frmCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();
        }
        private void rdbCaliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCaliente.Checked)
            {
                lblExtra.Text = "Temperatura";
                label4.Visible = false;
                chkGluten.Visible = false;
                //txtGluten.Visible = false;
            }            
            else
            {
                lblExtra.Text = "% Alcohol";
                label4.Visible = true;
                chkGluten.Visible = true;
                //txtGluten.Visible = true;
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            float precio = float.Parse(txtPrecio.Text);
            string tamaño = cmbTamano.Text;
            int extra = int.Parse(txtExtra.Text);
            string conGluten = "";

            if (chkGluten.SelectedIndex == 0)
                conGluten = "Sí";
            else
                conGluten = "No";
            if (rdbCaliente.Checked)
            {
                bebidas.Add(new BebidaCaliente(nombre,tamaño,precio,extra));
            }
            else if (rdbFria.Checked)
            {
                bebidas.Add(new BebidaFria(nombre,tamaño,precio,extra));
            }
            else if (rdbAlcoholica.Checked)
            {
                bebidas.Add(new BebidaAlcoholica(nombre,tamaño,precio, extra,conGluten));
            }
            MessageBox.Show("Bebida agregada correctamente, tienes "+ bebidas.Count + " bebidas registradas");
            LimpiaCajas();
            if (bebidas[bebidas.Count - 1] is BebidaFria fria)
            {
                lsbLista.Items.Add(fria.Listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.Listar());
            }
            else if (bebidas[bebidas.Count - 1] is BebidaAlcoholica alcoholica)
            {
                lsbLista.Items.Add(alcoholica.Listar());
            }
            lblCantidad.Text = bebidas.Count + " Bebidas registradas";
        }
        private void LimpiaCajas()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cmbTamano.SelectedIndex = -1;
            chkGluten.SelectedIndex = -1;
            txtGluten.Text = "";
        }
        private void lsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (bebidas[lsbLista.SelectedIndex] is BebidaFria fria)
            {
                lblDescripcion.Text=fria.d
            }
            else if (bebidas[bebidas.Count - 1] is BebidaCaliente caliente)
            {
                lsbLista.Items.Add(caliente.Listar());
            }*/
            Bebida bebidaSeleccionada = bebidas[lsbLista.SelectedIndex];
            lblDescripcion.Text =bebidaSeleccionada.Preparar();
            if (bebidaSeleccionada is BebidaAlcoholica alcoholica)
            {
                txtGluten.Text ="Con gluten: "+ alcoholica.ConGluten;
                txtGluten.Visible = true;
            }
            else
            {
                txtGluten.Text = "";
            }
        }
        private void txtPorcentajeAlcohol_Click(object sender, EventArgs e)
        {
        }
        private void rdbAlcoholica_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdbAlcoholica.Checked)
            //{
            //    lblExtra.Text = "% Alcohol";
            //    label4.Visible = true;
            //    chkGluten.Visible = true;
            //    txtPorcentajeAlcohol.Visible = true;
            //}
        }
        private void rbtAlcoholica_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            chkGluten.Visible = true;
            txtGluten.Visible = true;
            //txtGluten.Text= "Con gluten: ";
        }
        private void rdbFria_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFria.Checked)
            {
                lblExtra.Text = "Cantidad de hielo";
                label4.Visible = false;
                chkGluten.Visible = false;
                //txtGluten.Visible = false;
            }
            else
            {
                lblExtra.Text = "% Alcohol";
                label4.Visible = true;
                chkGluten.Visible = true;
                //txtGluten.Visible = true;
            }
        }
        private void lblExtra_Click(object sender, EventArgs e)
        {
        }
        private void chkGluten_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
