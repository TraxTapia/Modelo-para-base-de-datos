namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbHospicheckDetail")]
    public partial class tbHospicheckDetail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        [StringLength(255)]
        public string Episodio { get; set; }

        public int? ID { get; set; }

        public int? CVE_PROV { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHA_FACTURA { get; set; }

        [StringLength(255)]
        public string NO_FAC { get; set; }

        [StringLength(255)]
        public string FOLIO_RECETA { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHA_OCURRIDO { get; set; }

        [StringLength(255)]
        public string NOMINA { get; set; }

        public int? BENEFICIARIO { get; set; }

        [StringLength(5)]
        public string CIE_ING { get; set; }

        [StringLength(5)]
        public string CVE_CIE { get; set; }

        [StringLength(50)]
        public string CPT { get; set; }

        [StringLength(255)]
        public string CLAVE_INSUMO { get; set; }

        [StringLength(255)]
        public string DESCRIPCION_INSUMO { get; set; }

        public double? PORCENTAJE_DESCUENTO { get; set; }

        [Column(TypeName = "money")]
        public decimal? IMPORTE_DESCUENTO { get; set; }

        public int? CANTIDAD_INSUMOS { get; set; }

        public double? IMPORTE { get; set; }

        public double? SUBTOTAL { get; set; }

        public double? IVA { get; set; }

        public double? TASA { get; set; }

        public double? TOTAL { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHA_INGRESO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FECHA_EGRESO { get; set; }

        public int? CLAVE_MÉDICO { get; set; }

        public string NOMBRE_MEDICO { get; set; }

        [StringLength(255)]
        public string ELEGIBILIDAD { get; set; }

        [StringLength(255)]
        public string AUTORIZACIÓN { get; set; }

        public double? PORCOPAGO { get; set; }

        [Column(TypeName = "money")]
        public decimal? IMPCOPAGO { get; set; }

        [StringLength(255)]
        public string SEXO { get; set; }

        [StringLength(255)]
        public string CIUDAD { get; set; }

        [StringLength(255)]
        public string TIPO_SERVICO { get; set; }

        [Column(TypeName = "money")]
        public decimal? DEDUCIBLE_COPAGO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHA { get; set; }

        public string ERRORES { get; set; }
    }
}
