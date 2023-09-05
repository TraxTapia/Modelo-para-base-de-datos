namespace Bsase_Datos_Model.REMESASECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoRemesa")]
    public partial class TipoRemesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoRemesa()
        {
            Remesas = new HashSet<Remesas>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoRemesa { get; set; }

        [Column("TipoRemesa")]
        [StringLength(80)]
        public string TipoRemesa1 { get; set; }

        public DateTime? FechaCreacion { get; set; }

        [Column("Fecha Baja")]
        public DateTime? Fecha_Baja { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        public bool? Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remesas> Remesas { get; set; }
    }
}
