namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_TBL_COSTOS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAgrupado { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CPT { get; set; }

        public bool CodEstatus { get; set; }

        public double Costo { get; set; }

        public virtual CPT CPT1 { get; set; }
    }
}
