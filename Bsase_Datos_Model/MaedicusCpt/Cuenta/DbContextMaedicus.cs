using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.MaedicusCpt.Cuenta
{
    public partial class DbContextMaedicus : DbContext
    {
        public DbContextMaedicus()
            : base("name=DbCONTEXTModel")
        {
        }

        public virtual DbSet<Cuenta> Cuenta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodTipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.RestoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.ApellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.ApellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.flgIguala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.SGPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.cedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.certificacion)
                .IsUnicode(false);
        }
    }
}
