namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodFactura { get; set; }

        [StringLength(10)]
        public string CodMotivoDevolucion { get; set; }

        public int? CodMotivoDetencion { get; set; }

        public int? CodGuiaForanea { get; set; }

        public int? CodStatusFactura { get; set; }

        public int? CodRemesa { get; set; }

        public DateTime? FechaRemesa { get; set; }

        [StringLength(10)]
        public string NumeroProveedor { get; set; }

        [StringLength(100)]
        public string NombreProveedor { get; set; }

        [StringLength(50)]
        public string NumeroFactura { get; set; }

        public DateTime? FechaFactura { get; set; }

        public int? CantidadFolios { get; set; }

        [Column(TypeName = "money")]
        public decimal? facImporte { get; set; }

        [Column(TypeName = "money")]
        public decimal? facIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? facISR { get; set; }

        [Column(TypeName = "money")]
        public decimal? facRetencionIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? facDescuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? facTotal { get; set; }

        [StringLength(1)]
        public string flgDetenido { get; set; }

        public DateTime? FechaDetenido { get; set; }

        [StringLength(20)]
        public string DetenidoPor { get; set; }

        [StringLength(20)]
        public string DevueltoPor { get; set; }

        [Column(TypeName = "text")]
        public string ObservacionDetenido { get; set; }

        [StringLength(20)]
        public string NumeroGuiaDevolucion { get; set; }

        public DateTime? FechaDevolucion { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public DateTime? FechaCaptura { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
