namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diagnostico")]
    public partial class Diagnostico
    {
        [Key]
        [StringLength(5)]
        public string CodDiagnostico { get; set; }

        [Column("Diagnostico")]
        [Required]
        [StringLength(255)]
        public string Diagnostico1 { get; set; }
    }
}
