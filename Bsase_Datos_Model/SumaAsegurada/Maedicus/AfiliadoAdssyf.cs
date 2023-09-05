namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AfiliadoAdssyf")]
    public partial class AfiliadoAdssyf
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int CodEmpresa { get; set; }

        public int? Correlativo { get; set; }

        [Required]
        [StringLength(50)]
        public string IdPoliza { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroPolizaUnico { get; set; }

        public int CodAsegurado { get; set; }

        [StringLength(50)]
        public string IdExterno { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoMaterno { get; set; }

        public DateTime FechaInicioVigenciaPoliza { get; set; }

        public DateTime FechaFinVigenciaPoliza { get; set; }

        public DateTime FechaEmision { get; set; }

        public DateTime? FechaAnulacionPoliza { get; set; }

        public DateTime? FechaCancelacion { get; set; }

        [Required]
        [StringLength(5)]
        public string StsPoliza { get; set; }

        [Required]
        [StringLength(10)]
        public string IdTipoSeguro { get; set; }

        [StringLength(30)]
        public string CodAgente { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [StringLength(2)]
        public string Genero { get; set; }

        [Required]
        [StringLength(50)]
        public string PlanCoberturas { get; set; }

        public int CodCia { get; set; }

        public int NumeroRenovacion { get; set; }

        public int Certificado { get; set; }

        [Required]
        [StringLength(25)]
        public string EstadoPlan { get; set; }

        [StringLength(100)]
        public string NOMBRECLIENTE { get; set; }

        public DateTime? InicioVigenciaAfiliado { get; set; }

        public DateTime? FinVigenciaAfiliado { get; set; }

        [StringLength(30)]
        public string CODPARENT { get; set; }
    }
}
