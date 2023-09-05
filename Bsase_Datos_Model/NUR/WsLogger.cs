namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WsLogger")]
    public partial class WsLogger
    {
        [Key]
        public int IdLog { get; set; }

        [StringLength(200)]
        public string WebService { get; set; }

        public DateTime FechaEjecucion { get; set; }

        [Required]
        [StringLength(500)]
        public string Mensaje { get; set; }
    }
}
