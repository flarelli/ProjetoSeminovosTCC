using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Seminovos.Models
{
    public class CadastroModelo
    {
        public int Codigo { get; set; }
        public string DescricaoModelo { get; set; }
        public int AnoModelo { get; set; }
        public int AnoFabricacao { get; set; }
        public string CorModelo { get; set; }
        public bool SituacaoModelo { get; set; }
    }
}