using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TestReazor.ViewModel
{
    public class ClienteViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Apellido es obligatorio")]
        [DisplayName("Apellido Cliente")]
        public string Apellido { get; set; }

        [Required]
        [StringLength(maximumLength: 10, ErrorMessage = "No puede contener mas de 10 caracteres", MinimumLength = 3)]
        public string Nombre { get; set; }

        [Required]
        [ValidarEdad]
        public int Edad { get; set; }
    }
}