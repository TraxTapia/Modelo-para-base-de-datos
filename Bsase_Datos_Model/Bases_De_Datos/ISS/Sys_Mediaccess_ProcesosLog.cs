namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_ProcesosLog
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Proceso { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Comentario { get; set; }

        public string MsgError { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fecha { get; set; }
    }
}
