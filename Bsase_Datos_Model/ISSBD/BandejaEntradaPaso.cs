namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BandejaEntradaPaso")]
    public partial class BandejaEntradaPaso
    {
        [Key]
        public int CodBandeja { get; set; }

        [StringLength(10)]
        public string CodEstatusBandeja { get; set; }

        public int? CodCuenta { get; set; }

        [StringLength(10)]
        public string CodDiagnostico { get; set; }

        [StringLength(10)]
        public string CodProcedimiento1 { get; set; }

        [StringLength(10)]
        public string CodProcedimiento2 { get; set; }

        [StringLength(100)]
        public string QuienLlama { get; set; }

        [StringLength(20)]
        public string NumeroTelefono { get; set; }

        [StringLength(10)]
        public string CodEstado { get; set; }

        [StringLength(10)]
        public string CodPoblacion { get; set; }

        [StringLength(100)]
        public string Autorizacion { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        [StringLength(100)]
        public string CodAfiliado { get; set; }

        [StringLength(10)]
        public string CodEmpresa { get; set; }

        public int? Correlativo { get; set; }

        public int? CodParentesco { get; set; }

        [StringLength(10)]
        public string CodServicio { get; set; }

        public int? DiasIncapacidad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaInicioIncapacidad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaFinIncapacidad { get; set; }

        [StringLength(10)]
        public string CodMotivoLlamada { get; set; }

        [StringLength(10)]
        public string CodMotivoQueja { get; set; }

        [StringLength(20)]
        public string codMotivo { get; set; }

        [StringLength(10)]
        public string CodTipoLlamada { get; set; }

        [Column(TypeName = "text")]
        public string Observacion1 { get; set; }

        [Column(TypeName = "text")]
        public string Observacion2 { get; set; }

        public DateTime? FechaLlamada { get; set; }

        [StringLength(255)]
        public string xUsrInsert { get; set; }

        [StringLength(20)]
        public string xDateInsert { get; set; }

        [StringLength(255)]
        public string xUsrUpdate { get; set; }

        [StringLength(20)]
        public string xDateUpdate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaNacimiento { get; set; }

        [StringLength(50)]
        public string TelefonoContacto { get; set; }

        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [StringLength(200)]
        public string EmailContacto { get; set; }
    }
}
