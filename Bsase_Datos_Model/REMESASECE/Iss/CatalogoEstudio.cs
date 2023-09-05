namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatalogoEstudio")]
    public partial class CatalogoEstudio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatalogoEstudio()
        {
            ClasificacionxProducto = new HashSet<ClasificacionxProducto>();
        }

        [Key]
        public int IdEstudio { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int IdCategoria { get; set; }

        public int IdSubcategoria { get; set; }

        [Required]
        [StringLength(50)]
        public string CveEstudio { get; set; }

        public virtual Categoria Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClasificacionxProducto> ClasificacionxProducto { get; set; }

        public virtual Subcategoria Subcategoria { get; set; }
    }
}
