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
     //   public virtual DbSet<Donos> Donos { get; set; }
      //  public virtual DbSet<Animais> Animais { get; set; }
      //  public virtual DbSet<Veterinarios> Veterinarios { get; set; }
       // public virtual DbSet<Consultas> Consultas { get; set; }
    }
}