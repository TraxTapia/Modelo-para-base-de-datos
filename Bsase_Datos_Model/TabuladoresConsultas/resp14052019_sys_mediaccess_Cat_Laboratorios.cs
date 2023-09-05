namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class resp14052019_sys_mediaccess_Cat_Laboratorios
    {
        [Key]
        public int IdLaboratorio { get; set; }

        [StringLength(300)]
        public string Nombre { get; set; }
    }
}
