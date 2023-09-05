namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Especialidad")]
    public partial class Especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Especialidad()
        {
            ProcedimientoEspecialidad = new HashSet<ProcedimientoEspecialidad>();
            SubEspecialidad = new HashSet<SubEspecialidad>();
        }

        [Key]
        [StringLength(3)]
        public string CodEspecialidad { get; set; }

        [Column("Especialidad")]
        [Required]
        [StringLength(100)]
        public string Especialidad1 { get; set; }

        [Required]
        [StringLength(10)]
        public string ConRetencion { get; set; }

        [Required]
        [StringLength(10)]
        public string SinRetencion { get; set; }

        public int CodTipoGasto { get; set; }

        public virtual TipoGasto TipoGasto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedimientoEspecialidad> ProcedimientoEspecialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubEspecialidad> SubEspecialidad { get; set; }
    }
}
