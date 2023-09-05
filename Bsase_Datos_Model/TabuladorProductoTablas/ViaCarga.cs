namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViaCarga")]
    public partial class ViaCarga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ViaCarga()
        {
            Autorizaciones = new HashSet<Autorizaciones>();
        }

        [Key]
        [StringLength(2)]
        public string CodViaCarga { get; set; }

        [Column("ViaCarga")]
        [Required]
        [StringLength(25)]
        public string ViaCarga1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autorizaciones> Autorizaciones { get; set; }
    }
}
