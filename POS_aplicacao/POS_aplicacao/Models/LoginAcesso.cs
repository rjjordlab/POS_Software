using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    public class LoginAcesso
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Acesso ID")]
        public int AcessoID { get; set; }

        [Display(Name = "Empregado ID")]
        public int EmpregadoID { get; set; } //FK

        [Display(Name = "Senha")]
        public string Senha { set; get; }
    }
}