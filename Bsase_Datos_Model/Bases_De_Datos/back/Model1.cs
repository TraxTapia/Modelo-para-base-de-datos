using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model114")
        {
        }

        public virtual DbSet<Requisitos> Requisitos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Requisitos>()
                .Property(e => e.TipoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);
        }
    }
}
