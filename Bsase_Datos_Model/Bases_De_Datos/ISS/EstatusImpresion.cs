namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusImpresion")]
    public partial class EstatusImpresion
    {
        [Key]
        [StringLength(1)]
        public string CodEstatusImpresion { get; set; }

        [Column("EstatusImpresion")]
        [Required]
        [StringLength(25)]
        public string EstatusImpresion1 { get; set; }
    }
}
