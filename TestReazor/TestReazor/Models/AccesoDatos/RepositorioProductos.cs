using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using 

namespace TestReazor.Models.AccesoDatos
{
    public class RepositorioProductos
    {
        TallerDB tallerDb = new TallerDB();
        public List<Producto> Listar()
        {
            return tallerDb.Producto.ToList();
        }

        public void Guardar(Producto producto)
        {
            tallerDb.Producto.Add(producto);
            tallerDb.SaveChanges();
        }

        public List<Producto> Buscar(string producto)
        {
            return tallerDb.Producto.Where(x => x.Nombre.Contains(producto)).ToList();
        }

        public void Eliminar(int id)
        {
            var productodelete = BuscarPorId(id);
            tallerDb.Producto.Remove(productodelete);
            tallerDb.SaveChanges();
        }

        public Producto BuscarPorId(int id)
        {
            return tallerDb.Producto.First(x => x.Id == id);
        }

        public void Modificar(Producto producto)
        {
            var productoParaModificar = BuscarPorId(producto.Id);
            productoParaModificar.Nombre = producto.Nombre;
            productoParaModificar.Precio = producto.Precio;
            productoParaModificar.Cantidad = producto.Cantidad;
            tallerDb.SaveChanges();
        }
    }
}