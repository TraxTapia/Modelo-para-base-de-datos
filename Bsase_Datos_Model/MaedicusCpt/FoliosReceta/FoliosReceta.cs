namespace Bsase_Datos_Model.MaedicusCpt.FoliosReceta
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
    }
}
