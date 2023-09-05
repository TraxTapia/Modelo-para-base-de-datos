namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoberturaAddsyf")]
    public partial class CoberturaAddsyf
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string CodCobertura { get; set; }

        [Required]
        [StringLength(500)]
        public string DescripcionCobertura { get; set; }

        public int IdPoliza { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroPolizaUnico { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PorcentajeCopago { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SumaAseguradaMoneda { get; set; }

        public decimal? PRIMANETA_LOCAL { get; set; }

        public decimal? PRIMANETA_MONEDA { get; set; }

        [StringLength(50)]
        public string CODPLANPAGO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SUMAASEG_LOCAL { get; set; }
    }
}
