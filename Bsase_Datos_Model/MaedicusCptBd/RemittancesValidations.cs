namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemittancesValidations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RemittancesValidations()
        {
            RemittancesAdministrationDetailsErrors = new HashSet<RemittancesAdministrationDetailsErrors>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        public bool ApproveManually { get; set; }

        public int TypeValidation_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesAdministrationDetailsErrors> RemittancesAdministrationDetailsErrors { get; set; }

        public virtual TypeValidationRemittanceAdministration TypeValidationRemittanceAdministration { get; set; }
    }
}
