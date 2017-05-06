using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TestReazor.Models;
using TestReazor.ViewModel;

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

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Guardar(ProductoViewModel productoviewmodel)
        {
            var modeloproducto = new Producto();
            modeloproducto.Nombre = productoviewmodel.Nombre;
            modeloproducto.Cantidad = productoviewmodel.Cantidad;
            modeloproducto.Precio = (decimal)productoviewmodel.Precio;

            if (ModelState.IsValid)
            {
                gestProd.Guardar(modeloproducto);
            }
            else
            {
                return View("Crear");
            }
            return View("Index");
        }
    }
}