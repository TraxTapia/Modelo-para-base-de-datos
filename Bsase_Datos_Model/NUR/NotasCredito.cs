namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotasCredito")]
    public partial class NotasCredito
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodNC { get; set; }

        public int? CodFactura { get; set; }

        [StringLength(20)]
        public string NumeroFactura { get; set; }

        [StringLength(20)]
        public string ImporteFact { get; set; }

        [StringLength(10)]
        public string NumeroProveedor { get; set; }

        [StringLength(100)]
        public string NombreProveedor { get; set; }

        [StringLength(50)]
        public string NumeroNC { get; set; }

        public DateTime? FechaNC { get; set; }

        [Column(TypeName = "money")]
        public decimal? ncImporte { get; set; }

        [Column(TypeName = "money")]
        public decimal? ncIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? ncISR { get; set; }

        [Column(TypeName = "money")]
        public decimal? ncRetencionIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? ncDescuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? ncTotal { get; set; }

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
