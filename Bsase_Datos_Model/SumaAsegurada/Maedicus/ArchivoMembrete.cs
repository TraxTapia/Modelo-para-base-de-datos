namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArchivoMembrete")]
    public partial class ArchivoMembrete
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Agrupacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Membrete { get; set; }

        [Required]
        [StringLength(50)]
        public string ReporteCredencial { get; set; }

        public bool Activo { get; set; }
    }
}
