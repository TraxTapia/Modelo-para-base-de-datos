namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class XML_SistemaProveedores
    {
        [Key]
        [Column(Order = 0)]
        public int ident { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ArchivoXML { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [StringLength(20)]
        public string serie { get; set; }

        [StringLength(100)]
        public string uuid { get; set; }

        [StringLength(20)]
        public string RFCEmisor { get; set; }

        [StringLength(50)]
        public string FechaFactura { get; set; }

        [StringLength(50)]
        public string subtotal { get; set; }

        [StringLength(20)]
        public string iva { get; set; }

        [StringLength(20)]
        public string total { get; set; }

        [StringLength(10)]
        public string proveedor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaInsert { get; set; }
    }
}
