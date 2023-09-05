namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaseEmpresa")]
    public partial class CaseEmpresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreFiscal { get; set; }

        [Required]
        [StringLength(15)]
        public string RFC { get; set; }

        [Required]
        [StringLength(100)]
        public string Responsable { get; set; }

        public DateTime FechaInicioServicio { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        public int DiasCredito { get; set; }

        [Required]
        [StringLength(2)]
        public string DiaSemanaCorte { get; set; }

        public int DiaMesCorte { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusEmpresa { get; set; }

        [Required]
        [StringLength(15)]
        public string CodProducto { get; set; }

        public int CodRed { get; set; }

        public int CodPeriodo { get; set; }

        public int CodCampania { get; set; }

        public int NumeroBeneficiarios { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Observacion { get; set; }

        [Required]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codPlan { get; set; }

        public int? CodTabulador { get; set; }

        public int? ValidacionArchivoPor { get; set; }
    }
}
