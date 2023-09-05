namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_TipoCuenta
    {
        [Key]
        [StringLength(10)]
        public string CodTipoCuenta { get; set; }

        [StringLength(50)]
        public string TipoCuenta { get; set; }
    }
}
