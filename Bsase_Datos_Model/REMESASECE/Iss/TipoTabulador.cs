namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoTabulador")]
    public partial class TipoTabulador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoTabulador()
        {
            Procedimiento = new HashSet<Procedimiento>();
        }

        [Key]
        [StringLength(3)]
        public string CodTipoTabulador { get; set; }

        [Column("TipoTabulador")]
        [Required]
        [StringLength(50)]
        public string TipoTabulador1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimiento> Procedimiento { get; set; }
    }
}
