using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.CRUDMedicamentos
{
    public partial class Model4 : DbContext
    {
        public Model4()
            : base("name=Model4")
        {
        }

        public virtual DbSet<sys_mediaccess_Medicamentos_log> sys_mediaccess_Medicamentos_log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.TipoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);
        }
    }
}
