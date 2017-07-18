using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminovos.Controllers
{
    public class AcompanhamentoLojaController : Controller
    {
        [Authorize]
        public ActionResult AcompanhamentoLoja()
        {
            return View();
        }
    }
}