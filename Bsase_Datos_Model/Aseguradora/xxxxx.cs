using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Aseguradora
{
    public partial class xxxxx : DbContext
    {
        public xxxxx()
            : base("name=xxxxx")
        {
        }

        public virtual DbSet<sys_mediaccess_Agrupacion_Productos> sys_mediaccess_Agrupacion_Productos { get; set; }
        public virtual DbSet<sys_mediaccess_Agrupacion_Productos_log> sys_mediaccess_Agrupacion_Productos_log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos_log>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos_log>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos_log>()
                .Property(e => e.observaciones)
                .IsUnicode(false);
        }
    }
}
