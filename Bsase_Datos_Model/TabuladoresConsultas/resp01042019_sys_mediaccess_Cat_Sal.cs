namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class resp01042019_sys_mediaccess_Cat_Sal
    {
        [Key]
        public int IdSal { get; set; }

        [StringLength(300)]
        public string DscSal { get; set; }
    }
}
