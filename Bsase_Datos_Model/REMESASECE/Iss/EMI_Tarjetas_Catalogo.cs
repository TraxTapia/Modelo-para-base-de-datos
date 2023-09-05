namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMI_Tarjetas_Catalogo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMI_Tarjetas_Catalogo()
        {
            EMI_Tarjetas_Producto = new HashSet<EMI_Tarjetas_Producto>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public bool Estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMI_Tarjetas_Producto> EMI_Tarjetas_Producto { get; set; }
    }
}
