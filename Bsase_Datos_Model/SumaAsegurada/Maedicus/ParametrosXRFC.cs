namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParametrosXRFC")]
    public partial class ParametrosXRFC
    {
        public int id { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        public int? diasAdicionales { get; set; }

        [StringLength(8000)]
        public string notificacion { get; set; }
    }
}
