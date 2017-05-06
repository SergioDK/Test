using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestReazor.Models;

namespace TestReazor.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        GestorVentas gestVenta = new GestorVentas();
        public ActionResult Index()
        {
            var gestorventa = new GestorVentas();

            var listacliente = gestVenta.listaCliente();
            var listaprod = gestVenta.listaProducto();

            var venta = new ViewModel.Venta();

            //venta.ListaCliente = listacliente;
            //venta.ListaProducto = listaprod;

            return View("Venta", venta);
        }
    }

    
}