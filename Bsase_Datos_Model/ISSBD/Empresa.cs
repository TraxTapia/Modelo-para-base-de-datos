namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empresa()
        {
            CargaArchivos = new HashSet<CargaArchivos>();
            Comision = new HashSet<Comision>();
            ContactoEmpresa = new HashSet<ContactoEmpresa>();
            EmpresaRegla = new HashSet<EmpresaRegla>();
            EmpresaRestriccion = new HashSet<EmpresaRestriccion>();
            EmpresaPeriodo = new HashSet<EmpresaPeriodo>();
            EmpresaProducto = new HashSet<EmpresaProducto>();
            Recibo = new HashSet<Recibo>();
            UbicacionEmpresa = new HashSet<UbicacionEmpresa>();
            Vendedor = new HashSet<Vendedor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreFiscal { get; set; }

        [Required]
        [StringLength(15)]
        public string RFC { get; set; }

        [Required]
        [StringLength(100)]
        public string Responsable { get; set; }

        public DateTime FechaInicioServicio { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        public int DiasCredito { get; set; }

        [Required]
        [StringLength(2)]
        public string DiaSemanaCorte { get; set; }

        public int DiaMesCorte { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusEmpresa { get; set; }

        [Required]
        [StringLength(15)]
        public string CodProducto { get; set; }

        public int CodRed { get; set; }

        public int CodPeriodo { get; set; }

        public int CodCampania { get; set; }

        public int NumeroBeneficiarios { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Observacion { get; set; }

        [Required]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codPlan { get; set; }

        public int? CodTabulador { get; set; }

        public int? ValidacionArchivoPor { get; set; }

        public virtual Campania Campania { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargaArchivos> CargaArchivos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comision> Comision { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoEmpresa> ContactoEmpresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaRegla> EmpresaRegla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaRestriccion> EmpresaRestriccion { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual Periodo Periodo { get; set; }

        public virtual Red Red { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaPeriodo> EmpresaPeriodo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpresaProducto> EmpresaProducto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionEmpresa> UbicacionEmpresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor> Vendedor { get; set; }
    }
}
