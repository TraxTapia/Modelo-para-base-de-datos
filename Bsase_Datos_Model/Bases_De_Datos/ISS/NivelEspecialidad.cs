namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NivelEspecialidad")]
    public partial class NivelEspecialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NivelEspecialidad()
        {
            EspecialidadNegocio = new HashSet<EspecialidadNegocio>();
            EspecialidadxProducto = new HashSet<EspecialidadxProducto>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idNivel { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EspecialidadNegocio> EspecialidadNegocio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EspecialidadxProducto> EspecialidadxProducto { get; set; }
    }
}
