namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConsultaElectronicaHSA_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodFarmacia { get; set; }

        public int? CodEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 3)]
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
        [Column(Order = 4)]
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

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string xusrinsertLog { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime xdateinsertLog { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(500)]
        public string evento { get; set; }
    }
}
