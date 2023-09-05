namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sentido")]
    public partial class Sentido
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sentido()
        {
            LOTE = new HashSet<LOTE>();
        }

        [Key]
        [StringLength(1)]
        public string CodSentido { get; set; }

        [Column("Sentido")]
        [Required]
        [StringLength(25)]
        public string Sentido1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOTE> LOTE { get; set; }
    }
}
