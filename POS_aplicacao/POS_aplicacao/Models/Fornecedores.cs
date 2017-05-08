using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    // vai representar os dados da tabela dos Fornecedores

    // criar o construtor desta classe
    public class Fornecedores
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Fornecedor ID")]
        public int FornecedorID { get; set; }

        [Display(Name = "Nome")]
        public string Nome { set; get; }

        [Display(Name = "N. Identificação fiscal")]
        public string EIN { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Morada")]
        public string Morada { get; set; }
    }
}