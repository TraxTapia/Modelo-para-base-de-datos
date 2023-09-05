namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Cambio_Monto_Captura
    {
        public int id { get; set; }

        [StringLength(20)]
        public string cve_empresa { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaAlta { get; set; }

        [StringLength(20)]
        public string UsrAlta { get; set; }

        public DateTime? FechaActualiza { get; set; }

        [StringLength(20)]
        public string UsrActualizacion { get; set; }
    }
}
