namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SeguimientoProcesos
    {
        public int Id { get; set; }

        public int ProcesoId { get; set; }

        public int Identificador { get; set; }

        public int EstatusOrigenId { get; set; }

        public int EstatusDestinoId { get; set; }

        public DateTime FechaEntrada { get; set; }

        public DateTime? FechaSalida { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioOrigen { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuarioDestino { get; set; }

        [Required]
        [StringLength(500)]
        public string Observaciones { get; set; }

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
