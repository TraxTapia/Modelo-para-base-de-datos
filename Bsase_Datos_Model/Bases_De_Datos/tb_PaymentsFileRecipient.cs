namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_PaymentsFileRecipient")]
    public partial class tb_PaymentsFileRecipient
    {
        public int Id { get; set; }

        public int tb_PaymentsFile_Id { get; set; }

        [StringLength(11)]
        public string Bill { get; set; }

        [Required]
        [StringLength(8)]
        public string ProcessDate { get; set; }

        [Required]
        [StringLength(8)]
        public string ProcessTime { get; set; }

        [Required]
        [StringLength(4)]
        public string Branch { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(5)]
        public string MovementType { get; set; }

        public double Amount { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(20)]
        public string Reference { get; set; }

        [Required]
        public string Concept { get; set; }

        [StringLength(50)]
        public string ProviderAccount { get; set; }

        public int? tb_BillFile_id { get; set; }

        public int? tb_BillFileRecipient_id { get; set; }

        public bool? State { get; set; }

        public virtual tb_BillFile tb_BillFile { get; set; }

        public virtual tb_BillFileRecipient tb_BillFileRecipient { get; set; }

        public virtual tb_PaymentsFile tb_PaymentsFile { get; set; }
    }
}
