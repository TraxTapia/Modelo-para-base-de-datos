namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_ParametrosXRFC
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int diasAdicionales { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string notificacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string segLogin { get; set; }

        [StringLength(50)]
        public string tipoMovimiento { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime fecha_movimiento { get; set; }
    }
}
