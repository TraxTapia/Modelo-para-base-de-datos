namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Remesa
    {
        [Key]
        [StringLength(1)]
        public string CodStatusRemesa { get; set; }

        [StringLength(50)]
        public string StatusRemesa { get; set; }
    }
}
