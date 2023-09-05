namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sistema")]
    public partial class Sistema
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sistema()
        {
            NumeroRemesa = new HashSet<NumeroRemesa>();
        }

        [Key]
        [StringLength(5)]
        public string ClaveSistema { get; set; }

        [StringLength(40)]
        public string Descripcion { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        public DateTime? FechaActualizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NumeroRemesa> NumeroRemesa { get; set; }
    }
}
