using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestReazor.Common;

namespace TestReazor.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        TallerDB tallerDb = new TallerDB();

        public RepositorioClientes()
        {
            tallerDb.Database.Log = Logger.Log;
        }

        public void Guardar(Cliente cliente)
        {
            tallerDb.Cliente.Add(cliente);
            tallerDb.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return tallerDb.Cliente.ToList();
        }

        public void Eliminar(int id)
        {
            var cliente = tallerDb.Cliente.First(x => x.Id == id);
            tallerDb.Cliente.Remove(cliente);
            tallerDb.SaveChanges();
        }

        public void Eliminar(string apellido, string nombre)
        {
            var cliente = tallerDb.Cliente.Where(x => x.Apellido == apellido && x.Nombre == nombre).First();
            tallerDb.Cliente.Remove(cliente);
            tallerDb.SaveChanges();
        }

        public void Modificar(Cliente cliente)
        {
            var clienteParaModificar = tallerDb.Cliente.First(x => x.Id == cliente.Id);

            clienteParaModificar.Apellido = cliente.Apellido;
            clienteParaModificar.Nombre = cliente.Nombre;
            clienteParaModificar.Edad = cliente.Edad;
            tallerDb.SaveChanges();
        }

        public Cliente BuscarPorId(int id)
        {
            return tallerDb.Cliente.First(x => x.Id == id);
        }

        public List<Cliente> Buscar(string cliente)
        {
            return tallerDb.Cliente.Where(x => x.Apellido.Contains(cliente) || x.Nombre.Contains(cliente)).ToList();
        }

        public int ObtenerId(Cliente cliente)
        {
            //var id = tallerDb.Cliente.Select(x=> x.Id);
            //tallerDb.Cliente.Select(z => z.Id);
            var id = tallerDb.Cliente.FirstOrDefault(x => x.Apellido == cliente.Apellido).Id;

            return Convert.ToInt32(id);
        }
    }
}