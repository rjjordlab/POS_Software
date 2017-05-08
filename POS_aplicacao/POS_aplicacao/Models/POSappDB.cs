using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace POS_aplicacao.Models
{
    public class PosAppDB : DbContext
    {
        //representar a database
        //descrevendo as tabelas que la estao contidas

        //representar um construtor desta classe
        //identifica onde se encontra a database

        public PosAppDB() : base("POSappDBConnection") { }
        //descrever as tabelas que estao na database
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Vendas> Vendas { get; set; }
        public virtual DbSet<VendasDetalhes> VendasDetalhes { get; set; }
        public virtual DbSet<Empregados> Empregados { get; set; }
        public virtual DbSet<Produtos> Produtos { get; set; }
        public virtual DbSet<Fornecedores> Fornecedores { get; set; }
        public virtual DbSet<LoginAcesso> LoginAcesso { get; set; }
    }
}