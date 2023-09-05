namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TypeMovement_AfiliadoAddsyf
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }
    }
}
