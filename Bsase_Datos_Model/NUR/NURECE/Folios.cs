namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodFolio { get; set; }

        public int? CodFactura { get; set; }

        [StringLength(50)]
        public string NumeroFolio { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(50)]
        public string CodTipoArticulo { get; set; }

        public DateTime? FechaFolio { get; set; }

        [StringLength(20)]
        public string PrecioRef { get; set; }

        [Column(TypeName = "money")]
        public decimal? folImporte { get; set; }

        [Column(TypeName = "money")]
        public decimal? folIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? folISR { get; set; }

        [Column(TypeName = "money")]
        public decimal? folRetencionIVA { get; set; }

        [Column(TypeName = "money")]
        public decimal? folDescuento { get; set; }

        [Column(TypeName = "money")]
        public decimal? folTotal { get; set; }

        public int? CodAfiliado { get; set; }

        [StringLength(100)]
        public string NombreAfiliado { get; set; }

        public int? Correlativo { get; set; }

        public int? CodParentesco { get; set; }

        [StringLength(50)]
        public string CodDiagnostico { get; set; }

        [StringLength(50)]
        public string CodProcedimiento { get; set; }

        public int? CodListadoPrecio { get; set; }

        public int? Cantidad { get; set; }

        public DateTime? FechaCaptura { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
