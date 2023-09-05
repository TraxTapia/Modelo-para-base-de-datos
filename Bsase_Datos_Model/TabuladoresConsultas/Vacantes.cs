namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vacantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vacantes()
        {
            VacantesRequisitos = new HashSet<VacantesRequisitos>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Puesto { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(50)]
        public string Ubicacion { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Activo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuarioCreacion { get; set; }

        public DateTime? FechaDeshabilitacion { get; set; }

        [StringLength(50)]
        public string UsuarioDeshabilitacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VacantesRequisitos> VacantesRequisitos { get; set; }
    }
}
