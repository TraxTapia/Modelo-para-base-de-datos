using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.movimientosFacturas
{
    public partial class movimientos : DbContext
    {
        public movimientos()
            : base("name=movimientos")
        {
        }

        public virtual DbSet<movimientosFacturas> movimientosFacturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.codestatusfactura)
                .IsFixedLength();

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.codConcepto)
                .IsFixedLength();

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.observaciones)
                .IsUnicode(false);
        }
    }
}
