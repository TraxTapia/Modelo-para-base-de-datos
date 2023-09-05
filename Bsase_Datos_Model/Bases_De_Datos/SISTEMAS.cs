namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SISTEMAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SISTEMAS()
        {
            USUARIO_SISTEMAS = new HashSet<USUARIO_SISTEMAS>();
        }

        [Key]
        public int SIS_ID_SISTEMA { get; set; }

        [Required]
        [StringLength(100)]
        public string SISTEMA { get; set; }

        [StringLength(300)]
        public string DESCRIPCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO_SISTEMAS> USUARIO_SISTEMAS { get; set; }
    }
}
