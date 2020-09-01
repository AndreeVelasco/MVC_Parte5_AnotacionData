using MVC_Parte5_AnotacionData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Parte5_AnotacionData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DatosPersonales(ClsDatos obj)
        {
            if(ModelState.IsValid)
            {
                return View(obj);
            }
            else
            {
                return View("Index");
            }           
        }
    }
}