namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoCobertura")]
    public partial class TipoCobertura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoCobertura()
        {
            ControlGasto = new HashSet<ControlGasto>();
            ResumenGasto = new HashSet<ResumenGasto>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(500)]
        public string descripcion { get; set; }

        public decimal limite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ControlGasto> ControlGasto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResumenGasto> ResumenGasto { get; set; }
    }
}
