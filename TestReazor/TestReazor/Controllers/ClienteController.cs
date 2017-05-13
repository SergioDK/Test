using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestReazor.Models;
using TestReazor.ViewModel;
using TestReazor.ExtensionClasses;

namespace TestReazor.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        GestorClientes gescliente = new GestorClientes();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Crear()
      {
            
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(ClienteViewModel clienteviewmodel)
        {

            if (ModelState.IsValid)
            {
                gescliente.Guardar(clienteviewmodel.convertirAModelo());
            }
            else
            {
                return View("Crear");
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            var cliente = gescliente.Listar();
            
            return View(cliente.ConvertirAViewModel());
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(string cliente)
        {
            var clientes = gescliente.Buscar(cliente);
            return View(clientes.ConvertirAViewModel());
        }
        
        public ActionResult EliminarPorId(int id)
        {
            gescliente.Eliminar(id);
            return RedirectToAction("Listar");
        }

        public ActionResult EliminarPorApyNom(string apellido, string nombre)
        {
            gescliente.Eliminar(apellido,nombre);
            return RedirectToAction("Listar");
        }

        public ActionResult Detalle(int id)
        {
            var cliente = gescliente.BuscarPorId(id);
            return View(cliente.ConvertirAViewModel());
        }

        [HttpPost]
        public ActionResult Modificar(Cliente cliente)
        {
            gescliente.Modificar(cliente);
            return RedirectToAction("Listar");
        }
    }
}