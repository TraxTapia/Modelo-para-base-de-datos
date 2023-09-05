namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_Factura_Remesas_Devueltas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Remesa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string Cve_prov { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 5)]
        public double Total { get; set; }

        [StringLength(100)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "date")]
        public DateTime F_Devuelta { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
