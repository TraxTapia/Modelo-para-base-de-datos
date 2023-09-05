namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Cat_Especialidades
    {
        [Key]
        [Column(Order = 0)]
        public int IdEspecialidad { get; set; }

        [StringLength(300)]
        public string DscEspecialidad { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Activo { get; set; }
    }
}
