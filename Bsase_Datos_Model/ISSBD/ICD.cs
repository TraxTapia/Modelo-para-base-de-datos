namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ICD")]
    public partial class ICD
    {
        [Key]
        [Column("ICD")]
        [StringLength(5)]
        public string ICD1 { get; set; }

        [Required]
        [StringLength(255)]
        public string Diagnostico { get; set; }
    }
}
