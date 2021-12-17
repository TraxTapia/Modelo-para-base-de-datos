using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Mediaccess.FilesProveedores
{
    public partial class DBContextMediaccess : DbContext
    {
        public DBContextMediaccess()
            : base("name=DBContextMediaccess")
        {
        }

        public virtual DbSet<CatArchivos> CatArchivos { get; set; }
        public virtual DbSet<filesProveedores> filesProveedores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatArchivos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CatArchivos>()
                .HasMany(e => e.filesProveedores)
                .WithRequired(e => e.CatArchivos)
                .HasForeignKey(e => e.IdCatFiles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<filesProveedores>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<filesProveedores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<filesProveedores>()
                .Property(e => e.Archivo)
                .IsUnicode(false);
        }
    }
}
