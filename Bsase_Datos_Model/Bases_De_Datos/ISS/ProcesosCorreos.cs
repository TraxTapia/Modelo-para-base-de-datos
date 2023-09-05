namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProcesosCorreos
    {
        [Key]
        [Column(Order = 0)]
        public int idProceso { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Proceso { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string Descripcion { get; set; }
    }
}
