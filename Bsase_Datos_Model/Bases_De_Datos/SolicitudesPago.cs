namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudesPago")]
    public partial class SolicitudesPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudesPago()
        {
            SolicitudesPagoDetalle = new HashSet<SolicitudesPagoDetalle>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaSolicitud { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaRecepcion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaPago { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaEnvio { get; set; }

        [Required]
        [StringLength(50)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Comprobante { get; set; }

        [Required]
        [StringLength(255)]
        public string Soporte { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_alta { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_alta { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_cambio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_cambio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudesPagoDetalle> SolicitudesPagoDetalle { get; set; }
    }
}
