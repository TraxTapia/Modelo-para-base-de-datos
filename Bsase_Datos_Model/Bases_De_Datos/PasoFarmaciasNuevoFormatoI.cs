namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PasoFarmaciasNuevoFormatoI")]
    public partial class PasoFarmaciasNuevoFormatoI
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(18)]
        public string consecutivo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime f_ocurrido { get; set; }

        [StringLength(2)]
        public string CodFormato { get; set; }

        [StringLength(10)]
        public string CodCopiaFormato { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
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
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 15)]
        public double total { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(10)]
        public string articulo { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cantidad { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(150)]
        public string Exadmin { get; set; }

        [StringLength(10)]
        public string ccostos { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [StringLength(50)]
        public string obs { get; set; }

        [StringLength(10)]
        public string estatus { get; set; }

        public double? PrecioCadena { get; set; }

        public double? Copago { get; set; }

        public double? ImporteDescuento { get; set; }

        [StringLength(20)]
        public string cve_provOrigen { get; set; }

        [StringLength(500)]
        public string DescripcionEAN { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }

        public int? SecuenciaMac { get; set; }

        [StringLength(50)]
        public string Id { get; set; }
    }
}
