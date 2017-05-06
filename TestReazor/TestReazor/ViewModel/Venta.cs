using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestReazor.Models;

namespace TestReazor.ViewModel
{
    public class Venta
    {
        public List<Cliente> ListaCliente{ get; set; }

        public List<Producto> ListaProducto { get; set; }
    }
}