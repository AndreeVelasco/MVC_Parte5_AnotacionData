using Microsoft.SqlServer.Server;
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
        public ActionResult DatosPersonales(DatosEmail obj)
        {
            if(ModelState.IsValid)
            {
                string email = obj.Email;
                string pass = obj.Password;
                if(email=="apandcan@gmail.com"&&pass=="123456")
                {
                    return View();
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }           
        }
        public ActionResult MostrarDatos(DatosPersonales obj)
        {
            if (ModelState.IsValid)
            {
                return View(obj);
            }
            else
            {
                return View("DatosPersonales");
            }
        }
    }
}