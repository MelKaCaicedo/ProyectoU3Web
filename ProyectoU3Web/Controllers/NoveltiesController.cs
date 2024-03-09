using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoU3Web.Controllers
{
    public class NoveltiesController : Controller
    {
        // GET: Novelties
        public ActionResult Index()
        {
            return View();
        }
    }
}