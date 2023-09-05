namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("subEspecialidad")]
    public partial class subEspecialidad
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodSubEspecialidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [Column("SubEspecialidad")]
        [StringLength(50)]
        public string SubEspecialidad1 { get; set; }
    }
}
