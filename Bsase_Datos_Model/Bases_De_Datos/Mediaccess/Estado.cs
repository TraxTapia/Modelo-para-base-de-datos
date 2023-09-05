namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estado")]
    public partial class Estado
    {
        [Key]
        [StringLength(10)]
        public string CodEstado { get; set; }

        [Column("Estado")]
        [StringLength(50)]
        public string Estado1 { get; set; }

        [StringLength(10)]
        public string codhsbc { get; set; }

        public double? latitud { get; set; }

        public double? longitud { get; set; }
    }
}
