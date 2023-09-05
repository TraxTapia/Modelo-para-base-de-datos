namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aseguradoras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodAseguradora { get; set; }

        [Required]
        [StringLength(50)]
        public string Aseguragora { get; set; }
    }
}
