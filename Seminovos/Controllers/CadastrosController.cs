using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminovos.Controllers
{
    public class CadastrosController : Controller
    {
        [Authorize]
        public ActionResult CadastroCliente()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroLoja()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroProduto()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroFornecedor()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroFormaPagamento()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroPerfilUsuario()
        {
            return View();
        }
        [Authorize]
        public ActionResult CadastroUsuario()
        {
            return View();
        }
    }
}