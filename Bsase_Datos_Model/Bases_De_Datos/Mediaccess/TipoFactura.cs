namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoFactura")]
    public partial class TipoFactura
    {
        [Key]
        [StringLength(20)]
        public string CodTipoFactura { get; set; }

        [Column("TipoFactura")]
        [StringLength(50)]
        public string TipoFactura1 { get; set; }
    }
}
