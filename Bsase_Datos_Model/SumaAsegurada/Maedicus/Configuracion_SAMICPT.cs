namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Configuracion_SAMICPT
    {
        public int Id { get; set; }

        public bool? CapturaComodin { get; set; }
    }
}
