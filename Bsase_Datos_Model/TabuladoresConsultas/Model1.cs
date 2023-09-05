using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.TabuladoresConsultas
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model121")
        {
        }

        public virtual DbSet<LogCalculoReservaProveedor> LogCalculoReservaProveedor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LogCalculoReservaProveedor>()
                .Property(e => e.UserName)
                .IsUnicode(false);
        }
    }
}
