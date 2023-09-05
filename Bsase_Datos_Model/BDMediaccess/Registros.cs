namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.Registros")]
    public partial class Registros
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string People { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Sip2000 { get; set; }
    }
}
