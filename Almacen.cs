using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioConListasOrdenado
{
    class Almacen
    {
        private Productos inicio;

        public Almacen()
        {
            inicio = null;
        }

        public bool agregarProducto(Productos producto)
        {
            bool sePuedeAgregar = true;
            if(inicio == null)
            {
                inicio = producto;
            }
            else
            {
                Productos varTemporal = inicio;
                while(varTemporal.siguiente != null && sePuedeAgregar == true)
                {
                    varTemporal = varTemporal.siguiente;
                }
                if(varTemporal.codigo != producto.codigo && sePuedeAgregar)
                {
                    varTemporal = inicio;
                    if (producto.codigo < varTemporal.codigo)
                    {
                        producto.siguiente = varTemporal;
                        inicio = producto;
                    }
                    else
                    {
                        sePuedeAgregar = true;
                        while(varTemporal.siguiente != null)
                        {
                            if(producto.codigo < varTemporal.codigo)
                            {
                                producto.siguiente = varTemporal.siguiente;
                                varTemporal.siguiente = producto;
                                sePuedeAgregar = false;
                                break;
                            }
                        }
                        if(sePuedeAgregar)
                        {
                            varTemporal.siguiente = producto;
                        }
                    }
                }
            }
            return sePuedeAgregar;
        }
        public void agregar(Productos producto)
        {
            Productos guardar = inicio;

   
                if (inicio == null)
                {
                    inicio = producto;
                }
                else
                {
                    if (producto.codigo < inicio.codigo)
                    {
                        producto.siguiente = inicio;
                        inicio = producto;
                    }
                    else if (producto.codigo > inicio.codigo)
                    {
                        while (guardar.siguiente != null && producto.codigo > guardar.siguiente.codigo)   //este sirve para indicarnos cuando dos numeros estan
                        {                                                                             //enseguida uno con el otro, cuando se cumple se sale del
                            guardar = guardar.siguiente;                                             //while para entrar a lo de abajo donde se cambian las direcciones del siguiente de cada uno
                        }
                        producto.siguiente = guardar.siguiente;
                        guardar.siguiente = producto;
                    }
                }
            

        }
        public Productos buscarProducto(int codigo)
        {
            Productos varTemporal = inicio;
            while(varTemporal != null)
            {
                varTemporal = varTemporal.siguiente;
            }
            return varTemporal;
        }

        public string reporte()
        {
            string resultado = "";
            Productos varTemporal = inicio;
            while(varTemporal != null)
            {
                resultado += varTemporal.ToString();
                varTemporal = varTemporal.siguiente;
            }
            return resultado;
        }
        public void eliminarProducto(int codigo)
        {
            Productos varTemporal = inicio;
            bool sePuedeEliminar = true;
            if(varTemporal != null)
            {
                if(varTemporal.codigo == codigo)
                {
                    inicio = varTemporal.siguiente;
                    varTemporal = inicio;
                }
                else
                {
                    while(varTemporal.siguiente != null)
                    {
                        varTemporal = varTemporal.siguiente;
                    }
                }
            }
        }
        public void insertarProducto(int posicion, Productos producto)
        {
            int contador = 2;
            Productos varTemporal = inicio;
            if(posicion == 1)
            {
                producto.siguiente = varTemporal;
                inicio = producto;
            }
            else
            {
                while(varTemporal.siguiente != null && contador != posicion)
                {
                    contador++;
                    varTemporal = varTemporal.siguiente;
                }
                producto.siguiente = varTemporal.siguiente;
                varTemporal.siguiente = producto;
            }
        }
        public override string ToString()
        {
            string resultado = "";
            Productos varTemporal = inicio;
            while (varTemporal != null)
            {
                resultado += varTemporal.ToString();
                varTemporal = varTemporal.siguiente;
            }
            return resultado;
        }

    }
}
