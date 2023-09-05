namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RespaldoCatSal20210112
    {
        [Key]
        public int IdSal { get; set; }

        [StringLength(700)]
        public string DscSal { get; set; }
    }
}
