using System;
using System.Windows.Forms;

namespace APP3C.MaquinaExp
{
    public partial class frmMaquina : Form
    {
        Producto producto1 = new Producto("Papas", 18.5f, 100);
        Producto producto2 = new Producto("Refresco", 22f, 80);
        Producto producto3 = new Producto("Chocolate", 15f, 50);
        Producto producto4 = new Producto("Galletas", 12.5f, 70);
        public frmMaquina()
        {
            InitializeComponent();
        }
        private void frmMaquina_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }
        private void MostrarProductos()
        {
            lstVitrina.Items.Clear();
            lstVitrina.Items.Add("1. " + producto1.ObtenerNombre() + " | Precio: $" + producto1.ObtenerPrecio() + " | Inventario: " + producto1.ObtenerInventario());
            lstVitrina.Items.Add("2. " + producto2.ObtenerNombre() + " | Precio: $" + producto2.ObtenerPrecio() + " | Inventario: " + producto2.ObtenerInventario());
            lstVitrina.Items.Add("3. " + producto3.ObtenerNombre() + " | Precio: $" + producto3.ObtenerPrecio() + " | Inventario: " + producto3.ObtenerInventario());
            lstVitrina.Items.Add("4. " + producto4.ObtenerNombre() + " | Precio: $" + producto4.ObtenerPrecio() + " | Inventario: " + producto4.ObtenerInventario());
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int seleccion = int.Parse(txtSeleccion.Text);
            int cantidadCompra = int.Parse(txtCantidad.Text);
            string mensaje = "";
            if (seleccion == 1)
                mensaje = producto1.ComprarProducto(cantidadCompra);
            else if (seleccion == 2)
                mensaje = producto2.ComprarProducto(cantidadCompra);
            else if (seleccion == 3)
                mensaje = producto3.ComprarProducto(cantidadCompra);
            else if (seleccion == 4)
                mensaje = producto4.ComprarProducto(cantidadCompra);
            else
                mensaje = "Opcion no válida";
            MessageBox.Show(mensaje, "Resultado");
            MostrarProductos();
        }
        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            int seleccion = int.Parse(txtSeleccion.Text);
            int cantidadAgregar = int.Parse(txtCantidad.Text);
            string mensaje = "";

            if (seleccion == 1)
                mensaje = producto1.AbastecerProducto(cantidadAgregar);
            else if (seleccion == 2)
                mensaje = producto2.AbastecerProducto(cantidadAgregar);
            else if (seleccion == 3)
                mensaje = producto3.AbastecerProducto(cantidadAgregar);
            else if (seleccion == 4)
                mensaje = producto4.AbastecerProducto(cantidadAgregar);
            else
                mensaje = "Opcion no válida";
            MessageBox.Show(mensaje, "Resultado");
            MostrarProductos();
        }
    }
}