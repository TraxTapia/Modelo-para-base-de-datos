namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediaccess_SAB_UsuarioWS
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(255)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Password { get; set; }

        public int Idaplicativo { get; set; }

        public bool status { get; set; }
    }
}
