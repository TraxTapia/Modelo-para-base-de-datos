using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.CajaAhorro
{
    public partial class CajaAhorro : DbContext
    {
        public CajaAhorro()
            : base("name=CajaAhorro")
        {
        }

        public virtual DbSet<Ahorro> Ahorro { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Ahorro)
                .WithRequired(e => e.Usuario)
                .HasForeignKey(e => e.Id_Usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
