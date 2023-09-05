namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogCalculoReservaProveedor")]
    public partial class LogCalculoReservaProveedor
    {
        [Key]
        public int IdLog { get; set; }

        public int IdReserva { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
