namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SamiZona")]
    public partial class SamiZona
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodZona { get; set; }

        [Required]
        [StringLength(50)]
        public string Zona { get; set; }

        public double BaseQuirurgica { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        public DateTime fechaActualizacion { get; set; }
    }
}
