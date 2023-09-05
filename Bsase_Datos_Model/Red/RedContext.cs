using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Red
{
    public partial class RedContext : DbContext
    {
        public RedContext()
            : base("name=RedContext")
        {
        }

        public virtual DbSet<Red> Red { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Red>()
                .Property(e => e.Red1)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.NombreLargo)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);
        }
    }
}
