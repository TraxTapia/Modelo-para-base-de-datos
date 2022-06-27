using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.ECEREMESAS
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model13")
        {
        }

        public virtual DbSet<NumeroRemesa> NumeroRemesa { get; set; }
        public virtual DbSet<Remesas> Remesas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.CveEmpresaGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.ClaveSistema)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);
        }
    }
}
