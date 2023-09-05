namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NotificacionDiagnostico")]
    public partial class NotificacionDiagnostico
    {
        [Key]
        [StringLength(10)]
        public string cveCie { get; set; }

        public int statusValidacion { get; set; }

        [StringLength(50)]
        public string Mensaje { get; set; }
    }
}
