namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusArchivo")]
    public partial class EstatusArchivo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusArchivo()
        {
            CargaArchivos = new HashSet<CargaArchivos>();
        }

        [Key]
        [StringLength(1)]
        public string CodEstatusArchivo { get; set; }

        [Column("EstatusArchivo")]
        [Required]
        [StringLength(25)]
        public string EstatusArchivo1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CargaArchivos> CargaArchivos { get; set; }
    }
}
