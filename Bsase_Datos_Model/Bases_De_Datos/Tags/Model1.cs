using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Bases_De_Datos.Tags
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model117")
        {
        }

        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Producto1)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.Tags)
                .WithMany(e => e.Producto)
                .Map(m => m.ToTable("TagsxProducto").MapLeftKey(new[] { "CodProducto", "codPlan" }).MapRightKey("IdTag"));

            modelBuilder.Entity<Tags>()
                .Property(e => e.Tag)
                .IsUnicode(false);

            modelBuilder.Entity<Tags>()
                .Property(e => e.descripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<Tags>()
                .Property(e => e.creadopor)
                .IsUnicode(false);

            modelBuilder.Entity<Tags>()
                .Property(e => e.actualizadopor)
                .IsUnicode(false);

            modelBuilder.Entity<Tags>()
                .Property(e => e.eliminadopor)
                .IsUnicode(false);
        }
    }
}
