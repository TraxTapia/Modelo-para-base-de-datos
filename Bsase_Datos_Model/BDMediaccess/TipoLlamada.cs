namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoLlamada")]
    public partial class TipoLlamada
    {
        [Key]
        [StringLength(10)]
        public string CodTipoLlamada { get; set; }

        [Column("TipoLlamada")]
        [StringLength(50)]
        public string TipoLlamada1 { get; set; }
    }
}
