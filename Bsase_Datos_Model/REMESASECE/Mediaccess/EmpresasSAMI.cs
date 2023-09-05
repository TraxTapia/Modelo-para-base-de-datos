namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresasSAMI")]
    public partial class EmpresasSAMI
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

        public int? codEmpresa { get; set; }

        public int? codTabulador { get; set; }
    }
}
