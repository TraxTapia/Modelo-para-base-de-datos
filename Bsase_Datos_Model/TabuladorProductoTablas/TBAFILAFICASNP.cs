namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TBAFILAFICASNP")]
    public partial class TBAFILAFICASNP
    {
        public int? iConsecutivo { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iCodPlan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string vchCodProducto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iCodEmpresa { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string iCodAfiliado { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iNumeroBeneficiario { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iNumPoliza { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iCodParentesco { get; set; }

        [StringLength(10)]
        public string vchCodEstado { get; set; }

        public int? iCodPoblacion { get; set; }

        [StringLength(80)]
        public string vchColonia { get; set; }

        [StringLength(180)]
        public string vchDireccion { get; set; }

        [StringLength(5)]
        public string vchCodigoPostal { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(40)]
        public string vchNombres { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(40)]
        public string vchApellidoPaterno { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(40)]
        public string vchApellidoMaterno { get; set; }

        [StringLength(50)]
        public string vchEmail { get; set; }

        [StringLength(30)]
        public string vchTelefonoCasa { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(40)]
        public string vchSexo { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(10)]
        public string vchFechaNacimiento { get; set; }

        [StringLength(10)]
        public string vchFechaInicioServicio { get; set; }

        [StringLength(10)]
        public string vchFechaFinServicio { get; set; }

        public int? iCodAseguradora { get; set; }

        [StringLength(30)]
        public string iCodCobertura { get; set; }

        [StringLength(10)]
        public string vchFechaInicioSeg { get; set; }

        [StringLength(10)]
        public string vchFechaFinSeg { get; set; }

        public int? iCodEmpPymeColectividad { get; set; }

        [StringLength(2)]
        public string vchVip { get; set; }

        [StringLength(10)]
        public string vchFecAntiguedad { get; set; }

        [StringLength(1)]
        public string vchestatus { get; set; }

        [StringLength(30)]
        public string vchNumSocio { get; set; }

        public int? iCodAsegurado { get; set; }

        public int? iNumCerti { get; set; }

        [StringLength(20)]
        public string iClasificacion { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Valida { get; set; }

        public string MsgError { get; set; }
    }
}
