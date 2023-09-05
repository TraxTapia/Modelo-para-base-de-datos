namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Error_Log_SQL
    {
        [Key]
        public int Id_Log { get; set; }

        public DateTime? FechaHora { get; set; }

        public int? Numero { get; set; }

        public int? Severidad { get; set; }

        public int? Estado { get; set; }

        [StringLength(50)]
        public string Procedimiento { get; set; }

        public int? Linea { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }
    }
}
