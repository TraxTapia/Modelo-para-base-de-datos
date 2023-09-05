namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_TipoConteo
    {
        [Key]
        public int codTipoConteo { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }
    }
}
