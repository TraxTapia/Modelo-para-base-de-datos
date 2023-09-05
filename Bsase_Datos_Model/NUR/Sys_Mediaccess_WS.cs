namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_WS
    {
        [Key]
        public int IdWS { get; set; }

        [Required]
        [StringLength(255)]
        public string webservices { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public int Estatus { get; set; }
    }
}
