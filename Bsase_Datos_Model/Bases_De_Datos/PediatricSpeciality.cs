namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PediatricSpeciality")]
    public partial class PediatricSpeciality
    {
        public int Id { get; set; }

        [Required]
        [StringLength(4)]
        public string Code { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public bool Active { get; set; }
    }
}
