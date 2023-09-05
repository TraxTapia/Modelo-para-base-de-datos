namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlanProductoAdssyf_Log
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanCode { get; set; }

        public int TypeMovement_Id { get; set; }

        public virtual TypeMovementPlanProducto TypeMovementPlanProducto { get; set; }
    }
}
