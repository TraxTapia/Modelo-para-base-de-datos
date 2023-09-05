namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlanProducto_12_11_2021
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ClavePlanSicas { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ClaveProductoSicas { get; set; }

        [StringLength(50)]
        public string ClavePlanMac { get; set; }

        [StringLength(50)]
        public string ClaveProductoMac { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string DescripcionSicas { get; set; }

        [StringLength(50)]
        public string DescripcionMAc { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string AgrupacionCG { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaIngreso { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaInicioVigencia { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Activo { get; set; }
    }
}
