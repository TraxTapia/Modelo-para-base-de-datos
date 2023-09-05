namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_EdoCuenta
    {
        [Key]
        public int ident { get; set; }

        [Required]
        [StringLength(10)]
        public string CodEmpresa { get; set; }

        [Required]
        [StringLength(10)]
        public string codafiliado { get; set; }

        [Required]
        [StringLength(150)]
        public string correo { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
