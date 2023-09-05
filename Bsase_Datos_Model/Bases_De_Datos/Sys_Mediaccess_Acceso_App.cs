namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Acceso_App
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Mediaccess_Acceso_App()
        {
            Sys_Mediaccess_Acceso_Perfil_no = new HashSet<Sys_Mediaccess_Acceso_Perfil_no>();
            Sys_Mediaccess_Acceso_Menu = new HashSet<Sys_Mediaccess_Acceso_Menu>();
            Sys_Mediaccess_Acceso_Usr = new HashSet<Sys_Mediaccess_Acceso_Usr>();
            Sys_Mediaccess_Acceso_Ctrl = new HashSet<Sys_Mediaccess_Acceso_Ctrl>();
            Sys_Mediaccess_Acceso_Perfil = new HashSet<Sys_Mediaccess_Acceso_Perfil>();
        }

        [Key]
        public int CodApp { get; set; }

        [Required]
        [StringLength(255)]
        public string Aplicacion { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public int Estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Acceso_Perfil_no> Sys_Mediaccess_Acceso_Perfil_no { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Acceso_Menu> Sys_Mediaccess_Acceso_Menu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Acceso_Usr> Sys_Mediaccess_Acceso_Usr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Acceso_Ctrl> Sys_Mediaccess_Acceso_Ctrl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Acceso_Perfil> Sys_Mediaccess_Acceso_Perfil { get; set; }
    }
}
