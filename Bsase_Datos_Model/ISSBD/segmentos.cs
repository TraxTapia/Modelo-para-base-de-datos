namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.segmentos")]
    public partial class segmentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public segmentos()
        {
            ventasSistemaCartera = new HashSet<ventasSistemaCartera>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codSegmento { get; set; }

        [StringLength(50)]
        public string segmento { get; set; }

        [StringLength(1)]
        public string codEstatus { get; set; }

        public DateTime? fechaCarga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventasSistemaCartera> ventasSistemaCartera { get; set; }
    }
}
