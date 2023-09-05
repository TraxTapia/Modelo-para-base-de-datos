namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillFileRecipient")]
    public partial class tb_BillFileRecipient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_BillFileRecipient()
        {
            tb_BillFileRecipientDetail = new HashSet<tb_BillFileRecipientDetail>();
            tb_PaymentsFileRecipient = new HashSet<tb_PaymentsFileRecipient>();
        }

        public int Id { get; set; }

        public int tb_BillFile_Id { get; set; }

        public int ProviderKey { get; set; }

        [Required]
        [StringLength(255)]
        public string Bill { get; set; }

        [Required]
        [StringLength(255)]
        public string Remittance { get; set; }

        public int? Sequence { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyKey { get; set; }

        public DateTime DateSendPayment { get; set; }

        public DateTime BillingDate { get; set; }

        public DateTime ReceptionDate { get; set; }

        public DateTime? PaymentDate { get; set; }

        [Required]
        [StringLength(3)]
        public string BillKey { get; set; }

        [Required]
        [StringLength(10)]
        public string BillConcept { get; set; }

        public double Amount { get; set; }

        public double Iva { get; set; }

        public double Isr { get; set; }

        public double Retiva { get; set; }

        public double? AmountCedular { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(40)]
        public string Uuid { get; set; }

        [Required]
        [StringLength(50)]
        public string ProviderAccount { get; set; }

        [Required]
        [StringLength(50)]
        public string ProviderCode { get; set; }

        [StringLength(25)]
        public string comprobante { get; set; }

        [StringLength(2)]
        public string Metodo { get; set; }

        [StringLength(4000)]
        public string Observaciones { get; set; }

        public bool? StateBill { get; set; }

        [StringLength(30)]
        public string Package { get; set; }

        public string Message { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual tb_BillFile tb_BillFile { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BillFileRecipientDetail> tb_BillFileRecipientDetail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PaymentsFileRecipient> tb_PaymentsFileRecipient { get; set; }
    }
}
