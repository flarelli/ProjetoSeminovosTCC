using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminovos.Controllers
{
    public class OperacaoController : Controller
    {
        [Authorize]
        public ActionResult Especulacoes()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastrarContrato()
        {
            return View();
        }
    }
}