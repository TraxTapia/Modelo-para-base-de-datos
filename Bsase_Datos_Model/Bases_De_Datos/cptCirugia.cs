namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cptCirugia")]
    public partial class cptCirugia
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CPT { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string DescripcionCorta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string DescripcionLarga { get; set; }

        public double? Porcentaje { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string Lugar { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string CodEstatus { get; set; }
    }
}
