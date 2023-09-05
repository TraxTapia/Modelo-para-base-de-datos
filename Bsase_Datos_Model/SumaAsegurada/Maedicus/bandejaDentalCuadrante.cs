namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bandejaDentalCuadrante")]
    public partial class bandejaDentalCuadrante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bandejaDentalCuadrante()
        {
            procedimientOdontologico = new HashSet<procedimientOdontologico>();
        }

        [Key]
        [StringLength(50)]
        public string folio { get; set; }

        public DateTime? fechaServicio { get; set; }

        [StringLength(50)]
        public string elegibilidad { get; set; }

        public int? codempresa { get; set; }

        [StringLength(50)]
        public string codafiliado { get; set; }

        public int? correlativo { get; set; }

        [StringLength(50)]
        public string cve_provMedico { get; set; }

        public int? viaRecepcion { get; set; }

        [Column(TypeName = "text")]
        public string descDental { get; set; }

        [StringLength(50)]
        public string cve_provRealiza { get; set; }

        public DateTime? fechaRecepcion { get; set; }

        [Column(TypeName = "text")]
        public string datosExploracion { get; set; }

        public DateTime? fechaGenerarion { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [Column(TypeName = "text")]
        public string obsAutorizacion { get; set; }

        [Column(TypeName = "text")]
        public string indicacionesMedico { get; set; }

        [Column(TypeName = "text")]
        public string indicacionesPaciente { get; set; }

        [Column(TypeName = "text")]
        public string indicacionesHospital { get; set; }

        public int? codEstatus { get; set; }

        [Column(TypeName = "text")]
        public string observacionPendiente { get; set; }

        public int? estatusImpresion { get; set; }

        [StringLength(5)]
        public string cve_cie { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int secuencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<procedimientOdontologico> procedimientOdontologico { get; set; }
    }
}
