namespace Bsase_Datos_Model.MaedicusCpt.ECEREMESAS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusFactura")]
    public partial class EstatusFactura
    {
        [Key]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Column("EstatusFactura")]
        [Required]
        [StringLength(50)]
        public string EstatusFactura1 { get; set; }
    }
}
