namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas()
        {
            CaptureChangeLog = new HashSet<CaptureChangeLog>();
            CaptureChangeLog1 = new HashSet<CaptureChangeLog>();
            controlElegibilidadesAfiliados = new HashSet<controlElegibilidadesAfiliados>();
            CopayApplied = new HashSet<CopayApplied>();
            derhabsesp = new HashSet<derhabsesp>();
            tb_BillFileRecipient = new HashSet<tb_BillFileRecipient>();
            controlFoliosCapturados = new HashSet<controlFoliosCapturados>();
            facturas_cambio = new HashSet<facturas_cambio>();
            FacturasLOG = new HashSet<FacturasLOG>();
            facturasNotaCredito = new HashSet<facturasNotaCredito>();
            HistoricoContador_Especiales_Bancomext = new HashSet<HistoricoContador_Especiales_Bancomext>();
            Layout_SHF_Entrega = new HashSet<Layout_SHF_Entrega>();
            Layout_SHF_fac = new HashSet<Layout_SHF_fac>();
            Layout_SHF_Ope = new HashSet<Layout_SHF_Ope>();
            movimientosFacturas = new HashSet<movimientosFacturas>();
            OP_Factura_Remesas = new HashSet<OP_Factura_Remesas>();
            OP_Factura_Remesas_Devueltas = new HashSet<OP_Factura_Remesas_Devueltas>();
            OP_PEMEX_Recepcion = new HashSet<OP_PEMEX_Recepcion>();
            OP_VF_BANRURAL_Carga = new HashSet<OP_VF_BANRURAL_Carga>();
            OP_VF_Bansefi_Carga = new HashSet<OP_VF_Bansefi_Carga>();
            OpeDetalleST = new HashSet<OpeDetalleST>();
            Operacion = new HashSet<Operacion>();
            Operacion_Compl = new HashSet<Operacion_Compl>();
            Operacion_Log = new HashSet<Operacion_Log>();
            RecursosPemex = new HashSet<RecursosPemex>();
            sustitucionFacturas = new HashSet<sustitucionFacturas>();
            tb_TF_Fac = new HashSet<tb_TF_Fac>();
            tb_TF_FacDet = new HashSet<tb_TF_FacDet>();
            Transferencias_TB_Facturas = new HashSet<Transferencias_TB_Facturas>();
            Transferencias_TB_LogFacturas = new HashSet<Transferencias_TB_LogFacturas>();
            Transferencias_TB_PagosLOG = new HashSet<Transferencias_TB_PagosLOG>();
            FacturaTypeService = new HashSet<FacturaTypeService>();
            OperationsMovementsLog = new HashSet<OperationsMovementsLog>();
        }

        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
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

        [StringLength(200)]
        public string StickerRecepcion { get; set; }

        [StringLength(200)]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaptureChangeLog> CaptureChangeLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CaptureChangeLog> CaptureChangeLog1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<controlElegibilidadesAfiliados> controlElegibilidadesAfiliados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CopayApplied> CopayApplied { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<derhabsesp> derhabsesp { get; set; }

        public virtual Empresas Empresas { get; set; }

        public virtual EstatusFactura EstatusFactura { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BillFileRecipient> tb_BillFileRecipient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<controlFoliosCapturados> controlFoliosCapturados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturas_cambio> facturas_cambio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturasLOG> FacturasLOG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturasNotaCredito> facturasNotaCredito { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoricoContador_Especiales_Bancomext> HistoricoContador_Especiales_Bancomext { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Layout_SHF_Entrega> Layout_SHF_Entrega { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Layout_SHF_fac> Layout_SHF_fac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Layout_SHF_Ope> Layout_SHF_Ope { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movimientosFacturas> movimientosFacturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_Factura_Remesas> OP_Factura_Remesas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_Factura_Remesas_Devueltas> OP_Factura_Remesas_Devueltas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_PEMEX_Recepcion> OP_PEMEX_Recepcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_VF_BANRURAL_Carga> OP_VF_BANRURAL_Carga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_VF_Bansefi_Carga> OP_VF_Bansefi_Carga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeDetalleST> OpeDetalleST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion> Operacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion_Compl> Operacion_Compl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion_Log> Operacion_Log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecursosPemex> RecursosPemex { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sustitucionFacturas> sustitucionFacturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TF_Fac> tb_TF_Fac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TF_FacDet> tb_TF_FacDet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencias_TB_Facturas> Transferencias_TB_Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencias_TB_LogFacturas> Transferencias_TB_LogFacturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transferencias_TB_PagosLOG> Transferencias_TB_PagosLOG { get; set; }

        public virtual Recursos_Medicos Recursos_Medicos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaTypeService> FacturaTypeService { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsMovementsLog> OperationsMovementsLog { get; set; }
    }
}
