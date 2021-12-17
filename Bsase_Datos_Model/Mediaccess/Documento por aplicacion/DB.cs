using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Mediaccess.Documento_por_aplicacion
{
    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<CatAplicacion> CatAplicacion { get; set; }
        public virtual DbSet<CatArchivos> CatArchivos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatAplicacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatArchivos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);
        }
    }
}
