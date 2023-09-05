namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("usuarioApp")]
    public partial class usuarioApp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [StringLength(50)]
        public string CodAfiliadoUnico { get; set; }

        [Required]
        [StringLength(2)]
        public string cambioPassword { get; set; }

        [StringLength(50)]
        public string correo { get; set; }

        [StringLength(15)]
        public string celular { get; set; }

        [StringLength(10)]
        public string correlativo { get; set; }
    }
}
