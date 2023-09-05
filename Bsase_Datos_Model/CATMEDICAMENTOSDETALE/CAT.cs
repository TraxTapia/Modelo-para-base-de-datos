using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.CATMEDICAMENTOSDETALE
{
    public partial class CAT : DbContext
    {
        public CAT()
            : base("name=CAT")
        {
        }

        public virtual DbSet<CatFormaFarmaceutica> CatFormaFarmaceutica { get; set; }
        public virtual DbSet<CatUnidaddeMedidas> CatUnidaddeMedidas { get; set; }
        public virtual DbSet<CatUnidades> CatUnidades { get; set; }
        public virtual DbSet<CatViaAdmUnidades> CatViaAdmUnidades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatFormaFarmaceutica>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatUnidaddeMedidas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatUnidades>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatViaAdmUnidades>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
