namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturasNAFIN")]
    public partial class FacturasNAFIN
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
        public DateTime f_factura { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime f_recepcion { get; set; }

        public DateTime? f_ini_captura { get; set; }

        public DateTime? f_fin_captura { get; set; }

        public DateTime? f_envio_pago { get; set; }

        public DateTime? f_pago { get; set; }

        public DateTime? f_regresada { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string CodConcepto { get; set; }

        [Key]
        [Column(Order = 6)]
        public double monto { get; set; }

        [Key]
        [Column(Order = 7)]
        public double iva { get; set; }

        [Key]
        [Column(Order = 8)]
        public double isr { get; set; }

        [Key]
        [Column(Order = 9)]
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 10)]
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

        [StringLength(8000)]
        public string Observaciones { get; set; }

        [StringLength(100)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        [StringLength(50)]
        public string cve_empresa { get; set; }

        public bool? reembolso { get; set; }

        public int? codReembolso { get; set; }

        [StringLength(50)]
        public string remesa { get; set; }

        public bool? codPrevencion { get; set; }

        public bool? EsRecibo { get; set; }

        [StringLength(40)]
        public string uuid { get; set; }

        public double? descuento { get; set; }

        public double? copago { get; set; }

        public int? odenPago { get; set; }

        [StringLength(40)]
        public string LugarIngreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_val { get; set; }

        public TimeSpan? hora_val { get; set; }

        public double? monto_despues_copago { get; set; }
    }
}
