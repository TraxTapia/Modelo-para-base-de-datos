namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Afiliado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estatus_Afiliado()
        {
            Derhabs = new HashSet<Derhabs>();
        }

        [Key]
        [StringLength(10)]
        public string CodEstatus { get; set; }

        [Required]
        [StringLength(50)]
        public string EstatusAfiliado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Derhabs> Derhabs { get; set; }
    }
}
