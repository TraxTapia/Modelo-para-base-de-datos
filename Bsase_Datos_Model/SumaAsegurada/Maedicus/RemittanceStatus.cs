namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemittanceStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RemittanceStatus()
        {
            ValidatedFiles = new HashSet<ValidatedFiles>();
            ValidatedFilesLog = new HashSet<ValidatedFilesLog>();
        }

        public int Id { get; set; }

        public int CodeStatus { get; set; }

        [Required]
        [StringLength(80)]
        public string Description { get; set; }

        public bool Visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidatedFiles> ValidatedFiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ValidatedFilesLog> ValidatedFilesLog { get; set; }
    }
}
