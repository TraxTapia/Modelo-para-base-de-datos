namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EstatusRemesas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusRemesas()
        {
            Remesas = new HashSet<Remesas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdEstatusRemesa { get; set; }

        [StringLength(100)]
        public string EstatusRemesa { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public bool? Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remesas> Remesas { get; set; }
    }
}
