namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Grupo_Plan
    {
        public int id { get; set; }

        public int? idGrupo { get; set; }

        public int? idPlanPreventivo { get; set; }
    }
}
