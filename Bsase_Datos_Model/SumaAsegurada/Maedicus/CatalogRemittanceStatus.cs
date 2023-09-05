namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatalogRemittanceStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogRemittanceStatus()
        {
            RemittancesAdministration = new HashSet<RemittancesAdministration>();
            RemittancesAdministrationMovements = new HashSet<RemittancesAdministrationMovements>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesAdministration> RemittancesAdministration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesAdministrationMovements> RemittancesAdministrationMovements { get; set; }
    }
}
