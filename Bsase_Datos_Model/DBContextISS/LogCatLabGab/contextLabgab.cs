using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.DBContextISS.LogCatLabGab
{
    public partial class contextLabgab : DbContext
    {
        public contextLabgab()
            : base("name=contextLabgab")
        {
        }

        public virtual DbSet<LogMovimientosCatLabGab> LogMovimientosCatLabGab { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogMovimientosCatLabGab>()
                .Property(e => e.Usuario)
                .IsUnicode(false);
        }
    }
}
