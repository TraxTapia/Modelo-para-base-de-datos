namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillFileRecipientDetail")]
    public partial class tb_BillFileRecipientDetail
    {
        public int Id { get; set; }

        public int tb_BillFile_Id { get; set; }

        public int tb_BillFilerecipient_Id { get; set; }

        [Required]
        [StringLength(18)]
        public string Consecutive { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        public DateTime DateOccurred { get; set; }

        [StringLength(2)]
        public string FormatCode { get; set; }

        [StringLength(10)]
        public string FormatCopyCode { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyKey { get; set; }

        [Required]
        [StringLength(50)]
        public string AffiliateCode { get; set; }

        public int Correlative { get; set; }

        [Required]
        [StringLength(5)]
        public string Ciekey { get; set; }

        [Required]
        [StringLength(4)]
        public string SpecialityKey { get; set; }

        [Required]
        [StringLength(20)]
        public string ProcedureKey { get; set; }

        public double Amount { get; set; }

        public double Iva { get; set; }

        public double Isr { get; set; }

        public double Retiva { get; set; }

        public double? AmountCedular { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(10)]
        public string Article { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public double Quantity { get; set; }

        [Required]
        [StringLength(50)]
        public string TabKey { get; set; }

        [StringLength(150)]
        public string Exadmin { get; set; }

        [StringLength(10)]
        public string CostCenter { get; set; }

        [StringLength(50)]
        public string authorization { get; set; }

        public DateTime? ingressDate { get; set; }

        public DateTime? EgressDate { get; set; }

        [StringLength(200)]
        public string Subsidiary { get; set; }

        [StringLength(10)]
        public string OriginProvider { get; set; }

        [StringLength(50)]
        public string EmployeeType { get; set; }

        public double? PorCopago { get; set; }

        public double? ImpCopago { get; set; }

        public DateTime? Date { get; set; }

        public int? YearLP { get; set; }

        public double? Discount { get; set; }

        [StringLength(50)]
        public string Eligibility { get; set; }

        [StringLength(20)]
        public string Productkey { get; set; }

        public int? codPlan { get; set; }

        public int? codPymeColectivo { get; set; }

        public int? Codempresa { get; set; }

        [StringLength(255)]
        public string Num_Certificado { get; set; }

        [StringLength(20)]
        public string CPT { get; set; }

        [StringLength(5)]
        public string cve_cie_egreso { get; set; }

        [StringLength(5)]
        public string cve_cie_segdiag { get; set; }

        public int Operacion_ID { get; set; }

        public virtual tb_BillFileRecipient tb_BillFileRecipient { get; set; }
    }
}
