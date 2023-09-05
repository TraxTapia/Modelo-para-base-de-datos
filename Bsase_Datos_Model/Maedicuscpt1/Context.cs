using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Maedicuscpt1
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context9")
        {
        }

        public virtual DbSet<ElectronicFoliosValidatorTemp> ElectronicFoliosValidatorTemp { get; set; }
        public virtual DbSet<ManualFoliosValidatorTemp> ManualFoliosValidatorTemp { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElectronicFoliosValidatorTemp>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ElectronicFoliosValidatorTemp>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<ElectronicFoliosValidatorTemp>()
                .Property(e => e.Importe)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ElectronicFoliosValidatorTemp>()
                .Property(e => e.Total)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ManualFoliosValidatorTemp>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ManualFoliosValidatorTemp>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<ManualFoliosValidatorTemp>()
                .Property(e => e.Importe)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ManualFoliosValidatorTemp>()
                .Property(e => e.Total)
                .HasPrecision(18, 4);
        }
    }
}
