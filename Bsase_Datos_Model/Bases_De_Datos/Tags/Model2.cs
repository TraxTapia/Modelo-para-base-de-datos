using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Bases_De_Datos.Tags
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model25")
        {
        }

        public virtual DbSet<TagsxProducto> TagsxProducto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TagsxProducto>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
