namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolizaCorreosEnvio")]
    public partial class PolizaCorreosEnvio
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string PolizaRenovacion { get; set; }

        [Required]
        [StringLength(255)]
        public string MailContratante { get; set; }

        [Required]
        [StringLength(255)]
        public string MailAgente { get; set; }

        [Required]
        [StringLength(255)]
        public string MailPromotor { get; set; }

        [Required]
        [StringLength(255)]
        public string MailEjecutivo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}
