namespace Bsase_Datos_Model.MaedicusCpt.ejemplorelacion
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
        [StringLength(250)]
        public string FolioRemesa { get; set; }

        [Required]
        [StringLength(250)]
        public string FolioReceta { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual FoliosReceta FoliosReceta { get; set; }
    }
}
