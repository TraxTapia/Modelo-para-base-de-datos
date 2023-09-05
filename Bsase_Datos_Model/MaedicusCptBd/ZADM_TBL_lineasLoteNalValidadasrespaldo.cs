namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZADM_TBL_lineasLoteNalValidadasrespaldo
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Folio { get; set; }

        [StringLength(15)]
        public string Cedula { get; set; }

        [StringLength(60)]
        public string Medico { get; set; }

        [StringLength(15)]
        public string Expediente { get; set; }

        [StringLength(2)]
        public string Parentesco { get; set; }

        [StringLength(2)]
        public string Consecutivo { get; set; }

        [StringLength(60)]
        public string Paciente { get; set; }

        public int? Clave { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string EAN { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Unidades { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(250)]
        public string FolioFactura { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string FolioMediaccess { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(250)]
        public string Cliente { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(250)]
        public string CodigoEAN { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(250)]
        public string CodigoEAN2 { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cantidad { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cantidad2 { get; set; }

        [Key]
        [Column(Order = 11, TypeName = "money")]
        public decimal PrecioUnitario { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "money")]
        public decimal PrecioBruto { get; set; }

        [Key]
        [Column(Order = 13)]
        public double PtjDescto { get; set; }

        [Key]
        [Column(Order = 14, TypeName = "money")]
        public decimal ImpteDescto { get; set; }

        [Key]
        [Column(Order = 15, TypeName = "money")]
        public decimal Subtotal { get; set; }

        [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal ImpteIVA { get; set; }

        [Key]
        [Column(Order = 17, TypeName = "money")]
        public decimal PrecioNeto { get; set; }

        public string Observaciones { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 20)]
        public DateTime Finsert { get; set; }
    }
}
