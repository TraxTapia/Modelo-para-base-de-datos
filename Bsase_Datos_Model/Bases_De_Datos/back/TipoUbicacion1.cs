namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.TipoUbicacion")]
    public partial class TipoUbicacion1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoUbicacion1()
        {
            UbicacionAfiliado = new HashSet<UbicacionAfiliado>();
        }

        [Key]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoUbicacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionAfiliado> UbicacionAfiliado { get; set; }
    }
}
