namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_PaymentsFile")]
    public partial class tb_PaymentsFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_PaymentsFile()
        {
            tb_PaymentsFileRecipient = new HashSet<tb_PaymentsFileRecipient>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string File { get; set; }

        public int Records { get; set; }

        public int ProcessForRecords { get; set; }

        public DateTime ProcessDate { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public bool State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_PaymentsFileRecipient> tb_PaymentsFileRecipient { get; set; }
    }
}
