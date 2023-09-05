namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusPago")]
    public partial class EstatusPago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusPago()
        {
            FacturaFranquicia = new HashSet<FacturaFranquicia>();
            SSR = new HashSet<SSR>();
        }

        [Key]
        [StringLength(1)]
        public string CodEstatusPago { get; set; }

        [Column("EstatusPago")]
        [Required]
        [StringLength(25)]
        public string EstatusPago1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FacturaFranquicia> FacturaFranquicia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SSR> SSR { get; set; }
    }
}
