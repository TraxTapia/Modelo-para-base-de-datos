namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiagnosisCode")]
    public partial class DiagnosisCode
    {
        public int Id { get; set; }

        [Required]
        [StringLength(5)]
        public string Code { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public bool Visible { get; set; }
    }
}
