namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoDevolucion")]
    public partial class MotivoDevolucion
    {
        [Key]
        [StringLength(10)]
        public string CodMotivoDevolucion { get; set; }

        [Column("MotivoDevolucion")]
        [StringLength(100)]
        public string MotivoDevolucion1 { get; set; }
    }
}
