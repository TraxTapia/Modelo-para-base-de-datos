using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Aseguradora
{
    public partial class Log : DbContext
    {
        public Log()
            : base("name=Log")
        {
        }

        public virtual DbSet<LogProductosEmision> LogProductosEmision { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.ICodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.VCHCodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.ICodCoberturaCambio)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.VCHCodProductoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
