namespace Bsase_Datos_Model.MaedicusCpt.ECEREMESAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaRemesa")]
    public partial class FacturaRemesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacturaRemesa()
        {
            FacturaxRemesa = new HashSet<FacturaxRemesa>();
        }

        [Key]
        [StringLength(40)]
        public string UUID { get; set; }

        [StringLength(13)]
        public string RFCEmisor { get; set; }

        public DateTime? FechaEmision { get; set; }

        public DateTime? FechaTimbrado { get; set; }

        [StringLength(50)]
        public string Estatus { get; set; }

        [StringLength(256)]
        public string XML { get; set; }

        [StringLength(256)]
        public string PDF { get; set; }

        public decimal? TotalFactura { get; set; }

        public decimal? SubtotalFactura { get; set; }

        public decimal? DescuentoFactura { get; set; }

        public DateTime? FechaBaja { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public bool? Activo { get; set; }

        [StringLength(15)]
        public string idEstatusFacturaRemesaSAT { get; set; }

        public int? idEstatusFacturaRemesa { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroFactura { get; set; }

        public int SecuenciaMac { get; set; }

        public DateTime? FechaPago { get; set; }

        public virtual EstatusFacturaRemesa EstatusFacturaRemesa { get; set; }

        public virtual EstatusFacturaRemesaSAT EstatusFacturaRemesaSAT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaxRemesa> FacturaxRemesa { get; set; }
    }
}
