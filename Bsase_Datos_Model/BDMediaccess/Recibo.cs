namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.Recibo")]
    public partial class Recibo
    {
        [Key]
        [Column("Recibo", Order = 0)]
        [StringLength(20)]
        public string Recibo1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FechaRecibo { get; set; }

        public DateTime? FechaPago { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Importe { get; set; }

        [Key]
        [Column(Order = 4)]
        public double IVA { get; set; }

        [Key]
        [Column(Order = 5)]
        public double Total { get; set; }
    }
}
