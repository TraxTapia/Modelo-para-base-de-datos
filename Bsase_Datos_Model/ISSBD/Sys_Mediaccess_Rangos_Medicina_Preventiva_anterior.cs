namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Rangos_Medicina_Preventiva_anterior
    {
        public int Id { get; set; }

        public int? idPlanPreventivo { get; set; }

        public int? EdadMin { get; set; }

        public int? EdadMax { get; set; }

        [StringLength(1)]
        public string Genero { get; set; }
    }
}
