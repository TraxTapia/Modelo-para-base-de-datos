namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorFarmacia")]
    public partial class TabuladorFarmacia
    {
        [Key]
        [StringLength(20)]
        public string CodigoEAN { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        public double PMP { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatus { get; set; }
    }
}
