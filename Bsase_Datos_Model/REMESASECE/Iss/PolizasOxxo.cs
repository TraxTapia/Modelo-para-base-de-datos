namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolizasOxxo")]
    public partial class PolizasOxxo
    {
        [StringLength(50)]
        public string Poliza { get; set; }

        [StringLength(50)]
        public string centroCostos { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string SN_Activo { get; set; }

        [StringLength(20)]
        public string MaxFolioCerti { get; set; }

        [Key]
        [Column(Order = 1)]
        public int Autoid { get; set; }
    }
}
