using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Aseguradora
{
    public partial class asegu : DbContext
    {
        public asegu()
            : base("name=asegu")
        {
        }

        public virtual DbSet<ProductoAseguradora> ProductoAseguradora { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoAseguradora>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
