using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    // vai representar os dados da tabela das VENDAS

    // criar o construtor desta classe
    public class Vendas
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Venda ID")]
        public int VendaID { get; set; }

        [Display(Name = "Empregado ID")]
        public int EmpregadoID { get; set; }

        [Display(Name = "Cliente ID")]
        public int ClienteID { get; set; }

        [Display(Name = "Produto ID")]
        public int ProdutoID { get; set; }

        [Display(Name = "Quantidade")]
        public string Quantidade { set; get; }

        [Display(Name = "Data de Venda")]
        public string DataVenda { get; set; }
    }
}