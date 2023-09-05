namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Facturas$")]
    public partial class Facturas_
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string no_fac { get; set; }

        public DateTime f_factura { get; set; }

        public DateTime f_recepcion { get; set; }

        public DateTime? f_ini_captura { get; set; }

        public DateTime? f_fin_captura { get; set; }

        public DateTime? f_envio_pago { get; set; }

        public DateTime? f_pago { get; set; }

        public DateTime? f_regresada { get; set; }

        [Required]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Required]
        [StringLength(10)]
        public string CodConcepto { get; set; }

        public double monto { get; set; }

        public double iva { get; set; }

        public double isr { get; set; }

        public double retiva { get; set; }

        public double? impCedular { get; set; }

        public double total { get; set; }

        [StringLength(25)]
        public string comprobante { get; set; }

        [StringLength(50)]
        public string sucursal { get; set; }

        [StringLength(40)]
        public string StickerRecepcion { get; set; }

        [StringLength(40)]
        public string StickerEnvio { get; set; }

        [StringLength(10)]
        public string CodControl { get; set; }

        [StringLength(2)]
        public string Metodo { get; set; }

        [StringLength(1000)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int secuenciaMac { get; set; }

        [StringLength(50)]
        public string cve_empresa { get; set; }

        public bool? reembolso { get; set; }

        public int? codReembolso { get; set; }

        [StringLength(20)]
        public string remesa { get; set; }

        public bool? codPrevencion { get; set; }

        public bool? EsRecibo { get; set; }

        [Column(TypeName = "xml")]
        public string xml { get; set; }
    }
}
