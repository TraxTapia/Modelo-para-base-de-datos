namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_cat_producto_rangos_Medicina_Preventiva
    {
        public int id { get; set; }

        public int? idCatalogo { get; set; }

        public int? idRango { get; set; }

        public DateTime? FechaAlta { get; set; }

        [StringLength(50)]
        public string UsrAlta { get; set; }

        public int? Activo { get; set; }
    }
}
