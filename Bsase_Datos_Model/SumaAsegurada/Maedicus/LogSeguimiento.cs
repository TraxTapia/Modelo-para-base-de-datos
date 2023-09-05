namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogSeguimiento")]
    public partial class LogSeguimiento
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(200)]
        public string Ruta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(800)]
        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Created { get; set; }
    }
}
