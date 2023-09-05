namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Acceso_Ctrl
    {
        public int CodApp { get; set; }

        public int Codperfil { get; set; }

        public int CodMenu { get; set; }

        public int CodMenuSub { get; set; }

        [Key]
        public int CodControl { get; set; }

        [Required]
        [StringLength(255)]
        public string Controls { get; set; }

        [Required]
        [StringLength(255)]
        public string ControlCtrl { get; set; }

        public virtual Sys_Mediaccess_Acceso_App Sys_Mediaccess_Acceso_App { get; set; }

        public virtual Sys_Mediaccess_Acceso_Menu Sys_Mediaccess_Acceso_Menu { get; set; }

        public virtual Sys_Mediaccess_Acceso_MenuSub Sys_Mediaccess_Acceso_MenuSub { get; set; }

        public virtual Sys_Mediaccess_Acceso_Perfil_no Sys_Mediaccess_Acceso_Perfil_no { get; set; }
    }
}
