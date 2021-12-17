namespace Bsase_Datos_Model.DBContextISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EspecialidadNegocio")]
    public partial class EspecialidadNegocio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EspecialidadNegocio()
        {
            EspecialidadxProducto = new HashSet<EspecialidadxProducto>();
        }

        [Key]
        [StringLength(10)]
        public string CodigoEspecialidad { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }

        [StringLength(4)]
        public string ClaveEspecialidad { get; set; }

        public int? idNivel { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        public DateTime? FechaBaja { get; set; }

        public virtual NivelEspecialidad NivelEspecialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EspecialidadxProducto> EspecialidadxProducto { get; set; }
    }
}
