namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConsultaElectronicaHSA")]
    public partial class ConsultaElectronicaHSA
    {
        [Required]
        [StringLength(50)]
        public string CodCuenta { get; set; }

        public int CodFarmacia { get; set; }

        public int? CodEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

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
    }
}
