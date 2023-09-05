namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Especialidad")]
    public partial class Especialidad
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodTipoCuenta { get; set; }

        [Column("Especialidad")]
        [StringLength(255)]
        public string Especialidad1 { get; set; }

        [StringLength(255)]
        public string Cve_Especialidad { get; set; }

        [StringLength(255)]
        public string ConRetencion { get; set; }

        [StringLength(255)]
        public string SinRetencion { get; set; }

        [StringLength(50)]
        public string codhsbc { get; set; }

        [StringLength(1)]
        public string TipoCosto { get; set; }

        public bool Activo { get; set; }
    }
}
