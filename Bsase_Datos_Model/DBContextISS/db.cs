using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.DBContextISS
{
    public partial class db : DbContext
    {
        public db()
            : base("name=db")
        {
        }

        public virtual DbSet<Catalogo_Moneda> Catalogo_Moneda { get; set; }
        public virtual DbSet<Coberturas_Ficha_Tecnica> Coberturas_Ficha_Tecnica { get; set; }
        public virtual DbSet<Ficha_Tecnica> Ficha_Tecnica { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalogo_Moneda>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Moneda>()
                .HasMany(e => e.Ficha_Tecnica)
                .WithRequired(e => e.Catalogo_Moneda)
                .HasForeignKey(e => e.Id_Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .Property(e => e.Cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .Property(e => e.CodAgrupador)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .HasMany(e => e.Ficha_Tecnica)
                .WithRequired(e => e.Coberturas_Ficha_Tecnica)
                .HasForeignKey(e => e.Id_Cobertura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ficha_Tecnica>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Ficha_Tecnica>()
                .Property(e => e.Especificaciones)
                .IsUnicode(false);
        }
    }
}
