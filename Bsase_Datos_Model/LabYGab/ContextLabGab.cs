using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.LabYGab
{
    public partial class ContextLabGab : DbContext
    {
        public ContextLabGab()
            : base("name=ContextLabGab")
        {
        }

        public virtual DbSet<CatalogoEstudio> CatalogoEstudio { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Clasificacion> Clasificacion { get; set; }
        public virtual DbSet<Subcategoria> Subcategoria { get; set; }
        public virtual DbSet<ClasificacionxProducto> ClasificacionxProducto { get; set; }
        public virtual DbSet<ProductoxClasificacion> ProductoxClasificacion { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatalogoEstudio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoEstudio>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CatalogoEstudio>()
                .Property(e => e.CveEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoEstudio>()
                .HasMany(e => e.ClasificacionxProducto)
                .WithRequired(e => e.CatalogoEstudio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.CatalogoEstudio)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.ProductoxClasificacion)
                .WithRequired(e => e.Clasificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Subcategoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Subcategoria>()
                .HasMany(e => e.CatalogoEstudio)
                .WithRequired(e => e.Subcategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasificacionxProducto>()
                .Property(e => e.CveAutrizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoxClasificacion>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);
        }
    }
}
