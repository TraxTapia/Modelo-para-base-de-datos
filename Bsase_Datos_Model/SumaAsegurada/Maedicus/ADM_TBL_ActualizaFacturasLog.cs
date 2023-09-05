namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADM_TBL_ActualizaFacturasLog
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Archivo { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Finsert { get; set; }

        public int? Actualizadas { get; set; }

        public int? Rechazos { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }
    }
}
