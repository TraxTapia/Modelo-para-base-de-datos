namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogHistoricoTabuladores
    {
        [Key]
        public int IdLog { get; set; }

        public int IdTabuladorConsulta { get; set; }

        public decimal Monto { get; set; }

        [Required]
        [StringLength(100)]
        public string Usuario { get; set; }

        public DateTime Fecha { get; set; }
    }
}
