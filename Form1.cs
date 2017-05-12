using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioConListasOrdenado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Almacen nuevoAlmacen = new Almacen();
        Productos nuevoProducto;
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            nuevoProducto = new Productos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text,
                Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            nuevoAlmacen.agregarProducto(nuevoProducto);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (nuevoAlmacen.buscarProducto(Convert.ToInt32(txtCodigo.Text)) != null)
            {
                txtReporte.Text = (nuevoAlmacen.buscarProducto(Convert.ToInt32(txtCodigo.Text))).ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            nuevoAlmacen.eliminarProducto(Convert.ToInt32(txtCodigo.Text));
            txtReporte.Text = nuevoAlmacen.reporte();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            txtReporte.Text = nuevoAlmacen.ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            nuevoProducto = new Productos(Convert.ToInt32(txtCodigo.Text), txtNombre.Text,
                Convert.ToInt32(txtCantidad.Text), Convert.ToInt32(txtCosto.Text));
            nuevoAlmacen.insertarProducto(Convert.ToInt32(txtInsertar.Text),nuevoProducto);
        }
    }
}
