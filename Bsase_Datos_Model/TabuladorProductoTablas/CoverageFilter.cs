namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoverageFilter")]
    public partial class CoverageFilter
    {
        public int Id { get; set; }

        public int TipoGasto_Id { get; set; }

        public int Cobertura_Id { get; set; }

        public bool Active { get; set; }

        public virtual Coberturas_Ficha_Tecnica Coberturas_Ficha_Tecnica { get; set; }

        public virtual TipoGasto TipoGasto { get; set; }
    }
}
