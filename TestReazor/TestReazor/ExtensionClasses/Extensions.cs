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

        public static Producto convertirAModelo(this ProductoViewModel productoviewmodel)
        {
            var modeloproducto = new Producto
            {
                Nombre = productoviewmodel.Nombre,
                Precio = productoviewmodel.Precio,
                Cantidad = productoviewmodel.Cantidad
            };

            return modeloproducto;
        }

        public static List<ProductoViewModel> ConvertirAViewModel(this List<Producto> productos)
        {
            var listaDeViewModel = new List<ProductoViewModel>();

            foreach (var productoDeModel in productos)
            {
                var productoViewModel = new ProductoViewModel
                {
                    Id = productoDeModel.Id,
                    Nombre = productoDeModel.Nombre,
                    Precio = productoDeModel.Precio,
                    Cantidad = productoDeModel.Cantidad
                };

                listaDeViewModel.Add(productoViewModel);
            }

            return listaDeViewModel;
        }

        public static ProductoViewModel ConvertirAViewModel(this Producto productoModelo)
        {
            var productoViewModel = new ProductoViewModel
            {
                Nombre = productoModelo.Nombre,
                Precio = productoModelo.Precio,
                Cantidad = productoModelo.Cantidad,
                Id = productoModelo.Id
            };

            return productoViewModel;
        }
    }
}