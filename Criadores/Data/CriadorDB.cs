using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Criadores.Data
{
    /// <summary>
    /// representa a base de dados
    /// </summary>
    public class CriadorDB : DbContext
    {
        //construtor da classe DB, ver conteeudo de startup
        public CriadorDB(DbContextOptions<CriadorDB> options) : base(options) { }

        //representar as tabelas da bd
        public DbSet<Criadores> Criadores { get; set; }
        public DbSet<Caes> Caes { get; set; }
        public DbSet<Fotografias> Fotografias{ get; set; }
        public DbSet<Racas> Racas { get; set; }
        public DbSet<Cri_Cae> Cri_Caes { get; set; }
        

    }
}
