using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Mediaccess
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model16")
        {
        }

        public virtual DbSet<CatAplicacion> CatAplicacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatAplicacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);
        }
    }
}
