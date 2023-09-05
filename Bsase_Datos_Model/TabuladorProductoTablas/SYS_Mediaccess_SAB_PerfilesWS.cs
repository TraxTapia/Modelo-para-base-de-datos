namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediaccess_SAB_PerfilesWS
    {
        [Key]
        public int IdPerfilWS { get; set; }

        [StringLength(100)]
        public string DscPerfil { get; set; }
    }
}
