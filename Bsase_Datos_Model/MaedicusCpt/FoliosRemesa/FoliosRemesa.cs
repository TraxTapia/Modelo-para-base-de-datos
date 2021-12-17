namespace Bsase_Datos_Model.MaedicusCpt.FoliosRemesa
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoliosRemesa")]
    public partial class FoliosRemesa
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FolioRemesa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FolioRecta { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}
