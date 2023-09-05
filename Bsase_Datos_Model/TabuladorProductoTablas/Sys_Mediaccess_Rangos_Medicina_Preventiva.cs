namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Rangos_Medicina_Preventiva
    {
        public int Id { get; set; }

        public int? idPlanPreventivo { get; set; }

        public int? EdadMin { get; set; }

        public int? EdadMax { get; set; }

        [StringLength(1)]
        public string Genero { get; set; }

        [StringLength(100)]
        public string codproducto { get; set; }

        [StringLength(50)]
        public string poliza { get; set; }

        public virtual Sys_Mediaccess_Cat_Medicina_Preventiva Sys_Mediaccess_Cat_Medicina_Preventiva { get; set; }
    }
}
