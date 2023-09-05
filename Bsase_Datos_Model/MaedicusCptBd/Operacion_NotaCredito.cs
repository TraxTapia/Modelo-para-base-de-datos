namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operacion_NotaCredito
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        public double importe { get; set; }

        public double iva { get; set; }

        public double isr { get; set; }

        public double retiva { get; set; }

        public double? impCedular { get; set; }

        public double total { get; set; }

        [StringLength(100)]
        public string SegLogin { get; set; }

        public DateTime? FechaCaptura { get; set; }

        public int IDOperacion { get; set; }

        public int SecuenciaMacFactura { get; set; }

        [StringLength(1000)]
        public string Observaciones { get; set; }

        public bool? NotaVirtual { get; set; }
    }
}
