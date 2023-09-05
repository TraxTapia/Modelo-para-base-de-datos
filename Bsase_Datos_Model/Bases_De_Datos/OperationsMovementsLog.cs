namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationsMovementsLog")]
    public partial class OperationsMovementsLog
    {
        public int Id { get; set; }

        public int Operation_Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(200)]
        public string User { get; set; }

        public double Importe { get; set; }

        public double IVA { get; set; }

        public double ISR { get; set; }

        public double RetencionIVA { get; set; }

        public double ImpuestoCedular { get; set; }

        public double Total { get; set; }

        public int? SecuenciaMAC { get; set; }

        public int TypeMovement_Id { get; set; }

        [StringLength(10)]
        public string Elegibility { get; set; }

        [StringLength(15)]
        public string Authorization { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(5)]
        public string CIE10 { get; set; }

        [StringLength(5)]
        public string CIE10_2 { get; set; }

        public DateTime? DateOcurred { get; set; }

        [StringLength(10)]
        public string OriginProvider { get; set; }

        [StringLength(50)]
        public string CodeAffiliate { get; set; }

        public int? Correlative { get; set; }

        public int? CodeEnterprise { get; set; }

        [StringLength(100)]
        public string Coverage { get; set; }

        [StringLength(300)]
        public string Concept { get; set; }

        [StringLength(100)]
        public string CodeConcept { get; set; }

        public decimal? AmountBeforeCopay { get; set; }

        public int? Quantity { get; set; }

        public int? TypeCopay { get; set; }

        public double? PercentCopay { get; set; }

        public double? AmountCopay { get; set; }

        public decimal? AmountAfterCopay { get; set; }

        public decimal? MediaccessPrice { get; set; }

        [StringLength(5)]
        public string CIE10_Egress { get; set; }

        public double? PercentDiscount { get; set; }

        public double? AmountDiscount { get; set; }

        public double? AmountAfterDiscount { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual Operacion Operacion { get; set; }

        public virtual TypeMovement TypeMovement { get; set; }
    }
}
