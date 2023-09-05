namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EspecialidadSASS")]
    public partial class EspecialidadSASS
    {
        [Key]
        [StringLength(255)]
        public string CodEspecialidad { get; set; }

        [StringLength(255)]
        public string CodTipoCuenta { get; set; }

        [StringLength(255)]
        public string Especialidad { get; set; }

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
    }
}
