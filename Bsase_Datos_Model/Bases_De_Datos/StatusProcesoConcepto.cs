namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StatusProcesoConcepto")]
    public partial class StatusProcesoConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatusProcesoConcepto()
        {
            RolStatusProcesoConcepto = new HashSet<RolStatusProcesoConcepto>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string CodConcepto { get; set; }

        [Required]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Required]
        [StringLength(80)]
        public string nombrePresentacion { get; set; }

        public short orden { get; set; }

        public virtual Concepto Concepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolStatusProcesoConcepto> RolStatusProcesoConcepto { get; set; }
    }
}
