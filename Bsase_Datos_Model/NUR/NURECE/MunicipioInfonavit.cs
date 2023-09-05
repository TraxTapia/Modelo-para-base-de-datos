namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MunicipioInfonavit")]
    public partial class MunicipioInfonavit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MunicipioInfonavit()
        {
            MedicalNetworkInfonavit = new HashSet<MedicalNetworkInfonavit>();
        }

        public int Id { get; set; }

        public int ClaveEF { get; set; }

        public int ClaveMunicipio { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreMunicipio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MedicalNetworkInfonavit> MedicalNetworkInfonavit { get; set; }
    }
}
