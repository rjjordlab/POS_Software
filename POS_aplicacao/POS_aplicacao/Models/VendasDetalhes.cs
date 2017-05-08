using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    public class VendasDetalhes
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Detalhe ID")]
        public int DetalheID { get; set; }

        [Display(Name = "Venda ID")]
        public int VendaID { set; get; } //FK

        [Display(Name = "Produto ID")]
        public int ProdutoID { set; get; } //FK

        [Display(Name = "Quantidade")]
        public int Quantidade { set; get; }

        [Display(Name = "Preço Unidade")] //preoo do produto correspondente
        public double Preco { set; get; }

        [Display(Name = "Total a pagar")] //total do preco * quantidade
        public int TotalAPagar { set; get; }
    }
}