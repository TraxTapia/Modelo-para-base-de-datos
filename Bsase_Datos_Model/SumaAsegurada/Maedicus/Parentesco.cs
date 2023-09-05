namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Parentesco")]
    public partial class Parentesco
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Parentesco()
        {
            Derhabs = new HashSet<Derhabs>();
        }

        [Key]
        [StringLength(2)]
        public string cve_parent { get; set; }

        [Column("parentesco")]
        [Required]
        [StringLength(40)]
        public string parentesco1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Derhabs> Derhabs { get; set; }
    }
}
