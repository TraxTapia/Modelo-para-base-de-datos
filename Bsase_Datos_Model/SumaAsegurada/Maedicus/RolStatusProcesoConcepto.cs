namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolStatusProcesoConcepto")]
    public partial class RolStatusProcesoConcepto
    {
        public int id { get; set; }

        public int idStatusProcesoConcepto { get; set; }

        public int idRol { get; set; }

        public bool estatus { get; set; }

        public virtual StatusProcesoConcepto StatusProcesoConcepto { get; set; }
    }
}
