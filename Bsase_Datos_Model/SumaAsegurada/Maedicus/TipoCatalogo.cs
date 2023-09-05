namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoCatalogo")]
    public partial class TipoCatalogo
    {
        [Key]
        public int IdTipoCatalogo { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreTipoCatalogo { get; set; }
    }
}
