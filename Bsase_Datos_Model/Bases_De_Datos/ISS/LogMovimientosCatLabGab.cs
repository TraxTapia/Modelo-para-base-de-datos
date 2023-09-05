namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogMovimientosCatLabGab")]
    public partial class LogMovimientosCatLabGab
    {
        public int Id { get; set; }

        public int IdCatOriginal { get; set; }

        public int IdCatMovimiento { get; set; }

        public DateTime FechaMovimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }
    }
}
