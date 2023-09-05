namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sami_TB_FacturaXMLP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Proveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string N_Factura { get; set; }

        public string N_Folio { get; set; }

        public string RFC_Emisor { get; set; }

        public string RFC_Receptor { get; set; }

        [StringLength(255)]
        public string XML_uuid { get; set; }

        [StringLength(255)]
        public string Uuid { get; set; }

        public string F_Factura { get; set; }

        public string Importe { get; set; }

        public string Iva { get; set; }

        public string Isr { get; set; }

        public string Ivaret { get; set; }

        public string Imcd { get; set; }

        public string Total { get; set; }

        [Column(TypeName = "text")]
        public string A_Xml { get; set; }

        public string A_pdf { get; set; }

        public DateTime? F_Insert { get; set; }

        [StringLength(50)]
        public string Xusrinsert { get; set; }

        [StringLength(50)]
        public string Xusrupdate { get; set; }

        [StringLength(50)]
        public string serie { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }
    }
}
