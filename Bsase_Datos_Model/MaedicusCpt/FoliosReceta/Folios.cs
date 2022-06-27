using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.FoliosReceta
{
    public partial class Folios : DbContext
    {
        public Folios()
            : base("name=Folios")
        {
        }

        public virtual DbSet<FoliosReceta> FoliosReceta { get; set; }
        public virtual DbSet<FoliosRemesa> FoliosRemesa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Copago)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.CIE10)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.DescripcionProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.OrigenProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);
        }
    }
}
