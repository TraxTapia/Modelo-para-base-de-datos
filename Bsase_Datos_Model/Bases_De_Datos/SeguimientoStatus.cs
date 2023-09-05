namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SeguimientoStatus
    {
        [Key]
        public int idSeguimientoStatus { get; set; }

        public int secuenciaMac { get; set; }

        [Required]
        [StringLength(50)]
        public string remesa { get; set; }

        [Required]
        [StringLength(10)]
        public string statusConceptos { get; set; }

        public DateTime fecha { get; set; }
    }
}
