using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.PadronSICA
{
    public partial class Sicas : DbContext
    {
        public Sicas()
            : base("name=Sicas")
        {
        }

        public virtual DbSet<PadronSICAS> PadronSICAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PadronSICAS>()
                .Property(e => e.ICodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<PadronSICAS>()
                .Property(e => e.VCHCodProducto)
                .IsUnicode(false);
        }
    }
}
