using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Red
{
    public partial class agrupacion : DbContext
    {
        public agrupacion()
            : base("name=agrupacion")
        {
        }

        public virtual DbSet<sys_mediaccess_Agrupacion_Productos> sys_mediaccess_Agrupacion_Productos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
