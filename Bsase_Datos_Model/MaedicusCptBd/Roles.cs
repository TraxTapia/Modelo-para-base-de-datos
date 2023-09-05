namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Roles
    {
        [Key]
        public int RolId { get; set; }

        [Required]
        [StringLength(45)]
        public string Rol { get; set; }

        public int ModuloId { get; set; }
    }
}
