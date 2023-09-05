namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Observations
    {
        public int Id { get; set; }

        public int Operation_Id { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Observation { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
