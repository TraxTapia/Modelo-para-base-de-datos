namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Facturas_HWS
    {
        [Key]
        public int id_hws { get; set; }

        [StringLength(25)]
        public string no_fac { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_val { get; set; }

        public TimeSpan? hora_val { get; set; }

        public double? monto_despues_copago { get; set; }

        [StringLength(25)]
        public string num_episodio { get; set; }

        [StringLength(25)]
        public string edo_cuenta { get; set; }
    }
}
