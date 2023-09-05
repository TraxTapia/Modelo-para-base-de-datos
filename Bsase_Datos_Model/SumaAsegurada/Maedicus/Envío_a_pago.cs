namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Envío a pago")]
    public partial class Envío_a_pago
    {
        [StringLength(50)]
        public string cve_empresa { get; set; }

        [StringLength(50)]
        public string remesa { get; set; }

        public int? secuenciaMac { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        [StringLength(18)]
        public string consecutivo { get; set; }

        [StringLength(2)]
        public string Metodo { get; set; }

        [StringLength(25)]
        public string comprobante { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        public double? dbo_Facturas_total { get; set; }

        [Column(TypeName = "text")]
        public string uuid { get; set; }

        public DateTime? f_recepcion { get; set; }

        public DateTime? f_envio_pago { get; set; }

        public DateTime? f_ocurrido { get; set; }

        [Column("Año Ocurrido")]
        public int? Año_Ocurrido { get; set; }

        public DateTime? f_pago { get; set; }

        public DateTime? f_factura { get; set; }

        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [StringLength(50)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(21)]
        public string EstatusAfiliado { get; set; }

        public int? Numbenef { get; set; }

        [StringLength(2)]
        public string cve_parent { get; set; }

        [StringLength(40)]
        public string Parentesco { get; set; }

        [StringLength(8000)]
        public string Nombre { get; set; }

        [Column("Nombre por apellidos")]
        [StringLength(302)]
        public string Nombre_por_apellidos { get; set; }

        public DateTime? F_nace { get; set; }

        [StringLength(3)]
        public string Sexo { get; set; }

        [StringLength(4)]
        public string dbo_Derhabs_CodEstado { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [Column("cve_prov (5)")]
        [StringLength(5)]
        public string cve_prov__5_ { get; set; }

        [StringLength(5)]
        public string dbo_Recursos_Medicos_CodEstado { get; set; }

        [StringLength(200)]
        public string RecursoMedico { get; set; }

        [StringLength(200)]
        public string nombreComercial { get; set; }

        [StringLength(200)]
        public string nombreFiscal { get; set; }

        [StringLength(200)]
        public string sucursal { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(6)]
        public string REG_FISCAL { get; set; }

        [StringLength(4)]
        public string cve_espec { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }

        public int? CodTipoGasto { get; set; }

        [StringLength(50)]
        public string TipoGasto { get; set; }

        [StringLength(5)]
        public string cve_cie { get; set; }

        [StringLength(255)]
        public string Diagnostico { get; set; }

        [Column("Monto antes del descuento")]
        public double? Monto_antes_del_descuento { get; set; }

        public double? Descuento { get; set; }

        [Column("% Descuento")]
        public double? C__Descuento { get; set; }

        public double? importe { get; set; }

        public double? iva { get; set; }

        [Column("%i Iva")]
        public double? C_i_Iva { get; set; }

        public double? isr { get; set; }

        public double? retiva { get; set; }

        public double? impCedular { get; set; }

        public double? dbo_Operacion_total { get; set; }

        public double? cantidad { get; set; }

        [StringLength(20)]
        public string CPT { get; set; }

        [Column("Descripción de CPT")]
        [StringLength(8000)]
        public string Descripción_de_CPT { get; set; }

        [StringLength(20)]
        public string cve_proc { get; set; }

        public int? CC_proc { get; set; }

        [StringLength(8000)]
        public string Medicamentos { get; set; }

        [Column("TIpo de procedimiento")]
        [StringLength(8000)]
        public string TIpo_de_procedimiento { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [StringLength(15)]
        public string provOrigen { get; set; }

        [Key]
        [Column("Proveedor Origen (NComercial)", Order = 2)]
        [StringLength(1)]
        public string Proveedor_Origen__NComercial_ { get; set; }

        [Column("Proveedor Origen (NFiscal)")]
        [StringLength(200)]
        public string Proveedor_Origen__NFiscal_ { get; set; }

        [Key]
        [Column("Origen de la Devolución", Order = 3)]
        [StringLength(1)]
        public string Origen_de_la_Devolución { get; set; }

        [Key]
        [Column("Motivo de Devolución", Order = 4)]
        [StringLength(1)]
        public string Motivo_de_Devolución { get; set; }

        public int? ID { get; set; }

        public int? ConsecPaseEsp { get; set; }

        [StringLength(50)]
        public string ElegOrigen { get; set; }
    }
}
