using ProjetoLAB4.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoLAB4.Data
{
    public class ProjetoLAB4Context : DbContext 
    {
        public DbSet<Administrador> Administrador { get; set; }

        public DbSet<Administrar_Utilizador> Administrar_Utilizador { get; set; }

        public DbSet<Comentario> Comentario { get; set; }

        public DbSet<Contacto> Contacto { get; set; }

        public DbSet<Garrafeira> Garrafeira { get; set; }

        public DbSet<Vinho_Garrafeira> Vinho_Garrafeira { get; set; }

        public DbSet<Morada> Morada { get; set; }

        public DbSet<Produtor> Produtor { get; set; }

        public DbSet<Recomendacao> Recomendacao { get; set; }

        public DbSet<Regiao> Regiao { get; set; }

        public DbSet<Tipo> Tipo { get; set; }

        public DbSet<Utilizador> Utilizador { get; set; }

        public DbSet<Vinho> Vinho { get; set; }


    }
}
