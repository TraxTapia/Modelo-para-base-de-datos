using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Nomina
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model18")
        {
        }

        public virtual DbSet<C_AAST_010> C_AAST_010 { get; set; }
        public virtual DbSet<C_AST_001> C_AST_001 { get; set; }
        public virtual DbSet<C_AST_010> C_AST_010 { get; set; }
        public virtual DbSet<C_AST_011> C_AST_011 { get; set; }
        public virtual DbSet<C_AST_132> C_AST_132 { get; set; }
        public virtual DbSet<C_AST_142> C_AST_142 { get; set; }
        public virtual DbSet<C_AST_701> C_AST_701 { get; set; }
        public virtual DbSet<C_AST_702> C_AST_702 { get; set; }
        public virtual DbSet<C_AST_703> C_AST_703 { get; set; }
        public virtual DbSet<C_AST_704> C_AST_704 { get; set; }
        public virtual DbSet<C_AST_705> C_AST_705 { get; set; }
        public virtual DbSet<C_AST_706> C_AST_706 { get; set; }
        public virtual DbSet<C_AST_708> C_AST_708 { get; set; }
        public virtual DbSet<C_AST_709> C_AST_709 { get; set; }
        public virtual DbSet<C_AST_710> C_AST_710 { get; set; }
        public virtual DbSet<C_AST_711> C_AST_711 { get; set; }
        public virtual DbSet<C_AST_712> C_AST_712 { get; set; }
        public virtual DbSet<C_AST_713> C_AST_713 { get; set; }
        public virtual DbSet<C_AST_714> C_AST_714 { get; set; }
        public virtual DbSet<C_AST_715> C_AST_715 { get; set; }
        public virtual DbSet<C_AST_716> C_AST_716 { get; set; }
        public virtual DbSet<C_AST_717> C_AST_717 { get; set; }
        public virtual DbSet<C_AST_718> C_AST_718 { get; set; }
        public virtual DbSet<C_AST_722> C_AST_722 { get; set; }
        public virtual DbSet<C_AST_723> C_AST_723 { get; set; }
        public virtual DbSet<C_AST_737> C_AST_737 { get; set; }
        public virtual DbSet<C_AST_747> C_AST_747 { get; set; }
        public virtual DbSet<C_AST_754> C_AST_754 { get; set; }
        public virtual DbSet<C_AST_F11> C_AST_F11 { get; set; }
        public virtual DbSet<C_AST_T12> C_AST_T12 { get; set; }
        public virtual DbSet<C_AST_T15> C_AST_T15 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<C_AST_001>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_001>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_001>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_STAT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SUE)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SDI)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SIST)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SFIJ)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SVAR)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_INTF)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_IRE1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_IRE2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_BONO)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SN)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SPRO)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_DBANT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_VBANT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_PTJAUM)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_SUED)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_IFV)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_CALFN)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_STATN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_011>()
                .Property(e => e.U_TIPUSU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_132>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_132>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_132>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_142>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_142>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_142>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_701>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_701>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_701>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_701>()
                .Property(e => e.U_OECTAB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_702>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_702>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_702>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_702>()
                .Property(e => e.U_ACCTAB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_703>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_703>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_703>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_703>()
                .Property(e => e.U_OECTAB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_703>()
                .Property(e => e.U_UCTAB2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_704>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_704>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_704>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_705>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_705>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_705>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_706>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_706>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_706>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_706>()
                .Property(e => e.U_HRT)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_708>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_708>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_708>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_709>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_709>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_709>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_710>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_710>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_710>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_711>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_711>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_711>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_712>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_712>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_712>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_713>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_713>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_713>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_714>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_714>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_714>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_715>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_715>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_715>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_716>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_716>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_716>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_717>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_717>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_717>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_718>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_718>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_718>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.U_IRD1)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.U_IRD2)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.U_IRD3)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_722>()
                .Property(e => e.U_IRD4)
                .HasPrecision(19, 6);

            modelBuilder.Entity<C_AST_723>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_723>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_723>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_737>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_737>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_737>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_747>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_747>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_747>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_754>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_754>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_754>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_F11>()
                .Property(e => e.Canceled)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_F11>()
                .Property(e => e.Transfered)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<C_AST_F11>()
                .Property(e => e.DataSource)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
