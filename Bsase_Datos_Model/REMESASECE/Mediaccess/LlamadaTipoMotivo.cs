namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LlamadaTipoMotivo")]
    public partial class LlamadaTipoMotivo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodTipoLlamada { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodMotivoLlamada { get; set; }
    }
}
