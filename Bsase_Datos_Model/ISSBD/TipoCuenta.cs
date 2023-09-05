namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoCuenta")]
    public partial class TipoCuenta
    {
        [Key]
        [StringLength(10)]
        public string CodTipoCuenta { get; set; }

        [Column("TipoCuenta")]
        [StringLength(50)]
        public string TipoCuenta1 { get; set; }
    }
}
