namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebModules
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebModules()
        {
            OperationsDuplicated = new HashSet<OperationsDuplicated>();
        }

        public int Id { get; set; }

        public int Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool Visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsDuplicated> OperationsDuplicated { get; set; }
    }
}
