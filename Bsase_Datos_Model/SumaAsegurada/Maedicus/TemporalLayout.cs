namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TemporalLayout")]
    public partial class TemporalLayout
    {
        [Key]
        public int idTemporalLayout { get; set; }

        public int statusValidacion { get; set; }

        [StringLength(2000)]
        public string observacion { get; set; }

        [Required]
        [StringLength(50)]
        public string numeroRemesa { get; set; }

        [Required]
        [StringLength(100)]
        public string metodoPago { get; set; }

        [Required]
        [StringLength(50)]
        public string comprobanteNumCheque { get; set; }

        [Required]
        [StringLength(50)]
        public string numeroFactura { get; set; }

        public DateTime? fechaRecepcion { get; set; }

        [Required]
        [StringLength(50)]
        public string nomina { get; set; }

        [Required]
        [StringLength(50)]
        public string Folio { get; set; }

        [Required]
        [StringLength(50)]
        public string estatus { get; set; }

        [StringLength(255)]
        public string estado { get; set; }

        [Required]
        [StringLength(255)]
        public string nombre { get; set; }

        public DateTime? fechaNaci { get; set; }

        [Required]
        [StringLength(3)]
        public string sexo { get; set; }

        [Required]
        [StringLength(50)]
        public string parentesco { get; set; }

        public DateTime? fechaServicio { get; set; }

        public DateTime? fechaPago { get; set; }

        [Required]
        [StringLength(255)]
        public string lugarSevicio { get; set; }

        [Required]
        [StringLength(10)]
        public string cveCie { get; set; }

        [Required]
        [StringLength(2000)]
        public string diagnostico { get; set; }

        [Required]
        [StringLength(255)]
        public string provOrigen { get; set; }

        [Required]
        [StringLength(50)]
        public string clavePrestadorCobra { get; set; }

        [Required]
        [StringLength(300)]
        public string prestadorCobra { get; set; }

        [Required]
        [StringLength(100)]
        public string tipoGasto { get; set; }

        [Required]
        [StringLength(255)]
        public string especialidad { get; set; }

        public decimal? precioPublico { get; set; }

        public decimal? descuento { get; set; }

        public decimal? importe { get; set; }

        public decimal? iva { get; set; }

        public decimal? isr { get; set; }

        public decimal? retiva { get; set; }

        public decimal? impCedular { get; set; }

        public decimal? total { get; set; }

        [Required]
        [StringLength(15)]
        public string RFC { get; set; }

        [Required]
        [StringLength(50)]
        public string codEan { get; set; }

        [Required]
        [StringLength(255)]
        public string medicamento { get; set; }

        public int cantidad { get; set; }

        [Required]
        [StringLength(255)]
        public string tipoProcedimiento { get; set; }

        [Required]
        [StringLength(255)]
        public string sucursal { get; set; }

        [Required]
        [StringLength(50)]
        public string autorizacion { get; set; }

        public int secuenciaMac { get; set; }

        public DateTime? fIngreso { get; set; }

        public DateTime? fEgreso { get; set; }

        [Required]
        [StringLength(10)]
        public string cveEmpresa { get; set; }

        [Required]
        [StringLength(255)]
        public string empresa { get; set; }

        [Required]
        [StringLength(255)]
        public string aseguradora { get; set; }

        [Required]
        [StringLength(255)]
        public string aseguradoraPorAfiliado { get; set; }

        [Required]
        [StringLength(100)]
        public string icodAsegurado { get; set; }

        [Required]
        [StringLength(100)]
        public string poliza { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(25)]
        public string codTabulador { get; set; }

        public int numeroBeneficiario { get; set; }

        public int? codempresa { get; set; }

        [Required]
        [StringLength(50)]
        public string codProducto { get; set; }

        [Required]
        [StringLength(10)]
        public string codConcepto { get; set; }

        [Required]
        [StringLength(50)]
        public string remesaSeguro { get; set; }

        public DateTime? fVigenciaAlta { get; set; }

        public DateTime? fVigenciaBaja { get; set; }

        public int codPymeColectivo { get; set; }

        [Required]
        [StringLength(30)]
        public string cveEmpresaOperacion { get; set; }

        [Required]
        [StringLength(80)]
        public string cveProc { get; set; }

        public int codPlan { get; set; }

        [Required]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        public decimal? ImpCopago { get; set; }

        public decimal? PorCopago { get; set; }

        public decimal? Precio_MAC_Unitario { get; set; }

        public decimal? Precio_MAC_Cantidad { get; set; }

        public decimal? Importe_Desc_Unitario { get; set; }

        public decimal? Importe_Desc_Cantidad { get; set; }

        public DateTime? f_ocurrido { get; set; }

        public bool Reembolso { get; set; }

        public bool SiniestroGracia { get; set; }

        [Required]
        [StringLength(50)]
        public string numeroFacturaSAPI { get; set; }

        public DateTime? fechaPagoFacturaSAPI { get; set; }

        public bool metromedica { get; set; }

        public DateTime? fVigenciaFin { get; set; }

        [Required]
        [StringLength(10)]
        public string ClaveEmisor { get; set; }

        public int CodTipoGasto { get; set; }

        public int CodEspecialidad { get; set; }

        public int ReglaCopagoValor { get; set; }

        [Required]
        [StringLength(5)]
        public string ReglaCopagoTipo { get; set; }

        [Required]
        [StringLength(4)]
        public string cve_espec { get; set; }

        public int PolizaReal { get; set; }

        [StringLength(50)]
        public string AfiliadoReal { get; set; }

        [Required]
        [StringLength(50)]
        public string StatusPoliza { get; set; }

        public DateTime? FechaCancelacion { get; set; }

        public DateTime? FechaAnulacion { get; set; }

        [Required]
        [StringLength(25)]
        public string Periodo { get; set; }

        public int NumeroEventos { get; set; }

        public int NumeroEventosMaximo { get; set; }

        public DateTime? InicioVigenciaReal { get; set; }

        public DateTime? FinVigenciaReal { get; set; }

        public bool EnviadoSiniestralidad { get; set; }

        public DateTime? FechaValidacionSat { get; set; }

        [StringLength(10)]
        public string ValidacionSat { get; set; }

        [StringLength(2000)]
        public string FoliosElegibilidad { get; set; }

        [StringLength(50)]
        public string CodAgente { get; set; }

        [Required]
        [StringLength(50)]
        public string Cve_ProbOrigen { get; set; }

        [Required]
        [StringLength(100)]
        public string Esp_ProbOrigen { get; set; }

        [Required]
        [StringLength(100)]
        public string FolioSASS { get; set; }

        [StringLength(50)]
        public string EtiquetaPago { get; set; }

        [StringLength(50)]
        public string TicketFarmacia { get; set; }

        [StringLength(50)]
        public string NUR { get; set; }

        public int? Certificado { get; set; }

        [StringLength(200)]
        public string ObservacionesEtiquetaPago { get; set; }
    }
}
