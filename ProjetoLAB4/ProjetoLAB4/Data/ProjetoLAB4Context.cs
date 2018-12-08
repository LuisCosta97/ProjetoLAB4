using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoLAB4.Models;
using Microsoft.EntityFrameworkCore.Metadata;


namespace ProjetoLAB4.Models
{
    public class ProjetoLAB4Context : DbContext
    {
        public ProjetoLAB4Context (DbContextOptions<ProjetoLAB4Context> options)
            : base(options)
        {
        }

        public DbSet<ProjetoLAB4.Models.Utilizador> Utilizador { get; set; }

        public DbSet<ProjetoLAB4.Models.Morada> Morada { get; set; }

        public DbSet<ProjetoLAB4.Models.Administrador> Administrador { get; set; }

        public DbSet<ProjetoLAB4.Models.Administrar_Utilizador> Administrar_Utilizador { get; set; }

        public DbSet<ProjetoLAB4.Models.Vinho> Vinho { get; set; }

        public DbSet<ProjetoLAB4.Models.Produtor> Produtor { get; set; }

        public DbSet<ProjetoLAB4.Models.Regiao> Regiao { get; set; }

        public DbSet<ProjetoLAB4.Models.Tipo> Tipo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.Property(e => e.ID_Cliente).IsRequired();
                entity.Property(e => e.ID_Vinho).IsRequired();
                entity.Property(e => e.data_comentario).IsRequired();
                entity.HasOne(d => d.Vinho)
                    .WithMany(p => p.Comentario)
                    .HasForeignKey(d => d.ID_Vinho);
                entity.HasOne(d => d.Vinho)
                    .WithMany(p => p.Comentario)
                    .HasForeignKey(d => d.ID_Cliente);

            });



        }
    }
}
