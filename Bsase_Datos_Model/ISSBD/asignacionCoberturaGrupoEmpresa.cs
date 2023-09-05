namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asignacionCoberturaGrupoEmpresa")]
    public partial class asignacionCoberturaGrupoEmpresa
    {
        public int? codPlan { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCobertura { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codGrupo { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string cve_empresa { get; set; }
    }
}
