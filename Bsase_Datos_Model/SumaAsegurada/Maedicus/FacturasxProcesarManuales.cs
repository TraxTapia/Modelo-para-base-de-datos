namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FacturasxProcesarManuales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        public bool? Estatus { get; set; }
    }
}
