using System;

namespace APP3C.MaquinaExp
{
    class Producto
    {
        private string nombre;
        private float precio;
        private int inventario;
        public Producto(string nombre, float precio, int inventario)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.inventario = inventario;
        }
        public string ObtenerNombre() { return nombre; }
        public float ObtenerPrecio() { return precio; }
        public int ObtenerInventario() { return inventario; }
        public string ComprarProducto(int cantidad)
        {
            if (cantidad <= 0) return "Cantidad inválida.";
            if (cantidad > inventario) return "No hay suficiente inventario.";

            inventario -= cantidad;
            float total = cantidad * precio;
            return "Compra realizada \nEl total a pagar es: $" + total;
        }

        public string AbastecerProducto(int cantidad)
        {
            if (cantidad > 0)
            {
                inventario += cantidad;
                return "Producto abastecido correctamente.";
            }
            return "Cantidad inválida.";
        }
    }
}