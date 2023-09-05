namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatLocalidades
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string cve_ent { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string cve_mun { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string cve_loc { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string nom_loc { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal lat_decimal { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal lon_decimal { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string altitud { get; set; }
    }
}
