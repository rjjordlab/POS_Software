using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    // vai representar os dados da tabela dos PRODUTOS

    // criar o construtor desta classe
    public class Produtos
    {
        [Key]//indica que o atributo e uma PK
        [Display(Name = "Produto ID")]
        public int ProdutoID { get; set; }

        [Display(Name = "Nome do Dono")]
        public string Nome { set; get; }

        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Display(Name = "Descrisão")]
        public string Descrisao { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Preço")]
        public double Preco { get; set; }

        [Display(Name = "Fornecedor ID")]
        public int FornecedorID { get; set; }
    }
}