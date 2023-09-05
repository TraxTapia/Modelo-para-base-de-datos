using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCPTTabuladores
{
    public partial class maedicusCPT : DbContext
    {
        public maedicusCPT()
            : base("name=maedicusCPT")
        {
        }

        public virtual DbSet<FilePreciosRechazos> FilePreciosRechazos { get; set; }
        public virtual DbSet<FilesByListaRechazos> FilesByListaRechazos { get; set; }
        public virtual DbSet<TabuladorProveedorPreciosRechazos> TabuladorProveedorPreciosRechazos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilePreciosRechazos>()
                .Property(e => e.FileName)
                .IsUnicode(false);

            modelBuilder.Entity<FilePreciosRechazos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FilePreciosRechazos>()
                .HasMany(e => e.FilesByListaRechazos)
                .WithRequired(e => e.FilePreciosRechazos)
                .HasForeignKey(e => e.IdFileRechazo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FilePreciosRechazos>()
                .HasMany(e => e.TabuladorProveedorPreciosRechazos)
                .WithRequired(e => e.FilePreciosRechazos)
                .HasForeignKey(e => e.IdFileRechazo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FilesByListaRechazos>()
                .Property(e => e.FileJustificacion)
                .IsUnicode(false);

            modelBuilder.Entity<FilesByListaRechazos>()
                .Property(e => e.Justificacion)
                .IsUnicode(false);

            modelBuilder.Entity<FilesByListaRechazos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPreciosRechazos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPreciosRechazos>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPreciosRechazos>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
