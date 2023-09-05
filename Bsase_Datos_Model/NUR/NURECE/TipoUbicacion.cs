namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoUbicacion")]
    public partial class TipoUbicacion
    {
        [Key]
        [StringLength(10)]
        public string CodTipoUbicacion { get; set; }

        [Column("TipoUbicacion")]
        [StringLength(50)]
        public string TipoUbicacion1 { get; set; }
    }
}
