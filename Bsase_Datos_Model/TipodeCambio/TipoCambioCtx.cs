using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.TipodeCambio
{
    public partial class TipoCambioCtx : DbContext
    {
        public TipoCambioCtx()
            : base("name=TipoCambioCtx")
        {
        }

        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<TipodeCambio> TipodeCambio { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Moneda>()
                .Property(e => e.CveMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.DescripcionMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.TipodeCambio)
                .WithOptional(e => e.Moneda)
                .HasForeignKey(e => e.CveModena);

            modelBuilder.Entity<TipodeCambio>()
                .Property(e => e.CveModena)
                .IsUnicode(false);

            modelBuilder.Entity<TipodeCambio>()
                .Property(e => e.Monto)
                .HasPrecision(19, 5);
        }
    }
}
