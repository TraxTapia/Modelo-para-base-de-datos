namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Acceso_MenuSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Mediaccess_Acceso_MenuSub()
        {
            Sys_Mediaccess_Acceso_Ctrl = new HashSet<Sys_Mediaccess_Acceso_Ctrl>();
        }

        public int CodMenu { get; set; }

        [Key]
        public int CodMenuSub { get; set; }

        [Required]
        [StringLength(255)]
        public string MenuSub { get; set; }

        [Required]
        [StringLength(255)]
        public string ControlSub { get; set; }

        public int Estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Acceso_Ctrl> Sys_Mediaccess_Acceso_Ctrl { get; set; }

        public virtual Sys_Mediaccess_Acceso_Menu Sys_Mediaccess_Acceso_Menu { get; set; }
    }
}
