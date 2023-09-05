namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProveedoresInfonavit")]
    public partial class ProveedoresInfonavit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProveedoresInfonavit()
        {
            MedicalNetworkInfonavit = new HashSet<MedicalNetworkInfonavit>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreProveedor { get; set; }

        public int ClaveProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalNetworkInfonavit> MedicalNetworkInfonavit { get; set; }
    }
}
