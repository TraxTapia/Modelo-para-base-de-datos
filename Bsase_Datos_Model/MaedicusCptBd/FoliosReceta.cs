namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoliosReceta")]
    public partial class FoliosReceta
    {
        [Key]
        [StringLength(50)]
        public string FolioReceta { get; set; }

        public int? ClaveProveedor { get; set; }

        public decimal PrecioMac { get; set; }

        [Required]
        [StringLength(250)]
        public string Concepto { get; set; }

        public decimal Copago { get; set; }

        [Required]
        [StringLength(20)]
        public string Cpt { get; set; }
    }
}
