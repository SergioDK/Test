using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestReazor.ViewModel
{
    public class ProductoViewModel
    {
        [Required(ErrorMessage = "Campo Obligatorio")]
        [DisplayName("Nombre del Producto:")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [DisplayName("Cantidad:")]
        [Range(0, 50, ErrorMessage = "La cantidad no puede ser menor que 1 ni mayor a 50")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "Campo Obligatorio")]
        [Range(0.1, 100.00, ErrorMessage = "El precio no pude ser menor que 0.1 ni mayor que 100.00")]
        [DisplayName("Precio:")]
        public double Precio { get; set; }
    }
}