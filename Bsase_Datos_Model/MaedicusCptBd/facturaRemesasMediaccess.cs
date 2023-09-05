namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("facturaRemesasMediaccess")]
    public partial class facturaRemesasMediaccess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idFacturacion { get; set; }

        [StringLength(10)]
        public string serie { get; set; }

        [StringLength(10)]
        public string cve_empresa { get; set; }

        public int? idTipoEmpleado { get; set; }

        [StringLength(50)]
        public string factura { get; set; }

        public DateTime? fechaFactura { get; set; }

        [StringLength(10)]
        public string codEstatusFactura { get; set; }

        [StringLength(10)]
        public string usrGenero { get; set; }

        public DateTime? fechaGeneracion { get; set; }

        public double? importe { get; set; }

        public double? iva { get; set; }

        public double? isr { get; set; }

        public double? retIva { get; set; }

        public double? impCedular { get; set; }

        public double? total { get; set; }

        [Column(TypeName = "xml")]
        public string xml { get; set; }
    }
}
