namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_TP_Remesas_Paso
    {
        [StringLength(50)]
        public string Remesa { get; set; }

        [StringLength(255)]
        public string metodoPago { get; set; }

        [StringLength(50)]
        public string ComprobanteNumCheque { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaRecepcionFactura { get; set; }

        [StringLength(50)]
        public string Nomina { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }

        [StringLength(20)]
        public string Estatus { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaNace { get; set; }

        [StringLength(2)]
        public string sexo { get; set; }

        [StringLength(40)]
        public string parentesco { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaServicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaPago { get; set; }

        [StringLength(50)]
        public string LugarSevicio { get; set; }

        [StringLength(50)]
        public string cve_cie { get; set; }

        [StringLength(500)]
        public string diagnostico { get; set; }

        [StringLength(500)]
        public string PrestadorOrigen { get; set; }

        [StringLength(50)]
        public string ClavePrestadorCobra { get; set; }

        [StringLength(500)]
        public string PrestadorCobra { get; set; }

        [StringLength(500)]
        public string TipoGasto { get; set; }

        [StringLength(500)]
        public string Especialidad { get; set; }

        public double? PrecioPublico { get; set; }

        public double? descuento { get; set; }

        public double? importe { get; set; }

        public double? IVA { get; set; }

        public double? ISR { get; set; }

        public double? retiva { get; set; }

        public double? impCedular { get; set; }

        public double? total { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string CodEan { get; set; }

        [Column(TypeName = "ntext")]
        public string Medicamento { get; set; }

        [StringLength(50)]
        public string cantidad { get; set; }

        [StringLength(500)]
        public string TipoProcedimiento { get; set; }

        [StringLength(100)]
        public string sucursal { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [StringLength(12)]
        public string Elegibilidad { get; set; }

        [StringLength(20)]
        public string secuenciamac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? f_ingreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? f_egreso { get; set; }

        [StringLength(50)]
        public string cve_empresa { get; set; }

        [StringLength(100)]
        public string empresa { get; set; }

        [StringLength(50)]
        public string Aseguradora { get; set; }

        [StringLength(500)]
        public string AseguradoraPorAfiliado { get; set; }

        [StringLength(50)]
        public string icodAsegurado { get; set; }

        [StringLength(50)]
        public string poliza { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? Codempresa { get; set; }

        public int? codPymeColectivo { get; set; }

        [StringLength(20)]
        public string Codproducto { get; set; }

        [Column(TypeName = "text")]
        public string Observaciones { get; set; }

        public int? EstatusFactura { get; set; }

        public bool? BCarga { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FechaCarga { get; set; }
    }
}
