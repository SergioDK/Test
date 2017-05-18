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
    public class ProductoController : Controller
    {
        // GET: 
        GestorProductos gestProd = new GestorProductos();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            var producto = gestProd.Listar();

            return View(producto.ConvertirAViewModel());
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(ProductoViewModel productoviewmodel)
        {

            if (ModelState.IsValid)
            {
                gestProd.Guardar(productoviewmodel.convertirAModelo());
            }
            else
            {
                return View("Crear");
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Buscar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(string producto)
        {
            var productos = gestProd.Buscar(producto);
            return View(productos.ConvertirAViewModel());
        }

        public ActionResult EliminarPorId(int id)
        {
            gestProd.Eliminar(id);
            return RedirectToAction("Listar");
        }

        public ActionResult Detalle(int id)
        {
            var productos = gestProd.BuscarPorId(id);
            return View(productos.ConvertirAViewModel());
        }

        public ActionResult Modificar(Producto producto)
        {
            gestProd.Modificar(producto);
            return RedirectToAction("Listar");
        }
    }
}