namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Procedimiento")]
    public partial class Procedimiento
    {
        [Key]
        [StringLength(10)]
        public string CodProcedimiento { get; set; }

        [Column("Procedimiento")]
        [StringLength(255)]
        public string Procedimiento1 { get; set; }
    }
}
