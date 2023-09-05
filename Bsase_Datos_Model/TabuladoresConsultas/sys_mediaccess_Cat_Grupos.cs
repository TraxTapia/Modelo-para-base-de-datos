namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Cat_Grupos
    {
        [Key]
        [Column(Order = 0)]
        public int IdGrupo { get; set; }

        [StringLength(300)]
        public string DscGrupo { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Activo { get; set; }
    }
}
