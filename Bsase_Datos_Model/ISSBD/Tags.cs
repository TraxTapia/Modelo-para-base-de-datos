namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tags
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tags()
        {
            Producto = new HashSet<Producto>();
        }

        [Key]
        public int IdTag { get; set; }

        [Required]
        [StringLength(50)]
        public string Tag { get; set; }

        [StringLength(100)]
        public string descripcionLarga { get; set; }

        public bool? activo { get; set; }

        public DateTime? fechacreacion { get; set; }

        public DateTime? fechadebaja { get; set; }

        public DateTime? fechamodificacion { get; set; }

        [StringLength(100)]
        public string creadopor { get; set; }

        [StringLength(100)]
        public string actualizadopor { get; set; }

        [StringLength(100)]
        public string eliminadopor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
