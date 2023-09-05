namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SustitucionDeFactura")]
    public partial class SustitucionDeFactura
    {
        public int id { get; set; }

        [StringLength(100)]
        public string segLogin { get; set; }

        public int secuenciaMac { get; set; }

        [Required]
        [StringLength(40)]
        public string datoRelacion { get; set; }

        [StringLength(10)]
        public string tipo { get; set; }

        [Required]
        [StringLength(500)]
        public string sustituyeA { get; set; }

        [Required]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Required]
        [StringLength(500)]
        public string observaciones { get; set; }

        public DateTime created_at { get; set; }
    }
}
