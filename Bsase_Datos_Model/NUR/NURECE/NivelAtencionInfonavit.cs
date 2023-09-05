namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NivelAtencionInfonavit")]
    public partial class NivelAtencionInfonavit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NivelAtencionInfonavit()
        {
            MedicalNetworkInfonavit = new HashSet<MedicalNetworkInfonavit>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string NivelAtencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalNetworkInfonavit> MedicalNetworkInfonavit { get; set; }
    }
}
