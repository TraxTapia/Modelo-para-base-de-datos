namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Devolucion")]
    public partial class Devolucion
    {
        [Key]
        [StringLength(5)]
        public string CodDevolucion { get; set; }

        [Required]
        [StringLength(60)]
        public string Concepto { get; set; }
    }
}
