namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log_Parametros
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int diasAdicionales { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string mensaje { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string segLogin { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime created_at { get; set; }
    }
}
