using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.REMESASECE
{
    public partial class maedicusCTPContext : DbContext
    {
        public maedicusCTPContext()
            : base("name=maedicusCTPContext")
        {
        }

        public virtual DbSet<CatErrores> CatErrores { get; set; }
        public virtual DbSet<EmpresaGrupo> EmpresaGrupo { get; set; }
        public virtual DbSet<EstatusFacturaRemesa> EstatusFacturaRemesa { get; set; }
        public virtual DbSet<EstatusFacturaRemesaSAT> EstatusFacturaRemesaSAT { get; set; }
        public virtual DbSet<EstatusRemesas> EstatusRemesas { get; set; }
        public virtual DbSet<FacturaRemesa> FacturaRemesa { get; set; }
        public virtual DbSet<FacturaxRemesa> FacturaxRemesa { get; set; }
        public virtual DbSet<FoliosReceta> FoliosReceta { get; set; }
        public virtual DbSet<FoliosRemesa> FoliosRemesa { get; set; }
        public virtual DbSet<LogFacturasConError> LogFacturasConError { get; set; }
        public virtual DbSet<NumeroRemesa> NumeroRemesa { get; set; }
        public virtual DbSet<Remesas> Remesas { get; set; }
        public virtual DbSet<TipoRemesa> TipoRemesa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CatErrores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaGrupo>()
                .Property(e => e.CveEmpresaGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaGrupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFacturaRemesa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFacturaRemesaSAT>()
                .Property(e => e.idEstatusFacturaRemesaSAT)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFacturaRemesaSAT>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusRemesas>()
                .Property(e => e.EstatusRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.RFCEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.XML)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.PDF)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.TotalFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.SubtotalFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.DescuentoFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.idEstatusFacturaRemesaSAT)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .HasMany(e => e.FacturaxRemesa)
                .WithRequired(e => e.FacturaRemesa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacturaxRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaxRemesa>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Copago)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.CIE10)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.DescripcionProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.OrigenProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<LogFacturasConError>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.CveEmpresaGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.ClaveSistema)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRemesa>()
                .Property(e => e.TipoRemesa1)
                .IsUnicode(false);
        }
    }
}
