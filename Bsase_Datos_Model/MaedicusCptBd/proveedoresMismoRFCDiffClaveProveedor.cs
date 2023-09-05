namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("proveedoresMismoRFCDiffClaveProveedor")]
    public partial class proveedoresMismoRFCDiffClaveProveedor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string rfc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string estatus { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime fecha { get; set; }
    }
}
