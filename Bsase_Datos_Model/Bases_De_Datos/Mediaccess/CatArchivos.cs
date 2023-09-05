namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatArchivos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatArchivos()
        {
            filesProveedores = new HashSet<filesProveedores>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<filesProveedores> filesProveedores { get; set; }
    }
}
