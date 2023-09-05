namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empresassicas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string empresa { get; set; }

        public int? codPlan { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codEmpresa { get; set; }

        public int? codTabulador { get; set; }

        public int? requisitosReembolsos { get; set; }
    }
}
