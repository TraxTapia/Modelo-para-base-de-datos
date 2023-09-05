namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanProductoAdssyf")]
    public partial class PlanProductoAdssyf
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroRegistroCondusef { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionPlan { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanCob { get; set; }

        public DateTime FechaInicioVigencia { get; set; }

        public DateTime FechaIngresoRegistro { get; set; }

        [Required]
        [StringLength(50)]
        public string IdTipoSeg { get; set; }

        [StringLength(100)]
        public string NUMAUTORTIPSEG { get; set; }
    }
}
