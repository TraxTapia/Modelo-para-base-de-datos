namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Cuenta
    {
        [Key]
        [StringLength(1)]
        public string CodEstatusCuenta { get; set; }

        [StringLength(255)]
        public string EstatusCuenta { get; set; }
    }
}
