namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("motivov")]
    public partial class motivov
    {
        [Key]
        [StringLength(10)]
        public string CodMotivoLlamada { get; set; }

        [StringLength(50)]
        public string MotivoLlamada { get; set; }
    }
}
