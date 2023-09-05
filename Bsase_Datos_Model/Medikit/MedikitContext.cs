using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Medikit
{
    public partial class MedikitContext : DbContext
    {
        public MedikitContext()
            : base("name=MedikitContext1")
        {
        }

        public virtual DbSet<MedikitFTPFile> MedikitFTPFile { get; set; }
        public virtual DbSet<MedikitFtpFileDetail> MedikitFtpFileDetail { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MedikitFTPFile>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFTPFile>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFTPFile>()
                .HasMany(e => e.MedikitFtpFileDetail)
                .WithRequired(e => e.MedikitFTPFile)
                .HasForeignKey(e => e.IdFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nur)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Paciente)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Dispensacion_de_medicamentos)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Creado_por)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Ultima_modificacion_por)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre_Medicacion)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Receta_relacionada)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre_de_Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre_de_la_cuenta_del_dispensador)
                .IsUnicode(false);
        }
    }
}
