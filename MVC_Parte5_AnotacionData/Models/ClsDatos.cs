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
        [Phone]
        [Display(Name ="Numero telefonico")]
        [Required(ErrorMessage ="El siguiente dato es requerido")]
        public string Number { get; set; }
    }
    public class DatosEmail 
    {
        [EmailAddress]
        [Required(ErrorMessage = "El Email es requerido")]
        [Display(Name ="Correo Electronico")]
        public string Email { get; set; }
        [StringLength(100, ErrorMessage ="El numero de caracteres de {0} debe ser al menos {2}.", MinimumLength = 6)]
        [Required(ErrorMessage = "El Password es requerido")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        [Display(Name ="Confirmar contraseña")]
        [Compare("Password",ErrorMessage ="La contraseña y la confirmacion de contraseña no coinciden.")]
        public string ConfirmPassword { get; set; }
    }
}