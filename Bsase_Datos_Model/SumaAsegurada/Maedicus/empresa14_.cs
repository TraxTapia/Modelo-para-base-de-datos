namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empresa14#")]
    public partial class empresa14_
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NombreEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string NombreFiscal { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Responsable { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaInicioServicio { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiasCredito { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string DiaSemanaCorte { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DiaMesCorte { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(1)]
        public string CodEstatusEmpresa { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(15)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPeriodo { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCampania { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroBeneficiarios { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "text")]
        public string Observacion { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [Key]
        [Column(Order = 17)]
        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? codPlan { get; set; }

        public int? CodTabulador { get; set; }

        public int? ValidacionArchivoPor { get; set; }
    }
}
