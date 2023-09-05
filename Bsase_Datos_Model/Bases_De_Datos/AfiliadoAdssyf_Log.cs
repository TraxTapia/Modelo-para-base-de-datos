namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AfiliadoAdssyf_Log
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public int AfiliadoAdssyf_Id { get; set; }

        public int TypeMovement_Id { get; set; }
    }
}
