using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusModificacionGasto
{
    public partial class ContextBD : DbContext
    {
        public ContextBD()
            : base("name=ContextBD1")
        {
        }

        public virtual DbSet<FacturasxProcesar> FacturasxProcesar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
