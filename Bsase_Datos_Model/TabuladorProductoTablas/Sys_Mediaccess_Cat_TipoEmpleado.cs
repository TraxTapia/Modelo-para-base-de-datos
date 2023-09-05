namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Cat_TipoEmpleado
    {
        [Key]
        public int idTipoEmpleado { get; set; }

        public int? codEmpresa { get; set; }

        [StringLength(20)]
        public string TipoEmpleado { get; set; }

        public int? NivelMinimo { get; set; }

        public int? NivelMaximo { get; set; }
    }
}
