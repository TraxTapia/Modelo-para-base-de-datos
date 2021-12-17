using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.ejemplollave
{
    public partial class ejemplo : DbContext
    {
        public ejemplo()
            : base("name=ejemplo")
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.NombreLibro)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .HasMany(e => e.Autor)
                .WithRequired(e => e.Libro)
                .HasForeignKey(e => e.IdLibro)
                .WillCascadeOnDelete(false);
        }
    }
}
