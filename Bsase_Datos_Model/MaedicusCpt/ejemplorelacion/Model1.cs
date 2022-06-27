using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.ejemplorelacion
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model12")
        {
        }

        public virtual DbSet<FoliosReceta> FoliosReceta { get; set; }
        public virtual DbSet<FoliosRemesa> FoliosRemesa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .HasMany(e => e.FoliosRemesa)
                .WithRequired(e => e.FoliosReceta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);
        }
    }
}
