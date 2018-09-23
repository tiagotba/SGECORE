using Microsoft.EntityFrameworkCore;
using SGECOREDOMINIO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGECOREDAO.CONTEXTOS
{
    public class SGECORECONTEXT : DbContext
    {
        public SGECORECONTEXT()
        { }

        public SGECORECONTEXT(DbContextOptions<SGECORECONTEXT> opcoes)
            : base(opcoes)
        {

        }

        public DbSet<Vagas> Vagas { get; set; }

        public DbSet<Setor> Setores { get; set; }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Ocupacao> Ocupacoes { get; set; }

        public DbSet<Desocupacao> Desocupacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\DESKTOP-68G5EQJ;Database=BD_SGE;Trusted_Connection=True;");
            }
        }
    }
}
