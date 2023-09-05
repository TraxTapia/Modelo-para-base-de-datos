namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlazaInfonavit")]
    public partial class PlazaInfonavit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlazaInfonavit()
        {
            MedicalNetworkInfonavit = new HashSet<MedicalNetworkInfonavit>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string Plaza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalNetworkInfonavit> MedicalNetworkInfonavit { get; set; }
    }
}
