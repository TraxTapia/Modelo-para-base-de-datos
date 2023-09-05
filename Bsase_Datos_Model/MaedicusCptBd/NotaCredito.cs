namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotaCredito")]
    public partial class NotaCredito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NotaCredito()
        {
            NotaCreditoDetalle = new HashSet<NotaCreditoDetalle>();
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

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string XML { get; set; }

        public DateTime? FechaPago { get; set; }

        public DateTime? FechaEmision { get; set; }

        [StringLength(255)]
        public string PDF { get; set; }

        [StringLength(40)]
        public string UUID { get; set; }

        [StringLength(50)]
        public string Serie { get; set; }

        [StringLength(5)]
        public string Tipo { get; set; }

        [StringLength(255)]
        public string NombreEmisor { get; set; }

        [StringLength(13)]
        public string RFC { get; set; }

        public decimal? TotalFactura { get; set; }

        public decimal? SubtotalFactura { get; set; }

        public decimal? DescuentoFactura { get; set; }

        public decimal? ImpuestosFactura { get; set; }

        [StringLength(25)]
        public string FolioFactura { get; set; }

        [StringLength(25)]
        public string FolioNotaCredito { get; set; }

        [StringLength(255)]
        public string ArchivoNotaCredito { get; set; }

        [StringLength(255)]
        public string ArchivoNotaCreditoPDF { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime? FechaCambio { get; set; }

        public bool Eliminado { get; set; }

        [StringLength(50)]
        public string Periodo { get; set; }

        public DateTime? FechaReclamacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotaCreditoDetalle> NotaCreditoDetalle { get; set; }
    }
}
