namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RecepcionFactura")]
    public partial class RecepcionFactura
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime f_recepcion { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime f_factura { get; set; }

        [Key]
        [Column(Order = 5)]
        public double Importe { get; set; }

        [Key]
        [Column(Order = 6)]
        public double IVA { get; set; }

        [Key]
        [Column(Order = 7)]
        public double ISR { get; set; }

        [Key]
        [Column(Order = 8)]
        public double RetIVA { get; set; }

        [Key]
        [Column(Order = 9)]
        public double Total { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string CodEstatus { get; set; }

        [StringLength(25)]
        public string NoPaquete { get; set; }

        public DateTime? f_envio { get; set; }
    }
}
