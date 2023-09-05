namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RegistrosManuales19082023Temporal
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cve_prov { get; set; }

        public string no_fac { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long consecutivo { get; set; }

        public string folio { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "datetime2")]
        public DateTime f_ocurrido { get; set; }

        public string CodFormato { get; set; }

        public string CodCopiaFormato { get; set; }

        [Key]
        [Column(Order = 3)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [Key]
        [Column(Order = 6)]
        public string cve_cie { get; set; }

        [Key]
        [Column(Order = 7)]
        public string cve_espec { get; set; }

        public string cve_proc { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal importe { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal iva { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal isr { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal retiva { get; set; }

        [Key]
        [Column(Order = 12)]
        public decimal impCedular { get; set; }

        [Key]
        [Column(Order = 13)]
        public decimal total { get; set; }

        [Key]
        [Column(Order = 14)]
        public string articulo { get; set; }

        [Key]
        [Column(Order = 15)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 16)]
        public byte cantidad { get; set; }

        public string CodTabulador { get; set; }

        [Key]
        [Column(Order = 17)]
        public string Exadmin { get; set; }

        public string ccostos { get; set; }

        public string autorizacion { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? f_ingreso { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? f_egreso { get; set; }

        public string sucursal { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int provOrigen { get; set; }

        public int? tipoEmpleado { get; set; }

        [Key]
        [Column(Order = 19)]
        public byte porCopago { get; set; }

        [Key]
        [Column(Order = 20)]
        public decimal impCopago { get; set; }

        [Key]
        [Column(Order = 21, TypeName = "datetime2")]
        public DateTime fecha { get; set; }

        public short? anioLP { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal descuento { get; set; }

        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 23)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 24)]
        public byte codPlan { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPymeColectivo { get; set; }

        [Key]
        [Column(Order = 26)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Codempresa { get; set; }

        [StringLength(50)]
        public string Num_Certificado { get; set; }

        public string CPT { get; set; }

        [Key]
        [Column(Order = 27)]
        public string cve_cie_egreso { get; set; }

        [Key]
        [Column(Order = 28)]
        public string cve_cie_segdiag { get; set; }

        [Key]
        [Column(Order = 29)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 30)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SecuenciaMac { get; set; }

        [Key]
        [Column(Order = 31)]
        public byte Visible { get; set; }
    }
}
