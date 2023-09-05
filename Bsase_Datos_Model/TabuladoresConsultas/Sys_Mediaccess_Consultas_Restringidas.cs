namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Consultas_Restringidas
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string codProducto { get; set; }

        public int? NivelConsulta { get; set; }

        public int? NumeroConsultas { get; set; }

        public bool? Activo { get; set; }
    }
}
