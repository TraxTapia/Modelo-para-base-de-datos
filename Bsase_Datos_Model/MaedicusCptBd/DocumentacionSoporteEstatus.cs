namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DocumentacionSoporteEstatus
    {
        public int Id { get; set; }

        public int SoporteId { get; set; }

        public int EstatusId { get; set; }

        public int DocumentacionSoporteId { get; set; }

        public int MotivoRechazoId { get; set; }

        [Required]
        [StringLength(1000)]
        public string MotivoRechazo { get; set; }

        [Required]
        [StringLength(1000)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public bool? Activo { get; set; }
    }
}
