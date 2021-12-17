using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Mediaccess.Autorizaciones
{
    public partial class Autorizacion : DbContext
    {
        public Autorizacion()
            : base("name=Autorizacion")
        {
        }

        public virtual DbSet<Autorizaciones> Autorizaciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.IP)
                .IsUnicode(false);
        }
    }
}
