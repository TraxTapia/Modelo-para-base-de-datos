using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Red
{
    public partial class gruposctx : DbContext
    {
        public gruposctx()
            : base("name=gruposctx")
        {
        }

        public virtual DbSet<Grupos> Grupos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grupos>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Grupos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);
        }
    }
}
