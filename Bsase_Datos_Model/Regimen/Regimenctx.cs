using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Regimen
{
    public partial class Regimenctx : DbContext
    {
        public Regimenctx()
            : base("name=Regimenctx")
        {
        }

        public virtual DbSet<LogRegimenFiscal> LogRegimenFiscal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogRegimenFiscal>()
                .Property(e => e.Regimen)
                .IsUnicode(false);

            modelBuilder.Entity<LogRegimenFiscal>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<LogRegimenFiscal>()
                .Property(e => e.User)
                .IsUnicode(false);
        }
    }
}
