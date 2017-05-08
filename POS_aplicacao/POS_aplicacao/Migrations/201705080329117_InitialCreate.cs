namespace POS_aplicacao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NIF = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Morada = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Empregados",
                c => new
                    {
                        EmpregadoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        NIF = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Morada = c.String(),
                    })
                .PrimaryKey(t => t.EmpregadoID);
            
            CreateTable(
                "dbo.Fornecedores",
                c => new
                    {
                        FornecedorID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        EIN = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Morada = c.String(),
                    })
                .PrimaryKey(t => t.FornecedorID);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Categoria = c.String(),
                        Descrisao = c.String(),
                        Preco = c.String(),
                        FornecedorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        VendaID = c.Int(nullable: false, identity: true),
                        EmpregadoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                        ProdutoID = c.Int(nullable: false),
                        Quantidade = c.String(),
                        DataVenda = c.String(),
                    })
                .PrimaryKey(t => t.VendaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Vendas");
            DropTable("dbo.Produtos");
            DropTable("dbo.Fornecedores");
            DropTable("dbo.Empregados");
            DropTable("dbo.Clientes");
        }
    }
}
