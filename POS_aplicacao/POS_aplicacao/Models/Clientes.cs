using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    // vai representar os dados da tabela dos CLIENTES

    // criar o construtor desta classe
    public class Clientes
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Cliente ID")]
        public int ClienteID { get; set; }

        [Display(Name = "Nome do Dono")]
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