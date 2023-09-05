namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TemServiciosDentales
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long consecutivo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "datetime2")]
        public DateTime f_ocurrido { get; set; }

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
        public long Nomina { get; set; }

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

        [StringLength(50)]
        public string cve_proc { get; set; }

        [Key]
        [Column(Order = 10)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 11)]
        public double iva { get; set; }

        public byte? isr { get; set; }

        [Key]
        [Column(Order = 12)]
        public byte retiva { get; set; }

        [Key]
        [Column(Order = 13)]
        public byte impCedular { get; set; }

        [Key]
        [Column(Order = 14)]
        public double total { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string articulo { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 17)]
        public byte cantidad { get; set; }

        [StringLength(50)]
        public string CodTabulador { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(50)]
        public string Exadmin { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string ccostos { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(50)]
        public string autorizacion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? f_ingreso { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? f_egreso { get; set; }

        [StringLength(1)]
        public string sucursal { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int provOrigen { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int tipoEmpleado { get; set; }

        [Key]
        [Column(Order = 23)]
        public byte porCopago { get; set; }

        public byte? impCopago { get; set; }

        [Key]
        [Column(Order = 24, TypeName = "datetime2")]
        public DateTime fecha { get; set; }

        public short? anioLP { get; set; }

        [Key]
        [Column(Order = 25)]
        public byte descuento { get; set; }

        [Key]
        [Column(Order = 26)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 27)]
        [StringLength(50)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 28)]
        public byte codPlan { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPymeColectivo { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Codempresa { get; set; }

        [Key]
        [Column(Order = 31)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Num_Certificado { get; set; }

        [StringLength(1)]
        public string CPT { get; set; }

        [Key]
        [Column(Order = 32)]
        [StringLength(50)]
        public string cve_cie_egreso { get; set; }

        [Key]
        [Column(Order = 33)]
        [StringLength(50)]
        public string cve_cie_segdiag { get; set; }

        [Key]
        [Column(Order = 34)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 35)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        [Key]
        [Column(Order = 36)]
        public byte Visible { get; set; }
    }
}
