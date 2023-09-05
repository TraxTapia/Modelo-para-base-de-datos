namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediacces_EstadoCuenta_Agrupa
    {
        [Key]
        [Column(Order = 0)]
        public int CodSelect { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(600)]
        public string Nombre { get; set; }
    }
}
