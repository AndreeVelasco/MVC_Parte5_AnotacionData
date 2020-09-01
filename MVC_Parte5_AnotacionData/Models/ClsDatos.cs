using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Parte5_AnotacionData.Models
{
    public class ClsDatos
    {
        [Required(ErrorMessage ="El siguiente dato es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string Edad { get; set; }
    }
}