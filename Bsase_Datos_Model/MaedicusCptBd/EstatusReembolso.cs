namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusReembolso")]
    public partial class EstatusReembolso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public bool Activo { get; set; }
    }
}
