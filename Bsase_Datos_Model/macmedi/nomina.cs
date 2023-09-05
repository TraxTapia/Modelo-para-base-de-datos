namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.nomina")]
    public partial class nomina
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string People { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string SIP { get; set; }
    }
}
