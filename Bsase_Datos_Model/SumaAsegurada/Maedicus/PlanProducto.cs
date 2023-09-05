namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanProducto")]
    public partial class PlanProducto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ClavePlanSicas { get; set; }

        [Required]
        [StringLength(50)]
        public string ClaveProductoSicas { get; set; }

        [StringLength(50)]
        public string ClavePlanMac { get; set; }

        [StringLength(50)]
        public string ClaveProductoMac { get; set; }

        [Required]
        [StringLength(50)]
        public string DescripcionSicas { get; set; }

        [StringLength(60)]
        public string DescripcionMAc { get; set; }

        [Required]
        [StringLength(50)]
        public string AgrupacionCG { get; set; }

        public DateTime FechaIngreso { get; set; }

        public DateTime FechaInicioVigencia { get; set; }

        public bool Activo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}
