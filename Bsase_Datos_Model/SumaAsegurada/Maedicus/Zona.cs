namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zona")]
    public partial class Zona
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodZona { get; set; }

        [Column("Zona")]
        [Required]
        [StringLength(50)]
        public string Zona1 { get; set; }

        public double BaseQuirurgica { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }
    }
}
