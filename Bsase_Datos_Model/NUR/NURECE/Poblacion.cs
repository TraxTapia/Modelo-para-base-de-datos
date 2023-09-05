namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Poblacion")]
    public partial class Poblacion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodPoblacion { get; set; }

        [StringLength(10)]
        public string CodZona { get; set; }

        [Column("Poblacion")]
        [StringLength(50)]
        public string Poblacion1 { get; set; }

        public int? CodPob { get; set; }
    }
}
