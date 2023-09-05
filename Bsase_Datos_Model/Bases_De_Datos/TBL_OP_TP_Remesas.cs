namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_OP_TP_Remesas
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string fechaPago { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string remesa { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string estatusFactura { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int facturas { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "money")]
        public decimal importe { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "money")]
        public decimal total { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "money")]
        public decimal totalFactura { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime finsert { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int estatus { get; set; }
    }
}
