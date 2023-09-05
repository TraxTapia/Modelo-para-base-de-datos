using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.csfsfsfsd
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context3")
        {
        }

        public virtual DbSet<LogControlGasto> LogControlGasto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogControlGasto>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGasto>()
                .Property(e => e.CodProcedimientoInicial)
                .IsUnicode(false);
        }
    }
}
