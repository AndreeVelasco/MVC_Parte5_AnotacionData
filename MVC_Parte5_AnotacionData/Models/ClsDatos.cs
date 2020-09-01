using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Parte5_AnotacionData.Models
{
    public class DatosPersonales
    {
        [Required(ErrorMessage ="El siguiente dato es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string Edad { get; set; }
    }
    public class DatosEmail
    {
        [Required(ErrorMessage = "El Email es requerido")]
        [Display(Name ="Correo Electronico")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El Password es requerido")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}