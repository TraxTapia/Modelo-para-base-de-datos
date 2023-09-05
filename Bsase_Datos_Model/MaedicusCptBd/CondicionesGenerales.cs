namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CondicionesGenerales
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CondicionesGenerales()
        {
            CondicionesGeneralesDocuments = new HashSet<CondicionesGeneralesDocuments>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Agrupacion { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CondicionesGeneralesDocuments> CondicionesGeneralesDocuments { get; set; }
    }
}
