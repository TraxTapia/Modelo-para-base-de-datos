using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCPT_Web.FoliosReceta
{
    public partial class DBCTX : DbContext
    {
        public DBCTX()
            : base("name=DBCTX")
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
