using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.CRUDMedicamentos
{
    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model22")
        {
        }

        public virtual DbSet<sys_mediaccess_CatClaves_Autorizacion> sys_mediaccess_CatClaves_Autorizacion { get; set; }
        public virtual DbSet<sys_mediaccess_CatMensajes_ECE> sys_mediaccess_CatMensajes_ECE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Cve_Aut)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Color_Aut)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatMensajes_ECE>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatMensajes_ECE>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);
        }
    }
}
