namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_TP_RemesasNova_Paso
    {
        [StringLength(50)]
        public string Remesa { get; set; }

        [StringLength(255)]
        public string metodoPago { get; set; }

        [StringLength(25)]
        public string ComprobanteNumCheque { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaRecepcionFactura { get; set; }

        [StringLength(50)]
        public string Nomina { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string Estatus { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(8000)]
        public string Nombre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaNace { get; set; }

        [StringLength(3)]
        public string sexo { get; set; }

        [StringLength(40)]
        public string parentesco { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaServicio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaPago { get; set; }

        [StringLength(50)]
        public string LugarSevicio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [StringLength(8000)]
        public string diagnostico { get; set; }

        [StringLength(8000)]
        public string PrestadorOrigen { get; set; }

        [StringLength(10)]
        public string ClavePrestadorCobra { get; set; }

        [StringLength(8000)]
        public string PrestadorCobra { get; set; }

        [StringLength(8000)]
        public string TipoGasto { get; set; }

        [StringLength(8000)]
        public string Especialidad { get; set; }

        [Key]
        [Column(Order = 2)]
        public double PrecioPublico { get; set; }

        public double? descuento { get; set; }

        [Key]
        [Column(Order = 3)]
        public double importe { get; set; }

        [Key]
        [Column(Order = 4)]
        public double IVA { get; set; }

        [Key]
        [Column(Order = 5)]
        public double ISR { get; set; }

        [Key]
        [Column(Order = 6)]
        public double retiva { get; set; }

        public double? impCedular { get; set; }

        [Key]
        [Column(Order = 7)]
        public double total { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [StringLength(30)]
        public string CodEan { get; set; }

        public string Medicamento { get; set; }

        [StringLength(23)]
        public string cantidad { get; set; }

        [StringLength(8000)]
        public string TipoProcedimiento { get; set; }

        [StringLength(200)]
        public string sucursal { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [StringLength(12)]
        public string secuenciamac { get; set; }

        [Column(TypeName = "date")]
        public DateTime? f_ingreso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? f_egreso { get; set; }

        [StringLength(10)]
        public string cve_empresa { get; set; }

        [StringLength(100)]
        public string empresa { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(4)]
        public string Aseguradora { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(11)]
        public string AseguradoraPorAfiliado { get; set; }

        [StringLength(10)]
        public string icodAsegurado { get; set; }

        [StringLength(50)]
        public string poliza { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int? Codempresa { get; set; }

        public int? codPymeColectivo { get; set; }
    }
}
