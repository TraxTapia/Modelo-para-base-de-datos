namespace Bsase_Datos_Model.SASSV2.BDSASE
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

        public bool Activo { get; set; }
    }
}
