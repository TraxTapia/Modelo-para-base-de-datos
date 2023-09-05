namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proveedor")]
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            DocumentoProveedor = new HashSet<DocumentoProveedor>();
            RedProveedor = new HashSet<RedProveedor>();
            ServicioGeneral = new HashSet<ServicioGeneral>();
            StaffMedico = new HashSet<StaffMedico>();
            UbicacionProveedor = new HashSet<UbicacionProveedor>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProveedor { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreComercial { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreFiscal { get; set; }

        [Required]
        [StringLength(15)]
        public string RFC { get; set; }

        [StringLength(18)]
        public string CURP { get; set; }

        public int IVA { get; set; }

        public int RetISR { get; set; }

        public int RetIVA { get; set; }

        public double? OtrosImpuestos { get; set; }

        [StringLength(255)]
        public string Observacion { get; set; }

        public double ImporteIguala { get; set; }

        public int CodTipoContribuyente { get; set; }

        [Required]
        [StringLength(2)]
        public string CodMetodoPago { get; set; }

        [Required]
        [StringLength(3)]
        public string CodEspecialidad { get; set; }

        public int CodSubEspecialidad { get; set; }

        public int? CodBanco { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusProveedor { get; set; }

        public int CodPerfil { get; set; }

        [Required]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        [StringLength(25)]
        public string LGProveedor { get; set; }

        [StringLength(45)]
        public string PSProveedor { get; set; }

        public virtual Banco Banco { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentoProveedor> DocumentoProveedor { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual MetodoPago MetodoPago { get; set; }

        public virtual Perfil Perfil { get; set; }

        public virtual SubEspecialidad SubEspecialidad { get; set; }

        public virtual TipoContribuyente TipoContribuyente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RedProveedor> RedProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioGeneral> ServicioGeneral { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffMedico> StaffMedico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionProveedor> UbicacionProveedor { get; set; }
    }
}
