using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.HomologacionDB
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context10")
        {
        }

        public virtual DbSet<HomologacionCatalogos> HomologacionCatalogos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HomologacionCatalogos>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HomologacionCatalogos>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<HomologacionCatalogos>()
                .Property(e => e.CveEstudio)
                .IsUnicode(false);
        }
    }
}
