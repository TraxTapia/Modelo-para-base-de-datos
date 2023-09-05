namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pendiente")]
    public partial class Pendiente
    {
        [Key]
        [StringLength(5)]
        public string CodPendiente { get; set; }

        [Required]
        [StringLength(100)]
        public string Concepto { get; set; }
    }
}
