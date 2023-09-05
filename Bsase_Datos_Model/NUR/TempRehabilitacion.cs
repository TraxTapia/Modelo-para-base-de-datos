namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TempRehabilitacion")]
    public partial class TempRehabilitacion
    {
        [Key]
        [Column(Order = 0)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long consecutivo { get; set; }

        [StringLength(50)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "datetime2")]
        public DateTime f_ocurrido { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string CodFormato { get; set; }

        [StringLength(1)]
        public string CodCopiaFormato { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nomina { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string cve_cie { get; set; }

        [Key]
        [Column(Order = 9)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 10)]
        public string cve_proc { get; set; }

        [Key]
        [Column(Order = 11)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 12)]
        public double iva { get; set; }

        [Key]
        [Column(Order = 13)]
        public double isr { get; set; }

        [Key]
        [Column(Order = 14)]
        public byte retiva { get; set; }

        [Key]
        [Column(Order = 15)]
        public byte impCedular { get; set; }

        [Key]
        [Column(Order = 16)]
        public double total { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string articulo { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 19)]
        public byte cantidad { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(50)]
        public string CodTabulador { get; set; }

        [Key]
        [Column(Order = 21)]
        [StringLength(50)]
        public string Exadmin { get; set; }

        [Key]
        [Column(Order = 22)]
        [StringLength(50)]
        public string ccostos { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [Key]
        [Column(Order = 23, TypeName = "datetime2")]
        public DateTime f_ingreso { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "datetime2")]
        public DateTime f_egreso { get; set; }

        [StringLength(1)]
        public string sucursal { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int provOrigen { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tipoEmpleado { get; set; }

        [Key]
        [Column(Order = 27)]
        public byte porCopago { get; set; }

        [Key]
        [Column(Order = 28)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short impCopago { get; set; }

        [Key]
        [Column(Order = 29, TypeName = "datetime2")]
        public DateTime fecha { get; set; }

        [Key]
        [Column(Order = 30)]
        [StringLength(50)]
        public string anioLP { get; set; }

        [Key]
        [Column(Order = 31)]
        public byte descuento { get; set; }

        [Key]
        [Column(Order = 32)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(50)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 34)]
        public byte codPlan { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPymeColectivo { get; set; }

        [Key]
        [Column(Order = 36)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Codempresa { get; set; }

        [Key]
        [Column(Order = 37)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Num_Certificado { get; set; }

        public int? CPT { get; set; }

        [Key]
        [Column(Order = 38)]
        [StringLength(50)]
        public string cve_cie_egreso { get; set; }

        [Key]
        [Column(Order = 39)]
        [StringLength(50)]
        public string cve_cie_segdiag { get; set; }

        [Key]
        [Column(Order = 40)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 41)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        [Key]
        [Column(Order = 42)]
        public byte Visible { get; set; }
    }
}
