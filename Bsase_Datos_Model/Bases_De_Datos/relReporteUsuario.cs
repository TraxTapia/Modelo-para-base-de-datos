namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("relReporteUsuario")]
    public partial class relReporteUsuario
    {
        [Key]
        public int idReporteUsuario { get; set; }

        public int idReporte { get; set; }

        [Required]
        [StringLength(50)]
        public string cve_usuario { get; set; }
    }
}
