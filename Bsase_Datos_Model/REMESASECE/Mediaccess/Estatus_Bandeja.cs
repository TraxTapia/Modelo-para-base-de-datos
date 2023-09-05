namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Bandeja
    {
        [Key]
        [StringLength(10)]
        public string CodEstatusBandeja { get; set; }

        [StringLength(50)]
        public string EstatusBandeja { get; set; }
    }
}
