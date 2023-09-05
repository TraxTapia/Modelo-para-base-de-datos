namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoliosConceptos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoliosConceptos()
        {
            DetallesFoliosConceptos = new HashSet<DetallesFoliosConceptos>();
        }

        [Key]
        public int idFoliosConceptos { get; set; }

        public int idRol { get; set; }

        [Required]
        [StringLength(255)]
        public string descripcion { get; set; }

        public DateTime fecha_alta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetallesFoliosConceptos> DetallesFoliosConceptos { get; set; }
    }
}
