namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Autorizacion_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string UsuarioModif { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FechaSolicitud { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaProceso { get; set; }
    }
}
