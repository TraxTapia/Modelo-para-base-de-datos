namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIE10
    {
        [Key]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [Required]
        [StringLength(255)]
        public string diagnostico { get; set; }
    }
}
