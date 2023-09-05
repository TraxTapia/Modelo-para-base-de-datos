namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObservacionesConcepto")]
    public partial class ObservacionesConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ObservacionesConcepto()
        {
            ObservacionConcepto_Operacion = new HashSet<ObservacionConcepto_Operacion>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }

        public bool AbsorbeAseguradora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservacionConcepto_Operacion> ObservacionConcepto_Operacion { get; set; }
    }
}
