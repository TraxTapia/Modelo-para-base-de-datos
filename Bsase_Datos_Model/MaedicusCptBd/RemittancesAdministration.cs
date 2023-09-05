namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RemittancesAdministration")]
    public partial class RemittancesAdministration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RemittancesAdministration()
        {
            RemittancesAdministrationDetails = new HashSet<RemittancesAdministrationDetails>();
            RemittancesAdministrationMovements = new HashSet<RemittancesAdministrationMovements>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Remittance { get; set; }

        public int RemittanceStatus_Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public virtual CatalogRemittanceStatus CatalogRemittanceStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesAdministrationDetails> RemittancesAdministrationDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesAdministrationMovements> RemittancesAdministrationMovements { get; set; }
    }
}
