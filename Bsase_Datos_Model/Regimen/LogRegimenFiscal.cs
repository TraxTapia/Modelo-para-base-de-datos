namespace Bsase_Datos_Model.Regimen
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogRegimenFiscal")]
    public partial class LogRegimenFiscal
    {
        public int Id { get; set; }

        public int cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string Regimen { get; set; }

        [Required]
        [StringLength(50)]
        public string uuid { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public DateTime Fecha { get; set; }
    }
}
