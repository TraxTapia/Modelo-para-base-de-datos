namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class resp15072019_sys_mediaccess_Cat_Grupos
    {
        [Key]
        public int IdGrupo { get; set; }

        [StringLength(300)]
        public string DscGrupo { get; set; }
    }
}
