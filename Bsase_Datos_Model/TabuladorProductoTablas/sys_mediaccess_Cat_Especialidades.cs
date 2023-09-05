namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Cat_Especialidades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sys_mediaccess_Cat_Especialidades()
        {
            sys_mediaccess_Medicamentos = new HashSet<sys_mediaccess_Medicamentos>();
        }

        [Key]
        public int IdEspecialidad { get; set; }

        [StringLength(300)]
        public string DscEspecialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_mediaccess_Medicamentos> sys_mediaccess_Medicamentos { get; set; }
    }
}
