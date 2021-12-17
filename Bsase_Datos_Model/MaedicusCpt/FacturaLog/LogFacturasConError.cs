namespace Bsase_Datos_Model.MaedicusCpt.FacturaLog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogFacturasConError")]
    public partial class LogFacturasConError
    {
        [Key]
        public int IdErrorFactura { get; set; }

        [Required]
        [StringLength(100)]
        public string UUID { get; set; }

        public DateTime FechaAltaError { get; set; }

        public bool? Activo { get; set; }
    }
}
