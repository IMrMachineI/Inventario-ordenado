using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConListasOrdenado
{
    class Productos
    {
        private int _codigo { get; }
        private string _nombre { get; }
        private int _cantidad { get; }
        private int _costo { get; }
        public Productos siguiente;
        public int codigo
        {
            get { return _codigo; }
        }
        public string nombre
        {
            get { return _nombre; }
        }
        public int cantidad
        {
            get { return _cantidad; }
        }
        public int costo
        {
            get { return _costo; }
        }
        public Productos(int codigo, string nombre, int cantidad, int costo)
        {
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _costo = costo;
        }
        public override string ToString()
        {
            return "Codigo: " + _codigo + "\r\nNombre: " + _nombre + "\r\nCantidad: " + _cantidad + "\r\nCosto: " + _costo + "\r\n";
        }
    }
}
