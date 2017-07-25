using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seminovos.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="O campo usuário é obrigatório!")]
        [Display(Name="Usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "O campo senha é obrigatório!")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Lembrar me")]
        public bool LembrarMe { get; set; }
    }
}