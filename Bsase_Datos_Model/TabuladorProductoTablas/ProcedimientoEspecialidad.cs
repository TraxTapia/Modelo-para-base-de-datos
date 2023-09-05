namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcedimientoEspecialidad")]
    public partial class ProcedimientoEspecialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcedimientoEspecialidad()
        {
            Tabulador = new HashSet<Tabulador>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string CodEspecialidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodProcedimeinto { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public virtual Especialidad Especialidad { get; set; }

        public virtual Procedimiento Procedimiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tabulador> Tabulador { get; set; }
    }
}
