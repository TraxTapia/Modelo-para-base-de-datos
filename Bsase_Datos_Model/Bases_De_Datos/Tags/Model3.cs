using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Bases_De_Datos.Tags
{
    public partial class Model3 : DbContext
    {
        public Model3()
            : base("name=Model32")
        {
        }

        public virtual DbSet<LogTags> LogTags { get; set; }
        public virtual DbSet<LogTagsxProducto> LogTagsxProducto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogTags>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<LogTags>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<LogTags>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<LogTagsxProducto>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<LogTagsxProducto>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);
        }
    }
}
