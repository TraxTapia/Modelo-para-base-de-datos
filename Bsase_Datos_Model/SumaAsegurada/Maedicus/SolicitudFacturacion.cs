namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudFacturacion")]
    public partial class SolicitudFacturacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SolicitudFacturacion()
        {
            SolicitudesPagoDetalle = new HashSet<SolicitudesPagoDetalle>();
            SolicitudFacturacionDetalle = new HashSet<SolicitudFacturacionDetalle>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Clave { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public DateTime? FechaRecepcion { get; set; }

        public DateTime? FechaEnvio { get; set; }

        [Required]
        [StringLength(50)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(255)]
        public string XML { get; set; }

        public DateTime? FechaPago { get; set; }

        public DateTime? FechaEmision { get; set; }

        [Required]
        [StringLength(255)]
        public string PDF { get; set; }

        [Required]
        [StringLength(40)]
        public string UUID { get; set; }

        [Required]
        [StringLength(50)]
        public string Serie { get; set; }

        [Required]
        [StringLength(5)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(255)]
        public string NombreEmisor { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        public decimal TotalFactura { get; set; }

        public decimal SubtotalFactura { get; set; }

        public decimal DescuentoFactura { get; set; }

        public decimal ImpuestosFactura { get; set; }

        [Required]
        [StringLength(25)]
        public string FolioFactura { get; set; }

        [Required]
        [StringLength(25)]
        public string FolioNotaCredito { get; set; }

        [StringLength(255)]
        public string ArchivoNotaCredito { get; set; }

        [StringLength(255)]
        public string ArchivoNotaCreditoPDF { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_alta { get; set; }

        public DateTime fecha_alta { get; set; }

        [Required]
        [StringLength(50)]
        public string usu_cambio { get; set; }

        public DateTime fecha_cambio { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudesPagoDetalle> SolicitudesPagoDetalle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SolicitudFacturacionDetalle> SolicitudFacturacionDetalle { get; set; }
    }
}
