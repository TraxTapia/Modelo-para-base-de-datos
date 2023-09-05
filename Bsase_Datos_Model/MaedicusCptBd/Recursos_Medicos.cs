namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recursos_Medicos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recursos_Medicos()
        {
            Facturas = new HashSet<Facturas>();
            OP_PEMEX_Recepcion = new HashSet<OP_PEMEX_Recepcion>();
            ProvidersExceedsDays = new HashSet<ProvidersExceedsDays>();
            ProvidersWithoutCopay = new HashSet<ProvidersWithoutCopay>();
            SARSCoV2_Letters = new HashSet<SARSCoV2_Letters>();
            SIS_CTLF_Folios = new HashSet<SIS_CTLF_Folios>();
        }

        [Key]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string RFC { get; set; }

        [Required]
        [StringLength(200)]
        public string RecursoMedico { get; set; }

        [Required]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Required]
        [StringLength(2)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(300)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(5)]
        public string CodEstado { get; set; }

        public int CodPoblacion { get; set; }

        [StringLength(50)]
        public string clabe { get; set; }

        [StringLength(50)]
        public string Cuenta { get; set; }

        [StringLength(50)]
        public string Sucursal { get; set; }

        [Required]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [StringLength(1000)]
        public string email { get; set; }

        [StringLength(50)]
        public string lada { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string apellidoPaterno { get; set; }

        [StringLength(50)]
        public string apellidoMaterno { get; set; }

        [StringLength(50)]
        public string nombres { get; set; }

        [StringLength(200)]
        public string nombreComercial { get; set; }

        [StringLength(200)]
        public string nombreFiscal { get; set; }

        public DateTime? fechaBaja { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_PEMEX_Recepcion> OP_PEMEX_Recepcion { get; set; }

        public virtual Poblacion Poblacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvidersExceedsDays> ProvidersExceedsDays { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProvidersWithoutCopay> ProvidersWithoutCopay { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SARSCoV2_Letters> SARSCoV2_Letters { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIS_CTLF_Folios> SIS_CTLF_Folios { get; set; }
    }
}
