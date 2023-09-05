namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AutorizacionesCE")]
    public partial class AutorizacionesCE
    {
        [StringLength(255)]
        public string nombrecompleto { get; set; }

        [StringLength(302)]
        public string paciente { get; set; }

        [StringLength(50)]
        public string parentesco { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(203)]
        public string nombreempresa { get; set; }

        [StringLength(255)]
        public string Diag1 { get; set; }

        [StringLength(255)]
        public string Diag2 { get; set; }

        [StringLength(255)]
        public string Diag3 { get; set; }

        [StringLength(255)]
        public string Diag4 { get; set; }

        [StringLength(255)]
        public string especialidad { get; set; }

        [StringLength(50)]
        public string poliza { get; set; }

        [StringLength(29)]
        public string copago_en { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string producto { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CodCuenta { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodFarmacia { get; set; }

        public int? CodEmpresa { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [StringLength(10)]
        public string CodDiagnostico { get; set; }

        [StringLength(10)]
        public string CodDiagnostico2 { get; set; }

        [StringLength(10)]
        public string CodDiagnostico3 { get; set; }

        [StringLength(10)]
        public string CodDiagnostico4 { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(1)]
        public string DigChk { get; set; }

        public int? IdMedicoTratante { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        [StringLength(100)]
        public string NombrePacienteExt { get; set; }

        [StringLength(100)]
        public string APaternoPacienteExt { get; set; }

        [StringLength(100)]
        public string AMaternoPacienteExt { get; set; }

        public bool? EnFactura { get; set; }

        [StringLength(20)]
        public string AutorizacionLab { get; set; }

        [StringLength(20)]
        public string Autorizacion2 { get; set; }

        [StringLength(20)]
        public string Autorizacion4to { get; set; }

        [StringLength(20)]
        public string AutorizacionEsp { get; set; }

        public DateTime? xDateInsert { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? CodEstatus { get; set; }

        public int? CodDetalle { get; set; }

        [StringLength(50)]
        public string Cpt { get; set; }

        [StringLength(10)]
        public string CodTabulador { get; set; }

        public int? Cantidad { get; set; }

        public double? PU { get; set; }

        public double? Total { get; set; }

        [StringLength(8000)]
        public string Indicaciones { get; set; }

        public bool? PagadoFacturado { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "image")]
        public byte[] CodigoBarras { get; set; }
    }
}
