namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.PasoBrigadas")]
    public partial class PasoBrigadas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Glucosa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Colesterol { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Trigliceridos { get; set; }
    }
}
