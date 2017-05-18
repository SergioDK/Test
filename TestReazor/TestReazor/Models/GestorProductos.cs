using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TestReazor.Models;
using TestReazor.Models.AccesoDatos;

namespace TestReazor.Models
{
    public class GestorProductos
    {
        RepositorioProductos repoProd = new RepositorioProductos();
        public void Guardar(Producto producto)
        {
            repoProd.Guardar(producto);
        }

        public List<Producto> Listar()
        {
            return repoProd.Listar();
        }

        public List<Producto> Buscar(string producto)
        {
            return repoProd.Buscar(producto);
        }

        public void Eliminar(int id)
        {
            repoProd.Eliminar(id);
        }

        public Producto BuscarPorId(int id)
        {
            return repoProd.BuscarPorId(id);
        }

        public void Modificar(Producto producto)
        {
            repoProd.Modificar(producto);
        }
    }
}