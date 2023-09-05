using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.NewTablesMediaccess
{
    public partial class ContextBD : DbContext
    {
        public ContextBD()
            : base("name=ContextBD")
        {
        }

        public virtual DbSet<GastoCoberturasDetalleObservaciones> GastoCoberturasDetalleObservaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GastoCoberturasDetalleObservaciones>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleObservaciones>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
