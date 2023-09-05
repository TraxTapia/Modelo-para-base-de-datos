using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.REMESASECE.Maedicus_Web
{
    public partial class Maedicus_Web : DbContext
    {
        public Maedicus_Web()
            : base("name=Maedicus_Web")
        {
        }

        public virtual DbSet<FoliosRecetas> FoliosRecetas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoliosRecetas>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRecetas>()
                .Property(e => e.seglogin)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
