using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.RemesasECE
{
    public partial class RemesasECE : DbContext
    {
        public RemesasECE()
            : base("name=RemesasECE")
        {
        }

        public virtual DbSet<Remesas> Remesas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Remesas>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);
        }
    }
}
