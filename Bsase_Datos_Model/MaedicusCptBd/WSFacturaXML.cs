namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSFacturaXML")]
    public partial class WSFacturaXML
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WSFacturaXML()
        {
            concepto_WSFacturaXML = new HashSet<concepto_WSFacturaXML>();
        }

        [Key]
        public int factura_ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Proveedor { get; set; }

        [StringLength(200)]
        public string folio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha { get; set; }

        public TimeSpan? hora { get; set; }

        [Column(TypeName = "text")]
        public string sello { get; set; }

        [Column(TypeName = "text")]
        public string formaDePago { get; set; }

        [Column(TypeName = "text")]
        public string noCertificado { get; set; }

        [Column(TypeName = "text")]
        public string certificado { get; set; }

        [Column(TypeName = "text")]
        public string condicionesDePago { get; set; }

        public double? subTotal { get; set; }

        public double? descuento { get; set; }

        public double? total { get; set; }

        [Column(TypeName = "text")]
        public string tipoDeComprobante { get; set; }

        [Column(TypeName = "text")]
        public string metodoDePago { get; set; }

        [Column(TypeName = "text")]
        public string LugarExpedicion { get; set; }

        [StringLength(200)]
        public string NumCtaPago { get; set; }

        [StringLength(50)]
        public string rfcEmisor { get; set; }

        [Column(TypeName = "text")]
        public string nombreEmisor { get; set; }

        [Column(TypeName = "text")]
        public string calleFiscal { get; set; }

        [Column(TypeName = "text")]
        public string noExteriorFiscal { get; set; }

        [Column(TypeName = "text")]
        public string noInteriorFiscal { get; set; }

        [Column(TypeName = "text")]
        public string coloniaFiscal { get; set; }

        [Column(TypeName = "text")]
        public string localidadFiscal { get; set; }

        [Column(TypeName = "text")]
        public string municipioFiscal { get; set; }

        [Column(TypeName = "text")]
        public string estadoFiscal { get; set; }

        [Column(TypeName = "text")]
        public string paisFiscal { get; set; }

        [StringLength(50)]
        public string codigoPostalFiscal { get; set; }

        [Column(TypeName = "text")]
        public string calleExpedido { get; set; }

        [StringLength(50)]
        public string noExteriorExpedido { get; set; }

        [StringLength(50)]
        public string noInteriorExpedido { get; set; }

        [Column(TypeName = "text")]
        public string coloniaExpedido { get; set; }

        [Column(TypeName = "text")]
        public string localidadExpedido { get; set; }

        [Column(TypeName = "text")]
        public string municipioExpedido { get; set; }

        [Column(TypeName = "text")]
        public string estadoExpedido { get; set; }

        [Column(TypeName = "text")]
        public string paisExpedido { get; set; }

        [StringLength(50)]
        public string codigoPostalExpedido { get; set; }

        [Column(TypeName = "text")]
        public string regimenFiscalEmisor { get; set; }

        [StringLength(50)]
        public string rfcReceptor { get; set; }

        [Column(TypeName = "text")]
        public string nombreReceptor { get; set; }

        [Column(TypeName = "text")]
        public string calleReceptor { get; set; }

        [StringLength(50)]
        public string noExteriorReceptor { get; set; }

        [StringLength(50)]
        public string noInteriorReceptor { get; set; }

        [Column(TypeName = "text")]
        public string coloniaReceptor { get; set; }

        [Column(TypeName = "text")]
        public string localidadReceptor { get; set; }

        [Column(TypeName = "text")]
        public string municipioReceptor { get; set; }

        [Column(TypeName = "text")]
        public string estadoReceptor { get; set; }

        [Column(TypeName = "text")]
        public string paisReceptor { get; set; }

        [StringLength(50)]
        public string codigoPostalReceptor { get; set; }

        public double? importe { get; set; }

        [StringLength(20)]
        public string impuesto { get; set; }

        public double? tasa { get; set; }

        public double? iva { get; set; }

        public double? isr { get; set; }

        public double? impuestosLocales { get; set; }

        [StringLength(40)]
        public string UUID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaTimbrado { get; set; }

        public TimeSpan? horaTimbrado { get; set; }

        [Column(TypeName = "text")]
        public string selloCFD { get; set; }

        [Column(TypeName = "text")]
        public string noCertificadoSAT { get; set; }

        [Column(TypeName = "text")]
        public string selloSAT { get; set; }

        [StringLength(2)]
        public string estatus { get; set; }

        [Column(TypeName = "text")]
        public string url { get; set; }

        [StringLength(50)]
        public string serie { get; set; }

        public DateTime? fechaInsert { get; set; }

        [StringLength(10)]
        public string lugardeexpedicion { get; set; }

        [StringLength(40)]
        public string UUIDRelacionado { get; set; }

        [StringLength(5)]
        public string TipoRelacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<concepto_WSFacturaXML> concepto_WSFacturaXML { get; set; }
    }
}
