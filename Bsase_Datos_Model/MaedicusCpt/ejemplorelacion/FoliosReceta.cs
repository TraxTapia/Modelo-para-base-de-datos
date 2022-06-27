namespace Bsase_Datos_Model.MaedicusCpt.ejemplorelacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoliosReceta")]
    public partial class FoliosReceta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoliosReceta()
        {
            FoliosRemesa = new HashSet<FoliosRemesa>();
        }

        [Key]
        [StringLength(250)]
        public string FolioReceta { get; set; }

        public DateTime FechaCreacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoliosRemesa> FoliosRemesa { get; set; }
    }
}
