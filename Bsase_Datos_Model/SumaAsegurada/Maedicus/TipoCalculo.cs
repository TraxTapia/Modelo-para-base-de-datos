namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoCalculo")]
    public partial class TipoCalculo
    {
        [Key]
        public int IdTipoCalculo { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreTipoCalculo { get; set; }
    }
}
