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
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-68G5EQJ;Database=BD_SGE;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vagas>()
            .HasOne<Setor>(s => s.Setor)
            .WithMany(g => g.Vagas)
            .HasForeignKey(s => s.setId);

            modelBuilder.Entity<Ocupacao>()
            .HasOne<Setor>(s => s.Setor)
            .WithMany(g => g.Ocupacoes)
            .HasForeignKey(s => s.setId);

            modelBuilder.Entity<Desocupacao>()
            .HasOne<Setor>(s => s.Setor)
            .WithMany(g => g.Desocupacoes)
            .HasForeignKey(s => s.setId);

            modelBuilder.Entity<Ocupacao>()
           .HasOne<Vagas>(v => v.Vaga)
           .WithMany(g => g.Ocupacoes)
           .HasForeignKey(v => v.vagId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Desocupacao>()
           .HasOne<Vagas>(v => v.Vaga)
           .WithMany(g => g.Desocupacoes)
           .HasForeignKey(v => v.vagId)
           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ocupacao>()
          .HasOne<Veiculo>(v => v.Veiculo)
          .WithMany(g => g.Ocupacoes)
          .HasForeignKey(v => v.veiId)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Desocupacao>()
         .HasOne<Veiculo>(v => v.Veiculo)
         .WithMany(g => g.Desocupacoes)
         .HasForeignKey(v => v.veiId)
         .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
