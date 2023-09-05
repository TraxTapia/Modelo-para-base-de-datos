namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MetodoPago")]
    public partial class MetodoPago
    {
        [Key]
        [StringLength(10)]
        public string CodMetodoPago { get; set; }

        [Column("MetodoPago")]
        [StringLength(50)]
        public string MetodoPago1 { get; set; }
    }
}
