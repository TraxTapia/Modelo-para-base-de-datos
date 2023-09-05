namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class migrations
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string migration { get; set; }

        public int batch { get; set; }
    }
}
