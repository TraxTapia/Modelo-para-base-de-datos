namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dhx")]
    public partial class dhx
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string codestatus { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        public DateTime? FechaInicioServicio { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        public DateTime? FechaCargaMediaccess { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        public int? CodEstadoCivil { get; set; }

        public int? CodPeriodo { get; set; }

        [StringLength(2)]
        public string DiaSemanaCorte { get; set; }

        public int? DiaMesCorte { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(25)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string CodEstatusImpresion { get; set; }

        [StringLength(20)]
        public string CodVendedor { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(2)]
        public string CodViaCarga { get; set; }

        [StringLength(1)]
        public string CodSeguro { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        public int? codGrupo { get; set; }

        public int? codPlan { get; set; }

        [StringLength(50)]
        public string tipoEmpleado { get; set; }

        [StringLength(50)]
        public string centroCostos { get; set; }

        [StringLength(10)]
        public string CodProductoAux { get; set; }

        public int? codPymeColectivo { get; set; }

        public int? codVip { get; set; }

        [StringLength(50)]
        public string Poliza { get; set; }

        public DateTime? FechaAntiguedad { get; set; }

        [StringLength(5)]
        public string codaseguradora { get; set; }
    }
}
