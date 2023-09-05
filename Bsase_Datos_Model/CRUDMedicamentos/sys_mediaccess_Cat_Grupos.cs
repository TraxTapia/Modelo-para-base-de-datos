namespace Bsase_Datos_Model.CRUDMedicamentos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Cat_Grupos
    {
        [Key]
        public int IdGrupo { get; set; }

        [StringLength(300)]
        public string DscGrupo { get; set; }
    }
}
