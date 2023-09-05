namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolizaAdssyf")]
    public partial class PolizaAdssyf
    {
        public int Id { get; set; }

        public int IdPoliza { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroPolizaUnico { get; set; }

        public DateTime FechaEmision { get; set; }

        public int ICodSucursal { get; set; }

        public DateTime FechaInicioVigencia { get; set; }

        public DateTime FechaFinVigencia { get; set; }

        public DateTime FechaAnulacion { get; set; }

        public DateTime FechaCancelacion { get; set; }

        [Required]
        [StringLength(10)]
        public string StsPoliza { get; set; }

        [Required]
        [StringLength(200)]
        public string DescripcionPoliza { get; set; }

        public int NumeroRenovacion { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAgente { get; set; }

        public int CodCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoPaternoCliente { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoMaternoCliente { get; set; }

        [Required]
        [StringLength(20)]
        public string IdTipoSeguro { get; set; }

        [StringLength(100)]
        public string DescripcionPlan { get; set; }

        [StringLength(100)]
        public string NUMAUTORTIPSEG { get; set; }

        [StringLength(100)]
        public string NumeroRegistroCondusef { get; set; }

        public DateTime? FechaIngresoRegistro { get; set; }

        public DateTime? FechaInicioVigenciaRegistro { get; set; }

        [StringLength(30)]
        public string CODRAMO { get; set; }

        public DateTime? FECSOLICITUD { get; set; }

        public DateTime? FECRENOVACION { get; set; }

        public DateTime? FECSTS { get; set; }

        [StringLength(50)]
        public string MOTIVANUL { get; set; }
    }
}
