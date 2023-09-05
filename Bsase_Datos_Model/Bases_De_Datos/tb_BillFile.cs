namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillFile")]
    public partial class tb_BillFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_BillFile()
        {
            tb_BillFileRecipient = new HashSet<tb_BillFileRecipient>();
            tb_BillStateLog = new HashSet<tb_BillStateLog>();
            tb_PaymentsFileRecipient = new HashSet<tb_PaymentsFileRecipient>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string File { get; set; }

        public int Sequence { get; set; }

        public double Amount { get; set; }

        public DateTime ProcessDate { get; set; }

        public string Interbank { get; set; }

        public string SameBank { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public int tb_BillState_Id { get; set; }

        public virtual tb_BillState tb_BillState { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BillFileRecipient> tb_BillFileRecipient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BillStateLog> tb_BillStateLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PaymentsFileRecipient> tb_PaymentsFileRecipient { get; set; }
    }
}
