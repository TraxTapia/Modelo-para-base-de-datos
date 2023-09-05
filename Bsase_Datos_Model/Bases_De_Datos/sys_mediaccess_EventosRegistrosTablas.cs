namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_EventosRegistrosTablas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_mediaccess_EventosRegistrosTablas()
        {
            TabuladorProveedor_Log = new HashSet<TabuladorProveedor_Log>();
        }

        [Key]
        public int Codevento { get; set; }

        [Required]
        [StringLength(50)]
        public string Evento { get; set; }

        [StringLength(100)]
        public string DescripcionEvento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabuladorProveedor_Log> TabuladorProveedor_Log { get; set; }
    }
}
