namespace Bsase_Datos_Model.ISSBD
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

        [StringLength(2550)]
        public string EstatusCuenta { get; set; }
    }
}
