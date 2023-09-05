namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remesas
    {
        [Key]
        [StringLength(50)]
        public string FolioRemesa { get; set; }

        public int? IdEstatusRemesa { get; set; }

        public int? IdTipoRemesa { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public bool? Activo { get; set; }

        public virtual EstatusRemesas EstatusRemesas { get; set; }

        public virtual TipoRemesa TipoRemesa { get; set; }
    }
}
