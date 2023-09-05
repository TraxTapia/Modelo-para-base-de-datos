namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeValidationRemittanceAdministration")]
    public partial class TypeValidationRemittanceAdministration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeValidationRemittanceAdministration()
        {
            RemittancesValidations = new HashSet<RemittancesValidations>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string TypeValidation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesValidations> RemittancesValidations { get; set; }
    }
}
