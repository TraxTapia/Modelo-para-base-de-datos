using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.DBContextISS.CodPymesWELLNES
{
    public partial class ContextISS : DbContext
    {
        public ContextISS()
            : base("name=ContextISS")
        {
        }

        public virtual DbSet<CodPymesWELLNES> CodPymesWELLNES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
