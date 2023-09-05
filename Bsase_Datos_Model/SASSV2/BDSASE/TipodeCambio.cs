namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipodeCambio")]
    public partial class TipodeCambio
    {
        [Key]
        public int IdTipodeCambio { get; set; }

        [StringLength(3)]
        public string CveMoneda { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha { get; set; }

        public decimal? Monto { get; set; }

        public bool Activo { get; set; }

        public virtual Moneda Moneda { get; set; }
    }
}
