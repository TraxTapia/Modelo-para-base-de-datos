namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuarios
    {
        [Key]
        [StringLength(10)]
        public string cve_usuario { get; set; }

        [Required]
        [StringLength(10)]
        public string pwd_usuario { get; set; }

        [Required]
        [StringLength(80)]
        public string nom_usuario { get; set; }

        [Required]
        [StringLength(10)]
        public string permisos { get; set; }
    }
}
