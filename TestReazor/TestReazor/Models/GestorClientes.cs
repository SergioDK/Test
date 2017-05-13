using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestReazor.Models.AccesoDatos;

namespace TestReazor.Models
{
    public class GestorClientes
    {
        RepositorioClientes repoCliente = new RepositorioClientes();
        public void Guardar(Cliente cliente)
        {
            repoCliente.Guardar(cliente);
        }

        public List<Cliente> Listar()
        {
            return repoCliente.Listar();
        }

        public List<Cliente> Buscar(string cliente)
        {
            return repoCliente.Buscar(cliente);
        }

        public void Eliminar(int id)
        {
            repoCliente.Eliminar(id);
        }

        public void Eliminar(string apellido, string nombre)
        {
            repoCliente.Eliminar(apellido, nombre);
        }

        public Cliente BuscarPorId(int id)
        {
            return repoCliente.BuscarPorId(id);
        }

        public void Modificar(Cliente cliente)
        {
            repoCliente.Modificar(cliente);
        }
    }
}