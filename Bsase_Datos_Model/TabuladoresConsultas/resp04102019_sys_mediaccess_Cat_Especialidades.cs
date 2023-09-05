namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class resp04102019_sys_mediaccess_Cat_Especialidades
    {
        [Key]
        public int IdEspecialidad { get; set; }

        [StringLength(300)]
        public string DscEspecialidad { get; set; }
    }
}
