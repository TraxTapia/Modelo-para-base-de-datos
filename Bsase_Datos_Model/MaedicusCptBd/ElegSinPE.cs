namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElegSinPE")]
    public partial class ElegSinPE
    {
        [Key]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }
    }
}
