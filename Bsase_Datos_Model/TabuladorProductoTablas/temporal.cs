namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.temporal")]
    public partial class temporal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string codcuenta { get; set; }

        [StringLength(10)]
        public string fecha { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string xusrinsert { get; set; }

        public int? Elegibilidades { get; set; }
    }
}
