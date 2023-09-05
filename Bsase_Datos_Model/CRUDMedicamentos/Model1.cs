using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.CRUDMedicamentos
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model19")
        {
        }

        public virtual DbSet<sys_mediaccess_Cat_Cuadros> sys_mediaccess_Cat_Cuadros { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Especialidades> sys_mediaccess_Cat_Especialidades { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Grupos> sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Laboratorios> sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Sal> sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos> sys_mediaccess_Medicamentos { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos_Detalle> sys_mediaccess_Medicamentos_Detalle { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<sys_mediaccess_Cat_Cuadros>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Especialidades>()
                .Property(e => e.DscEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.Unidad)
                .IsUnicode(false);
        }
    }
}
