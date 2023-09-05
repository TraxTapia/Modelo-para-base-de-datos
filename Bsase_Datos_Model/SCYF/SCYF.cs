using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.SCYF
{
    public partial class SCYF : DbContext
    {
        public SCYF()
            : base("name=SCYF3")
        {
        }

        public virtual DbSet<DetalleSCYF> DetalleSCYF { get; set; }
        public virtual DbSet<FileScyfFtp> FileScyfFtp { get; set; }
        public virtual DbSet<LogFileSCYF> LogFileSCYF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NomProducto)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NroNomina)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.CodPostal)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.EstadoCivil)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.ApPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.ApMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Nacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.TelCasa)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FNacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FInicioServicio)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FFinServicio)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Vip)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FAntiguedad)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NroPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NroAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.ContentFile)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .HasMany(e => e.DetalleSCYF)
                .WithRequired(e => e.FileScyfFtp)
                .HasForeignKey(e => e.IdFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogFileSCYF>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<LogFileSCYF>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
