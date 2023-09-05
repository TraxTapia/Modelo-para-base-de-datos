namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SolicitudReembolso")]
    public partial class SolicitudReembolso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Folio { get; set; }

        public int TipoReembolsoId { get; set; }

        public int ReembolsoRelacionadoId { get; set; }

        public int EstatusId { get; set; }

        [Required]
        [StringLength(25)]
        public string AfiliadoId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nombre { get; set; }

        [StringLength(10)]
        public string PolizaId { get; set; }

        public DateTime FechaOcurrido { get; set; }

        public DateTime InicioVigencia { get; set; }

        public DateTime FinVigencia { get; set; }

        public DateTime FechaSolicitud { get; set; }

        public DateTime FechaIngreso { get; set; }

        [Required]
        [StringLength(255)]
        public string EMail { get; set; }

        [Required]
        [StringLength(125)]
        public string CLABE { get; set; }

        public decimal MontoReclamado { get; set; }

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

        public int MotivoReclamacionId { get; set; }

        public decimal MontoPagado { get; set; }

        [Required]
        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [Required]
        [StringLength(10)]
        public string SubCodEspecialidad { get; set; }

        public bool? Activo { get; set; }

        [Required]
        [StringLength(150)]
        public string ManagedKey { get; set; }

        [Required]
        [StringLength(150)]
        public string ManagedIV { get; set; }

        [Required]
        [StringLength(150)]
        public string FolioCallCenter { get; set; }
    }
}
