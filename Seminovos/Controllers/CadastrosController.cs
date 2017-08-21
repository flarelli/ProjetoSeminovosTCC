using Seminovos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Seminovos.Controllers
{
    public class CadastrosController : Controller
    {
        private static List<CadastroProduto> _listaCadastroProduto = new List<CadastroProduto>()
        {
            new CadastroProduto() { Placa="PMO7585", Modelo="FOX 1.0 2016", SituacaoCarro=1},
            new CadastroProduto() { Placa="PMO9999", Modelo="UNO VIVACE 1.0 2015", SituacaoCarro=2},
            new CadastroProduto() { Placa="PXX1399", Modelo="UNO VIVACE 1.0 2015", SituacaoCarro=3},
        };

        private static List<CadastroModelo> _listaCadastroModelo = new List<CadastroModelo>()
        {
            new CadastroModelo() { Codigo=1, DescricaoModelo="UNO VIVACE", AnoModelo=2012, AnoFabricacao=2012, CorModelo="Azul Anil", SituacaoModelo = true},
            new CadastroModelo() { Codigo=2, DescricaoModelo="SANDERO EXPRESS", AnoModelo=2010, AnoFabricacao=2012, CorModelo="Verde Fosco", SituacaoModelo = false},
            new CadastroModelo() { Codigo=3, DescricaoModelo="CROSFOX", AnoModelo=2016, AnoFabricacao=2017, CorModelo="Vermelho", SituacaoModelo = true},
        };

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
            return View(_listaCadastroProduto);
        }
        [Authorize]
        public ActionResult CadastroModelo()
        {
            return View(_listaCadastroModelo);
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