namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NivelesdeServicio")]
    public partial class NivelesdeServicio
    {
        public int Id { get; set; }

        public int ProcesoId { get; set; }

        public int EstatusId { get; set; }

        public int TipoId { get; set; }

        public decimal HorasNivelServicio { get; set; }

        public decimal PorcentajeTolerancia { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}
