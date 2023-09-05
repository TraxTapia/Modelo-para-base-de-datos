namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Cat_Cuadros
    {
        [Key]
        public int IdCatCuadro { get; set; }

        [StringLength(300)]
        public string Dsc_Cuadro { get; set; }
    }
}
