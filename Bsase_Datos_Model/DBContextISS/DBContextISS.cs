using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.DBContextISS
{
    public partial class DBContextISS : DbContext
    {
        public DBContextISS()
            : base("name=DBContextISS")
        {
        }

        public virtual DbSet<EspecialidadNegocio> EspecialidadNegocio { get; set; }
        public virtual DbSet<EspecialidadxProducto> EspecialidadxProducto { get; set; }
        public virtual DbSet<NivelEspecialidad> NivelEspecialidad { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.CodigoEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.ClaveEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .HasMany(e => e.EspecialidadxProducto)
                .WithRequired(e => e.EspecialidadNegocio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EspecialidadxProducto>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadxProducto>()
                .Property(e => e.CodigoEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<NivelEspecialidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

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

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.TipoCuenta1)
                .IsUnicode(false);
        }
    }
}
