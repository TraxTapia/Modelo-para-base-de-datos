namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Configuracion_OpValidadorFolios
    {
        [Key]
        public int Id_Configuracion { get; set; }

        public bool? ValidaLenElegibilidad_TXT { get; set; }

        public bool? ValidaCIE_TXT { get; set; }

        public bool? GenerarRemesa { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ImporteMaximo_Remesa { get; set; }

        public bool? BloqueoEditar_GwFacturas { get; set; }

        public bool? Valida_FechaElegVsFocurrido { get; set; }

        [StringLength(10)]
        public string TipoRemesa_VF { get; set; }
    }
}
