using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.RemesasECE
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model14")
        {
        }

        public virtual DbSet<FacturaRemesa> FacturaRemesa { get; set; }
        public virtual DbSet<FacturaxRemesa> FacturaxRemesa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.RFCEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.XML)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.PDF)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.TotalFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.SubtotalFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.DescuentoFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.idEstatusFacturaRemesaSAT)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .HasMany(e => e.FacturaxRemesa)
                .WithRequired(e => e.FacturaRemesa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacturaxRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaxRemesa>()
                .Property(e => e.UUID)
                .IsUnicode(false);
        }
    }
}
