namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aplicaciones
    {
        [Key]
        public int IdAplicacion { get; set; }

        public int IdArea { get; set; }

        [StringLength(200)]
        public string NombreAplicativo { get; set; }

        [StringLength(500)]
        public string DescripcionAplicativo { get; set; }

        public bool? ABCManual { get; set; }

        public DateTime? FechaAltaAplicativo { get; set; }

        [StringLength(100)]
        public string UsrAltaAplicativo { get; set; }

        public DateTime? FechaBajaAplicativo { get; set; }

        [StringLength(100)]
        public string UsrBajaAplicativo { get; set; }

        public bool StatusAplicativo { get; set; }

        public virtual Aplicaciones Aplicaciones1 { get; set; }

        public virtual Aplicaciones Aplicaciones2 { get; set; }
    }
}
