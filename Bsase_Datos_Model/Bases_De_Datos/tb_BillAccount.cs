namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillAccount")]
    public partial class tb_BillAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_BillAccount()
        {
            tb_BillCatCargo = new HashSet<tb_BillCatCargo>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        public bool State { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public DateTime ProcessDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_BillCatCargo> tb_BillCatCargo { get; set; }
    }
}
