namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Moneda")]
    public partial class Moneda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Moneda()
        {
            TipodeCambio = new HashSet<TipodeCambio>();
        }

        [Key]
        [StringLength(3)]
        public string CveMoneda { get; set; }

        [StringLength(10)]
        public string DescripcionMoneda { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipodeCambio> TipodeCambio { get; set; }
    }
}
