namespace POS_aplicacao.Migrations
{
    using POS_aplicacao.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<POS_aplicacao.Models.PosAppDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(POS_aplicacao.Models.PosAppDB context)
        {
            //#############################################################
            // criação das classes Clientes, Empregados, Fornecedores, Produtos e Vendas
            //#############################################################


            // Configuration --- SEED
            //=============================================================

            // ############################################################################################
            // adiciona Clientes
            var Clientes = new List<Clientes> {
               new Clientes  {ClienteID=1,  Nome = "Luís Freitas",     NIF = "813635582", Telefone = "916932253", Email = "marin.petkov2@hotmail.com",   Morada = "Rua do Arsenal" },
               new Clientes  {ClienteID=2,  Nome = "Andreia Gomes",    NIF = "854613462", Telefone = "914881298", Email = "Kenny.dang303@gmail.com",     Morada = "Rua Nova do Almada" },
               new Clientes  {ClienteID=3,  Nome = "Cristina Sousa",   NIF = "265368715", Telefone = "916913918", Email = "symsy92@yahoo.com",           Morada = "Rua Júlio César Machado" },
               new Clientes  {ClienteID=4,  Nome = "Sónia Rosa",       NIF = "835623190", Telefone = "916429893", Email = "mmaegly@cinci.rr.com",        Morada = "Rua Roberto Duarte Silva" },
               new Clientes  {ClienteID=5,  Nome = "António Santos",   NIF = "751512205", Telefone = "917214221", Email = "brad@spon.com",               Morada = "Rua da Madalena" },
               new Clientes  {ClienteID=6,  Nome = "Gustavo Alves",    NIF = "728663835", Telefone = "915872036", Email = "primobella@yahoo.com",        Morada = "Rua Ferreira Lapa" },
               new Clientes  {ClienteID=7,  Nome = "Rosa Vieira",      NIF = "644388118", Telefone = "913446986", Email = "hicham_h17@hotmail.com",      Morada = "Rua do Instituto Bacteriológico" },
               new Clientes  {ClienteID=8,  Nome = "Daniel Dias",      NIF = "262618487", Telefone = "913952717", Email = "craig.alstatt@exide.com",     Morada = "Rua Vicente Borga" },
               new Clientes  {ClienteID=9,  Nome = "Tânia Gomes",      NIF = "842615197", Telefone = "915841192", Email = "crazy_darius13@yahoo.com",    Morada = "Rua dos Bacalhoeiros" },
               new Clientes  {ClienteID=10, Nome = "Andreia Correia",  NIF = "635139506", Telefone = "913062100", Email = "mulenga_o@yahoo.com",         Morada = "Rua Garrett" },
               new Clientes  {ClienteID=11, Nome = "Márcio Alves",     NIF = "715428372", Telefone = "913298526", Email = "freetechdude@hotmail.com",    Morada = "Rua Heróis de Quionga" },
               new Clientes  {ClienteID=12, Nome = "Inês Martins",     NIF = "348385836", Telefone = "912927211", Email = "tennisproet@hotmail.com",     Morada = "Rua do Salitre" },
               new Clientes  {ClienteID=13, Nome = "Teresinha Vieira", NIF = "365555205", Telefone = "912977890", Email = "thelegacyofhodge@gmail.com",  Morada = "Rua da Madalena" },
               new Clientes  {ClienteID=14, Nome = "Marco Soares",     NIF = "540161898", Telefone = "913228808", Email = "ryanelectriclomas@gmail.com", Morada = "Rua do Salitre" },
               new Clientes  {ClienteID=15, Nome = "Lourdes Vieira",   NIF = "528411261", Telefone = "916000970", Email = " bklynbrandon@gmail.com",     Morada = "Rua dos Fanqueiros" },
               new Clientes  {ClienteID=16, Nome = "Júlio Morais",     NIF = "266563928", Telefone = "914198687", Email = "andrey_unikool@yahoo.com",    Morada = "Rua do Comércio" }
            };

            Clientes.ForEach(cc => context.Clientes.AddOrUpdate(c => c.Nome,cc));
            context.SaveChanges();
            // ############################################################################################
            // adiciona Empregados
            var Empregados = new List<Empregados> {
               new Empregados  {EmpregadoID=1, Nome = "Administrador",   NIF ="999999999", Telefone = "917254187", Email = "gestorsoftware@gmail.com", Morada = "Indisponivel" },
               new Empregados  {EmpregadoID=2, Nome = "Augusto Rosa",    NIF ="485162005", Telefone = "919367708", Email = "stefanleo@gmail.com",      Morada = "Rua do Breiner" },
               new Empregados  {EmpregadoID=3, Nome = "Cristina Melo",   NIF ="416933279", Telefone = "910721924", Email = "sydney7a@gmail.com",       Morada = "Rua de Santa Catarina" },
               new Empregados  {EmpregadoID=4, Nome = "Denise Silva",    NIF ="843547587", Telefone = "911298074", Email = "russel9j@aol.com",         Morada = "Rua Escura" },
               new Empregados  {EmpregadoID=5, Nome = "Carmem Oliveira", NIF ="717250604", Telefone = "913349749", Email = "santosn35@aol.com",        Morada = "Rua do Comércio" }
            };

            Empregados.ForEach(ee => context.Empregados.AddOrUpdate(e => e.Nome,ee));
            context.SaveChanges();
            // ############################################################################################
            // adiciona Fornecedores
            var Fornecedores = new List<Fornecedores> {
               new Fornecedores  {FornecedorID=1, Nome = "PTRobotics",             EIN ="45-1536581", Telefone = "910400147", Email = "ptr@gmail.com",                Morada = "Rua Brigadeiro Lino Dias Valente" },
               new Fornecedores  {FornecedorID=2, Nome = "Mouser Electronics",     EIN ="61-1520598", Telefone = "915511027", Email = "meinc@hotmail.com",            Morada = "Rua do Moderno" },
               new Fornecedores  {FornecedorID=3, Nome = "castro ELETRONICA",      EIN ="26-2368715", Telefone = "915765786", Email = "castelet@iol.pt",              Morada = "Rua do Graínho" },
               new Fornecedores  {FornecedorID=4, Nome = "Lenave",                 EIN ="83-5623190", Telefone = "910962271", Email = "complenave@hotmail.com",       Morada = "Rua Garrett" },
               new Fornecedores  {FornecedorID=5, Nome = "AliExpress",             EIN ="34-5454115", Telefone = "918418987", Email = "aliexpressofficial@gmail.com", Morada = "Rua do Comércio" },
               new Fornecedores  {FornecedorID=6, Nome = "ELETRONICA EMBAJADORES", EIN ="88-1548541", Telefone = "910492386", Email = "eletroembajadores@clix.pt",    Morada = "Rua de Santa Catarina" }
            };

            Fornecedores.ForEach(ff => context.Fornecedores.AddOrUpdate(f => f.Nome,ff));
            context.SaveChanges();
            // ############################################################################################
            // adiciona Produtos
            var Produtos = new List<Produtos> {
               new Produtos  {ProdutoID=1,  Nome = "74LS47",            Categoria ="74XX LOGIC ICS", Descrisao ="BCD To 7 Segment Decoder",                                   Preco ="1.20", FornecedorID =1},
               new Produtos  {ProdutoID=2,  Nome = "DM7407N",           Categoria ="74XX LOGIC ICS", Descrisao ="7407 HEX BUFFERS WITH HIGH VOLTAGE OPEN-COLLECTOR OUTPUTS",  Preco ="2.10", FornecedorID =3},
               new Produtos  {ProdutoID=3,  Nome = "74AC139PC",         Categoria ="74XX LOGIC ICS", Descrisao ="74AC139 DUAL 1-OF-4 DECODER/DEMULTIPLEXER",                  Preco ="1.49", FornecedorID =5},
               new Produtos  {ProdutoID=4,  Nome = "SN74AC14N",         Categoria ="74XX LOGIC ICS", Descrisao ="74AC14 HEX SCHMITT-TRIGGER INVERTER",                        Preco ="1.25", FornecedorID =4},
               new Produtos  {ProdutoID=5,  Nome = "74F04PC",           Categoria ="74XX LOGIC ICS", Descrisao ="HEX INVERTER, in 14-pin DIP package",                        Preco ="2.95", FornecedorID =6},
               new Produtos  {ProdutoID=6,  Nome = "TC74HC595AP",       Categoria ="74XX LOGIC ICS", Descrisao ="74HC595 8-BIT SHIFT REGISTER LATCH, in 16-pin Dip package",  Preco ="5.05", FornecedorID =1},
               new Produtos  {ProdutoID=7,  Nome = "SN74LS244N",        Categoria ="74XX LOGIC ICS", Descrisao ="74LS244 OCTAL BUFFER W/ TRI-STATE OUTPUTS",                  Preco ="3.20", FornecedorID =1},
               new Produtos  {ProdutoID=8,  Nome = "SN74AC240N",        Categoria ="74XX LOGIC ICS", Descrisao ="74AC240 OCTAL BUFFER W/ TRI-STATE OUTPUTS",                  Preco ="4.50", FornecedorID =2},
               new Produtos  {ProdutoID=9,  Nome = "TC74HC4053AP(F)",   Categoria ="74XX LOGIC ICS", Descrisao ="MUX/DEMUX TRIPLE 2X1",                                       Preco ="2.36", FornecedorID =6},
               new Produtos  {ProdutoID=10, Nome = "MM74HCT240N",       Categoria ="74XX LOGIC ICS", Descrisao ="74HCT240 OCTAL INVERTER W/ TRI-STATE OUTPUTS",               Preco ="1.15", FornecedorID =5},
               new Produtos  {ProdutoID=11, Nome = "MM74HC165N",        Categoria ="74XX LOGIC ICS", Descrisao ="74HC165 PARALLEL-IN/SERIAL-OUT 8-BIT SHIFT REGISTER",        Preco ="3.10", FornecedorID =4}
            };

            Produtos.ForEach(pp => context.Produtos.AddOrUpdate(p => p.Nome,pp));
            context.SaveChanges();
            // ############################################################################################
            // adiciona Vendas
            var Vendas = new List<Vendas> {
               new Vendas  {VendaID=1, EmpregadoID = 1, ClienteID = 1, ProdutoID = 2, Quantidade = 5, DataVenda ="15-02-2017" }
            };

            Vendas.ForEach(vv => context.Vendas.AddOrUpdate(v => v.DataVenda,vv));
            context.SaveChanges();
        }
    }
}
