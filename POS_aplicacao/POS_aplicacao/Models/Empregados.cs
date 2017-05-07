using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    // vai representar os dados da tabela dos EMPREGADOS

    // criar o construtor desta classe
    public class Empregados
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Empregado ID")]
        public int EmpregadoID { get; set; }

        [Display(Name = "Nome")]
        public string Nome { set; get; }

        [Display(Name = "N. Contribuinte")]
        public string NIF { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Morada")]
        public string Morada { get; set; }
    }
}