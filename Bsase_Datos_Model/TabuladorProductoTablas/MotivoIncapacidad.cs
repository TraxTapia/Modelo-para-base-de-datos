namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoIncapacidad")]
    public partial class MotivoIncapacidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MotivoIncapacidad()
        {
            CertificadoIncapacidad = new HashSet<CertificadoIncapacidad>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoIncapacidad { get; set; }

        [Column("MotivoIncapacidad")]
        [StringLength(50)]
        public string MotivoIncapacidad1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CertificadoIncapacidad> CertificadoIncapacidad { get; set; }
    }
}
