namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Poblacion_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodPoblacion { get; set; }

        [StringLength(10)]
        public string CodZona { get; set; }

        [StringLength(50)]
        public string Poblacion { get; set; }

        public int? CodPob { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string xuserinsert { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime fechaMovimiento { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(29)]
        public string evento { get; set; }
    }
}
