namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EnvioDocumentacionStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EnvioDocumentacionStatus()
        {
            DOCUMENTACIONENVIO = new HashSet<DOCUMENTACIONENVIO>();
            EnvioDocumentacionMovimientos = new HashSet<EnvioDocumentacionMovimientos>();
            NotificationsEnvioDocumentacion = new HashSet<NotificationsEnvioDocumentacion>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTACIONENVIO> DOCUMENTACIONENVIO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EnvioDocumentacionMovimientos> EnvioDocumentacionMovimientos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NotificationsEnvioDocumentacion> NotificationsEnvioDocumentacion { get; set; }
    }
}
