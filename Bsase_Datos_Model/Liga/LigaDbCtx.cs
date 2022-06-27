using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Liga
{
    public partial class LigaDbCtx : DbContext
    {
        public LigaDbCtx()
            : base("name=LigaDbCtx")
        {
        }

        public virtual DbSet<Jugadores> Jugadores { get; set; }
        public virtual DbSet<Posiciones> Posiciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jugadores>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Jugadores>()
                .Property(e => e.Apodo)
                .IsUnicode(false);

            modelBuilder.Entity<Posiciones>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Posiciones>()
                .HasMany(e => e.Jugadores)
                .WithOptional(e => e.Posiciones)
                .HasForeignKey(e => e.IdPosicion);
        }
    }
}
