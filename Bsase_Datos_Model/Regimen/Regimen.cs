using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Regimen
{
    public partial class Regimen : DbContext
    {
        public Regimen()
            : base("name=Regimen")
        {
        }

        public virtual DbSet<CATREGIMEN> CATREGIMEN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CATREGIMEN>()
                .Property(e => e.Fecha_de_inicio_de_vigencia)
                .HasPrecision(3);

            modelBuilder.Entity<CATREGIMEN>()
                .Property(e => e.Fecha_de_fin_de_vigencia)
                .HasPrecision(3);
        }
    }
}
