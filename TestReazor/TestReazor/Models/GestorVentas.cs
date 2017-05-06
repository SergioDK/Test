using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TestReazor.Models
{
    public class GestorVentas
    {
        public List<Models.Cliente> listaCliente()
        {
            var Cliente1 = new Models.Cliente { Apellido = "Paz", Nombre = "Sergio" };
            var Cliente2 = new Models.Cliente { Apellido = "Paz", Nombre = "Sergio" };
            var Cliente3 = new Models.Cliente { Apellido = "Paz", Nombre = "Sergio" };

            var listacliente = new List<Models.Cliente>();
            listacliente.Add(Cliente1);
            listacliente.Add(Cliente2);
            listacliente.Add(Cliente3);

            return listacliente;
        }

        public List<Models.Producto> listaProducto()
        {
            var Producto1 = new Models.Producto { Nombre = "Arroz" };
            var Producto2 = new Models.Producto { Nombre = "Lenteja" };

            var listaprodcuto = new List<Models.Producto>();
            listaprodcuto.Add(Producto1);
            listaprodcuto.Add(Producto2);

            return listaprodcuto;
        }
    }
}