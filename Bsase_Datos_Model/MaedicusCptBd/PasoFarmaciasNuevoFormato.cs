namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PasoFarmaciasNuevoFormato")]
    public partial class PasoFarmaciasNuevoFormato
    {
        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Required]
        [StringLength(18)]
        public string consecutivo { get; set; }

        [Required]
        [StringLength(20)]
        public string folio { get; set; }

        public DateTime f_ocurrido { get; set; }

        [StringLength(2)]
        public string CodFormato { get; set; }

        [StringLength(10)]
        public string CodCopiaFormato { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Nomina { get; set; }

        public int Numbenef { get; set; }

        [Required]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [Required]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Required]
        [StringLength(20)]
        public string cve_proc { get; set; }

        public double importe { get; set; }

        public double iva { get; set; }

        public double isr { get; set; }

        public double retiva { get; set; }

        public double? impCedular { get; set; }

        public double total { get; set; }

        [Required]
        [StringLength(10)]
        public string articulo { get; set; }

        [Required]
        [StringLength(25)]
        public string SegLogin { get; set; }

        public int cantidad { get; set; }

        [Required]
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

        public int Id { get; set; }
    }
}
