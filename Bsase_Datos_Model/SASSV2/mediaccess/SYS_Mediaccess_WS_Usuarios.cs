namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediaccess_WS_Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required]
        [StringLength(255)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Password { get; set; }

        public int IdWS { get; set; }

        public int Idaplicativo { get; set; }

        public bool status { get; set; }
    }
}
