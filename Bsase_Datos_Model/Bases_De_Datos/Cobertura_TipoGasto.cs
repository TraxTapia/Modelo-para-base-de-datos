namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cobertura_TipoGasto
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Cobertura { get; set; }

        public int? CodTipoGasto { get; set; }
    }
}
