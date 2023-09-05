namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RestitucionSumasAseguradas
    {
        [Key]
        public int IdRestitucion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_Aplicacion_Restitucion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_inicio_Restitucion { get; set; }

        [Column(TypeName = "date")]
        public DateTime Fecha_fin_Restitucion { get; set; }

        public bool Activo { get; set; }
    }
}
