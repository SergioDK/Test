using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestReazor.Models;
using TestReazor.ViewModel;

namespace TestReazor.ExtensionClasses
{
    public static class Extensions
    {
        public static Cliente convertirAModelo(this ClienteViewModel clienteviewmodel)
        {
            var modelocliente = new Cliente
            {
                Apellido = clienteviewmodel.Apellido,
                Nombre = clienteviewmodel.Nombre,
                Edad = clienteviewmodel.Edad
            };

            return modelocliente;
        }

        public static List<ClienteViewModel> ConvertirAViewModel(this List<Cliente> clientes)
        {
            var listaDeViewModel = new List<ClienteViewModel>();

            foreach (var clienteDeModel in clientes)
            {
                var clienteViewModel = new ClienteViewModel
                {
                    Id = clienteDeModel.Id,
                    Apellido = clienteDeModel.Apellido,
                    Nombre = clienteDeModel.Nombre
                };

                listaDeViewModel.Add(clienteViewModel);
            }

            return listaDeViewModel;
        }

        public static ClienteViewModel ConvertirAViewModel(this Cliente clienteModelo)
        {
            var clienteViewModel = new ClienteViewModel
            {
                Apellido = clienteModelo.Apellido,
                Nombre = clienteModelo.Nombre,
                Edad = clienteModelo.Edad,
                Id = clienteModelo.Id
            };

            return clienteViewModel;
        }
    }
}