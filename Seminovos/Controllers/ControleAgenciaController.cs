using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminovos.Controllers
{
    public class ControleAgenciaController : Controller
    {
        [Authorize]
        public ActionResult ControleAgencia()
        {
            return View();
        }
    }
}