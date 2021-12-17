using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.prueba_libros
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .HasMany(e => e.Libro)
                .WithRequired(e => e.Autor)
                .HasForeignKey(e => e.IdAutor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.NombreLibro)
                .IsUnicode(false);
        }
    }
}
