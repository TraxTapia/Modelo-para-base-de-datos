namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Medio_Recepcion
    {
        [Key]
        public int IdMedRecepcion { get; set; }

        [StringLength(200)]
        public string DscMedRecepcion { get; set; }
    }
}
