namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class operacion_notacredito_log
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        [Key]
        [Column(Order = 2)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 3)]
        public double iva { get; set; }

        [Key]
        [Column(Order = 4)]
        public double isr { get; set; }

        [Key]
        [Column(Order = 5)]
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 6)]
        public double total { get; set; }

        [StringLength(100)]
        public string SegLogin { get; set; }

        public DateTime? FechaCaptura { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDOperacion { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMacFactura { get; set; }

        [StringLength(1000)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime f_proceso { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string usuarioP { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(800)]
        public string Comentario { get; set; }
    }
}
