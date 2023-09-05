namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Parametros
    {
        public int id { get; set; }

        public int? diasAdicionales { get; set; }

        [StringLength(8000)]
        public string mensaje { get; set; }
    }
}
