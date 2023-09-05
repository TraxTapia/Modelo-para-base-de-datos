namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusFacturaRemesaSAT")]
    public partial class EstatusFacturaRemesaSAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusFacturaRemesaSAT()
        {
            FacturaRemesa = new HashSet<FacturaRemesa>();
        }

        [Key]
        [StringLength(15)]
        public string idEstatusFacturaRemesaSAT { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaRemesa> FacturaRemesa { get; set; }
    }
}
